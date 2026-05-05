// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/MotionType.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_BodyCreationSettings JPH_BodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/Body/BodyCreationSettings.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_BroadPhaseLayer JPH_BroadPhaseLayer; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_MotionProperties JPH_MotionProperties; // Defined in `#include <jolt/Jolt/Physics/Body/MotionProperties.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SoftBodyCreationSettings JPH_SoftBodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Generated from class `JPH::Body`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_Body JPH_Body;

/// A dummy body that can be used by constraints to attach a constraint to the world instead of another body
/// Returns a pointer to a member variable of class `JPH::Body` named `sFixedToWorld`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Body *JPH_Body_Get_sFixedToWorld(void);

/// A dummy body that can be used by constraints to attach a constraint to the world instead of another body
/// Returns a mutable pointer to a member variable of class `JPH::Body` named `sFixedToWorld`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Body *JPH_Body_GetMutable_sFixedToWorld(void);

///< Constant indicating that body is not active
/// Returns a pointer to a member variable of class `JPH::Body` named `cInactiveIndex`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_Body_Get_cInactiveIndex(void);

/// Generated from method `JPH::Body::operator new`.
JOLT_API void *Jolt_new_JPH_Body_size_t(size_t inCount);

/// Generated from method `JPH::Body::operator delete`.
JOLT_API void Jolt_delete_JPH_Body_void_ptr(void *inPointer);

/// Generated from method `JPH::Body::operator delete`.
JOLT_API void Jolt_delete_JPH_Body_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Body::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Body_size_t(size_t inCount);

/// Generated from method `JPH::Body::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Body_void_ptr(void *inPointer);

/// Generated from method `JPH::Body::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Body_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Body::operator new`.
JOLT_API void *Jolt_new_JPH_Body_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Body::operator delete`.
JOLT_API void Jolt_delete_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Body::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Body_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Body::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the id of this body
/// Generated from method `JPH::Body::GetID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyID *JPH_Body_GetID(const JPH_Body *_this);

/// Check if this body is a rigid body
/// Generated from method `JPH::Body::IsRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsRigidBody(const JPH_Body *_this);

/// Check if this body is a soft body
/// Generated from method `JPH::Body::IsSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsSoftBody(const JPH_Body *_this);

/// If this body is currently actively simulating (true) or sleeping (false)
/// Generated from method `JPH::Body::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsActive(const JPH_Body *_this);

/// Check if this body is static (not movable)
/// Generated from method `JPH::Body::IsStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsStatic(const JPH_Body *_this);

/// Check if this body is kinematic (keyframed), which means that it will move according to its current velocity, but forces don't affect it
/// Generated from method `JPH::Body::IsKinematic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsKinematic(const JPH_Body *_this);

/// Check if this body is dynamic, which means that it moves and forces can act on it
/// Generated from method `JPH::Body::IsDynamic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsDynamic(const JPH_Body *_this);

/// Check if a body could be made kinematic or dynamic (if it was created dynamic or with mAllowDynamicOrKinematic set to true)
/// Generated from method `JPH::Body::CanBeKinematicOrDynamic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_CanBeKinematicOrDynamic(const JPH_Body *_this);

/// Change the body to a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume.
/// The cheapest sensor (in terms of CPU usage) is a sensor with motion type Static (they can be moved around using BodyInterface::SetPosition/SetPositionAndRotation).
/// These sensors will only detect collisions with active Dynamic or Kinematic bodies. As soon as a body go to sleep, the contact point with the sensor will be lost.
/// If you make a sensor Dynamic or Kinematic and activate them, the sensor will be able to detect collisions with sleeping bodies too. An active sensor will never go to sleep automatically.
/// When you make a Dynamic or Kinematic sensor, make sure it is in an ObjectLayer that does not collide with Static bodies or other sensors to avoid extra overhead in the broad phase.
/// Generated from method `JPH::Body::SetIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetIsSensor(JPH_Body *_this, bool inIsSensor);

/// Check if this body is a sensor.
/// Generated from method `JPH::Body::IsSensor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsSensor(const JPH_Body *_this);

/// If kinematic objects can generate contact points against other kinematic or static objects.
/// Note that turning this on can be CPU intensive as much more collision detection work will be done without any effect on the simulation (kinematic objects are not affected by other kinematic/static objects).
/// This can be used to make sensors detect static objects. Note that the sensor must be kinematic and active for it to detect static objects.
/// Generated from method `JPH::Body::SetCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetCollideKinematicVsNonDynamic(JPH_Body *_this, bool inCollide);

