/* jolt_init.cpp — implementation of JoltHelpers.
   Compiled with -include Jolt/Jolt.h (force-included by run.sh). */

#define JOLT_BUILD_LIBRARY

#include <Jolt/Core/Factory.h>
#include <Jolt/RegisterTypes.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Body/BodyLock.h>
#include <Jolt/Physics/Character/CharacterBase.h>

#include <cstdarg>
#include <cstdio>

#include "jolt_init_wrapper.h"

using namespace JPH;

static void sTrace(const char *fmt, ...)
{
    va_list args;
    va_start(args, fmt);
    vprintf(fmt, args);
    va_end(args);
    putchar('\n');
}

JPH_IF_ENABLE_ASSERTS(
static bool sAssertFailed(const char *inExpr, const char *inMsg,
                          const char *inFile, uint inLine)
{
    sTrace("%s:%u: (%s) %s", inFile, inLine, inExpr, inMsg ? inMsg : "");
    return true;
}
)

void JoltHelpers::Init()
{
    Trace = sTrace;
    JPH_IF_ENABLE_ASSERTS(AssertFailed = sAssertFailed;)
    RegisterDefaultAllocator();
    Factory::sInstance = new Factory();
    RegisterTypes();
}

void JoltHelpers::Shutdown()
{
    UnregisterTypes();
    delete Factory::sInstance;
    Factory::sInstance = nullptr;
}

float JoltHelpers::RayAABox(JPH::Vec3Arg inOrigin, const JPH::RayInvDirection& inInvDirection, JPH::Vec3Arg inBoundsMin, JPH::Vec3Arg inBoundsMax)
{
    return JPH::RayAABox(inOrigin, inInvDirection, inBoundsMin, inBoundsMax);
}

void JoltHelpers::VehicleSettingsAddWheel(JPH::VehicleConstraintSettings& settings, JPH::WheelSettingsWV* wheel)
{
    settings.mWheels.push_back(wheel);
}

void JoltHelpers::VehicleSettingsSetController(JPH::VehicleConstraintSettings& settings, JPH::WheeledVehicleControllerSettings* ctrl)
{
    settings.mController = ctrl;
}

void JoltHelpers::VehicleSettingsAddAntiRollBar(JPH::VehicleConstraintSettings& settings, const JPH::VehicleAntiRollBar& bar)
{
    settings.mAntiRollBars.push_back(bar);
}

void JoltHelpers::WheeledControllerSettingsAddDifferential(JPH::WheeledVehicleControllerSettings& settings, const JPH::VehicleDifferentialSettings& diff)
{
    settings.mDifferentials.push_back(diff);
}

JPH::WheeledVehicleController* JoltHelpers::VehicleConstraintGetWheeledController(JPH::VehicleConstraint& constraint)
{
    // Jolt is compiled without RTTI; use static_cast since the caller is responsible
    // for only calling this when the vehicle uses a WheeledVehicleControllerSettings.
    return static_cast<JPH::WheeledVehicleController*>(constraint.GetController());
}

void JoltHelpers::VehicleSettingsAddWheelTV(JPH::VehicleConstraintSettings& settings, JPH::WheelSettingsTV* wheel)
{
    settings.mWheels.push_back(wheel);
}

void JoltHelpers::VehicleSettingsSetTrackedController(JPH::VehicleConstraintSettings& settings, JPH::TrackedVehicleControllerSettings* ctrl)
{
    settings.mController = ctrl;
}

void JoltHelpers::VehicleTrackSettingsAddWheelIndex(JPH::VehicleTrackSettings& track, JPH::uint32 wheelIndex)
{
    track.mWheels.push_back(wheelIndex);
}

void JoltHelpers::VehicleTransmissionSettingsSetGearRatios(
    JPH::VehicleTransmissionSettings& inSettings,
    const float* inRatios,
    unsigned int inCount)
{
    inSettings.mGearRatios.assign(inRatios, inRatios + inCount);
}

void JoltHelpers::VehicleTransmissionSettingsSetReverseGearRatios(
    JPH::VehicleTransmissionSettings& inSettings,
    const float* inRatios,
    unsigned int inCount)
{
    inSettings.mReverseGearRatios.assign(inRatios, inRatios + inCount);
}

