// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

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
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vector_2 JPH_Vector_2; // Defined in `#include <jolt/Jolt/Math/Vector.h>`.


/// Slider constraint settings, used to create a slider constraint
/// Generated from class `JPH::SliderConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SliderConstraintSettings JPH_SliderConstraintSettings;

/// A slider constraint allows movement in only 1 axis (and no rotation). Also known as a prismatic constraint.
/// Generated from class `JPH::SliderConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_SliderConstraint JPH_SliderConstraint;

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (the current relative position/orientation is chosen as the '0' position). Set this to false if you want to supply the attachment points yourself.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SliderConstraintSettings_Get_mAutoDetectPoint(const JPH_SliderConstraintSettings *_this);

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (the current relative position/orientation is chosen as the '0' position). Set this to false if you want to supply the attachment points yourself.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAutoDetectPoint`.
JOLT_API void JPH_SliderConstraintSettings_Set_mAutoDetectPoint(JPH_SliderConstraintSettings *_this, bool value);

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (the current relative position/orientation is chosen as the '0' position). Set this to false if you want to supply the attachment points yourself.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SliderConstraintSettings_GetMutable_mAutoDetectPoint(JPH_SliderConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace).
/// Slider axis is the axis along which movement is possible (direction), normal axis is a perpendicular vector to define the frame.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mPoint1(const JPH_SliderConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace).
/// Slider axis is the axis along which movement is possible (direction), normal axis is a perpendicular vector to define the frame.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mPoint1(JPH_SliderConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mSliderAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mSliderAxis1(const JPH_SliderConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mSliderAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mSliderAxis1(JPH_SliderConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNormalAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mNormalAxis1(const JPH_SliderConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNormalAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mNormalAxis1(JPH_SliderConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mPoint2(const JPH_SliderConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mPoint2(JPH_SliderConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mSliderAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mSliderAxis2(const JPH_SliderConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mSliderAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mSliderAxis2(JPH_SliderConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNormalAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mNormalAxis2(const JPH_SliderConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNormalAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mNormalAxis2(JPH_SliderConstraintSettings *_this);

/// When the bodies move so that mPoint1 coincides with mPoint2 the slider position is defined to be 0, movement will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-inf, 0] and mLimitsMax e [0, inf]
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SliderConstraintSettings_Get_mLimitsMin(const JPH_SliderConstraintSettings *_this);

/// When the bodies move so that mPoint1 coincides with mPoint2 the slider position is defined to be 0, movement will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-inf, 0] and mLimitsMax e [0, inf]
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLimitsMin`.
JOLT_API void JPH_SliderConstraintSettings_Set_mLimitsMin(JPH_SliderConstraintSettings *_this, float value);

