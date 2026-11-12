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


/// Constraint is split up into translation/rotation around X, Y and Z axis.
typedef enum JPH_SixDOFConstraintSettings_EAxis
{
    JPH_SixDOFConstraintSettings_EAxis_TranslationX = 0,
    JPH_SixDOFConstraintSettings_EAxis_TranslationY = 1,
    JPH_SixDOFConstraintSettings_EAxis_TranslationZ = 2,
    JPH_SixDOFConstraintSettings_EAxis_RotationX = 3,
    JPH_SixDOFConstraintSettings_EAxis_RotationY = 4,
    JPH_SixDOFConstraintSettings_EAxis_RotationZ = 5,
    JPH_SixDOFConstraintSettings_EAxis_Num = 6,
    JPH_SixDOFConstraintSettings_EAxis_NumTranslation = 3,
} JPH_SixDOFConstraintSettings_EAxis;

/// 6 Degree Of Freedom Constraint setup structure. Allows control over each of the 6 degrees of freedom.
/// Generated from class `JPH::SixDOFConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SixDOFConstraintSettings JPH_SixDOFConstraintSettings;

/// 6 Degree Of Freedom Constraint. Allows control over each of the 6 degrees of freedom.
/// Generated from class `JPH::SixDOFConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_SixDOFConstraint JPH_SixDOFConstraint;

/// Body 1 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mPosition1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mPosition1(const JPH_SixDOFConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mPosition1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mPosition1(JPH_SixDOFConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisX1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisX1(const JPH_SixDOFConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisX1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisX1(JPH_SixDOFConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisY1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisY1(const JPH_SixDOFConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisY1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisY1(JPH_SixDOFConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mPosition2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mPosition2(const JPH_SixDOFConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mPosition2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mPosition2(JPH_SixDOFConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisX2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisX2(const JPH_SixDOFConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisX2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisX2(JPH_SixDOFConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisY2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisY2(const JPH_SixDOFConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mAxisY2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisY2(JPH_SixDOFConstraintSettings *_this);

/// Friction settings.
/// For translation: Max friction force in N. 0 = no friction.
/// For rotation: Max friction torque in Nm. 0 = no friction.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mMaxFriction`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SixDOFConstraintSettings_Get_mMaxFriction(const JPH_SixDOFConstraintSettings *_this);

/// Friction settings.
/// For translation: Max friction force in N. 0 = no friction.
/// For rotation: Max friction torque in Nm. 0 = no friction.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mMaxFriction`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction(JPH_SixDOFConstraintSettings *_this);

/// Returns the size of the array member of class `JPH::SixDOFConstraintSettings` named `mMaxFriction`. The size is `6`.
JOLT_API size_t JPH_SixDOFConstraintSettings_GetSize_mMaxFriction(void);

/// Limits.
/// For translation: Min and max linear limits in m (0 is frame of body 1 and 2 coincide).
/// For rotation: Min and max angular limits in rad (0 is frame of body 1 and 2 coincide). See comments at Axis enum for limit ranges.
///
/// Remove degree of freedom by setting min = FLT_MAX and max = -FLT_MAX. The constraint will be driven to 0 for this axis.
///
/// Free movement over an axis is allowed when min = -FLT_MAX and max = FLT_MAX.
///
/// Rotation limit around X-Axis: When limited, should be \f$\in [-\pi, \pi]\f$. Can be asymmetric around zero.
///
/// Rotation limit around Y-Z Axis: Forms a pyramid or cone shaped limit:
/// * For pyramid, should be \f$\in [-\pi, \pi]\f$ and does not need to be symmetrical around zero.
/// * For cone should be \f$\in [0, \pi]\f$ and needs to be symmetrical around zero (min limit is assumed to be -max limit).
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitMin`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SixDOFConstraintSettings_Get_mLimitMin(const JPH_SixDOFConstraintSettings *_this);

/// Limits.
/// For translation: Min and max linear limits in m (0 is frame of body 1 and 2 coincide).
/// For rotation: Min and max angular limits in rad (0 is frame of body 1 and 2 coincide). See comments at Axis enum for limit ranges.
///
/// Remove degree of freedom by setting min = FLT_MAX and max = -FLT_MAX. The constraint will be driven to 0 for this axis.
///
/// Free movement over an axis is allowed when min = -FLT_MAX and max = FLT_MAX.
///
/// Rotation limit around X-Axis: When limited, should be \f$\in [-\pi, \pi]\f$. Can be asymmetric around zero.
///
/// Rotation limit around Y-Z Axis: Forms a pyramid or cone shaped limit:
/// * For pyramid, should be \f$\in [-\pi, \pi]\f$ and does not need to be symmetrical around zero.
/// * For cone should be \f$\in [0, \pi]\f$ and needs to be symmetrical around zero (min limit is assumed to be -max limit).
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitMin`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SixDOFConstraintSettings_GetMutable_mLimitMin(JPH_SixDOFConstraintSettings *_this);

