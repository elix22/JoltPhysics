// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Two objects collide with each other if:
/// - Both don't have a group filter
/// - The first group filter says that the objects can collide
/// - Or if there's no filter for the first object, the second group filter says the objects can collide
/// Generated from class `JPH::CollisionGroup`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CollisionGroup JPH_CollisionGroup;

/// Returns a pointer to a member variable of class `JPH::CollisionGroup` named `cInvalidGroup`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_CollisionGroup_Get_cInvalidGroup(void);

/// Returns a pointer to a member variable of class `JPH::CollisionGroup` named `cInvalidSubGroup`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_CollisionGroup_Get_cInvalidSubGroup(void);

/// An invalid collision group
/// Returns a pointer to a member variable of class `JPH::CollisionGroup` named `sInvalid`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CollisionGroup *JPH_CollisionGroup_Get_sInvalid(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollisionGroup *JPH_CollisionGroup_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CollisionGroup_DestroyArray()`.
/// Use `JPH_CollisionGroup_OffsetMutablePtr()` and `JPH_CollisionGroup_OffsetPtr()` to access the array elements.
JOLT_API JPH_CollisionGroup *JPH_CollisionGroup_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CollisionGroup *JPH_CollisionGroup_OffsetPtr(const JPH_CollisionGroup *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CollisionGroup *JPH_CollisionGroup_OffsetMutablePtr(JPH_CollisionGroup *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollisionGroup *JPH_CollisionGroup_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CollisionGroup *_other);

/// Destroys a heap-allocated instance of `JPH_CollisionGroup`. Does nothing if the pointer is null.
JOLT_API void JPH_CollisionGroup_Destroy(const JPH_CollisionGroup *_this);

/// Destroys a heap-allocated array of `JPH_CollisionGroup`. Does nothing if the pointer is null.
JOLT_API void JPH_CollisionGroup_DestroyArray(const JPH_CollisionGroup *_this);

/// Generated from method `JPH::CollisionGroup::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollisionGroup *JPH_CollisionGroup_AssignFromAnother(JPH_CollisionGroup *_this, Jolt_PassBy _other_pass_by, JPH_CollisionGroup *_other);

/// Generated from method `JPH::CollisionGroup::operator new`.
JOLT_API void *Jolt_new_JPH_CollisionGroup_size_t(unsigned long inCount);

/// Generated from method `JPH::CollisionGroup::operator delete`.
JOLT_API void Jolt_delete_JPH_CollisionGroup_void_ptr(void *inPointer);

/// Generated from method `JPH::CollisionGroup::operator delete`.
JOLT_API void Jolt_delete_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CollisionGroup::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollisionGroup_size_t(unsigned long inCount);

/// Generated from method `JPH::CollisionGroup::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollisionGroup_void_ptr(void *inPointer);

/// Generated from method `JPH::CollisionGroup::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CollisionGroup::operator new`.
JOLT_API void *Jolt_new_JPH_CollisionGroup_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CollisionGroup::operator delete`.
JOLT_API void Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CollisionGroup::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CollisionGroup::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the main group id for this object
/// Generated from method `JPH::CollisionGroup::SetGroupID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CollisionGroup_SetGroupID(JPH_CollisionGroup *_this, unsigned int inID);

/// Generated from method `JPH::CollisionGroup::GetGroupID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CollisionGroup_GetGroupID(const JPH_CollisionGroup *_this);

/// Add this object to a sub group
/// Generated from method `JPH::CollisionGroup::SetSubGroupID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CollisionGroup_SetSubGroupID(JPH_CollisionGroup *_this, unsigned int inID);

/// Generated from method `JPH::CollisionGroup::GetSubGroupID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CollisionGroup_GetSubGroupID(const JPH_CollisionGroup *_this);

/// Check if this object collides with another object
/// Generated from method `JPH::CollisionGroup::CanCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_CollisionGroup_CanCollide(const JPH_CollisionGroup *_this, const JPH_CollisionGroup *inOther);

#ifdef __cplusplus
} // extern "C"
#endif
