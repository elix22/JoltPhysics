// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Double3 JPH_Double3; // Defined in `#include <jolt/Jolt/Math/Double3.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// 3 component vector of doubles (stored as 4 vectors).
/// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
/// Generated from class `JPH::DVec3`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DVec3 JPH_DVec3;

/// Representations of true and false for boolean operations
/// Returns a pointer to a member variable of class `JPH::DVec3` named `cTrue`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const double *JPH_DVec3_Get_cTrue(void);

/// Returns a pointer to a member variable of class `JPH::DVec3` named `cFalse`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const double *JPH_DVec3_Get_cFalse(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DVec3_DestroyArray()`.
/// Use `JPH_DVec3_OffsetMutablePtr()` and `JPH_DVec3_OffsetPtr()` to access the array elements.
JOLT_API JPH_DVec3 *JPH_DVec3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DVec3 *JPH_DVec3_OffsetPtr(const JPH_DVec3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_OffsetMutablePtr(JPH_DVec3 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::DVec3::DVec3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_ConstructFromAnother(const JPH_DVec3 *inRHS);

// Create a std::hash/JPH::Hash for DVec3
/// Generated from constructor `JPH::DVec3::DVec3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Vec3(const JPH_Vec3 *inRHS);

/// Generated from constructor `JPH::DVec3::DVec3`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Vec4(const JPH_Vec4 *inRHS);

/// Create a vector from 3 components
/// Generated from constructor `JPH::DVec3::DVec3`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Construct_3(double inX, double inY, double inZ);

/// Load 3 doubles from memory
/// Generated from constructor `JPH::DVec3::DVec3`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Double3(const JPH_Double3 *inV);

/// Destroys a heap-allocated instance of `JPH_DVec3`. Does nothing if the pointer is null.
JOLT_API void JPH_DVec3_Destroy(const JPH_DVec3 *_this);

/// Destroys a heap-allocated array of `JPH_DVec3`. Does nothing if the pointer is null.
JOLT_API void JPH_DVec3_DestroyArray(const JPH_DVec3 *_this);

/// Convert to float vector 3 rounding to nearest
/// Generated from conversion operator `JPH::DVec3::operator JPH::Vec3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DVec3_ConvertTo_JPH_Vec3(const JPH_DVec3 *_this);

/// Generated from method `JPH::DVec3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DVec3 *JPH_DVec3_AssignFromAnother(JPH_DVec3 *_this, const JPH_DVec3 *inRHS);

/// Generated from method `JPH::DVec3::operator new`.
JOLT_API void *Jolt_new_JPH_DVec3_size_t(unsigned long inCount);

/// Generated from method `JPH::DVec3::operator delete`.
JOLT_API void Jolt_delete_JPH_DVec3_void_ptr(void *inPointer);

/// Generated from method `JPH::DVec3::operator delete`.
JOLT_API void Jolt_delete_JPH_DVec3_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DVec3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DVec3_size_t(unsigned long inCount);

/// Generated from method `JPH::DVec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DVec3_void_ptr(void *inPointer);

/// Generated from method `JPH::DVec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DVec3_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DVec3::operator new`.
JOLT_API void *Jolt_new_JPH_DVec3_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DVec3::operator delete`.
JOLT_API void Jolt_delete_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DVec3::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DVec3_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DVec3::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Vector with all zeros
/// Generated from method `JPH::DVec3::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sZero(void);

/// Vector with all ones
/// Generated from method `JPH::DVec3::sOne`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sOne(void);

/// Vectors with the principal axis
/// Generated from method `JPH::DVec3::sAxisX`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sAxisX(void);

/// Generated from method `JPH::DVec3::sAxisY`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sAxisY(void);

/// Generated from method `JPH::DVec3::sAxisZ`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sAxisZ(void);

/// Replicate inV across all components
/// Generated from method `JPH::DVec3::sReplicate`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sReplicate(double inV);

/// Vector with all NaN's
/// Generated from method `JPH::DVec3::sNaN`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sNaN(void);

/// Load 3 doubles from memory (reads 64 bits extra which it doesn't use)
/// Generated from method `JPH::DVec3::sLoadDouble3Unsafe`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sLoadDouble3Unsafe(const JPH_Double3 *inV);

/// Store 3 doubles to memory
/// Generated from method `JPH::DVec3::StoreDouble3`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_StoreDouble3(const JPH_DVec3 *_this, JPH_Double3 *outV);

/// Prepare to convert to float vector 3 rounding towards zero (returns DVec3 that can be converted to a Vec3 to get the rounding)
/// Generated from method `JPH::DVec3::PrepareRoundToZero`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_PrepareRoundToZero(const JPH_DVec3 *_this);

/// Prepare to convert to float vector 3 rounding towards positive/negative inf (returns DVec3 that can be converted to a Vec3 to get the rounding)
/// Generated from method `JPH::DVec3::PrepareRoundToInf`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_PrepareRoundToInf(const JPH_DVec3 *_this);

/// Convert to float vector 3 rounding down
/// Generated from method `JPH::DVec3::ToVec3RoundDown`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DVec3_ToVec3RoundDown(const JPH_DVec3 *_this);

/// Convert to float vector 3 rounding up
/// Generated from method `JPH::DVec3::ToVec3RoundUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DVec3_ToVec3RoundUp(const JPH_DVec3 *_this);

/// Return the minimum value of each of the components
/// Generated from method `JPH::DVec3::sMin`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sMin(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Return the maximum of each of the components
/// Generated from method `JPH::DVec3::sMax`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sMax(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Clamp a vector between min and max (component wise)
/// Generated from method `JPH::DVec3::sClamp`.
/// Parameter `inV` can not be null. It is a single object.
/// Parameter `inMin` can not be null. It is a single object.
/// Parameter `inMax` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sClamp(const JPH_DVec3 *inV, const JPH_DVec3 *inMin, const JPH_DVec3 *inMax);

/// Equals (component wise)
/// Generated from method `JPH::DVec3::sEquals`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sEquals(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Less than (component wise)
/// Generated from method `JPH::DVec3::sLess`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sLess(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Less than or equal (component wise)
/// Generated from method `JPH::DVec3::sLessOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sLessOrEqual(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Greater than (component wise)
/// Generated from method `JPH::DVec3::sGreater`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sGreater(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Greater than or equal (component wise)
/// Generated from method `JPH::DVec3::sGreaterOrEqual`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sGreaterOrEqual(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Calculates inMul1 * inMul2 + inAdd
/// Generated from method `JPH::DVec3::sFusedMultiplyAdd`.
/// Parameter `inMul1` can not be null. It is a single object.
/// Parameter `inMul2` can not be null. It is a single object.
/// Parameter `inAdd` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sFusedMultiplyAdd(const JPH_DVec3 *inMul1, const JPH_DVec3 *inMul2, const JPH_DVec3 *inAdd);

/// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
/// Generated from method `JPH::DVec3::sSelect`.
/// Parameter `inNotSet` can not be null. It is a single object.
/// Parameter `inSet` can not be null. It is a single object.
/// Parameter `inControl` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sSelect(const JPH_DVec3 *inNotSet, const JPH_DVec3 *inSet, const JPH_DVec3 *inControl);

/// Logical or (component wise)
/// Generated from method `JPH::DVec3::sOr`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sOr(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Logical xor (component wise)
/// Generated from method `JPH::DVec3::sXor`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sXor(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Logical and (component wise)
/// Generated from method `JPH::DVec3::sAnd`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_sAnd(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2);

/// Store if X is true in bit 0, Y in bit 1, Z in bit 2 and W in bit 3 (true is when highest bit of component is set)
/// Generated from method `JPH::DVec3::GetTrues`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_DVec3_GetTrues(const JPH_DVec3 *_this);

/// Test if any of the components are true (true is when highest bit of component is set)
/// Generated from method `JPH::DVec3::TestAnyTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DVec3_TestAnyTrue(const JPH_DVec3 *_this);

/// Test if all components are true (true is when highest bit of component is set)
/// Generated from method `JPH::DVec3::TestAllTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DVec3_TestAllTrue(const JPH_DVec3 *_this);

/// Generated from method `JPH::DVec3::GetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_GetX(const JPH_DVec3 *_this);

/// Generated from method `JPH::DVec3::GetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_GetY(const JPH_DVec3 *_this);

/// Generated from method `JPH::DVec3::GetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_GetZ(const JPH_DVec3 *_this);

/// Set individual components
/// Generated from method `JPH::DVec3::SetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_SetX(JPH_DVec3 *_this, double inX);

/// Generated from method `JPH::DVec3::SetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_SetY(JPH_DVec3 *_this, double inY);

/// Generated from method `JPH::DVec3::SetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_SetZ(JPH_DVec3 *_this, double inZ);

/// Set all components
/// Generated from method `JPH::DVec3::Set`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_Set(JPH_DVec3 *_this, double inX, double inY, double inZ);

/// Get double component by index
/// Generated from method `JPH::DVec3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_index(const JPH_DVec3 *_this, unsigned int inCoordinate);

/// Set double component by index
/// Generated from method `JPH::DVec3::SetComponent`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_SetComponent(JPH_DVec3 *_this, unsigned int inCoordinate, double inValue);

/// Comparison
/// Generated from method `JPH::DVec3::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Generated from method `JPH::DVec3::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Test if two vectors are close
/// Generated from method `JPH::DVec3::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.9999999999999992e-25`, pass a null pointer to use it.
JOLT_API bool JPH_DVec3_IsClose(const JPH_DVec3 *_this, const JPH_DVec3 *inV2, const double *inMaxDistSq);

/// Test if vector is near zero
/// Generated from method `JPH::DVec3::IsNearZero`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.9999999999999992e-25`, pass a null pointer to use it.
JOLT_API bool JPH_DVec3_IsNearZero(const JPH_DVec3 *_this, const double *inMaxDistSq);

/// Test if vector is normalized
/// Generated from method `JPH::DVec3::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTolerance` has a default argument: `9.9999999999999998e-13`, pass a null pointer to use it.
JOLT_API bool JPH_DVec3_IsNormalized(const JPH_DVec3 *_this, const double *inTolerance);

/// Test if vector contains NaN elements
/// Generated from method `JPH::DVec3::IsNaN`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DVec3_IsNaN(const JPH_DVec3 *_this);

/// Multiply two double vectors (component wise)
/// Generated from method `JPH::DVec3::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_mul_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Multiply vector with double
/// Generated from method `JPH::DVec3::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_mul_JPH_DVec3_double(const JPH_DVec3 *_this, double inV2);

/// Divide vector by double
/// Generated from method `JPH::DVec3::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_div_JPH_DVec3_double(const JPH_DVec3 *_this, double inV2);

/// Multiply vector with double
/// Generated from method `JPH::DVec3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_mul_assign_double(JPH_DVec3 *_this, double inV2);

/// Multiply vector with vector
/// Generated from method `JPH::DVec3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_mul_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Divide vector by double
/// Generated from method `JPH::DVec3::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_div_assign(JPH_DVec3 *_this, double inV2);

/// Add two vectors (component wise)
/// Generated from method `JPH::DVec3::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_add_JPH_DVec3_JPH_Vec3(const JPH_DVec3 *_this, const JPH_Vec3 *inV2);

/// Add two double vectors (component wise)
/// Generated from method `JPH::DVec3::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_add_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Add two vectors (component wise)
/// Generated from method `JPH::DVec3::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_add_assign_JPH_Vec3(JPH_DVec3 *_this, const JPH_Vec3 *inV2);

/// Add two double vectors (component wise)
/// Generated from method `JPH::DVec3::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_add_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Negate
/// Generated from method `JPH::DVec3::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_neg_JPH_DVec3(const JPH_DVec3 *_this);

/// Subtract two vectors (component wise)
/// Generated from method `JPH::DVec3::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_sub_JPH_DVec3_JPH_Vec3(const JPH_DVec3 *_this, const JPH_Vec3 *inV2);

/// Subtract two double vectors (component wise)
/// Generated from method `JPH::DVec3::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_sub_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Subtract two vectors (component wise)
/// Generated from method `JPH::DVec3::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_sub_assign_JPH_Vec3(JPH_DVec3 *_this, const JPH_Vec3 *inV2);

/// Subtract two vectors (component wise)
/// Generated from method `JPH::DVec3::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_DVec3 *JPH_DVec3_sub_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Divide (component wise)
/// Generated from method `JPH::DVec3::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_div_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Return the absolute value of each of the components
/// Generated from method `JPH::DVec3::Abs`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Abs(const JPH_DVec3 *_this);

/// Reciprocal vector (1 / value) for each of the components
/// Generated from method `JPH::DVec3::Reciprocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Reciprocal(const JPH_DVec3 *_this);

/// Cross product
/// Generated from method `JPH::DVec3::Cross`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Cross(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Dot product
/// Generated from method `JPH::DVec3::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API double JPH_DVec3_Dot(const JPH_DVec3 *_this, const JPH_DVec3 *inV2);

/// Squared length of vector
/// Generated from method `JPH::DVec3::LengthSq`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_LengthSq(const JPH_DVec3 *_this);

/// Length of vector
/// Generated from method `JPH::DVec3::Length`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API double JPH_DVec3_Length(const JPH_DVec3 *_this);

/// Normalize vector
/// Generated from method `JPH::DVec3::Normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Normalized(const JPH_DVec3 *_this);

/// Component wise square root
/// Generated from method `JPH::DVec3::Sqrt`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_Sqrt(const JPH_DVec3 *_this);

/// Get vector that contains the sign of each element (returns 1 if positive, -1 if negative)
/// Generated from method `JPH::DVec3::GetSign`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DVec3_GetSign(const JPH_DVec3 *_this);

/// Internal helper function that checks that W is equal to Z, so e.g. dividing by it should not generate div by 0
/// Generated from method `JPH::DVec3::CheckW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DVec3_CheckW(const JPH_DVec3 *_this);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_DVec3(Jolt_std_ostream *inStream, const JPH_DVec3 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