// ---------------------------------------------------------------------------
// BodyCreationSettings helpers
// ---------------------------------------------------------------------------

void JoltHelpers::BodyCreationSettingsSetOverrideMassProperties(
    JPH::BodyCreationSettings& inSettings,
    int inMode)
{
    inSettings.mOverrideMassProperties =
        static_cast<JPH::EOverrideMassProperties>(inMode);
}

void JoltHelpers::BodyCreationSettingsSetMassOverride(
    JPH::BodyCreationSettings& inSettings,
    float inMass)
{
    inSettings.mMassPropertiesOverride.mMass = inMass;
}

float JoltHelpers::BodyCreationSettingsGetMassOverride(
    const JPH::BodyCreationSettings& inSettings)
{
    return inSettings.mMassPropertiesOverride.mMass;
}

// ---------------------------------------------------------------------------
// HeightFieldShape helpers
// ---------------------------------------------------------------------------

void JoltHelpers::HeightFieldSettingsSetHeightSamples(JPH::HeightFieldShapeSettings& inSettings, const float* inSamples, unsigned int inCount)
{
    inSettings.mHeightSamples.assign(inSamples, inSamples + inCount);
}

void JoltHelpers::HeightFieldSettingsResizeHeightSamples(JPH::HeightFieldShapeSettings& inSettings, unsigned int inCount, float inFillValue)
{
    inSettings.mHeightSamples.resize(inCount, inFillValue);
}

void JoltHelpers::HeightFieldSettingsSetHeightSampleAt(JPH::HeightFieldShapeSettings& inSettings, unsigned int inIndex, float inValue)
{
    inSettings.mHeightSamples[inIndex] = inValue;
}

unsigned int JoltHelpers::HeightFieldSettingsGetHeightSamplesCount(const JPH::HeightFieldShapeSettings& inSettings)
{
    return static_cast<unsigned int>(inSettings.mHeightSamples.size());
}

float JoltHelpers::HeightFieldSettingsGetHeightSample(const JPH::HeightFieldShapeSettings& inSettings, unsigned int inIndex)
{
    return inSettings.mHeightSamples[inIndex];
}

float JoltHelpers::HeightFieldShapeConstantsNoCollisionValue()
{
    return JPH::HeightFieldShapeConstants::cNoCollisionValue;
}

JPH::Vec3 JoltHelpers::HeightFieldShapeGetPosition(const JPH::Shape& inShape, JPH::uint inX, JPH::uint inY)
{
    return static_cast<const JPH::HeightFieldShape&>(inShape).GetPosition(inX, inY);
}

bool JoltHelpers::HeightFieldShapeIsNoCollision(const JPH::Shape& inShape, JPH::uint inX, JPH::uint inY)
{
    return static_cast<const JPH::HeightFieldShape&>(inShape).IsNoCollision(inX, inY);
}

// ---------------------------------------------------------------------------
// SoftBody helpers
// ---------------------------------------------------------------------------

void JoltHelpers::SoftBodySettingsAddVertex(JPH::SoftBodySharedSettings& inSettings, const JPH::SoftBodySharedSettings::Vertex& inVertex)
{
    inSettings.mVertices.push_back(inVertex);
}

unsigned int JoltHelpers::SoftBodySettingsGetVertexCount(const JPH::SoftBodySharedSettings& inSettings)
{
    return static_cast<unsigned int>(inSettings.mVertices.size());
}

unsigned int JoltHelpers::SoftBodySettingsGetFaceCount(const JPH::SoftBodySharedSettings& inSettings)
{
    return static_cast<unsigned int>(inSettings.mFaces.size());
}

JPH::uint32 JoltHelpers::SoftBodySettingsGetFaceVertex(const JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inFaceIndex, JPH::uint32 inVertexSlot)
{
    return inSettings.mFaces[inFaceIndex].mVertex[inVertexSlot];
}

JPH::SoftBodySharedSettings* JoltHelpers::SoftBodySettingsCreateCube(JPH::uint inGridSize, float inGridSpacing)
{
    JPH::Ref<JPH::SoftBodySharedSettings> ref = JPH::SoftBodySharedSettings::sCreateCube(inGridSize, inGridSpacing);
    ref->AddRef(); // Transfer ownership: prevent destruction when ref goes out of scope
    return ref.GetPtr();
}

