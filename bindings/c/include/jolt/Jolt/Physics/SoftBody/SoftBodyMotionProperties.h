// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/MotionQuality.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_MotionProperties JPH_MotionProperties; // Defined in `#include <jolt/Jolt/Physics/Body/MotionProperties.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_SoftBodyCreationSettings JPH_SoftBodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>`.
typedef struct JPH_SoftBodySharedSettings JPH_SoftBodySharedSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SoftBodySharedSettings_Face JPH_SoftBodySharedSettings_Face; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.
typedef struct JPH_SoftBodyVertex JPH_SoftBodyVertex; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyVertex.h>`.
typedef struct JPH_TempAllocator JPH_TempAllocator; // Defined in `#include <jolt/Jolt/Core/TempAllocator.h>`.
typedef struct JPH_UVec4 JPH_UVec4; // Defined in `#include <jolt/Jolt/Math/UVec4.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Return code for ParallelUpdate
typedef enum JPH_SoftBodyMotionProperties_EStatus
{
    ///< No work was done because other threads were still working on a batch that cannot run concurrently
    JPH_SoftBodyMotionProperties_EStatus_NoWork = 1,
    ///< Work was done to progress the update
    JPH_SoftBodyMotionProperties_EStatus_DidWork = 2,
    ///< All work is done
    JPH_SoftBodyMotionProperties_EStatus_Done = 4,
} JPH_SoftBodyMotionProperties_EStatus;

/// This class contains the runtime information of a soft body.
//
// Based on: XPBD, Extended Position Based Dynamics, Matthias Muller, Ten Minute Physics
// See: https://matthias-research.github.io/pages/tenMinutePhysics/09-xpbd.pdf
/// Generated from class `JPH::SoftBodyMotionProperties`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::MotionProperties`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyMotionProperties JPH_SoftBodyMotionProperties;

///< Constant indicating that body is not active
/// Returns a pointer to a member variable of class `JPH::SoftBodyMotionProperties` named `cInactiveIndex`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_SoftBodyMotionProperties_Get_cInactiveIndex(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyMotionProperties_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyMotionProperties_DestroyArray()`.
/// Use `JPH_SoftBodyMotionProperties_OffsetMutablePtr()` and `JPH_SoftBodyMotionProperties_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_OffsetPtr(const JPH_SoftBodyMotionProperties *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_OffsetMutablePtr(JPH_SoftBodyMotionProperties *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SoftBodyMotionProperties` to its base class `JPH::MotionProperties`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotionProperties *JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(const JPH_SoftBodyMotionProperties *object);

/// Upcasts an instance of `JPH::SoftBodyMotionProperties` to its base class `JPH::MotionProperties`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotionProperties *JPH_SoftBodyMotionProperties_MutableUpcastTo_JPH_MotionProperties(JPH_SoftBodyMotionProperties *object);

/// Downcasts an instance of `JPH::MotionProperties` to a derived class `JPH::SoftBodyMotionProperties`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(const JPH_MotionProperties *object);

/// Downcasts an instance of `JPH::MotionProperties` to a derived class `JPH::SoftBodyMotionProperties`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_MutableStaticDowncastFrom_JPH_MotionProperties(JPH_MotionProperties *object);

/// Destroys a heap-allocated instance of `JPH_SoftBodyMotionProperties`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyMotionProperties_Destroy(const JPH_SoftBodyMotionProperties *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyMotionProperties`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyMotionProperties_DestroyArray(const JPH_SoftBodyMotionProperties *_this);

/// Initialize the soft body motion properties
/// Generated from method `JPH::SoftBodyMotionProperties::Initialize`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_Initialize(JPH_SoftBodyMotionProperties *_this, const JPH_SoftBodyCreationSettings *inSettings);

/// Get the shared settings of the soft body
/// Generated from method `JPH::SoftBodyMotionProperties::GetSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_SoftBodySharedSettings *JPH_SoftBodyMotionProperties_GetSettings(const JPH_SoftBodyMotionProperties *_this);

