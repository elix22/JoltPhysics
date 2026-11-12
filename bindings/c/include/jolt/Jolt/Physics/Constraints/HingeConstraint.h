// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Constraints/MotorSettings.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_Constraint JPH_Constraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/Constraint.h>`.
typedef struct JPH_ConstraintSettings JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/Constraint.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_MotorSettings JPH_MotorSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/MotorSettings.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_SpringSettings JPH_SpringSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/SpringSettings.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vector_2 JPH_Vector_2; // Defined in `#include <jolt/Jolt/Math/Vector.h>`.


/// Hinge constraint settings, used to create a hinge constraint
/// Generated from class `JPH::HingeConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_HingeConstraintSettings JPH_HingeConstraintSettings;

/// A hinge constraint constrains 2 bodies on a single point and allows only a single axis of rotation
/// Generated from class `JPH::HingeConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_HingeConstraint JPH_HingeConstraint;

/// Body 1 constraint reference frame (space determined by mSpace).
/// Hinge axis is the axis where rotation is allowed.
/// When the normal axis of both bodies align in world space, the hinge angle is defined to be 0.
/// mHingeAxis1 and mNormalAxis1 should be perpendicular. mHingeAxis2 and mNormalAxis2 should also be perpendicular.
/// If you configure the joint in world space and create both bodies with a relative rotation you want to be defined as zero,
/// you can simply set mHingeAxis1 = mHingeAxis2 and mNormalAxis1 = mNormalAxis2.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mPoint1(const JPH_HingeConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace).
/// Hinge axis is the axis where rotation is allowed.
/// When the normal axis of both bodies align in world space, the hinge angle is defined to be 0.
/// mHingeAxis1 and mNormalAxis1 should be perpendicular. mHingeAxis2 and mNormalAxis2 should also be perpendicular.
/// If you configure the joint in world space and create both bodies with a relative rotation you want to be defined as zero,
/// you can simply set mHingeAxis1 = mHingeAxis2 and mNormalAxis1 = mNormalAxis2.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mPoint1(JPH_HingeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mHingeAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mHingeAxis1(const JPH_HingeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mHingeAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mHingeAxis1(JPH_HingeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNormalAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mNormalAxis1(const JPH_HingeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNormalAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mNormalAxis1(JPH_HingeConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mPoint2(const JPH_HingeConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mPoint2(JPH_HingeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mHingeAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mHingeAxis2(const JPH_HingeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mHingeAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mHingeAxis2(JPH_HingeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNormalAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mNormalAxis2(const JPH_HingeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNormalAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mNormalAxis2(JPH_HingeConstraintSettings *_this);

/// Rotation around the hinge axis will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-pi, 0] and mLimitsMax e [0, pi].
/// Both angles are in radians.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HingeConstraintSettings_Get_mLimitsMin(const JPH_HingeConstraintSettings *_this);

