// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_RefTarget_JPH_Skeleton JPH_RefTarget_JPH_Skeleton; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct Jolt_JPH_Array_JPH_Skeleton_Joint Jolt_JPH_Array_JPH_Skeleton_Joint; // Defined in `#include <JPH_Array_JPH_Skeleton_Joint.h>`.


/// Declare internal structure for a joint
/// Generated from class `JPH::Skeleton::Joint`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Skeleton_Joint JPH_Skeleton_Joint;

/// Resource that contains the joint hierarchy for a skeleton
/// Generated from class `JPH::Skeleton`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::Skeleton>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Skeleton JPH_Skeleton;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Skeleton_Destroy()` to free it when you're done using it.
JOLT_API JPH_Skeleton *JPH_Skeleton_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Skeleton_DestroyArray()`.
/// Use `JPH_Skeleton_OffsetMutablePtr()` and `JPH_Skeleton_OffsetPtr()` to access the array elements.
JOLT_API JPH_Skeleton *JPH_Skeleton_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Skeleton *JPH_Skeleton_OffsetPtr(const JPH_Skeleton *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Skeleton *JPH_Skeleton_OffsetMutablePtr(JPH_Skeleton *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Skeleton` to its base class `JPH::RefTarget<JPH::Skeleton>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Skeleton *JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(const JPH_Skeleton *object);

/// Upcasts an instance of `JPH::Skeleton` to its base class `JPH::RefTarget<JPH::Skeleton>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_Skeleton_MutableUpcastTo_JPH_RefTarget_JPH_Skeleton(JPH_Skeleton *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Skeleton>` to a derived class `JPH::Skeleton`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Skeleton *JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(const JPH_RefTarget_JPH_Skeleton *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Skeleton>` to a derived class `JPH::Skeleton`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Skeleton *JPH_Skeleton_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(JPH_RefTarget_JPH_Skeleton *object);

/// Generated from constructor `JPH::Skeleton::Skeleton`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Skeleton_Destroy()` to free it when you're done using it.
JOLT_API JPH_Skeleton *JPH_Skeleton_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Skeleton *_other);

/// Destroys a heap-allocated instance of `JPH_Skeleton`. Does nothing if the pointer is null.
JOLT_API void JPH_Skeleton_Destroy(const JPH_Skeleton *_this);

/// Destroys a heap-allocated array of `JPH_Skeleton`. Does nothing if the pointer is null.
JOLT_API void JPH_Skeleton_DestroyArray(const JPH_Skeleton *_this);

/// Generated from method `JPH::Skeleton::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Skeleton *JPH_Skeleton_AssignFromAnother(JPH_Skeleton *_this, Jolt_PassBy _other_pass_by, JPH_Skeleton *_other);

/// Generated from method `JPH::Skeleton::operator new`.
JOLT_API void *Jolt_new_JPH_Skeleton_size_t(size_t inCount);

/// Generated from method `JPH::Skeleton::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_void_ptr(void *inPointer);

/// Generated from method `JPH::Skeleton::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Skeleton::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Skeleton_size_t(size_t inCount);

/// Generated from method `JPH::Skeleton::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_void_ptr(void *inPointer);

/// Generated from method `JPH::Skeleton::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Skeleton::operator new`.
JOLT_API void *Jolt_new_JPH_Skeleton_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Skeleton::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Skeleton::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Skeleton_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Skeleton::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace);

///@name Access to the joints
///@{
/// Generated from method `JPH::Skeleton::GetJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_Skeleton_Joint *JPH_Skeleton_GetJoints(const JPH_Skeleton *_this);

/// Generated from method `JPH::Skeleton::GetJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_Skeleton_Joint *JPH_Skeleton_GetJoints_mut(JPH_Skeleton *_this);

/// Generated from method `JPH::Skeleton::GetJointCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Skeleton_GetJointCount(const JPH_Skeleton *_this);

/// Generated from method `JPH::Skeleton::GetJoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Skeleton_Joint *JPH_Skeleton_GetJoint(const JPH_Skeleton *_this, int inJoint);

