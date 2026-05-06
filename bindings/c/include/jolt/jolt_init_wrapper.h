// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Collision/ContactListener.h>
#include <jolt/Jolt/Renderer/DebugRenderer.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyCreationSettings JPH_BodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/Body/BodyCreationSettings.h>`.
typedef struct JPH_CharacterBaseSettings JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterBase.h>`.
typedef struct JPH_CollideShapeResult JPH_CollideShapeResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_ContactListener JPH_ContactListener; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_ContactManifold JPH_ContactManifold; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_ContactSettings JPH_ContactSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_ConvexHullShapeSettings JPH_ConvexHullShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexHullShape.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_DebugRendererSimple JPH_DebugRendererSimple; // Defined in `#include <jolt/Jolt/Renderer/DebugRendererSimple.h>`.
typedef struct JPH_DebugRenderer_Vertex JPH_DebugRenderer_Vertex; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_HeightFieldShapeSettings JPH_HeightFieldShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/HeightFieldShape.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_PhysicsStepListener JPH_PhysicsStepListener; // Defined in `#include <jolt/Jolt/Physics/PhysicsStepListener.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_RagdollSettings JPH_RagdollSettings; // Defined in `#include <jolt/Jolt/Physics/Ragdoll/Ragdoll.h>`.
typedef struct JPH_RagdollSettings_Part JPH_RagdollSettings_Part; // Defined in `#include <jolt/Jolt/Physics/Ragdoll/Ragdoll.h>`.
typedef struct JPH_RayInvDirection JPH_RayInvDirection; // Defined in `#include <jolt/Jolt/Geometry/RayAABox.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Skeleton JPH_Skeleton; // Defined in `#include <jolt/Jolt/Skeleton/Skeleton.h>`.
typedef struct JPH_SoftBodySharedSettings JPH_SoftBodySharedSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SoftBodySharedSettings_Vertex JPH_SoftBodySharedSettings_Vertex; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SubShapeIDPair JPH_SubShapeIDPair; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeIDPair.h>`.
typedef struct JPH_TrackedVehicleControllerSettings JPH_TrackedVehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/TrackedVehicleController.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleAntiRollBar JPH_VehicleAntiRollBar; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleAntiRollBar.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleConstraintSettings JPH_VehicleConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleDifferentialSettings JPH_VehicleDifferentialSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleDifferential.h>`.
typedef struct JPH_VehicleTrackSettings JPH_VehicleTrackSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTrack.h>`.
typedef struct JPH_VehicleTransmissionSettings JPH_VehicleTransmissionSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_WheelSettingsTV JPH_WheelSettingsTV; // Defined in `#include <jolt/Jolt/Physics/Vehicle/TrackedVehicleController.h>`.
typedef struct JPH_WheelSettingsWV JPH_WheelSettingsWV; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleController JPH_WheeledVehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleControllerSettings JPH_WheeledVehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct Jolt_std_function_JPH_Vec3_from_JPH_Vec3 Jolt_std_function_JPH_Vec3_from_JPH_Vec3; // Defined in `#include <std_function_JPH_Vec3_from_JPH_Vec3.h>`.


/// Minimal helpers for Jolt global lifecycle.
/// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
/// Generated from class `JoltHelpers`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltHelpers JoltHelpers;

// ---------------------------------------------------------------------------
// CountingPhysicsStepListener — concrete PhysicsStepListener for C# tests.
// Counts how many times OnStep was called and stores the last context values.
// ---------------------------------------------------------------------------
/// Generated from class `CountingPhysicsStepListener`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::PhysicsStepListener`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct CountingPhysicsStepListener CountingPhysicsStepListener;

// ---------------------------------------------------------------------------
// SimpleContactEventListener — concrete ContactListener for C# tests.
// Counts contact events and records the last added body pair.
// ---------------------------------------------------------------------------
/// Generated from class `SimpleContactEventListener`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ContactListener`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct SimpleContactEventListener SimpleContactEventListener;

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
/// Generated from class `ContactListenerTrampoline`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ContactListener`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct ContactListenerTrampoline ContactListenerTrampoline;

// ---------------------------------------------------------------------------
// EstimateResponseContactListener — concrete ContactListener that runs
// EstimateCollisionResponse in OnContactAdded and stores the result.
// ---------------------------------------------------------------------------
/// Generated from class `EstimateResponseContactListener`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ContactListener`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct EstimateResponseContactListener EstimateResponseContactListener;

/// Plain record of a single DrawLine call captured by RecordingDebugRenderer.
/// Generated from class `DebugLineRecord`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct DebugLineRecord DebugLineRecord;

/// Plain record of a single DrawTriangle call captured by RecordingDebugRenderer.
/// Generated from class `DebugTriangleRecord`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct DebugTriangleRecord DebugTriangleRecord;

/// Concrete DebugRenderer that records all DrawLine / DrawTriangle calls so
/// C# can inspect them.  Inherits DebugRendererSimple to avoid re-implementing
/// CreateTriangleBatch and DrawGeometry.
///
/// Lifecycle: only one instance may exist at a time (enforced by
/// DebugRenderer's singleton assert).  Call Clear() between frames.
/// Generated from class `RecordingDebugRenderer`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DebugRendererSimple`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
///     `JPH::DebugRenderer`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct RecordingDebugRenderer RecordingDebugRenderer;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltHelpers_DestroyArray()`.
/// Use `JoltHelpers_OffsetMutablePtr()` and `JoltHelpers_OffsetPtr()` to access the array elements.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltHelpers *JoltHelpers_OffsetPtr(const JoltHelpers *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltHelpers *JoltHelpers_OffsetMutablePtr(JoltHelpers *ptr, ptrdiff_t i);

/// Generated from constructor `JoltHelpers::JoltHelpers`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_ConstructFromAnother(const JoltHelpers *_other);

/// Destroys a heap-allocated instance of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_Destroy(const JoltHelpers *_this);

/// Destroys a heap-allocated array of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_DestroyArray(const JoltHelpers *_this);

/// Generated from method `JoltHelpers::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltHelpers *JoltHelpers_AssignFromAnother(JoltHelpers *_this, const JoltHelpers *_other);

/// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
/// Generated from method `JoltHelpers::Init`.
JOLT_API void JoltHelpers_Init(void);

/// Generated from method `JoltHelpers::Shutdown`.
JOLT_API void JoltHelpers_Shutdown(void);

/// Wrapper for the free function JPH::RayAABox (mrbind only binds named types).
/// Returns the minimal distance along the ray, or FLT_MAX if no hit.
/// Note: can return a negative value if the ray starts inside the box.
/// Generated from method `JoltHelpers::RayAABox`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inInvDirection` can not be null. It is a single object.
/// Parameter `inBoundsMin` can not be null. It is a single object.
/// Parameter `inBoundsMax` can not be null. It is a single object.
JOLT_API float JoltHelpers_RayAABox(const JPH_Vec3 *inOrigin, const JPH_RayInvDirection *inInvDirection, const JPH_Vec3 *inBoundsMin, const JPH_Vec3 *inBoundsMax);

/// Append a WheelSettingsWV to VehicleConstraintSettings::mWheels.
/// Generated from method `JoltHelpers::VehicleSettingsAddWheel`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsAddWheel(JPH_VehicleConstraintSettings *settings, JPH_WheelSettingsWV *wheel);

/// Append a WheelSettingsTV to VehicleConstraintSettings::mWheels.
/// Generated from method `JoltHelpers::VehicleSettingsAddWheelTV`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsAddWheelTV(JPH_VehicleConstraintSettings *settings, JPH_WheelSettingsTV *wheel);

/// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
/// Generated from method `JoltHelpers::VehicleSettingsSetController`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsSetController(JPH_VehicleConstraintSettings *settings, JPH_WheeledVehicleControllerSettings *ctrl);

/// Set VehicleConstraintSettings::mController to a TrackedVehicleControllerSettings.
/// Generated from method `JoltHelpers::VehicleSettingsSetTrackedController`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsSetTrackedController(JPH_VehicleConstraintSettings *settings, JPH_TrackedVehicleControllerSettings *ctrl);

/// Append a wheel index to VehicleTrackSettings::mWheels.
/// Generated from method `JoltHelpers::VehicleTrackSettingsAddWheelIndex`.
/// Parameter `track` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleTrackSettingsAddWheelIndex(JPH_VehicleTrackSettings *track, unsigned int wheelIndex);

/// Append a VehicleAntiRollBar to VehicleConstraintSettings::mAntiRollBars.
/// Generated from method `JoltHelpers::VehicleSettingsAddAntiRollBar`.
/// Parameter `settings` can not be null. It is a single object.
/// Parameter `bar` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsAddAntiRollBar(JPH_VehicleConstraintSettings *settings, const JPH_VehicleAntiRollBar *bar);

/// Append a VehicleDifferentialSettings to WheeledVehicleControllerSettings::mDifferentials.
/// Generated from method `JoltHelpers::WheeledControllerSettingsAddDifferential`.
/// Parameter `settings` can not be null. It is a single object.
/// Parameter `diff` can not be null. It is a single object.
JOLT_API void JoltHelpers_WheeledControllerSettingsAddDifferential(JPH_WheeledVehicleControllerSettings *settings, const JPH_VehicleDifferentialSettings *diff);

/// Cast the VehicleController on a VehicleConstraint to WheeledVehicleController.
/// Returns nullptr if the controller is not a WheeledVehicleController.
/// Generated from method `JoltHelpers::VehicleConstraintGetWheeledController`.
/// Parameter `constraint` can not be null. It is a single object.
JOLT_API JPH_WheeledVehicleController *JoltHelpers_VehicleConstraintGetWheeledController(JPH_VehicleConstraint *constraint);

/// Replace VehicleTransmissionSettings::mGearRatios with the supplied array.
/// inRatios[0] = 1st gear, inRatios[1] = 2nd gear, etc.
/// All values are positive (engine-to-gearbox ratio).
/// Generated from method `JoltHelpers::VehicleTransmissionSettingsSetGearRatios`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleTransmissionSettingsSetGearRatios(JPH_VehicleTransmissionSettings *inSettings, const float *inRatios, unsigned int inCount);

/// Replace VehicleTransmissionSettings::mReverseGearRatios.
/// Values must be negative.
/// Generated from method `JoltHelpers::VehicleTransmissionSettingsSetReverseGearRatios`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleTransmissionSettingsSetReverseGearRatios(JPH_VehicleTransmissionSettings *inSettings, const float *inRatios, unsigned int inCount);

/// Set BodyCreationSettings::mOverrideMassProperties.
/// Pass: 0 = CalculateMassAndInertia (default)
///       1 = CalculateInertia        (supply mass; Jolt scales inertia)
///       2 = MassAndInertiaProvided  (full manual override)
/// Generated from method `JoltHelpers::BodyCreationSettingsSetOverrideMassProperties`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_BodyCreationSettingsSetOverrideMassProperties(JPH_BodyCreationSettings *inSettings, int inMode);

/// Set the override mass in BodyCreationSettings::mMassPropertiesOverride.mMass.
/// Generated from method `JoltHelpers::BodyCreationSettingsSetMassOverride`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_BodyCreationSettingsSetMassOverride(JPH_BodyCreationSettings *inSettings, float inMass);

/// Read back the override mass.
/// Generated from method `JoltHelpers::BodyCreationSettingsGetMassOverride`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API float JoltHelpers_BodyCreationSettingsGetMassOverride(const JPH_BodyCreationSettings *inSettings);

/// Assign the height samples array (replaces existing content).
/// Generated from method `JoltHelpers::HeightFieldSettingsSetHeightSamples`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_HeightFieldSettingsSetHeightSamples(JPH_HeightFieldShapeSettings *inSettings, const float *inSamples, unsigned int inCount);

/// Resize the height samples array to inCount elements, filling with inFillValue.
/// Generated from method `JoltHelpers::HeightFieldSettingsResizeHeightSamples`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_HeightFieldSettingsResizeHeightSamples(JPH_HeightFieldShapeSettings *inSettings, unsigned int inCount, float inFillValue);

/// Set the height sample at a specific index.
/// Generated from method `JoltHelpers::HeightFieldSettingsSetHeightSampleAt`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_HeightFieldSettingsSetHeightSampleAt(JPH_HeightFieldShapeSettings *inSettings, unsigned int inIndex, float inValue);

/// Return the number of height samples currently stored.
/// Generated from method `JoltHelpers::HeightFieldSettingsGetHeightSamplesCount`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_HeightFieldSettingsGetHeightSamplesCount(const JPH_HeightFieldShapeSettings *inSettings);

/// Return a single height sample by index.
/// Generated from method `JoltHelpers::HeightFieldSettingsGetHeightSample`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API float JoltHelpers_HeightFieldSettingsGetHeightSample(const JPH_HeightFieldShapeSettings *inSettings, unsigned int inIndex);

/// Return HeightFieldShapeConstants::cNoCollisionValue (sentinel height = no-collision).
/// Generated from method `JoltHelpers::HeightFieldShapeConstantsNoCollisionValue`.
JOLT_API float JoltHelpers_HeightFieldShapeConstantsNoCollisionValue(void);

/// Return the world-space position of a HeightFieldShape sample at (inX, inY).
/// (Wraps HeightFieldShape::GetPosition; accepts base Shape& to avoid requiring a downcast in C#.)
/// Generated from method `JoltHelpers::HeightFieldShapeGetPosition`.
/// Parameter `inShape` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JoltHelpers_HeightFieldShapeGetPosition(const JPH_Shape *inShape, unsigned int inX, unsigned int inY);

/// Return true if the sample at (inX, inY) has no collision (is a "hole").
/// Generated from method `JoltHelpers::HeightFieldShapeIsNoCollision`.
/// Parameter `inShape` can not be null. It is a single object.
JOLT_API bool JoltHelpers_HeightFieldShapeIsNoCollision(const JPH_Shape *inShape, unsigned int inX, unsigned int inY);

/// Append a vertex to SoftBodySharedSettings::mVertices.
/// Generated from method `JoltHelpers::SoftBodySettingsAddVertex`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inVertex` can not be null. It is a single object.
JOLT_API void JoltHelpers_SoftBodySettingsAddVertex(JPH_SoftBodySharedSettings *inSettings, const JPH_SoftBodySharedSettings_Vertex *inVertex);

/// Return the number of vertices in SoftBodySharedSettings::mVertices.
/// Generated from method `JoltHelpers::SoftBodySettingsGetVertexCount`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SoftBodySettingsGetVertexCount(const JPH_SoftBodySharedSettings *inSettings);

/// Return the number of faces in SoftBodySharedSettings::mFaces (valid after Optimize()).
/// Generated from method `JoltHelpers::SoftBodySettingsGetFaceCount`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SoftBodySettingsGetFaceCount(const JPH_SoftBodySharedSettings *inSettings);

/// Return the vertex index at slot inVertexSlot (0, 1, or 2) of face inFaceIndex in SoftBodySharedSettings::mFaces.
/// Generated from method `JoltHelpers::SoftBodySettingsGetFaceVertex`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SoftBodySettingsGetFaceVertex(const JPH_SoftBodySharedSettings *inSettings, unsigned int inFaceIndex, unsigned int inVertexSlot);

