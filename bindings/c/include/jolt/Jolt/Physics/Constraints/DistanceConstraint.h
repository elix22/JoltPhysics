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
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.


/// Distance constraint settings, used to create a distance constraint
/// Generated from class `JPH::DistanceConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DistanceConstraintSettings JPH_DistanceConstraintSettings;

/// This constraint is a stiff spring that holds 2 points at a fixed distance from each other
/// Generated from class `JPH::DistanceConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_DistanceConstraint JPH_DistanceConstraint;

/// Ability to override the distance range at which the two points are kept apart. If the value is negative, it will be replaced by the distance between mPoint1 and mPoint2 (works only if mSpace is world space).
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mMinDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_DistanceConstraintSettings_Get_mMinDistance(const JPH_DistanceConstraintSettings *_this);

/// Ability to override the distance range at which the two points are kept apart. If the value is negative, it will be replaced by the distance between mPoint1 and mPoint2 (works only if mSpace is world space).
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mMinDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinDistance`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mMinDistance(JPH_DistanceConstraintSettings *_this, float value);

/// Ability to override the distance range at which the two points are kept apart. If the value is negative, it will be replaced by the distance between mPoint1 and mPoint2 (works only if mSpace is world space).
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mMinDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_DistanceConstraintSettings_GetMutable_mMinDistance(JPH_DistanceConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_DistanceConstraintSettings_Get_mMaxDistance(const JPH_DistanceConstraintSettings *_this);

/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxDistance`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mMaxDistance(JPH_DistanceConstraintSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_DistanceConstraintSettings_GetMutable_mMaxDistance(JPH_DistanceConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_DistanceConstraintSettings_Get_mEnabled(const JPH_DistanceConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mEnabled(JPH_DistanceConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_DistanceConstraintSettings_GetMutable_mEnabled(JPH_DistanceConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_DistanceConstraintSettings_Get_mConstraintPriority(const JPH_DistanceConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mConstraintPriority(JPH_DistanceConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority(JPH_DistanceConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_DistanceConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mNumVelocityStepsOverride(JPH_DistanceConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_DistanceConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride(const JPH_DistanceConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mNumPositionStepsOverride(JPH_DistanceConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_DistanceConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_DistanceConstraintSettings_Get_mDrawConstraintSize(const JPH_DistanceConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mDrawConstraintSize(JPH_DistanceConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize(JPH_DistanceConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_DistanceConstraintSettings_Get_mUserData(const JPH_DistanceConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::DistanceConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_DistanceConstraintSettings_Set_mUserData(JPH_DistanceConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::DistanceConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_DistanceConstraintSettings_GetMutable_mUserData(JPH_DistanceConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DistanceConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DistanceConstraintSettings_DestroyArray()`.
/// Use `JPH_DistanceConstraintSettings_OffsetMutablePtr()` and `JPH_DistanceConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_OffsetPtr(const JPH_DistanceConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_OffsetMutablePtr(JPH_DistanceConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_DistanceConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_DistanceConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_DistanceConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_DistanceConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_DistanceConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_DistanceConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_DistanceConstraintSettings *object);

/// Upcasts an instance of `JPH::DistanceConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_DistanceConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::DistanceConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DistanceConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DistanceConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_DistanceConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_DistanceConstraintSettings_Destroy(const JPH_DistanceConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_DistanceConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_DistanceConstraintSettings_DestroyArray(const JPH_DistanceConstraintSettings *_this);

/// Generated from method `JPH::DistanceConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_AssignFromAnother(JPH_DistanceConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_DistanceConstraintSettings *_other);

/// Generated from method `JPH::DistanceConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_DistanceConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DistanceConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DistanceConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DistanceConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_DistanceConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DistanceConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DistanceConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::DistanceConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_DistanceConstraintSettings_Create(const JPH_DistanceConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::DistanceConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraintSettings_SetEmbedded(const JPH_DistanceConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::DistanceConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DistanceConstraintSettings_GetRefCount(const JPH_DistanceConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::DistanceConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraintSettings_AddRef(const JPH_DistanceConstraintSettings *_this);

/// Generated from method `JPH::DistanceConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraintSettings_Release(const JPH_DistanceConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::DistanceConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_DistanceConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct distance constraint
/// Generated from constructor `JPH::DistanceConstraint::DistanceConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DistanceConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_DistanceConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraint *JPH_DistanceConstraint_OffsetPtr(const JPH_DistanceConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_OffsetMutablePtr(JPH_DistanceConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_DistanceConstraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_DistanceConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(const JPH_DistanceConstraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DistanceConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_DistanceConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_DistanceConstraint_UpcastTo_JPH_Constraint(const JPH_DistanceConstraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_Constraint(JPH_DistanceConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_DistanceConstraint *object);

/// Upcasts an instance of `JPH::DistanceConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_DistanceConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::DistanceConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_DistanceConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_DistanceConstraint_Destroy(const JPH_DistanceConstraint *_this);

/// Destroys a heap-allocated array of `JPH_DistanceConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_DistanceConstraint_DestroyArray(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_DistanceConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::DistanceConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::DistanceConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DistanceConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DistanceConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::DistanceConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::DistanceConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DistanceConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_DistanceConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DistanceConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DistanceConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DistanceConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DistanceConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DistanceConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetupVelocityConstraint(JPH_DistanceConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::DistanceConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_ResetWarmStart(JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_WarmStartVelocityConstraint(JPH_DistanceConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::DistanceConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DistanceConstraint_SolveVelocityConstraint(JPH_DistanceConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::DistanceConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DistanceConstraint_SolvePositionConstraint(JPH_DistanceConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Update the minimum and maximum distance for the constraint
/// Generated from method `JPH::DistanceConstraint::SetDistance`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetDistance(JPH_DistanceConstraint *_this, float inMinDistance, float inMaxDistance);

/// Generated from method `JPH::DistanceConstraint::GetMinDistance`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_DistanceConstraint_GetMinDistance(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::GetMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_DistanceConstraint_GetMaxDistance(const JPH_DistanceConstraint *_this);

///@name Get Lagrange multiplier from last physics update (the linear impulse applied to satisfy the constraint)
/// Generated from method `JPH::DistanceConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_DistanceConstraint_GetTotalLambdaPosition(const JPH_DistanceConstraint *_this);

/// Solver interface
/// Generated from method `JPH::DistanceConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DistanceConstraint_IsActive(const JPH_DistanceConstraint *_this);

/// Access to the connected bodies
/// Generated from method `JPH::DistanceConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_DistanceConstraint_GetBody1(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_DistanceConstraint_GetBody2(const JPH_DistanceConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::DistanceConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DistanceConstraint_GetConstraintPriority(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetConstraintPriority(JPH_DistanceConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::DistanceConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetNumVelocityStepsOverride(JPH_DistanceConstraint *_this, unsigned int inN);

/// Generated from method `JPH::DistanceConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DistanceConstraint_GetNumVelocityStepsOverride(const JPH_DistanceConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::DistanceConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetNumPositionStepsOverride(JPH_DistanceConstraint *_this, unsigned int inN);

/// Generated from method `JPH::DistanceConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DistanceConstraint_GetNumPositionStepsOverride(const JPH_DistanceConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::DistanceConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetEnabled(JPH_DistanceConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::DistanceConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DistanceConstraint_GetEnabled(const JPH_DistanceConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::DistanceConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_DistanceConstraint_GetUserData(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetUserData(JPH_DistanceConstraint *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::DistanceConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_SetEmbedded(const JPH_DistanceConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::DistanceConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DistanceConstraint_GetRefCount(const JPH_DistanceConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::DistanceConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_AddRef(const JPH_DistanceConstraint *_this);

/// Generated from method `JPH::DistanceConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DistanceConstraint_Release(const JPH_DistanceConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::DistanceConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_DistanceConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
