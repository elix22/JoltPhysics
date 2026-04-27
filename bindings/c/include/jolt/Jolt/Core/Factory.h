// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// This class is responsible for creating instances of classes based on their name or hash and is mainly used for deserialization of saved data.
/// Generated from class `JPH::Factory`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Factory JPH_Factory;

/// Singleton factory instance
/// Returns a pointer to a member variable of class `JPH::Factory` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Factory *const *JPH_Factory_Get_sInstance(void);

/// Singleton factory instance
/// Modifies a member variable of class `JPH::Factory` named `sInstance`.
/// The reference to the parameter `value` might be preserved in this object in element `sInstance`.
/// When this function is called, this object will drop object references it held previously in `sInstance`.
JOLT_API void JPH_Factory_Set_sInstance(JPH_Factory *value);

/// Singleton factory instance
/// Returns a mutable pointer to a member variable of class `JPH::Factory` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Factory **JPH_Factory_GetMutable_sInstance(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Factory_Destroy()` to free it when you're done using it.
JOLT_API JPH_Factory *JPH_Factory_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Factory_DestroyArray()`.
/// Use `JPH_Factory_OffsetMutablePtr()` and `JPH_Factory_OffsetPtr()` to access the array elements.
JOLT_API JPH_Factory *JPH_Factory_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Factory *JPH_Factory_OffsetPtr(const JPH_Factory *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Factory *JPH_Factory_OffsetMutablePtr(JPH_Factory *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Factory::Factory`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Factory_Destroy()` to free it when you're done using it.
JOLT_API JPH_Factory *JPH_Factory_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Factory *_other);

/// Destroys a heap-allocated instance of `JPH_Factory`. Does nothing if the pointer is null.
JOLT_API void JPH_Factory_Destroy(const JPH_Factory *_this);

/// Destroys a heap-allocated array of `JPH_Factory`. Does nothing if the pointer is null.
JOLT_API void JPH_Factory_DestroyArray(const JPH_Factory *_this);

/// Generated from method `JPH::Factory::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Factory *JPH_Factory_AssignFromAnother(JPH_Factory *_this, Jolt_PassBy _other_pass_by, JPH_Factory *_other);

/// Generated from method `JPH::Factory::operator new`.
JOLT_API void *Jolt_new_JPH_Factory_size_t(unsigned long inCount);

/// Generated from method `JPH::Factory::operator delete`.
JOLT_API void Jolt_delete_JPH_Factory_void_ptr(void *inPointer);

/// Generated from method `JPH::Factory::operator delete`.
JOLT_API void Jolt_delete_JPH_Factory_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Factory::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Factory_size_t(unsigned long inCount);

/// Generated from method `JPH::Factory::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Factory_void_ptr(void *inPointer);

/// Generated from method `JPH::Factory::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Factory_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Factory::operator new`.
JOLT_API void *Jolt_new_JPH_Factory_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Factory::operator delete`.
JOLT_API void Jolt_delete_JPH_Factory_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Factory::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Factory_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Factory::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Factory_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an object
/// Generated from method `JPH::Factory::CreateObject`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_Factory_CreateObject(JPH_Factory *_this, const char *inName);

/// Unregisters all types
/// Generated from method `JPH::Factory::Clear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Factory_Clear(JPH_Factory *_this);

#ifdef __cplusplus
} // extern "C"
#endif