void JoltHelpers::SoftBodySettingsAddRodStretchShear(JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inVertex1, JPH::uint32 inVertex2)
{
    inSettings.mRodStretchShearConstraints.push_back(JPH::SoftBodySharedSettings::RodStretchShear(inVertex1, inVertex2));
}

void JoltHelpers::SoftBodySettingsAddRodBendTwist(JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inRod1, JPH::uint32 inRod2)
{
    inSettings.mRodBendTwistConstraints.push_back(JPH::SoftBodySharedSettings::RodBendTwist(inRod1, inRod2));
}

unsigned int JoltHelpers::SoftBodySettingsGetRodStretchShearCount(const JPH::SoftBodySharedSettings& inSettings)
{
    return static_cast<unsigned int>(inSettings.mRodStretchShearConstraints.size());
}

JPH::uint32 JoltHelpers::SoftBodySettingsGetRodStretchShearVertex(const JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inIndex, JPH::uint32 inSlot)
{
    return inSettings.mRodStretchShearConstraints[inIndex].mVertex[inSlot];
}

void JoltHelpers::SoftBodySettingsAddSkinned(JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius)
{
    inSettings.mSkinnedConstraints.push_back(JPH::SoftBodySharedSettings::Skinned(inVertex, inMaxDistance, inBackStopDistance, inBackStopRadius));
}

void JoltHelpers::SoftBodySettingsAddInvBind(JPH::SoftBodySharedSettings& inSettings, JPH::uint32 inJointIndex, JPH::Mat44Arg inInvBind)
{
    inSettings.mInvBindMatrices.push_back(JPH::SoftBodySharedSettings::InvBind(inJointIndex, inInvBind));
}

unsigned int JoltHelpers::BodyGetSoftBodyVertexCount(const JPH::Body& inBody)
{
    const auto* mp = static_cast<const JPH::SoftBodyMotionProperties*>(inBody.GetMotionProperties());
    return static_cast<unsigned int>(mp->GetVertices().size());
}

JPH::Vec3 JoltHelpers::BodyGetSoftBodyVertexPosition(const JPH::Body& inBody, JPH::uint inIndex)
{
    const auto* mp = static_cast<const JPH::SoftBodyMotionProperties*>(inBody.GetMotionProperties());
    return mp->GetVertex(inIndex).mPosition;
}

void JoltHelpers::BodySetSoftBodyVertexPosition(JPH::Body& inBody, JPH::uint inIndex, JPH::Vec3Arg inPosition)
{
    auto* mp = static_cast<JPH::SoftBodyMotionProperties*>(inBody.GetMotionProperties());
    mp->GetVertex(inIndex).mPosition = inPosition;
}

float JoltHelpers::BodyGetInverseMass(const JPH::Body& inBody)
{
    return inBody.GetMotionProperties()->GetInverseMass();
}

unsigned int JoltHelpers::PhysicsSystemGetSoftBodyVertexCount(const JPH::PhysicsSystem& inSystem, const JPH::BodyID& inBodyID)
{
    JPH::BodyLockRead lock(inSystem.GetBodyLockInterface(), inBodyID);
    if (!lock.Succeeded()) return 0;
    const JPH::Body& body = lock.GetBody();
    return static_cast<unsigned int>(
        static_cast<const JPH::SoftBodyMotionProperties*>(body.GetMotionProperties())->GetVertices().size());
}

JPH::Vec3 JoltHelpers::PhysicsSystemGetSoftBodyVertexPosition(const JPH::PhysicsSystem& inSystem, const JPH::BodyID& inBodyID, JPH::uint inIndex)
{
    JPH::BodyLockRead lock(inSystem.GetBodyLockInterface(), inBodyID);
    if (!lock.Succeeded()) return JPH::Vec3::sZero();
    const JPH::Body& body = lock.GetBody();
    const auto& verts = static_cast<const JPH::SoftBodyMotionProperties*>(body.GetMotionProperties())->GetVertices();
    if (inIndex >= verts.size()) return JPH::Vec3::sZero();
    return verts[inIndex].mPosition;
}

void JoltHelpers::CharacterBaseSettingsSetShape(JPH::CharacterBaseSettings& inSettings, const JPH::Shape* inShape)
{
    inSettings.mShape = inShape;
}

