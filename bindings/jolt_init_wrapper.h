#pragma once
/* jolt_init_wrapper.h — Parsed by mrbind to auto-generate C and C# bindings.
 * Only contains APIs that cannot be expressed through Jolt's own headers:
 *   - Global lifecycle (mrbind only binds named types, not free functions)
 *   - Vec3/RVec3 bridge methods (SIMD types mrbind cannot bind directly)
 *   - Free function wrappers (mrbind only binds named types, not free functions)
 *   - Concrete subclasses for virtual dispatch (C# cannot subclass C++ virtual classes) */

#include <Jolt/Jolt.h>
#include <Jolt/Geometry/RayAABox.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>
#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/Collision/ContactListener.h>
#include <Jolt/Physics/Collision/EstimateCollisionResponse.h>
#include <Jolt/Physics/Collision/Shape/HeightFieldShape.h>
#include <Jolt/Physics/Collision/Shape/ConvexHullShape.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Physics/SoftBody/SoftBodyMotionProperties.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#ifdef JPH_DEBUG_RENDERER
#include <Jolt/Renderer/DebugRendererSimple.h>
#endif

/// Minimal helpers for Jolt global lifecycle.
/// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
struct JoltHelpers
{
    /// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
    static void Init();
    static void Shutdown();

    /// Wrapper for the free function JPH::RayAABox (mrbind only binds named types).
    /// Returns the minimal distance along the ray, or FLT_MAX if no hit.
    /// Note: can return a negative value if the ray starts inside the box.
    static float RayAABox(JPH::Vec3Arg inOrigin, const JPH::RayInvDirection& inInvDirection, JPH::Vec3Arg inBoundsMin, JPH::Vec3Arg inBoundsMax);

    // -----------------------------------------------------------------------
    // Vehicle helpers — expose Array field manipulation to C# (mrbind cannot
    // bind std::vector / JPH::Array directly).
    // -----------------------------------------------------------------------

    /// Append a WheelSettingsWV to VehicleConstraintSettings::mWheels.
    static void VehicleSettingsAddWheel(JPH::VehicleConstraintSettings& settings, JPH::WheelSettingsWV* wheel);

    /// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
    static void VehicleSettingsSetController(JPH::VehicleConstraintSettings& settings, JPH::WheeledVehicleControllerSettings* ctrl);

    /// Append a VehicleAntiRollBar to VehicleConstraintSettings::mAntiRollBars.
    static void VehicleSettingsAddAntiRollBar(JPH::VehicleConstraintSettings& settings, const JPH::VehicleAntiRollBar& bar);

    /// Append a VehicleDifferentialSettings to WheeledVehicleControllerSettings::mDifferentials.
    static void WheeledControllerSettingsAddDifferential(JPH::WheeledVehicleControllerSettings& settings, const JPH::VehicleDifferentialSettings& diff);

    /// Cast the VehicleController on a VehicleConstraint to WheeledVehicleController.
    /// Returns nullptr if the controller is not a WheeledVehicleController.
    static JPH::WheeledVehicleController* VehicleConstraintGetWheeledController(JPH::VehicleConstraint& constraint);

    // -----------------------------------------------------------------------
    // HeightFieldShape helpers — expose mHeightSamples array to C#
    // (mHeightSamples is std::vector<float>, mrbind cannot bind STL containers).
    // -----------------------------------------------------------------------

    /// Assign the height samples array (replaces existing content).
    static void HeightFieldSettingsSetHeightSamples(JPH::HeightFieldShapeSettings& inSettings, const float* inSamples, unsigned int inCount);
    /// Resize the height samples array to inCount elements, filling with inFillValue.
    static void HeightFieldSettingsResizeHeightSamples(JPH::HeightFieldShapeSettings& inSettings, unsigned int inCount, float inFillValue);
    /// Set the height sample at a specific index.
    static void HeightFieldSettingsSetHeightSampleAt(JPH::HeightFieldShapeSettings& inSettings, unsigned int inIndex, float inValue);
    /// Return the number of height samples currently stored.
    static unsigned int HeightFieldSettingsGetHeightSamplesCount(const JPH::HeightFieldShapeSettings& inSettings);
    /// Return a single height sample by index.
    static float HeightFieldSettingsGetHeightSample(const JPH::HeightFieldShapeSettings& inSettings, unsigned int inIndex);
    /// Return HeightFieldShapeConstants::cNoCollisionValue (sentinel height = no-collision).
    static float HeightFieldShapeConstantsNoCollisionValue();
    /// Return the world-space position of a HeightFieldShape sample at (inX, inY).
    /// (Wraps HeightFieldShape::GetPosition; accepts base Shape& to avoid requiring a downcast in C#.)
    static JPH::Vec3 HeightFieldShapeGetPosition(const JPH::Shape& inShape, JPH::uint inX, JPH::uint inY);
    /// Return true if the sample at (inX, inY) has no collision (is a "hole").
    static bool HeightFieldShapeIsNoCollision(const JPH::Shape& inShape, JPH::uint inX, JPH::uint inY);