/// Access an individual vertex
/// Generated from method `JPH::SoftBodyMotionProperties::GetVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertex(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Generated from method `JPH::SoftBodyMotionProperties::GetVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertex_mut(JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Access to the state of rods
/// Generated from method `JPH::SoftBodyMotionProperties::GetRodRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SoftBodyMotionProperties_GetRodRotation(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Generated from method `JPH::SoftBodyMotionProperties::GetRodAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetRodAngularVelocity(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Access to an individual face
/// Generated from method `JPH::SoftBodyMotionProperties::GetFace`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SoftBodySharedSettings_Face *JPH_SoftBodyMotionProperties_GetFace(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Get the number of solver iterations
/// Generated from method `JPH::SoftBodyMotionProperties::GetNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyMotionProperties_GetNumIterations(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetNumIterations(JPH_SoftBodyMotionProperties *_this, unsigned int inNumIterations);

/// Get the pressure of the soft body
/// Generated from method `JPH::SoftBodyMotionProperties::GetPressure`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetPressure(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetPressure`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetPressure(JPH_SoftBodyMotionProperties *_this, float inPressure);

/// Update the position of the body while simulating (set to false for something that is attached to the static world)
/// Generated from method `JPH::SoftBodyMotionProperties::GetUpdatePosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyMotionProperties_GetUpdatePosition(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetUpdatePosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetUpdatePosition(JPH_SoftBodyMotionProperties *_this, bool inUpdatePosition);

/// If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
/// Generated from method `JPH::SoftBodyMotionProperties::GetFacesDoubleSided`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyMotionProperties_GetFacesDoubleSided(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetFacesDoubleSided`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetFacesDoubleSided(JPH_SoftBodyMotionProperties *_this, bool inDoubleSided);

/// Global setting to turn on/off skin constraints
/// Generated from method `JPH::SoftBodyMotionProperties::GetEnableSkinConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyMotionProperties_GetEnableSkinConstraints(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetEnableSkinConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetEnableSkinConstraints(JPH_SoftBodyMotionProperties *_this, bool inEnableSkinConstraints);

/// Multiplier applied to Skinned::mMaxDistance to allow tightening or loosening of the skin constraints. 0 to hard skin all vertices.
/// Generated from method `JPH::SoftBodyMotionProperties::GetSkinnedMaxDistanceMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetSkinnedMaxDistanceMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier(JPH_SoftBodyMotionProperties *_this, float inSkinnedMaxDistanceMultiplier);

/// How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
/// Generated from method `JPH::SoftBodyMotionProperties::GetVertexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetVertexRadius(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetVertexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetVertexRadius(JPH_SoftBodyMotionProperties *_this, float inVertexRadius);

/// Get local bounding box
/// Generated from method `JPH::SoftBodyMotionProperties::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_AABox *JPH_SoftBodyMotionProperties_GetLocalBounds(const JPH_SoftBodyMotionProperties *_this);

/// Get the volume of the soft body. Note can become negative if the shape is inside out!
/// Generated from method `JPH::SoftBodyMotionProperties::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetVolume(const JPH_SoftBodyMotionProperties *_this);

/// Calculate the total mass and inertia of this body based on the current state of the vertices
/// Generated from method `JPH::SoftBodyMotionProperties::CalculateMassAndInertia`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_CalculateMassAndInertia(JPH_SoftBodyMotionProperties *_this);

/// Draw the state of a soft body
/// Generated from method `JPH::SoftBodyMotionProperties::DrawVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_DrawVertices(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform);

/// Generated from method `JPH::SoftBodyMotionProperties::DrawVertexVelocities`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_DrawVertexVelocities(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform);

/// Generated from method `JPH::SoftBodyMotionProperties::DrawPredictedBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_DrawPredictedBounds(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform);

/// Skin vertices to supplied joints, information is used by the skinned constraints.
/// @param inCenterOfMassTransform Value of Body::GetCenterOfMassTransform().
/// @param inJointMatrices The joint matrices must be expressed relative to inCenterOfMassTransform.
/// @param inNumJoints Indicates how large the inJointMatrices array is (used only for validating out of bounds).
/// @param inHardSkinAll Can be used to position all vertices on the skinned vertices and can be used to hard reset the soft body.
/// @param ioTempAllocator Allocator.
/// Generated from method `JPH::SoftBodyMotionProperties::SkinVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `ioTempAllocator` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SkinVertices(JPH_SoftBodyMotionProperties *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Mat44 *inJointMatrices, unsigned int inNumJoints, bool inHardSkinAll, JPH_TempAllocator *ioTempAllocator);

