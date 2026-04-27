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


/// Fixed constraint settings, used to create a fixed constraint
/// Generated from class `JPH::FixedConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_FixedConstraintSettings JPH_FixedConstraintSettings;

/// A fixed constraint welds two bodies together removing all degrees of freedom between them.
/// This variant uses Euler angles for the rotation constraint.
/// Generated from class `JPH::FixedConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_FixedConstraint JPH_FixedConstraint;

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (they will be fixated in their current relative position/orientation). Set this to false if you want to supply the attachment points yourself.
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_FixedConstraintSettings_Get_mAutoDetectPoint(const JPH_FixedConstraintSettings *_this);

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (they will be fixated in their current relative position/orientation). Set this to false if you want to supply the attachment points yourself.
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAutoDetectPoint`.
JOLT_API void JPH_FixedConstraintSettings_Set_mAutoDetectPoint(JPH_FixedConstraintSettings *_this, bool value);

/// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (they will be fixated in their current relative position/orientation). Set this to false if you want to supply the attachment points yourself.
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mAutoDetectPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint(JPH_FixedConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_FixedConstraintSettings_Get_mEnabled(const JPH_FixedConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_FixedConstraintSettings_Set_mEnabled(JPH_FixedConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_FixedConstraintSettings_GetMutable_mEnabled(JPH_FixedConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_FixedConstraintSettings_Get_mConstraintPriority(const JPH_FixedConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_FixedConstraintSettings_Set_mConstraintPriority(JPH_FixedConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_FixedConstraintSettings_GetMutable_mConstraintPriority(JPH_FixedConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_FixedConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_FixedConstraintSettings_Set_mNumVelocityStepsOverride(JPH_FixedConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_FixedConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride(const JPH_FixedConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_FixedConstraintSettings_Set_mNumPositionStepsOverride(JPH_FixedConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_FixedConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_FixedConstraintSettings_Get_mDrawConstraintSize(const JPH_FixedConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_FixedConstraintSettings_Set_mDrawConstraintSize(JPH_FixedConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize(JPH_FixedConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::FixedConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_FixedConstraintSettings_Get_mUserData(const JPH_FixedConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::FixedConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_FixedConstraintSettings_Set_mUserData(JPH_FixedConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::FixedConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_FixedConstraintSettings_GetMutable_mUserData(JPH_FixedConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_FixedConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_FixedConstraintSettings_DestroyArray()`.
/// Use `JPH_FixedConstraintSettings_OffsetMutablePtr()` and `JPH_FixedConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_OffsetPtr(const JPH_FixedConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_OffsetMutablePtr(JPH_FixedConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_FixedConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_FixedConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_FixedConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_FixedConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_FixedConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_FixedConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_FixedConstraintSettings *object);

/// Upcasts an instance of `JPH::FixedConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_FixedConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::FixedConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_FixedConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_FixedConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_FixedConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_FixedConstraintSettings_Destroy(const JPH_FixedConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_FixedConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_FixedConstraintSettings_DestroyArray(const JPH_FixedConstraintSettings *_this);

/// Generated from method `JPH::FixedConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_AssignFromAnother(JPH_FixedConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_FixedConstraintSettings *_other);

/// Generated from method `JPH::FixedConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_FixedConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::FixedConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::FixedConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::FixedConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::FixedConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_FixedConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::FixedConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::FixedConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::FixedConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_FixedConstraintSettings_Create(const JPH_FixedConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::FixedConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraintSettings_SetEmbedded(const JPH_FixedConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::FixedConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_FixedConstraintSettings_GetRefCount(const JPH_FixedConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::FixedConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraintSettings_AddRef(const JPH_FixedConstraintSettings *_this);

/// Generated from method `JPH::FixedConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraintSettings_Release(const JPH_FixedConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::FixedConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_FixedConstraintSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// Generated from constructor `JPH::FixedConstraint::FixedConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_FixedConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_FixedConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_FixedConstraint *JPH_FixedConstraint_OffsetPtr(const JPH_FixedConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_OffsetMutablePtr(JPH_FixedConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_FixedConstraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_FixedConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_FixedConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(const JPH_FixedConstraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_FixedConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_FixedConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_FixedConstraint_UpcastTo_JPH_Constraint(const JPH_FixedConstraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_FixedConstraint_MutableUpcastTo_JPH_Constraint(JPH_FixedConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_FixedConstraint *object);

/// Upcasts an instance of `JPH::FixedConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_FixedConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_FixedConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::FixedConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_FixedConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_FixedConstraint_Destroy(const JPH_FixedConstraint *_this);

/// Destroys a heap-allocated array of `JPH_FixedConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_FixedConstraint_DestroyArray(const JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_FixedConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::FixedConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::FixedConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::FixedConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_FixedConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::FixedConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::FixedConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::FixedConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_FixedConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::FixedConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::FixedConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_FixedConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::FixedConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::FixedConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetupVelocityConstraint(JPH_FixedConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::FixedConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_ResetWarmStart(JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_WarmStartVelocityConstraint(JPH_FixedConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::FixedConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_FixedConstraint_SolveVelocityConstraint(JPH_FixedConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::FixedConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_FixedConstraint_SolvePositionConstraint(JPH_FixedConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Solver interface
/// Generated from method `JPH::FixedConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_FixedConstraint_IsActive(const JPH_FixedConstraint *_this);

/// Access to the connected bodies
/// Generated from method `JPH::FixedConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_FixedConstraint_GetBody1(const JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_FixedConstraint_GetBody2(const JPH_FixedConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::FixedConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_FixedConstraint_GetConstraintPriority(const JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetConstraintPriority(JPH_FixedConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::FixedConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetNumVelocityStepsOverride(JPH_FixedConstraint *_this, unsigned int inN);

/// Generated from method `JPH::FixedConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_FixedConstraint_GetNumVelocityStepsOverride(const JPH_FixedConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::FixedConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetNumPositionStepsOverride(JPH_FixedConstraint *_this, unsigned int inN);

/// Generated from method `JPH::FixedConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_FixedConstraint_GetNumPositionStepsOverride(const JPH_FixedConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::FixedConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetEnabled(JPH_FixedConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::FixedConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_FixedConstraint_GetEnabled(const JPH_FixedConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::FixedConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_FixedConstraint_GetUserData(const JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetUserData(JPH_FixedConstraint *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::FixedConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_SetEmbedded(const JPH_FixedConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::FixedConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_FixedConstraint_GetRefCount(const JPH_FixedConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::FixedConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_AddRef(const JPH_FixedConstraint *_this);

/// Generated from method `JPH::FixedConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_FixedConstraint_Release(const JPH_FixedConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::FixedConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_FixedConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
