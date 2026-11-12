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
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Swing twist constraint settings, used to create a swing twist constraint
/// All values in this structure are copied to the swing twist constraint and the settings object is no longer needed afterwards.
///
/// This image describes the limit settings:
/// @image html Docs/SwingTwistConstraint.png
/// Generated from class `JPH::SwingTwistConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SwingTwistConstraintSettings JPH_SwingTwistConstraintSettings;

/// A swing twist constraint is a specialized constraint for humanoid ragdolls that allows limited rotation only
///
/// @see SwingTwistConstraintSettings for a description of the limits
/// Generated from class `JPH::SwingTwistConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_SwingTwistConstraint JPH_SwingTwistConstraint;

///@name Body 1 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPosition1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPosition1(const JPH_SwingTwistConstraintSettings *_this);

///@name Body 1 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPosition1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPosition1(JPH_SwingTwistConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mTwistAxis1(const JPH_SwingTwistConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mTwistAxis1(JPH_SwingTwistConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPlaneAxis1(const JPH_SwingTwistConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneAxis1(JPH_SwingTwistConstraintSettings *_this);

///@name Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPosition2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPosition2(const JPH_SwingTwistConstraintSettings *_this);

///@name Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPosition2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPosition2(JPH_SwingTwistConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mTwistAxis2(const JPH_SwingTwistConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mTwistAxis2(JPH_SwingTwistConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPlaneAxis2(const JPH_SwingTwistConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneAxis2(JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNormalHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mNormalHalfConeAngle(const JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mNormalHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mNormalHalfConeAngle`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mNormalHalfConeAngle(JPH_SwingTwistConstraintSettings *_this, float value);

///< See image at Detailed Description. Angle in radians.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNormalHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mNormalHalfConeAngle(JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mPlaneHalfConeAngle(const JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPlaneHalfConeAngle`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mPlaneHalfConeAngle(JPH_SwingTwistConstraintSettings *_this, float value);

///< See image at Detailed Description. Angle in radians.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mPlaneHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneHalfConeAngle(JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMinAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mTwistMinAngle(const JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMinAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTwistMinAngle`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mTwistMinAngle(JPH_SwingTwistConstraintSettings *_this, float value);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMinAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMinAngle(JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mTwistMaxAngle(const JPH_SwingTwistConstraintSettings *_this);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTwistMaxAngle`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mTwistMaxAngle(JPH_SwingTwistConstraintSettings *_this, float value);

///< See image at Detailed Description. Angle in radians. Should be \f$\in [-\pi, \pi]\f$.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMaxAngle(JPH_SwingTwistConstraintSettings *_this);

///< Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mMaxFrictionTorque(const JPH_SwingTwistConstraintSettings *_this);

///< Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxFrictionTorque`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mMaxFrictionTorque(JPH_SwingTwistConstraintSettings *_this, float value);

///< Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mMaxFrictionTorque(JPH_SwingTwistConstraintSettings *_this);

///@name In case the constraint is powered, this determines the motor settings around the swing and twist axis
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mSwingMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_MotorSettings *JPH_SwingTwistConstraintSettings_Get_mSwingMotorSettings(const JPH_SwingTwistConstraintSettings *_this);

