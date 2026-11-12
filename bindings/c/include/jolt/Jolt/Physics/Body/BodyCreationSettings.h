// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/MotionQuality.h>
#include <jolt/Jolt/Physics/Body/MotionType.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Settings for constructing a rigid body
/// Generated from class `JPH::BodyCreationSettings`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RagdollSettings::Part`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BodyCreationSettings JPH_BodyCreationSettings;

///< Position of the body (not of the center of mass)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_BodyCreationSettings_Get_mPosition(const JPH_BodyCreationSettings *_this);

///< Position of the body (not of the center of mass)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mPosition(JPH_BodyCreationSettings *_this);

///< Rotation of the body
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_BodyCreationSettings_Get_mRotation(const JPH_BodyCreationSettings *_this);

///< Rotation of the body
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_BodyCreationSettings_GetMutable_mRotation(JPH_BodyCreationSettings *_this);

///< World space linear velocity of the center of mass (m/s)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_BodyCreationSettings_Get_mLinearVelocity(const JPH_BodyCreationSettings *_this);

///< World space linear velocity of the center of mass (m/s)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mLinearVelocity(JPH_BodyCreationSettings *_this);

///< World space angular velocity (rad/s)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_BodyCreationSettings_Get_mAngularVelocity(const JPH_BodyCreationSettings *_this);