/// Check if kinematic objects can generate contact points against other kinematic or static objects.
/// Generated from method `JPH::Body::GetCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetCollideKinematicVsNonDynamic(const JPH_Body *_this);

/// If PhysicsSettings::mUseManifoldReduction is true, this allows turning off manifold reduction for this specific body.
/// Manifold reduction by default will combine contacts with similar normals that come from different SubShapeIDs (e.g. different triangles in a mesh shape or different compound shapes).
/// If the application requires tracking exactly which SubShapeIDs are in contact, you can turn off manifold reduction. Note that this comes at a performance cost.
/// Consider using BodyInterface::SetUseManifoldReduction if the body could already be in contact with other bodies to ensure that the contact cache is invalidated and you get the correct contact callbacks.
/// Generated from method `JPH::Body::SetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetUseManifoldReduction(JPH_Body *_this, bool inUseReduction);

/// Check if this body can use manifold reduction.
/// Generated from method `JPH::Body::GetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetUseManifoldReduction(const JPH_Body *_this);

/// Checks if the combination of this body and inBody2 should use manifold reduction
/// Generated from method `JPH::Body::GetUseManifoldReductionWithBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetUseManifoldReductionWithBody(const JPH_Body *_this, const JPH_Body *inBody2);

/// Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Generated from method `JPH::Body::SetApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetApplyGyroscopicForce(JPH_Body *_this, bool inApply);

/// Check if the gyroscopic force is being applied for this body
/// Generated from method `JPH::Body::GetApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetApplyGyroscopicForce(const JPH_Body *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Generated from method `JPH::Body::SetEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetEnhancedInternalEdgeRemoval(JPH_Body *_this, bool inApply);

/// Check if enhanced internal edge removal is turned on
/// Generated from method `JPH::Body::GetEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetEnhancedInternalEdgeRemoval(const JPH_Body *_this);

/// Checks if the combination of this body and inBody2 should use enhanced internal edge removal
/// Generated from method `JPH::Body::GetEnhancedInternalEdgeRemovalWithBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(const JPH_Body *_this, const JPH_Body *inBody2);

/// Get the bodies motion type.
/// Generated from method `JPH::Body::GetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotionType JPH_Body_GetMotionType(const JPH_Body *_this);

/// Set the motion type of this body. Consider using BodyInterface::SetMotionType instead of this function if the body may be active or if it needs to be activated.
/// Generated from method `JPH::Body::SetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetMotionType(JPH_Body *_this, JPH_EMotionType inMotionType);

/// Get broadphase layer, this determines in which broad phase sub-tree the object is placed
/// Generated from method `JPH::Body::GetBroadPhaseLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_Body_GetBroadPhaseLayer(const JPH_Body *_this);

/// Get object layer, this determines which other objects it collides with
/// Generated from method `JPH::Body::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_Body_GetObjectLayer(const JPH_Body *_this);

/// Collision group and sub-group ID, determines which other objects it collides with
/// Generated from method `JPH::Body::GetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CollisionGroup *JPH_Body_GetCollisionGroup(const JPH_Body *_this);

/// Generated from method `JPH::Body::GetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_CollisionGroup *JPH_Body_GetCollisionGroup_mut(JPH_Body *_this);

/// Generated from method `JPH::Body::SetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGroup` can not be null. It is a single object.
JOLT_API void JPH_Body_SetCollisionGroup(JPH_Body *_this, const JPH_CollisionGroup *inGroup);

/// If this body can go to sleep. Note that disabling sleeping on a sleeping object will not wake it up.
/// Generated from method `JPH::Body::GetAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_GetAllowSleeping(const JPH_Body *_this);

/// Generated from method `JPH::Body::SetAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetAllowSleeping(JPH_Body *_this, bool inAllow);

/// Resets the sleep timer. This does not wake up the body if it is sleeping, but allows resetting the system that detects when a body is sleeping.
/// Generated from method `JPH::Body::ResetSleepTimer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_ResetSleepTimer(JPH_Body *_this);

/// Friction (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Generated from method `JPH::Body::GetFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Body_GetFriction(const JPH_Body *_this);

