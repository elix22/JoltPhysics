// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_GroupFilter JPH_GroupFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/GroupFilter.h>`.
typedef struct JPH_RefTarget_JPH_GroupFilter JPH_RefTarget_JPH_GroupFilter; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.


/// Implementation of GroupFilter that stores a bit table with one bit per sub shape ID pair to determine if they collide or not
///
/// The collision rules:
/// - If one of the objects is in the cInvalidGroup the objects will collide.
/// - If the objects are in different groups they will collide.
/// - If they're in the same group but their collision filter is different they will not collide.
/// - If they're in the same group and their collision filters match, we'll use the SubGroupID and the table below.
///
/// For N = 6 sub groups the table will look like:
///
///		            sub group 1 --->
///		sub group 2 x.....
///		     |      ox....
///		     |      oox...
///		     V      ooox..
///		            oooox.
///		            ooooox
///
/// * 'x' means sub group 1 == sub group 2 and we define this to never collide.
/// * 'o' is a bit that we have to store that defines if the sub groups collide or not.
/// * '.' is a bit we don't need to store because the table is symmetric, we take care that group 2 > group 1 by swapping sub group 1 and sub group 2 if needed.
///
/// The total number of bits we need to store is (N * (N - 1)) / 2
/// Generated from class `JPH::GroupFilterTable`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::GroupFilter`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::GroupFilter>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_GroupFilterTable JPH_GroupFilterTable;

/// Constructs the table with inNumSubGroups subgroups, initially all collision pairs are enabled except when the sub group ID is the same
/// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
/// Parameter `inNumSubGroups` has a default argument: `0`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_GroupFilterTable_Destroy()` to free it when you're done using it.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_Construct(const unsigned int *inNumSubGroups);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_GroupFilterTable_DestroyArray()`.
/// Use `JPH_GroupFilterTable_OffsetMutablePtr()` and `JPH_GroupFilterTable_OffsetPtr()` to access the array elements.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_GroupFilterTable *JPH_GroupFilterTable_OffsetPtr(const JPH_GroupFilterTable *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_OffsetMutablePtr(JPH_GroupFilterTable *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(const JPH_GroupFilterTable *object);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_GroupFilterTable_MutableUpcastTo_JPH_SerializableObject(JPH_GroupFilterTable *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::RefTarget<JPH::GroupFilter>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(const JPH_GroupFilterTable *object);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::RefTarget<JPH::GroupFilter>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilterTable_MutableUpcastTo_JPH_RefTarget_JPH_GroupFilter(JPH_GroupFilterTable *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::GroupFilter>` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(const JPH_RefTarget_JPH_GroupFilter *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::GroupFilter>` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH_RefTarget_JPH_GroupFilter *object);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::GroupFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilter *JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(const JPH_GroupFilterTable *object);

/// Upcasts an instance of `JPH::GroupFilterTable` to its base class `JPH::GroupFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilter *JPH_GroupFilterTable_MutableUpcastTo_JPH_GroupFilter(JPH_GroupFilterTable *object);

/// Downcasts an instance of `JPH::GroupFilter` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(const JPH_GroupFilter *object);

/// Downcasts an instance of `JPH::GroupFilter` to a derived class `JPH::GroupFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_GroupFilter(JPH_GroupFilter *object);

/// Copy constructor
/// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_GroupFilterTable_Destroy()` to free it when you're done using it.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_ConstructFromAnother(Jolt_PassBy inRHS_pass_by, JPH_GroupFilterTable *inRHS);

/// Destroys a heap-allocated instance of `JPH_GroupFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_GroupFilterTable_Destroy(const JPH_GroupFilterTable *_this);

/// Destroys a heap-allocated array of `JPH_GroupFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_GroupFilterTable_DestroyArray(const JPH_GroupFilterTable *_this);

/// Generated from method `JPH::GroupFilterTable::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_GroupFilterTable *JPH_GroupFilterTable_AssignFromAnother(JPH_GroupFilterTable *_this, Jolt_PassBy _other_pass_by, JPH_GroupFilterTable *_other);

/// Generated from method `JPH::GroupFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_GroupFilterTable_size_t(size_t inCount);

/// Generated from method `JPH::GroupFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::GroupFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GroupFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GroupFilterTable_size_t(size_t inCount);

/// Generated from method `JPH::GroupFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::GroupFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GroupFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_GroupFilterTable_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GroupFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::GroupFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GroupFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Checks if two CollisionGroups collide
/// Generated from method `JPH::GroupFilterTable::CanCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGroup1` can not be null. It is a single object.
/// Parameter `inGroup2` can not be null. It is a single object.
JOLT_API bool JPH_GroupFilterTable_CanCollide(const JPH_GroupFilterTable *_this, const JPH_CollisionGroup *inGroup1, const JPH_CollisionGroup *inGroup2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::GroupFilterTable::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilterTable_SetEmbedded(const JPH_GroupFilterTable *_this);

/// Get current refcount of this object
/// Generated from method `JPH::GroupFilterTable::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GroupFilterTable_GetRefCount(const JPH_GroupFilterTable *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::GroupFilterTable::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilterTable_AddRef(const JPH_GroupFilterTable *_this);

/// Generated from method `JPH::GroupFilterTable::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilterTable_Release(const JPH_GroupFilterTable *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::GroupFilterTable::sInternalGetRefCountOffset`.
JOLT_API int JPH_GroupFilterTable_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
