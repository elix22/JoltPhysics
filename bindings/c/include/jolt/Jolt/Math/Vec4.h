// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Float4 JPH_Float4; // Defined in `#include <jolt/Jolt/Math/Float4.h>`.
typedef struct JPH_UVec4 JPH_UVec4; // Defined in `#include <jolt/Jolt/Math/UVec4.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Generated from class `JPH::Vec4`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Vec4 JPH_Vec4;

/// Returns a pointer to a member variable of class `JPH::Vec4` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Vec4_Get_mF32(const JPH_Vec4 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::Vec4` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Vec4_GetMutable_mF32(JPH_Vec4 *_this);

/// Returns the size of the array member of class `JPH::Vec4` named `mF32`. The size is `4`.
JOLT_API size_t JPH_Vec4_GetSize_mF32(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Vec4_DestroyArray()`.
/// Use `JPH_Vec4_OffsetMutablePtr()` and `JPH_Vec4_OffsetPtr()` to access the array elements.
JOLT_API JPH_Vec4 *JPH_Vec4_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Vec4 *JPH_Vec4_OffsetPtr(const JPH_Vec4 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_OffsetMutablePtr(JPH_Vec4 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Vec4::Vec4`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_ConstructFromAnother(const JPH_Vec4 *inRHS);

// Constructor
/// Generated from constructor `JPH::Vec4::Vec4`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Construct_1_JPH_Vec3(const JPH_Vec3 *inRHS);

/// Generated from constructor `JPH::Vec4::Vec4`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Construct_2(const JPH_Vec3 *inRHS, float inW);

/// Create a vector from 4 components
/// Generated from constructor `JPH::Vec4::Vec4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Construct_4(float inX, float inY, float inZ, float inW);

/// Destroys a heap-allocated instance of `JPH_Vec4`. Does nothing if the pointer is null.
JOLT_API void JPH_Vec4_Destroy(const JPH_Vec4 *_this);

/// Destroys a heap-allocated array of `JPH_Vec4`. Does nothing if the pointer is null.
JOLT_API void JPH_Vec4_DestroyArray(const JPH_Vec4 *_this);

/// Generated from method `JPH::Vec4::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Vec4 *JPH_Vec4_AssignFromAnother(JPH_Vec4 *_this, const JPH_Vec4 *inRHS);

/// Generated from method `JPH::Vec4::operator new`.
JOLT_API void *Jolt_new_JPH_Vec4_size_t(size_t inCount);

/// Generated from method `JPH::Vec4::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec4_void_ptr(void *inPointer);

/// Generated from method `JPH::Vec4::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec4_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Vec4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Vec4_size_t(size_t inCount);

/// Generated from method `JPH::Vec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec4_void_ptr(void *inPointer);

/// Generated from method `JPH::Vec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec4_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Vec4::operator new`.
JOLT_API void *Jolt_new_JPH_Vec4_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Vec4::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Vec4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Vec4_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Vec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Vector with all zeros
/// Generated from method `JPH::Vec4::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sZero(void);

/// Vector with all ones
/// Generated from method `JPH::Vec4::sOne`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sOne(void);

/// Vector with all NaN's
/// Generated from method `JPH::Vec4::sNaN`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sNaN(void);

/// Replicate inV across all components
/// Generated from method `JPH::Vec4::sReplicate`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sReplicate(float inV);

/// Load 4 floats from memory
/// Generated from method `JPH::Vec4::sLoadFloat4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sLoadFloat4(const JPH_Float4 *inV);

/// Load 4 floats from memory, 16 bytes aligned
/// Generated from method `JPH::Vec4::sLoadFloat4Aligned`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sLoadFloat4Aligned(const JPH_Float4 *inV);

/// Return the minimum value of each of the components
/// Generated from method `JPH::Vec4::sMin`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sMin(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Return the maximum of each of the components
/// Generated from method `JPH::Vec4::sMax`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sMax(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Clamp a vector between min and max (component wise)
/// Generated from method `JPH::Vec4::sClamp`.
/// Parameter `inV` can not be null. It is a single object.
/// Parameter `inMin` can not be null. It is a single object.
/// Parameter `inMax` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sClamp(const JPH_Vec4 *inV, const JPH_Vec4 *inMin, const JPH_Vec4 *inMax);

/// Equals (component wise)
/// Generated from method `JPH::Vec4::sEquals`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_sEquals(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Less than (component wise)
/// Generated from method `JPH::Vec4::sLess`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_sLess(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Less than or equal (component wise)
/// Generated from method `JPH::Vec4::sLessOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_sLessOrEqual(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Greater than (component wise)
/// Generated from method `JPH::Vec4::sGreater`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_sGreater(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Greater than or equal (component wise)
/// Generated from method `JPH::Vec4::sGreaterOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_sGreaterOrEqual(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Calculates inMul1 * inMul2 + inAdd
/// Generated from method `JPH::Vec4::sFusedMultiplyAdd`.
/// Parameter `inMul1` can not be null. It is a single object.
/// Parameter `inMul2` can not be null. It is a single object.
/// Parameter `inAdd` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sFusedMultiplyAdd(const JPH_Vec4 *inMul1, const JPH_Vec4 *inMul2, const JPH_Vec4 *inAdd);

/// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
/// Generated from method `JPH::Vec4::sSelect`.
/// Parameter `inNotSet` can not be null. It is a single object.
/// Parameter `inSet` can not be null. It is a single object.
/// Parameter `inControl` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sSelect(const JPH_Vec4 *inNotSet, const JPH_Vec4 *inSet, const JPH_UVec4 *inControl);

/// Logical or (component wise)
/// Generated from method `JPH::Vec4::sOr`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sOr(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Logical xor (component wise)
/// Generated from method `JPH::Vec4::sXor`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sXor(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Logical and (component wise)
/// Generated from method `JPH::Vec4::sAnd`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sAnd(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2);

/// Sort the four elements of ioValue and sort ioIndex at the same time.
/// Based on a sorting network: http://en.wikipedia.org/wiki/Sorting_network
/// Generated from method `JPH::Vec4::sSort4`.
/// Parameter `ioValue` can not be null. It is a single object.
/// Parameter `ioIndex` can not be null. It is a single object.
JOLT_API void JPH_Vec4_sSort4(JPH_Vec4 *ioValue, JPH_UVec4 *ioIndex);

/// Reverse sort the four elements of ioValue (highest first) and sort ioIndex at the same time.
/// Based on a sorting network: http://en.wikipedia.org/wiki/Sorting_network
/// Generated from method `JPH::Vec4::sSort4Reverse`.
/// Parameter `ioValue` can not be null. It is a single object.
/// Parameter `ioIndex` can not be null. It is a single object.
JOLT_API void JPH_Vec4_sSort4Reverse(JPH_Vec4 *ioValue, JPH_UVec4 *ioIndex);

/// Generated from method `JPH::Vec4::GetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_GetX(const JPH_Vec4 *_this);

/// Generated from method `JPH::Vec4::GetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_GetY(const JPH_Vec4 *_this);

/// Generated from method `JPH::Vec4::GetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_GetZ(const JPH_Vec4 *_this);

/// Generated from method `JPH::Vec4::GetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_GetW(const JPH_Vec4 *_this);

/// Set individual components
/// Generated from method `JPH::Vec4::SetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_SetX(JPH_Vec4 *_this, float inX);

/// Generated from method `JPH::Vec4::SetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_SetY(JPH_Vec4 *_this, float inY);

/// Generated from method `JPH::Vec4::SetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_SetZ(JPH_Vec4 *_this, float inZ);

/// Generated from method `JPH::Vec4::SetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_SetW(JPH_Vec4 *_this, float inW);

/// Set all components
/// Generated from method `JPH::Vec4::Set`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_Set(JPH_Vec4 *_this, float inX, float inY, float inZ, float inW);

/// Get float component by index
/// Generated from method `JPH::Vec4::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_index(const JPH_Vec4 *_this, unsigned int inCoordinate);

/// Generated from method `JPH::Vec4::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API float *JPH_Vec4_index_mut(JPH_Vec4 *_this, unsigned int inCoordinate);

/// Comparison
/// Generated from method `JPH::Vec4::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Generated from method `JPH::Vec4::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Test if two vectors are close
/// Generated from method `JPH::Vec4::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec4_IsClose(const JPH_Vec4 *_this, const JPH_Vec4 *inV2, const float *inMaxDistSq);

/// Test if vector is near zero
/// Generated from method `JPH::Vec4::IsNearZero`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec4_IsNearZero(const JPH_Vec4 *_this, const float *inMaxDistSq);

/// Test if vector is normalized
/// Generated from method `JPH::Vec4::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTolerance` has a default argument: `9.99999997e-7f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec4_IsNormalized(const JPH_Vec4 *_this, const float *inTolerance);

/// Test if vector contains NaN elements
/// Generated from method `JPH::Vec4::IsNaN`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Vec4_IsNaN(const JPH_Vec4 *_this);

/// Multiply two float vectors (component wise)
/// Generated from method `JPH::Vec4::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_mul_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Multiply vector with float
/// Generated from method `JPH::Vec4::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_mul_JPH_Vec4_float(const JPH_Vec4 *_this, float inV2);

/// Divide vector by float
/// Generated from method `JPH::Vec4::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_div_JPH_Vec4_float(const JPH_Vec4 *_this, float inV2);

/// Multiply vector with float
/// Generated from method `JPH::Vec4::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_mul_assign_float(JPH_Vec4 *_this, float inV2);

/// Multiply vector with vector
/// Generated from method `JPH::Vec4::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_mul_assign_JPH_Vec4(JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Divide vector by float
/// Generated from method `JPH::Vec4::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_div_assign(JPH_Vec4 *_this, float inV2);

/// Add two float vectors (component wise)
/// Generated from method `JPH::Vec4::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_add_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Add two float vectors (component wise)
/// Generated from method `JPH::Vec4::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_add_assign(JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Negate
/// Generated from method `JPH::Vec4::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_neg_JPH_Vec4(const JPH_Vec4 *_this);

/// Subtract two float vectors (component wise)
/// Generated from method `JPH::Vec4::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_sub_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Subtract two float vectors (component wise)
/// Generated from method `JPH::Vec4::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec4 *JPH_Vec4_sub_assign(JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Divide (component wise)
/// Generated from method `JPH::Vec4::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_div_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<2, 3, 0, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_2_3_0_1(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 0, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_0_3_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<0, 2, 1, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_0_2_1_3(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 2, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_2_3_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<2, 2, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_2_2_2_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<3, 0, 1, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_3_0_1_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<0, 3, 1, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_0_3_1_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<0, 1, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_0_1_3_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<3, 2, 1, 0>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_3_2_1_0(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<2, 0, 1, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_2_0_1_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 2, 0, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_2_0_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 0, 0, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_0_0_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<3, 2, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_3_2_3_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<2, 3, 1, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_2_3_1_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<2, 2, 1, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_2_2_1_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 3, 0, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_3_0_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<3, 0, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_3_0_3_2(const JPH_Vec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec4::Swizzle<1, 1, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Swizzle_1_1_2_2(const JPH_Vec4 *_this);

/// Replicate the X component to all components
/// Generated from method `JPH::Vec4::SplatX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_SplatX(const JPH_Vec4 *_this);

/// Replicate the Y component to all components
/// Generated from method `JPH::Vec4::SplatY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_SplatY(const JPH_Vec4 *_this);

/// Replicate the Z component to all components
/// Generated from method `JPH::Vec4::SplatZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_SplatZ(const JPH_Vec4 *_this);

/// Replicate the W component to all components
/// Generated from method `JPH::Vec4::SplatW`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_SplatW(const JPH_Vec4 *_this);

/// Replicate the X component to all components
/// Generated from method `JPH::Vec4::SplatX3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec4_SplatX3(const JPH_Vec4 *_this);

/// Replicate the Y component to all components
/// Generated from method `JPH::Vec4::SplatY3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec4_SplatY3(const JPH_Vec4 *_this);

/// Replicate the Z component to all components
/// Generated from method `JPH::Vec4::SplatZ3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec4_SplatZ3(const JPH_Vec4 *_this);

/// Replicate the W component to all components
/// Generated from method `JPH::Vec4::SplatW3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec4_SplatW3(const JPH_Vec4 *_this);

/// Get index of component with lowest value
/// Generated from method `JPH::Vec4::GetLowestComponentIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Vec4_GetLowestComponentIndex(const JPH_Vec4 *_this);

/// Get index of component with highest value
/// Generated from method `JPH::Vec4::GetHighestComponentIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Vec4_GetHighestComponentIndex(const JPH_Vec4 *_this);

/// Return the absolute value of each of the components
/// Generated from method `JPH::Vec4::Abs`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Abs(const JPH_Vec4 *_this);

/// Reciprocal vector (1 / value) for each of the components
/// Generated from method `JPH::Vec4::Reciprocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Reciprocal(const JPH_Vec4 *_this);

/// Dot product, returns the dot product in X, Y, Z and W components
/// Generated from method `JPH::Vec4::DotV`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_DotV(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Dot product
/// Generated from method `JPH::Vec4::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API float JPH_Vec4_Dot(const JPH_Vec4 *_this, const JPH_Vec4 *inV2);

/// Squared length of vector
/// Generated from method `JPH::Vec4::LengthSq`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_LengthSq(const JPH_Vec4 *_this);

/// Length of vector
/// Generated from method `JPH::Vec4::Length`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_Length(const JPH_Vec4 *_this);

/// Normalize vector
/// Generated from method `JPH::Vec4::Normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Normalized(const JPH_Vec4 *_this);

/// Store 4 floats to memory
/// Generated from method `JPH::Vec4::StoreFloat4`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec4_StoreFloat4(const JPH_Vec4 *_this, JPH_Float4 *outV);

/// Convert each component from a float to an int
/// Generated from method `JPH::Vec4::ToInt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_ToInt(const JPH_Vec4 *_this);

/// Reinterpret Vec4 as a UVec4 (doesn't change the bits)
/// Generated from method `JPH::Vec4::ReinterpretAsInt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec4_ReinterpretAsInt(const JPH_Vec4 *_this);

/// Store if X is negative in bit 0, Y in bit 1, Z in bit 2 and W in bit 3
/// Generated from method `JPH::Vec4::GetSignBits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Vec4_GetSignBits(const JPH_Vec4 *_this);

/// Get the minimum of X, Y, Z and W
/// Generated from method `JPH::Vec4::ReduceMin`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_ReduceMin(const JPH_Vec4 *_this);

/// Get the maximum of X, Y, Z and W
/// Generated from method `JPH::Vec4::ReduceMax`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec4_ReduceMax(const JPH_Vec4 *_this);

/// Component wise square root
/// Generated from method `JPH::Vec4::Sqrt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Sqrt(const JPH_Vec4 *_this);

/// Get vector that contains the sign of each element (returns 1.0f if positive, -1.0f if negative)
/// Generated from method `JPH::Vec4::GetSign`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_GetSign(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<-1, -1, -1, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<1, -1, 1, -1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_1_sub_1_1_sub_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<1, 1, -1, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_1_1_sub_1_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<-1, 1, 1, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_1_1_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<1, -1, 1, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_1_sub_1_1_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<1, 1, -1, -1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_1_1_sub_1_sub_1(const JPH_Vec4 *_this);

/// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
/// Generated from method `JPH::Vec4::FlipSign<-1, 1, 1, -1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_1_1_sub_1(const JPH_Vec4 *_this);

/// Calculate the sine and cosine for each element of this vector (input in radians)
/// Generated from method `JPH::Vec4::SinCos`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outSin` can not be null. It is a single object.
/// Parameter `outCos` can not be null. It is a single object.
JOLT_API void JPH_Vec4_SinCos(const JPH_Vec4 *_this, JPH_Vec4 *outSin, JPH_Vec4 *outCos);

/// Calculate the tangent for each element of this vector (input in radians)
/// Generated from method `JPH::Vec4::Tan`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_Tan(const JPH_Vec4 *_this);

/// Calculate the arc sine for each element of this vector (returns value in the range [-PI / 2, PI / 2])
/// Note that all input values will be clamped to the range [-1, 1] and this function will not return NaNs like std::asin
/// Generated from method `JPH::Vec4::ASin`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_ASin(const JPH_Vec4 *_this);

/// Calculate the arc cosine for each element of this vector (returns value in the range [0, PI])
/// Note that all input values will be clamped to the range [-1, 1] and this function will not return NaNs like std::acos
/// Generated from method `JPH::Vec4::ACos`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_ACos(const JPH_Vec4 *_this);

/// Calculate the arc tangent for each element of this vector (returns value in the range [-PI / 2, PI / 2])
/// Generated from method `JPH::Vec4::ATan`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_ATan(const JPH_Vec4 *_this);

/// Calculate the arc tangent of y / x using the signs of the arguments to determine the correct quadrant (returns value in the range [-PI, PI])
/// Generated from method `JPH::Vec4::sATan2`.
/// Parameter `inY` can not be null. It is a single object.
/// Parameter `inX` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sATan2(const JPH_Vec4 *inY, const JPH_Vec4 *inX);

/// Compress a unit vector to a 32 bit value, precision is around 0.5 * 10^-3
/// Generated from method `JPH::Vec4::CompressUnitVector`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Vec4_CompressUnitVector(const JPH_Vec4 *_this);

/// Decompress a unit vector from a 32 bit value
/// Generated from method `JPH::Vec4::sDecompressUnitVector`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec4_sDecompressUnitVector(unsigned int inValue);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Vec4(Jolt_std_ostream *inStream, const JPH_Vec4 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