    // -----------------------------------------------------------------------
    // SoftBody helpers — vertex array + runtime vertex access.
    // -----------------------------------------------------------------------

    /// Append a vertex to SoftBodySharedSettings::mVertices.
    static void SoftBodySettingsAddVertex(JPH::SoftBodySharedSettings& inSettings, const JPH::SoftBodySharedSettings::Vertex& inVertex);
    /// Return the number of vertices in SoftBodySharedSettings::mVertices.
    static unsigned int SoftBodySettingsGetVertexCount(const JPH::SoftBodySharedSettings& inSettings);
    /// Create a cube soft body and return an owning pointer (caller must eventually Release() it).
    static JPH::SoftBodySharedSettings* SoftBodySettingsCreateCube(JPH::uint inGridSize, float inGridSpacing);
    /// Return the number of runtime vertices in a soft body (via SoftBodyMotionProperties).
    static unsigned int BodyGetSoftBodyVertexCount(const JPH::Body& inBody);
    /// Return the position of a runtime soft body vertex.
    static JPH::Vec3 BodyGetSoftBodyVertexPosition(const JPH::Body& inBody, JPH::uint inIndex);
    /// Set the position of a runtime soft body vertex.
    static void BodySetSoftBodyVertexPosition(JPH::Body& inBody, JPH::uint inIndex, JPH::Vec3Arg inPosition);
    /// Return the inverse mass of the body (soft or rigid) via MotionProperties.
    static float BodyGetInverseMass(const JPH::Body& inBody);
    /// Get the number of soft-body vertices for the body with the given ID.
    /// Must be called with the physics system locked (outside of simulation step).
    static unsigned int PhysicsSystemGetSoftBodyVertexCount(const JPH::PhysicsSystem& inSystem, const JPH::BodyID& inBodyID);
    /// Get the position of a soft-body vertex by body ID and vertex index.
    /// Must be called with the physics system locked (outside of simulation step).
    static JPH::Vec3 PhysicsSystemGetSoftBodyVertexPosition(const JPH::PhysicsSystem& inSystem, const JPH::BodyID& inBodyID, JPH::uint inIndex);

    /// Set the shape on a CharacterBaseSettings (mShape is a RefConst<Shape> not directly bindable).
    static void CharacterBaseSettingsSetShape(JPH::CharacterBaseSettings& inSettings, const JPH::Shape* inShape);

    // -----------------------------------------------------------------------
    // Ragdoll helpers — expose mSkeleton and mParts array to C#
    // (mSkeleton is Ref<Skeleton>, mParts is Array<Part>; mrbind skips both).
    // -----------------------------------------------------------------------

    /// Set the skeleton on a RagdollSettings (mSkeleton is Ref<Skeleton>).
    static void RagdollSettingsSetSkeleton(JPH::RagdollSettings& inSettings, JPH::Skeleton* inSkeleton);
    /// Get the skeleton from a RagdollSettings (returns raw pointer, not Ref).
    static JPH::Skeleton* RagdollSettingsGetSkeleton(const JPH::RagdollSettings& inSettings);
    /// Append a Part to RagdollSettings::mParts.
    static void RagdollSettingsAddPart(JPH::RagdollSettings& inSettings, const JPH::RagdollSettings::Part& inPart);
    /// Return the number of parts in RagdollSettings::mParts.
    static unsigned int RagdollSettingsGetPartCount(const JPH::RagdollSettings& inSettings);
    /// Return a reference to a Part by index.
    static const JPH::RagdollSettings::Part& RagdollSettingsGetPart(const JPH::RagdollSettings& inSettings, unsigned int inIndex);

    // -----------------------------------------------------------------------
    // Skeleton helpers — AddJoint wrappers (mrbind cannot bind AddJoint because
    // JPH::Array<T> mutation is not supported by the generator).
    // -----------------------------------------------------------------------

    /// Add a root joint (no parent) to a Skeleton. Returns the joint index.
    static unsigned int SkeletonAddJoint(JPH::Skeleton& inSkeleton, const char* inName);
    /// Add a joint with a named parent. Returns the joint index.
    static unsigned int SkeletonAddJointWithParentName(JPH::Skeleton& inSkeleton, const char* inName, const char* inParentName);
    /// Add a joint with a parent index. Returns the joint index.
    static unsigned int SkeletonAddJointWithParentIndex(JPH::Skeleton& inSkeleton, const char* inName, int inParentIndex);

    // -----------------------------------------------------------------------
    // ConvexHullShapeSettings Float3-array constructor
    // (Vec3 is SIMD-aligned and cannot form a contiguous C array from managed code;
    //  Float3 is a plain {float x,y,z} struct with the same layout as System.Numerics.Vector3).
    // -----------------------------------------------------------------------