/// When the bodies move so that mPoint1 coincides with mPoint2 the slider position is defined to be 0, movement will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-inf, 0] and mLimitsMax e [0, inf]
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SliderConstraintSettings_GetMutable_mLimitsMin(JPH_SliderConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SliderConstraintSettings_Get_mLimitsMax(const JPH_SliderConstraintSettings *_this);

/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLimitsMax`.
JOLT_API void JPH_SliderConstraintSettings_Set_mLimitsMax(JPH_SliderConstraintSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SliderConstraintSettings_GetMutable_mLimitsMax(JPH_SliderConstraintSettings *_this);

/// Maximum amount of friction force to apply (N) when not driven by a motor.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mMaxFrictionForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SliderConstraintSettings_Get_mMaxFrictionForce(const JPH_SliderConstraintSettings *_this);

/// Maximum amount of friction force to apply (N) when not driven by a motor.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mMaxFrictionForce`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxFrictionForce`.
JOLT_API void JPH_SliderConstraintSettings_Set_mMaxFrictionForce(JPH_SliderConstraintSettings *_this, float value);

/// Maximum amount of friction force to apply (N) when not driven by a motor.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mMaxFrictionForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SliderConstraintSettings_GetMutable_mMaxFrictionForce(JPH_SliderConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SliderConstraintSettings_Get_mEnabled(const JPH_SliderConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_SliderConstraintSettings_Set_mEnabled(JPH_SliderConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SliderConstraintSettings_GetMutable_mEnabled(JPH_SliderConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SliderConstraintSettings_Get_mConstraintPriority(const JPH_SliderConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_SliderConstraintSettings_Set_mConstraintPriority(JPH_SliderConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SliderConstraintSettings_GetMutable_mConstraintPriority(JPH_SliderConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SliderConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SliderConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_SliderConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SliderConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SliderConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SliderConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SliderConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SliderConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_SliderConstraintSettings_Set_mNumPositionStepsOverride(JPH_SliderConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SliderConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SliderConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SliderConstraintSettings_Get_mDrawConstraintSize(const JPH_SliderConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_SliderConstraintSettings_Set_mDrawConstraintSize(JPH_SliderConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SliderConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SliderConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::SliderConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_SliderConstraintSettings_Get_mUserData(const JPH_SliderConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::SliderConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_SliderConstraintSettings_Set_mUserData(JPH_SliderConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::SliderConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_SliderConstraintSettings_GetMutable_mUserData(JPH_SliderConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SliderConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SliderConstraintSettings_DestroyArray()`.
/// Use `JPH_SliderConstraintSettings_OffsetMutablePtr()` and `JPH_SliderConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_OffsetPtr(const JPH_SliderConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_OffsetMutablePtr(JPH_SliderConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_SliderConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SliderConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SliderConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SliderConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SliderConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SliderConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SliderConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SliderConstraintSettings *object);

/// Upcasts an instance of `JPH::SliderConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SliderConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::SliderConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::SliderConstraintSettings::SliderConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SliderConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SliderConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SliderConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SliderConstraintSettings_Destroy(const JPH_SliderConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_SliderConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SliderConstraintSettings_DestroyArray(const JPH_SliderConstraintSettings *_this);

/// Generated from method `JPH::SliderConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_AssignFromAnother(JPH_SliderConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SliderConstraintSettings *_other);

/// Generated from method `JPH::SliderConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SliderConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SliderConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SliderConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SliderConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SliderConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::SliderConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SliderConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SliderConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SliderConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SliderConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SliderConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SliderConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SliderConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint.
/// Note that the rotation constraint will be solved from body 1. This means that if body 1 and body 2 have different masses / inertias (kinematic body = infinite mass / inertia), body 1 should be the heaviest body.
/// Generated from method `JPH::SliderConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_SliderConstraintSettings_Create(const JPH_SliderConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Simple way of setting the slider and normal axis in world space (assumes the bodies are already oriented correctly when the constraint is created)
/// Generated from method `JPH::SliderConstraintSettings::SetSliderAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSliderAxis` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraintSettings_SetSliderAxis(JPH_SliderConstraintSettings *_this, const JPH_Vec3 *inSliderAxis);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SliderConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraintSettings_SetEmbedded(const JPH_SliderConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SliderConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SliderConstraintSettings_GetRefCount(const JPH_SliderConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SliderConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraintSettings_AddRef(const JPH_SliderConstraintSettings *_this);

/// Generated from method `JPH::SliderConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraintSettings_Release(const JPH_SliderConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SliderConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_SliderConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct slider constraint
/// Generated from constructor `JPH::SliderConstraint::SliderConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SliderConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SliderConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SliderConstraint *JPH_SliderConstraint_OffsetPtr(const JPH_SliderConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_OffsetMutablePtr(JPH_SliderConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_SliderConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SliderConstraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_SliderConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SliderConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SliderConstraint_UpcastTo_JPH_NonCopyable(const JPH_SliderConstraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SliderConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SliderConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_SliderConstraint_UpcastTo_JPH_Constraint(const JPH_SliderConstraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_SliderConstraint_MutableUpcastTo_JPH_Constraint(JPH_SliderConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_SliderConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SliderConstraint *object);

/// Upcasts an instance of `JPH::SliderConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_SliderConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SliderConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::SliderConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_SliderConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SliderConstraint_Destroy(const JPH_SliderConstraint *_this);

/// Destroys a heap-allocated array of `JPH_SliderConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_SliderConstraint_DestroyArray(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SliderConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SliderConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SliderConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SliderConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SliderConstraint_size_t(size_t inCount);

/// Generated from method `JPH::SliderConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::SliderConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SliderConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_SliderConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SliderConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_SliderConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SliderConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SliderConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SliderConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SliderConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SliderConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_NotifyShapeChanged(JPH_SliderConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::SliderConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetupVelocityConstraint(JPH_SliderConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SliderConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_ResetWarmStart(JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_WarmStartVelocityConstraint(JPH_SliderConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::SliderConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SliderConstraint_SolveVelocityConstraint(JPH_SliderConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::SliderConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SliderConstraint_SolvePositionConstraint(JPH_SliderConstraint *_this, float inDeltaTime, float inBaumgarte);

// See: TwoBodyConstraint
/// Generated from method `JPH::SliderConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SliderConstraint_GetConstraintToBody1Matrix(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SliderConstraint_GetConstraintToBody2Matrix(const JPH_SliderConstraint *_this);

/// Get the current distance from the rest position
/// Generated from method `JPH::SliderConstraint::GetCurrentPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetCurrentPosition(const JPH_SliderConstraint *_this);

/// Friction control
/// Generated from method `JPH::SliderConstraint::SetMaxFrictionForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetMaxFrictionForce(JPH_SliderConstraint *_this, float inFrictionForce);

/// Generated from method `JPH::SliderConstraint::GetMaxFrictionForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetMaxFrictionForce(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::SetTargetVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetTargetVelocity(JPH_SliderConstraint *_this, float inVelocity);

/// Generated from method `JPH::SliderConstraint::GetTargetVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetTargetVelocity(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::SetTargetPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetTargetPosition(JPH_SliderConstraint *_this, float inPosition);

/// Generated from method `JPH::SliderConstraint::GetTargetPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetTargetPosition(const JPH_SliderConstraint *_this);

/// Update the limits of the slider constraint (see SliderConstraintSettings)
/// Generated from method `JPH::SliderConstraint::SetLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetLimits(JPH_SliderConstraint *_this, float inLimitsMin, float inLimitsMax);

/// Generated from method `JPH::SliderConstraint::GetLimitsMin`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetLimitsMin(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetLimitsMax`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetLimitsMax(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::HasLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SliderConstraint_HasLimits(const JPH_SliderConstraint *_this);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::SliderConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_SliderConstraint_GetTotalLambdaPosition(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetTotalLambdaPositionLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetTotalLambdaPositionLimits(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetTotalLambdaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SliderConstraint_GetTotalLambdaRotation(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetTotalLambdaMotor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SliderConstraint_GetTotalLambdaMotor(const JPH_SliderConstraint *_this);

/// Solver interface
/// Generated from method `JPH::SliderConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SliderConstraint_IsActive(const JPH_SliderConstraint *_this);

/// Access to the connected bodies
/// Generated from method `JPH::SliderConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SliderConstraint_GetBody1(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_SliderConstraint_GetBody2(const JPH_SliderConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::SliderConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SliderConstraint_GetConstraintPriority(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetConstraintPriority(JPH_SliderConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SliderConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetNumVelocityStepsOverride(JPH_SliderConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SliderConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SliderConstraint_GetNumVelocityStepsOverride(const JPH_SliderConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::SliderConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetNumPositionStepsOverride(JPH_SliderConstraint *_this, unsigned int inN);

/// Generated from method `JPH::SliderConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SliderConstraint_GetNumPositionStepsOverride(const JPH_SliderConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::SliderConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetEnabled(JPH_SliderConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::SliderConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SliderConstraint_GetEnabled(const JPH_SliderConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::SliderConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SliderConstraint_GetUserData(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetUserData(JPH_SliderConstraint *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SliderConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_SetEmbedded(const JPH_SliderConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SliderConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SliderConstraint_GetRefCount(const JPH_SliderConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SliderConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_AddRef(const JPH_SliderConstraint *_this);

/// Generated from method `JPH::SliderConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SliderConstraint_Release(const JPH_SliderConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SliderConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_SliderConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
