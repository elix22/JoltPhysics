// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Float4 JPH_Float4; // Defined in `#include <jolt/Jolt/Math/Float4.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Holds a 4x4 matrix of floats, but supports also operations on the 3x3 upper left part of the matrix.
/// Generated from class `JPH::Mat44`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Mat44 JPH_Mat44;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Mat44_DestroyArray()`.
/// Use `JPH_Mat44_OffsetMutablePtr()` and `JPH_Mat44_OffsetPtr()` to access the array elements.
JOLT_API JPH_Mat44 *JPH_Mat44_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Mat44 *JPH_Mat44_OffsetPtr(const JPH_Mat44 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Mat44 *JPH_Mat44_OffsetMutablePtr(JPH_Mat44 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Mat44::Mat44`.
/// Parameter `inM2` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_ConstructFromAnother(const JPH_Mat44 *inM2);

/// Generated from constructor `JPH::Mat44::Mat44`.
/// Parameter `inC1` can not be null. It is a single object.
/// Parameter `inC2` can not be null. It is a single object.
/// Parameter `inC3` can not be null. It is a single object.
/// Parameter `inC4` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_Vec4 *inC4);

/// Generated from constructor `JPH::Mat44::Mat44`.
/// Parameter `inC1` can not be null. It is a single object.
/// Parameter `inC2` can not be null. It is a single object.
/// Parameter `inC3` can not be null. It is a single object.
/// Parameter `inC4` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_Vec3 *inC4);

/// Destroys a heap-allocated instance of `JPH_Mat44`. Does nothing if the pointer is null.
JOLT_API void JPH_Mat44_Destroy(const JPH_Mat44 *_this);

/// Destroys a heap-allocated array of `JPH_Mat44`. Does nothing if the pointer is null.
JOLT_API void JPH_Mat44_DestroyArray(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Mat44 *JPH_Mat44_AssignFromAnother(JPH_Mat44 *_this, const JPH_Mat44 *inM2);

/// Generated from method `JPH::Mat44::operator new`.
JOLT_API void *Jolt_new_JPH_Mat44_size_t(unsigned long inCount);

/// Generated from method `JPH::Mat44::operator delete`.
JOLT_API void Jolt_delete_JPH_Mat44_void_ptr(void *inPointer);

/// Generated from method `JPH::Mat44::operator delete`.
JOLT_API void Jolt_delete_JPH_Mat44_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Mat44::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Mat44_size_t(unsigned long inCount);

/// Generated from method `JPH::Mat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Mat44_void_ptr(void *inPointer);

/// Generated from method `JPH::Mat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Mat44_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Mat44::operator new`.
JOLT_API void *Jolt_new_JPH_Mat44_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Mat44::operator delete`.
JOLT_API void Jolt_delete_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Mat44::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Mat44_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Mat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Zero matrix
/// Generated from method `JPH::Mat44::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sZero(void);

/// Identity matrix
/// Generated from method `JPH::Mat44::sIdentity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sIdentity(void);

/// Matrix filled with NaN's
/// Generated from method `JPH::Mat44::sNaN`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sNaN(void);

/// Load 16 floats from memory
/// Generated from method `JPH::Mat44::sLoadFloat4x4`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sLoadFloat4x4(const JPH_Float4 *inV);

/// Load 16 floats from memory, 16 bytes aligned
/// Generated from method `JPH::Mat44::sLoadFloat4x4Aligned`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sLoadFloat4x4Aligned(const JPH_Float4 *inV);

/// Rotate around X, Y or Z axis (angle in radians)
/// Generated from method `JPH::Mat44::sRotationX`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotationX(float inX);

/// Generated from method `JPH::Mat44::sRotationY`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotationY(float inY);

/// Generated from method `JPH::Mat44::sRotationZ`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotationZ(float inZ);

/// Rotate around arbitrary axis
/// Generated from method `JPH::Mat44::sRotation`.
/// Parameter `inAxis` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotation_2(const JPH_Vec3 *inAxis, float inAngle);

/// Rotate from quaternion
/// Generated from method `JPH::Mat44::sRotation`.
/// Parameter `inQuat` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotation_1(const JPH_Quat *inQuat);

/// Get matrix that translates
/// Generated from method `JPH::Mat44::sTranslation`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sTranslation(const JPH_Vec3 *inV);

/// Get matrix that rotates and translates
/// Generated from method `JPH::Mat44::sRotationTranslation`.
/// Parameter `inR` can not be null. It is a single object.
/// Parameter `inT` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sRotationTranslation(const JPH_Quat *inR, const JPH_Vec3 *inT);

/// Get inverse matrix of sRotationTranslation
/// Generated from method `JPH::Mat44::sInverseRotationTranslation`.
/// Parameter `inR` can not be null. It is a single object.
/// Parameter `inT` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sInverseRotationTranslation(const JPH_Quat *inR, const JPH_Vec3 *inT);

/// Get matrix that scales uniformly
/// Generated from method `JPH::Mat44::sScale`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sScale_float(float inScale);

/// Get matrix that scales (produces a matrix with (inV, 1) on its diagonal)
/// Generated from method `JPH::Mat44::sScale`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sScale_JPH_Vec3(const JPH_Vec3 *inV);

/// Get outer product of inV and inV2 (equivalent to \f$inV1 \otimes inV2\f$)
/// Generated from method `JPH::Mat44::sOuterProduct`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sOuterProduct(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2);

/// Get matrix that represents a cross product \f$A \times B = \text{sCrossProduct}(A) \: B\f$
/// Generated from method `JPH::Mat44::sCrossProduct`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sCrossProduct(const JPH_Vec3 *inV);

/// Returns matrix ML so that \f$ML(q) \: p = q \: p\f$ (where p and q are quaternions)
/// Generated from method `JPH::Mat44::sQuatLeftMultiply`.
/// Parameter `inQ` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sQuatLeftMultiply(const JPH_Quat *inQ);

/// Returns matrix MR so that \f$MR(q) \: p = p \: q\f$ (where p and q are quaternions)
/// Generated from method `JPH::Mat44::sQuatRightMultiply`.
/// Parameter `inQ` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sQuatRightMultiply(const JPH_Quat *inQ);

/// Returns a look at matrix that transforms from world space to view space
/// @param inPos Position of the camera
/// @param inTarget Target of the camera
/// @param inUp Up vector
/// Generated from method `JPH::Mat44::sLookAt`.
/// Parameter `inPos` can not be null. It is a single object.
/// Parameter `inTarget` can not be null. It is a single object.
/// Parameter `inUp` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sLookAt(const JPH_Vec3 *inPos, const JPH_Vec3 *inTarget, const JPH_Vec3 *inUp);

/// Returns a right-handed perspective projection matrix
/// Generated from method `JPH::Mat44::sPerspective`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_sPerspective(float inFovY, float inAspect, float inNear, float inFar);

/// Get float component by element index
/// Generated from method `JPH::Mat44::operator()`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Mat44_call(const JPH_Mat44 *_this, unsigned int inRow, unsigned int inColumn);

/// Generated from method `JPH::Mat44::operator()`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API float *JPH_Mat44_call_mut(JPH_Mat44 *_this, unsigned int inRow, unsigned int inColumn);

/// Comparison
/// Generated from method `JPH::Mat44::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM2);

/// Generated from method `JPH::Mat44::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM2);

/// Test if two matrices are close
/// Generated from method `JPH::Mat44::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Mat44_IsClose(const JPH_Mat44 *_this, const JPH_Mat44 *inM2, const float *inMaxDistSq);

/// Multiply matrix by matrix
/// Generated from method `JPH::Mat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_mul_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Multiply vector by matrix
/// Generated from method `JPH::Mat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_mul_JPH_Mat44_JPH_Vec3(const JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *Jolt_mul_JPH_Mat44_JPH_Vec4(const JPH_Mat44 *_this, const JPH_Vec4 *inV);

/// Multiply vector by only 3x3 part of the matrix
/// Generated from method `JPH::Mat44::Multiply3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_Multiply3x3_JPH_Vec3(const JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Multiply vector by only 3x3 part of the transpose of the matrix (\f$result = this^T \: inV\f$)
/// Generated from method `JPH::Mat44::Multiply3x3Transposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_Multiply3x3Transposed(const JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Multiply 3x3 matrix by 3x3 matrix
/// Generated from method `JPH::Mat44::Multiply3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Multiply3x3_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Multiply transpose of 3x3 matrix by 3x3 matrix (\f$result = this^T \: inM\f$)
/// Generated from method `JPH::Mat44::Multiply3x3LeftTransposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Multiply3x3LeftTransposed(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Multiply 3x3 matrix by the transpose of a 3x3 matrix (\f$result = this \: inM^T\f$)
/// Generated from method `JPH::Mat44::Multiply3x3RightTransposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Multiply3x3RightTransposed(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Multiply matrix with float
/// Generated from method `JPH::Mat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_mul_JPH_Mat44_float(const JPH_Mat44 *_this, float inV);

/// Multiply matrix with float
/// Generated from method `JPH::Mat44::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Mat44 *JPH_Mat44_mul_assign(JPH_Mat44 *_this, float inV);

/// Per element addition of matrix
/// Generated from method `JPH::Mat44::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_add_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Negate
/// Generated from method `JPH::Mat44::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_neg_JPH_Mat44(const JPH_Mat44 *_this);

/// Per element subtraction of matrix
/// Generated from method `JPH::Mat44::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_sub_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Per element addition of matrix
/// Generated from method `JPH::Mat44::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
JOLT_API JPH_Mat44 *JPH_Mat44_add_assign(JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Access to the columns
/// Generated from method `JPH::Mat44::GetAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetAxisX(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetAxisX(JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetAxisY(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetAxisY(JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetAxisZ(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetAxisZ(JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetTranslation(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetTranslation(JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetDiagonal3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetDiagonal3(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetDiagonal3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetDiagonal3(JPH_Mat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetDiagonal4`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Mat44_GetDiagonal4(const JPH_Mat44 *_this);

/// Generated from method `JPH::Mat44::SetDiagonal4`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetDiagonal4(JPH_Mat44 *_this, const JPH_Vec4 *inV);

/// Generated from method `JPH::Mat44::GetColumn3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Mat44_GetColumn3(const JPH_Mat44 *_this, unsigned int inCol);

/// Generated from method `JPH::Mat44::SetColumn3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetColumn3(JPH_Mat44 *_this, unsigned int inCol, const JPH_Vec3 *inV);

/// Generated from method `JPH::Mat44::GetColumn4`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Mat44_GetColumn4(const JPH_Mat44 *_this, unsigned int inCol);

/// Generated from method `JPH::Mat44::SetColumn4`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetColumn4(JPH_Mat44 *_this, unsigned int inCol, const JPH_Vec4 *inV);

/// Store matrix to memory
/// Generated from method `JPH::Mat44::StoreFloat4x4`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Mat44_StoreFloat4x4(const JPH_Mat44 *_this, JPH_Float4 *outV);

/// Transpose matrix
/// Generated from method `JPH::Mat44::Transposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Transposed(const JPH_Mat44 *_this);

/// Transpose 3x3 subpart of matrix
/// Generated from method `JPH::Mat44::Transposed3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Transposed3x3(const JPH_Mat44 *_this);

/// Inverse 4x4 matrix
/// Generated from method `JPH::Mat44::Inversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Inversed(const JPH_Mat44 *_this);

/// Inverse 4x4 matrix when it only contains rotation and translation
/// Generated from method `JPH::Mat44::InversedRotationTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_InversedRotationTranslation(const JPH_Mat44 *_this);

/// Get the determinant of a 3x3 matrix
/// Generated from method `JPH::Mat44::GetDeterminant3x3`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Mat44_GetDeterminant3x3(const JPH_Mat44 *_this);

/// Get the adjoint of a 3x3 matrix
/// Generated from method `JPH::Mat44::Adjointed3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Adjointed3x3(const JPH_Mat44 *_this);

/// Inverse 3x3 matrix
/// Generated from method `JPH::Mat44::Inversed3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Inversed3x3(const JPH_Mat44 *_this);

/// *this = inM.Inversed3x3(), returns false if the matrix is singular in which case *this is unchanged
/// Generated from method `JPH::Mat44::SetInversed3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
JOLT_API bool JPH_Mat44_SetInversed3x3(JPH_Mat44 *_this, const JPH_Mat44 *inM);

/// Get rotation part only (note: retains the first 3 values from the bottom row)
/// Generated from method `JPH::Mat44::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_GetRotation(const JPH_Mat44 *_this);

/// Get rotation part only (note: also clears the bottom row)
/// Generated from method `JPH::Mat44::GetRotationSafe`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_GetRotationSafe(const JPH_Mat44 *_this);

/// Updates the rotation part of this matrix (the first 3 columns)
/// Generated from method `JPH::Mat44::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_Mat44_SetRotation(JPH_Mat44 *_this, const JPH_Mat44 *inRotation);

/// Convert to quaternion
/// Generated from method `JPH::Mat44::GetQuaternion`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Mat44_GetQuaternion(const JPH_Mat44 *_this);

/// Get matrix that transforms a direction with the same transform as this matrix (length is not preserved)
/// Generated from method `JPH::Mat44::GetDirectionPreservingMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_GetDirectionPreservingMatrix(const JPH_Mat44 *_this);

/// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
/// Generated from method `JPH::Mat44::PreTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_PreTranslated(const JPH_Mat44 *_this, const JPH_Vec3 *inTranslation);

/// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
/// Generated from method `JPH::Mat44::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_PostTranslated(const JPH_Mat44 *_this, const JPH_Vec3 *inTranslation);

/// Scale a matrix: result = this * Mat44::sScale(inScale)
/// Generated from method `JPH::Mat44::PreScaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_PreScaled(const JPH_Mat44 *_this, const JPH_Vec3 *inScale);

/// Scale a matrix: result = Mat44::sScale(inScale) * this
/// Generated from method `JPH::Mat44::PostScaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_PostScaled(const JPH_Mat44 *_this, const JPH_Vec3 *inScale);

/// Decompose a matrix into a rotation & translation part and into a scale part so that:
/// this = return_value * Mat44::sScale(outScale).
/// This equation only holds when the matrix is orthogonal, if it is not the returned matrix
/// will be made orthogonal using the modified Gram-Schmidt algorithm (see: https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process)
/// Generated from method `JPH::Mat44::Decompose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_Decompose(const JPH_Mat44 *_this, JPH_Vec3 *outScale);

/// In single precision mode just return the matrix itself
/// Generated from method `JPH::Mat44::ToMat44`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Mat44_ToMat44(const JPH_Mat44 *_this);

/// Generated from function `JPH::operator*`.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *Jolt_mul_float_JPH_Mat44(float inV, const JPH_Mat44 *inM);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Mat44(Jolt_std_ostream *inStream, const JPH_Mat44 *inM);

#ifdef __cplusplus
} // extern "C"
#endif
