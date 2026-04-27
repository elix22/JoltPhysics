// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Class that holds 3 doubles. Used as a storage class. Convert to DVec3 for calculations.
/// Generated from class `JPH::Double3`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Double3 JPH_Double3;

/// Returns a pointer to a member variable of class `JPH::Double3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JPH_Double3_Get_x(const JPH_Double3 *_this);

/// Modifies a member variable of class `JPH::Double3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JPH_Double3_Set_x(JPH_Double3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JPH::Double3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JPH_Double3_GetMutable_x(JPH_Double3 *_this);

/// Returns a pointer to a member variable of class `JPH::Double3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JPH_Double3_Get_y(const JPH_Double3 *_this);

/// Modifies a member variable of class `JPH::Double3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JPH_Double3_Set_y(JPH_Double3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JPH::Double3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JPH_Double3_GetMutable_y(JPH_Double3 *_this);

/// Returns a pointer to a member variable of class `JPH::Double3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JPH_Double3_Get_z(const JPH_Double3 *_this);

/// Modifies a member variable of class `JPH::Double3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JPH_Double3_Set_z(JPH_Double3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JPH::Double3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JPH_Double3_GetMutable_z(JPH_Double3 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Double3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Double3 *JPH_Double3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Double3_DestroyArray()`.
/// Use `JPH_Double3_OffsetMutablePtr()` and `JPH_Double3_OffsetPtr()` to access the array elements.
JOLT_API JPH_Double3 *JPH_Double3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Double3 *JPH_Double3_OffsetPtr(const JPH_Double3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Double3 *JPH_Double3_OffsetMutablePtr(JPH_Double3 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Double3::Double3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Double3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Double3 *JPH_Double3_ConstructFromAnother(const JPH_Double3 *inRHS);

/// Generated from constructor `JPH::Double3::Double3`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Double3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Double3 *JPH_Double3_Construct(double inX, double inY, double inZ);

/// Destroys a heap-allocated instance of `JPH_Double3`. Does nothing if the pointer is null.
JOLT_API void JPH_Double3_Destroy(const JPH_Double3 *_this);

/// Destroys a heap-allocated array of `JPH_Double3`. Does nothing if the pointer is null.
JOLT_API void JPH_Double3_DestroyArray(const JPH_Double3 *_this);

/// Generated from method `JPH::Double3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Double3 *JPH_Double3_AssignFromAnother(JPH_Double3 *_this, const JPH_Double3 *inRHS);

/// Generated from method `JPH::Double3::operator new`.
JOLT_API void *Jolt_new_JPH_Double3_size_t(unsigned long inCount);

/// Generated from method `JPH::Double3::operator delete`.
JOLT_API void Jolt_delete_JPH_Double3_void_ptr(void *inPointer);

/// Generated from method `JPH::Double3::operator delete`.
JOLT_API void Jolt_delete_JPH_Double3_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Double3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Double3_size_t(unsigned long inCount);

/// Generated from method `JPH::Double3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Double3_void_ptr(void *inPointer);

/// Generated from method `JPH::Double3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Double3_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Double3::operator new`.
JOLT_API void *Jolt_new_JPH_Double3_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Double3::operator delete`.
JOLT_API void Jolt_delete_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Double3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Double3_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Double3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Double3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_Double3_index(const JPH_Double3 *_this, int inCoordinate);

/// Generated from method `JPH::Double3::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Double3(const JPH_Double3 *_this, const JPH_Double3 *inRHS);

/// Generated from method `JPH::Double3::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Double3(const JPH_Double3 *_this, const JPH_Double3 *inRHS);

#ifdef __cplusplus
} // extern "C"
#endif
