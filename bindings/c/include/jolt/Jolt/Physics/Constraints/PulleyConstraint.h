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
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Pulley constraint settings, used to create a pulley constraint.
/// A pulley connects two bodies via two fixed world points to each other similar to a distance constraint.
/// We define Length1 = |BodyPoint1 - FixedPoint1| where Body1 is a point on body 1 in world space and FixedPoint1 a fixed point in world space
/// Length2 = |BodyPoint2 - FixedPoint2|
/// The constraint keeps the two line segments constrained so that
/// MinDistance <= Length1 + Ratio * Length2 <= MaxDistance
/// Generated from class `JPH::PulleyConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PulleyConstraintSettings JPH_PulleyConstraintSettings;

/// A pulley constraint.
/// Generated from class `JPH::PulleyConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_PulleyConstraint JPH_PulleyConstraint;

/// Body 1 constraint attachment point (space determined by mSpace).
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mBodyPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mBodyPoint1(const JPH_PulleyConstraintSettings *_this);

/// Body 1 constraint attachment point (space determined by mSpace).
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mBodyPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1(JPH_PulleyConstraintSettings *_this);

/// Fixed world point to which body 1 is connected (always world space)
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mFixedPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mFixedPoint1(const JPH_PulleyConstraintSettings *_this);

/// Fixed world point to which body 1 is connected (always world space)
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mFixedPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1(JPH_PulleyConstraintSettings *_this);

/// Body 2 constraint attachment point (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mBodyPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mBodyPoint2(const JPH_PulleyConstraintSettings *_this);

/// Body 2 constraint attachment point (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mBodyPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2(JPH_PulleyConstraintSettings *_this);

/// Fixed world point to which body 2 is connected (always world space)
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mFixedPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mFixedPoint2(const JPH_PulleyConstraintSettings *_this);

/// Fixed world point to which body 2 is connected (always world space)
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mFixedPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2(JPH_PulleyConstraintSettings *_this);

/// Ratio between the two line segments (see formula above), can be used to create a block and tackle
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PulleyConstraintSettings_Get_mRatio(const JPH_PulleyConstraintSettings *_this);

/// Ratio between the two line segments (see formula above), can be used to create a block and tackle
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRatio`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mRatio(JPH_PulleyConstraintSettings *_this, float value);

/// Ratio between the two line segments (see formula above), can be used to create a block and tackle
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PulleyConstraintSettings_GetMutable_mRatio(JPH_PulleyConstraintSettings *_this);

/// The minimum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PulleyConstraintSettings_Get_mMinLength(const JPH_PulleyConstraintSettings *_this);

/// The minimum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinLength`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mMinLength(JPH_PulleyConstraintSettings *_this, float value);

/// The minimum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PulleyConstraintSettings_GetMutable_mMinLength(JPH_PulleyConstraintSettings *_this);

/// The maximum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PulleyConstraintSettings_Get_mMaxLength(const JPH_PulleyConstraintSettings *_this);

/// The maximum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxLength`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mMaxLength(JPH_PulleyConstraintSettings *_this, float value);

/// The maximum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PulleyConstraintSettings_GetMutable_mMaxLength(JPH_PulleyConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PulleyConstraintSettings_Get_mEnabled(const JPH_PulleyConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mEnabled(JPH_PulleyConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PulleyConstraintSettings_GetMutable_mEnabled(JPH_PulleyConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PulleyConstraintSettings_Get_mConstraintPriority(const JPH_PulleyConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mConstraintPriority(JPH_PulleyConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority(JPH_PulleyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_PulleyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mNumVelocityStepsOverride(JPH_PulleyConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_PulleyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride(const JPH_PulleyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mNumPositionStepsOverride(JPH_PulleyConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_PulleyConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PulleyConstraintSettings_Get_mDrawConstraintSize(const JPH_PulleyConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mDrawConstraintSize(JPH_PulleyConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize(JPH_PulleyConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_PulleyConstraintSettings_Get_mUserData(const JPH_PulleyConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::PulleyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_PulleyConstraintSettings_Set_mUserData(JPH_PulleyConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::PulleyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_PulleyConstraintSettings_GetMutable_mUserData(JPH_PulleyConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PulleyConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PulleyConstraintSettings_DestroyArray()`.
/// Use `JPH_PulleyConstraintSettings_OffsetMutablePtr()` and `JPH_PulleyConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_OffsetPtr(const JPH_PulleyConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_OffsetMutablePtr(JPH_PulleyConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_PulleyConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PulleyConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_PulleyConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_PulleyConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_PulleyConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_PulleyConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_PulleyConstraintSettings *object);

/// Upcasts an instance of `JPH::PulleyConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_PulleyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::PulleyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PulleyConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PulleyConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_PulleyConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PulleyConstraintSettings_Destroy(const JPH_PulleyConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_PulleyConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PulleyConstraintSettings_DestroyArray(const JPH_PulleyConstraintSettings *_this);

/// Generated from method `JPH::PulleyConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_AssignFromAnother(JPH_PulleyConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_PulleyConstraintSettings *_other);

