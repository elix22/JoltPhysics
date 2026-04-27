// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Class that holds 2 floats, used as a storage class mainly.
/// Generated from class `JPH::Float2`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Float2 JPH_Float2;

/// Returns a pointer to a member variable of class `JPH::Float2` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float2_Get_x(const JPH_Float2 *_this);

/// Modifies a member variable of class `JPH::Float2` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JPH_Float2_Set_x(JPH_Float2 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float2` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float2_GetMutable_x(JPH_Float2 *_this);

/// Returns a pointer to a member variable of class `JPH::Float2` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float2_Get_y(const JPH_Float2 *_this);

/// Modifies a member variable of class `JPH::Float2` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JPH_Float2_Set_y(JPH_Float2 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float2` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float2_GetMutable_y(JPH_Float2 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float2 *JPH_Float2_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Float2_DestroyArray()`.
/// Use `JPH_Float2_OffsetMutablePtr()` and `JPH_Float2_OffsetPtr()` to access the array elements.
JOLT_API JPH_Float2 *JPH_Float2_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Float2 *JPH_Float2_OffsetPtr(const JPH_Float2 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Float2 *JPH_Float2_OffsetMutablePtr(JPH_Float2 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Float2::Float2`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float2 *JPH_Float2_ConstructFromAnother(const JPH_Float2 *inRHS);

/// Generated from constructor `JPH::Float2::Float2`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float2 *JPH_Float2_Construct(float inX, float inY);

/// Destroys a heap-allocated instance of `JPH_Float2`. Does nothing if the pointer is null.
JOLT_API void JPH_Float2_Destroy(const JPH_Float2 *_this);

/// Destroys a heap-allocated array of `JPH_Float2`. Does nothing if the pointer is null.
JOLT_API void JPH_Float2_DestroyArray(const JPH_Float2 *_this);

/// Generated from method `JPH::Float2::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Float2 *JPH_Float2_AssignFromAnother(JPH_Float2 *_this, const JPH_Float2 *inRHS);

/// Generated from method `JPH::Float2::operator new`.
JOLT_API void *Jolt_new_JPH_Float2_size_t(unsigned long inCount);

/// Generated from method `JPH::Float2::operator delete`.
JOLT_API void Jolt_delete_JPH_Float2_void_ptr(void *inPointer);

/// Generated from method `JPH::Float2::operator delete`.
JOLT_API void Jolt_delete_JPH_Float2_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Float2::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float2_size_t(unsigned long inCount);

/// Generated from method `JPH::Float2::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float2_void_ptr(void *inPointer);

/// Generated from method `JPH::Float2::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float2_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Float2::operator new`.
JOLT_API void *Jolt_new_JPH_Float2_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Float2::operator delete`.
JOLT_API void Jolt_delete_JPH_Float2_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float2::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float2_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Float2::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float2_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float2::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Float2(const JPH_Float2 *_this, const JPH_Float2 *inRHS);

/// Generated from method `JPH::Float2::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Float2(const JPH_Float2 *_this, const JPH_Float2 *inRHS);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Float2(Jolt_std_ostream *inStream, const JPH_Float2 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
