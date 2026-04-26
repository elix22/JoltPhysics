// Implementation of jolt_helper.h.  All Jolt headers are confined to this TU.

#include "jolt_helper.h"

#ifdef __clang__
#  pragma clang diagnostic push
#  pragma clang diagnostic ignored "-Weverything"
#elif defined(__GNUC__)
#  pragma GCC diagnostic push
#  pragma GCC diagnostic ignored "-Wall"
#  pragma GCC diagnostic ignored "-Wextra"
#endif

#include <Jolt/Jolt.h>
#include <Jolt/RegisterTypes.h>
#include <Jolt/Core/Factory.h>
#include <Jolt/Core/TempAllocator.h>
#include <Jolt/Core/JobSystemThreadPool.h>
#include <Jolt/Physics/PhysicsSettings.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Collision/Shape/BoxShape.h>
#include <Jolt/Physics/Collision/Shape/SphereShape.h>
#include <Jolt/Physics/Collision/Shape/CapsuleShape.h>
#include <Jolt/Physics/Collision/Shape/CylinderShape.h>
#include <Jolt/Physics/Collision/Shape/RotatedTranslatedShape.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/BodyActivationListener.h>
#include <Jolt/Physics/Constraints/FixedConstraint.h>
#include <Jolt/Physics/Constraints/DistanceConstraint.h>
#include <Jolt/Physics/Constraints/PointConstraint.h>
#include <Jolt/Physics/Constraints/HingeConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Geometry/AABox.h>

#ifdef __clang__
#  pragma clang diagnostic pop
#elif defined(__GNUC__)
#  pragma GCC diagnostic pop
#endif

#include <thread>
#include <unordered_map>
#include <vector>
#include <cstdarg>
#include <cstdio>

using namespace JPH;

// ---------------------------------------------------------------------------
// Layer constants (two-layer default setup: 0=NonMoving, 1=Moving)
// ---------------------------------------------------------------------------
static constexpr ObjectLayer LAYER_NON_MOVING = 0;
static constexpr ObjectLayer LAYER_MOVING     = 1;
static constexpr BroadPhaseLayer BP_NON_MOVING(0);
static constexpr BroadPhaseLayer BP_MOVING(1);

class DefaultBPLayer final : public BroadPhaseLayerInterface {
    BroadPhaseLayer mMap[2];
public:
    DefaultBPLayer() { mMap[0] = BP_NON_MOVING; mMap[1] = BP_MOVING; }
    uint GetNumBroadPhaseLayers() const override { return 2; }
    BroadPhaseLayer GetBroadPhaseLayer(ObjectLayer l) const override { return mMap[l]; }
};
class DefaultObjVsBP final : public ObjectVsBroadPhaseLayerFilter {
public:
    bool ShouldCollide(ObjectLayer l1, BroadPhaseLayer l2) const override {
        return l1 == LAYER_NON_MOVING ? (l2 == BP_MOVING) : true;
    }
};
class DefaultObjVsObj final : public ObjectLayerPairFilter {
public:
    bool ShouldCollide(ObjectLayer l1, ObjectLayer l2) const override {
        return l1 == LAYER_NON_MOVING ? (l2 == LAYER_MOVING) : true;
    }
};

// ---------------------------------------------------------------------------
// Library init/shutdown reference counting
// ---------------------------------------------------------------------------
static int g_jolt_refs = 0;
static void jolt_trace(const char* fmt, ...) {
    va_list args;
    va_start(args, fmt);
    vprintf(fmt, args);
    va_end(args);
    putchar('\n');
}
#ifdef JPH_ENABLE_ASSERTS
static bool jolt_assert_failed(const char* expr, const char* msg,
                                const char* file, unsigned int line) {
    fprintf(stderr, "JPH Assert failed: %s (%s) at %s:%u\n",
            expr, msg ? msg : "", file, line);
    return true;
}
#endif

static void jolt_lib_acquire() {
    if (g_jolt_refs++ == 0) {
        Trace = jolt_trace;
        JPH_IF_ENABLE_ASSERTS(AssertFailed = jolt_assert_failed;)
        RegisterDefaultAllocator();
        Factory::sInstance = new Factory();
        RegisterTypes();
    }
}
static void jolt_lib_release() {
    if (--g_jolt_refs == 0) {
        UnregisterTypes();
        delete Factory::sInstance;
        Factory::sInstance = nullptr;
    }
}

// ---------------------------------------------------------------------------
// Accept-all layer filters (used by ActivateBodiesInAABox)
// ---------------------------------------------------------------------------
class AcceptAllBPLayerFilter final : public BroadPhaseLayerFilter {
public:
    bool ShouldCollide(BroadPhaseLayer) const override { return true; }
};
class AcceptAllObjLayerFilter final : public ObjectLayerFilter {
public:
    bool ShouldCollide(ObjectLayer) const override { return true; }
};
static const AcceptAllBPLayerFilter  s_acceptAllBP;
static const AcceptAllObjLayerFilter s_acceptAllObj;

// ---------------------------------------------------------------------------
// Math helpers
// ---------------------------------------------------------------------------
static inline Vec3  toJph(const JoltVec3f& v)  { return Vec3(v.x, v.y, v.z); }
static inline Vec3  toJph3(const JoltVec3& v)   { return Vec3((float)v.x,(float)v.y,(float)v.z); }
static inline RVec3 toJphR(const JoltVec3& v)   { return RVec3(v.x, v.y, v.z); }
static inline Quat  toJphQ(const JoltQuat& q)   { return Quat(q.x, q.y, q.z, q.w); }
static inline JoltVec3f fromVec3(Vec3 v)  { return JoltVec3f(v.GetX(), v.GetY(), v.GetZ()); }
static inline JoltVec3  fromRVec3(RVec3 v){ return JoltVec3((double)v.GetX(),(double)v.GetY(),(double)v.GetZ()); }
static inline JoltQuat  fromQuat(Quat q)  { return JoltQuat(q.GetX(), q.GetY(), q.GetZ(), q.GetW()); }

static JoltMat44 fromMat44(const Mat44& m) {
    JoltMat44 r;
    Vec4 c0 = m.GetColumn4(0), c1 = m.GetColumn4(1), c2 = m.GetColumn4(2), c3 = m.GetColumn4(3);
    r.e00=c0.GetX(); r.e10=c0.GetY(); r.e20=c0.GetZ(); r.e30=c0.GetW();
    r.e01=c1.GetX(); r.e11=c1.GetY(); r.e21=c1.GetZ(); r.e31=c1.GetW();
    r.e02=c2.GetX(); r.e12=c2.GetY(); r.e22=c2.GetZ(); r.e32=c2.GetW();
    r.e03=c3.GetX(); r.e13=c3.GetY(); r.e23=c3.GetZ(); r.e33=c3.GetW();
    return r;
}

static JoltRMat44 fromRMat44(const RMat44& m) {
    JoltRMat44 r;
    Vec3 c0=m.GetColumn3(0), c1=m.GetColumn3(1), c2=m.GetColumn3(2);
    r.e00=c0.GetX(); r.e10=c0.GetY(); r.e20=c0.GetZ();
    r.e01=c1.GetX(); r.e11=c1.GetY(); r.e21=c1.GetZ();
    r.e02=c2.GetX(); r.e12=c2.GetY(); r.e22=c2.GetZ();
    RVec3 t = m.GetTranslation();
    r.tx=(double)t.GetX(); r.ty=(double)t.GetY(); r.tz=(double)t.GetZ();
    return r;
}


// ---------------------------------------------------------------------------
// JoltVec3f
// ---------------------------------------------------------------------------
JoltVec3f::JoltVec3f() : x(0), y(0), z(0) {}
JoltVec3f::JoltVec3f(float x_, float y_, float z_) : x(x_), y(y_), z(z_) {}

// ---------------------------------------------------------------------------
// JoltVec3
// ---------------------------------------------------------------------------
JoltVec3::JoltVec3() : x(0), y(0), z(0) {}
JoltVec3::JoltVec3(double x_, double y_, double z_) : x(x_), y(y_), z(z_) {}

