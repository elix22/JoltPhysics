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


/// Rack and pinion constraint (slider & gear) settings
/// Generated from class `JPH::RackAndPinionConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RackAndPinionConstraintSettings JPH_RackAndPinionConstraintSettings;

/// A rack and pinion constraint constrains the rotation of body1 to the translation of body 2.
/// Note that this constraint needs to be used in conjunction with a hinge constraint for body 1 and a slider constraint for body 2.
/// Generated from class `JPH::RackAndPinionConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_RackAndPinionConstraint JPH_RackAndPinionConstraint;

/// Body 1 (pinion) constraint reference frame (space determined by mSpace).
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mHingeAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RackAndPinionConstraintSettings_Get_mHingeAxis(const JPH_RackAndPinionConstraintSettings *_this);

/// Body 1 (pinion) constraint reference frame (space determined by mSpace).
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mHingeAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RackAndPinionConstraintSettings_GetMutable_mHingeAxis(JPH_RackAndPinionConstraintSettings *_this);

/// Body 2 (rack) constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mSliderAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RackAndPinionConstraintSettings_Get_mSliderAxis(const JPH_RackAndPinionConstraintSettings *_this);

/// Body 2 (rack) constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mSliderAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RackAndPinionConstraintSettings_GetMutable_mSliderAxis(JPH_RackAndPinionConstraintSettings *_this);

/// Ratio between the rack and pinion, see SetRatio.
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RackAndPinionConstraintSettings_Get_mRatio(const JPH_RackAndPinionConstraintSettings *_this);

/// Ratio between the rack and pinion, see SetRatio.
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRatio`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mRatio(JPH_RackAndPinionConstraintSettings *_this, float value);

/// Ratio between the rack and pinion, see SetRatio.
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RackAndPinionConstraintSettings_GetMutable_mRatio(JPH_RackAndPinionConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RackAndPinionConstraintSettings_Get_mEnabled(const JPH_RackAndPinionConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mEnabled(JPH_RackAndPinionConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RackAndPinionConstraintSettings_GetMutable_mEnabled(JPH_RackAndPinionConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mConstraintPriority(const JPH_RackAndPinionConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mConstraintPriority(JPH_RackAndPinionConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mConstraintPriority(JPH_RackAndPinionConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_RackAndPinionConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mNumVelocityStepsOverride(JPH_RackAndPinionConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_RackAndPinionConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mNumPositionStepsOverride(const JPH_RackAndPinionConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mNumPositionStepsOverride(JPH_RackAndPinionConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_RackAndPinionConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RackAndPinionConstraintSettings_Get_mDrawConstraintSize(const JPH_RackAndPinionConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mDrawConstraintSize(JPH_RackAndPinionConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RackAndPinionConstraintSettings_GetMutable_mDrawConstraintSize(JPH_RackAndPinionConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_RackAndPinionConstraintSettings_Get_mUserData(const JPH_RackAndPinionConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::RackAndPinionConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_RackAndPinionConstraintSettings_Set_mUserData(JPH_RackAndPinionConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::RackAndPinionConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_RackAndPinionConstraintSettings_GetMutable_mUserData(JPH_RackAndPinionConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RackAndPinionConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RackAndPinionConstraintSettings_DestroyArray()`.
/// Use `JPH_RackAndPinionConstraintSettings_OffsetMutablePtr()` and `JPH_RackAndPinionConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_OffsetPtr(const JPH_RackAndPinionConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_OffsetMutablePtr(JPH_RackAndPinionConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_RackAndPinionConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_RackAndPinionConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RackAndPinionConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_RackAndPinionConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_RackAndPinionConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_RackAndPinionConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_RackAndPinionConstraintSettings *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_RackAndPinionConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::RackAndPinionConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::RackAndPinionConstraintSettings::RackAndPinionConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RackAndPinionConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RackAndPinionConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RackAndPinionConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RackAndPinionConstraintSettings_Destroy(const JPH_RackAndPinionConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_RackAndPinionConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RackAndPinionConstraintSettings_DestroyArray(const JPH_RackAndPinionConstraintSettings *_this);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_AssignFromAnother(JPH_RackAndPinionConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_RackAndPinionConstraintSettings *_other);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RackAndPinionConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RackAndPinionConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RackAndPinionConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RackAndPinionConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint.
/// Body1 should be the pinion (gear) and body 2 the rack (slider).
/// Generated from method `JPH::RackAndPinionConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_RackAndPinionConstraintSettings_Create(const JPH_RackAndPinionConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Defines the ratio between the rotation of the pinion and the translation of the rack.
/// The ratio is defined as: PinionRotation(t) = ratio * RackTranslation(t)
/// @param inNumTeethRack Number of teeth that the rack has
/// @param inRackLength Length of the rack
/// @param inNumTeethPinion Number of teeth the pinion has
/// Generated from method `JPH::RackAndPinionConstraintSettings::SetRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraintSettings_SetRatio(JPH_RackAndPinionConstraintSettings *_this, int inNumTeethRack, float inRackLength, int inNumTeethPinion);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RackAndPinionConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraintSettings_SetEmbedded(const JPH_RackAndPinionConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RackAndPinionConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RackAndPinionConstraintSettings_GetRefCount(const JPH_RackAndPinionConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RackAndPinionConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraintSettings_AddRef(const JPH_RackAndPinionConstraintSettings *_this);