    /// Create a ConvexHullShapeSettings from an array of Float3 points.
    static JPH::ConvexHullShapeSettings* ConvexHullShapeSettingsFromFloat3Array(
        const JPH::Float3* inPoints, int inNumPoints,
        float inMaxConvexRadius, const JPH::PhysicsMaterial* inMaterial);
};

// ---------------------------------------------------------------------------
// CountingPhysicsStepListener — concrete PhysicsStepListener for C# tests.
// Counts how many times OnStep was called and stores the last context values.
// ---------------------------------------------------------------------------
struct CountingPhysicsStepListener : public JPH::PhysicsStepListener
{
    int   mCount          = 0;
    float mLastDeltaTime  = 0.0f;
    bool  mLastIsFirst    = false;
    bool  mLastIsLast     = false;

    void  Reset()                { mCount = 0; mLastDeltaTime = 0.0f; mLastIsFirst = false; mLastIsLast = false; }
    int   GetCount()       const { return mCount; }
    float GetLastDeltaTime() const { return mLastDeltaTime; }
    bool  GetLastIsFirst() const { return mLastIsFirst; }
    bool  GetLastIsLast()  const { return mLastIsLast; }

    virtual void OnStep(const JPH::PhysicsStepListenerContext& inContext) override;
};

// ---------------------------------------------------------------------------
// SimpleContactEventListener — concrete ContactListener for C# tests.
// Counts contact events and records the last added body pair.
// ---------------------------------------------------------------------------
struct SimpleContactEventListener : public JPH::ContactListener
{
    int         mValidateCount  = 0;
    int         mAddedCount     = 0;
    int         mPersistedCount = 0;
    int         mRemovedCount   = 0;
    JPH::BodyID mLastAddedBody1;
    JPH::BodyID mLastAddedBody2;

    void Reset();
    int  GetValidateCount()  const { return mValidateCount; }
    int  GetAddedCount()     const { return mAddedCount; }
    int  GetPersistedCount() const { return mPersistedCount; }
    int  GetRemovedCount()   const { return mRemovedCount; }
    const JPH::BodyID& GetLastAddedBody1() const { return mLastAddedBody1; }
    const JPH::BodyID& GetLastAddedBody2() const { return mLastAddedBody2; }

    virtual JPH::ValidateResult OnContactValidate(const JPH::Body& inBody1, const JPH::Body& inBody2, JPH::RVec3Arg inBaseOffset, const JPH::CollideShapeResult& inCollisionResult) override;
    virtual void OnContactAdded(const JPH::Body& inBody1, const JPH::Body& inBody2, const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings) override;
    virtual void OnContactPersisted(const JPH::Body& inBody1, const JPH::Body& inBody2, const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings) override;
    virtual void OnContactRemoved(const JPH::SubShapeIDPair& inSubShapePair) override;
};

// ---------------------------------------------------------------------------
// ContactListenerTrampoline — concrete ContactListener that dispatches to
// C# function pointers.  Set mContext and the four mXxxFn fields; leave any
// field null to get the default (AcceptAll for Validate, no-op for the rest).
//
// Function pointer signatures (all __cdecl / C calling convention):
//   OnContactValidate : int  (*)(void* ctx,
//                                const JPH::Body* body1, const JPH::Body* body2,
//                                const JPH::Vec3* baseOffset,
//                                const JPH::CollideShapeResult* result)
//                       Return value maps to JPH::ValidateResult (0 = AcceptAll, etc.)
//   OnContactAdded    : void (*)(void* ctx,
//                                const JPH::Body* body1, const JPH::Body* body2,
//                                const JPH::ContactManifold* manifold,
//                                JPH::ContactSettings* settings)
//   OnContactPersisted: same signature as OnContactAdded
//   OnContactRemoved  : void (*)(void* ctx, const JPH::SubShapeIDPair* pair)
// ---------------------------------------------------------------------------
struct ContactListenerTrampoline : public JPH::ContactListener
{
    void* mContext              = nullptr;
    void* mOnContactValidateFn  = nullptr;
    void* mOnContactAddedFn     = nullptr;
    void* mOnContactPersistedFn = nullptr;
    void* mOnContactRemovedFn   = nullptr;

    void* GetContext()              const { return mContext; }
    void  SetContext(void* v)             { mContext = v; }
    void* GetOnContactValidateFn()  const { return mOnContactValidateFn; }
    void  SetOnContactValidateFn(void* v)  { mOnContactValidateFn  = v; }
    void* GetOnContactAddedFn()     const { return mOnContactAddedFn; }
    void  SetOnContactAddedFn(void* v)     { mOnContactAddedFn     = v; }
    void* GetOnContactPersistedFn() const { return mOnContactPersistedFn; }
    void  SetOnContactPersistedFn(void* v) { mOnContactPersistedFn = v; }
    void* GetOnContactRemovedFn()   const { return mOnContactRemovedFn; }
    void  SetOnContactRemovedFn(void* v)   { mOnContactRemovedFn   = v; }