// ---------------------------------------------------------------------------
// JoltQuat
// ---------------------------------------------------------------------------
JoltQuat::JoltQuat() : x(0), y(0), z(0), w(1) {}
JoltQuat::JoltQuat(float x_, float y_, float z_, float w_)
    : x(x_), y(y_), z(z_), w(w_) {}
JoltQuat JoltQuat::Identity() { return JoltQuat(0, 0, 0, 1); }
bool JoltQuat::IsNormalized(float tolerance) const {
    return toJphQ(*this).IsNormalized(tolerance);
}
JoltVec3f JoltQuat::RotateAxisX() const { return fromVec3(toJphQ(*this).RotateAxisX()); }
JoltVec3f JoltQuat::RotateAxisY() const { return fromVec3(toJphQ(*this).RotateAxisY()); }
JoltVec3f JoltQuat::RotateAxisZ() const { return fromVec3(toJphQ(*this).RotateAxisZ()); }

// ---------------------------------------------------------------------------
// JoltBodyID
// ---------------------------------------------------------------------------
JoltBodyID::JoltBodyID() : value(BodyID().GetIndexAndSequenceNumber()) {}
bool JoltBodyID::IsValid()   const { return !BodyID(value).IsInvalid(); }
bool JoltBodyID::IsInvalid() const { return  BodyID(value).IsInvalid(); }

// ---------------------------------------------------------------------------
// JoltConstraintID
// ---------------------------------------------------------------------------
JoltConstraintID::JoltConstraintID() : value(0xFFFFFFFF) {}
bool JoltConstraintID::IsValid() const { return value != 0xFFFFFFFF; }

// ---------------------------------------------------------------------------
// JoltShape base
// ---------------------------------------------------------------------------
JoltShape::JoltShape()       : mHandle(nullptr), mOwning(false) {}
JoltShape::~JoltShape()      { Release(); }
bool JoltShape::IsValid() const { return mHandle != nullptr; }
void* JoltShape::getHandle() const { return mHandle; }
void JoltShape::Release() {
    if (mOwning && mHandle) {
        static_cast<Shape*>(mHandle)->Release();
        mHandle  = nullptr;
        mOwning  = false;
    }
}

// Derived-class helper: store an already-AddRef'd shape (shape->AddRef already called by caller).
#define SHAPE_INIT(shape_ref_c) \
    do { (shape_ref_c)->AddRef(); \
         mHandle = (void*)(shape_ref_c).GetPtr(); \
         mOwning = true; } while(0)

// ---------------------------------------------------------------------------
// JoltBoxShape
// ---------------------------------------------------------------------------
JoltBoxShape::JoltBoxShape(double hx, double hy, double hz, float cr) {
    BoxShapeSettings ss(Vec3((float)hx, (float)hy, (float)hz), cr);
    ss.SetEmbedded();
    ShapeRefC s = ss.Create().Get(); SHAPE_INIT(s);
}
JoltBoxShape::JoltBoxShape(double hx, double hy, double hz)
    : JoltBoxShape(hx, hy, hz, 0.05f) {}

// ---------------------------------------------------------------------------
// JoltSphereShape
// ---------------------------------------------------------------------------
JoltSphereShape::JoltSphereShape(float radius) {
    ShapeRefC s = new SphereShape(radius); SHAPE_INIT(s);
}

// ---------------------------------------------------------------------------
// JoltCapsuleShape
// ---------------------------------------------------------------------------
JoltCapsuleShape::JoltCapsuleShape(float halfHeight, float radius) {
    CapsuleShapeSettings ss(halfHeight, radius);
    ss.SetEmbedded();
    ShapeRefC s = ss.Create().Get(); SHAPE_INIT(s);
}

// ---------------------------------------------------------------------------
// JoltCylinderShape
// ---------------------------------------------------------------------------
JoltCylinderShape::JoltCylinderShape(float halfHeight, float radius, float cr) {
    CylinderShapeSettings ss(halfHeight, radius, cr);
    ss.SetEmbedded();
    ShapeRefC s = ss.Create().Get(); SHAPE_INIT(s);
}
JoltCylinderShape::JoltCylinderShape(float halfHeight, float radius)
    : JoltCylinderShape(halfHeight, radius, 0.05f) {}

// ---------------------------------------------------------------------------
// JoltRotatedTranslatedShape
// ---------------------------------------------------------------------------
JoltRotatedTranslatedShape::JoltRotatedTranslatedShape(
    JoltShape* inner,
    double posX, double posY, double posZ,
    float qx, float qy, float qz, float qw)
{
    const Shape* innerPtr = static_cast<const Shape*>(inner->getHandle());
    RotatedTranslatedShapeSettings ss(
        Vec3((float)posX, (float)posY, (float)posZ),
        Quat(qx, qy, qz, qw),
        innerPtr);
    ss.SetEmbedded();
    ShapeRefC s = ss.Create().Get(); SHAPE_INIT(s);
}

#undef SHAPE_INIT

// ---------------------------------------------------------------------------
// JoltBodyCreationSettings
// ---------------------------------------------------------------------------
struct BCSHandle {
    BodyCreationSettings settings;
};

JoltBodyCreationSettings::JoltBodyCreationSettings(
    JoltShape* shape,
    double posX, double posY, double posZ,
    float qx, float qy, float qz, float qw,
    int motionType,
    unsigned int objectLayer)
{
    auto* h = new BCSHandle();
    EMotionType mt = static_cast<EMotionType>((int)motionType);
    h->settings = BodyCreationSettings(
        static_cast<Shape*>(shape->getHandle()),
        RVec3(posX, posY, posZ),
        Quat(qx, qy, qz, qw),
        mt,
        (ObjectLayer)objectLayer);
    mHandle = h;
}

JoltBodyCreationSettings::JoltBodyCreationSettings(
    JoltShape* shape,
    double posX, double posY, double posZ,
    int motionType,
    unsigned int objectLayer)
    : JoltBodyCreationSettings(shape, posX, posY, posZ,
                                0, 0, 0, 1,
                                motionType, objectLayer) {}

JoltBodyCreationSettings::~JoltBodyCreationSettings() {
    delete static_cast<BCSHandle*>(mHandle);
}

static BodyCreationSettings& bcs(JoltBodyCreationSettings* s) {
    return static_cast<BCSHandle*>(s->mHandle)->settings;
}

void JoltBodyCreationSettings::SetPosition(double x, double y, double z) {
    bcs(this).mPosition = RVec3(x, y, z);
}
void JoltBodyCreationSettings::SetRotation(float qx, float qy, float qz, float qw) {
    bcs(this).mRotation = Quat(qx, qy, qz, qw);
}
void JoltBodyCreationSettings::SetLinearVelocity(float vx, float vy, float vz) {
    bcs(this).mLinearVelocity = Vec3(vx, vy, vz);
}
void JoltBodyCreationSettings::SetAngularVelocity(float vx, float vy, float vz) {
    bcs(this).mAngularVelocity = Vec3(vx, vy, vz);
}
void JoltBodyCreationSettings::SetFriction(float f) {
    bcs(this).mFriction = f;
}
void JoltBodyCreationSettings::SetRestitution(float r) {
    bcs(this).mRestitution = r;
}
void JoltBodyCreationSettings::SetGravityFactor(float f) {
    bcs(this).mGravityFactor = f;
}
void JoltBodyCreationSettings::SetIsSensor(bool s) {
    bcs(this).mIsSensor = s;
}
void JoltBodyCreationSettings::SetObjectLayer(unsigned int layer) {
    bcs(this).mObjectLayer = (ObjectLayer)layer;
}

// ---------------------------------------------------------------------------
// JoltPhysicsSystem::Impl
// ---------------------------------------------------------------------------
struct JoltPhysicsSystem::Impl {
    DefaultBPLayer     bpLayer;
    DefaultObjVsBP     objVsBP;
    DefaultObjVsObj    objVsObj;
    TempAllocatorImpl  tempAlloc;
    JobSystemThreadPool jobSystem;
    PhysicsSystem      physics;

    // Constraint registry (pointer -> sequential ID)
    std::unordered_map<uint32_t, Ref<Constraint>> constraints;
    uint32_t nextConstraintID = 1;