/// Rotation around the hinge axis will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-pi, 0] and mLimitsMax e [0, pi].
/// Both angles are in radians.
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLimitsMin`.
JOLT_API void JPH_HingeConstraintSettings_Set_mLimitsMin(JPH_HingeConstraintSettings *_this, float value);

/// Rotation around the hinge axis will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-pi, 0] and mLimitsMax e [0, pi].
/// Both angles are in radians.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HingeConstraintSettings_GetMutable_mLimitsMin(JPH_HingeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HingeConstraintSettings_Get_mLimitsMax(const JPH_HingeConstraintSettings *_this);

/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLimitsMax`.
JOLT_API void JPH_HingeConstraintSettings_Set_mLimitsMax(JPH_HingeConstraintSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HingeConstraintSettings_GetMutable_mLimitsMax(JPH_HingeConstraintSettings *_this);

/// When enabled, this makes the limits soft. When the constraint exceeds the limits, a spring force will pull it back.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SpringSettings *JPH_HingeConstraintSettings_Get_mLimitsSpringSettings(const JPH_HingeConstraintSettings *_this);

/// When enabled, this makes the limits soft. When the constraint exceeds the limits, a spring force will pull it back.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SpringSettings *JPH_HingeConstraintSettings_GetMutable_mLimitsSpringSettings(JPH_HingeConstraintSettings *_this);

/// Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HingeConstraintSettings_Get_mMaxFrictionTorque(const JPH_HingeConstraintSettings *_this);

/// Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxFrictionTorque`.
JOLT_API void JPH_HingeConstraintSettings_Set_mMaxFrictionTorque(JPH_HingeConstraintSettings *_this, float value);

/// Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque(JPH_HingeConstraintSettings *_this);

/// In case the constraint is powered, this determines the motor settings around the hinge axis
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_MotorSettings *JPH_HingeConstraintSettings_Get_mMotorSettings(const JPH_HingeConstraintSettings *_this);

/// In case the constraint is powered, this determines the motor settings around the hinge axis
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_MotorSettings *JPH_HingeConstraintSettings_GetMutable_mMotorSettings(JPH_HingeConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_HingeConstraintSettings_Get_mEnabled(const JPH_HingeConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_HingeConstraintSettings_Set_mEnabled(JPH_HingeConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_HingeConstraintSettings_GetMutable_mEnabled(JPH_HingeConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HingeConstraintSettings_Get_mConstraintPriority(const JPH_HingeConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_HingeConstraintSettings_Set_mConstraintPriority(JPH_HingeConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HingeConstraintSettings_GetMutable_mConstraintPriority(JPH_HingeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_HingeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_HingeConstraintSettings_Set_mNumVelocityStepsOverride(JPH_HingeConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_HingeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride(const JPH_HingeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_HingeConstraintSettings_Set_mNumPositionStepsOverride(JPH_HingeConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_HingeConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HingeConstraintSettings_Get_mDrawConstraintSize(const JPH_HingeConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_HingeConstraintSettings_Set_mDrawConstraintSize(JPH_HingeConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize(JPH_HingeConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::HingeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_HingeConstraintSettings_Get_mUserData(const JPH_HingeConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::HingeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_HingeConstraintSettings_Set_mUserData(JPH_HingeConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::HingeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_HingeConstraintSettings_GetMutable_mUserData(JPH_HingeConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HingeConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_HingeConstraintSettings_DestroyArray()`.
/// Use `JPH_HingeConstraintSettings_OffsetMutablePtr()` and `JPH_HingeConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_OffsetPtr(const JPH_HingeConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_OffsetMutablePtr(JPH_HingeConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_HingeConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_HingeConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_HingeConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_HingeConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_HingeConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_HingeConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_HingeConstraintSettings *object);

/// Upcasts an instance of `JPH::HingeConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_HingeConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::HingeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HingeConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_HingeConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_HingeConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_HingeConstraintSettings_Destroy(const JPH_HingeConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_HingeConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_HingeConstraintSettings_DestroyArray(const JPH_HingeConstraintSettings *_this);

/// Generated from method `JPH::HingeConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_AssignFromAnother(JPH_HingeConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_HingeConstraintSettings *_other);

/// Generated from method `JPH::HingeConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_HingeConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::HingeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::HingeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::HingeConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HingeConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::HingeConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::HingeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::HingeConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::HingeConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_HingeConstraintSettings_Create(const JPH_HingeConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::HingeConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraintSettings_SetEmbedded(const JPH_HingeConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::HingeConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HingeConstraintSettings_GetRefCount(const JPH_HingeConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::HingeConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraintSettings_AddRef(const JPH_HingeConstraintSettings *_this);

/// Generated from method `JPH::HingeConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraintSettings_Release(const JPH_HingeConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::HingeConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_HingeConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct hinge constraint
/// Generated from constructor `JPH::HingeConstraint::HingeConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HingeConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_HingeConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_HingeConstraint *JPH_HingeConstraint_OffsetPtr(const JPH_HingeConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_OffsetMutablePtr(JPH_HingeConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_HingeConstraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_HingeConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_HingeConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(const JPH_HingeConstraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_HingeConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_HingeConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_HingeConstraint_UpcastTo_JPH_Constraint(const JPH_HingeConstraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_HingeConstraint_MutableUpcastTo_JPH_Constraint(JPH_HingeConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_HingeConstraint *object);

/// Upcasts an instance of `JPH::HingeConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_HingeConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_HingeConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::HingeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_HingeConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_HingeConstraint_Destroy(const JPH_HingeConstraint *_this);

/// Destroys a heap-allocated array of `JPH_HingeConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_HingeConstraint_DestroyArray(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_HingeConstraint_size_t(size_t inCount);

/// Generated from method `JPH::HingeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::HingeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::HingeConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HingeConstraint_size_t(size_t inCount);

/// Generated from method `JPH::HingeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::HingeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::HingeConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_HingeConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::HingeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::HingeConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::HingeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::HingeConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_NotifyShapeChanged(JPH_HingeConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::HingeConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetupVelocityConstraint(JPH_HingeConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::HingeConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_ResetWarmStart(JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_WarmStartVelocityConstraint(JPH_HingeConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::HingeConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HingeConstraint_SolveVelocityConstraint(JPH_HingeConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::HingeConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HingeConstraint_SolvePositionConstraint(JPH_HingeConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::HingeConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_DrawConstraint(const JPH_HingeConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Generated from method `JPH::HingeConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_DrawConstraintLimits(const JPH_HingeConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::HingeConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_HingeConstraint_GetConstraintToBody1Matrix(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_HingeConstraint_GetConstraintToBody2Matrix(const JPH_HingeConstraint *_this);

/// Get the attachment point for body 1 relative to body 1 COM (transform by Body::GetCenterOfMassTransform to take to world space)
/// Generated from method `JPH::HingeConstraint::GetLocalSpacePoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpacePoint1(const JPH_HingeConstraint *_this);

/// Get the attachment point for body 2 relative to body 2 COM (transform by Body::GetCenterOfMassTransform to take to world space)
/// Generated from method `JPH::HingeConstraint::GetLocalSpacePoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpacePoint2(const JPH_HingeConstraint *_this);

// Local space hinge directions (transform direction by Body::GetCenterOfMassTransform to take to world space)
/// Generated from method `JPH::HingeConstraint::GetLocalSpaceHingeAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceHingeAxis1(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetLocalSpaceHingeAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceHingeAxis2(const JPH_HingeConstraint *_this);

// Local space normal directions (transform direction by Body::GetCenterOfMassTransform to take to world space)
/// Generated from method `JPH::HingeConstraint::GetLocalSpaceNormalAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceNormalAxis1(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetLocalSpaceNormalAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceNormalAxis2(const JPH_HingeConstraint *_this);

/// Get the current rotation angle from the rest position
/// Generated from method `JPH::HingeConstraint::GetCurrentAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetCurrentAngle(const JPH_HingeConstraint *_this);

// Friction control
/// Generated from method `JPH::HingeConstraint::SetMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetMaxFrictionTorque(JPH_HingeConstraint *_this, float inFrictionTorque);

/// Generated from method `JPH::HingeConstraint::GetMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetMaxFrictionTorque(const JPH_HingeConstraint *_this);

// Motor settings
/// Generated from method `JPH::HingeConstraint::GetMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_MotorSettings *JPH_HingeConstraint_GetMotorSettings_mut(JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_MotorSettings *JPH_HingeConstraint_GetMotorSettings(const JPH_HingeConstraint *_this);

// Motor controls
/// Generated from method `JPH::HingeConstraint::SetMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetMotorState(JPH_HingeConstraint *_this, JPH_EMotorState inState);

/// Generated from method `JPH::HingeConstraint::GetMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotorState JPH_HingeConstraint_GetMotorState(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetTargetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetTargetAngularVelocity(JPH_HingeConstraint *_this, float inAngularVelocity);

/// Generated from method `JPH::HingeConstraint::GetTargetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetTargetAngularVelocity(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetTargetAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetTargetAngle(JPH_HingeConstraint *_this, float inAngle);

/// Generated from method `JPH::HingeConstraint::GetTargetAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetTargetAngle(const JPH_HingeConstraint *_this);

/// Set the target orientation in body space (R2 = R1 * inOrientation, where R1 and R2 are the world space rotations for body 1 and 2).
/// Calculates the local space target angle and calls SetTargetAngle. Motor state must be EMotorState::Position for this to have any effect.
/// May set the wrong angle if inOrientation contains large rotations around other axis than the hinge axis.
/// Generated from method `JPH::HingeConstraint::SetTargetOrientationBS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOrientation` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetTargetOrientationBS(JPH_HingeConstraint *_this, const JPH_Quat *inOrientation);

/// Update the rotation limits of the hinge, value in radians (see HingeConstraintSettings)
/// Generated from method `JPH::HingeConstraint::SetLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetLimits(JPH_HingeConstraint *_this, float inLimitsMin, float inLimitsMax);

/// Generated from method `JPH::HingeConstraint::GetLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetLimitsMin(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetLimitsMax(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::HasLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HingeConstraint_HasLimits(const JPH_HingeConstraint *_this);

/// Update the limits spring settings
/// Generated from method `JPH::HingeConstraint::GetLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SpringSettings *JPH_HingeConstraint_GetLimitsSpringSettings(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_SpringSettings *JPH_HingeConstraint_GetLimitsSpringSettings_mut(JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLimitsSpringSettings` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetLimitsSpringSettings(JPH_HingeConstraint *_this, const JPH_SpringSettings *inLimitsSpringSettings);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::HingeConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_HingeConstraint_GetTotalLambdaPosition(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetTotalLambdaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_HingeConstraint_GetTotalLambdaRotation(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetTotalLambdaRotationLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetTotalLambdaRotationLimits(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetTotalLambdaMotor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetTotalLambdaMotor(const JPH_HingeConstraint *_this);

/// Solver interface
/// Generated from method `JPH::HingeConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HingeConstraint_IsActive(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_DrawConstraintReferenceFrame(const JPH_HingeConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::HingeConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_HingeConstraint_GetBody1(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_HingeConstraint_GetBody2(const JPH_HingeConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::HingeConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HingeConstraint_GetConstraintPriority(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetConstraintPriority(JPH_HingeConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::HingeConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetNumVelocityStepsOverride(JPH_HingeConstraint *_this, unsigned int inN);

/// Generated from method `JPH::HingeConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HingeConstraint_GetNumVelocityStepsOverride(const JPH_HingeConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::HingeConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetNumPositionStepsOverride(JPH_HingeConstraint *_this, unsigned int inN);

/// Generated from method `JPH::HingeConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HingeConstraint_GetNumPositionStepsOverride(const JPH_HingeConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::HingeConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetEnabled(JPH_HingeConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::HingeConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HingeConstraint_GetEnabled(const JPH_HingeConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::HingeConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_HingeConstraint_GetUserData(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetUserData(JPH_HingeConstraint *_this, uint64_t inUserData);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::HingeConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HingeConstraint_GetDrawConstraintSize(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetDrawConstraintSize(JPH_HingeConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::HingeConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_SetEmbedded(const JPH_HingeConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::HingeConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HingeConstraint_GetRefCount(const JPH_HingeConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::HingeConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_AddRef(const JPH_HingeConstraint *_this);

/// Generated from method `JPH::HingeConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HingeConstraint_Release(const JPH_HingeConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::HingeConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_HingeConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
