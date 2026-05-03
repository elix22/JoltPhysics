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


/// Gear constraint settings
/// Generated from class `JPH::GearConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_GearConstraintSettings JPH_GearConstraintSettings;

/// A gear constraint constrains the rotation of body1 to the rotation of body 2 using a gear.
/// Note that this constraint needs to be used in conjunction with a two hinge constraints.
/// Generated from class `JPH::GearConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_GearConstraint JPH_GearConstraint;

/// Body 1 constraint reference frame (space determined by mSpace).
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mHingeAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_GearConstraintSettings_Get_mHingeAxis1(const JPH_GearConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace).
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mHingeAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_GearConstraintSettings_GetMutable_mHingeAxis1(JPH_GearConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mHingeAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_GearConstraintSettings_Get_mHingeAxis2(const JPH_GearConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mHingeAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_GearConstraintSettings_GetMutable_mHingeAxis2(JPH_GearConstraintSettings *_this);

/// Ratio between both gears, see SetRatio.
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_GearConstraintSettings_Get_mRatio(const JPH_GearConstraintSettings *_this);

/// Ratio between both gears, see SetRatio.
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRatio`.
JOLT_API void JPH_GearConstraintSettings_Set_mRatio(JPH_GearConstraintSettings *_this, float value);

/// Ratio between both gears, see SetRatio.
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_GearConstraintSettings_GetMutable_mRatio(JPH_GearConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_GearConstraintSettings_Get_mEnabled(const JPH_GearConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_GearConstraintSettings_Set_mEnabled(JPH_GearConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_GearConstraintSettings_GetMutable_mEnabled(JPH_GearConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_GearConstraintSettings_Get_mConstraintPriority(const JPH_GearConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_GearConstraintSettings_Set_mConstraintPriority(JPH_GearConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_GearConstraintSettings_GetMutable_mConstraintPriority(JPH_GearConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_GearConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_GearConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_GearConstraintSettings_Set_mNumVelocityStepsOverride(JPH_GearConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_GearConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_GearConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_GearConstraintSettings_Get_mNumPositionStepsOverride(const JPH_GearConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_GearConstraintSettings_Set_mNumPositionStepsOverride(JPH_GearConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_GearConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_GearConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_GearConstraintSettings_Get_mDrawConstraintSize(const JPH_GearConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_GearConstraintSettings_Set_mDrawConstraintSize(JPH_GearConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_GearConstraintSettings_GetMutable_mDrawConstraintSize(JPH_GearConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::GearConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_GearConstraintSettings_Get_mUserData(const JPH_GearConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::GearConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_GearConstraintSettings_Set_mUserData(JPH_GearConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::GearConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_GearConstraintSettings_GetMutable_mUserData(JPH_GearConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_GearConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_GearConstraintSettings_DestroyArray()`.
/// Use `JPH_GearConstraintSettings_OffsetMutablePtr()` and `JPH_GearConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_GearConstraintSettings *JPH_GearConstraintSettings_OffsetPtr(const JPH_GearConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_OffsetMutablePtr(JPH_GearConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_GearConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_GearConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_GearConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_GearConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_GearConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_GearConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_GearConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_GearConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_GearConstraintSettings *object);

/// Upcasts an instance of `JPH::GearConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_GearConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::GearConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::GearConstraintSettings::GearConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_GearConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_GearConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_GearConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_GearConstraintSettings_Destroy(const JPH_GearConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_GearConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_GearConstraintSettings_DestroyArray(const JPH_GearConstraintSettings *_this);

/// Generated from method `JPH::GearConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_GearConstraintSettings *JPH_GearConstraintSettings_AssignFromAnother(JPH_GearConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_GearConstraintSettings *_other);

/// Generated from method `JPH::GearConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_GearConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::GearConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::GearConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GearConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GearConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::GearConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::GearConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GearConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_GearConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GearConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::GearConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GearConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GearConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint.
/// Generated from method `JPH::GearConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_GearConstraintSettings_Create(const JPH_GearConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Defines the ratio between the rotation of both gears
/// The ratio is defined as: Gear1Rotation(t) = -ratio * Gear2Rotation(t)
/// @param inNumTeethGear1 Number of teeth that body 1 has
/// @param inNumTeethGear2 Number of teeth that body 2 has
/// Generated from method `JPH::GearConstraintSettings::SetRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraintSettings_SetRatio(JPH_GearConstraintSettings *_this, int inNumTeethGear1, int inNumTeethGear2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::GearConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraintSettings_SetEmbedded(const JPH_GearConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::GearConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GearConstraintSettings_GetRefCount(const JPH_GearConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::GearConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraintSettings_AddRef(const JPH_GearConstraintSettings *_this);

/// Generated from method `JPH::GearConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraintSettings_Release(const JPH_GearConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::GearConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_GearConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct gear constraint
/// Generated from constructor `JPH::GearConstraint::GearConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_GearConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_GearConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_GearConstraint *JPH_GearConstraint_OffsetPtr(const JPH_GearConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_OffsetMutablePtr(JPH_GearConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_GearConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_GearConstraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_GearConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_GearConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_GearConstraint_UpcastTo_JPH_NonCopyable(const JPH_GearConstraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_GearConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_GearConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_GearConstraint_UpcastTo_JPH_Constraint(const JPH_GearConstraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_GearConstraint_MutableUpcastTo_JPH_Constraint(JPH_GearConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_GearConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_GearConstraint *object);

/// Upcasts an instance of `JPH::GearConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_GearConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_GearConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::GearConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_GearConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_GearConstraint_Destroy(const JPH_GearConstraint *_this);

/// Destroys a heap-allocated array of `JPH_GearConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_GearConstraint_DestroyArray(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_GearConstraint_size_t(size_t inCount);

/// Generated from method `JPH::GearConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::GearConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GearConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GearConstraint_size_t(size_t inCount);

/// Generated from method `JPH::GearConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::GearConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GearConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_GearConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GearConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_GearConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::GearConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GearConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GearConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GearConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::GearConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_NotifyShapeChanged(JPH_GearConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::GearConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetupVelocityConstraint(JPH_GearConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::GearConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_ResetWarmStart(JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_WarmStartVelocityConstraint(JPH_GearConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::GearConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_GearConstraint_SolveVelocityConstraint(JPH_GearConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::GearConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_GearConstraint_SolvePositionConstraint(JPH_GearConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::GearConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_DrawConstraint(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::GearConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_GearConstraint_GetConstraintToBody1Matrix(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_GearConstraint_GetConstraintToBody2Matrix(const JPH_GearConstraint *_this);

/// The constraints that constrain both gears (2 hinges), optional and used to calculate the rotation error and fix numerical drift.
/// Generated from method `JPH::GearConstraint::SetConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetConstraints(JPH_GearConstraint *_this, const JPH_Constraint *inGear1, const JPH_Constraint *inGear2);

///@name Get Lagrange multiplier from last physics update (the angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::GearConstraint::GetTotalLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_GearConstraint_GetTotalLambda(const JPH_GearConstraint *_this);

/// Solver interface
/// Generated from method `JPH::GearConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_GearConstraint_IsActive(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_DrawConstraintReferenceFrame(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::GearConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_GearConstraint_GetBody1(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_GearConstraint_GetBody2(const JPH_GearConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::GearConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GearConstraint_GetConstraintPriority(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetConstraintPriority(JPH_GearConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::GearConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetNumVelocityStepsOverride(JPH_GearConstraint *_this, unsigned int inN);

/// Generated from method `JPH::GearConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GearConstraint_GetNumVelocityStepsOverride(const JPH_GearConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::GearConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetNumPositionStepsOverride(JPH_GearConstraint *_this, unsigned int inN);

/// Generated from method `JPH::GearConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GearConstraint_GetNumPositionStepsOverride(const JPH_GearConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::GearConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetEnabled(JPH_GearConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::GearConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_GearConstraint_GetEnabled(const JPH_GearConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::GearConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_GearConstraint_GetUserData(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetUserData(JPH_GearConstraint *_this, uint64_t inUserData);

/// Generated from method `JPH::GearConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_DrawConstraintLimits(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::GearConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_GearConstraint_GetDrawConstraintSize(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetDrawConstraintSize(JPH_GearConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::GearConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_SetEmbedded(const JPH_GearConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::GearConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GearConstraint_GetRefCount(const JPH_GearConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::GearConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_AddRef(const JPH_GearConstraint *_this);

/// Generated from method `JPH::GearConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GearConstraint_Release(const JPH_GearConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::GearConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_GearConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