///@name In case the constraint is powered, this determines the motor settings around the swing and twist axis
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mSwingMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_MotorSettings *JPH_SwingTwistConstraintSettings_GetMutable_mSwingMotorSettings(JPH_SwingTwistConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_MotorSettings *JPH_SwingTwistConstraintSettings_Get_mTwistMotorSettings(const JPH_SwingTwistConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mTwistMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_MotorSettings *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMotorSettings(JPH_SwingTwistConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SwingTwistConstraintSettings_Get_mEnabled(const JPH_SwingTwistConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mEnabled(JPH_SwingTwistConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SwingTwistConstraintSettings_GetMutable_mEnabled(JPH_SwingTwistConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SwingTwistConstraintSettings_Get_mConstraintPriority(const JPH_SwingTwistConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mConstraintPriority(JPH_SwingTwistConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mConstraintPriority(JPH_SwingTwistConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SwingTwistConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SwingTwistConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SwingTwistConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SwingTwistConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SwingTwistConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SwingTwistConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mNumPositionStepsOverride(JPH_SwingTwistConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SwingTwistConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SwingTwistConstraintSettings_Get_mDrawConstraintSize(const JPH_SwingTwistConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mDrawConstraintSize(JPH_SwingTwistConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SwingTwistConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SwingTwistConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_SwingTwistConstraintSettings_Get_mUserData(const JPH_SwingTwistConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::SwingTwistConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_SwingTwistConstraintSettings_Set_mUserData(JPH_SwingTwistConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::SwingTwistConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_SwingTwistConstraintSettings_GetMutable_mUserData(JPH_SwingTwistConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SwingTwistConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SwingTwistConstraintSettings_DestroyArray()`.
/// Use `JPH_SwingTwistConstraintSettings_OffsetMutablePtr()` and `JPH_SwingTwistConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_OffsetPtr(const JPH_SwingTwistConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_OffsetMutablePtr(JPH_SwingTwistConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SwingTwistConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SwingTwistConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SwingTwistConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SwingTwistConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SwingTwistConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SwingTwistConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SwingTwistConstraintSettings *object);

/// Upcasts an instance of `JPH::SwingTwistConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SwingTwistConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SwingTwistConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::SwingTwistConstraintSettings::SwingTwistConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SwingTwistConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SwingTwistConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SwingTwistConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SwingTwistConstraintSettings_Destroy(const JPH_SwingTwistConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_SwingTwistConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SwingTwistConstraintSettings_DestroyArray(const JPH_SwingTwistConstraintSettings *_this);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_AssignFromAnother(JPH_SwingTwistConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SwingTwistConstraintSettings *_other);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SwingTwistConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SwingTwistConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SwingTwistConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SwingTwistConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SwingTwistConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::SwingTwistConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_SwingTwistConstraintSettings_Create(const JPH_SwingTwistConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SwingTwistConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraintSettings_SetEmbedded(const JPH_SwingTwistConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SwingTwistConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SwingTwistConstraintSettings_GetRefCount(const JPH_SwingTwistConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SwingTwistConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraintSettings_AddRef(const JPH_SwingTwistConstraintSettings *_this);

/// Generated from method `JPH::SwingTwistConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraintSettings_Release(const JPH_SwingTwistConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SwingTwistConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_SwingTwistConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct swing twist constraint
/// Generated from constructor `JPH::SwingTwistConstraint::SwingTwistConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SwingTwistConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SwingTwistConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_OffsetPtr(const JPH_SwingTwistConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_OffsetMutablePtr(JPH_SwingTwistConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_SwingTwistConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SwingTwistConstraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SwingTwistConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SwingTwistConstraint_UpcastTo_JPH_NonCopyable(const JPH_SwingTwistConstraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SwingTwistConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_SwingTwistConstraint_UpcastTo_JPH_Constraint(const JPH_SwingTwistConstraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_Constraint(JPH_SwingTwistConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_SwingTwistConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SwingTwistConstraint *object);

/// Upcasts an instance of `JPH::SwingTwistConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SwingTwistConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SwingTwistConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_SwingTwistConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SwingTwistConstraint_Destroy(const JPH_SwingTwistConstraint *_this);

/// Destroys a heap-allocated array of `JPH_SwingTwistConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SwingTwistConstraint_DestroyArray(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SwingTwistConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SwingTwistConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SwingTwistConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SwingTwistConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SwingTwistConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SwingTwistConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SwingTwistConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SwingTwistConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SwingTwistConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SwingTwistConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SwingTwistConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SwingTwistConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SwingTwistConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SwingTwistConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SwingTwistConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_NotifyShapeChanged(JPH_SwingTwistConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::SwingTwistConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetupVelocityConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SwingTwistConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_ResetWarmStart(JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_WarmStartVelocityConstraint(JPH_SwingTwistConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::SwingTwistConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SwingTwistConstraint_SolveVelocityConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SwingTwistConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SwingTwistConstraint_SolvePositionConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::SwingTwistConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_DrawConstraint(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Generated from method `JPH::SwingTwistConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_DrawConstraintLimits(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::SwingTwistConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SwingTwistConstraint_GetConstraintToBody1Matrix(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SwingTwistConstraint_GetConstraintToBody2Matrix(const JPH_SwingTwistConstraint *_this);

///@name Constraint reference frame
/// Generated from method `JPH::SwingTwistConstraint::GetLocalSpacePosition1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraint_GetLocalSpacePosition1(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetLocalSpacePosition2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraint_GetLocalSpacePosition2(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetConstraintToBody1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SwingTwistConstraint_GetConstraintToBody1(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetConstraintToBody2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SwingTwistConstraint_GetConstraintToBody2(const JPH_SwingTwistConstraint *_this);

///@name Constraint limits
/// Generated from method `JPH::SwingTwistConstraint::GetNormalHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetNormalHalfConeAngle(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetNormalHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetNormalHalfConeAngle(JPH_SwingTwistConstraint *_this, float inAngle);

/// Generated from method `JPH::SwingTwistConstraint::GetPlaneHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetPlaneHalfConeAngle(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetPlaneHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetPlaneHalfConeAngle(JPH_SwingTwistConstraint *_this, float inAngle);

/// Generated from method `JPH::SwingTwistConstraint::GetTwistMinAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetTwistMinAngle(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetTwistMinAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTwistMinAngle(JPH_SwingTwistConstraint *_this, float inAngle);

/// Generated from method `JPH::SwingTwistConstraint::GetTwistMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetTwistMaxAngle(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetTwistMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTwistMaxAngle(JPH_SwingTwistConstraint *_this, float inAngle);

///@name Motor settings
/// Generated from method `JPH::SwingTwistConstraint::GetSwingMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_MotorSettings *JPH_SwingTwistConstraint_GetSwingMotorSettings(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetSwingMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_MotorSettings *JPH_SwingTwistConstraint_GetSwingMotorSettings_mut(JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTwistMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_MotorSettings *JPH_SwingTwistConstraint_GetTwistMotorSettings(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTwistMotorSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_MotorSettings *JPH_SwingTwistConstraint_GetTwistMotorSettings_mut(JPH_SwingTwistConstraint *_this);

///@name Friction control
/// Generated from method `JPH::SwingTwistConstraint::SetMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetMaxFrictionTorque(JPH_SwingTwistConstraint *_this, float inFrictionTorque);

/// Generated from method `JPH::SwingTwistConstraint::GetMaxFrictionTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetMaxFrictionTorque(const JPH_SwingTwistConstraint *_this);

/// Controls if the motors are on or off
/// Generated from method `JPH::SwingTwistConstraint::SetSwingMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetSwingMotorState(JPH_SwingTwistConstraint *_this, JPH_EMotorState inState);

/// Generated from method `JPH::SwingTwistConstraint::GetSwingMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotorState JPH_SwingTwistConstraint_GetSwingMotorState(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetTwistMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTwistMotorState(JPH_SwingTwistConstraint *_this, JPH_EMotorState inState);

/// Generated from method `JPH::SwingTwistConstraint::GetTwistMotorState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotorState JPH_SwingTwistConstraint_GetTwistMotorState(const JPH_SwingTwistConstraint *_this);

/// Set the target angular velocity of body 2 in constraint space of body 2
/// Generated from method `JPH::SwingTwistConstraint::SetTargetAngularVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTargetAngularVelocityCS(JPH_SwingTwistConstraint *_this, const JPH_Vec3 *inAngularVelocity);

/// Generated from method `JPH::SwingTwistConstraint::GetTargetAngularVelocityCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraint_GetTargetAngularVelocityCS(const JPH_SwingTwistConstraint *_this);

/// Set the target orientation in constraint space (drives constraint to: GetRotationInConstraintSpace() == inOrientation)
/// Generated from method `JPH::SwingTwistConstraint::SetTargetOrientationCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOrientation` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTargetOrientationCS(JPH_SwingTwistConstraint *_this, const JPH_Quat *inOrientation);

/// Generated from method `JPH::SwingTwistConstraint::GetTargetOrientationCS`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SwingTwistConstraint_GetTargetOrientationCS(const JPH_SwingTwistConstraint *_this);

/// Set the target orientation in body space (R2 = R1 * inOrientation, where R1 and R2 are the world space rotations for body 1 and 2).
/// Solve: R2 * ConstraintToBody2 = R1 * ConstraintToBody1 * q (see SwingTwistConstraint::GetSwingTwist) and R2 = R1 * inOrientation for q.
/// Generated from method `JPH::SwingTwistConstraint::SetTargetOrientationBS`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOrientation` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetTargetOrientationBS(JPH_SwingTwistConstraint *_this, const JPH_Quat *inOrientation);

/// Get current rotation of constraint in constraint space.
/// Solve: R2 * ConstraintToBody2 = R1 * ConstraintToBody1 * q for q.
/// Generated from method `JPH::SwingTwistConstraint::GetRotationInConstraintSpace`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_SwingTwistConstraint_GetRotationInConstraintSpace(const JPH_SwingTwistConstraint *_this);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::SwingTwistConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraint_GetTotalLambdaPosition(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTotalLambdaTwist`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetTotalLambdaTwist(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTotalLambdaSwingY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetTotalLambdaSwingY(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTotalLambdaSwingZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetTotalLambdaSwingZ(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetTotalLambdaMotor`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SwingTwistConstraint_GetTotalLambdaMotor(const JPH_SwingTwistConstraint *_this);

/// Solver interface
/// Generated from method `JPH::SwingTwistConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SwingTwistConstraint_IsActive(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_DrawConstraintReferenceFrame(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::SwingTwistConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SwingTwistConstraint_GetBody1(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SwingTwistConstraint_GetBody2(const JPH_SwingTwistConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::SwingTwistConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SwingTwistConstraint_GetConstraintPriority(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetConstraintPriority(JPH_SwingTwistConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SwingTwistConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetNumVelocityStepsOverride(JPH_SwingTwistConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SwingTwistConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SwingTwistConstraint_GetNumVelocityStepsOverride(const JPH_SwingTwistConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SwingTwistConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetNumPositionStepsOverride(JPH_SwingTwistConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SwingTwistConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SwingTwistConstraint_GetNumPositionStepsOverride(const JPH_SwingTwistConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::SwingTwistConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetEnabled(JPH_SwingTwistConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::SwingTwistConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SwingTwistConstraint_GetEnabled(const JPH_SwingTwistConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::SwingTwistConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SwingTwistConstraint_GetUserData(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetUserData(JPH_SwingTwistConstraint *_this, uint64_t inUserData);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::SwingTwistConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SwingTwistConstraint_GetDrawConstraintSize(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetDrawConstraintSize(JPH_SwingTwistConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SwingTwistConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_SetEmbedded(const JPH_SwingTwistConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SwingTwistConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SwingTwistConstraint_GetRefCount(const JPH_SwingTwistConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SwingTwistConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_AddRef(const JPH_SwingTwistConstraint *_this);

/// Generated from method `JPH::SwingTwistConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SwingTwistConstraint_Release(const JPH_SwingTwistConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SwingTwistConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_SwingTwistConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