    virtual JPH::ValidateResult OnContactValidate(const JPH::Body& inBody1, const JPH::Body& inBody2, JPH::RVec3Arg inBaseOffset, const JPH::CollideShapeResult& inCollisionResult) override;
    virtual void OnContactAdded(const JPH::Body& inBody1, const JPH::Body& inBody2, const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings) override;
    virtual void OnContactPersisted(const JPH::Body& inBody1, const JPH::Body& inBody2, const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings) override;
    virtual void OnContactRemoved(const JPH::SubShapeIDPair& inSubShapePair) override;
};

// ---------------------------------------------------------------------------
// EstimateResponseContactListener — concrete ContactListener that runs
// EstimateCollisionResponse in OnContactAdded and stores the result.
// ---------------------------------------------------------------------------
struct EstimateResponseContactListener : public JPH::ContactListener
{
    bool      mWasCalled        = false;
    JPH::Vec3 mLinearVelocity1  = JPH::Vec3::sZero();
    JPH::Vec3 mAngularVelocity1 = JPH::Vec3::sZero();
    JPH::Vec3 mLinearVelocity2  = JPH::Vec3::sZero();
    JPH::Vec3 mAngularVelocity2 = JPH::Vec3::sZero();

    void Reset() { mWasCalled = false; }
    bool WasCalled() const { return mWasCalled; }
    const JPH::Vec3& GetLinearVelocity1()  const { return mLinearVelocity1; }
    const JPH::Vec3& GetAngularVelocity1() const { return mAngularVelocity1; }
    const JPH::Vec3& GetLinearVelocity2()  const { return mLinearVelocity2; }
    const JPH::Vec3& GetAngularVelocity2() const { return mAngularVelocity2; }

    virtual void OnContactAdded(const JPH::Body& inBody1, const JPH::Body& inBody2, const JPH::ContactManifold& inManifold, JPH::ContactSettings& ioSettings) override;
};

// ---------------------------------------------------------------------------
// DebugRenderer support — only compiled when JPH_DEBUG_RENDERER is defined
// (set DEBUG_RENDERER_IN_DEBUG_AND_RELEASE=ON in CMakeLists.txt).
// ---------------------------------------------------------------------------
#ifdef JPH_DEBUG_RENDERER

/// Plain record of a single DrawLine call captured by RecordingDebugRenderer.
struct DebugLineRecord
{
    JPH::RVec3 mFrom;
    JPH::RVec3 mTo;
    JPH::Color mColor;
};

/// Plain record of a single DrawTriangle call captured by RecordingDebugRenderer.
struct DebugTriangleRecord
{
    JPH::RVec3 mV1;
    JPH::RVec3 mV2;
    JPH::RVec3 mV3;
    JPH::Color mColor;
};

/// Concrete DebugRenderer that records all DrawLine / DrawTriangle calls so
/// C# can inspect them.  Inherits DebugRendererSimple to avoid re-implementing
/// CreateTriangleBatch and DrawGeometry.
///
/// Lifecycle: only one instance may exist at a time (enforced by
/// DebugRenderer's singleton assert).  Call Clear() between frames.
struct RecordingDebugRenderer : public JPH::DebugRendererSimple
{
    JPH::Array<DebugLineRecord>     mLines;
    JPH::Array<DebugTriangleRecord> mTriangles;

    void         Clear()                              { mLines.clear(); mTriangles.clear(); }
    unsigned int GetLineCount()             const     { return (unsigned int)mLines.size(); }
    unsigned int GetTriangleCount()         const     { return (unsigned int)mTriangles.size(); }
    const DebugLineRecord&     GetLine(unsigned int inIndex)     const { return mLines[inIndex]; }
    const DebugTriangleRecord& GetTriangle(unsigned int inIndex) const { return mTriangles[inIndex]; }

    virtual void DrawLine(JPH::RVec3Arg inFrom, JPH::RVec3Arg inTo, JPH::ColorArg inColor) override;
    virtual void DrawTriangle(JPH::RVec3Arg inV1, JPH::RVec3Arg inV2, JPH::RVec3Arg inV3, JPH::ColorArg inColor, ECastShadow inCastShadow) override;

private:
    // DrawText3D uses std::string_view which cannot be marshalled; implemented
    // as a no-op and kept private so mrbind does not try to expose it.
    virtual void DrawText3D(JPH::RVec3Arg, const JPH::string_view&, JPH::ColorArg, float) override {}
};

#endif // JPH_DEBUG_RENDERER
