// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Collision/ContactListener.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_CollideShapeResult JPH_CollideShapeResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_ContactListener JPH_ContactListener; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_ContactManifold JPH_ContactManifold; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_ContactSettings JPH_ContactSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_HeightFieldShapeSettings JPH_HeightFieldShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/HeightFieldShape.h>`.
typedef struct JPH_PhysicsStepListener JPH_PhysicsStepListener; // Defined in `#include <jolt/Jolt/Physics/PhysicsStepListener.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_RayInvDirection JPH_RayInvDirection; // Defined in `#include <jolt/Jolt/Geometry/RayAABox.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SoftBodySharedSettings JPH_SoftBodySharedSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SoftBodySharedSettings_Vertex JPH_SoftBodySharedSettings_Vertex; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SubShapeIDPair JPH_SubShapeIDPair; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeIDPair.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleAntiRollBar JPH_VehicleAntiRollBar; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleAntiRollBar.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleConstraintSettings JPH_VehicleConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleDifferentialSettings JPH_VehicleDifferentialSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleDifferential.h>`.
typedef struct JPH_WheelSettingsWV JPH_WheelSettingsWV; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleController JPH_WheeledVehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleControllerSettings JPH_WheeledVehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.


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
// EstimateResponseContactListener — concrete ContactListener that runs
// EstimateCollisionResponse in OnContactAdded and stores the result.
// ---------------------------------------------------------------------------
/// Generated from class `EstimateResponseContactListener`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ContactListener`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct EstimateResponseContactListener EstimateResponseContactListener;

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

/// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
/// Generated from method `JoltHelpers::VehicleSettingsSetController`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsSetController(JPH_VehicleConstraintSettings *settings, JPH_WheeledVehicleControllerSettings *ctrl);

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

#ifdef __cplusplus
} // extern "C"
#endif