/// Returns the size of the array member of class `JPH::SixDOFConstraintSettings` named `mLimitMin`. The size is `6`.
JOLT_API size_t JPH_SixDOFConstraintSettings_GetSize_mLimitMin(void);

/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitMax`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SixDOFConstraintSettings_Get_mLimitMax(const JPH_SixDOFConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitMax`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SixDOFConstraintSettings_GetMutable_mLimitMax(JPH_SixDOFConstraintSettings *_this);

/// Returns the size of the array member of class `JPH::SixDOFConstraintSettings` named `mLimitMax`. The size is `6`.
JOLT_API size_t JPH_SixDOFConstraintSettings_GetSize_mLimitMax(void);

/// When enabled, this makes the limits soft. When the constraint exceeds the limits, a spring force will pull it back.
/// Only soft translation limits are supported, soft rotation limits are not currently supported.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitsSpringSettings`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SpringSettings *JPH_SixDOFConstraintSettings_Get_mLimitsSpringSettings(const JPH_SixDOFConstraintSettings *_this);

/// When enabled, this makes the limits soft. When the constraint exceeds the limits, a spring force will pull it back.
/// Only soft translation limits are supported, soft rotation limits are not currently supported.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mLimitsSpringSettings`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SpringSettings *JPH_SixDOFConstraintSettings_GetMutable_mLimitsSpringSettings(JPH_SixDOFConstraintSettings *_this);

/// Returns the size of the array member of class `JPH::SixDOFConstraintSettings` named `mLimitsSpringSettings`. The size is `3`.
JOLT_API size_t JPH_SixDOFConstraintSettings_GetSize_mLimitsSpringSettings(void);

/// Motor settings for each axis
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mMotorSettings`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_MotorSettings *JPH_SixDOFConstraintSettings_Get_mMotorSettings(const JPH_SixDOFConstraintSettings *_this);

/// Motor settings for each axis
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mMotorSettings`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_MotorSettings *JPH_SixDOFConstraintSettings_GetMutable_mMotorSettings(JPH_SixDOFConstraintSettings *_this);