/// Generated from method `JPH::Body::SetFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetFriction(JPH_Body *_this, float inFriction);

/// Restitution (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Generated from method `JPH::Body::GetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Body_GetRestitution(const JPH_Body *_this);

/// Generated from method `JPH::Body::SetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetRestitution(JPH_Body *_this, float inRestitution);

/// Get world space linear velocity of the center of mass (unit: m/s)
/// Generated from method `JPH::Body::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetLinearVelocity(const JPH_Body *_this);

/// Set world space linear velocity of the center of mass (unit: m/s).
/// If you want the body to wake up when it is sleeping, use BodyInterface::SetLinearVelocity instead.
/// Generated from method `JPH::Body::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_Body_SetLinearVelocity(JPH_Body *_this, const JPH_Vec3 *inLinearVelocity);

/// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity.
/// If you want the body to wake up when it is sleeping, use BodyInterface::SetLinearVelocity instead.
/// Generated from method `JPH::Body::SetLinearVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_Body_SetLinearVelocityClamped(JPH_Body *_this, const JPH_Vec3 *inLinearVelocity);

/// Get world space angular velocity of the center of mass (unit: rad/s)
/// Generated from method `JPH::Body::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetAngularVelocity(const JPH_Body *_this);

/// Set world space angular velocity of the center of mass (unit: rad/s).
/// If you want the body to wake up when it is sleeping, use BodyInterface::SetAngularVelocity instead.
/// Generated from method `JPH::Body::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_Body_SetAngularVelocity(JPH_Body *_this, const JPH_Vec3 *inAngularVelocity);

/// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity.
/// If you want the body to wake up when it is sleeping, use BodyInterface::SetAngularVelocity instead.
/// Generated from method `JPH::Body::SetAngularVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_Body_SetAngularVelocityClamped(JPH_Body *_this, const JPH_Vec3 *inAngularVelocity);

/// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
/// Generated from method `JPH::Body::GetPointVelocityCOM`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPointRelativeToCOM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetPointVelocityCOM(const JPH_Body *_this, const JPH_Vec3 *inPointRelativeToCOM);

/// Velocity of point inPoint (in world space, e.g. on the surface of the body) of the body (unit: m/s)
/// Generated from method `JPH::Body::GetPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetPointVelocity(const JPH_Body *_this, const JPH_Vec3 *inPoint);

/// Add force (unit: N) at center of mass for the next time step, will be reset after the next call to PhysicsSystem::Update.
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddForce instead.
/// Generated from method `JPH::Body::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inForce` can not be null. It is a single object.
JOLT_API void JPH_Body_AddForce_1(JPH_Body *_this, const JPH_Vec3 *inForce);

/// Add force (unit: N) at world space position inPosition for the next time step, will be reset after the next call to PhysicsSystem::Update.
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddForce instead.
/// Generated from method `JPH::Body::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inForce` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_Body_AddForce_2(JPH_Body *_this, const JPH_Vec3 *inForce, const JPH_Vec3 *inPosition);

/// Add torque (unit: N m) for the next time step, will be reset after the next call to PhysicsSystem::Update.
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddTorque instead.
/// Generated from method `JPH::Body::AddTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTorque` can not be null. It is a single object.
JOLT_API void JPH_Body_AddTorque(JPH_Body *_this, const JPH_Vec3 *inTorque);

// Get the total amount of force applied to the center of mass this time step (through AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::Body::GetAccumulatedForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetAccumulatedForce(const JPH_Body *_this);

// Get the total amount of torque applied to the center of mass this time step (through AddForce/AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::Body::GetAccumulatedTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetAccumulatedTorque(const JPH_Body *_this);

// Reset the total accumulated force, not that this will be done automatically after every time step.
/// Generated from method `JPH::Body::ResetForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_ResetForce(JPH_Body *_this);

// Reset the total accumulated torque, not that this will be done automatically after every time step.
/// Generated from method `JPH::Body::ResetTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_ResetTorque(JPH_Body *_this);

// Reset the current velocity and accumulated force and torque.
/// Generated from method `JPH::Body::ResetMotion`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_ResetMotion(JPH_Body *_this);

/// Get inverse inertia tensor in world space
/// Generated from method `JPH::Body::GetInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Body_GetInverseInertia(const JPH_Body *_this);