///< World space angular velocity (rad/s)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mAngularVelocity(JPH_BodyCreationSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_BodyCreationSettings_Get_mUserData(const JPH_BodyCreationSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_BodyCreationSettings_Set_mUserData(JPH_BodyCreationSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_BodyCreationSettings_GetMutable_mUserData(JPH_BodyCreationSettings *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned short *JPH_BodyCreationSettings_Get_mObjectLayer(const JPH_BodyCreationSettings *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mObjectLayer`.
/// When this function is called, this object will drop object references it held previously in `mObjectLayer`.
JOLT_API void JPH_BodyCreationSettings_Set_mObjectLayer(JPH_BodyCreationSettings *_this, unsigned short value);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned short *JPH_BodyCreationSettings_GetMutable_mObjectLayer(JPH_BodyCreationSettings *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CollisionGroup *JPH_BodyCreationSettings_Get_mCollisionGroup(const JPH_BodyCreationSettings *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollisionGroup`.
/// When this function is called, this object will drop object references it held previously in `mCollisionGroup`.
JOLT_API void JPH_BodyCreationSettings_Set_mCollisionGroup(JPH_BodyCreationSettings *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CollisionGroup *JPH_BodyCreationSettings_GetMutable_mCollisionGroup(JPH_BodyCreationSettings *_this);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EMotionType *JPH_BodyCreationSettings_Get_mMotionType(const JPH_BodyCreationSettings *_this);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMotionType`.
/// When this function is called, this object will drop object references it held previously in `mMotionType`.
JOLT_API void JPH_BodyCreationSettings_Set_mMotionType(JPH_BodyCreationSettings *_this, JPH_EMotionType value);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EMotionType *JPH_BodyCreationSettings_GetMutable_mMotionType(JPH_BodyCreationSettings *_this);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic(const JPH_BodyCreationSettings *_this);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowDynamicOrKinematic`.
JOLT_API void JPH_BodyCreationSettings_Set_mAllowDynamicOrKinematic(JPH_BodyCreationSettings *_this, bool value);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic(JPH_BodyCreationSettings *_this);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mIsSensor(const JPH_BodyCreationSettings *_this);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsSensor`.
JOLT_API void JPH_BodyCreationSettings_Set_mIsSensor(JPH_BodyCreationSettings *_this, bool value);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mIsSensor(JPH_BodyCreationSettings *_this);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic(const JPH_BodyCreationSettings *_this);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollideKinematicVsNonDynamic`.
JOLT_API void JPH_BodyCreationSettings_Set_mCollideKinematicVsNonDynamic(JPH_BodyCreationSettings *_this, bool value);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic(JPH_BodyCreationSettings *_this);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mUseManifoldReduction(const JPH_BodyCreationSettings *_this);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseManifoldReduction`.
JOLT_API void JPH_BodyCreationSettings_Set_mUseManifoldReduction(JPH_BodyCreationSettings *_this, bool value);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction(JPH_BodyCreationSettings *_this);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mApplyGyroscopicForce(const JPH_BodyCreationSettings *_this);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mApplyGyroscopicForce`.
JOLT_API void JPH_BodyCreationSettings_Set_mApplyGyroscopicForce(JPH_BodyCreationSettings *_this, bool value);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce(JPH_BodyCreationSettings *_this);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EMotionQuality *JPH_BodyCreationSettings_Get_mMotionQuality(const JPH_BodyCreationSettings *_this);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMotionQuality`.
/// When this function is called, this object will drop object references it held previously in `mMotionQuality`.
JOLT_API void JPH_BodyCreationSettings_Set_mMotionQuality(JPH_BodyCreationSettings *_this, JPH_EMotionQuality value);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EMotionQuality *JPH_BodyCreationSettings_GetMutable_mMotionQuality(JPH_BodyCreationSettings *_this);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_BodyCreationSettings *_this);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnhancedInternalEdgeRemoval`.
JOLT_API void JPH_BodyCreationSettings_Set_mEnhancedInternalEdgeRemoval(JPH_BodyCreationSettings *_this, bool value);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_BodyCreationSettings *_this);

///< If this body can go to sleep or not
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_BodyCreationSettings_Get_mAllowSleeping(const JPH_BodyCreationSettings *_this);

///< If this body can go to sleep or not
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowSleeping`.
JOLT_API void JPH_BodyCreationSettings_Set_mAllowSleeping(JPH_BodyCreationSettings *_this, bool value);

///< If this body can go to sleep or not
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_BodyCreationSettings_GetMutable_mAllowSleeping(JPH_BodyCreationSettings *_this);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mFriction(const JPH_BodyCreationSettings *_this);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFriction`.
JOLT_API void JPH_BodyCreationSettings_Set_mFriction(JPH_BodyCreationSettings *_this, float value);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mFriction(JPH_BodyCreationSettings *_this);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mRestitution(const JPH_BodyCreationSettings *_this);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRestitution`.
JOLT_API void JPH_BodyCreationSettings_Set_mRestitution(JPH_BodyCreationSettings *_this, float value);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mRestitution(JPH_BodyCreationSettings *_this);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mLinearDamping(const JPH_BodyCreationSettings *_this);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLinearDamping`.
JOLT_API void JPH_BodyCreationSettings_Set_mLinearDamping(JPH_BodyCreationSettings *_this, float value);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mLinearDamping(JPH_BodyCreationSettings *_this);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mAngularDamping(const JPH_BodyCreationSettings *_this);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_BodyCreationSettings_Set_mAngularDamping(JPH_BodyCreationSettings *_this, float value);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mAngularDamping(JPH_BodyCreationSettings *_this);

///< Maximum linear velocity that this body can reach (m/s)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mMaxLinearVelocity(const JPH_BodyCreationSettings *_this);

///< Maximum linear velocity that this body can reach (m/s)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxLinearVelocity`.
JOLT_API void JPH_BodyCreationSettings_Set_mMaxLinearVelocity(JPH_BodyCreationSettings *_this, float value);

///< Maximum linear velocity that this body can reach (m/s)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity(JPH_BodyCreationSettings *_this);

///< Maximum angular velocity that this body can reach (rad/s)
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mMaxAngularVelocity(const JPH_BodyCreationSettings *_this);

///< Maximum angular velocity that this body can reach (rad/s)
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxAngularVelocity`.
JOLT_API void JPH_BodyCreationSettings_Set_mMaxAngularVelocity(JPH_BodyCreationSettings *_this, float value);

///< Maximum angular velocity that this body can reach (rad/s)
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity(JPH_BodyCreationSettings *_this);

///< Value to multiply gravity with for this body
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mGravityFactor(const JPH_BodyCreationSettings *_this);

///< Value to multiply gravity with for this body
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mGravityFactor`.
JOLT_API void JPH_BodyCreationSettings_Set_mGravityFactor(JPH_BodyCreationSettings *_this, float value);

///< Value to multiply gravity with for this body
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mGravityFactor(JPH_BodyCreationSettings *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride(const JPH_BodyCreationSettings *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_BodyCreationSettings_Set_mNumVelocityStepsOverride(JPH_BodyCreationSettings *_this, unsigned int value);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride(JPH_BodyCreationSettings *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_BodyCreationSettings_Get_mNumPositionStepsOverride(const JPH_BodyCreationSettings *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_BodyCreationSettings_Set_mNumPositionStepsOverride(JPH_BodyCreationSettings *_this, unsigned int value);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride(JPH_BodyCreationSettings *_this);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Returns a pointer to a member variable of class `JPH::BodyCreationSettings` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BodyCreationSettings_Get_mInertiaMultiplier(const JPH_BodyCreationSettings *_this);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Modifies a member variable of class `JPH::BodyCreationSettings` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertiaMultiplier`.
JOLT_API void JPH_BodyCreationSettings_Set_mInertiaMultiplier(JPH_BodyCreationSettings *_this, float value);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Returns a mutable pointer to a member variable of class `JPH::BodyCreationSettings` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier(JPH_BodyCreationSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BodyCreationSettings_DestroyArray()`.
/// Use `JPH_BodyCreationSettings_OffsetMutablePtr()` and `JPH_BodyCreationSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BodyCreationSettings *JPH_BodyCreationSettings_OffsetPtr(const JPH_BodyCreationSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_OffsetMutablePtr(JPH_BodyCreationSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_BodyCreationSettings *_other);

/// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_ShapeSettings *inShape, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EMotionType inMotionType, unsigned short inObjectLayer);

/// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EMotionType inMotionType, unsigned short inObjectLayer);

/// Destroys a heap-allocated instance of `JPH_BodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyCreationSettings_Destroy(const JPH_BodyCreationSettings *_this);

/// Destroys a heap-allocated array of `JPH_BodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyCreationSettings_DestroyArray(const JPH_BodyCreationSettings *_this);

/// Generated from method `JPH::BodyCreationSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BodyCreationSettings *JPH_BodyCreationSettings_AssignFromAnother(JPH_BodyCreationSettings *_this, Jolt_PassBy _other_pass_by, JPH_BodyCreationSettings *_other);

/// Generated from method `JPH::BodyCreationSettings::operator new`.
JOLT_API void *Jolt_new_JPH_BodyCreationSettings_size_t(size_t inCount);

/// Generated from method `JPH::BodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyCreationSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::BodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BodyCreationSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BodyCreationSettings_size_t(size_t inCount);

/// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BodyCreationSettings::operator new`.
JOLT_API void *Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BodyCreationSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access to the shape settings object. This contains serializable (non-runtime optimized) information about the Shape.
/// Generated from method `JPH::BodyCreationSettings::GetShapeSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ShapeSettings *JPH_BodyCreationSettings_GetShapeSettings(const JPH_BodyCreationSettings *_this);

/// Generated from method `JPH::BodyCreationSettings::SetShapeSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyCreationSettings_SetShapeSettings(JPH_BodyCreationSettings *_this, const JPH_ShapeSettings *inShape);

/// Access to the run-time shape object. Will convert from ShapeSettings object if needed.
/// Generated from method `JPH::BodyCreationSettings::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_BodyCreationSettings_GetShape(const JPH_BodyCreationSettings *_this);

/// Generated from method `JPH::BodyCreationSettings::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyCreationSettings_SetShape(JPH_BodyCreationSettings *_this, const JPH_Shape *inShape);

/// Check if the mass properties of this body will be calculated (only relevant for kinematic or dynamic objects that need a MotionProperties object)
/// Generated from method `JPH::BodyCreationSettings::HasMassProperties`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BodyCreationSettings_HasMassProperties(const JPH_BodyCreationSettings *_this);

#ifdef __cplusplus
} // extern "C"
#endif