/// Create a cube soft body and return an owning pointer (caller must eventually Release() it).
/// Generated from method `JoltHelpers::SoftBodySettingsCreateCube`.
JOLT_API JPH_SoftBodySharedSettings *JoltHelpers_SoftBodySettingsCreateCube(unsigned int inGridSize, float inGridSpacing);

/// Return the number of runtime vertices in a soft body (via SoftBodyMotionProperties).
/// Generated from method `JoltHelpers::BodyGetSoftBodyVertexCount`.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_BodyGetSoftBodyVertexCount(const JPH_Body *inBody);

/// Return the position of a runtime soft body vertex.
/// Generated from method `JoltHelpers::BodyGetSoftBodyVertexPosition`.
/// Parameter `inBody` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JoltHelpers_BodyGetSoftBodyVertexPosition(const JPH_Body *inBody, unsigned int inIndex);

/// Set the position of a runtime soft body vertex.
/// Generated from method `JoltHelpers::BodySetSoftBodyVertexPosition`.
/// Parameter `inBody` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JoltHelpers_BodySetSoftBodyVertexPosition(JPH_Body *inBody, unsigned int inIndex, const JPH_Vec3 *inPosition);

/// Return the inverse mass of the body (soft or rigid) via MotionProperties.
/// Generated from method `JoltHelpers::BodyGetInverseMass`.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API float JoltHelpers_BodyGetInverseMass(const JPH_Body *inBody);

/// Get the number of soft-body vertices for the body with the given ID.
/// Must be called with the physics system locked (outside of simulation step).
/// Generated from method `JoltHelpers::PhysicsSystemGetSoftBodyVertexCount`.
/// Parameter `inSystem` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_PhysicsSystemGetSoftBodyVertexCount(const JPH_PhysicsSystem *inSystem, const JPH_BodyID *inBodyID);

/// Get the position of a soft-body vertex by body ID and vertex index.
/// Must be called with the physics system locked (outside of simulation step).
/// Generated from method `JoltHelpers::PhysicsSystemGetSoftBodyVertexPosition`.
/// Parameter `inSystem` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition(const JPH_PhysicsSystem *inSystem, const JPH_BodyID *inBodyID, unsigned int inIndex);

/// Set the shape on a CharacterBaseSettings (mShape is a RefConst<Shape> not directly bindable).
/// Generated from method `JoltHelpers::CharacterBaseSettingsSetShape`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_CharacterBaseSettingsSetShape(JPH_CharacterBaseSettings *inSettings, const JPH_Shape *inShape);

/// Set the skeleton on a RagdollSettings (mSkeleton is Ref<Skeleton>).
/// Generated from method `JoltHelpers::RagdollSettingsSetSkeleton`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JoltHelpers_RagdollSettingsSetSkeleton(JPH_RagdollSettings *inSettings, JPH_Skeleton *inSkeleton);

/// Get the skeleton from a RagdollSettings (returns raw pointer, not Ref).
/// Generated from method `JoltHelpers::RagdollSettingsGetSkeleton`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Skeleton *JoltHelpers_RagdollSettingsGetSkeleton(const JPH_RagdollSettings *inSettings);

/// Append a Part to RagdollSettings::mParts.
/// Generated from method `JoltHelpers::RagdollSettingsAddPart`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inPart` can not be null. It is a single object.
JOLT_API void JoltHelpers_RagdollSettingsAddPart(JPH_RagdollSettings *inSettings, const JPH_RagdollSettings_Part *inPart);

/// Return the number of parts in RagdollSettings::mParts.
/// Generated from method `JoltHelpers::RagdollSettingsGetPartCount`.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_RagdollSettingsGetPartCount(const JPH_RagdollSettings *inSettings);

/// Return a reference to a Part by index.
/// Generated from method `JoltHelpers::RagdollSettingsGetPart`.
/// Parameter `inSettings` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_RagdollSettings_Part *JoltHelpers_RagdollSettingsGetPart(const JPH_RagdollSettings *inSettings, unsigned int inIndex);

/// Add a root joint (no parent) to a Skeleton. Returns the joint index.
/// Generated from method `JoltHelpers::SkeletonAddJoint`.
/// Parameter `inSkeleton` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SkeletonAddJoint(JPH_Skeleton *inSkeleton, const char *inName);

/// Add a joint with a named parent. Returns the joint index.
/// Generated from method `JoltHelpers::SkeletonAddJointWithParentName`.
/// Parameter `inSkeleton` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SkeletonAddJointWithParentName(JPH_Skeleton *inSkeleton, const char *inName, const char *inParentName);

/// Add a joint with a parent index. Returns the joint index.
/// Generated from method `JoltHelpers::SkeletonAddJointWithParentIndex`.
/// Parameter `inSkeleton` can not be null. It is a single object.
JOLT_API unsigned int JoltHelpers_SkeletonAddJointWithParentIndex(JPH_Skeleton *inSkeleton, const char *inName, int inParentIndex);

/// Create a ConvexHullShapeSettings from an array of Float3 points.
/// Generated from method `JoltHelpers::ConvexHullShapeSettingsFromFloat3Array`.
JOLT_API JPH_ConvexHullShapeSettings *JoltHelpers_ConvexHullShapeSettingsFromFloat3Array(const JPH_Float3 *inPoints, int inNumPoints, float inMaxConvexRadius, const JPH_PhysicsMaterial *inMaterial);

/// Returns a pointer to a member variable of class `CountingPhysicsStepListener` named `mCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *CountingPhysicsStepListener_Get_mCount(const CountingPhysicsStepListener *_this);

/// Modifies a member variable of class `CountingPhysicsStepListener` named `mCount`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCount`.
JOLT_API void CountingPhysicsStepListener_Set_mCount(CountingPhysicsStepListener *_this, int value);

/// Returns a mutable pointer to a member variable of class `CountingPhysicsStepListener` named `mCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *CountingPhysicsStepListener_GetMutable_mCount(CountingPhysicsStepListener *_this);

/// Returns a pointer to a member variable of class `CountingPhysicsStepListener` named `mLastDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *CountingPhysicsStepListener_Get_mLastDeltaTime(const CountingPhysicsStepListener *_this);

/// Modifies a member variable of class `CountingPhysicsStepListener` named `mLastDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLastDeltaTime`.
JOLT_API void CountingPhysicsStepListener_Set_mLastDeltaTime(CountingPhysicsStepListener *_this, float value);

/// Returns a mutable pointer to a member variable of class `CountingPhysicsStepListener` named `mLastDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *CountingPhysicsStepListener_GetMutable_mLastDeltaTime(CountingPhysicsStepListener *_this);

/// Returns a pointer to a member variable of class `CountingPhysicsStepListener` named `mLastIsFirst`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *CountingPhysicsStepListener_Get_mLastIsFirst(const CountingPhysicsStepListener *_this);

/// Modifies a member variable of class `CountingPhysicsStepListener` named `mLastIsFirst`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLastIsFirst`.
JOLT_API void CountingPhysicsStepListener_Set_mLastIsFirst(CountingPhysicsStepListener *_this, bool value);

/// Returns a mutable pointer to a member variable of class `CountingPhysicsStepListener` named `mLastIsFirst`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *CountingPhysicsStepListener_GetMutable_mLastIsFirst(CountingPhysicsStepListener *_this);

/// Returns a pointer to a member variable of class `CountingPhysicsStepListener` named `mLastIsLast`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *CountingPhysicsStepListener_Get_mLastIsLast(const CountingPhysicsStepListener *_this);