/// This function allows you to update the soft body immediately without going through the PhysicsSystem.
/// This is useful if the soft body is teleported and needs to 'settle' or it can be used if a the soft body
/// is not added to the PhysicsSystem and needs to be updated manually. One reason for not adding it to the
/// PhysicsSystem is that you might want to update a soft body immediately after updating an animated object
/// that has the soft body attached to it. If the soft body is added to the PhysicsSystem it will be updated
/// by it, so calling this function will effectively update it twice. Note that when you use this function,
/// only the current thread will be used, whereas if you update through the PhysicsSystem, multiple threads may
/// be used.
/// Note that this will bypass any sleep checks. Since the dynamic objects that the soft body touches
/// will not move during this call, there can be simulation artifacts if you call this function multiple times
/// without running the physics simulation step.
/// Generated from method `JPH::SoftBodyMotionProperties::CustomUpdate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioSoftBody` can not be null. It is a single object.
/// Parameter `inSystem` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_CustomUpdate(JPH_SoftBodyMotionProperties *_this, float inDeltaTime, JPH_Body *ioSoftBody, JPH_PhysicsSystem *inSystem);

/// Motion quality, or how well it detects collisions when it has a high velocity
/// Generated from method `JPH::SoftBodyMotionProperties::GetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotionQuality JPH_SoftBodyMotionProperties_GetMotionQuality(const JPH_SoftBodyMotionProperties *_this);

/// If this body can go to sleep.
/// Generated from method `JPH::SoftBodyMotionProperties::GetAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyMotionProperties_GetAllowSleeping(const JPH_SoftBodyMotionProperties *_this);

/// Get world space linear velocity of the center of mass
/// Generated from method `JPH::SoftBodyMotionProperties::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetLinearVelocity(const JPH_SoftBodyMotionProperties *_this);

/// Set world space linear velocity of the center of mass
/// Generated from method `JPH::SoftBodyMotionProperties::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetLinearVelocity(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocity);

/// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity
/// Generated from method `JPH::SoftBodyMotionProperties::SetLinearVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetLinearVelocityClamped(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocity);

/// Get world space angular velocity of the center of mass
/// Generated from method `JPH::SoftBodyMotionProperties::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAngularVelocity(const JPH_SoftBodyMotionProperties *_this);

/// Set world space angular velocity of the center of mass
/// Generated from method `JPH::SoftBodyMotionProperties::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetAngularVelocity(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocity);

/// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity
/// Generated from method `JPH::SoftBodyMotionProperties::SetAngularVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetAngularVelocityClamped(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocity);

/// Set velocity of body such that it will be rotate/translate by inDeltaPosition/Rotation in inDeltaTime seconds.
/// Generated from method `JPH::SoftBodyMotionProperties::MoveKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDeltaPosition` can not be null. It is a single object.
/// Parameter `inDeltaRotation` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_MoveKinematic(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inDeltaPosition, const JPH_Quat *inDeltaRotation, float inDeltaTime);

/// Maximum linear velocity that a body can achieve. Used to prevent the system from exploding.
/// Generated from method `JPH::SoftBodyMotionProperties::GetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetMaxLinearVelocity(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetMaxLinearVelocity(JPH_SoftBodyMotionProperties *_this, float inLinearVelocity);

/// Maximum angular velocity that a body can achieve. Used to prevent the system from exploding.
/// Generated from method `JPH::SoftBodyMotionProperties::GetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetMaxAngularVelocity(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetMaxAngularVelocity(JPH_SoftBodyMotionProperties *_this, float inAngularVelocity);

/// Clamp velocity according to limit
/// Generated from method `JPH::SoftBodyMotionProperties::ClampLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ClampLinearVelocity(JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::ClampAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ClampAngularVelocity(JPH_SoftBodyMotionProperties *_this);