// ---------------------------------------------------------------------------
// Ragdoll helpers
// ---------------------------------------------------------------------------

void JoltHelpers::RagdollSettingsSetSkeleton(JPH::RagdollSettings& inSettings, JPH::Skeleton* inSkeleton)
{
    inSettings.mSkeleton = inSkeleton;
}

JPH::Skeleton* JoltHelpers::RagdollSettingsGetSkeleton(const JPH::RagdollSettings& inSettings)
{
    return inSettings.mSkeleton;
}

void JoltHelpers::RagdollSettingsAddPart(JPH::RagdollSettings& inSettings, const JPH::RagdollSettings::Part& inPart)
{
    inSettings.mParts.push_back(inPart);
}

unsigned int JoltHelpers::RagdollSettingsGetPartCount(const JPH::RagdollSettings& inSettings)
{
    return static_cast<unsigned int>(inSettings.mParts.size());
}

const JPH::RagdollSettings::Part& JoltHelpers::RagdollSettingsGetPart(const JPH::RagdollSettings& inSettings, unsigned int inIndex)
{
    return inSettings.mParts[inIndex];
}

// ---------------------------------------------------------------------------
// Skeleton helpers
// ---------------------------------------------------------------------------

unsigned int JoltHelpers::SkeletonAddJoint(JPH::Skeleton& inSkeleton, const char* inName)
{
    return inSkeleton.AddJoint(inName);
}

unsigned int JoltHelpers::SkeletonAddJointWithParentName(JPH::Skeleton& inSkeleton, const char* inName, const char* inParentName)
{
    return inSkeleton.AddJoint(inName, inParentName);
}

unsigned int JoltHelpers::SkeletonAddJointWithParentIndex(JPH::Skeleton& inSkeleton, const char* inName, int inParentIndex)
{
    return inSkeleton.AddJoint(inName, inParentIndex);
}

// ---------------------------------------------------------------------------
// ConvexHullShapeSettings from Float3 array
// ---------------------------------------------------------------------------

JPH::ConvexHullShapeSettings* JoltHelpers::ConvexHullShapeSettingsFromFloat3Array(
    const JPH::Float3* inPoints, int inNumPoints,
    float inMaxConvexRadius, const JPH::PhysicsMaterial* inMaterial)
{
    JPH::Array<JPH::Vec3> pts;
    pts.reserve(inNumPoints);
    for (int i = 0; i < inNumPoints; ++i)
        pts.emplace_back(inPoints[i].x, inPoints[i].y, inPoints[i].z);
    return new JPH::ConvexHullShapeSettings(pts, inMaxConvexRadius, inMaterial);
}

// ---------------------------------------------------------------------------
// ContactListenerTrampoline
// ---------------------------------------------------------------------------

JPH::ValidateResult ContactListenerTrampoline::OnContactValidate(
    const JPH::Body& inBody1, const JPH::Body& inBody2,
    JPH::RVec3Arg inBaseOffset, const JPH::CollideShapeResult& inCollisionResult)
{
    if (mOnContactValidateFn == nullptr)
        return JPH::ValidateResult::AcceptAllContactsForThisBodyPair;
    using Fn = int(*)(void*, const JPH::Body*, const JPH::Body*, const JPH::Vec3*, const JPH::CollideShapeResult*);
    JPH::Vec3 base(inBaseOffset);
    return static_cast<JPH::ValidateResult>(reinterpret_cast<Fn>(mOnContactValidateFn)(
        mContext, &inBody1, &inBody2, &base, &inCollisionResult));
}

void ContactListenerTrampoline::OnContactAdded(
    const JPH::Body& inBody1, const JPH::Body& inBody2,
    const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings)
{
    if (mOnContactAddedFn == nullptr) return;
    using Fn = void(*)(void*, const JPH::Body*, const JPH::Body*, const JPH::ContactManifold*, JPH::ContactSettings*);
    reinterpret_cast<Fn>(mOnContactAddedFn)(mContext, &inBody1, &inBody2, &inManifold, &ioSettings);
}