/// Add impulse to center of mass (unit: kg m/s).
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddImpulse instead.
/// Generated from method `JPH::Body::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
JOLT_API void JPH_Body_AddImpulse_1(JPH_Body *_this, const JPH_Vec3 *inImpulse);

/// Add impulse to point in world space (unit: kg m/s).
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddImpulse instead.
/// Generated from method `JPH::Body::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_Body_AddImpulse_2(JPH_Body *_this, const JPH_Vec3 *inImpulse, const JPH_Vec3 *inPosition);

/// Add angular impulse in world space (unit: N m s).
/// If you want the body to wake up when it is sleeping, use BodyInterface::AddAngularImpulse instead.
/// Generated from method `JPH::Body::AddAngularImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularImpulse` can not be null. It is a single object.
JOLT_API void JPH_Body_AddAngularImpulse(JPH_Body *_this, const JPH_Vec3 *inAngularImpulse);

/// Set velocity of body such that it will be positioned at inTargetPosition/Rotation in inDeltaTime seconds.
/// If you want the body to wake up when it is sleeping, use BodyInterface::MoveKinematic instead.
/// Generated from method `JPH::Body::MoveKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTargetPosition` can not be null. It is a single object.
/// Parameter `inTargetRotation` can not be null. It is a single object.
JOLT_API void JPH_Body_MoveKinematic(JPH_Body *_this, const JPH_Vec3 *inTargetPosition, const JPH_Quat *inTargetRotation, float inDeltaTime);

/// Gets the properties needed to do buoyancy calculations
/// @param inSurfacePosition Position of the fluid surface in world space
/// @param inSurfaceNormal Normal of the fluid surface (should point up)
/// @param outTotalVolume On return this contains the total volume of the shape
/// @param outSubmergedVolume On return this contains the submerged volume of the shape
/// @param outRelativeCenterOfBuoyancy On return this contains the center of mass of the submerged volume relative to the center of mass of the body
/// Generated from method `JPH::Body::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSurfacePosition` can not be null. It is a single object.
/// Parameter `inSurfaceNormal` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outRelativeCenterOfBuoyancy` can not be null. It is a single object.
JOLT_API void JPH_Body_GetSubmergedVolume(const JPH_Body *_this, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outRelativeCenterOfBuoyancy);

/// Applies an impulse to the body that simulates fluid buoyancy and drag.
/// If you want the body to wake up when it is sleeping, use BodyInterface::ApplyBuoyancyImpulse instead.
/// @param inSurfacePosition Position of the fluid surface in world space
/// @param inSurfaceNormal Normal of the fluid surface (should point up)
/// @param inBuoyancy The buoyancy factor for the body. 1 = neutral body, < 1 sinks, > 1 floats. Note that we don't use the fluid density since it is harder to configure than a simple number between [0, 2]
/// @param inLinearDrag Linear drag factor that slows down the body when in the fluid (approx. 0.5)
/// @param inAngularDrag Angular drag factor that slows down rotation when the body is in the fluid (approx. 0.01)
/// @param inFluidVelocity The average velocity of the fluid (in m/s) in which the body resides
/// @param inGravity The gravity vector (pointing down)
/// @param inDeltaTime Delta time of the next simulation step (in s)
/// @return true if an impulse was applied, false if the body was not in the fluid
/// Generated from method `JPH::Body::ApplyBuoyancyImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSurfacePosition` can not be null. It is a single object.
/// Parameter `inSurfaceNormal` can not be null. It is a single object.
/// Parameter `inFluidVelocity` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API bool JPH_Body_ApplyBuoyancyImpulse_8(JPH_Body *_this, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime);

/// Applies an impulse to the body that simulates fluid buoyancy and drag.
/// If you want the body to wake up when it is sleeping, use BodyInterface::ApplyBuoyancyImpulse instead.
/// @param inTotalVolume Total volume of the shape of this body (m^3)
/// @param inSubmergedVolume Submerged volume of the shape of this body (m^3)
/// @param inRelativeCenterOfBuoyancy The center of mass of the submerged volume relative to the center of mass of the body
/// @param inBuoyancy The buoyancy factor for the body. 1 = neutral body, < 1 sinks, > 1 floats. Note that we don't use the fluid density since it is harder to configure than a simple number between [0, 2]
/// @param inLinearDrag Linear drag factor that slows down the body when in the fluid (approx. 0.5)
/// @param inAngularDrag Angular drag factor that slows down rotation when the body is in the fluid (approx. 0.01)
/// @param inFluidVelocity The average velocity of the fluid (in m/s) in which the body resides
/// @param inGravity The gravity vector (pointing down)
/// @param inDeltaTime Delta time of the next simulation step (in s)
/// @return true if an impulse was applied, false if the body was not in the fluid
/// Generated from method `JPH::Body::ApplyBuoyancyImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRelativeCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inFluidVelocity` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API bool JPH_Body_ApplyBuoyancyImpulse_9(JPH_Body *_this, float inTotalVolume, float inSubmergedVolume, const JPH_Vec3 *inRelativeCenterOfBuoyancy, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime);