/// Get linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Generated from method `JPH::SoftBodyMotionProperties::GetLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetLinearDamping(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetLinearDamping(JPH_SoftBodyMotionProperties *_this, float inLinearDamping);

/// Get angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Generated from method `JPH::SoftBodyMotionProperties::GetAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetAngularDamping(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetAngularDamping(JPH_SoftBodyMotionProperties *_this, float inAngularDamping);

/// Get gravity factor (1 = normal gravity, 0 = no gravity)
/// Generated from method `JPH::SoftBodyMotionProperties::GetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetGravityFactor(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetGravityFactor(JPH_SoftBodyMotionProperties *_this, float inGravityFactor);

/// Get inverse mass (1 / mass). Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as 1 / mass = 0)
/// Generated from method `JPH::SoftBodyMotionProperties::GetInverseMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetInverseMass(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::GetInverseMassUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyMotionProperties_GetInverseMassUnchecked(const JPH_SoftBodyMotionProperties *_this);

/// Set the inverse mass (1 / mass).
/// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
/// If you change mass, inertia should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
/// If all your translation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
/// Generated from method `JPH::SoftBodyMotionProperties::SetInverseMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetInverseMass(JPH_SoftBodyMotionProperties *_this, float inInverseMass);

/// Diagonal of inverse inertia matrix: D. Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as D = 0)
/// Generated from method `JPH::SoftBodyMotionProperties::GetInverseInertiaDiagonal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal(const JPH_SoftBodyMotionProperties *_this);

/// Rotation (R) that takes inverse inertia diagonal to local space: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$
/// Generated from method `JPH::SoftBodyMotionProperties::GetInertiaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SoftBodyMotionProperties_GetInertiaRotation(const JPH_SoftBodyMotionProperties *_this);

/// Set the inverse inertia tensor in local space by setting the diagonal and the rotation: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$.
/// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
/// If you change inertia, mass should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
/// If all your rotation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
/// Generated from method `JPH::SoftBodyMotionProperties::SetInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDiagonal` can not be null. It is a single object.
/// Parameter `inRot` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetInverseInertia(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inDiagonal, const JPH_Quat *inRot);

/// Sets the mass to inMass and scale the inertia tensor based on the ratio between the old and new mass.
/// Note that this only works when the current mass is finite (i.e. the body is dynamic and translational degrees of freedom are not restricted).
/// Generated from method `JPH::SoftBodyMotionProperties::ScaleToMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ScaleToMass(JPH_SoftBodyMotionProperties *_this, float inMass);

/// Get inverse inertia matrix (\f$I_{body}^{-1}\f$). Will be a matrix of zeros for a static or kinematic object.
/// Generated from method `JPH::SoftBodyMotionProperties::GetLocalSpaceInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia(const JPH_SoftBodyMotionProperties *_this);

/// Same as GetLocalSpaceInverseInertia() but doesn't check if the body is dynamic
/// Generated from method `JPH::SoftBodyMotionProperties::GetLocalSpaceInverseInertiaUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked(const JPH_SoftBodyMotionProperties *_this);

/// Get inverse inertia matrix (\f$I^{-1}\f$) for a given object rotation (translation will be ignored). Zero if object is static or kinematic.
/// Generated from method `JPH::SoftBodyMotionProperties::GetInverseInertiaForRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation(const JPH_SoftBodyMotionProperties *_this, const JPH_Mat44 *inRotation);

/// Multiply a vector with the inverse world space inertia tensor (\f$I_{world}^{-1}\f$). Zero if object is static or kinematic.
/// Generated from method `JPH::SoftBodyMotionProperties::MultiplyWorldSpaceInverseInertiaByVector`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector(const JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inV);

/// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
/// Generated from method `JPH::SoftBodyMotionProperties::GetPointVelocityCOM`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPointRelativeToCOM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetPointVelocityCOM(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inPointRelativeToCOM);

// Get the total amount of force applied to the center of mass this time step (through Body::AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::SoftBodyMotionProperties::GetAccumulatedForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAccumulatedForce(const JPH_SoftBodyMotionProperties *_this);

