// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Body/MotionQuality.h>
#include <jolt/Jolt/Physics/Body/MotionType.h>
#include <jolt/Jolt/Physics/EActivation.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_BodyCreationSettings JPH_BodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/Body/BodyCreationSettings.h>`.
typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_Ragdoll JPH_RefTarget_JPH_Ragdoll; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_RagdollSettings JPH_RefTarget_JPH_RagdollSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Skeleton JPH_Skeleton; // Defined in `#include <jolt/Jolt/Skeleton/Skeleton.h>`.
typedef struct JPH_SkeletonPose JPH_SkeletonPose; // Defined in `#include <jolt/Jolt/Skeleton/SkeletonPose.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_BodyID Jolt_JPH_Array_JPH_BodyID; // Defined in `#include <JPH_Array_JPH_BodyID.h>`.
typedef struct Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint; // Defined in `#include <JPH_Array_JPH_RagdollSettings_AdditionalConstraint.h>`.
typedef struct Jolt_JPH_Array_JPH_RagdollSettings_Part Jolt_JPH_Array_JPH_RagdollSettings_Part; // Defined in `#include <JPH_Array_JPH_RagdollSettings_Part.h>`.
typedef struct Jolt_JPH_Array_int Jolt_JPH_Array_int; // Defined in `#include <JPH_Array_int.h>`.
typedef struct Jolt_JPH_Array_std_pair_int_int Jolt_JPH_Array_std_pair_int_int; // Defined in `#include <JPH_Array_std_pair_int_int.h>`.
typedef struct Jolt_std_pair_int_int Jolt_std_pair_int_int; // Defined in `#include <std_pair_int_int.h>`.


/// A single rigid body sub part of the ragdoll
/// Generated from class `JPH::RagdollSettings::Part`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BodyCreationSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RagdollSettings_Part JPH_RagdollSettings_Part;

/// A constraint that connects two bodies in a ragdoll (for non parent child related constraints)
/// Generated from class `JPH::RagdollSettings::AdditionalConstraint`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RagdollSettings_AdditionalConstraint JPH_RagdollSettings_AdditionalConstraint;

/// Contains the structure of a ragdoll
/// Generated from class `JPH::RagdollSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::RagdollSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RagdollSettings JPH_RagdollSettings;

/// Runtime ragdoll information
/// Generated from class `JPH::Ragdoll`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::Ragdoll>`
///     `JPH::NonCopyable`
typedef struct JPH_Ragdoll JPH_Ragdoll;

/// For each of the joints, the body and constraint attaching it to its parent body (1-on-1 with mSkeleton.GetJoints())
/// Returns a pointer to a member variable of class `JPH::RagdollSettings` named `mParts`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_JPH_RagdollSettings_Part *JPH_RagdollSettings_Get_mParts(const JPH_RagdollSettings *_this);

/// For each of the joints, the body and constraint attaching it to its parent body (1-on-1 with mSkeleton.GetJoints())
/// Modifies a member variable of class `JPH::RagdollSettings` named `mParts`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mParts`.
/// When this function is called, this object will drop object references it held previously in `mParts`.
JOLT_API void JPH_RagdollSettings_Set_mParts(JPH_RagdollSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_Part *value);

/// For each of the joints, the body and constraint attaching it to its parent body (1-on-1 with mSkeleton.GetJoints())
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings` named `mParts`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_JPH_RagdollSettings_Part *JPH_RagdollSettings_GetMutable_mParts(JPH_RagdollSettings *_this);

/// A list of constraints that connects two bodies in a ragdoll (for non parent child related constraints)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings` named `mAdditionalConstraints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_Get_mAdditionalConstraints(const JPH_RagdollSettings *_this);

/// A list of constraints that connects two bodies in a ragdoll (for non parent child related constraints)
/// Modifies a member variable of class `JPH::RagdollSettings` named `mAdditionalConstraints`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mAdditionalConstraints`.
/// When this function is called, this object will drop object references it held previously in `mAdditionalConstraints`.
JOLT_API void JPH_RagdollSettings_Set_mAdditionalConstraints(JPH_RagdollSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *value);