/// Generated from method `JPH::Skeleton::GetJoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_GetJoint_mut(JPH_Skeleton *_this, int inJoint);

/// Fill in parent joint indices based on name
/// Generated from method `JPH::Skeleton::CalculateParentJointIndices`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Skeleton_CalculateParentJointIndices(JPH_Skeleton *_this);

/// Many of the algorithms that use the Skeleton class require that parent joints are in the mJoints array before their children.
/// This function returns true if this is the case, false if not.
/// Generated from method `JPH::Skeleton::AreJointsCorrectlyOrdered`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Skeleton_AreJointsCorrectlyOrdered(const JPH_Skeleton *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::Skeleton::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Skeleton_SetEmbedded(const JPH_Skeleton *_this);

/// Get current refcount of this object
/// Generated from method `JPH::Skeleton::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Skeleton_GetRefCount(const JPH_Skeleton *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::Skeleton::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Skeleton_AddRef(const JPH_Skeleton *_this);

/// Generated from method `JPH::Skeleton::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Skeleton_Release(const JPH_Skeleton *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::Skeleton::sInternalGetRefCountOffset`.
JOLT_API int JPH_Skeleton_sInternalGetRefCountOffset(void);

///< Index of parent joint (in mJoints) or -1 if it has no parent
/// Returns a pointer to a member variable of class `JPH::Skeleton::Joint` named `mParentJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_Skeleton_Joint_Get_mParentJointIndex(const JPH_Skeleton_Joint *_this);

///< Index of parent joint (in mJoints) or -1 if it has no parent
/// Modifies a member variable of class `JPH::Skeleton::Joint` named `mParentJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mParentJointIndex`.
JOLT_API void JPH_Skeleton_Joint_Set_mParentJointIndex(JPH_Skeleton_Joint *_this, int value);

///< Index of parent joint (in mJoints) or -1 if it has no parent
/// Returns a mutable pointer to a member variable of class `JPH::Skeleton::Joint` named `mParentJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_Skeleton_Joint_GetMutable_mParentJointIndex(JPH_Skeleton_Joint *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Skeleton_Joint_Destroy()` to free it when you're done using it.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_Joint_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Skeleton_Joint_DestroyArray()`.
/// Use `JPH_Skeleton_Joint_OffsetMutablePtr()` and `JPH_Skeleton_Joint_OffsetPtr()` to access the array elements.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_Joint_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Skeleton_Joint *JPH_Skeleton_Joint_OffsetPtr(const JPH_Skeleton_Joint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_Joint_OffsetMutablePtr(JPH_Skeleton_Joint *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Skeleton::Joint::Joint`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Skeleton_Joint_Destroy()` to free it when you're done using it.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_Joint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Skeleton_Joint *_other);

/// Destroys a heap-allocated instance of `JPH_Skeleton_Joint`. Does nothing if the pointer is null.
JOLT_API void JPH_Skeleton_Joint_Destroy(const JPH_Skeleton_Joint *_this);

/// Destroys a heap-allocated array of `JPH_Skeleton_Joint`. Does nothing if the pointer is null.
JOLT_API void JPH_Skeleton_Joint_DestroyArray(const JPH_Skeleton_Joint *_this);

/// Generated from method `JPH::Skeleton::Joint::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Skeleton_Joint *JPH_Skeleton_Joint_AssignFromAnother(JPH_Skeleton_Joint *_this, Jolt_PassBy _other_pass_by, JPH_Skeleton_Joint *_other);

/// Generated from method `JPH::Skeleton::Joint::operator new`.
JOLT_API void *Jolt_new_JPH_Skeleton_Joint_size_t(size_t inCount);

/// Generated from method `JPH::Skeleton::Joint::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_Joint_void_ptr(void *inPointer);

/// Generated from method `JPH::Skeleton::Joint::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Skeleton::Joint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Skeleton_Joint_size_t(size_t inCount);

/// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr(void *inPointer);

/// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Skeleton::Joint::operator new`.
JOLT_API void *Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Skeleton::Joint::operator delete`.
JOLT_API void Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Skeleton::Joint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