// Get the total amount of torque applied to the center of mass this time step (through Body::AddForce/Body::AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::SoftBodyMotionProperties::GetAccumulatedTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAccumulatedTorque(const JPH_SoftBodyMotionProperties *_this);

// Reset the total accumulated force, note that this will be done automatically after every time step.
/// Generated from method `JPH::SoftBodyMotionProperties::ResetForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ResetForce(JPH_SoftBodyMotionProperties *_this);

// Reset the total accumulated torque, note that this will be done automatically after every time step.
/// Generated from method `JPH::SoftBodyMotionProperties::ResetTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ResetTorque(JPH_SoftBodyMotionProperties *_this);

// Reset the current velocity and accumulated force and torque.
/// Generated from method `JPH::SoftBodyMotionProperties::ResetMotion`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ResetMotion(JPH_SoftBodyMotionProperties *_this);

/// Returns a vector where the linear components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
/// Generated from method `JPH::SoftBodyMotionProperties::GetLinearDOFsMask`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_SoftBodyMotionProperties_GetLinearDOFsMask(const JPH_SoftBodyMotionProperties *_this);

/// Takes a translation vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
/// Generated from method `JPH::SoftBodyMotionProperties::LockTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_LockTranslation(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inV);

/// Returns a vector where the angular components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
/// Generated from method `JPH::SoftBodyMotionProperties::GetAngularDOFsMask`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_SoftBodyMotionProperties_GetAngularDOFsMask(const JPH_SoftBodyMotionProperties *_this);

/// Takes an angular velocity / torque vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
/// Generated from method `JPH::SoftBodyMotionProperties::LockAngular`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyMotionProperties_LockAngular(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inV);

/// Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SoftBodyMotionProperties::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride(JPH_SoftBodyMotionProperties *_this, unsigned int inN);

/// Generated from method `JPH::SoftBodyMotionProperties::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride(const JPH_SoftBodyMotionProperties *_this);

/// Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SoftBodyMotionProperties::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride(JPH_SoftBodyMotionProperties *_this, unsigned int inN);

/// Generated from method `JPH::SoftBodyMotionProperties::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride(const JPH_SoftBodyMotionProperties *_this);

///@name Update linear and angular velocity (used during constraint solving)
///@{
/// Generated from method `JPH::SoftBodyMotionProperties::AddLinearVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_AddLinearVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange);

/// Generated from method `JPH::SoftBodyMotionProperties::SubLinearVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SubLinearVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange);

/// Generated from method `JPH::SoftBodyMotionProperties::AddAngularVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_AddAngularVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange);

/// Generated from method `JPH::SoftBodyMotionProperties::SubAngularVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SubAngularVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange);

/// Apply the gyroscopic force (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Generated from method `JPH::SoftBodyMotionProperties::ApplyGyroscopicForceInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal(JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, float inDeltaTime);

/// Apply all accumulated forces, torques and drag (should only be called by the PhysicsSystem)
/// Generated from method `JPH::SoftBodyMotionProperties::ApplyForceTorqueAndDragInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal(JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inGravity, float inDeltaTime);

/// Access to the island index
/// Generated from method `JPH::SoftBodyMotionProperties::GetIslandIndexInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyMotionProperties_GetIslandIndexInternal(const JPH_SoftBodyMotionProperties *_this);

/// Generated from method `JPH::SoftBodyMotionProperties::SetIslandIndexInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_SetIslandIndexInternal(JPH_SoftBodyMotionProperties *_this, unsigned int inIndex);

/// Access to the index in the active bodies array
/// Generated from method `JPH::SoftBodyMotionProperties::GetIndexInActiveBodiesInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal(const JPH_SoftBodyMotionProperties *_this);

/// Reset spheres to center around inPoints with radius 0
/// Generated from method `JPH::SoftBodyMotionProperties::ResetSleepTestSpheres`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ResetSleepTestSpheres(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inPoints);

/// Reset the sleep test timer without resetting the sleep test spheres
/// Generated from method `JPH::SoftBodyMotionProperties::ResetSleepTestTimer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyMotionProperties_ResetSleepTestTimer(JPH_SoftBodyMotionProperties *_this);

#ifdef __cplusplus
} // extern "C"
#endif
