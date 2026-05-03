// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_UVec4 JPH_UVec4; // Defined in `#include <jolt/Jolt/Math/UVec4.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// 3 component vector (stored as 4 vectors).
/// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
/// Generated from class `JPH::Vec3`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Vec3 JPH_Vec3;

/// Returns a pointer to a member variable of class `JPH::Vec3` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_Vec3_Get_mF32(const JPH_Vec3 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::Vec3` named `mF32`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_Vec3_GetMutable_mF32(JPH_Vec3 *_this);

/// Returns the size of the array member of class `JPH::Vec3` named `mF32`. The size is `4`.
JOLT_API size_t JPH_Vec3_GetSize_mF32(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Vec3_DestroyArray()`.
/// Use `JPH_Vec3_OffsetMutablePtr()` and `JPH_Vec3_OffsetPtr()` to access the array elements.
JOLT_API JPH_Vec3 *JPH_Vec3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Vec3 *JPH_Vec3_OffsetPtr(const JPH_Vec3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_OffsetMutablePtr(JPH_Vec3 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Vec3::Vec3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_ConstructFromAnother(const JPH_Vec3 *inRHS);

/// Generated from constructor `JPH::Vec3::Vec3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Construct_1_JPH_Vec4(const JPH_Vec4 *inRHS);

/// Load 3 floats from memory
/// Generated from constructor `JPH::Vec3::Vec3`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Construct_1_JPH_Float3(const JPH_Float3 *inV);

/// Create a vector from 3 components
/// Generated from constructor `JPH::Vec3::Vec3`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Construct_3(float inX, float inY, float inZ);

/// Destroys a heap-allocated instance of `JPH_Vec3`. Does nothing if the pointer is null.
JOLT_API void JPH_Vec3_Destroy(const JPH_Vec3 *_this);

/// Destroys a heap-allocated array of `JPH_Vec3`. Does nothing if the pointer is null.
JOLT_API void JPH_Vec3_DestroyArray(const JPH_Vec3 *_this);

/// Generated from method `JPH::Vec3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Vec3 *JPH_Vec3_AssignFromAnother(JPH_Vec3 *_this, const JPH_Vec3 *inRHS);

/// Generated from method `JPH::Vec3::operator new`.
JOLT_API void *Jolt_new_JPH_Vec3_size_t(size_t inCount);

/// Generated from method `JPH::Vec3::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec3_void_ptr(void *inPointer);

/// Generated from method `JPH::Vec3::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec3_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Vec3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Vec3_size_t(size_t inCount);

/// Generated from method `JPH::Vec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec3_void_ptr(void *inPointer);

/// Generated from method `JPH::Vec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec3_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Vec3::operator new`.
JOLT_API void *Jolt_new_JPH_Vec3_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Vec3::operator delete`.
JOLT_API void Jolt_delete_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Vec3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Vec3_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Vec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Vector with all zeros
/// Generated from method `JPH::Vec3::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sZero(void);

/// Vector with all ones
/// Generated from method `JPH::Vec3::sOne`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sOne(void);

/// Vector with all NaN's
/// Generated from method `JPH::Vec3::sNaN`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sNaN(void);

/// Vectors with the principal axis
/// Generated from method `JPH::Vec3::sAxisX`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sAxisX(void);

/// Generated from method `JPH::Vec3::sAxisY`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sAxisY(void);

/// Generated from method `JPH::Vec3::sAxisZ`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sAxisZ(void);

/// Replicate inV across all components
/// Generated from method `JPH::Vec3::sReplicate`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sReplicate(float inV);

/// Load 3 floats from memory (reads 32 bits extra which it doesn't use)
/// Generated from method `JPH::Vec3::sLoadFloat3Unsafe`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sLoadFloat3Unsafe(const JPH_Float3 *inV);

/// Return the minimum value of each of the components
/// Generated from method `JPH::Vec3::sMin`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sMin(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Return the maximum of each of the components
/// Generated from method `JPH::Vec3::sMax`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sMax(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Clamp a vector between min and max (component wise)
/// Generated from method `JPH::Vec3::sClamp`.
/// Parameter `inV` can not be null. It is a single object.
/// Parameter `inMin` can not be null. It is a single object.
/// Parameter `inMax` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sClamp(const JPH_Vec3 *inV, const JPH_Vec3 *inMin, const JPH_Vec3 *inMax);

/// Equals (component wise)
/// Generated from method `JPH::Vec3::sEquals`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_sEquals(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Less than (component wise)
/// Generated from method `JPH::Vec3::sLess`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_sLess(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Less than or equal (component wise)
/// Generated from method `JPH::Vec3::sLessOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_sLessOrEqual(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Greater than (component wise)
/// Generated from method `JPH::Vec3::sGreater`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_sGreater(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Greater than or equal (component wise)
/// Generated from method `JPH::Vec3::sGreaterOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_sGreaterOrEqual(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Calculates inMul1 * inMul2 + inAdd
/// Generated from method `JPH::Vec3::sFusedMultiplyAdd`.
/// Parameter `inMul1` can not be null. It is a single object.
/// Parameter `inMul2` can not be null. It is a single object.
/// Parameter `inAdd` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sFusedMultiplyAdd(const JPH_Vec3 *inMul1, const JPH_Vec3 *inMul2, const JPH_Vec3 *inAdd);

/// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
/// Generated from method `JPH::Vec3::sSelect`.
/// Parameter `inNotSet` can not be null. It is a single object.
/// Parameter `inSet` can not be null. It is a single object.
/// Parameter `inControl` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sSelect(const JPH_Vec3 *inNotSet, const JPH_Vec3 *inSet, const JPH_UVec4 *inControl);

/// Logical or (component wise)
/// Generated from method `JPH::Vec3::sOr`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sOr(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Logical xor (component wise)
/// Generated from method `JPH::Vec3::sXor`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sXor(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Logical and (component wise)
/// Generated from method `JPH::Vec3::sAnd`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sAnd(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Get unit vector given spherical coordinates
/// inTheta \f$\in [0, \pi]\f$ is angle between vector and z-axis
/// inPhi \f$\in [0, 2 \pi]\f$ is the angle in the xy-plane starting from the x axis and rotating counter clockwise around the z-axis
/// Generated from method `JPH::Vec3::sUnitSpherical`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sUnitSpherical(float inTheta, float inPhi);

/// Generated from method `JPH::Vec3::GetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_GetX(const JPH_Vec3 *_this);

/// Generated from method `JPH::Vec3::GetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_GetY(const JPH_Vec3 *_this);

/// Generated from method `JPH::Vec3::GetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_GetZ(const JPH_Vec3 *_this);

/// Set individual components
/// Generated from method `JPH::Vec3::SetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_SetX(JPH_Vec3 *_this, float inX);

/// Generated from method `JPH::Vec3::SetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_SetY(JPH_Vec3 *_this, float inY);

/// Generated from method `JPH::Vec3::SetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_SetZ(JPH_Vec3 *_this, float inZ);

/// Set all components
/// Generated from method `JPH::Vec3::Set`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_Set(JPH_Vec3 *_this, float inX, float inY, float inZ);

/// Get float component by index
/// Generated from method `JPH::Vec3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_index(const JPH_Vec3 *_this, unsigned int inCoordinate);

/// Set float component by index
/// Generated from method `JPH::Vec3::SetComponent`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_SetComponent(JPH_Vec3 *_this, unsigned int inCoordinate, float inValue);

/// Comparison
/// Generated from method `JPH::Vec3::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Generated from method `JPH::Vec3::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Test if two vectors are close
/// Generated from method `JPH::Vec3::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec3_IsClose(const JPH_Vec3 *_this, const JPH_Vec3 *inV2, const float *inMaxDistSq);

/// Test if vector is near zero
/// Generated from method `JPH::Vec3::IsNearZero`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec3_IsNearZero(const JPH_Vec3 *_this, const float *inMaxDistSq);

/// Test if vector is normalized
/// Generated from method `JPH::Vec3::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTolerance` has a default argument: `9.99999997e-7f`, pass a null pointer to use it.
JOLT_API bool JPH_Vec3_IsNormalized(const JPH_Vec3 *_this, const float *inTolerance);

/// Test if vector contains NaN elements
/// Generated from method `JPH::Vec3::IsNaN`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Vec3_IsNaN(const JPH_Vec3 *_this);

/// Multiply two float vectors (component wise)
/// Generated from method `JPH::Vec3::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_mul_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Multiply vector with float
/// Generated from method `JPH::Vec3::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_mul_JPH_Vec3_float(const JPH_Vec3 *_this, float inV2);

/// Divide vector by float
/// Generated from method `JPH::Vec3::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_div_JPH_Vec3_float(const JPH_Vec3 *_this, float inV2);

/// Multiply vector with float
/// Generated from method `JPH::Vec3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_mul_assign_float(JPH_Vec3 *_this, float inV2);

/// Multiply vector with vector
/// Generated from method `JPH::Vec3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_mul_assign_JPH_Vec3(JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Divide vector by float
/// Generated from method `JPH::Vec3::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_div_assign(JPH_Vec3 *_this, float inV2);

/// Add two float vectors (component wise)
/// Generated from method `JPH::Vec3::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_add_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Add two float vectors (component wise)
/// Generated from method `JPH::Vec3::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_add_assign(JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Negate
/// Generated from method `JPH::Vec3::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_neg_JPH_Vec3(const JPH_Vec3 *_this);

/// Subtract two float vectors (component wise)
/// Generated from method `JPH::Vec3::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_sub_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Subtract two float vectors (component wise)
/// Generated from method `JPH::Vec3::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Vec3 *JPH_Vec3_sub_assign(JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Divide (component wise)
/// Generated from method `JPH::Vec3::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_div_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<1, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_1_2_2(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<2, 2, 2>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_2_2_2(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<2, 0, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_2_0_1(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<0, 2, 1>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_0_2_1(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<1, 2, 0>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_1_2_0(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<0, 1, 0>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_0_1_0(const JPH_Vec3 *_this);

/// Swizzle the elements in inV
/// Generated from method `JPH::Vec3::Swizzle<2, 1, 0>`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Swizzle_2_1_0(const JPH_Vec3 *_this);

/// Replicate the X component to all components
/// Generated from method `JPH::Vec3::SplatX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec3_SplatX(const JPH_Vec3 *_this);

/// Replicate the Y component to all components
/// Generated from method `JPH::Vec3::SplatY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec3_SplatY(const JPH_Vec3 *_this);

/// Replicate the Z component to all components
/// Generated from method `JPH::Vec3::SplatZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec3_SplatZ(const JPH_Vec3 *_this);

/// Get index of component with lowest value
/// Generated from method `JPH::Vec3::GetLowestComponentIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Vec3_GetLowestComponentIndex(const JPH_Vec3 *_this);

/// Get index of component with highest value
/// Generated from method `JPH::Vec3::GetHighestComponentIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_Vec3_GetHighestComponentIndex(const JPH_Vec3 *_this);

/// Return the absolute value of each of the components
/// Generated from method `JPH::Vec3::Abs`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Abs(const JPH_Vec3 *_this);

/// Reciprocal vector (1 / value) for each of the components
/// Generated from method `JPH::Vec3::Reciprocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Reciprocal(const JPH_Vec3 *_this);

/// Cross product
/// Generated from method `JPH::Vec3::Cross`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Cross(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Dot product, returns the dot product in X, Y and Z components
/// Generated from method `JPH::Vec3::DotV`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_DotV(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Dot product, returns the dot product in X, Y, Z and W components
/// Generated from method `JPH::Vec3::DotV4`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Vec3_DotV4(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Dot product
/// Generated from method `JPH::Vec3::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API float JPH_Vec3_Dot(const JPH_Vec3 *_this, const JPH_Vec3 *inV2);

/// Squared length of vector
/// Generated from method `JPH::Vec3::LengthSq`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_LengthSq(const JPH_Vec3 *_this);

/// Length of vector
/// Generated from method `JPH::Vec3::Length`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_Length(const JPH_Vec3 *_this);

/// Normalize vector
/// Generated from method `JPH::Vec3::Normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Normalized(const JPH_Vec3 *_this);

/// Normalize vector or return inZeroValue if the length of the vector is zero
/// Generated from method `JPH::Vec3::NormalizedOr`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inZeroValue` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_NormalizedOr(const JPH_Vec3 *_this, const JPH_Vec3 *inZeroValue);

/// Store 3 floats to memory
/// Generated from method `JPH::Vec3::StoreFloat3`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_StoreFloat3(const JPH_Vec3 *_this, JPH_Float3 *outV);

/// Convert each component from a float to an int
/// Generated from method `JPH::Vec3::ToInt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_ToInt(const JPH_Vec3 *_this);

/// Reinterpret Vec3 as a UVec4 (doesn't change the bits)
/// Generated from method `JPH::Vec3::ReinterpretAsInt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_Vec3_ReinterpretAsInt(const JPH_Vec3 *_this);

/// Get the minimum of X, Y and Z
/// Generated from method `JPH::Vec3::ReduceMin`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_ReduceMin(const JPH_Vec3 *_this);

/// Get the maximum of X, Y and Z
/// Generated from method `JPH::Vec3::ReduceMax`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Vec3_ReduceMax(const JPH_Vec3 *_this);

/// Component wise square root
/// Generated from method `JPH::Vec3::Sqrt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_Sqrt(const JPH_Vec3 *_this);

/// Get normalized vector that is perpendicular to this vector
/// Generated from method `JPH::Vec3::GetNormalizedPerpendicular`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_GetNormalizedPerpendicular(const JPH_Vec3 *_this);

/// Get vector that contains the sign of each element (returns 1.0f if positive, -1.0f if negative)
/// Generated from method `JPH::Vec3::GetSign`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_GetSign(const JPH_Vec3 *_this);

/// Compress a unit vector to a 32 bit value, precision is around 10^-4
/// Generated from method `JPH::Vec3::CompressUnitVector`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Vec3_CompressUnitVector(const JPH_Vec3 *_this);

/// Decompress a unit vector from a 32 bit value
/// Generated from method `JPH::Vec3::sDecompressUnitVector`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Vec3_sDecompressUnitVector(unsigned int inValue);

/// Internal helper function that checks that W is equal to Z, so e.g. dividing by it should not generate div by 0
/// Generated from method `JPH::Vec3::CheckW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Vec3_CheckW(const JPH_Vec3 *_this);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Vec3(Jolt_std_ostream *inStream, const JPH_Vec3 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