/// A list of constraints that connects two bodies in a ragdoll (for non parent child related constraints)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings` named `mAdditionalConstraints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_GetMutable_mAdditionalConstraints(JPH_RagdollSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RagdollSettings_DestroyArray()`.
/// Use `JPH_RagdollSettings_OffsetMutablePtr()` and `JPH_RagdollSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RagdollSettings *JPH_RagdollSettings_OffsetPtr(const JPH_RagdollSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_OffsetMutablePtr(JPH_RagdollSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RagdollSettings` to its base class `JPH::RefTarget<JPH::RagdollSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_RagdollSettings *JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(const JPH_RagdollSettings *object);

/// Upcasts an instance of `JPH::RagdollSettings` to its base class `JPH::RefTarget<JPH::RagdollSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RagdollSettings_MutableUpcastTo_JPH_RefTarget_JPH_RagdollSettings(JPH_RagdollSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::RagdollSettings>` to a derived class `JPH::RagdollSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RagdollSettings *JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(const JPH_RefTarget_JPH_RagdollSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::RagdollSettings>` to a derived class `JPH::RagdollSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(JPH_RefTarget_JPH_RagdollSettings *object);

/// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RagdollSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_Destroy(const JPH_RagdollSettings *_this);

/// Destroys a heap-allocated array of `JPH_RagdollSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_DestroyArray(const JPH_RagdollSettings *_this);

/// Generated from method `JPH::RagdollSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RagdollSettings *JPH_RagdollSettings_AssignFromAnother(JPH_RagdollSettings *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings *_other);

/// Generated from method `JPH::RagdollSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RagdollSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Stabilize the constraints of the ragdoll
/// @return True on success, false on failure.
/// Generated from method `JPH::RagdollSettings::Stabilize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RagdollSettings_Stabilize(JPH_RagdollSettings *_this);

/// Initializes the constraint priorities so that constraints near the leaves of the ragdoll have a lower priority
/// than constraints near the root of the ragdoll.
/// @param inBasePriority The lowest priority that will be used in the ragdoll.
/// Generated from method `JPH::RagdollSettings::CalculateConstraintPriorities`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBasePriority` has a default argument: `0`, pass a null pointer to use it.
JOLT_API void JPH_RagdollSettings_CalculateConstraintPriorities(JPH_RagdollSettings *_this, const unsigned int *inBasePriority);

/// After the ragdoll has been fully configured, call this function to automatically create and add a GroupFilterTable collision filter to all bodies
/// and configure them so that parent and children don't collide.
///
/// This will:
/// - Create a GroupFilterTable and assign it to all of the bodies in a ragdoll.
/// - Each body in your ragdoll will get a SubGroupID that is equal to the joint index in the Skeleton that it is attached to.
/// - Loop over all joints in the Skeleton and call GroupFilterTable::DisableCollision(joint index, parent joint index).
/// - When a pose is provided through inJointMatrices the function will detect collisions between joints
/// (they must be separated by more than inMinSeparationDistance to be treated as not colliding) and automatically disable collisions.
///
/// When you create an instance using Ragdoll::CreateRagdoll pass in a unique GroupID for each ragdoll (e.g. a simple counter), note that this number
/// should be unique throughout the PhysicsSystem, so if you have different types of ragdolls they should not share the same GroupID.
/// Generated from method `JPH::RagdollSettings::DisableParentChildCollisions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inJointMatrices` defaults to a null pointer in C++.
/// Parameter `inMinSeparationDistance` has a default argument: `0.0f`, pass a null pointer to use it.
JOLT_API void JPH_RagdollSettings_DisableParentChildCollisions(JPH_RagdollSettings *_this, const JPH_Mat44 *inJointMatrices, const float *inMinSeparationDistance);

/// Create ragdoll instance from these settings
/// @return Newly created ragdoll or null when out of bodies
/// Generated from method `JPH::RagdollSettings::CreateRagdoll`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Ragdoll *JPH_RagdollSettings_CreateRagdoll(const JPH_RagdollSettings *_this, unsigned int inCollisionGroup, uint64_t inUserData, JPH_PhysicsSystem *inSystem);

/// Access to the skeleton of this ragdoll
/// Generated from method `JPH::RagdollSettings::GetSkeleton`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Skeleton *JPH_RagdollSettings_GetSkeleton(const JPH_RagdollSettings *_this);

/// Generated from method `JPH::RagdollSettings::GetSkeleton`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Skeleton *JPH_RagdollSettings_GetSkeleton_mut(JPH_RagdollSettings *_this);

/// Calculate the map needed for GetBodyIndexToConstraintIndex()
/// Generated from method `JPH::RagdollSettings::CalculateBodyIndexToConstraintIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(JPH_RagdollSettings *_this);