/// Modifies a member variable of class `CountingPhysicsStepListener` named `mLastIsLast`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLastIsLast`.
JOLT_API void CountingPhysicsStepListener_Set_mLastIsLast(CountingPhysicsStepListener *_this, bool value);

/// Returns a mutable pointer to a member variable of class `CountingPhysicsStepListener` named `mLastIsLast`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *CountingPhysicsStepListener_GetMutable_mLastIsLast(CountingPhysicsStepListener *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `CountingPhysicsStepListener_Destroy()` to free it when you're done using it.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `CountingPhysicsStepListener_DestroyArray()`.
/// Use `CountingPhysicsStepListener_OffsetMutablePtr()` and `CountingPhysicsStepListener_OffsetPtr()` to access the array elements.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const CountingPhysicsStepListener *CountingPhysicsStepListener_OffsetPtr(const CountingPhysicsStepListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_OffsetMutablePtr(CountingPhysicsStepListener *ptr, ptrdiff_t i);

/// Upcasts an instance of `CountingPhysicsStepListener` to its base class `JPH::PhysicsStepListener`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsStepListener *CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(const CountingPhysicsStepListener *object);

/// Upcasts an instance of `CountingPhysicsStepListener` to its base class `JPH::PhysicsStepListener`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsStepListener *CountingPhysicsStepListener_MutableUpcastTo_JPH_PhysicsStepListener(CountingPhysicsStepListener *object);

/// Downcasts an instance of `JPH::PhysicsStepListener` to a derived class `CountingPhysicsStepListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const CountingPhysicsStepListener *CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(const JPH_PhysicsStepListener *object);

/// Downcasts an instance of `JPH::PhysicsStepListener` to a derived class `CountingPhysicsStepListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_MutableStaticDowncastFrom_JPH_PhysicsStepListener(JPH_PhysicsStepListener *object);

/// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `CountingPhysicsStepListener_Destroy()` to free it when you're done using it.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, CountingPhysicsStepListener *_other);

/// Destroys a heap-allocated instance of `CountingPhysicsStepListener`. Does nothing if the pointer is null.
JOLT_API void CountingPhysicsStepListener_Destroy(const CountingPhysicsStepListener *_this);

/// Destroys a heap-allocated array of `CountingPhysicsStepListener`. Does nothing if the pointer is null.
JOLT_API void CountingPhysicsStepListener_DestroyArray(const CountingPhysicsStepListener *_this);

/// Generated from method `CountingPhysicsStepListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API CountingPhysicsStepListener *CountingPhysicsStepListener_AssignFromAnother(CountingPhysicsStepListener *_this, Jolt_PassBy _other_pass_by, CountingPhysicsStepListener *_other);

/// Generated from method `CountingPhysicsStepListener::Reset`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void CountingPhysicsStepListener_Reset(CountingPhysicsStepListener *_this);

/// Generated from method `CountingPhysicsStepListener::GetCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int CountingPhysicsStepListener_GetCount(const CountingPhysicsStepListener *_this);

/// Generated from method `CountingPhysicsStepListener::GetLastDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float CountingPhysicsStepListener_GetLastDeltaTime(const CountingPhysicsStepListener *_this);

/// Generated from method `CountingPhysicsStepListener::GetLastIsFirst`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool CountingPhysicsStepListener_GetLastIsFirst(const CountingPhysicsStepListener *_this);

