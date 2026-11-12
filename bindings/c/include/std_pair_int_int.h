// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Stores two objects: `int` and `int`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct Jolt_std_pair_int_int Jolt_std_pair_int_int;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_std_pair_int_int_Destroy()` to free it when you're done using it.
JOLT_API Jolt_std_pair_int_int *Jolt_std_pair_int_int_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `Jolt_std_pair_int_int_DestroyArray()`.
/// Use `Jolt_std_pair_int_int_OffsetMutablePtr()` and `Jolt_std_pair_int_int_OffsetPtr()` to access the array elements.
JOLT_API Jolt_std_pair_int_int *Jolt_std_pair_int_int_DefaultConstructArray(size_t num_elems);

/// Constructs a copy of another instance. The source remains alive.
/// Parameter `other` can not be null. It is a single object.
/// The reference to the parameter `other` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_std_pair_int_int_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API Jolt_std_pair_int_int *Jolt_std_pair_int_int_ConstructFromAnother(const Jolt_std_pair_int_int *other);

/// Assigns the contents from another instance. Both objects remain alive after the call.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
/// The reference to the parameter `other` might be preserved in this object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_std_pair_int_int_AssignFromAnother(Jolt_std_pair_int_int *_this, const Jolt_std_pair_int_int *other);

/// Destroys a heap-allocated instance of `Jolt_std_pair_int_int`. Does nothing if the pointer is null.
JOLT_API void Jolt_std_pair_int_int_Destroy(const Jolt_std_pair_int_int *_this);

/// Destroys a heap-allocated array of `Jolt_std_pair_int_int`. Does nothing if the pointer is null.
JOLT_API void Jolt_std_pair_int_int_DestroyArray(const Jolt_std_pair_int_int *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const Jolt_std_pair_int_int *Jolt_std_pair_int_int_OffsetPtr(const Jolt_std_pair_int_int *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API Jolt_std_pair_int_int *Jolt_std_pair_int_int_OffsetMutablePtr(Jolt_std_pair_int_int *ptr, ptrdiff_t i);

/// Constructs the pair elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_std_pair_int_int_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API Jolt_std_pair_int_int *Jolt_std_pair_int_int_Construct(int first, int second);

/// The first of the two elements, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *Jolt_std_pair_int_int_first(const Jolt_std_pair_int_int *_this);

/// The first of the two elements, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *Jolt_std_pair_int_int_first_mut(Jolt_std_pair_int_int *_this);

/// The second of the two elements, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *Jolt_std_pair_int_int_second(const Jolt_std_pair_int_int *_this);

/// The second of the two elements, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *Jolt_std_pair_int_int_second_mut(Jolt_std_pair_int_int *_this);

#ifdef __cplusplus
} // extern "C"
#endif
