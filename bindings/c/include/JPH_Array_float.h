// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generated from C++ container `JPH::Array<float>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct Jolt_JPH_Array_float Jolt_JPH_Array_float;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_float_Destroy()` to free it when you're done using it.
JOLT_API Jolt_JPH_Array_float *Jolt_JPH_Array_float_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `Jolt_JPH_Array_float_DestroyArray()`.
/// Use `Jolt_JPH_Array_float_OffsetMutablePtr()` and `Jolt_JPH_Array_float_OffsetPtr()` to access the array elements.
JOLT_API Jolt_JPH_Array_float *Jolt_JPH_Array_float_DefaultConstructArray(size_t num_elems);

/// Constructs a copy of another instance. The source remains alive.
/// The reference to the parameter `other` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_float_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API Jolt_JPH_Array_float *Jolt_JPH_Array_float_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_float *other);

/// Assigns the contents from another instance. Both objects remain alive after the call.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `other` might be preserved in this object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_float_AssignFromAnother(Jolt_JPH_Array_float *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_float *other);

/// Destroys a heap-allocated instance of `Jolt_JPH_Array_float`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_float_Destroy(const Jolt_JPH_Array_float *_this);

/// Destroys a heap-allocated array of `Jolt_JPH_Array_float`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_float_DestroyArray(const Jolt_JPH_Array_float *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const Jolt_JPH_Array_float *Jolt_JPH_Array_float_OffsetPtr(const Jolt_JPH_Array_float *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API Jolt_JPH_Array_float *Jolt_JPH_Array_float_OffsetMutablePtr(Jolt_JPH_Array_float *ptr, ptrdiff_t i);

/// Construct from a range of elements.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_float_Destroy()` to free it when you're done using it.
JOLT_API Jolt_JPH_Array_float *Jolt_JPH_Array_float_ConstructFromRange(const float *ptr, size_t size);

/// Assign from a range of elements, overwriting previous contents.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_AssignFromRange(Jolt_JPH_Array_float *_this, const float *ptr, size_t size);

/// The number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_float_size(const Jolt_JPH_Array_float *_this);

/// Returns true if the size is zero.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool Jolt_JPH_Array_float_empty(const Jolt_JPH_Array_float *_this);

/// Resizes the container. The new elements if any are zeroed.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_resize(Jolt_JPH_Array_float *_this, size_t new_size);

/// Resizes the container. The new elements if any are set to the specified value.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_resize_with_default_value(Jolt_JPH_Array_float *_this, size_t new_size, float value);

/// Removes all elements from the container.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_float_clear(Jolt_JPH_Array_float *_this);

/// The memory capacity, measued in the number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_float_capacity(const Jolt_JPH_Array_float *_this);

/// Reserves memory for a certain number of elements. Never shrinks the memory.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_reserve(Jolt_JPH_Array_float *_this, size_t new_capacity);

/// Shrinks the capacity to match the size.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_shrink_to_fit(Jolt_JPH_Array_float *_this);

/// The element at a specific index, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *Jolt_JPH_Array_float_at(const Jolt_JPH_Array_float *_this, size_t i);

/// The element at a specific index, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *Jolt_JPH_Array_float_at_mut(Jolt_JPH_Array_float *_this, size_t i);

/// The first element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *Jolt_JPH_Array_float_front(const Jolt_JPH_Array_float *_this);

/// The first element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API float *Jolt_JPH_Array_float_front_mut(Jolt_JPH_Array_float *_this);

/// The last element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *Jolt_JPH_Array_float_back(const Jolt_JPH_Array_float *_this);

/// The last element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API float *Jolt_JPH_Array_float_back_mut(Jolt_JPH_Array_float *_this);

/// Returns a pointer to the continuous storage that holds all elements, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *Jolt_JPH_Array_float_data(const Jolt_JPH_Array_float *_this);

/// Returns a pointer to the continuous storage that holds all elements, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API float *Jolt_JPH_Array_float_data_mut(Jolt_JPH_Array_float *_this);

/// Inserts a new element at the end.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_push_back(Jolt_JPH_Array_float *_this, float new_elem);

/// Removes one element from the end.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_pop_back(Jolt_JPH_Array_float *_this);

/// Inserts a new element right before the specified position.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_insert(Jolt_JPH_Array_float *_this, size_t position, float new_elem);

/// Erases the element at the specified position.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_float_erase(Jolt_JPH_Array_float *_this, size_t position);

#ifdef __cplusplus
} // extern "C"
#endif
