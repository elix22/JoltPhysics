// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Generated from class `JPH::UVec4`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_UVec4 JPH_UVec4;

/// Returns a pointer to a member variable of class `JPH::UVec4` named `mU32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_UVec4_Get_mU32(const JPH_UVec4 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::UVec4` named `mU32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_UVec4_GetMutable_mU32(JPH_UVec4 *_this);

/// Returns the size of the array member of class `JPH::UVec4` named `mU32`. The size is `4`.
JOLT_API size_t JPH_UVec4_GetSize_mU32(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_UVec4_DestroyArray()`.
/// Use `JPH_UVec4_OffsetMutablePtr()` and `JPH_UVec4_OffsetPtr()` to access the array elements.
JOLT_API JPH_UVec4 *JPH_UVec4_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_UVec4 *JPH_UVec4_OffsetPtr(const JPH_UVec4 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_UVec4 *JPH_UVec4_OffsetMutablePtr(JPH_UVec4 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::UVec4::UVec4`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_ConstructFromAnother(const JPH_UVec4 *inRHS);

/// Create a vector from 4 integer components
/// Generated from constructor `JPH::UVec4::UVec4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Construct_4(unsigned int inX, unsigned int inY, unsigned int inZ, unsigned int inW);

/// Destroys a heap-allocated instance of `JPH_UVec4`. Does nothing if the pointer is null.
JOLT_API void JPH_UVec4_Destroy(const JPH_UVec4 *_this);

/// Destroys a heap-allocated array of `JPH_UVec4`. Does nothing if the pointer is null.
JOLT_API void JPH_UVec4_DestroyArray(const JPH_UVec4 *_this);

/// Generated from method `JPH::UVec4::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_UVec4 *JPH_UVec4_AssignFromAnother(JPH_UVec4 *_this, const JPH_UVec4 *inRHS);

/// Generated from method `JPH::UVec4::operator new`.
JOLT_API void *Jolt_new_JPH_UVec4_size_t(size_t inCount);

/// Generated from method `JPH::UVec4::operator delete`.
JOLT_API void Jolt_delete_JPH_UVec4_void_ptr(void *inPointer);

/// Generated from method `JPH::UVec4::operator delete`.
JOLT_API void Jolt_delete_JPH_UVec4_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::UVec4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_UVec4_size_t(size_t inCount);

/// Generated from method `JPH::UVec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_UVec4_void_ptr(void *inPointer);

/// Generated from method `JPH::UVec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_UVec4_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::UVec4::operator new`.
JOLT_API void *Jolt_new_JPH_UVec4_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::UVec4::operator delete`.
JOLT_API void Jolt_delete_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::UVec4::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_UVec4_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::UVec4::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Comparison
/// Generated from method `JPH::UVec4::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Generated from method `JPH::UVec4::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 1, 3, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_1_3_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 2, 3, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_2_3_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<1, 2, 3, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_1_2_3_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<1, 2, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_1_2_2_2(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 2, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_2_2_2(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<2, 3, 0, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_2_3_0_1(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<2, 3, 2, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_2_3_2_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<1, 0, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_1_0_3_2(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<1, 1, 3, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_1_1_3_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 2, 1, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_2_1_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 2, 2, 3>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_2_2_3(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<1, 2, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_1_2_3_2(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 2, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_2_3_2(const JPH_UVec4 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::UVec4::Swizzle<0, 1, 3, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Swizzle_0_1_3_2(const JPH_UVec4 *_this);

/// Vector with all zeros
/// Generated from method `JPH::UVec4::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sZero(void);

/// Replicate int inV across all components
/// Generated from method `JPH::UVec4::sReplicate`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sReplicate(unsigned int inV);

/// Load 1 int from memory and place it in the X component, zeros Y, Z and W
/// Generated from method `JPH::UVec4::sLoadInt`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sLoadInt(const unsigned int *inV);

/// Load 4 ints from memory
/// Generated from method `JPH::UVec4::sLoadInt4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sLoadInt4(const unsigned int *inV);

/// Load 4 ints from memory, aligned to 16 bytes
/// Generated from method `JPH::UVec4::sLoadInt4Aligned`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sLoadInt4Aligned(const unsigned int *inV);

/// Return the minimum value of each of the components
/// Generated from method `JPH::UVec4::sMin`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sMin(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Return the maximum of each of the components
/// Generated from method `JPH::UVec4::sMax`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sMax(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Equals (component wise)
/// Generated from method `JPH::UVec4::sEquals`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sEquals(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
/// Generated from method `JPH::UVec4::sSelect`.
/// Parameter `inNotSet` can not be null. It is a single object.
/// Parameter `inSet` can not be null. It is a single object.
/// Parameter `inControl` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sSelect(const JPH_UVec4 *inNotSet, const JPH_UVec4 *inSet, const JPH_UVec4 *inControl);

/// Logical or (component wise)
/// Generated from method `JPH::UVec4::sOr`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sOr(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Logical xor (component wise)
/// Generated from method `JPH::UVec4::sXor`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sXor(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Logical and (component wise)
/// Generated from method `JPH::UVec4::sAnd`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sAnd(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2);

/// Logical not (component wise)
/// Generated from method `JPH::UVec4::sNot`.
/// Parameter `inV1` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sNot(const JPH_UVec4 *inV1);

/// Sorts the elements in inIndex so that the values that correspond to trues in inValue are the first elements.
/// The remaining elements will be set to inValue.w.
/// I.e. if inValue = (true, false, true, false) and inIndex = (1, 2, 3, 4) the function returns (1, 3, 4, 4).
/// Generated from method `JPH::UVec4::sSort4True`.
/// Parameter `inValue` can not be null. It is a single object.
/// Parameter `inIndex` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_sSort4True(const JPH_UVec4 *inValue, const JPH_UVec4 *inIndex);

/// Generated from method `JPH::UVec4::GetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_GetX(const JPH_UVec4 *_this);

/// Generated from method `JPH::UVec4::GetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_GetY(const JPH_UVec4 *_this);

/// Generated from method `JPH::UVec4::GetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_GetZ(const JPH_UVec4 *_this);

/// Generated from method `JPH::UVec4::GetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_GetW(const JPH_UVec4 *_this);

/// Set individual components
/// Generated from method `JPH::UVec4::SetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_SetX(JPH_UVec4 *_this, unsigned int inX);

/// Generated from method `JPH::UVec4::SetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_SetY(JPH_UVec4 *_this, unsigned int inY);

/// Generated from method `JPH::UVec4::SetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_SetZ(JPH_UVec4 *_this, unsigned int inZ);

/// Generated from method `JPH::UVec4::SetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_SetW(JPH_UVec4 *_this, unsigned int inW);

/// Get component by index
/// Generated from method `JPH::UVec4::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_index(const JPH_UVec4 *_this, unsigned int inCoordinate);

/// Generated from method `JPH::UVec4::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API unsigned int *JPH_UVec4_index_mut(JPH_UVec4 *_this, unsigned int inCoordinate);

/// Component wise multiplication of two integer vectors (stores low 32 bits of result only)
/// Generated from method `JPH::UVec4::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *Jolt_mul_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Add two integer vectors (component wise)
/// Generated from method `JPH::UVec4::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *Jolt_add_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Add two integer vectors (component wise)
/// Generated from method `JPH::UVec4::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_UVec4 *JPH_UVec4_add_assign(JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Subtract two integer vectors (component wise)
/// Generated from method `JPH::UVec4::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *Jolt_sub_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Subtract two integer vectors (component wise)
/// Generated from method `JPH::UVec4::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_UVec4 *JPH_UVec4_sub_assign(JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Replicate the X component to all components
/// Generated from method `JPH::UVec4::SplatX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_SplatX(const JPH_UVec4 *_this);

/// Replicate the Y component to all components
/// Generated from method `JPH::UVec4::SplatY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_SplatY(const JPH_UVec4 *_this);

/// Replicate the Z component to all components
/// Generated from method `JPH::UVec4::SplatZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_SplatZ(const JPH_UVec4 *_this);

/// Replicate the W component to all components
/// Generated from method `JPH::UVec4::SplatW`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_SplatW(const JPH_UVec4 *_this);

/// Convert each component from an int to a float
/// Generated from method `JPH::UVec4::ToFloat`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_UVec4_ToFloat(const JPH_UVec4 *_this);

/// Reinterpret UVec4 as a Vec4 (doesn't change the bits)
/// Generated from method `JPH::UVec4::ReinterpretAsFloat`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_UVec4_ReinterpretAsFloat(const JPH_UVec4 *_this);

/// Dot product, returns the dot product in X, Y, Z and W components
/// Generated from method `JPH::UVec4::DotV`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_DotV(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Dot product
/// Generated from method `JPH::UVec4::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API unsigned int JPH_UVec4_Dot(const JPH_UVec4 *_this, const JPH_UVec4 *inV2);

/// Store 4 ints to memory
/// Generated from method `JPH::UVec4::StoreInt4`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_StoreInt4(const JPH_UVec4 *_this, unsigned int *outV);

/// Store 4 ints to memory, aligned to 16 bytes
/// Generated from method `JPH::UVec4::StoreInt4Aligned`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_UVec4_StoreInt4Aligned(const JPH_UVec4 *_this, unsigned int *outV);

/// Test if any of the components are true (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::TestAnyTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_UVec4_TestAnyTrue(const JPH_UVec4 *_this);

/// Test if any of X, Y or Z components are true (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::TestAnyXYZTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_UVec4_TestAnyXYZTrue(const JPH_UVec4 *_this);

/// Test if all components are true (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::TestAllTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_UVec4_TestAllTrue(const JPH_UVec4 *_this);

/// Test if X, Y and Z components are true (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::TestAllXYZTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_UVec4_TestAllXYZTrue(const JPH_UVec4 *_this);

/// Count the number of components that are true (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::CountTrues`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_UVec4_CountTrues(const JPH_UVec4 *_this);

/// Store if X is true in bit 0, Y in bit 1, Z in bit 2 and W in bit 3 (true is when highest bit of component is set)
/// Generated from method `JPH::UVec4::GetTrues`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_UVec4_GetTrues(const JPH_UVec4 *_this);

/// Shift all components by Count bits to the left (filling with zeros from the left)
/// Generated from method `JPH::UVec4::LogicalShiftLeft<31>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_31(const JPH_UVec4 *_this);

/// Shift all components by Count bits to the left (filling with zeros from the left)
/// Generated from method `JPH::UVec4::LogicalShiftLeft<30>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_30(const JPH_UVec4 *_this);

/// Shift all components by Count bits to the left (filling with zeros from the left)
/// Generated from method `JPH::UVec4::LogicalShiftLeft<13>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_13(const JPH_UVec4 *_this);

/// Shift all components by Count bits to the left (filling with zeros from the left)
/// Generated from method `JPH::UVec4::LogicalShiftLeft<16>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_16(const JPH_UVec4 *_this);

/// Shift all components by Count bits to the right (shifting in the value of the highest bit)
/// Generated from method `JPH::UVec4::ArithmeticShiftRight<31>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_ArithmeticShiftRight(const JPH_UVec4 *_this);

/// Takes the lower 4 16 bits and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Uint16Lo`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Uint16Lo(const JPH_UVec4 *_this);

/// Takes the upper 4 16 bits and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Uint16Hi`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Uint16Hi(const JPH_UVec4 *_this);

/// Takes byte 0 .. 3 and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Byte0`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Byte0(const JPH_UVec4 *_this);

/// Takes byte 4 .. 7 and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Byte4`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Byte4(const JPH_UVec4 *_this);

/// Takes byte 8 .. 11 and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Byte8`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Byte8(const JPH_UVec4 *_this);

/// Takes byte 12 .. 15 and expands them to X, Y, Z and W
/// Generated from method `JPH::UVec4::Expand4Byte12`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_Expand4Byte12(const JPH_UVec4 *_this);

/// Shift vector components by 4 - Count floats to the left, so if Count = 1 the resulting vector is (W, 0, 0, 0), when Count = 3 the resulting vector is (Y, Z, W, 0)
/// Generated from method `JPH::UVec4::ShiftComponents4Minus`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_UVec4_ShiftComponents4Minus(const JPH_UVec4 *_this, int inCount);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_UVec4(Jolt_std_ostream *inStream, const JPH_UVec4 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