/// Get table that maps a body index to the constraint index with which it is connected to its parent. -1 if there is no constraint associated with the body.
/// Note that this will only tell you which constraint connects the body to its parent, it will not look in the additional constraint list.
/// Generated from method `JPH::RagdollSettings::GetBodyIndexToConstraintIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_int *JPH_RagdollSettings_GetBodyIndexToConstraintIndex(const JPH_RagdollSettings *_this);

/// Map a single body index to a constraint index
/// Generated from method `JPH::RagdollSettings::GetConstraintIndexForBodyIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_RagdollSettings_GetConstraintIndexForBodyIndex(const JPH_RagdollSettings *_this, int inBodyIndex);

/// Calculate the map needed for GetConstraintIndexToBodyIdxPair()
/// Generated from method `JPH::RagdollSettings::CalculateConstraintIndexToBodyIdxPair`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(JPH_RagdollSettings *_this);

/// Table that maps a constraint index (index in mConstraints) to the indices of the bodies that the constraint is connected to (index in mBodyIDs)
/// Generated from method `JPH::RagdollSettings::GetConstraintIndexToBodyIdxPair`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_std_pair_int_int *JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair(const JPH_RagdollSettings *_this);

/// Map a single constraint index (index in mConstraints) to the indices of the bodies that the constraint is connected to (index in mBodyIDs)
/// Generated from method `JPH::RagdollSettings::GetBodyIndicesForConstraintIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_std_pair_int_int_Destroy()` to free it when you're done using it.
JOLT_API Jolt_std_pair_int_int *JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(const JPH_RagdollSettings *_this, int inConstraintIndex);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RagdollSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_SetEmbedded(const JPH_RagdollSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RagdollSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RagdollSettings_GetRefCount(const JPH_RagdollSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RagdollSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_AddRef(const JPH_RagdollSettings *_this);

/// Generated from method `JPH::RagdollSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_Release(const JPH_RagdollSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RagdollSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_RagdollSettings_sInternalGetRefCountOffset(void);

///< Position of the body (not of the center of mass)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mPosition(const JPH_RagdollSettings_Part *_this);

///< Position of the body (not of the center of mass)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mPosition(JPH_RagdollSettings_Part *_this);

///< Rotation of the body
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_RagdollSettings_Part_Get_mRotation(const JPH_RagdollSettings_Part *_this);

///< Rotation of the body
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_RagdollSettings_Part_GetMutable_mRotation(JPH_RagdollSettings_Part *_this);

///< World space linear velocity of the center of mass (m/s)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mLinearVelocity(const JPH_RagdollSettings_Part *_this);

///< World space linear velocity of the center of mass (m/s)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mLinearVelocity(JPH_RagdollSettings_Part *_this);

///< World space angular velocity (rad/s)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mAngularVelocity(const JPH_RagdollSettings_Part *_this);

///< World space angular velocity (rad/s)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mAngularVelocity(JPH_RagdollSettings_Part *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_RagdollSettings_Part_Get_mUserData(const JPH_RagdollSettings_Part *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_RagdollSettings_Part_Set_mUserData(JPH_RagdollSettings_Part *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_RagdollSettings_Part_GetMutable_mUserData(JPH_RagdollSettings_Part *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned short *JPH_RagdollSettings_Part_Get_mObjectLayer(const JPH_RagdollSettings_Part *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mObjectLayer`.
/// When this function is called, this object will drop object references it held previously in `mObjectLayer`.
JOLT_API void JPH_RagdollSettings_Part_Set_mObjectLayer(JPH_RagdollSettings_Part *_this, unsigned short value);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned short *JPH_RagdollSettings_Part_GetMutable_mObjectLayer(JPH_RagdollSettings_Part *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CollisionGroup *JPH_RagdollSettings_Part_Get_mCollisionGroup(const JPH_RagdollSettings_Part *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollisionGroup`.
/// When this function is called, this object will drop object references it held previously in `mCollisionGroup`.
JOLT_API void JPH_RagdollSettings_Part_Set_mCollisionGroup(JPH_RagdollSettings_Part *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CollisionGroup *JPH_RagdollSettings_Part_GetMutable_mCollisionGroup(JPH_RagdollSettings_Part *_this);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EMotionType *JPH_RagdollSettings_Part_Get_mMotionType(const JPH_RagdollSettings_Part *_this);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMotionType`.
/// When this function is called, this object will drop object references it held previously in `mMotionType`.
JOLT_API void JPH_RagdollSettings_Part_Set_mMotionType(JPH_RagdollSettings_Part *_this, JPH_EMotionType value);

///< Motion type, determines if the object is static, dynamic or kinematic
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EMotionType *JPH_RagdollSettings_Part_GetMutable_mMotionType(JPH_RagdollSettings_Part *_this);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic(const JPH_RagdollSettings_Part *_this);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowDynamicOrKinematic`.
JOLT_API void JPH_RagdollSettings_Part_Set_mAllowDynamicOrKinematic(JPH_RagdollSettings_Part *_this, bool value);

///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAllowDynamicOrKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic(JPH_RagdollSettings_Part *_this);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mIsSensor(const JPH_RagdollSettings_Part *_this);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsSensor`.
JOLT_API void JPH_RagdollSettings_Part_Set_mIsSensor(JPH_RagdollSettings_Part *_this, bool value);

///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mIsSensor(JPH_RagdollSettings_Part *_this);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic(const JPH_RagdollSettings_Part *_this);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollideKinematicVsNonDynamic`.
JOLT_API void JPH_RagdollSettings_Part_Set_mCollideKinematicVsNonDynamic(JPH_RagdollSettings_Part *_this, bool value);

///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mCollideKinematicVsNonDynamic`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic(JPH_RagdollSettings_Part *_this);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mUseManifoldReduction(const JPH_RagdollSettings_Part *_this);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseManifoldReduction`.
JOLT_API void JPH_RagdollSettings_Part_Set_mUseManifoldReduction(JPH_RagdollSettings_Part *_this, bool value);

///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction(JPH_RagdollSettings_Part *_this);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce(const JPH_RagdollSettings_Part *_this);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mApplyGyroscopicForce`.
JOLT_API void JPH_RagdollSettings_Part_Set_mApplyGyroscopicForce(JPH_RagdollSettings_Part *_this, bool value);

///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mApplyGyroscopicForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce(JPH_RagdollSettings_Part *_this);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EMotionQuality *JPH_RagdollSettings_Part_Get_mMotionQuality(const JPH_RagdollSettings_Part *_this);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMotionQuality`.
/// When this function is called, this object will drop object references it held previously in `mMotionQuality`.
JOLT_API void JPH_RagdollSettings_Part_Set_mMotionQuality(JPH_RagdollSettings_Part *_this, JPH_EMotionQuality value);

///< Motion quality, or how well it detects collisions when it has a high velocity
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EMotionQuality *JPH_RagdollSettings_Part_GetMutable_mMotionQuality(JPH_RagdollSettings_Part *_this);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval(const JPH_RagdollSettings_Part *_this);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnhancedInternalEdgeRemoval`.
JOLT_API void JPH_RagdollSettings_Part_Set_mEnhancedInternalEdgeRemoval(JPH_RagdollSettings_Part *_this, bool value);

///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval(JPH_RagdollSettings_Part *_this);

///< If this body can go to sleep or not
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RagdollSettings_Part_Get_mAllowSleeping(const JPH_RagdollSettings_Part *_this);

///< If this body can go to sleep or not
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowSleeping`.
JOLT_API void JPH_RagdollSettings_Part_Set_mAllowSleeping(JPH_RagdollSettings_Part *_this, bool value);

///< If this body can go to sleep or not
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RagdollSettings_Part_GetMutable_mAllowSleeping(JPH_RagdollSettings_Part *_this);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mFriction(const JPH_RagdollSettings_Part *_this);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFriction`.
JOLT_API void JPH_RagdollSettings_Part_Set_mFriction(JPH_RagdollSettings_Part *_this, float value);

///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mFriction(JPH_RagdollSettings_Part *_this);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mRestitution(const JPH_RagdollSettings_Part *_this);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRestitution`.
JOLT_API void JPH_RagdollSettings_Part_Set_mRestitution(JPH_RagdollSettings_Part *_this, float value);

///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mRestitution(JPH_RagdollSettings_Part *_this);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mLinearDamping(const JPH_RagdollSettings_Part *_this);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLinearDamping`.
JOLT_API void JPH_RagdollSettings_Part_Set_mLinearDamping(JPH_RagdollSettings_Part *_this, float value);

///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mLinearDamping(JPH_RagdollSettings_Part *_this);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mAngularDamping(const JPH_RagdollSettings_Part *_this);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_RagdollSettings_Part_Set_mAngularDamping(JPH_RagdollSettings_Part *_this, float value);

///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mAngularDamping(JPH_RagdollSettings_Part *_this);

///< Maximum linear velocity that this body can reach (m/s)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mMaxLinearVelocity(const JPH_RagdollSettings_Part *_this);

///< Maximum linear velocity that this body can reach (m/s)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxLinearVelocity`.
JOLT_API void JPH_RagdollSettings_Part_Set_mMaxLinearVelocity(JPH_RagdollSettings_Part *_this, float value);

///< Maximum linear velocity that this body can reach (m/s)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity(JPH_RagdollSettings_Part *_this);

///< Maximum angular velocity that this body can reach (rad/s)
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mMaxAngularVelocity(const JPH_RagdollSettings_Part *_this);

///< Maximum angular velocity that this body can reach (rad/s)
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxAngularVelocity`.
JOLT_API void JPH_RagdollSettings_Part_Set_mMaxAngularVelocity(JPH_RagdollSettings_Part *_this, float value);

///< Maximum angular velocity that this body can reach (rad/s)
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity(JPH_RagdollSettings_Part *_this);

///< Value to multiply gravity with for this body
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mGravityFactor(const JPH_RagdollSettings_Part *_this);

///< Value to multiply gravity with for this body
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mGravityFactor`.
JOLT_API void JPH_RagdollSettings_Part_Set_mGravityFactor(JPH_RagdollSettings_Part *_this, float value);

///< Value to multiply gravity with for this body
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mGravityFactor(JPH_RagdollSettings_Part *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride(const JPH_RagdollSettings_Part *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_RagdollSettings_Part_Set_mNumVelocityStepsOverride(JPH_RagdollSettings_Part *_this, unsigned int value);

///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride(JPH_RagdollSettings_Part *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride(const JPH_RagdollSettings_Part *_this);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_RagdollSettings_Part_Set_mNumPositionStepsOverride(JPH_RagdollSettings_Part *_this, unsigned int value);

///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride(JPH_RagdollSettings_Part *_this);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::Part` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RagdollSettings_Part_Get_mInertiaMultiplier(const JPH_RagdollSettings_Part *_this);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Modifies a member variable of class `JPH::RagdollSettings::Part` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertiaMultiplier`.
JOLT_API void JPH_RagdollSettings_Part_Set_mInertiaMultiplier(JPH_RagdollSettings_Part *_this, float value);

///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::Part` named `mInertiaMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier(JPH_RagdollSettings_Part *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_Part_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RagdollSettings_Part_DestroyArray()`.
/// Use `JPH_RagdollSettings_Part_OffsetMutablePtr()` and `JPH_RagdollSettings_Part_OffsetPtr()` to access the array elements.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_OffsetPtr(const JPH_RagdollSettings_Part *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_OffsetMutablePtr(JPH_RagdollSettings_Part *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RagdollSettings::Part` to its base class `JPH::BodyCreationSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BodyCreationSettings *JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(const JPH_RagdollSettings_Part *object);

/// Upcasts an instance of `JPH::RagdollSettings::Part` to its base class `JPH::BodyCreationSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BodyCreationSettings *JPH_RagdollSettings_Part_MutableUpcastTo_JPH_BodyCreationSettings(JPH_RagdollSettings_Part *object);

/// Downcasts an instance of `JPH::BodyCreationSettings` to a derived class `JPH::RagdollSettings::Part`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(const JPH_BodyCreationSettings *object);

/// Downcasts an instance of `JPH::BodyCreationSettings` to a derived class `JPH::RagdollSettings::Part`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_MutableStaticDowncastFrom_JPH_BodyCreationSettings(JPH_BodyCreationSettings *object);

/// Generated from constructor `JPH::RagdollSettings::Part::Part`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_Part_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings_Part *_other);

/// Destroys a heap-allocated instance of `JPH_RagdollSettings_Part`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_Part_Destroy(const JPH_RagdollSettings_Part *_this);

/// Destroys a heap-allocated array of `JPH_RagdollSettings_Part`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_Part_DestroyArray(const JPH_RagdollSettings_Part *_this);

/// Generated from method `JPH::RagdollSettings::Part::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_AssignFromAnother(JPH_RagdollSettings_Part *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings_Part *_other);

/// Generated from method `JPH::RagdollSettings::Part::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_Part_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::Part::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_Part_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::Part::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::Part::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_Part_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::Part::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::Part::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RagdollSettings::Part::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access to the shape settings object. This contains serializable (non-runtime optimized) information about the Shape.
/// Generated from method `JPH::RagdollSettings::Part::GetShapeSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ShapeSettings *JPH_RagdollSettings_Part_GetShapeSettings(const JPH_RagdollSettings_Part *_this);

/// Generated from method `JPH::RagdollSettings::Part::SetShapeSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_Part_SetShapeSettings(JPH_RagdollSettings_Part *_this, const JPH_ShapeSettings *inShape);

/// Access to the run-time shape object. Will convert from ShapeSettings object if needed.
/// Generated from method `JPH::RagdollSettings::Part::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_RagdollSettings_Part_GetShape(const JPH_RagdollSettings_Part *_this);

/// Generated from method `JPH::RagdollSettings::Part::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RagdollSettings_Part_SetShape(JPH_RagdollSettings_Part *_this, const JPH_Shape *inShape);

/// Check if the mass properties of this body will be calculated (only relevant for kinematic or dynamic objects that need a MotionProperties object)
/// Generated from method `JPH::RagdollSettings::Part::HasMassProperties`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RagdollSettings_Part_HasMassProperties(const JPH_RagdollSettings_Part *_this);

///< Indices of the bodies that this constraint connects
/// Returns a pointer to a member variable of class `JPH::RagdollSettings::AdditionalConstraint` named `mBodyIdx`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx(const JPH_RagdollSettings_AdditionalConstraint *_this);

///< Indices of the bodies that this constraint connects
/// Returns a mutable pointer to a member variable of class `JPH::RagdollSettings::AdditionalConstraint` named `mBodyIdx`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx(JPH_RagdollSettings_AdditionalConstraint *_this);

/// Returns the size of the array member of class `JPH::RagdollSettings::AdditionalConstraint` named `mBodyIdx`. The size is `2`.
JOLT_API size_t JPH_RagdollSettings_AdditionalConstraint_GetSize_mBodyIdx(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_AdditionalConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RagdollSettings_AdditionalConstraint_DestroyArray()`.
/// Use `JPH_RagdollSettings_AdditionalConstraint_OffsetMutablePtr()` and `JPH_RagdollSettings_AdditionalConstraint_OffsetPtr()` to access the array elements.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_OffsetPtr(const JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_OffsetMutablePtr(JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_AdditionalConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings_AdditionalConstraint *_other);

/// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RagdollSettings_AdditionalConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_Construct(int inBodyIdx1, int inBodyIdx2, JPH_TwoBodyConstraintSettings *inConstraint);

/// Destroys a heap-allocated instance of `JPH_RagdollSettings_AdditionalConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_AdditionalConstraint_Destroy(const JPH_RagdollSettings_AdditionalConstraint *_this);

/// Destroys a heap-allocated array of `JPH_RagdollSettings_AdditionalConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RagdollSettings_AdditionalConstraint_DestroyArray(const JPH_RagdollSettings_AdditionalConstraint *_this);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother(JPH_RagdollSettings_AdditionalConstraint *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings_AdditionalConstraint *_other);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t(size_t inCount);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Constructor
/// Generated from constructor `JPH::Ragdoll::Ragdoll`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Ragdoll_Destroy()` to free it when you're done using it.
JOLT_API JPH_Ragdoll *JPH_Ragdoll_Construct(JPH_PhysicsSystem *inSystem);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Ragdoll *JPH_Ragdoll_OffsetPtr(const JPH_Ragdoll *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Ragdoll *JPH_Ragdoll_OffsetMutablePtr(JPH_Ragdoll *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Ragdoll` to its base class `JPH::RefTarget<JPH::Ragdoll>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Ragdoll *JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(const JPH_Ragdoll *object);

/// Upcasts an instance of `JPH::Ragdoll` to its base class `JPH::RefTarget<JPH::Ragdoll>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_Ragdoll_MutableUpcastTo_JPH_RefTarget_JPH_Ragdoll(JPH_Ragdoll *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Ragdoll>` to a derived class `JPH::Ragdoll`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Ragdoll *JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(const JPH_RefTarget_JPH_Ragdoll *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Ragdoll>` to a derived class `JPH::Ragdoll`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Ragdoll *JPH_Ragdoll_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(JPH_RefTarget_JPH_Ragdoll *object);

/// Upcasts an instance of `JPH::Ragdoll` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Ragdoll_UpcastTo_JPH_NonCopyable(const JPH_Ragdoll *object);

/// Upcasts an instance of `JPH::Ragdoll` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Ragdoll_MutableUpcastTo_JPH_NonCopyable(JPH_Ragdoll *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Ragdoll`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Ragdoll *JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Ragdoll`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Ragdoll *JPH_Ragdoll_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_Ragdoll`. Does nothing if the pointer is null.
JOLT_API void JPH_Ragdoll_Destroy(const JPH_Ragdoll *_this);

/// Destroys a heap-allocated array of `JPH_Ragdoll`. Does nothing if the pointer is null.
JOLT_API void JPH_Ragdoll_DestroyArray(const JPH_Ragdoll *_this);

/// Generated from method `JPH::Ragdoll::operator new`.
JOLT_API void *Jolt_new_JPH_Ragdoll_size_t(size_t inCount);

/// Generated from method `JPH::Ragdoll::operator delete`.
JOLT_API void Jolt_delete_JPH_Ragdoll_void_ptr(void *inPointer);

/// Generated from method `JPH::Ragdoll::operator delete`.
JOLT_API void Jolt_delete_JPH_Ragdoll_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Ragdoll::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Ragdoll_size_t(size_t inCount);

/// Generated from method `JPH::Ragdoll::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ragdoll_void_ptr(void *inPointer);

/// Generated from method `JPH::Ragdoll::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Ragdoll::operator new`.
JOLT_API void *Jolt_new_JPH_Ragdoll_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Ragdoll::operator delete`.
JOLT_API void Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Ragdoll::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Ragdoll_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Ragdoll::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Add bodies and constraints to the system and optionally activate the bodies
/// Generated from method `JPH::Ragdoll::AddToPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_AddToPhysicsSystem(JPH_Ragdoll *_this, JPH_EActivation inActivationMode, const bool *inLockBodies);

/// Remove bodies and constraints from the system
/// Generated from method `JPH::Ragdoll::RemoveFromPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_RemoveFromPhysicsSystem(JPH_Ragdoll *_this, const bool *inLockBodies);

/// Wake up all bodies in the ragdoll
/// Generated from method `JPH::Ragdoll::Activate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_Activate(JPH_Ragdoll *_this, const bool *inLockBodies);

/// Check if one or more of the bodies in the ragdoll are active.
/// Note that this involves locking the bodies (if inLockBodies is true) and looping over them. An alternative and possibly faster
/// way could be to install a BodyActivationListener and count the number of active bodies of a ragdoll as they're activated / deactivated
/// (basically check if the body that activates / deactivates is in GetBodyIDs() and increment / decrement a counter).
/// Generated from method `JPH::Ragdoll::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API bool JPH_Ragdoll_IsActive(const JPH_Ragdoll *_this, const bool *inLockBodies);

/// Set the group ID on all bodies in the ragdoll
/// Generated from method `JPH::Ragdoll::SetGroupID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_SetGroupID(JPH_Ragdoll *_this, unsigned int inGroupID, const bool *inLockBodies);

/// Set the ragdoll to a pose (calls BodyInterface::SetPositionAndRotation to instantly move the ragdoll)
/// Generated from method `JPH::Ragdoll::SetPose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPose` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_SetPose_2(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose, const bool *inLockBodies);

/// Lower level version of SetPose that directly takes the world space joint matrices
/// Generated from method `JPH::Ragdoll::SetPose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRootOffset` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_SetPose_3(JPH_Ragdoll *_this, const JPH_Vec3 *inRootOffset, const JPH_Mat44 *inJointMatrices, const bool *inLockBodies);

/// Get the ragdoll pose (uses the world transform of the bodies to calculate the pose)
/// Generated from method `JPH::Ragdoll::GetPose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outPose` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_GetPose_2(JPH_Ragdoll *_this, JPH_SkeletonPose *outPose, const bool *inLockBodies);

/// Lower level version of GetPose that directly returns the world space joint matrices
/// Generated from method `JPH::Ragdoll::GetPose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outRootOffset` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_GetPose_3(JPH_Ragdoll *_this, JPH_Vec3 *outRootOffset, JPH_Mat44 *outJointMatrices, const bool *inLockBodies);

/// This function calls ResetWarmStart on all constraints. It can be used after calling SetPose to reset previous frames impulses. See: Constraint::ResetWarmStart.
/// Generated from method `JPH::Ragdoll::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Ragdoll_ResetWarmStart(JPH_Ragdoll *_this);

/// Drive the ragdoll to a specific pose by setting velocities on each of the bodies so that it will reach inPose in inDeltaTime
/// Generated from method `JPH::Ragdoll::DriveToPoseUsingKinematics`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPose` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_DriveToPoseUsingKinematics_3(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose, float inDeltaTime, const bool *inLockBodies);

/// Lower level version of DriveToPoseUsingKinematics that directly takes the world space joint matrices
/// Generated from method `JPH::Ragdoll::DriveToPoseUsingKinematics`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRootOffset` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_DriveToPoseUsingKinematics_4(JPH_Ragdoll *_this, const JPH_Vec3 *inRootOffset, const JPH_Mat44 *inJointMatrices, float inDeltaTime, const bool *inLockBodies);

/// Drive the ragdoll to a specific pose by activating the motors on each constraint
/// Generated from method `JPH::Ragdoll::DriveToPoseUsingMotors`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPose` can not be null. It is a single object.
JOLT_API void JPH_Ragdoll_DriveToPoseUsingMotors(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose);

/// Control the linear and velocity of all bodies in the ragdoll
/// Generated from method `JPH::Ragdoll::SetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_SetLinearAndAngularVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity, const bool *inLockBodies);

/// Set the world space linear velocity of all bodies in the ragdoll.
/// Generated from method `JPH::Ragdoll::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_SetLinearVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies);

/// Add a world space velocity (in m/s) to all bodies in the ragdoll.
/// Generated from method `JPH::Ragdoll::AddLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_AddLinearVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies);

/// Add impulse to all bodies of the ragdoll (center of mass of each of them)
/// Generated from method `JPH::Ragdoll::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_AddImpulse(JPH_Ragdoll *_this, const JPH_Vec3 *inImpulse, const bool *inLockBodies);

/// Get the position and orientation of the root of the ragdoll
/// Generated from method `JPH::Ragdoll::GetRootTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outPosition` can not be null. It is a single object.
/// Parameter `outRotation` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Ragdoll_GetRootTransform(const JPH_Ragdoll *_this, JPH_Vec3 *outPosition, JPH_Quat *outRotation, const bool *inLockBodies);

/// Get number of bodies in the ragdoll
/// Generated from method `JPH::Ragdoll::GetBodyCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t JPH_Ragdoll_GetBodyCount(const JPH_Ragdoll *_this);

/// Access a body ID
/// Generated from method `JPH::Ragdoll::GetBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_Ragdoll_GetBodyID(const JPH_Ragdoll *_this, int inBodyIndex);

/// Access to the array of body IDs
/// Generated from method `JPH::Ragdoll::GetBodyIDs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_BodyID *JPH_Ragdoll_GetBodyIDs(const JPH_Ragdoll *_this);

/// Get number of constraints in the ragdoll
/// Generated from method `JPH::Ragdoll::GetConstraintCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t JPH_Ragdoll_GetConstraintCount(const JPH_Ragdoll *_this);

/// Access a constraint by index
/// Generated from method `JPH::Ragdoll::GetConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_Ragdoll_GetConstraint_mut(JPH_Ragdoll *_this, int inConstraintIndex);

/// Access a constraint by index
/// Generated from method `JPH::Ragdoll::GetConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_TwoBodyConstraint *JPH_Ragdoll_GetConstraint(const JPH_Ragdoll *_this, int inConstraintIndex);

/// Get world space bounding box for all bodies of the ragdoll
/// Generated from method `JPH::Ragdoll::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_Ragdoll_GetWorldSpaceBounds(const JPH_Ragdoll *_this, const bool *inLockBodies);

/// Get the settings object that created this ragdoll
/// Generated from method `JPH::Ragdoll::GetRagdollSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_RagdollSettings *JPH_Ragdoll_GetRagdollSettings(const JPH_Ragdoll *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::Ragdoll::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Ragdoll_SetEmbedded(const JPH_Ragdoll *_this);

/// Get current refcount of this object
/// Generated from method `JPH::Ragdoll::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Ragdoll_GetRefCount(const JPH_Ragdoll *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::Ragdoll::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Ragdoll_AddRef(const JPH_Ragdoll *_this);

/// Generated from method `JPH::Ragdoll::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Ragdoll_Release(const JPH_Ragdoll *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::Ragdoll::sInternalGetRefCountOffset`.
JOLT_API int JPH_Ragdoll_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