/// Generated from method `JPH::PulleyConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PulleyConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PulleyConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PulleyConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PulleyConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PulleyConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::PulleyConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_PulleyConstraintSettings_Create(const JPH_PulleyConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PulleyConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraintSettings_SetEmbedded(const JPH_PulleyConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PulleyConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PulleyConstraintSettings_GetRefCount(const JPH_PulleyConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PulleyConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraintSettings_AddRef(const JPH_PulleyConstraintSettings *_this);

/// Generated from method `JPH::PulleyConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraintSettings_Release(const JPH_PulleyConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PulleyConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_PulleyConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct pulley constraint
/// Generated from constructor `JPH::PulleyConstraint::PulleyConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PulleyConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_PulleyConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraint *JPH_PulleyConstraint_OffsetPtr(const JPH_PulleyConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_OffsetMutablePtr(JPH_PulleyConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_PulleyConstraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_PulleyConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(const JPH_PulleyConstraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_PulleyConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_PulleyConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_PulleyConstraint_UpcastTo_JPH_Constraint(const JPH_PulleyConstraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_Constraint(JPH_PulleyConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_PulleyConstraint *object);

/// Upcasts an instance of `JPH::PulleyConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_PulleyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::PulleyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_PulleyConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_PulleyConstraint_Destroy(const JPH_PulleyConstraint *_this);

/// Destroys a heap-allocated array of `JPH_PulleyConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_PulleyConstraint_DestroyArray(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_PulleyConstraint_size_t(size_t inCount);

/// Generated from method `JPH::PulleyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::PulleyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PulleyConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PulleyConstraint_size_t(size_t inCount);

/// Generated from method `JPH::PulleyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::PulleyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PulleyConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_PulleyConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PulleyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PulleyConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PulleyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PulleyConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_NotifyShapeChanged(JPH_PulleyConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::PulleyConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetupVelocityConstraint(JPH_PulleyConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::PulleyConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_ResetWarmStart(JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_WarmStartVelocityConstraint(JPH_PulleyConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::PulleyConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PulleyConstraint_SolveVelocityConstraint(JPH_PulleyConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::PulleyConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PulleyConstraint_SolvePositionConstraint(JPH_PulleyConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::PulleyConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_DrawConstraint(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::PulleyConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_PulleyConstraint_GetConstraintToBody1Matrix(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_PulleyConstraint_GetConstraintToBody2Matrix(const JPH_PulleyConstraint *_this);

/// Update the minimum and maximum length for the constraint
/// Generated from method `JPH::PulleyConstraint::SetLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetLength(JPH_PulleyConstraint *_this, float inMinLength, float inMaxLength);

/// Generated from method `JPH::PulleyConstraint::GetMinLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PulleyConstraint_GetMinLength(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::GetMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PulleyConstraint_GetMaxLength(const JPH_PulleyConstraint *_this);

/// Get the current length of both segments (multiplied by the ratio for segment 2)
/// Generated from method `JPH::PulleyConstraint::GetCurrentLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PulleyConstraint_GetCurrentLength(const JPH_PulleyConstraint *_this);

///@name Get Lagrange multiplier from last physics update (the linear impulse applied to satisfy the constraint)
/// Generated from method `JPH::PulleyConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PulleyConstraint_GetTotalLambdaPosition(const JPH_PulleyConstraint *_this);

/// Solver interface
/// Generated from method `JPH::PulleyConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PulleyConstraint_IsActive(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_DrawConstraintReferenceFrame(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::PulleyConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_PulleyConstraint_GetBody1(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_PulleyConstraint_GetBody2(const JPH_PulleyConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::PulleyConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PulleyConstraint_GetConstraintPriority(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetConstraintPriority(JPH_PulleyConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::PulleyConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetNumVelocityStepsOverride(JPH_PulleyConstraint *_this, unsigned int inN);

/// Generated from method `JPH::PulleyConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PulleyConstraint_GetNumVelocityStepsOverride(const JPH_PulleyConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::PulleyConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetNumPositionStepsOverride(JPH_PulleyConstraint *_this, unsigned int inN);

/// Generated from method `JPH::PulleyConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PulleyConstraint_GetNumPositionStepsOverride(const JPH_PulleyConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::PulleyConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetEnabled(JPH_PulleyConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::PulleyConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PulleyConstraint_GetEnabled(const JPH_PulleyConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::PulleyConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_PulleyConstraint_GetUserData(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetUserData(JPH_PulleyConstraint *_this, uint64_t inUserData);

/// Generated from method `JPH::PulleyConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_DrawConstraintLimits(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::PulleyConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PulleyConstraint_GetDrawConstraintSize(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetDrawConstraintSize(JPH_PulleyConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PulleyConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_SetEmbedded(const JPH_PulleyConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PulleyConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PulleyConstraint_GetRefCount(const JPH_PulleyConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PulleyConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_AddRef(const JPH_PulleyConstraint *_this);

/// Generated from method `JPH::PulleyConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PulleyConstraint_Release(const JPH_PulleyConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PulleyConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_PulleyConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