/// Check if this body has been added to the physics system
/// Generated from method `JPH::Body::IsInBroadPhase`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsInBroadPhase(const JPH_Body *_this);

/// Check if this body has been changed in such a way that the collision cache should be considered invalid for any body interacting with this body
/// Generated from method `JPH::Body::IsCollisionCacheInvalid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_IsCollisionCacheInvalid(const JPH_Body *_this);

/// Get the shape of this body
/// Generated from method `JPH::Body::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_Body_GetShape(const JPH_Body *_this);

/// World space position of the body
/// Generated from method `JPH::Body::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetPosition(const JPH_Body *_this);

/// World space rotation of the body
/// Generated from method `JPH::Body::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Body_GetRotation(const JPH_Body *_this);

/// Calculates the transform of this body
/// Generated from method `JPH::Body::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Body_GetWorldTransform(const JPH_Body *_this);

/// Gets the world space position of this body's center of mass
/// Generated from method `JPH::Body::GetCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetCenterOfMassPosition(const JPH_Body *_this);

/// Calculates the transform for this body's center of mass
/// Generated from method `JPH::Body::GetCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Body_GetCenterOfMassTransform(const JPH_Body *_this);

/// Calculates the inverse of the transform for this body's center of mass
/// Generated from method `JPH::Body::GetInverseCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Body_GetInverseCenterOfMassTransform(const JPH_Body *_this);

/// Get world space bounding box
/// Generated from method `JPH::Body::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_AABox *JPH_Body_GetWorldSpaceBounds(const JPH_Body *_this);

/// Access to the motion properties
/// Generated from method `JPH::Body::GetMotionProperties`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_MotionProperties *JPH_Body_GetMotionProperties(const JPH_Body *_this);

/// Generated from method `JPH::Body::GetMotionProperties`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_MotionProperties *JPH_Body_GetMotionProperties_mut(JPH_Body *_this);

/// Access to the motion properties (version that does not check if the object is kinematic or dynamic)
/// Generated from method `JPH::Body::GetMotionPropertiesUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_MotionProperties *JPH_Body_GetMotionPropertiesUnchecked(const JPH_Body *_this);

/// Generated from method `JPH::Body::GetMotionPropertiesUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_MotionProperties *JPH_Body_GetMotionPropertiesUnchecked_mut(JPH_Body *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::Body::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_Body_GetUserData(const JPH_Body *_this);

/// Generated from method `JPH::Body::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetUserData(JPH_Body *_this, uint64_t inUserData);

/// Get surface normal of a particular sub shape and its world space surface position on this body
/// Generated from method `JPH::Body::GetWorldSpaceSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Body_GetWorldSpaceSurfaceNormal(const JPH_Body *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPosition);

/// Get the transformed shape of this body, which can be used to do collision detection outside of a body lock
/// Generated from method `JPH::Body::GetTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_Body_GetTransformedShape(const JPH_Body *_this);

/// Debug function to convert a body back to a body creation settings object to be able to save/recreate the body later
/// Generated from method `JPH::Body::GetBodyCreationSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyCreationSettings *JPH_Body_GetBodyCreationSettings(const JPH_Body *_this);

/// Debug function to convert a soft body back to a soft body creation settings object to be able to save/recreate the body later
/// Generated from method `JPH::Body::GetSoftBodyCreationSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyCreationSettings *JPH_Body_GetSoftBodyCreationSettings(const JPH_Body *_this);

