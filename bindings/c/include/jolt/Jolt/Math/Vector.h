// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Templatized vector class
/// Generated from class `JPH::Vector<2>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Vector_2 JPH_Vector_2;

/// Returns a pointer to a member variable of class `JPH::Vector<2>` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Vector_2_Get_mF32(const JPH_Vector_2 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::Vector<2>` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Vector_2_GetMutable_mF32(JPH_Vector_2 *_this);

/// Returns the size of the array member of class `JPH::Vector<2>` named `mF32`. The size is `2`.
JOLT_API size_t JPH_Vector_2_GetSize_mF32(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_Vector_2_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Vector_2_DestroyArray()`.
/// Use `JPH_Vector_2_OffsetMutablePtr()` and `JPH_Vector_2_OffsetPtr()` to access the array elements.
JOLT_API JPH_Vector_2 *JPH_Vector_2_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Vector_2 *JPH_Vector_2_OffsetPtr(const JPH_Vector_2 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Vector_2 *JPH_Vector_2_OffsetMutablePtr(JPH_Vector_2 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Vector<2>::Vector`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_Vector_2_ConstructFromAnother(const JPH_Vector_2 *_other);

/// Destroys a heap-allocated instance of `JPH_Vector_2`. Does nothing if the pointer is null.
JOLT_API void JPH_Vector_2_Destroy(const JPH_Vector_2 *_this);

/// Destroys a heap-allocated array of `JPH_Vector_2`. Does nothing if the pointer is null.
JOLT_API void JPH_Vector_2_DestroyArray(const JPH_Vector_2 *_this);

/// Assignment
/// Generated from method `JPH::Vector<2>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Vector_2 *JPH_Vector_2_AssignFromAnother(JPH_Vector_2 *_this, const JPH_Vector_2 *_other);

/// Dimensions
/// Generated from method `JPH::Vector<2>::GetRows`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Vector_2_GetRows(const JPH_Vector_2 *_this);

/// Vector with all zeros
/// Generated from method `JPH::Vector<2>::SetZero`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vector_2_SetZero(JPH_Vector_2 *_this);

/// Generated from method `JPH::Vector<2>::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_Vector_2_sZero(void);

/// Get float component by index
/// Generated from method `JPH::Vector<2>::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vector_2_index(const JPH_Vector_2 *_this, unsigned int inCoordinate);

/// Generated from method `JPH::Vector<2>::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API float *JPH_Vector_2_index_mut(JPH_Vector_2 *_this, unsigned int inCoordinate);

/// Comparison
/// Generated from method `JPH::Vector<2>::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Generated from method `JPH::Vector<2>::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Test if vector consists of all zeros
/// Generated from method `JPH::Vector<2>::IsZero`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Vector_2_IsZero(const JPH_Vector_2 *_this);

/// Test if two vectors are close to each other
/// Generated from method `JPH::Vector<2>::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Vector_2_IsClose(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2, const float *inMaxDistSq);

/// Multiply vector with float
/// Generated from method `JPH::Vector<2>::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_mul_JPH_Vector_2_float(const JPH_Vector_2 *_this, float inV2);

/// Generated from method `JPH::Vector<2>::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vector_2 *JPH_Vector_2_mul_assign(JPH_Vector_2 *_this, float inV2);

/// Divide vector by float
/// Generated from method `JPH::Vector<2>::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_div_JPH_Vector_2_float(const JPH_Vector_2 *_this, float inV2);

/// Generated from method `JPH::Vector<2>::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vector_2 *JPH_Vector_2_div_assign(JPH_Vector_2 *_this, float inV2);

/// Add two float vectors (component wise)
/// Generated from method `JPH::Vector<2>::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_add_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Generated from method `JPH::Vector<2>::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vector_2 *JPH_Vector_2_add_assign(JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Negate
/// Generated from method `JPH::Vector<2>::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_neg_JPH_Vector_2(const JPH_Vector_2 *_this);

/// Subtract two float vectors (component wise)
/// Generated from method `JPH::Vector<2>::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_sub_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Generated from method `JPH::Vector<2>::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vector_2 *JPH_Vector_2_sub_assign(JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Dot product
/// Generated from method `JPH::Vector<2>::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API float JPH_Vector_2_Dot(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2);

/// Squared length of vector
/// Generated from method `JPH::Vector<2>::LengthSq`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vector_2_LengthSq(const JPH_Vector_2 *_this);

/// Length of vector
/// Generated from method `JPH::Vector<2>::Length`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vector_2_Length(const JPH_Vector_2 *_this);

/// Check if vector is normalized
/// Generated from method `JPH::Vector<2>::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inToleranceSq` has a default argument: `9.99999997e-7f`, pass a null pointer to use it.
JOLT_API bool JPH_Vector_2_IsNormalized(JPH_Vector_2 *_this, const float *inToleranceSq);

/// Normalize vector
/// Generated from method `JPH::Vector<2>::Normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *JPH_Vector_2_Normalized(const JPH_Vector_2 *_this);

/// Multiply vector with float
/// Generated from function `JPH::operator*`.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_mul_float_JPH_Vector_2(float inV1, const JPH_Vector_2 *inV2);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Vector_2(Jolt_std_ostream *inStream, const JPH_Vector_2 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