/// Generated from method `CountingPhysicsStepListener::GetLastIsLast`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool CountingPhysicsStepListener_GetLastIsLast(const CountingPhysicsStepListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mValidateCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *SimpleContactEventListener_Get_mValidateCount(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mValidateCount`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mValidateCount`.
JOLT_API void SimpleContactEventListener_Set_mValidateCount(SimpleContactEventListener *_this, int value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mValidateCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *SimpleContactEventListener_GetMutable_mValidateCount(SimpleContactEventListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mAddedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *SimpleContactEventListener_Get_mAddedCount(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mAddedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAddedCount`.
JOLT_API void SimpleContactEventListener_Set_mAddedCount(SimpleContactEventListener *_this, int value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mAddedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *SimpleContactEventListener_GetMutable_mAddedCount(SimpleContactEventListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mPersistedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *SimpleContactEventListener_Get_mPersistedCount(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mPersistedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPersistedCount`.
JOLT_API void SimpleContactEventListener_Set_mPersistedCount(SimpleContactEventListener *_this, int value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mPersistedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *SimpleContactEventListener_GetMutable_mPersistedCount(SimpleContactEventListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mRemovedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *SimpleContactEventListener_Get_mRemovedCount(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mRemovedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRemovedCount`.
JOLT_API void SimpleContactEventListener_Set_mRemovedCount(SimpleContactEventListener *_this, int value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mRemovedCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *SimpleContactEventListener_GetMutable_mRemovedCount(SimpleContactEventListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mLastAddedBody1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *SimpleContactEventListener_Get_mLastAddedBody1(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mLastAddedBody1`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mLastAddedBody1`.
/// When this function is called, this object will drop object references it held previously in `mLastAddedBody1`.
JOLT_API void SimpleContactEventListener_Set_mLastAddedBody1(SimpleContactEventListener *_this, JPH_BodyID value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mLastAddedBody1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *SimpleContactEventListener_GetMutable_mLastAddedBody1(SimpleContactEventListener *_this);

/// Returns a pointer to a member variable of class `SimpleContactEventListener` named `mLastAddedBody2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *SimpleContactEventListener_Get_mLastAddedBody2(const SimpleContactEventListener *_this);

/// Modifies a member variable of class `SimpleContactEventListener` named `mLastAddedBody2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mLastAddedBody2`.
/// When this function is called, this object will drop object references it held previously in `mLastAddedBody2`.
JOLT_API void SimpleContactEventListener_Set_mLastAddedBody2(SimpleContactEventListener *_this, JPH_BodyID value);

/// Returns a mutable pointer to a member variable of class `SimpleContactEventListener` named `mLastAddedBody2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *SimpleContactEventListener_GetMutable_mLastAddedBody2(SimpleContactEventListener *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `SimpleContactEventListener_Destroy()` to free it when you're done using it.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `SimpleContactEventListener_DestroyArray()`.
/// Use `SimpleContactEventListener_OffsetMutablePtr()` and `SimpleContactEventListener_OffsetPtr()` to access the array elements.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const SimpleContactEventListener *SimpleContactEventListener_OffsetPtr(const SimpleContactEventListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_OffsetMutablePtr(SimpleContactEventListener *ptr, ptrdiff_t i);

/// Upcasts an instance of `SimpleContactEventListener` to its base class `JPH::ContactListener`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ContactListener *SimpleContactEventListener_UpcastTo_JPH_ContactListener(const SimpleContactEventListener *object);

/// Upcasts an instance of `SimpleContactEventListener` to its base class `JPH::ContactListener`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ContactListener *SimpleContactEventListener_MutableUpcastTo_JPH_ContactListener(SimpleContactEventListener *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `SimpleContactEventListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const SimpleContactEventListener *SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `SimpleContactEventListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object);

/// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `SimpleContactEventListener_Destroy()` to free it when you're done using it.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, SimpleContactEventListener *_other);

/// Destroys a heap-allocated instance of `SimpleContactEventListener`. Does nothing if the pointer is null.
JOLT_API void SimpleContactEventListener_Destroy(const SimpleContactEventListener *_this);

/// Destroys a heap-allocated array of `SimpleContactEventListener`. Does nothing if the pointer is null.
JOLT_API void SimpleContactEventListener_DestroyArray(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API SimpleContactEventListener *SimpleContactEventListener_AssignFromAnother(SimpleContactEventListener *_this, Jolt_PassBy _other_pass_by, SimpleContactEventListener *_other);

/// Generated from method `SimpleContactEventListener::Reset`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void SimpleContactEventListener_Reset(SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetValidateCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int SimpleContactEventListener_GetValidateCount(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetAddedCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int SimpleContactEventListener_GetAddedCount(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetPersistedCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int SimpleContactEventListener_GetPersistedCount(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetRemovedCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int SimpleContactEventListener_GetRemovedCount(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetLastAddedBody1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyID *SimpleContactEventListener_GetLastAddedBody1(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::GetLastAddedBody2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyID *SimpleContactEventListener_GetLastAddedBody2(const SimpleContactEventListener *_this);

/// Generated from method `SimpleContactEventListener::OnContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
/// Parameter `inCollisionResult` can not be null. It is a single object.
JOLT_API JPH_ValidateResult SimpleContactEventListener_OnContactValidate(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult);

/// Generated from method `SimpleContactEventListener::OnContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void SimpleContactEventListener_OnContactAdded(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Generated from method `SimpleContactEventListener::OnContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void SimpleContactEventListener_OnContactPersisted(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Generated from method `SimpleContactEventListener::OnContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapePair` can not be null. It is a single object.
JOLT_API void SimpleContactEventListener_OnContactRemoved(SimpleContactEventListener *_this, const JPH_SubShapeIDPair *inSubShapePair);

/// Returns a pointer to a member variable of class `ContactListenerTrampoline` named `mContext`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *ContactListenerTrampoline_Get_mContext(const ContactListenerTrampoline *_this);

/// Modifies a member variable of class `ContactListenerTrampoline` named `mContext`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mContext`.
/// When this function is called, this object will drop object references it held previously in `mContext`.
JOLT_API void ContactListenerTrampoline_Set_mContext(ContactListenerTrampoline *_this, void *value);

/// Returns a mutable pointer to a member variable of class `ContactListenerTrampoline` named `mContext`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **ContactListenerTrampoline_GetMutable_mContext(ContactListenerTrampoline *_this);

/// Returns a pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactValidateFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *ContactListenerTrampoline_Get_mOnContactValidateFn(const ContactListenerTrampoline *_this);

/// Modifies a member variable of class `ContactListenerTrampoline` named `mOnContactValidateFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mOnContactValidateFn`.
/// When this function is called, this object will drop object references it held previously in `mOnContactValidateFn`.
JOLT_API void ContactListenerTrampoline_Set_mOnContactValidateFn(ContactListenerTrampoline *_this, void *value);

/// Returns a mutable pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactValidateFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **ContactListenerTrampoline_GetMutable_mOnContactValidateFn(ContactListenerTrampoline *_this);

/// Returns a pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactAddedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *ContactListenerTrampoline_Get_mOnContactAddedFn(const ContactListenerTrampoline *_this);

/// Modifies a member variable of class `ContactListenerTrampoline` named `mOnContactAddedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mOnContactAddedFn`.
/// When this function is called, this object will drop object references it held previously in `mOnContactAddedFn`.
JOLT_API void ContactListenerTrampoline_Set_mOnContactAddedFn(ContactListenerTrampoline *_this, void *value);

/// Returns a mutable pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactAddedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **ContactListenerTrampoline_GetMutable_mOnContactAddedFn(ContactListenerTrampoline *_this);

/// Returns a pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactPersistedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *ContactListenerTrampoline_Get_mOnContactPersistedFn(const ContactListenerTrampoline *_this);

/// Modifies a member variable of class `ContactListenerTrampoline` named `mOnContactPersistedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mOnContactPersistedFn`.
/// When this function is called, this object will drop object references it held previously in `mOnContactPersistedFn`.
JOLT_API void ContactListenerTrampoline_Set_mOnContactPersistedFn(ContactListenerTrampoline *_this, void *value);

/// Returns a mutable pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactPersistedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **ContactListenerTrampoline_GetMutable_mOnContactPersistedFn(ContactListenerTrampoline *_this);

/// Returns a pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactRemovedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *ContactListenerTrampoline_Get_mOnContactRemovedFn(const ContactListenerTrampoline *_this);

/// Modifies a member variable of class `ContactListenerTrampoline` named `mOnContactRemovedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mOnContactRemovedFn`.
/// When this function is called, this object will drop object references it held previously in `mOnContactRemovedFn`.
JOLT_API void ContactListenerTrampoline_Set_mOnContactRemovedFn(ContactListenerTrampoline *_this, void *value);

/// Returns a mutable pointer to a member variable of class `ContactListenerTrampoline` named `mOnContactRemovedFn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **ContactListenerTrampoline_GetMutable_mOnContactRemovedFn(ContactListenerTrampoline *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `ContactListenerTrampoline_Destroy()` to free it when you're done using it.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `ContactListenerTrampoline_DestroyArray()`.
/// Use `ContactListenerTrampoline_OffsetMutablePtr()` and `ContactListenerTrampoline_OffsetPtr()` to access the array elements.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const ContactListenerTrampoline *ContactListenerTrampoline_OffsetPtr(const ContactListenerTrampoline *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_OffsetMutablePtr(ContactListenerTrampoline *ptr, ptrdiff_t i);

/// Upcasts an instance of `ContactListenerTrampoline` to its base class `JPH::ContactListener`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ContactListener *ContactListenerTrampoline_UpcastTo_JPH_ContactListener(const ContactListenerTrampoline *object);

/// Upcasts an instance of `ContactListenerTrampoline` to its base class `JPH::ContactListener`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ContactListener *ContactListenerTrampoline_MutableUpcastTo_JPH_ContactListener(ContactListenerTrampoline *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `ContactListenerTrampoline`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const ContactListenerTrampoline *ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `ContactListenerTrampoline`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object);

/// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `ContactListenerTrampoline_Destroy()` to free it when you're done using it.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_ConstructFromAnother(Jolt_PassBy _other_pass_by, ContactListenerTrampoline *_other);

/// Destroys a heap-allocated instance of `ContactListenerTrampoline`. Does nothing if the pointer is null.
JOLT_API void ContactListenerTrampoline_Destroy(const ContactListenerTrampoline *_this);

/// Destroys a heap-allocated array of `ContactListenerTrampoline`. Does nothing if the pointer is null.
JOLT_API void ContactListenerTrampoline_DestroyArray(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API ContactListenerTrampoline *ContactListenerTrampoline_AssignFromAnother(ContactListenerTrampoline *_this, Jolt_PassBy _other_pass_by, ContactListenerTrampoline *_other);

/// Generated from method `ContactListenerTrampoline::GetContext`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *ContactListenerTrampoline_GetContext(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::SetContext`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_SetContext(ContactListenerTrampoline *_this, void *v);

/// Generated from method `ContactListenerTrampoline::GetOnContactValidateFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *ContactListenerTrampoline_GetOnContactValidateFn(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::SetOnContactValidateFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_SetOnContactValidateFn(ContactListenerTrampoline *_this, void *v);

/// Generated from method `ContactListenerTrampoline::GetOnContactAddedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *ContactListenerTrampoline_GetOnContactAddedFn(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::SetOnContactAddedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_SetOnContactAddedFn(ContactListenerTrampoline *_this, void *v);

/// Generated from method `ContactListenerTrampoline::GetOnContactPersistedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *ContactListenerTrampoline_GetOnContactPersistedFn(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::SetOnContactPersistedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_SetOnContactPersistedFn(ContactListenerTrampoline *_this, void *v);

/// Generated from method `ContactListenerTrampoline::GetOnContactRemovedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *ContactListenerTrampoline_GetOnContactRemovedFn(const ContactListenerTrampoline *_this);

/// Generated from method `ContactListenerTrampoline::SetOnContactRemovedFn`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_SetOnContactRemovedFn(ContactListenerTrampoline *_this, void *v);

/// Generated from method `ContactListenerTrampoline::OnContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
/// Parameter `inCollisionResult` can not be null. It is a single object.
JOLT_API JPH_ValidateResult ContactListenerTrampoline_OnContactValidate(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult);

/// Generated from method `ContactListenerTrampoline::OnContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_OnContactAdded(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Generated from method `ContactListenerTrampoline::OnContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_OnContactPersisted(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Generated from method `ContactListenerTrampoline::OnContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapePair` can not be null. It is a single object.
JOLT_API void ContactListenerTrampoline_OnContactRemoved(ContactListenerTrampoline *_this, const JPH_SubShapeIDPair *inSubShapePair);

/// Returns a pointer to a member variable of class `EstimateResponseContactListener` named `mWasCalled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *EstimateResponseContactListener_Get_mWasCalled(const EstimateResponseContactListener *_this);

/// Modifies a member variable of class `EstimateResponseContactListener` named `mWasCalled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWasCalled`.
JOLT_API void EstimateResponseContactListener_Set_mWasCalled(EstimateResponseContactListener *_this, bool value);

/// Returns a mutable pointer to a member variable of class `EstimateResponseContactListener` named `mWasCalled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *EstimateResponseContactListener_GetMutable_mWasCalled(EstimateResponseContactListener *_this);

/// Returns a pointer to a member variable of class `EstimateResponseContactListener` named `mLinearVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_Get_mLinearVelocity1(const EstimateResponseContactListener *_this);

/// Returns a mutable pointer to a member variable of class `EstimateResponseContactListener` named `mLinearVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *EstimateResponseContactListener_GetMutable_mLinearVelocity1(EstimateResponseContactListener *_this);

/// Returns a pointer to a member variable of class `EstimateResponseContactListener` named `mAngularVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_Get_mAngularVelocity1(const EstimateResponseContactListener *_this);

/// Returns a mutable pointer to a member variable of class `EstimateResponseContactListener` named `mAngularVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *EstimateResponseContactListener_GetMutable_mAngularVelocity1(EstimateResponseContactListener *_this);

/// Returns a pointer to a member variable of class `EstimateResponseContactListener` named `mLinearVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_Get_mLinearVelocity2(const EstimateResponseContactListener *_this);

/// Returns a mutable pointer to a member variable of class `EstimateResponseContactListener` named `mLinearVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *EstimateResponseContactListener_GetMutable_mLinearVelocity2(EstimateResponseContactListener *_this);

/// Returns a pointer to a member variable of class `EstimateResponseContactListener` named `mAngularVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_Get_mAngularVelocity2(const EstimateResponseContactListener *_this);

/// Returns a mutable pointer to a member variable of class `EstimateResponseContactListener` named `mAngularVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *EstimateResponseContactListener_GetMutable_mAngularVelocity2(EstimateResponseContactListener *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `EstimateResponseContactListener_Destroy()` to free it when you're done using it.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `EstimateResponseContactListener_DestroyArray()`.
/// Use `EstimateResponseContactListener_OffsetMutablePtr()` and `EstimateResponseContactListener_OffsetPtr()` to access the array elements.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const EstimateResponseContactListener *EstimateResponseContactListener_OffsetPtr(const EstimateResponseContactListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_OffsetMutablePtr(EstimateResponseContactListener *ptr, ptrdiff_t i);

/// Upcasts an instance of `EstimateResponseContactListener` to its base class `JPH::ContactListener`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ContactListener *EstimateResponseContactListener_UpcastTo_JPH_ContactListener(const EstimateResponseContactListener *object);

/// Upcasts an instance of `EstimateResponseContactListener` to its base class `JPH::ContactListener`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ContactListener *EstimateResponseContactListener_MutableUpcastTo_JPH_ContactListener(EstimateResponseContactListener *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `EstimateResponseContactListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const EstimateResponseContactListener *EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object);

/// Downcasts an instance of `JPH::ContactListener` to a derived class `EstimateResponseContactListener`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object);

/// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `EstimateResponseContactListener_Destroy()` to free it when you're done using it.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, EstimateResponseContactListener *_other);

/// Destroys a heap-allocated instance of `EstimateResponseContactListener`. Does nothing if the pointer is null.
JOLT_API void EstimateResponseContactListener_Destroy(const EstimateResponseContactListener *_this);

/// Destroys a heap-allocated array of `EstimateResponseContactListener`. Does nothing if the pointer is null.
JOLT_API void EstimateResponseContactListener_DestroyArray(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API EstimateResponseContactListener *EstimateResponseContactListener_AssignFromAnother(EstimateResponseContactListener *_this, Jolt_PassBy _other_pass_by, EstimateResponseContactListener *_other);

/// Generated from method `EstimateResponseContactListener::Reset`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void EstimateResponseContactListener_Reset(EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::WasCalled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool EstimateResponseContactListener_WasCalled(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::GetLinearVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_GetLinearVelocity1(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::GetAngularVelocity1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_GetAngularVelocity1(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::GetLinearVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_GetLinearVelocity2(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::GetAngularVelocity2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Vec3 *EstimateResponseContactListener_GetAngularVelocity2(const EstimateResponseContactListener *_this);

/// Generated from method `EstimateResponseContactListener::OnContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void EstimateResponseContactListener_OnContactAdded(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Called after detecting a collision between a body pair, but before calling OnContactAdded and before adding the contact constraint.
/// If the function rejects the contact, the contact will not be processed by the simulation.
/// This is a rather expensive time to reject a contact point since a lot of the collision detection has happened already, make sure you
/// filter out the majority of undesired body pairs through the ObjectLayerPairFilter that is registered on the PhysicsSystem.
///
/// This function may not be called again the next update if a contact persists and no new contact pairs between sub shapes are found.
///
/// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
///
/// Body 1 will have a motion type that is larger or equal than body 2's motion type (order from large to small: dynamic -> kinematic -> static). When motion types are equal, they are ordered by BodyID.
///
/// The collision result (inCollisionResult) is reported relative to inBaseOffset.
/// Generated from method `EstimateResponseContactListener::OnContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
/// Parameter `inCollisionResult` can not be null. It is a single object.
JOLT_API JPH_ValidateResult EstimateResponseContactListener_OnContactValidate(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult);

/// Called whenever a contact is detected that was also detected last update.
///
/// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
///
/// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
///
/// If the structure of the shape of a body changes between simulation steps (e.g. by adding/removing a child shape of a compound shape),
/// it is possible that the same sub shape ID used to identify the removed child shape is now reused for a different child shape. The physics
/// system cannot detect this, so may send a 'contact persisted' callback even though the contact is now on a different child shape. You can
/// detect this by keeping the old shape (before adding/removing a part) around until the next PhysicsSystem::Update (when the OnContactPersisted
/// callbacks are triggered) and resolving the sub shape ID against both the old and new shape to see if they still refer to the same child shape.
/// Generated from method `EstimateResponseContactListener::OnContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void EstimateResponseContactListener_OnContactPersisted(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Called whenever a contact was detected last update but is not detected anymore.
///
/// You cannot access the bodies at the time of this callback because:
/// - All bodies are locked at the time of this callback.
/// - Some properties of the bodies are being modified from another thread at the same time.
/// - The body may have been removed and destroyed (you'll receive an OnContactRemoved callback in the PhysicsSystem::Update after the body has been removed).
///
/// Cache what you need in the OnContactAdded and OnContactPersisted callbacks and store it in a separate structure to use during this callback.
/// Alternatively, you could just record that the contact was removed and process it after PhysicsSystem::Update.
///
/// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
///
/// The sub shape IDs were created in the previous simulation step, so if the structure of a shape changes (e.g. by adding/removing a child shape of a compound shape),
/// the sub shape ID may not be valid / may not point to the same sub shape anymore.
/// If you want to know if this is the last contact between the two bodies, use PhysicsSystem::WereBodiesInContact.
/// Generated from method `EstimateResponseContactListener::OnContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapePair` can not be null. It is a single object.
JOLT_API void EstimateResponseContactListener_OnContactRemoved(EstimateResponseContactListener *_this, const JPH_SubShapeIDPair *inSubShapePair);

/// Returns a pointer to a member variable of class `DebugLineRecord` named `mFrom`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *DebugLineRecord_Get_mFrom(const DebugLineRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugLineRecord` named `mFrom`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *DebugLineRecord_GetMutable_mFrom(DebugLineRecord *_this);

/// Returns a pointer to a member variable of class `DebugLineRecord` named `mTo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *DebugLineRecord_Get_mTo(const DebugLineRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugLineRecord` named `mTo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *DebugLineRecord_GetMutable_mTo(DebugLineRecord *_this);

/// Returns a pointer to a member variable of class `DebugLineRecord` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Color *DebugLineRecord_Get_mColor(const DebugLineRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugLineRecord` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Color *DebugLineRecord_GetMutable_mColor(DebugLineRecord *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugLineRecord_Destroy()` to free it when you're done using it.
JOLT_API DebugLineRecord *DebugLineRecord_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `DebugLineRecord_DestroyArray()`.
/// Use `DebugLineRecord_OffsetMutablePtr()` and `DebugLineRecord_OffsetPtr()` to access the array elements.
JOLT_API DebugLineRecord *DebugLineRecord_DefaultConstructArray(size_t num_elems);

/// Constructs `DebugLineRecord` elementwise.
/// Parameter `mFrom` can not be null. It is a single object.
/// The reference to the parameter `mFrom` might be preserved in the constructed object.
/// Parameter `mTo` can not be null. It is a single object.
/// The reference to the parameter `mTo` might be preserved in the constructed object.
/// Parameter `mColor` can not be null. It is a single object.
/// The reference to the parameter `mColor` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugLineRecord_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API DebugLineRecord *DebugLineRecord_ConstructFrom(const JPH_Vec3 *mFrom, const JPH_Vec3 *mTo, const JPH_Color *mColor);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const DebugLineRecord *DebugLineRecord_OffsetPtr(const DebugLineRecord *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API DebugLineRecord *DebugLineRecord_OffsetMutablePtr(DebugLineRecord *ptr, ptrdiff_t i);

/// Generated from constructor `DebugLineRecord::DebugLineRecord`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugLineRecord_Destroy()` to free it when you're done using it.
JOLT_API DebugLineRecord *DebugLineRecord_ConstructFromAnother(const DebugLineRecord *_other);

/// Destroys a heap-allocated instance of `DebugLineRecord`. Does nothing if the pointer is null.
JOLT_API void DebugLineRecord_Destroy(const DebugLineRecord *_this);

/// Destroys a heap-allocated array of `DebugLineRecord`. Does nothing if the pointer is null.
JOLT_API void DebugLineRecord_DestroyArray(const DebugLineRecord *_this);

/// Generated from method `DebugLineRecord::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API DebugLineRecord *DebugLineRecord_AssignFromAnother(DebugLineRecord *_this, const DebugLineRecord *_other);

/// Returns a pointer to a member variable of class `DebugTriangleRecord` named `mV1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *DebugTriangleRecord_Get_mV1(const DebugTriangleRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugTriangleRecord` named `mV1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *DebugTriangleRecord_GetMutable_mV1(DebugTriangleRecord *_this);

/// Returns a pointer to a member variable of class `DebugTriangleRecord` named `mV2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *DebugTriangleRecord_Get_mV2(const DebugTriangleRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugTriangleRecord` named `mV2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *DebugTriangleRecord_GetMutable_mV2(DebugTriangleRecord *_this);

/// Returns a pointer to a member variable of class `DebugTriangleRecord` named `mV3`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *DebugTriangleRecord_Get_mV3(const DebugTriangleRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugTriangleRecord` named `mV3`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *DebugTriangleRecord_GetMutable_mV3(DebugTriangleRecord *_this);

/// Returns a pointer to a member variable of class `DebugTriangleRecord` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Color *DebugTriangleRecord_Get_mColor(const DebugTriangleRecord *_this);

/// Returns a mutable pointer to a member variable of class `DebugTriangleRecord` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Color *DebugTriangleRecord_GetMutable_mColor(DebugTriangleRecord *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugTriangleRecord_Destroy()` to free it when you're done using it.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `DebugTriangleRecord_DestroyArray()`.
/// Use `DebugTriangleRecord_OffsetMutablePtr()` and `DebugTriangleRecord_OffsetPtr()` to access the array elements.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_DefaultConstructArray(size_t num_elems);

/// Constructs `DebugTriangleRecord` elementwise.
/// Parameter `mV1` can not be null. It is a single object.
/// The reference to the parameter `mV1` might be preserved in the constructed object.
/// Parameter `mV2` can not be null. It is a single object.
/// The reference to the parameter `mV2` might be preserved in the constructed object.
/// Parameter `mV3` can not be null. It is a single object.
/// The reference to the parameter `mV3` might be preserved in the constructed object.
/// Parameter `mColor` can not be null. It is a single object.
/// The reference to the parameter `mColor` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugTriangleRecord_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_ConstructFrom(const JPH_Vec3 *mV1, const JPH_Vec3 *mV2, const JPH_Vec3 *mV3, const JPH_Color *mColor);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const DebugTriangleRecord *DebugTriangleRecord_OffsetPtr(const DebugTriangleRecord *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_OffsetMutablePtr(DebugTriangleRecord *ptr, ptrdiff_t i);

/// Generated from constructor `DebugTriangleRecord::DebugTriangleRecord`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `DebugTriangleRecord_Destroy()` to free it when you're done using it.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_ConstructFromAnother(const DebugTriangleRecord *_other);

/// Destroys a heap-allocated instance of `DebugTriangleRecord`. Does nothing if the pointer is null.
JOLT_API void DebugTriangleRecord_Destroy(const DebugTriangleRecord *_this);

/// Destroys a heap-allocated array of `DebugTriangleRecord`. Does nothing if the pointer is null.
JOLT_API void DebugTriangleRecord_DestroyArray(const DebugTriangleRecord *_this);

/// Generated from method `DebugTriangleRecord::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API DebugTriangleRecord *DebugTriangleRecord_AssignFromAnother(DebugTriangleRecord *_this, const DebugTriangleRecord *_other);

/// Singleton instance
/// Returns a pointer to a member variable of class `RecordingDebugRenderer` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer *const *RecordingDebugRenderer_Get_sInstance(void);

/// Singleton instance
/// Modifies a member variable of class `RecordingDebugRenderer` named `sInstance`.
/// The reference to the parameter `value` might be preserved in this object in element `sInstance`.
/// When this function is called, this object will drop object references it held previously in `sInstance`.
JOLT_API void RecordingDebugRenderer_Set_sInstance(JPH_DebugRenderer *value);

/// Singleton instance
/// Returns a mutable pointer to a member variable of class `RecordingDebugRenderer` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer **RecordingDebugRenderer_GetMutable_sInstance(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `RecordingDebugRenderer_Destroy()` to free it when you're done using it.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `RecordingDebugRenderer_DestroyArray()`.
/// Use `RecordingDebugRenderer_OffsetMutablePtr()` and `RecordingDebugRenderer_OffsetPtr()` to access the array elements.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const RecordingDebugRenderer *RecordingDebugRenderer_OffsetPtr(const RecordingDebugRenderer *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_OffsetMutablePtr(RecordingDebugRenderer *ptr, ptrdiff_t i);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(const RecordingDebugRenderer *object);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *RecordingDebugRenderer_MutableUpcastTo_JPH_NonCopyable(RecordingDebugRenderer *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::DebugRenderer`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer *RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(const RecordingDebugRenderer *object);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::DebugRenderer`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRenderer *RecordingDebugRenderer_MutableUpcastTo_JPH_DebugRenderer(RecordingDebugRenderer *object);

/// Downcasts an instance of `JPH::DebugRenderer` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(const JPH_DebugRenderer *object);

/// Downcasts an instance of `JPH::DebugRenderer` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_DebugRenderer(JPH_DebugRenderer *object);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::DebugRendererSimple`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRendererSimple *RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(const RecordingDebugRenderer *object);

/// Upcasts an instance of `RecordingDebugRenderer` to its base class `JPH::DebugRendererSimple`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRendererSimple *RecordingDebugRenderer_MutableUpcastTo_JPH_DebugRendererSimple(RecordingDebugRenderer *object);

/// Downcasts an instance of `JPH::DebugRendererSimple` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(const JPH_DebugRendererSimple *object);

/// Downcasts an instance of `JPH::DebugRendererSimple` to a derived class `RecordingDebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_DebugRendererSimple(JPH_DebugRendererSimple *object);

/// Destroys a heap-allocated instance of `RecordingDebugRenderer`. Does nothing if the pointer is null.
JOLT_API void RecordingDebugRenderer_Destroy(const RecordingDebugRenderer *_this);

/// Destroys a heap-allocated array of `RecordingDebugRenderer`. Does nothing if the pointer is null.
JOLT_API void RecordingDebugRenderer_DestroyArray(const RecordingDebugRenderer *_this);

/// Generated from method `RecordingDebugRenderer::Clear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_Clear(RecordingDebugRenderer *_this);

/// Generated from method `RecordingDebugRenderer::GetLineCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int RecordingDebugRenderer_GetLineCount(const RecordingDebugRenderer *_this);

/// Generated from method `RecordingDebugRenderer::GetTriangleCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int RecordingDebugRenderer_GetTriangleCount(const RecordingDebugRenderer *_this);

/// Generated from method `RecordingDebugRenderer::GetLine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const DebugLineRecord *RecordingDebugRenderer_GetLine(const RecordingDebugRenderer *_this, unsigned int inIndex);

/// Generated from method `RecordingDebugRenderer::GetTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const DebugTriangleRecord *RecordingDebugRenderer_GetTriangle(const RecordingDebugRenderer *_this, unsigned int inIndex);

/// Generated from method `RecordingDebugRenderer::DrawLine`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawLine(RecordingDebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor);

/// Generated from method `RecordingDebugRenderer::DrawTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawTriangle(RecordingDebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, JPH_DebugRenderer_ECastShadow inCastShadow);

/// Should be called every frame by the application to provide the camera position.
/// This is used to determine the correct LOD for rendering.
/// Generated from method `RecordingDebugRenderer::SetCameraPos`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCameraPos` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_SetCameraPos(RecordingDebugRenderer *_this, const JPH_Vec3 *inCameraPos);

/// Call once after frame is complete. Releases unused dynamically generated geometry assets.
/// Generated from method `RecordingDebugRenderer::NextFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_NextFrame(RecordingDebugRenderer *_this);

/// Draw a marker on a position
/// Generated from method `RecordingDebugRenderer::DrawMarker`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawMarker(RecordingDebugRenderer *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize);

/// Draw an arrow
/// Generated from method `RecordingDebugRenderer::DrawArrow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawArrow(RecordingDebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize);

/// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
/// Generated from method `RecordingDebugRenderer::DrawCoordinateSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Parameter `inSize` has a default argument: `1.0f`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawCoordinateSystem(RecordingDebugRenderer *_this, const JPH_Mat44 *inTransform, const float *inSize);

/// Draw a plane through inPoint with normal inNormal
/// Generated from method `RecordingDebugRenderer::DrawPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawPlane(RecordingDebugRenderer *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize);

/// Draw wireframe triangle
/// Generated from method `RecordingDebugRenderer::DrawWireTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void RecordingDebugRenderer_DrawWireTriangle(RecordingDebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor);

/// Draw wireframe sphere
/// Generated from method `RecordingDebugRenderer::DrawWireSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawWireSphere(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel);

/// Generated from method `RecordingDebugRenderer::DrawWireUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawWireUnitSphere(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel);

/// Draw a sphere
/// Generated from method `RecordingDebugRenderer::DrawSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawSphere(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Generated from method `RecordingDebugRenderer::DrawUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawUnitSphere(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
/// The capsule will be transformed by inMatrix.
/// Generated from method `RecordingDebugRenderer::DrawCapsule`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawCapsule(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
/// The cylinder will be transformed by inMatrix
/// Generated from method `RecordingDebugRenderer::DrawCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawCylinder(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a bottomless cone.
/// @param inTop Top of cone, center of base is at inTop + inAxis.
/// @param inAxis Height and direction of cone
/// @param inPerpendicular Perpendicular vector to inAxis.
/// @param inHalfAngle Specifies the cone angle in radians (angle measured between inAxis and cone surface).
/// @param inLength The length of the cone.
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `RecordingDebugRenderer::DrawOpenCone`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTop` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inPerpendicular` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawOpenCone(RecordingDebugRenderer *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draws cone rotation limits as used by the SwingTwistConstraintPart.
/// @param inMatrix Matrix that transforms from constraint space to world space
/// @param inSwingYHalfAngle See SwingTwistConstraintPart
/// @param inSwingZHalfAngle See SwingTwistConstraintPart
/// @param inEdgeLength Size of the edge of the cone shape
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `RecordingDebugRenderer::DrawSwingConeLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawSwingConeLimits(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draws rotation limits as used by the SwingTwistConstraintPart.
/// @param inMatrix Matrix that transforms from constraint space to world space
/// @param inMinSwingYAngle See SwingTwistConstraintPart
/// @param inMaxSwingYAngle See SwingTwistConstraintPart
/// @param inMinSwingZAngle See SwingTwistConstraintPart
/// @param inMaxSwingZAngle See SwingTwistConstraintPart
/// @param inEdgeLength Size of the edge of the cone shape
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `RecordingDebugRenderer::DrawSwingPyramidLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawSwingPyramidLimits(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a pie (part of a circle).
/// @param inCenter The center of the circle.
/// @param inRadius Radius of the circle.
/// @param inNormal The plane normal in which the pie resides.
/// @param inAxis The axis that defines an angle of 0 radians.
/// @param inMinAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
/// @param inMaxAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
/// @param inColor Color to use for drawing the pie.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `RecordingDebugRenderer::DrawPie`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawPie(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a tapered cylinder
/// @param inMatrix Matrix that transforms the cylinder to world space.
/// @param inTop Top of cylinder (along Y axis)
/// @param inBottom Bottom of cylinder (along Y axis)
/// @param inTopRadius Radius at the top
/// @param inBottomRadius Radius at the bottom
/// @param inColor Color to use for drawing the pie.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `RecordingDebugRenderer::DrawTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void RecordingDebugRenderer_DrawTaperedCylinder(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Calculate bounding box for a batch of triangles
/// Generated from method `RecordingDebugRenderer::sCalculateBounds`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *RecordingDebugRenderer_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount);

#ifdef __cplusplus
} // extern "C"
#endif