/// Helper function for BroadPhase::FindCollidingPairs that returns true when two bodies can collide
/// It assumes that body 1 is dynamic and active and guarantees that it body 1 collides with body 2 that body 2 will not collide with body 1 in order to avoid finding duplicate collision pairs
/// Generated from method `JPH::Body::sFindCollidingPairsCanCollide`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API bool JPH_Body_sFindCollidingPairsCanCollide(const JPH_Body *inBody1, const JPH_Body *inBody2);

/// Update position using an Euler step (used during position integrate & constraint solving)
/// Generated from method `JPH::Body::AddPositionStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityTimesDeltaTime` can not be null. It is a single object.
JOLT_API void JPH_Body_AddPositionStep(JPH_Body *_this, const JPH_Vec3 *inLinearVelocityTimesDeltaTime);

/// Generated from method `JPH::Body::SubPositionStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityTimesDeltaTime` can not be null. It is a single object.
JOLT_API void JPH_Body_SubPositionStep(JPH_Body *_this, const JPH_Vec3 *inLinearVelocityTimesDeltaTime);

/// Update rotation using an Euler step (used during position integrate & constraint solving)
/// Generated from method `JPH::Body::AddRotationStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityTimesDeltaTime` can not be null. It is a single object.
JOLT_API void JPH_Body_AddRotationStep(JPH_Body *_this, const JPH_Vec3 *inAngularVelocityTimesDeltaTime);

/// Generated from method `JPH::Body::SubRotationStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityTimesDeltaTime` can not be null. It is a single object.
JOLT_API void JPH_Body_SubRotationStep(JPH_Body *_this, const JPH_Vec3 *inAngularVelocityTimesDeltaTime);

/// Flag if body is in the broadphase (should only be called by the BroadPhase)
/// Generated from method `JPH::Body::SetInBroadPhaseInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetInBroadPhaseInternal(JPH_Body *_this, bool inInBroadPhase);

/// Invalidate the contact cache (should only be called by the BodyManager), will be reset the next simulation step. Returns true if the contact cache was still valid.
/// Generated from method `JPH::Body::InvalidateContactCacheInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Body_InvalidateContactCacheInternal(JPH_Body *_this);

/// Reset the collision cache invalid flag (should only be called by the BodyManager).
/// Generated from method `JPH::Body::ValidateContactCacheInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_ValidateContactCacheInternal(JPH_Body *_this);

/// Updates world space bounding box (should only be called by the PhysicsSystem)
/// Generated from method `JPH::Body::CalculateWorldSpaceBoundsInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_CalculateWorldSpaceBoundsInternal(JPH_Body *_this);

/// Function to update body's position (should only be called by the BodyInterface since it also requires updating the broadphase)
/// Generated from method `JPH::Body::SetPositionAndRotationInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inResetSleepTimer` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Body_SetPositionAndRotationInternal(JPH_Body *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const bool *inResetSleepTimer);

/// Updates the center of mass and optionally mass properties after shifting the center of mass or changes to the shape (should only be called by the BodyInterface since it also requires updating the broadphase)
/// @param inPreviousCenterOfMass Center of mass of the shape before the alterations
/// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
/// Generated from method `JPH::Body::UpdateCenterOfMassInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPreviousCenterOfMass` can not be null. It is a single object.
JOLT_API void JPH_Body_UpdateCenterOfMassInternal(JPH_Body *_this, const JPH_Vec3 *inPreviousCenterOfMass, bool inUpdateMassProperties);

/// Function to update a body's shape (should only be called by the BodyInterface since it also requires updating the broadphase)
/// @param inShape The new shape for this body
/// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
/// Generated from method `JPH::Body::SetShapeInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Body_SetShapeInternal(JPH_Body *_this, const JPH_Shape *inShape, bool inUpdateMassProperties);

/// Access to the index in the BodyManager::mActiveBodies list
/// Generated from method `JPH::Body::GetIndexInActiveBodiesInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Body_GetIndexInActiveBodiesInternal(const JPH_Body *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Body *JPH_Body_OffsetPtr(const JPH_Body *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Body *JPH_Body_OffsetMutablePtr(JPH_Body *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Body` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Body_UpcastTo_JPH_NonCopyable(const JPH_Body *object);

/// Upcasts an instance of `JPH::Body` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Body_MutableUpcastTo_JPH_NonCopyable(JPH_Body *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Body`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Body *JPH_Body_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Body`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Body *JPH_Body_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

#ifdef __cplusplus
} // extern "C"
#endif
