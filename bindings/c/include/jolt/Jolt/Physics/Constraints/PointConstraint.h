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


/// Point constraint settings, used to create a point constraint
/// Generated from class `JPH::PointConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PointConstraintSettings JPH_PointConstraintSettings;

/// A point constraint constrains 2 bodies on a single point (removing 3 degrees of freedom)
/// Generated from class `JPH::PointConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_PointConstraint JPH_PointConstraint;

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PointConstraintSettings_Get_mEnabled(const JPH_PointConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_PointConstraintSettings_Set_mEnabled(JPH_PointConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PointConstraintSettings_GetMutable_mEnabled(JPH_PointConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PointConstraintSettings_Get_mConstraintPriority(const JPH_PointConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_PointConstraintSettings_Set_mConstraintPriority(JPH_PointConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PointConstraintSettings_GetMutable_mConstraintPriority(JPH_PointConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_PointConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_PointConstraintSettings_Set_mNumVelocityStepsOverride(JPH_PointConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_PointConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PointConstraintSettings_Get_mNumPositionStepsOverride(const JPH_PointConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_PointConstraintSettings_Set_mNumPositionStepsOverride(JPH_PointConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_PointConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PointConstraintSettings_Get_mDrawConstraintSize(const JPH_PointConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_PointConstraintSettings_Set_mDrawConstraintSize(JPH_PointConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize(JPH_PointConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::PointConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_PointConstraintSettings_Get_mUserData(const JPH_PointConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::PointConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_PointConstraintSettings_Set_mUserData(JPH_PointConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::PointConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_PointConstraintSettings_GetMutable_mUserData(JPH_PointConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PointConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PointConstraintSettings_DestroyArray()`.
/// Use `JPH_PointConstraintSettings_OffsetMutablePtr()` and `JPH_PointConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PointConstraintSettings *JPH_PointConstraintSettings_OffsetPtr(const JPH_PointConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_OffsetMutablePtr(JPH_PointConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_PointConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PointConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PointConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_PointConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_PointConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_PointConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_PointConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_PointConstraintSettings *object);

/// Upcasts an instance of `JPH::PointConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_PointConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::PointConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PointConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PointConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_PointConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PointConstraintSettings_Destroy(const JPH_PointConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_PointConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PointConstraintSettings_DestroyArray(const JPH_PointConstraintSettings *_this);

/// Generated from method `JPH::PointConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PointConstraintSettings *JPH_PointConstraintSettings_AssignFromAnother(JPH_PointConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_PointConstraintSettings *_other);

/// Generated from method `JPH::PointConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PointConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PointConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PointConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PointConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PointConstraintSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PointConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PointConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PointConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::PointConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_PointConstraintSettings_Create(const JPH_PointConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PointConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraintSettings_SetEmbedded(const JPH_PointConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PointConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PointConstraintSettings_GetRefCount(const JPH_PointConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PointConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraintSettings_AddRef(const JPH_PointConstraintSettings *_this);

/// Generated from method `JPH::PointConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraintSettings_Release(const JPH_PointConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PointConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_PointConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct point constraint
/// Generated from constructor `JPH::PointConstraint::PointConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PointConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_PointConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PointConstraint *JPH_PointConstraint_OffsetPtr(const JPH_PointConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_OffsetMutablePtr(JPH_PointConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_PointConstraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_PointConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_PointConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_PointConstraint_UpcastTo_JPH_NonCopyable(const JPH_PointConstraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_PointConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_PointConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_PointConstraint_UpcastTo_JPH_Constraint(const JPH_PointConstraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_PointConstraint_MutableUpcastTo_JPH_Constraint(JPH_PointConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_PointConstraint *object);

/// Upcasts an instance of `JPH::PointConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_PointConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_PointConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::PointConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_PointConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_PointConstraint_Destroy(const JPH_PointConstraint *_this);

/// Destroys a heap-allocated array of `JPH_PointConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_PointConstraint_DestroyArray(const JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_PointConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PointConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::PointConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PointConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PointConstraint_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PointConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::PointConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PointConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PointConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PointConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PointConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PointConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetupVelocityConstraint(JPH_PointConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::PointConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_ResetWarmStart(JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_WarmStartVelocityConstraint(JPH_PointConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::PointConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PointConstraint_SolveVelocityConstraint(JPH_PointConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::PointConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PointConstraint_SolvePositionConstraint(JPH_PointConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Solver interface
/// Generated from method `JPH::PointConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PointConstraint_IsActive(const JPH_PointConstraint *_this);

/// Access to the connected bodies
/// Generated from method `JPH::PointConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_PointConstraint_GetBody1(const JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_PointConstraint_GetBody2(const JPH_PointConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::PointConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PointConstraint_GetConstraintPriority(const JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetConstraintPriority(JPH_PointConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::PointConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetNumVelocityStepsOverride(JPH_PointConstraint *_this, unsigned int inN);

/// Generated from method `JPH::PointConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PointConstraint_GetNumVelocityStepsOverride(const JPH_PointConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::PointConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetNumPositionStepsOverride(JPH_PointConstraint *_this, unsigned int inN);

/// Generated from method `JPH::PointConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PointConstraint_GetNumPositionStepsOverride(const JPH_PointConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::PointConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetEnabled(JPH_PointConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::PointConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PointConstraint_GetEnabled(const JPH_PointConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::PointConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_PointConstraint_GetUserData(const JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetUserData(JPH_PointConstraint *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PointConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_SetEmbedded(const JPH_PointConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PointConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PointConstraint_GetRefCount(const JPH_PointConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PointConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_AddRef(const JPH_PointConstraint *_this);

/// Generated from method `JPH::PointConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PointConstraint_Release(const JPH_PointConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PointConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_PointConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