/// Generated from method `JPH::RackAndPinionConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraintSettings_Release(const JPH_RackAndPinionConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RackAndPinionConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_RackAndPinionConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct gear constraint
/// Generated from constructor `JPH::RackAndPinionConstraint::RackAndPinionConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RackAndPinionConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_RackAndPinionConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_OffsetPtr(const JPH_RackAndPinionConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_OffsetMutablePtr(JPH_RackAndPinionConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_RackAndPinionConstraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_RackAndPinionConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_RackAndPinionConstraint_UpcastTo_JPH_NonCopyable(const JPH_RackAndPinionConstraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_RackAndPinionConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_Constraint(const JPH_RackAndPinionConstraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_Constraint(JPH_RackAndPinionConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_RackAndPinionConstraint *object);

/// Upcasts an instance of `JPH::RackAndPinionConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_RackAndPinionConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::RackAndPinionConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_RackAndPinionConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RackAndPinionConstraint_Destroy(const JPH_RackAndPinionConstraint *_this);

/// Destroys a heap-allocated array of `JPH_RackAndPinionConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RackAndPinionConstraint_DestroyArray(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_RackAndPinionConstraint_size_t(size_t inCount);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RackAndPinionConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RackAndPinionConstraint_size_t(size_t inCount);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RackAndPinionConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_RackAndPinionConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RackAndPinionConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RackAndPinionConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RackAndPinionConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RackAndPinionConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_NotifyShapeChanged(JPH_RackAndPinionConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::RackAndPinionConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetupVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::RackAndPinionConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_ResetWarmStart(JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_WarmStartVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::RackAndPinionConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RackAndPinionConstraint_SolveVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::RackAndPinionConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RackAndPinionConstraint_SolvePositionConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::RackAndPinionConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_DrawConstraint(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::RackAndPinionConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_RackAndPinionConstraint_GetConstraintToBody1Matrix(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_RackAndPinionConstraint_GetConstraintToBody2Matrix(const JPH_RackAndPinionConstraint *_this);

/// The constraints that constrain the rack and pinion (a slider and a hinge), optional and used to calculate the position error and fix numerical drift.
/// Generated from method `JPH::RackAndPinionConstraint::SetConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetConstraints(JPH_RackAndPinionConstraint *_this, const JPH_Constraint *inPinion, const JPH_Constraint *inRack);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::RackAndPinionConstraint::GetTotalLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_RackAndPinionConstraint_GetTotalLambda(const JPH_RackAndPinionConstraint *_this);

/// Solver interface
/// Generated from method `JPH::RackAndPinionConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RackAndPinionConstraint_IsActive(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_DrawConstraintReferenceFrame(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::RackAndPinionConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_RackAndPinionConstraint_GetBody1(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_RackAndPinionConstraint_GetBody2(const JPH_RackAndPinionConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::RackAndPinionConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RackAndPinionConstraint_GetConstraintPriority(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetConstraintPriority(JPH_RackAndPinionConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::RackAndPinionConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetNumVelocityStepsOverride(JPH_RackAndPinionConstraint *_this, unsigned int inN);

/// Generated from method `JPH::RackAndPinionConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RackAndPinionConstraint_GetNumVelocityStepsOverride(const JPH_RackAndPinionConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::RackAndPinionConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetNumPositionStepsOverride(JPH_RackAndPinionConstraint *_this, unsigned int inN);

/// Generated from method `JPH::RackAndPinionConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RackAndPinionConstraint_GetNumPositionStepsOverride(const JPH_RackAndPinionConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::RackAndPinionConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetEnabled(JPH_RackAndPinionConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::RackAndPinionConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RackAndPinionConstraint_GetEnabled(const JPH_RackAndPinionConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::RackAndPinionConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_RackAndPinionConstraint_GetUserData(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetUserData(JPH_RackAndPinionConstraint *_this, uint64_t inUserData);

/// Generated from method `JPH::RackAndPinionConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_DrawConstraintLimits(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::RackAndPinionConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_RackAndPinionConstraint_GetDrawConstraintSize(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetDrawConstraintSize(JPH_RackAndPinionConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RackAndPinionConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_SetEmbedded(const JPH_RackAndPinionConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RackAndPinionConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RackAndPinionConstraint_GetRefCount(const JPH_RackAndPinionConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RackAndPinionConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_AddRef(const JPH_RackAndPinionConstraint *_this);

/// Generated from method `JPH::RackAndPinionConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RackAndPinionConstraint_Release(const JPH_RackAndPinionConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RackAndPinionConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_RackAndPinionConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