/// Returns the size of the array member of class `JPH::SixDOFConstraintSettings` named `mMotorSettings`. The size is `6`.
JOLT_API size_t JPH_SixDOFConstraintSettings_GetSize_mMotorSettings(void);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SixDOFConstraintSettings_Get_mEnabled(const JPH_SixDOFConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mEnabled(JPH_SixDOFConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SixDOFConstraintSettings_GetMutable_mEnabled(JPH_SixDOFConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SixDOFConstraintSettings_Get_mConstraintPriority(const JPH_SixDOFConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mConstraintPriority(JPH_SixDOFConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority(JPH_SixDOFConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SixDOFConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SixDOFConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SixDOFConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SixDOFConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mNumPositionStepsOverride(JPH_SixDOFConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SixDOFConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize(const JPH_SixDOFConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mDrawConstraintSize(JPH_SixDOFConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SixDOFConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_SixDOFConstraintSettings_Get_mUserData(const JPH_SixDOFConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::SixDOFConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_SixDOFConstraintSettings_Set_mUserData(JPH_SixDOFConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::SixDOFConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_SixDOFConstraintSettings_GetMutable_mUserData(JPH_SixDOFConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SixDOFConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SixDOFConstraintSettings_DestroyArray()`.
/// Use `JPH_SixDOFConstraintSettings_OffsetMutablePtr()` and `JPH_SixDOFConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_OffsetPtr(const JPH_SixDOFConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_OffsetMutablePtr(JPH_SixDOFConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SixDOFConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SixDOFConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SixDOFConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SixDOFConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SixDOFConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SixDOFConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SixDOFConstraintSettings *object);

/// Upcasts an instance of `JPH::SixDOFConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SixDOFConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SixDOFConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SixDOFConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SixDOFConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SixDOFConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SixDOFConstraintSettings_Destroy(const JPH_SixDOFConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_SixDOFConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SixDOFConstraintSettings_DestroyArray(const JPH_SixDOFConstraintSettings *_this);

/// Generated from method `JPH::SixDOFConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_AssignFromAnother(JPH_SixDOFConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SixDOFConstraintSettings *_other);

/// Generated from method `JPH::SixDOFConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SixDOFConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SixDOFConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SixDOFConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SixDOFConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SixDOFConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::SixDOFConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_SixDOFConstraintSettings_Create(const JPH_SixDOFConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Make axis free (unconstrained)
/// Generated from method `JPH::SixDOFConstraintSettings::MakeFreeAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_MakeFreeAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraintSettings::IsFreeAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraintSettings_IsFreeAxis(const JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Make axis fixed (fixed at value 0)
/// Generated from method `JPH::SixDOFConstraintSettings::MakeFixedAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_MakeFixedAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraintSettings::IsFixedAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraintSettings_IsFixedAxis(const JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Set a valid range for the constraint (if inMax < inMin, the axis will become fixed)
/// Generated from method `JPH::SixDOFConstraintSettings::SetLimitedAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_SetLimitedAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, float inMin, float inMax);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SixDOFConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_SetEmbedded(const JPH_SixDOFConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SixDOFConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SixDOFConstraintSettings_GetRefCount(const JPH_SixDOFConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SixDOFConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_AddRef(const JPH_SixDOFConstraintSettings *_this);

/// Generated from method `JPH::SixDOFConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraintSettings_Release(const JPH_SixDOFConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SixDOFConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct six DOF constraint
/// Generated from constructor `JPH::SixDOFConstraint::SixDOFConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SixDOFConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SixDOFConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraint *JPH_SixDOFConstraint_OffsetPtr(const JPH_SixDOFConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_OffsetMutablePtr(JPH_SixDOFConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SixDOFConstraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SixDOFConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(const JPH_SixDOFConstraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SixDOFConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SixDOFConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(const JPH_SixDOFConstraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_Constraint(JPH_SixDOFConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SixDOFConstraint *object);

/// Upcasts an instance of `JPH::SixDOFConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SixDOFConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SixDOFConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_SixDOFConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SixDOFConstraint_Destroy(const JPH_SixDOFConstraint *_this);

/// Destroys a heap-allocated array of `JPH_SixDOFConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SixDOFConstraint_DestroyArray(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SixDOFConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SixDOFConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SixDOFConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SixDOFConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SixDOFConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SixDOFConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SixDOFConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SixDOFConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SixDOFConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_NotifyShapeChanged(JPH_SixDOFConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::SixDOFConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetupVelocityConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SixDOFConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_ResetWarmStart(JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_WarmStartVelocityConstraint(JPH_SixDOFConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::SixDOFConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_SolveVelocityConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SixDOFConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_SolvePositionConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::SixDOFConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_DrawConstraint(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Generated from method `JPH::SixDOFConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_DrawConstraintLimits(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::SixDOFConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SixDOFConstraint_GetConstraintToBody1Matrix(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SixDOFConstraint_GetConstraintToBody2Matrix(const JPH_SixDOFConstraint *_this);

/// Update the translation limits for this constraint
/// Generated from method `JPH::SixDOFConstraint::SetTranslationLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLimitMin` can not be null. It is a single object.
/// Parameter `inLimitMax` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTranslationLimits(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inLimitMin, const JPH_Vec3 *inLimitMax);

/// Update the rotational limits for this constraint
/// Generated from method `JPH::SixDOFConstraint::SetRotationLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLimitMin` can not be null. It is a single object.
/// Parameter `inLimitMax` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetRotationLimits(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inLimitMin, const JPH_Vec3 *inLimitMax);

/// Get constraint Limits
/// Generated from method `JPH::SixDOFConstraint::GetLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SixDOFConstraint_GetLimitsMin(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraint::GetLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SixDOFConstraint_GetLimitsMax(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraint::GetTranslationLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTranslationLimitsMin(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetTranslationLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTranslationLimitsMax(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetRotationLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetRotationLimitsMin(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetRotationLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetRotationLimitsMax(const JPH_SixDOFConstraint *_this);

/// Check which axis are fixed/free
/// Generated from method `JPH::SixDOFConstraint::IsFixedAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_IsFixedAxis(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraint::IsFreeAxis`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_IsFreeAxis(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Update the limits spring settings
/// Generated from method `JPH::SixDOFConstraint::GetLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SpringSettings *JPH_SixDOFConstraint_GetLimitsSpringSettings(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraint::SetLimitsSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLimitsSpringSettings` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetLimitsSpringSettings(JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, const JPH_SpringSettings *inLimitsSpringSettings);

/// Set the max friction for each axis
/// Generated from method `JPH::SixDOFConstraint::SetMaxFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetMaxFriction(JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, float inFriction);

/// Generated from method `JPH::SixDOFConstraint::GetMaxFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SixDOFConstraint_GetMaxFriction(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Get rotation of constraint in constraint space
/// Generated from method `JPH::SixDOFConstraint::GetRotationInConstraintSpace`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SixDOFConstraint_GetRotationInConstraintSpace(const JPH_SixDOFConstraint *_this);

/// Motor settings
/// Generated from method `JPH::SixDOFConstraint::GetMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_MotorSettings *JPH_SixDOFConstraint_GetMotorSettings_mut(JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Generated from method `JPH::SixDOFConstraint::GetMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_MotorSettings *JPH_SixDOFConstraint_GetMotorSettings(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Motor controls.
/// Translation motors work in constraint space of body 1.
/// Rotation motors work in constraint space of body 2 (!).
/// Generated from method `JPH::SixDOFConstraint::SetMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetMotorState(JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, JPH_EMotorState inState);

/// Generated from method `JPH::SixDOFConstraint::GetMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotorState JPH_SixDOFConstraint_GetMotorState(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis);

/// Set the target velocity in body 1 constraint space
/// Generated from method `JPH::SixDOFConstraint::GetTargetVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTargetVelocityCS(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::SetTargetVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVelocity` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTargetVelocityCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inVelocity);

/// Set the target angular velocity in body 2 constraint space (!)
/// Generated from method `JPH::SixDOFConstraint::SetTargetAngularVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTargetAngularVelocityCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inAngularVelocity);

/// Generated from method `JPH::SixDOFConstraint::GetTargetAngularVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTargetAngularVelocityCS(const JPH_SixDOFConstraint *_this);

/// Set the target position in body 1 constraint space
/// Generated from method `JPH::SixDOFConstraint::GetTargetPositionCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTargetPositionCS(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::SetTargetPositionCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTargetPositionCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inPosition);

/// Set the target orientation in body 1 constraint space
/// Generated from method `JPH::SixDOFConstraint::SetTargetOrientationCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOrientation` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTargetOrientationCS(JPH_SixDOFConstraint *_this, const JPH_Quat *inOrientation);

/// Generated from method `JPH::SixDOFConstraint::GetTargetOrientationCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SixDOFConstraint_GetTargetOrientationCS(const JPH_SixDOFConstraint *_this);

/// Set the target orientation in body space (R2 = R1 * inOrientation, where R1 and R2 are the world space rotations for body 1 and 2).
/// Solve: R2 * ConstraintToBody2 = R1 * ConstraintToBody1 * q (see SwingTwistConstraint::GetSwingTwist) and R2 = R1 * inOrientation for q.
/// Generated from method `JPH::SixDOFConstraint::SetTargetOrientationBS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOrientation` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetTargetOrientationBS(JPH_SixDOFConstraint *_this, const JPH_Quat *inOrientation);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaPosition(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaRotation(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaMotorTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaMotorRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(const JPH_SixDOFConstraint *_this);

/// Solver interface
/// Generated from method `JPH::SixDOFConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_IsActive(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_DrawConstraintReferenceFrame(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::SixDOFConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SixDOFConstraint_GetBody1(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SixDOFConstraint_GetBody2(const JPH_SixDOFConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::SixDOFConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SixDOFConstraint_GetConstraintPriority(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetConstraintPriority(JPH_SixDOFConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SixDOFConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetNumVelocityStepsOverride(JPH_SixDOFConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SixDOFConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SixDOFConstraint_GetNumVelocityStepsOverride(const JPH_SixDOFConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SixDOFConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetNumPositionStepsOverride(JPH_SixDOFConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SixDOFConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SixDOFConstraint_GetNumPositionStepsOverride(const JPH_SixDOFConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::SixDOFConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetEnabled(JPH_SixDOFConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::SixDOFConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SixDOFConstraint_GetEnabled(const JPH_SixDOFConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::SixDOFConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SixDOFConstraint_GetUserData(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetUserData(JPH_SixDOFConstraint *_this, uint64_t inUserData);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::SixDOFConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SixDOFConstraint_GetDrawConstraintSize(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetDrawConstraintSize(JPH_SixDOFConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SixDOFConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_SetEmbedded(const JPH_SixDOFConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SixDOFConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SixDOFConstraint_GetRefCount(const JPH_SixDOFConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SixDOFConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_AddRef(const JPH_SixDOFConstraint *_this);

/// Generated from method `JPH::SixDOFConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SixDOFConstraint_Release(const JPH_SixDOFConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SixDOFConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_SixDOFConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
