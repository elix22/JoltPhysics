// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Generated from C++ container `JPH::Array<JPH::Vec3>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct Jolt_JPH_Array_JPH_Vec3 Jolt_JPH_Array_JPH_Vec3;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `Jolt_JPH_Array_JPH_Vec3_DestroyArray()`.
/// Use `Jolt_JPH_Array_JPH_Vec3_OffsetMutablePtr()` and `Jolt_JPH_Array_JPH_Vec3_OffsetPtr()` to access the array elements.
JOLT_API Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_DefaultConstructArray(size_t num_elems);

/// Constructs a copy of another instance. The source remains alive.
/// The reference to the parameter `other` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_JPH_Vec3_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Vec3 *other);

/// Assigns the contents from another instance. Both objects remain alive after the call.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `other` might be preserved in this object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_AssignFromAnother(Jolt_JPH_Array_JPH_Vec3 *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Vec3 *other);

/// Destroys a heap-allocated instance of `Jolt_JPH_Array_JPH_Vec3`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_Destroy(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// Destroys a heap-allocated array of `Jolt_JPH_Array_JPH_Vec3`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_DestroyArray(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_OffsetPtr(const Jolt_JPH_Array_JPH_Vec3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_OffsetMutablePtr(Jolt_JPH_Array_JPH_Vec3 *ptr, ptrdiff_t i);

/// The number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_JPH_Vec3_size(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// Returns true if the size is zero.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool Jolt_JPH_Array_JPH_Vec3_empty(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// Resizes the container. The new elements if any are zeroed.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_resize(Jolt_JPH_Array_JPH_Vec3 *_this, size_t new_size);

/// Removes all elements from the container.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_clear(Jolt_JPH_Array_JPH_Vec3 *_this);

/// The memory capacity, measued in the number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_JPH_Vec3_capacity(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// Reserves memory for a certain number of elements. Never shrinks the memory.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_reserve(Jolt_JPH_Array_JPH_Vec3 *_this, size_t new_capacity);

/// Shrinks the capacity to match the size.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_shrink_to_fit(Jolt_JPH_Array_JPH_Vec3 *_this);

/// The element at a specific index, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_at(const Jolt_JPH_Array_JPH_Vec3 *_this, size_t i);

/// The element at a specific index, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_at_mut(Jolt_JPH_Array_JPH_Vec3 *_this, size_t i);

/// The first element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_front(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// The first element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_front_mut(Jolt_JPH_Array_JPH_Vec3 *_this);

/// The last element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_back(const Jolt_JPH_Array_JPH_Vec3 *_this);

/// The last element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_back_mut(Jolt_JPH_Array_JPH_Vec3 *_this);

/// Inserts a new element at the end.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `new_elem` can not be null. It is a single object.
/// The reference to the parameter `new_elem` might be preserved in this object.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_push_back(Jolt_JPH_Array_JPH_Vec3 *_this, const JPH_Vec3 *new_elem);

/// Removes one element from the end.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_Vec3_pop_back(Jolt_JPH_Array_JPH_Vec3 *_this);

#ifdef __cplusplus
} // extern "C"
#endif
