// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Class that holds 3 floats. Used as a storage class. Convert to Vec3 for calculations.
/// Generated from class `JPH::Float3`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Float3 JPH_Float3;

/// Returns a pointer to a member variable of class `JPH::Float3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float3_Get_x(const JPH_Float3 *_this);

/// Modifies a member variable of class `JPH::Float3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JPH_Float3_Set_x(JPH_Float3 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float3_GetMutable_x(JPH_Float3 *_this);

/// Returns a pointer to a member variable of class `JPH::Float3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float3_Get_y(const JPH_Float3 *_this);

/// Modifies a member variable of class `JPH::Float3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JPH_Float3_Set_y(JPH_Float3 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float3_GetMutable_y(JPH_Float3 *_this);

/// Returns a pointer to a member variable of class `JPH::Float3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float3_Get_z(const JPH_Float3 *_this);

/// Modifies a member variable of class `JPH::Float3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JPH_Float3_Set_z(JPH_Float3 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float3_GetMutable_z(JPH_Float3 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float3 *JPH_Float3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Float3_DestroyArray()`.
/// Use `JPH_Float3_OffsetMutablePtr()` and `JPH_Float3_OffsetPtr()` to access the array elements.
JOLT_API JPH_Float3 *JPH_Float3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Float3 *JPH_Float3_OffsetPtr(const JPH_Float3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Float3 *JPH_Float3_OffsetMutablePtr(JPH_Float3 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Float3::Float3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float3 *JPH_Float3_ConstructFromAnother(const JPH_Float3 *inRHS);

/// Generated from constructor `JPH::Float3::Float3`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float3 *JPH_Float3_Construct(float inX, float inY, float inZ);

/// Destroys a heap-allocated instance of `JPH_Float3`. Does nothing if the pointer is null.
JOLT_API void JPH_Float3_Destroy(const JPH_Float3 *_this);

/// Destroys a heap-allocated array of `JPH_Float3`. Does nothing if the pointer is null.
JOLT_API void JPH_Float3_DestroyArray(const JPH_Float3 *_this);

/// Generated from method `JPH::Float3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Float3 *JPH_Float3_AssignFromAnother(JPH_Float3 *_this, const JPH_Float3 *inRHS);

/// Generated from method `JPH::Float3::operator new`.
JOLT_API void *Jolt_new_JPH_Float3_size_t(size_t inCount);

/// Generated from method `JPH::Float3::operator delete`.
JOLT_API void Jolt_delete_JPH_Float3_void_ptr(void *inPointer);

/// Generated from method `JPH::Float3::operator delete`.
JOLT_API void Jolt_delete_JPH_Float3_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Float3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float3_size_t(size_t inCount);

/// Generated from method `JPH::Float3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float3_void_ptr(void *inPointer);

/// Generated from method `JPH::Float3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float3_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Float3::operator new`.
JOLT_API void *Jolt_new_JPH_Float3_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Float3::operator delete`.
JOLT_API void Jolt_delete_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float3_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Float3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Float3_index(const JPH_Float3 *_this, int inCoordinate);

/// Generated from method `JPH::Float3::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Float3(const JPH_Float3 *_this, const JPH_Float3 *inRHS);

/// Generated from method `JPH::Float3::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Float3(const JPH_Float3 *_this, const JPH_Float3 *inRHS);

#ifdef __cplusplus
} // extern "C"
#endif
