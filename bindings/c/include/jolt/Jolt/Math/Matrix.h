// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Vector_2 JPH_Vector_2; // Defined in `#include <jolt/Jolt/Math/Vector.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Templatized matrix class
/// Generated from class `JPH::Matrix<2, 2>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Matrix_2_2 JPH_Matrix_2_2;

///< Column
/// Returns a pointer to a member variable of class `JPH::Matrix<2, 2>` named `mCol`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vector_2 *JPH_Matrix_2_2_Get_mCol(const JPH_Matrix_2_2 *_this);

///< Column
/// Returns a mutable pointer to a member variable of class `JPH::Matrix<2, 2>` named `mCol`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vector_2 *JPH_Matrix_2_2_GetMutable_mCol(JPH_Matrix_2_2 *_this);

/// Returns the size of the array member of class `JPH::Matrix<2, 2>` named `mCol`. The size is `2`.
JOLT_API size_t JPH_Matrix_2_2_GetSize_mCol(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Matrix_2_2_DestroyArray()`.
/// Use `JPH_Matrix_2_2_OffsetMutablePtr()` and `JPH_Matrix_2_2_OffsetPtr()` to access the array elements.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Matrix_2_2 *JPH_Matrix_2_2_OffsetPtr(const JPH_Matrix_2_2 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_OffsetMutablePtr(JPH_Matrix_2_2 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_ConstructFromAnother(Jolt_PassBy inM2_pass_by, JPH_Matrix_2_2 *inM2);

/// Destroys a heap-allocated instance of `JPH_Matrix_2_2`. Does nothing if the pointer is null.
JOLT_API void JPH_Matrix_2_2_Destroy(const JPH_Matrix_2_2 *_this);

/// Destroys a heap-allocated array of `JPH_Matrix_2_2`. Does nothing if the pointer is null.
JOLT_API void JPH_Matrix_2_2_DestroyArray(const JPH_Matrix_2_2 *_this);

/// Assignment
/// Generated from method `JPH::Matrix<2, 2>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_AssignFromAnother(JPH_Matrix_2_2 *_this, Jolt_PassBy inM2_pass_by, JPH_Matrix_2_2 *inM2);

/// Dimensions
/// Generated from method `JPH::Matrix<2, 2>::GetRows`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Matrix_2_2_GetRows(const JPH_Matrix_2_2 *_this);

/// Generated from method `JPH::Matrix<2, 2>::GetCols`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Matrix_2_2_GetCols(const JPH_Matrix_2_2 *_this);

/// Zero matrix
/// Generated from method `JPH::Matrix<2, 2>::SetZero`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Matrix_2_2_SetZero(JPH_Matrix_2_2 *_this);

/// Generated from method `JPH::Matrix<2, 2>::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_sZero(void);

/// Check if this matrix consists of all zeros
/// Generated from method `JPH::Matrix<2, 2>::IsZero`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Matrix_2_2_IsZero(const JPH_Matrix_2_2 *_this);

/// Identity matrix
/// Generated from method `JPH::Matrix<2, 2>::SetIdentity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Matrix_2_2_SetIdentity(JPH_Matrix_2_2 *_this);

/// Generated from method `JPH::Matrix<2, 2>::sIdentity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_sIdentity(void);

/// Check if this matrix is identity
/// Generated from method `JPH::Matrix<2, 2>::IsIdentity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Matrix_2_2_IsIdentity(const JPH_Matrix_2_2 *_this);

/// Diagonal matrix
/// Generated from method `JPH::Matrix<2, 2>::SetDiagonal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Matrix_2_2_SetDiagonal(JPH_Matrix_2_2 *_this, const JPH_Vector_2 *inV);

/// Generated from method `JPH::Matrix<2, 2>::sDiagonal`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_sDiagonal(const JPH_Vector_2 *inV);

/// Get float component by element index
/// Generated from method `JPH::Matrix<2, 2>::operator()`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Matrix_2_2_call(const JPH_Matrix_2_2 *_this, unsigned int inRow, unsigned int inColumn);

/// Generated from method `JPH::Matrix<2, 2>::operator()`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API float *JPH_Matrix_2_2_call_mut(JPH_Matrix_2_2 *_this, unsigned int inRow, unsigned int inColumn);

/// Comparison
/// Generated from method `JPH::Matrix<2, 2>::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM2);

/// Generated from method `JPH::Matrix<2, 2>::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM2);

/// Multiply vector by matrix
/// Generated from method `JPH::Matrix<2, 2>::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vector_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vector_2 *Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2(const JPH_Matrix_2_2 *_this, const JPH_Vector_2 *inV);

/// Multiply matrix with float
/// Generated from method `JPH::Matrix<2, 2>::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *Jolt_mul_JPH_Matrix_2_2_float(const JPH_Matrix_2_2 *_this, float inV);

/// Per element addition of matrix
/// Generated from method `JPH::Matrix<2, 2>::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *Jolt_add_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM);

/// Per element subtraction of matrix
/// Generated from method `JPH::Matrix<2, 2>::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *Jolt_sub_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM);

/// Transpose matrix
/// Generated from method `JPH::Matrix<2, 2>::Transposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_Transposed(const JPH_Matrix_2_2 *_this);

/// Specialization of SetInversed for 2x2 matrix
/// Generated from method `JPH::Matrix<2, 2>::SetInversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
JOLT_API bool JPH_Matrix_2_2_SetInversed(JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM);

/// Generated from method `JPH::Matrix<2, 2>::Inversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *JPH_Matrix_2_2_Inversed(const JPH_Matrix_2_2 *_this);

/// Column access
/// Generated from method `JPH::Matrix<2, 2>::GetColumn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Vector_2 *JPH_Matrix_2_2_GetColumn(const JPH_Matrix_2_2 *_this, int inIdx);

/// Generated from method `JPH::Matrix<2, 2>::GetColumn`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Vector_2 *JPH_Matrix_2_2_GetColumn_mut(JPH_Matrix_2_2 *_this, int inIdx);

/// Generated from function `JPH::operator*`.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Matrix_2_2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Matrix_2_2 *Jolt_mul_float_JPH_Matrix_2_2(float inV, const JPH_Matrix_2_2 *inM);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Matrix_2_2(Jolt_std_ostream *inStream, const JPH_Matrix_2_2 *inM);

#ifdef __cplusplus
} // extern "C"
#endif