void ContactListenerTrampoline::OnContactPersisted(
    const JPH::Body& inBody1, const JPH::Body& inBody2,
    const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings)
{
    if (mOnContactPersistedFn == nullptr) return;
    using Fn = void(*)(void*, const JPH::Body*, const JPH::Body*, const JPH::ContactManifold*, JPH::ContactSettings*);
    reinterpret_cast<Fn>(mOnContactPersistedFn)(mContext, &inBody1, &inBody2, &inManifold, &ioSettings);
}

void ContactListenerTrampoline::OnContactRemoved(const JPH::SubShapeIDPair& inSubShapePair)
{
    if (mOnContactRemovedFn == nullptr) return;
    using Fn = void(*)(void*, const JPH::SubShapeIDPair*);
    reinterpret_cast<Fn>(mOnContactRemovedFn)(mContext, &inSubShapePair);
}

// ---------------------------------------------------------------------------
// CountingPhysicsStepListener
// ---------------------------------------------------------------------------

void CountingPhysicsStepListener::OnStep(const JPH::PhysicsStepListenerContext& inContext)
{
    mCount++;
    mLastDeltaTime = inContext.mDeltaTime;
    mLastIsFirst   = inContext.mIsFirstStep;
    mLastIsLast    = inContext.mIsLastStep;
}

// ---------------------------------------------------------------------------
// SimpleContactEventListener
// ---------------------------------------------------------------------------

void SimpleContactEventListener::Reset()
{
    mValidateCount = mAddedCount = mPersistedCount = mRemovedCount = 0;
    mLastAddedBody1 = mLastAddedBody2 = JPH::BodyID();
}

JPH::ValidateResult SimpleContactEventListener::OnContactValidate(
    const JPH::Body& /*inBody1*/, const JPH::Body& /*inBody2*/,
    JPH::RVec3Arg /*inBaseOffset*/, const JPH::CollideShapeResult& /*inCollisionResult*/)
{
    mValidateCount++;
    return JPH::ValidateResult::AcceptAllContactsForThisBodyPair;
}

void SimpleContactEventListener::OnContactAdded(
    const JPH::Body& inBody1, const JPH::Body& inBody2,
    const JPH::ContactManifold& /*inManifold*/, JPH::ContactSettings& /*ioSettings*/)
{
    mAddedCount++;
    mLastAddedBody1 = inBody1.GetID();
    mLastAddedBody2 = inBody2.GetID();
}

void SimpleContactEventListener::OnContactPersisted(
    const JPH::Body& /*inBody1*/, const JPH::Body& /*inBody2*/,
    const JPH::ContactManifold& /*inManifold*/, JPH::ContactSettings& /*ioSettings*/)
{
    mPersistedCount++;
}

void SimpleContactEventListener::OnContactRemoved(const JPH::SubShapeIDPair& /*inSubShapePair*/)
{
    mRemovedCount++;
}

// ---------------------------------------------------------------------------
// EstimateResponseContactListener
// ---------------------------------------------------------------------------

void EstimateResponseContactListener::OnContactAdded(
    const JPH::Body& inBody1, const JPH::Body& inBody2,
    const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings)
{
    JPH::CollisionEstimationResult result;
    JPH::EstimateCollisionResponse(inBody1, inBody2, inManifold, result,
        ioSettings.mCombinedFriction, ioSettings.mCombinedRestitution);
    mLinearVelocity1  = result.mLinearVelocity1;
    mAngularVelocity1 = result.mAngularVelocity1;
    mLinearVelocity2  = result.mLinearVelocity2;
    mAngularVelocity2 = result.mAngularVelocity2;
    mWasCalled = true;
}

// ---------------------------------------------------------------------------
// RecordingDebugRenderer
// ---------------------------------------------------------------------------
#ifdef JPH_DEBUG_RENDERER

void RecordingDebugRenderer::DrawLine(JPH::RVec3Arg inFrom, JPH::RVec3Arg inTo, JPH::ColorArg inColor)
{
    mLines.push_back({inFrom, inTo, inColor});
}

void RecordingDebugRenderer::DrawTriangle(JPH::RVec3Arg inV1, JPH::RVec3Arg inV2, JPH::RVec3Arg inV3, JPH::ColorArg inColor, ECastShadow /*inCastShadow*/)
{
    mTriangles.push_back({inV1, inV2, inV3, inColor});
}

#endif // JPH_DEBUG_RENDERER