    Impl(uint32_t maxBodies, uint32_t maxBodyPairs, uint32_t maxContacts)
        : tempAlloc(64 * 1024 * 1024)
        , jobSystem(cMaxPhysicsJobs, cMaxPhysicsBarriers,
                    std::max(1, (int)std::thread::hardware_concurrency() - 1))
    {
        physics.Init(maxBodies, 0, maxBodyPairs, maxContacts,
                     bpLayer, objVsBP, objVsObj);
    }

    BodyInterface& bi()       { return physics.GetBodyInterface(); }
    const BodyInterface& bi() const { return physics.GetBodyInterface(); }

    JoltBodyID toJoltID(BodyID id) {
        JoltBodyID r; r.value = id.GetIndexAndSequenceNumber(); return r;
    }
    BodyID fromJoltID(JoltBodyID id) const { return BodyID(id.value); }

    JoltConstraintID addConstraint(Constraint* c) {
        uint32_t id = nextConstraintID++;
        physics.AddConstraint(c);
        constraints[id] = c;
        JoltConstraintID r; r.value = id; return r;
    }
    Constraint* getConstraint(JoltConstraintID id) {
        auto it = constraints.find(id.value);
        return it != constraints.end() ? it->second.GetPtr() : nullptr;
    }
    void removeConstraint(JoltConstraintID id) {
        auto it = constraints.find(id.value);
        if (it != constraints.end()) {
            physics.RemoveConstraint(it->second);
            constraints.erase(it);
        }
    }
};

// ---------------------------------------------------------------------------
// JoltPhysicsSystem
// ---------------------------------------------------------------------------
// ---------------------------------------------------------------------------
// JoltSoftBodyCreationSettings helpers (needed by JoltPhysicsSystem below)
// ---------------------------------------------------------------------------
struct SBCSHandle { SoftBodyCreationSettings settings; };
static inline SoftBodyCreationSettings& sbcs_soft(JoltSoftBodyCreationSettings* s) {
    return static_cast<SBCSHandle*>(s->mHandle)->settings;
}

// ---------------------------------------------------------------------------
JoltPhysicsSystem::JoltPhysicsSystem()
    : JoltPhysicsSystem(65536, 65536, 65536) {}

JoltPhysicsSystem::JoltPhysicsSystem(
    unsigned int maxBodies,
    unsigned int maxBodyPairs,
    unsigned int maxContactConstraints)
{
    jolt_lib_acquire();
    mImpl = new Impl(maxBodies, maxBodyPairs, maxContactConstraints);
}

JoltPhysicsSystem::~JoltPhysicsSystem() {
    delete mImpl;
    jolt_lib_release();
}

void JoltPhysicsSystem::SetGravity(double x, double y, double z) {
    mImpl->physics.SetGravity(Vec3((float)x, (float)y, (float)z));
}
JoltVec3 JoltPhysicsSystem::GetGravity() const {
    return fromRVec3(RVec3(mImpl->physics.GetGravity()));
}
void JoltPhysicsSystem::Update(float deltaTime, int collisionSteps) {
    mImpl->physics.Update(deltaTime, collisionSteps,
                          &mImpl->tempAlloc, &mImpl->jobSystem);
}
void JoltPhysicsSystem::OptimizeBroadPhase() {
    mImpl->physics.OptimizeBroadPhase();
}

JoltBodyID JoltPhysicsSystem::CreateAndAddBody(
    JoltBodyCreationSettings* settings, int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    BodyID id = mImpl->bi().CreateAndAddBody(bcs(settings), a);
    return mImpl->toJoltID(id);
}

