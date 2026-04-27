// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Class that holds 4 float values. Convert to Vec4 to perform calculations.
/// Generated from class `JPH::Float4`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Float4 JPH_Float4;

/// Returns a pointer to a member variable of class `JPH::Float4` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float4_Get_x(const JPH_Float4 *_this);

/// Modifies a member variable of class `JPH::Float4` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JPH_Float4_Set_x(JPH_Float4 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float4` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float4_GetMutable_x(JPH_Float4 *_this);

/// Returns a pointer to a member variable of class `JPH::Float4` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float4_Get_y(const JPH_Float4 *_this);

/// Modifies a member variable of class `JPH::Float4` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JPH_Float4_Set_y(JPH_Float4 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float4` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float4_GetMutable_y(JPH_Float4 *_this);

/// Returns a pointer to a member variable of class `JPH::Float4` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float4_Get_z(const JPH_Float4 *_this);

/// Modifies a member variable of class `JPH::Float4` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JPH_Float4_Set_z(JPH_Float4 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float4` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float4_GetMutable_z(JPH_Float4 *_this);

/// Returns a pointer to a member variable of class `JPH::Float4` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Float4_Get_w(const JPH_Float4 *_this);

/// Modifies a member variable of class `JPH::Float4` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `w`.
JOLT_API void JPH_Float4_Set_w(JPH_Float4 *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::Float4` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Float4_GetMutable_w(JPH_Float4 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float4 *JPH_Float4_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Float4_DestroyArray()`.
/// Use `JPH_Float4_OffsetMutablePtr()` and `JPH_Float4_OffsetPtr()` to access the array elements.
JOLT_API JPH_Float4 *JPH_Float4_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Float4 *JPH_Float4_OffsetPtr(const JPH_Float4 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Float4 *JPH_Float4_OffsetMutablePtr(JPH_Float4 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Float4::Float4`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float4 *JPH_Float4_ConstructFromAnother(const JPH_Float4 *inRHS);

/// Generated from constructor `JPH::Float4::Float4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float4 *JPH_Float4_Construct(float inX, float inY, float inZ, float inW);

/// Destroys a heap-allocated instance of `JPH_Float4`. Does nothing if the pointer is null.
JOLT_API void JPH_Float4_Destroy(const JPH_Float4 *_this);

/// Destroys a heap-allocated array of `JPH_Float4`. Does nothing if the pointer is null.
JOLT_API void JPH_Float4_DestroyArray(const JPH_Float4 *_this);

/// Generated from method `JPH::Float4::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Float4 *JPH_Float4_AssignFromAnother(JPH_Float4 *_this, const JPH_Float4 *inRHS);

/// Generated from method `JPH::Float4::operator new`.
JOLT_API void *Jolt_new_JPH_Float4_size_t(unsigned long inCount);

/// Generated from method `JPH::Float4::operator delete`.
JOLT_API void Jolt_delete_JPH_Float4_void_ptr(void *inPointer);

/// Generated from method `JPH::Float4::operator delete`.
JOLT_API void Jolt_delete_JPH_Float4_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Float4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float4_size_t(unsigned long inCount);

/// Generated from method `JPH::Float4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float4_void_ptr(void *inPointer);

/// Generated from method `JPH::Float4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float4_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Float4::operator new`.
JOLT_API void *Jolt_new_JPH_Float4_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Float4::operator delete`.
JOLT_API void Jolt_delete_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Float4_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Float4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Float4::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Float4_index(const JPH_Float4 *_this, int inCoordinate);

/// Generated from method `JPH::Float4::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Float4(const JPH_Float4 *_this, const JPH_Float4 *inRHS);

/// Generated from method `JPH::Float4::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Float4(const JPH_Float4 *_this, const JPH_Float4 *inRHS);

#ifdef __cplusplus
} // extern "C"
#endif
