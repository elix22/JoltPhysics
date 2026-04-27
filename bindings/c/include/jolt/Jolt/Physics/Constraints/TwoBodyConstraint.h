// machine generated, do not edit
#pragma once

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


/// Base class for settings for all constraints that involve 2 bodies
/// Generated from class `JPH::TwoBodyConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DistanceConstraintSettings`
///     `JPH::FixedConstraintSettings`
///     `JPH::HingeConstraintSettings`
///     `JPH::PointConstraintSettings`
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings;

/// Base class for all constraints that involve 2 bodies. Body1 is usually considered the parent, Body2 the child.
/// Generated from class `JPH::TwoBodyConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Constraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DistanceConstraint`
///     `JPH::FixedConstraint`
///     `JPH::HingeConstraint`
///     `JPH::PointConstraint`
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint;

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_TwoBodyConstraintSettings_Get_mEnabled(const JPH_TwoBodyConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mEnabled(JPH_TwoBodyConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_TwoBodyConstraintSettings_GetMutable_mEnabled(JPH_TwoBodyConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_TwoBodyConstraintSettings_Get_mConstraintPriority(const JPH_TwoBodyConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mConstraintPriority(JPH_TwoBodyConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mConstraintPriority(JPH_TwoBodyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_TwoBodyConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_TwoBodyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mNumVelocityStepsOverride(JPH_TwoBodyConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_TwoBodyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_TwoBodyConstraintSettings_Get_mNumPositionStepsOverride(const JPH_TwoBodyConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mNumPositionStepsOverride(JPH_TwoBodyConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_TwoBodyConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TwoBodyConstraintSettings_Get_mDrawConstraintSize(const JPH_TwoBodyConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mDrawConstraintSize(JPH_TwoBodyConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TwoBodyConstraintSettings_GetMutable_mDrawConstraintSize(JPH_TwoBodyConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_TwoBodyConstraintSettings_Get_mUserData(const JPH_TwoBodyConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::TwoBodyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_TwoBodyConstraintSettings_Set_mUserData(JPH_TwoBodyConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::TwoBodyConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_TwoBodyConstraintSettings_GetMutable_mUserData(JPH_TwoBodyConstraintSettings *_this);

/// Destroys a heap-allocated instance of `JPH_TwoBodyConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TwoBodyConstraintSettings_Destroy(const JPH_TwoBodyConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_TwoBodyConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TwoBodyConstraintSettings_DestroyArray(const JPH_TwoBodyConstraintSettings *_this);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TwoBodyConstraintSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TwoBodyConstraintSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TwoBodyConstraintSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TwoBodyConstraintSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TwoBodyConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// You can use Body::sFixedToWorld for inBody1 if you want to attach inBody2 to the world
/// Generated from method `JPH::TwoBodyConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_TwoBodyConstraintSettings_Create(const JPH_TwoBodyConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TwoBodyConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraintSettings_SetEmbedded(const JPH_TwoBodyConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TwoBodyConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TwoBodyConstraintSettings_GetRefCount(const JPH_TwoBodyConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TwoBodyConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraintSettings_AddRef(const JPH_TwoBodyConstraintSettings *_this);

/// Generated from method `JPH::TwoBodyConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraintSettings_Release(const JPH_TwoBodyConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TwoBodyConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_TwoBodyConstraintSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_OffsetPtr(const JPH_TwoBodyConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_OffsetMutablePtr(JPH_TwoBodyConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_TwoBodyConstraintSettings *object);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Upcasts an instance of `JPH::TwoBodyConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::TwoBodyConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Destroys a heap-allocated instance of `JPH_TwoBodyConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_TwoBodyConstraint_Destroy(const JPH_TwoBodyConstraint *_this);

/// Destroys a heap-allocated array of `JPH_TwoBodyConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_TwoBodyConstraint_DestroyArray(const JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_TwoBodyConstraint_size_t(unsigned long inCount);

/// Generated from method `JPH::TwoBodyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::TwoBodyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraint_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TwoBodyConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TwoBodyConstraint_size_t(unsigned long inCount);

/// Generated from method `JPH::TwoBodyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::TwoBodyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TwoBodyConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_TwoBodyConstraint_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TwoBodyConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_TwoBodyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TwoBodyConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TwoBodyConstraint_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TwoBodyConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Solver interface
/// Generated from method `JPH::TwoBodyConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TwoBodyConstraint_IsActive(const JPH_TwoBodyConstraint *_this);

/// Access to the connected bodies
/// Generated from method `JPH::TwoBodyConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_TwoBodyConstraint_GetBody1(const JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_TwoBodyConstraint_GetBody2(const JPH_TwoBodyConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::TwoBodyConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TwoBodyConstraint_GetConstraintPriority(const JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetConstraintPriority(JPH_TwoBodyConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::TwoBodyConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetNumVelocityStepsOverride(JPH_TwoBodyConstraint *_this, unsigned int inN);

/// Generated from method `JPH::TwoBodyConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TwoBodyConstraint_GetNumVelocityStepsOverride(const JPH_TwoBodyConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::TwoBodyConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetNumPositionStepsOverride(JPH_TwoBodyConstraint *_this, unsigned int inN);

/// Generated from method `JPH::TwoBodyConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TwoBodyConstraint_GetNumPositionStepsOverride(const JPH_TwoBodyConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::TwoBodyConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetEnabled(JPH_TwoBodyConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::TwoBodyConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TwoBodyConstraint_GetEnabled(const JPH_TwoBodyConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::TwoBodyConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_TwoBodyConstraint_GetUserData(const JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetUserData(JPH_TwoBodyConstraint *_this, uint64_t inUserData);

/// Notify the system that the configuration of the bodies and/or constraint has changed enough so that the warm start impulses should not be applied the next frame.
/// You can use this function for example when repositioning a ragdoll through Ragdoll::SetPose in such a way that the orientation of the bodies completely changes so that
/// the previous frame impulses are no longer a good approximation of what the impulses will be in the next frame. Calling this function when there are no big changes
/// will result in the constraints being much 'softer' than usual so they are more easily violated (e.g. a long chain of bodies might sag a bit if you call this every frame).
/// Generated from method `JPH::TwoBodyConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_ResetWarmStart(JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetupVelocityConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::TwoBodyConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_WarmStartVelocityConstraint(JPH_TwoBodyConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::TwoBodyConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TwoBodyConstraint_SolveVelocityConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::TwoBodyConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TwoBodyConstraint_SolvePositionConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TwoBodyConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_SetEmbedded(const JPH_TwoBodyConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TwoBodyConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TwoBodyConstraint_GetRefCount(const JPH_TwoBodyConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TwoBodyConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_AddRef(const JPH_TwoBodyConstraint *_this);

/// Generated from method `JPH::TwoBodyConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TwoBodyConstraint_Release(const JPH_TwoBodyConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TwoBodyConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_TwoBodyConstraint_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_OffsetPtr(const JPH_TwoBodyConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_OffsetMutablePtr(JPH_TwoBodyConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_TwoBodyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_TwoBodyConstraint *object);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TwoBodyConstraint_UpcastTo_JPH_NonCopyable(const JPH_TwoBodyConstraint *object);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_TwoBodyConstraint_UpcastTo_JPH_Constraint(const JPH_TwoBodyConstraint *object);

/// Upcasts an instance of `JPH::TwoBodyConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_Constraint(JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::TwoBodyConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

#ifdef __cplusplus
} // extern "C"
#endif