void JoltPhysicsSystem::RemoveBody(JoltBodyID id) {
    mImpl->bi().RemoveBody(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::DestroyBody(JoltBodyID id) {
    mImpl->bi().DestroyBody(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::RemoveAndDestroyBody(JoltBodyID id) {
    mImpl->bi().RemoveBody(mImpl->fromJoltID(id));
    mImpl->bi().DestroyBody(mImpl->fromJoltID(id));
}

JoltVec3 JoltPhysicsSystem::GetBodyPosition(JoltBodyID id) const {
    return fromRVec3(mImpl->bi().GetCenterOfMassPosition(mImpl->fromJoltID(id)));
}
JoltQuat JoltPhysicsSystem::GetBodyRotation(JoltBodyID id) const {
    return fromQuat(mImpl->bi().GetRotation(mImpl->fromJoltID(id)));
}
JoltVec3f JoltPhysicsSystem::GetBodyLinearVelocity(JoltBodyID id) const {
    return fromVec3(mImpl->bi().GetLinearVelocity(mImpl->fromJoltID(id)));
}
JoltVec3f JoltPhysicsSystem::GetBodyAngularVelocity(JoltBodyID id) const {
    return fromVec3(mImpl->bi().GetAngularVelocity(mImpl->fromJoltID(id)));
}
bool JoltPhysicsSystem::IsBodyActive(JoltBodyID id) const {
    return mImpl->bi().IsActive(mImpl->fromJoltID(id));
}

void JoltPhysicsSystem::SetBodyPosition(
    JoltBodyID id, double x, double y, double z, int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    mImpl->bi().SetPosition(mImpl->fromJoltID(id), RVec3(x,y,z), a);
}
void JoltPhysicsSystem::SetBodyRotation(
    JoltBodyID id, float qx, float qy, float qz, float qw, int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    mImpl->bi().SetRotation(mImpl->fromJoltID(id), Quat(qx,qy,qz,qw), a);
}
void JoltPhysicsSystem::SetBodyPositionAndRotation(
    JoltBodyID id,
    double x, double y, double z,
    float qx, float qy, float qz, float qw,
    int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    mImpl->bi().SetPositionAndRotation(
        mImpl->fromJoltID(id), RVec3(x,y,z), Quat(qx,qy,qz,qw), a);
}
void JoltPhysicsSystem::SetBodyLinearVelocity(JoltBodyID id, float vx, float vy, float vz) {
    mImpl->bi().SetLinearVelocity(mImpl->fromJoltID(id), Vec3(vx,vy,vz));
}
void JoltPhysicsSystem::SetBodyAngularVelocity(JoltBodyID id, float vx, float vy, float vz) {
    mImpl->bi().SetAngularVelocity(mImpl->fromJoltID(id), Vec3(vx,vy,vz));
}
void JoltPhysicsSystem::SetBodyLinearAndAngularVelocity(
    JoltBodyID id,
    float lvx, float lvy, float lvz,
    float avx, float avy, float avz)
{
    mImpl->bi().SetLinearAndAngularVelocity(
        mImpl->fromJoltID(id), Vec3(lvx,lvy,lvz), Vec3(avx,avy,avz));
}
void JoltPhysicsSystem::AddForce(JoltBodyID id, float fx, float fy, float fz) {
    mImpl->bi().AddForce(mImpl->fromJoltID(id), Vec3(fx,fy,fz));
}
void JoltPhysicsSystem::AddForceAtPosition(
    JoltBodyID id, float fx, float fy, float fz, double px, double py, double pz)
{
    mImpl->bi().AddForce(mImpl->fromJoltID(id), Vec3(fx,fy,fz), RVec3(px,py,pz));
}
void JoltPhysicsSystem::AddTorque(JoltBodyID id, float tx, float ty, float tz) {
    mImpl->bi().AddTorque(mImpl->fromJoltID(id), Vec3(tx,ty,tz));
}
void JoltPhysicsSystem::AddImpulse(JoltBodyID id, float ix, float iy, float iz) {
    mImpl->bi().AddImpulse(mImpl->fromJoltID(id), Vec3(ix,iy,iz));
}
void JoltPhysicsSystem::AddAngularImpulse(JoltBodyID id, float ix, float iy, float iz) {
    mImpl->bi().AddAngularImpulse(mImpl->fromJoltID(id), Vec3(ix,iy,iz));
}
void JoltPhysicsSystem::ActivateBody(JoltBodyID id) {
    mImpl->bi().ActivateBody(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::DeactivateBody(JoltBodyID id) {
    mImpl->bi().DeactivateBody(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::SetFriction(JoltBodyID id, float f) {
    mImpl->bi().SetFriction(mImpl->fromJoltID(id), f);
}
float JoltPhysicsSystem::GetFriction(JoltBodyID id) const {
    return mImpl->bi().GetFriction(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::SetRestitution(JoltBodyID id, float r) {
    mImpl->bi().SetRestitution(mImpl->fromJoltID(id), r);
}
float JoltPhysicsSystem::GetRestitution(JoltBodyID id) const {
    return mImpl->bi().GetRestitution(mImpl->fromJoltID(id));
}
void JoltPhysicsSystem::SetGravityFactor(JoltBodyID id, float f) {
    mImpl->bi().SetGravityFactor(mImpl->fromJoltID(id), f);
}
float JoltPhysicsSystem::GetGravityFactor(JoltBodyID id) const {
    return mImpl->bi().GetGravityFactor(mImpl->fromJoltID(id));
}
JoltBodyID JoltPhysicsSystem::CreateAndAddSoftBody(JoltSoftBodyCreationSettings* settings, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    return mImpl->toJoltID(mImpl->bi().CreateAndAddSoftBody(sbcs_soft(settings), a));
}

JoltTwoBodyConstraint JoltPhysicsSystem::GetConstraintHandle(JoltConstraintID id) {
    JoltTwoBodyConstraint r;
    if (Constraint* c = mImpl->getConstraint(id))
        r.mPtr = static_cast<TwoBodyConstraint*>(c);
    return r;
}

JoltBodyInterface JoltPhysicsSystem::GetBodyInterface() {
    return JoltBodyInterface(mImpl);
}

unsigned int JoltPhysicsSystem::GetNumBodies() const {
    return mImpl->physics.GetNumBodies();
}
unsigned int JoltPhysicsSystem::GetNumActiveBodies() const {
    return mImpl->physics.GetNumActiveBodies(EBodyType::RigidBody);
}

// ---- Constraints ----

JoltConstraintID JoltPhysicsSystem::AddFixedConstraint(JoltBodyID b1, JoltBodyID b2) {
    FixedConstraintSettings s;
    s.mAutoDetectPoint = true;
    auto* c = static_cast<Constraint*>(
        s.Create(*mImpl->physics.GetBodyLockInterface().TryGetBody(mImpl->fromJoltID(b1)),
                 *mImpl->physics.GetBodyLockInterface().TryGetBody(mImpl->fromJoltID(b2))));

    // Use BodyInterface lock to get bodies properly
    BodyLockWrite lock1(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b1));
    BodyLockWrite lock2(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b2));
    if (!lock1.Succeeded() || !lock2.Succeeded()) { JoltConstraintID r; return r; }
    Ref<Constraint> constraint = s.Create(lock1.GetBody(), lock2.GetBody());
    return mImpl->addConstraint(constraint);
}

JoltConstraintID JoltPhysicsSystem::AddDistanceConstraint(
    JoltBodyID b1, JoltBodyID b2, float minDist, float maxDist)
{
    DistanceConstraintSettings s;
    s.mMinDistance = minDist;
    s.mMaxDistance = maxDist;
    BodyLockWrite lock1(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b1));
    BodyLockWrite lock2(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b2));
    if (!lock1.Succeeded() || !lock2.Succeeded()) { JoltConstraintID r; return r; }
    s.mPoint1 = lock1.GetBody().GetCenterOfMassPosition();
    s.mPoint2 = lock2.GetBody().GetCenterOfMassPosition();
    s.mSpace  = EConstraintSpace::WorldSpace;
    return mImpl->addConstraint(s.Create(lock1.GetBody(), lock2.GetBody()));
}

JoltConstraintID JoltPhysicsSystem::AddPointConstraint(
    JoltBodyID b1, JoltBodyID b2, double px, double py, double pz)
{
    PointConstraintSettings s;
    s.mSpace  = EConstraintSpace::WorldSpace;
    s.mPoint1 = RVec3(px, py, pz);
    s.mPoint2 = RVec3(px, py, pz);
    BodyLockWrite lock1(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b1));
    BodyLockWrite lock2(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b2));
    if (!lock1.Succeeded() || !lock2.Succeeded()) { JoltConstraintID r; return r; }
    return mImpl->addConstraint(s.Create(lock1.GetBody(), lock2.GetBody()));
}

JoltConstraintID JoltPhysicsSystem::AddHingeConstraint(
    JoltBodyID b1, JoltBodyID b2,
    double px, double py, double pz,
    float ax, float ay, float az)
{
    HingeConstraintSettings s;
    s.mSpace       = EConstraintSpace::WorldSpace;
    s.mPoint1      = RVec3(px, py, pz);
    s.mPoint2      = RVec3(px, py, pz);
    s.mHingeAxis1  = Vec3(ax, ay, az).Normalized();
    s.mHingeAxis2  = s.mHingeAxis1;
    s.mNormalAxis1 = s.mHingeAxis1.GetNormalizedPerpendicular();
    s.mNormalAxis2 = s.mNormalAxis1;
    BodyLockWrite lock1(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b1));
    BodyLockWrite lock2(mImpl->physics.GetBodyLockInterface(), mImpl->fromJoltID(b2));
    if (!lock1.Succeeded() || !lock2.Succeeded()) { JoltConstraintID r; return r; }
    return mImpl->addConstraint(s.Create(lock1.GetBody(), lock2.GetBody()));
}

void JoltPhysicsSystem::DestroyConstraint(JoltConstraintID id) {
    mImpl->removeConstraint(id);
}
void JoltPhysicsSystem::SetConstraintEnabled(JoltConstraintID id, bool enabled) {
    if (Constraint* c = mImpl->getConstraint(id)) c->SetEnabled(enabled);
}

// ---------------------------------------------------------------------------
// JoltWorld (backward compat)
// ---------------------------------------------------------------------------
struct JoltWorld::Impl {
    JoltPhysicsSystem sys;
    Impl() { sys.SetGravity(0, -9.81, 0); }
};

JoltWorld::JoltWorld()  { mImpl = new Impl(); }
JoltWorld::~JoltWorld() { delete mImpl; }

void JoltWorld::SetGravity(double x, double y, double z) {
    mImpl->sys.SetGravity(x, y, z);
}

JoltBodyID JoltWorld::AddStaticBox(double hx, double hy, double hz,
                                    double px, double py, double pz)
{
    JoltBoxShape shape(hx, hy, hz);
    JoltBodyCreationSettings s(&shape, px, py, pz,
        JoltMotionType_Static, (unsigned int)(unsigned int)JoltObjectLayer_NonMoving);
    return mImpl->sys.CreateAndAddBody(&s, JoltActivation_DontActivate);
}

JoltBodyID JoltWorld::AddDynamicSphere(double radius, double px, double py, double pz) {
    JoltSphereShape shape((float)radius);
    JoltBodyCreationSettings s(&shape, px, py, pz,
        JoltMotionType_Dynamic, (unsigned int)(unsigned int)JoltObjectLayer_Moving);
    return mImpl->sys.CreateAndAddBody(&s, JoltActivation_Activate);
}

void JoltWorld::Update(double deltaTime) { mImpl->sys.Update((float)deltaTime, 1); }
void JoltWorld::OptimizeBroadPhase()     { mImpl->sys.OptimizeBroadPhase(); }

JoltVec3 JoltWorld::GetBodyPosition(JoltBodyID id) const {
    return mImpl->sys.GetBodyPosition(id);
}
bool JoltWorld::IsBodyActive(JoltBodyID id) const {
    return mImpl->sys.IsBodyActive(id);
}
void JoltWorld::RemoveBody(JoltBodyID id)  { mImpl->sys.RemoveBody(id); }
void JoltWorld::DestroyBody(JoltBodyID id) { mImpl->sys.DestroyBody(id); }

// ---------------------------------------------------------------------------
// JoltMat44
// ---------------------------------------------------------------------------
JoltMat44::JoltMat44() {
    e00=e11=e22=e33=1.f;
    e10=e20=e30=e01=e21=e31=e02=e12=e32=e03=e13=e23=0.f;
}
JoltMat44 JoltMat44::Identity() { return JoltMat44(); }
JoltVec3f JoltMat44::GetTranslation() const { return JoltVec3f(e03, e13, e23); }
JoltQuat  JoltMat44::GetRotation() const {
    Mat44 m(Vec4(e00,e10,e20,e30),Vec4(e01,e11,e21,e31),Vec4(e02,e12,e22,e32),Vec4(e03,e13,e23,e33));
    return fromQuat(m.GetQuaternion());
}

// ---------------------------------------------------------------------------
// JoltRMat44
// ---------------------------------------------------------------------------
JoltRMat44::JoltRMat44() {
    e00=e11=e22=1.f;
    e10=e20=e01=e21=e02=e12=0.f;
    tx=ty=tz=0.0;
}
JoltRMat44 JoltRMat44::Identity() { return JoltRMat44(); }
JoltVec3   JoltRMat44::GetTranslation()  const { return JoltVec3(tx,ty,tz); }
JoltVec3f  JoltRMat44::GetTranslationF() const { return JoltVec3f((float)tx,(float)ty,(float)tz); }
JoltQuat   JoltRMat44::GetRotation() const {
    Mat44 m(Vec4(e00,e10,e20,0),Vec4(e01,e11,e21,0),Vec4(e02,e12,e22,0),Vec4(0,0,0,1));
    return fromQuat(m.GetQuaternion());
}
JoltMat44  JoltRMat44::ToMat44() const {
    JoltMat44 r;
    r.e00=e00; r.e10=e10; r.e20=e20; r.e30=0.f;
    r.e01=e01; r.e11=e11; r.e21=e21; r.e31=0.f;
    r.e02=e02; r.e12=e12; r.e22=e22; r.e32=0.f;
    r.e03=(float)tx; r.e13=(float)ty; r.e23=(float)tz; r.e33=1.f;
    return r;
}

// ---------------------------------------------------------------------------
// JoltAABox
// ---------------------------------------------------------------------------
JoltAABox::JoltAABox()
    : minX(0),minY(0),minZ(0),maxX(0),maxY(0),maxZ(0) {}
JoltAABox::JoltAABox(double mnX,double mnY,double mnZ,double mxX,double mxY,double mxZ)
    : minX(mnX),minY(mnY),minZ(mnZ),maxX(mxX),maxY(mxY),maxZ(mxZ) {}
JoltVec3 JoltAABox::GetCenter() const {
    return JoltVec3((minX+maxX)*0.5,(minY+maxY)*0.5,(minZ+maxZ)*0.5);
}
JoltVec3 JoltAABox::GetExtent() const {
    return JoltVec3((maxX-minX)*0.5,(maxY-minY)*0.5,(maxZ-minZ)*0.5);
}
bool JoltAABox::Contains(double x,double y,double z) const {
    return x>=minX&&x<=maxX&&y>=minY&&y<=maxY&&z>=minZ&&z<=maxZ;
}
bool JoltAABox::Overlaps(const JoltAABox& o) const {
    return minX<=o.maxX&&maxX>=o.minX&&minY<=o.maxY&&maxY>=o.minY&&minZ<=o.maxZ&&maxZ>=o.minZ;
}
void JoltAABox::Encapsulate(double x,double y,double z) {
    if(x<minX)minX=x; if(x>maxX)maxX=x;
    if(y<minY)minY=y; if(y>maxY)maxY=y;
    if(z<minZ)minZ=z; if(z>maxZ)maxZ=z;
}

// ---------------------------------------------------------------------------
// JoltCollisionGroup
// ---------------------------------------------------------------------------
JoltCollisionGroup::JoltCollisionGroup()
    : groupID(0xffffffff), subGroupID(0xffffffff) {}
JoltCollisionGroup::JoltCollisionGroup(unsigned int g, unsigned int sg)
    : groupID(g), subGroupID(sg) {}

// ---------------------------------------------------------------------------
// JoltPhysicsMaterial
// ---------------------------------------------------------------------------
JoltPhysicsMaterial::JoltPhysicsMaterial() : mPtr(nullptr) {}
bool JoltPhysicsMaterial::IsValid() const { return mPtr != nullptr; }
const char* JoltPhysicsMaterial::GetDebugName() const {
    if (!mPtr) {
        const PhysicsMaterial* def = PhysicsMaterial::sDefault;
        return def ? def->GetDebugName() : "default";
    }
    return static_cast<const PhysicsMaterial*>(mPtr)->GetDebugName();
}

// ---------------------------------------------------------------------------
// JoltTwoBodyConstraint
// ---------------------------------------------------------------------------
JoltTwoBodyConstraint::JoltTwoBodyConstraint() : mPtr(nullptr) {}
bool JoltTwoBodyConstraint::IsValid()   const { return mPtr != nullptr; }
bool JoltTwoBodyConstraint::GetEnabled() const {
    return mPtr && static_cast<TwoBodyConstraint*>(mPtr)->GetEnabled();
}
void JoltTwoBodyConstraint::SetEnabled(bool e) {
    if (mPtr) static_cast<TwoBodyConstraint*>(mPtr)->SetEnabled(e);
}

// ---------------------------------------------------------------------------
// JoltSoftBodySharedSettings
// ---------------------------------------------------------------------------
struct SBSSHandle { Ref<SoftBodySharedSettings> settings; };
static inline SoftBodySharedSettings& sbss(JoltSoftBodySharedSettings* s) {
    return *static_cast<SBSSHandle*>(s->mHandle)->settings;
}
static inline const SoftBodySharedSettings& sbss_c(const JoltSoftBodySharedSettings* s) {
    return *static_cast<const SBSSHandle*>(s->mHandle)->settings;
}

JoltSoftBodySharedSettings::JoltSoftBodySharedSettings()
    : mHandle(new SBSSHandle{ new SoftBodySharedSettings() }) {}
JoltSoftBodySharedSettings::~JoltSoftBodySharedSettings() {
    delete static_cast<SBSSHandle*>(mHandle);
}
void JoltSoftBodySharedSettings::AddVertex(float x, float y, float z, float invMass) {
    sbss(this).mVertices.push_back(
        SoftBodySharedSettings::Vertex(Float3(x,y,z), Float3(0,0,0), invMass));
}
void JoltSoftBodySharedSettings::AddFace(unsigned int v0, unsigned int v1, unsigned int v2) {
    sbss(this).AddFace(SoftBodySharedSettings::Face(v0, v1, v2));
}
void JoltSoftBodySharedSettings::AddEdgeConstraint(unsigned int v0, unsigned int v1,
    float compliance, float restLength)
{
    SoftBodySharedSettings::Edge e(v0, v1, compliance);
    e.mRestLength = (restLength > 0.f) ? restLength : 1.0f;
    sbss(this).mEdgeConstraints.push_back(e);
}
void JoltSoftBodySharedSettings::AddEdgeConstraintAuto(unsigned int v0, unsigned int v1, float compliance) {
    auto& verts = sbss(this).mVertices;
    float len = 1.0f;
    if (v0 < verts.size() && v1 < verts.size()) {
        Float3 p0=verts[v0].mPosition, p1=verts[v1].mPosition;
        float dx=p1.x-p0.x, dy=p1.y-p0.y, dz=p1.z-p0.z;
        len = sqrtf(dx*dx+dy*dy+dz*dz);
        if (len < 1e-6f) len = 1.0f;
    }
    SoftBodySharedSettings::Edge e(v0, v1, compliance);
    e.mRestLength = len;
    sbss(this).mEdgeConstraints.push_back(e);
}
void JoltSoftBodySharedSettings::CalculateEdgeLengths() { sbss(this).CalculateEdgeLengths(); }
void JoltSoftBodySharedSettings::Optimize()             { sbss(this).Optimize(); }
int  JoltSoftBodySharedSettings::GetVertexCount() const { return (int)sbss_c(this).mVertices.size(); }
int  JoltSoftBodySharedSettings::GetFaceCount()   const { return (int)sbss_c(this).mFaces.size(); }
int  JoltSoftBodySharedSettings::GetEdgeCount()   const { return (int)sbss_c(this).mEdgeConstraints.size(); }

// ---------------------------------------------------------------------------
// JoltSoftBodyCreationSettings
// ---------------------------------------------------------------------------
JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings(
    JoltSoftBodySharedSettings* shared,
    double posX, double posY, double posZ,
    float qx, float qy, float qz, float qw,
    unsigned int objectLayer)
{
    auto* h = new SBCSHandle();
    h->settings.mSettings    = static_cast<SBSSHandle*>(shared->mHandle)->settings;
    h->settings.mPosition    = RVec3(posX, posY, posZ);
    h->settings.mRotation    = Quat(qx, qy, qz, qw);
    h->settings.mObjectLayer = (ObjectLayer)objectLayer;
    mHandle = h;
}
JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings(
    JoltSoftBodySharedSettings* shared,
    double posX, double posY, double posZ,
    unsigned int objectLayer)
    : JoltSoftBodyCreationSettings(shared, posX, posY, posZ, 0,0,0,1, objectLayer) {}
JoltSoftBodyCreationSettings::~JoltSoftBodyCreationSettings() {
    delete static_cast<SBCSHandle*>(mHandle);
}
void JoltSoftBodyCreationSettings::SetPosition(double x, double y, double z) {
    sbcs_soft(this).mPosition = RVec3(x,y,z);
}
void JoltSoftBodyCreationSettings::SetRotation(float qx, float qy, float qz, float qw) {
    sbcs_soft(this).mRotation = Quat(qx,qy,qz,qw);
}
void JoltSoftBodyCreationSettings::SetObjectLayer(unsigned int layer) {
    sbcs_soft(this).mObjectLayer = (ObjectLayer)layer;
}
void JoltSoftBodyCreationSettings::SetMakeRotationIdentity(bool v) {
    sbcs_soft(this).mMakeRotationIdentity = v;
}
void JoltSoftBodyCreationSettings::SetNumIterations(unsigned int n) {
    sbcs_soft(this).mNumIterations = n;
}

// ---------------------------------------------------------------------------
// JoltBodyIDList
// ---------------------------------------------------------------------------
struct JoltBodyIDListData { std::vector<BodyID> ids; };
static inline JoltBodyIDListData* bdata(void* p) {
    return static_cast<JoltBodyIDListData*>(p);
}

JoltBodyIDList::JoltBodyIDList()  : mData(new JoltBodyIDListData()) {}
JoltBodyIDList::~JoltBodyIDList() { delete bdata(mData); }

void JoltBodyIDList::Add(JoltBodyID id) {
    bdata(mData)->ids.push_back(BodyID(id.value));
}
void JoltBodyIDList::Clear() { bdata(mData)->ids.clear(); }
int  JoltBodyIDList::Count() const { return (int)bdata(mData)->ids.size(); }
JoltBodyID JoltBodyIDList::Get(int index) const {
    JoltBodyID r;
    r.value = bdata(mData)->ids[index].GetIndexAndSequenceNumber();
    return r;
}

// ---------------------------------------------------------------------------
// JoltBodyInterface
// ---------------------------------------------------------------------------
static inline JoltPhysicsSystem::Impl* bi_impl(void* p) {
    return static_cast<JoltPhysicsSystem::Impl*>(p);
}

JoltBodyInterface::JoltBodyInterface(void* impl) : mImpl(impl) {}

bool JoltBodyInterface::IsValid() const { return mImpl != nullptr; }

// ---- Body lifetime -------------------------------------------------------

JoltBodyID JoltBodyInterface::CreateBody(JoltBodyCreationSettings* settings) {
    Body* body = bi_impl(mImpl)->bi().CreateBody(bcs(settings));
    JoltBodyID r;
    if (body) r.value = body->GetID().GetIndexAndSequenceNumber();
    return r;
}

JoltBodyID JoltBodyInterface::CreateBodyWithID(JoltBodyID targetID, JoltBodyCreationSettings* settings) {
    Body* body = bi_impl(mImpl)->bi().CreateBodyWithID(
        bi_impl(mImpl)->fromJoltID(targetID), bcs(settings));
    JoltBodyID r;
    if (body) r.value = body->GetID().GetIndexAndSequenceNumber();
    return r;
}

JoltBodyID JoltBodyInterface::CreateAndAddBody(JoltBodyCreationSettings* settings, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    return bi_impl(mImpl)->toJoltID(bi_impl(mImpl)->bi().CreateAndAddBody(bcs(settings), a));
}
void JoltBodyInterface::AddBody(JoltBodyID id, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().AddBody(bi_impl(mImpl)->fromJoltID(id), a);
}
void JoltBodyInterface::RemoveBody(JoltBodyID id) {
    bi_impl(mImpl)->bi().RemoveBody(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::DestroyBody(JoltBodyID id) {
    bi_impl(mImpl)->bi().DestroyBody(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::RemoveAndDestroyBody(JoltBodyID id) {
    auto& b = bi_impl(mImpl)->bi();
    BodyID bid = bi_impl(mImpl)->fromJoltID(id);
    b.RemoveBody(bid);
    b.DestroyBody(bid);
}
bool JoltBodyInterface::IsAdded(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().IsAdded(bi_impl(mImpl)->fromJoltID(id));
}

// ---- Position / rotation -------------------------------------------------

void JoltBodyInterface::SetPosition(JoltBodyID id, double x, double y, double z, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetPosition(bi_impl(mImpl)->fromJoltID(id), RVec3(x, y, z), a);
}
JoltVec3 JoltBodyInterface::GetPosition(JoltBodyID id) const {
    return fromRVec3(bi_impl(mImpl)->bi().GetPosition(bi_impl(mImpl)->fromJoltID(id)));
}
JoltVec3 JoltBodyInterface::GetCenterOfMassPosition(JoltBodyID id) const {
    return fromRVec3(bi_impl(mImpl)->bi().GetCenterOfMassPosition(bi_impl(mImpl)->fromJoltID(id)));
}
void JoltBodyInterface::SetRotation(JoltBodyID id, float qx, float qy, float qz, float qw, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetRotation(bi_impl(mImpl)->fromJoltID(id), Quat(qx, qy, qz, qw), a);
}
JoltQuat JoltBodyInterface::GetRotation(JoltBodyID id) const {
    return fromQuat(bi_impl(mImpl)->bi().GetRotation(bi_impl(mImpl)->fromJoltID(id)));
}
void JoltBodyInterface::SetPositionAndRotation(JoltBodyID id,
    double x, double y, double z,
    float qx, float qy, float qz, float qw, int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetPositionAndRotation(
        bi_impl(mImpl)->fromJoltID(id), RVec3(x, y, z), Quat(qx, qy, qz, qw), a);
}
void JoltBodyInterface::MoveKinematic(JoltBodyID id,
    double x, double y, double z,
    float qx, float qy, float qz, float qw, float deltaTime)
{
    bi_impl(mImpl)->bi().MoveKinematic(
        bi_impl(mImpl)->fromJoltID(id), RVec3(x, y, z), Quat(qx, qy, qz, qw), deltaTime);
}
void JoltBodyInterface::SetPositionRotationAndVelocity(JoltBodyID id,
    double x, double y, double z,
    float qx, float qy, float qz, float qw,
    float lvx, float lvy, float lvz,
    float avx, float avy, float avz)
{
    bi_impl(mImpl)->bi().SetPositionRotationAndVelocity(
        bi_impl(mImpl)->fromJoltID(id),
        RVec3(x, y, z), Quat(qx, qy, qz, qw),
        Vec3(lvx, lvy, lvz), Vec3(avx, avy, avz));
}

// ---- Velocity ------------------------------------------------------------

void JoltBodyInterface::SetLinearVelocity(JoltBodyID id, float vx, float vy, float vz) {
    bi_impl(mImpl)->bi().SetLinearVelocity(bi_impl(mImpl)->fromJoltID(id), Vec3(vx, vy, vz));
}
JoltVec3f JoltBodyInterface::GetLinearVelocity(JoltBodyID id) const {
    return fromVec3(bi_impl(mImpl)->bi().GetLinearVelocity(bi_impl(mImpl)->fromJoltID(id)));
}
void JoltBodyInterface::AddLinearVelocity(JoltBodyID id, float vx, float vy, float vz) {
    bi_impl(mImpl)->bi().AddLinearVelocity(bi_impl(mImpl)->fromJoltID(id), Vec3(vx, vy, vz));
}
void JoltBodyInterface::SetAngularVelocity(JoltBodyID id, float vx, float vy, float vz) {
    bi_impl(mImpl)->bi().SetAngularVelocity(bi_impl(mImpl)->fromJoltID(id), Vec3(vx, vy, vz));
}
JoltVec3f JoltBodyInterface::GetAngularVelocity(JoltBodyID id) const {
    return fromVec3(bi_impl(mImpl)->bi().GetAngularVelocity(bi_impl(mImpl)->fromJoltID(id)));
}
void JoltBodyInterface::SetLinearAndAngularVelocity(JoltBodyID id,
    float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    bi_impl(mImpl)->bi().SetLinearAndAngularVelocity(
        bi_impl(mImpl)->fromJoltID(id), Vec3(lvx, lvy, lvz), Vec3(avx, avy, avz));
}
void JoltBodyInterface::GetLinearAndAngularVelocity(JoltBodyID id,
    JoltVec3f& outLinear, JoltVec3f& outAngular) const
{
    Vec3 lin, ang;
    bi_impl(mImpl)->bi().GetLinearAndAngularVelocity(bi_impl(mImpl)->fromJoltID(id), lin, ang);
    outLinear  = fromVec3(lin);
    outAngular = fromVec3(ang);
}
void JoltBodyInterface::AddLinearAndAngularVelocity(JoltBodyID id,
    float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    bi_impl(mImpl)->bi().AddLinearAndAngularVelocity(
        bi_impl(mImpl)->fromJoltID(id), Vec3(lvx, lvy, lvz), Vec3(avx, avy, avz));
}
JoltVec3f JoltBodyInterface::GetPointVelocity(JoltBodyID id, double px, double py, double pz) const {
    return fromVec3(bi_impl(mImpl)->bi().GetPointVelocity(
        bi_impl(mImpl)->fromJoltID(id), RVec3(px, py, pz)));
}

// ---- Forces / impulses ---------------------------------------------------

void JoltBodyInterface::AddForce(JoltBodyID id, float fx, float fy, float fz) {
    bi_impl(mImpl)->bi().AddForce(bi_impl(mImpl)->fromJoltID(id), Vec3(fx, fy, fz));
}
void JoltBodyInterface::AddForceAtPosition(JoltBodyID id,
    float fx, float fy, float fz, double px, double py, double pz)
{
    bi_impl(mImpl)->bi().AddForce(
        bi_impl(mImpl)->fromJoltID(id), Vec3(fx, fy, fz), RVec3(px, py, pz));
}
void JoltBodyInterface::AddTorque(JoltBodyID id, float tx, float ty, float tz) {
    bi_impl(mImpl)->bi().AddTorque(bi_impl(mImpl)->fromJoltID(id), Vec3(tx, ty, tz));
}
void JoltBodyInterface::AddForceAndTorque(JoltBodyID id,
    float fx, float fy, float fz, float tx, float ty, float tz)
{
    bi_impl(mImpl)->bi().AddForceAndTorque(
        bi_impl(mImpl)->fromJoltID(id), Vec3(fx, fy, fz), Vec3(tx, ty, tz));
}
void JoltBodyInterface::AddImpulse(JoltBodyID id, float ix, float iy, float iz) {
    bi_impl(mImpl)->bi().AddImpulse(bi_impl(mImpl)->fromJoltID(id), Vec3(ix, iy, iz));
}
void JoltBodyInterface::AddImpulseAtPosition(JoltBodyID id,
    float ix, float iy, float iz, double px, double py, double pz)
{
    bi_impl(mImpl)->bi().AddImpulse(
        bi_impl(mImpl)->fromJoltID(id), Vec3(ix, iy, iz), RVec3(px, py, pz));
}
void JoltBodyInterface::AddAngularImpulse(JoltBodyID id, float ix, float iy, float iz) {
    bi_impl(mImpl)->bi().AddAngularImpulse(bi_impl(mImpl)->fromJoltID(id), Vec3(ix, iy, iz));
}

// ---- Body properties -----------------------------------------------------

int JoltBodyInterface::GetBodyType(JoltBodyID id) const {
    return (int)bi_impl(mImpl)->bi().GetBodyType(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetMotionType(JoltBodyID id, int motionType, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetMotionType(
        bi_impl(mImpl)->fromJoltID(id), (EMotionType)motionType, a);
}
int JoltBodyInterface::GetMotionType(JoltBodyID id) const {
    return (int)bi_impl(mImpl)->bi().GetMotionType(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetMotionQuality(JoltBodyID id, int motionQuality) {
    bi_impl(mImpl)->bi().SetMotionQuality(
        bi_impl(mImpl)->fromJoltID(id), (EMotionQuality)motionQuality);
}
int JoltBodyInterface::GetMotionQuality(JoltBodyID id) const {
    return (int)bi_impl(mImpl)->bi().GetMotionQuality(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetObjectLayer(JoltBodyID id, unsigned int layer) {
    bi_impl(mImpl)->bi().SetObjectLayer(bi_impl(mImpl)->fromJoltID(id), (ObjectLayer)layer);
}
unsigned int JoltBodyInterface::GetObjectLayer(JoltBodyID id) const {
    return (unsigned int)bi_impl(mImpl)->bi().GetObjectLayer(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetFriction(JoltBodyID id, float f) {
    bi_impl(mImpl)->bi().SetFriction(bi_impl(mImpl)->fromJoltID(id), f);
}
float JoltBodyInterface::GetFriction(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetFriction(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetRestitution(JoltBodyID id, float r) {
    bi_impl(mImpl)->bi().SetRestitution(bi_impl(mImpl)->fromJoltID(id), r);
}
float JoltBodyInterface::GetRestitution(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetRestitution(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetGravityFactor(JoltBodyID id, float f) {
    bi_impl(mImpl)->bi().SetGravityFactor(bi_impl(mImpl)->fromJoltID(id), f);
}
float JoltBodyInterface::GetGravityFactor(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetGravityFactor(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetMaxLinearVelocity(JoltBodyID id, float v) {
    bi_impl(mImpl)->bi().SetMaxLinearVelocity(bi_impl(mImpl)->fromJoltID(id), v);
}
float JoltBodyInterface::GetMaxLinearVelocity(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetMaxLinearVelocity(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetMaxAngularVelocity(JoltBodyID id, float v) {
    bi_impl(mImpl)->bi().SetMaxAngularVelocity(bi_impl(mImpl)->fromJoltID(id), v);
}
float JoltBodyInterface::GetMaxAngularVelocity(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetMaxAngularVelocity(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetIsSensor(JoltBodyID id, bool s) {
    bi_impl(mImpl)->bi().SetIsSensor(bi_impl(mImpl)->fromJoltID(id), s);
}
bool JoltBodyInterface::IsSensor(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().IsSensor(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetUseManifoldReduction(JoltBodyID id, bool useReduction) {
    bi_impl(mImpl)->bi().SetUseManifoldReduction(bi_impl(mImpl)->fromJoltID(id), useReduction);
}
bool JoltBodyInterface::GetUseManifoldReduction(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().GetUseManifoldReduction(bi_impl(mImpl)->fromJoltID(id));
}
unsigned long long JoltBodyInterface::GetUserData(JoltBodyID id) const {
    return (unsigned long long)bi_impl(mImpl)->bi().GetUserData(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::SetUserData(JoltBodyID id, unsigned long long userData) {
    bi_impl(mImpl)->bi().SetUserData(bi_impl(mImpl)->fromJoltID(id), (uint64)userData);
}

// ---- Activation ----------------------------------------------------------

void JoltBodyInterface::ActivateBody(JoltBodyID id) {
    bi_impl(mImpl)->bi().ActivateBody(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::DeactivateBody(JoltBodyID id) {
    bi_impl(mImpl)->bi().DeactivateBody(bi_impl(mImpl)->fromJoltID(id));
}
bool JoltBodyInterface::IsActive(JoltBodyID id) const {
    return bi_impl(mImpl)->bi().IsActive(bi_impl(mImpl)->fromJoltID(id));
}
void JoltBodyInterface::ResetSleepTimer(JoltBodyID id) {
    bi_impl(mImpl)->bi().ResetSleepTimer(bi_impl(mImpl)->fromJoltID(id));
}

// ---- Shape ---------------------------------------------------------------

void JoltBodyInterface::SetShape(JoltBodyID id, JoltShape* shape,
    bool updateMassProperties, int activation) const
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetShape(
        bi_impl(mImpl)->fromJoltID(id),
        static_cast<const Shape*>(shape->getHandle()),
        updateMassProperties, a);
}

void JoltBodyInterface::NotifyShapeChanged(JoltBodyID id,
    double prevComX, double prevComY, double prevComZ,
    bool updateMassProperties, int activation) const
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().NotifyShapeChanged(
        bi_impl(mImpl)->fromJoltID(id),
        Vec3((float)prevComX, (float)prevComY, (float)prevComZ),
        updateMassProperties, a);
}

// ---- Position / rotation (new) -------------------------------------------

void JoltBodyInterface::GetPositionAndRotation(JoltBodyID id,
    JoltVec3& outPosition, JoltQuat& outRotation) const
{
    RVec3 pos; Quat rot;
    bi_impl(mImpl)->bi().GetPositionAndRotation(bi_impl(mImpl)->fromJoltID(id), pos, rot);
    outPosition = fromRVec3(pos);
    outRotation = fromQuat(rot);
}

void JoltBodyInterface::SetPositionAndRotationWhenChanged(JoltBodyID id,
    double x, double y, double z,
    float qx, float qy, float qz, float qw, int activation)
{
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    bi_impl(mImpl)->bi().SetPositionAndRotationWhenChanged(
        bi_impl(mImpl)->fromJoltID(id), RVec3(x, y, z), Quat(qx, qy, qz, qw), a);
}

// ---- Forces / impulses (new) ----------------------------------------------

bool JoltBodyInterface::ApplyBuoyancyImpulse(JoltBodyID id,
    double surfacePosX, double surfacePosY, double surfacePosZ,
    float surfaceNX, float surfaceNY, float surfaceNZ,
    float buoyancy, float linearDrag, float angularDrag,
    float fluidVX, float fluidVY, float fluidVZ,
    float gravX, float gravY, float gravZ,
    float deltaTime)
{
    return bi_impl(mImpl)->bi().ApplyBuoyancyImpulse(
        bi_impl(mImpl)->fromJoltID(id),
        RVec3(surfacePosX, surfacePosY, surfacePosZ),
        Vec3(surfaceNX, surfaceNY, surfaceNZ),
        buoyancy, linearDrag, angularDrag,
        Vec3(fluidVX, fluidVY, fluidVZ),
        Vec3(gravX, gravY, gravZ),
        deltaTime);
}

// ---- Activation (batch) --------------------------------------------------

void JoltBodyInterface::ActivateBodies(JoltBodyIDList* bodies) {
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().ActivateBodies(ids.data(), (int)ids.size());
}
void JoltBodyInterface::DeactivateBodies(JoltBodyIDList* bodies) {
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().DeactivateBodies(ids.data(), (int)ids.size());
}

// ---- Batch add / remove --------------------------------------------------

void* JoltBodyInterface::AddBodiesPrepare(JoltBodyIDList* bodies) {
    auto& ids = bdata(bodies->mData)->ids;
    return bi_impl(mImpl)->bi().AddBodiesPrepare(ids.data(), (int)ids.size());
}
void JoltBodyInterface::AddBodiesFinalize(JoltBodyIDList* bodies, void* addState, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().AddBodiesFinalize(ids.data(), (int)ids.size(), addState, a);
}
void JoltBodyInterface::AddBodiesAbort(JoltBodyIDList* bodies, void* addState) {
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().AddBodiesAbort(ids.data(), (int)ids.size(), addState);
}
void JoltBodyInterface::RemoveBodies(JoltBodyIDList* bodies) {
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().RemoveBodies(ids.data(), (int)ids.size());
}
void JoltBodyInterface::DestroyBodies(JoltBodyIDList* bodies) {
    auto& ids = bdata(bodies->mData)->ids;
    bi_impl(mImpl)->bi().DestroyBodies(ids.data(), (int)ids.size());
}

// ---- Misc ----------------------------------------------------------------

void JoltBodyInterface::InvalidateContactCache(JoltBodyID id) {
    bi_impl(mImpl)->bi().InvalidateContactCache(bi_impl(mImpl)->fromJoltID(id));
}

// ---- Transforms ----------------------------------------------------------

JoltRMat44 JoltBodyInterface::GetWorldTransform(JoltBodyID id) const {
    return fromRMat44(bi_impl(mImpl)->bi().GetWorldTransform(bi_impl(mImpl)->fromJoltID(id)));
}
JoltRMat44 JoltBodyInterface::GetCenterOfMassTransform(JoltBodyID id) const {
    return fromRMat44(bi_impl(mImpl)->bi().GetCenterOfMassTransform(bi_impl(mImpl)->fromJoltID(id)));
}
JoltMat44 JoltBodyInterface::GetInverseInertia(JoltBodyID id) const {
    return fromMat44(bi_impl(mImpl)->bi().GetInverseInertia(bi_impl(mImpl)->fromJoltID(id)));
}

// ---- Collision group -----------------------------------------------------

void JoltBodyInterface::SetCollisionGroup(JoltBodyID id, const JoltCollisionGroup& group) {
    CollisionGroup g(nullptr,
        (CollisionGroup::GroupID)group.groupID,
        (CollisionGroup::SubGroupID)group.subGroupID);
    bi_impl(mImpl)->bi().SetCollisionGroup(bi_impl(mImpl)->fromJoltID(id), g);
}
JoltCollisionGroup JoltBodyInterface::GetCollisionGroup(JoltBodyID id) const {
    const CollisionGroup& g = bi_impl(mImpl)->bi().GetCollisionGroup(bi_impl(mImpl)->fromJoltID(id));
    return JoltCollisionGroup(g.GetGroupID(), g.GetSubGroupID());
}

// ---- Broad-phase activation -----------------------------------------------

void JoltBodyInterface::ActivateBodiesInAABox(const JoltAABox& box) {
    AABox jBox(Vec3((float)box.minX,(float)box.minY,(float)box.minZ),
               Vec3((float)box.maxX,(float)box.maxY,(float)box.maxZ));
    bi_impl(mImpl)->bi().ActivateBodiesInAABox(jBox, s_acceptAllBP, s_acceptAllObj);
}

// ---- Material ------------------------------------------------------------

JoltPhysicsMaterial JoltBodyInterface::GetMaterial(JoltBodyID id) const {
    JoltPhysicsMaterial r;
    r.mPtr = (void*)bi_impl(mImpl)->bi().GetMaterial(bi_impl(mImpl)->fromJoltID(id), SubShapeID());
    return r;
}

// ---- Constraints ---------------------------------------------------------

void JoltBodyInterface::ActivateConstraint(const JoltTwoBodyConstraint& constraint) {
    if (constraint.mPtr)
        bi_impl(mImpl)->bi().ActivateConstraint(
            static_cast<const TwoBodyConstraint*>(constraint.mPtr));
}

// ---- Soft body -----------------------------------------------------------

JoltBodyID JoltBodyInterface::CreateSoftBody(JoltSoftBodyCreationSettings* settings) {
    Body* body = bi_impl(mImpl)->bi().CreateSoftBody(sbcs_soft(settings));
    JoltBodyID r;
    if (body) r.value = body->GetID().GetIndexAndSequenceNumber();
    return r;
}
JoltBodyID JoltBodyInterface::CreateAndAddSoftBody(JoltSoftBodyCreationSettings* settings, int activation) {
    EActivation a = (activation == JoltActivation_Activate)
                  ? EActivation::Activate : EActivation::DontActivate;
    return bi_impl(mImpl)->toJoltID(bi_impl(mImpl)->bi().CreateAndAddSoftBody(sbcs_soft(settings), a));
}
