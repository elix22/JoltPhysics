// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DVec3 JPH_DVec3; // Defined in `#include <jolt/Jolt/Math/DVec3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Holds a 4x4 matrix of floats with the last column consisting of doubles
/// Generated from class `JPH::DMat44`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DMat44 JPH_DMat44;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DMat44_DestroyArray()`.
/// Use `JPH_DMat44_OffsetMutablePtr()` and `JPH_DMat44_OffsetPtr()` to access the array elements.
JOLT_API JPH_DMat44 *JPH_DMat44_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DMat44 *JPH_DMat44_OffsetPtr(const JPH_DMat44 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DMat44 *JPH_DMat44_OffsetMutablePtr(JPH_DMat44 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::DMat44::DMat44`.
/// Parameter `inM2` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_ConstructFromAnother(const JPH_DMat44 *inM2);

/// Generated from constructor `JPH::DMat44::DMat44`.
/// Parameter `inC1` can not be null. It is a single object.
/// Parameter `inC2` can not be null. It is a single object.
/// Parameter `inC3` can not be null. It is a single object.
/// Parameter `inC4` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_Construct_4_JPH_Vec4(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_DVec3 *inC4);

/// Generated from constructor `JPH::DMat44::DMat44`.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_Construct_1(const JPH_Mat44 *inM);

/// Generated from constructor `JPH::DMat44::DMat44`.
/// Parameter `inRot` can not be null. It is a single object.
/// Parameter `inT` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_Construct_2(const JPH_Mat44 *inRot, const JPH_DVec3 *inT);

/// Destroys a heap-allocated instance of `JPH_DMat44`. Does nothing if the pointer is null.
JOLT_API void JPH_DMat44_Destroy(const JPH_DMat44 *_this);

/// Destroys a heap-allocated array of `JPH_DMat44`. Does nothing if the pointer is null.
JOLT_API void JPH_DMat44_DestroyArray(const JPH_DMat44 *_this);

/// Generated from method `JPH::DMat44::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inM2` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DMat44 *JPH_DMat44_AssignFromAnother(JPH_DMat44 *_this, const JPH_DMat44 *inM2);

/// Generated from method `JPH::DMat44::operator new`.
JOLT_API void *Jolt_new_JPH_DMat44_size_t(unsigned long inCount);

/// Generated from method `JPH::DMat44::operator delete`.
JOLT_API void Jolt_delete_JPH_DMat44_void_ptr(void *inPointer);

/// Generated from method `JPH::DMat44::operator delete`.
JOLT_API void Jolt_delete_JPH_DMat44_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DMat44::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DMat44_size_t(unsigned long inCount);

/// Generated from method `JPH::DMat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DMat44_void_ptr(void *inPointer);

/// Generated from method `JPH::DMat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DMat44_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::DMat44::operator new`.
JOLT_API void *Jolt_new_JPH_DMat44_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DMat44::operator delete`.
JOLT_API void Jolt_delete_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DMat44::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DMat44_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::DMat44::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Zero matrix
/// Generated from method `JPH::DMat44::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sZero(void);

/// Identity matrix
/// Generated from method `JPH::DMat44::sIdentity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sIdentity(void);

/// Rotate from quaternion
/// Generated from method `JPH::DMat44::sRotation`.
/// Parameter `inQuat` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sRotation(const JPH_Quat *inQuat);

/// Get matrix that translates
/// Generated from method `JPH::DMat44::sTranslation`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sTranslation(const JPH_DVec3 *inV);

/// Get matrix that rotates and translates
/// Generated from method `JPH::DMat44::sRotationTranslation`.
/// Parameter `inR` can not be null. It is a single object.
/// Parameter `inT` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sRotationTranslation(const JPH_Quat *inR, const JPH_DVec3 *inT);

/// Get inverse matrix of sRotationTranslation
/// Generated from method `JPH::DMat44::sInverseRotationTranslation`.
/// Parameter `inR` can not be null. It is a single object.
/// Parameter `inT` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sInverseRotationTranslation(const JPH_Quat *inR, const JPH_DVec3 *inT);

/// Get matrix that scales (produces a matrix with (inV, 1) on its diagonal)
/// Generated from method `JPH::DMat44::sScale`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_sScale(const JPH_Vec3 *inV);

/// Convert to Mat44 rounding to nearest
/// Generated from method `JPH::DMat44::ToMat44`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_DMat44_ToMat44(const JPH_DMat44 *_this);

/// Comparison
/// Generated from method `JPH::DMat44::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM2);

/// Generated from method `JPH::DMat44::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM2);

/// Test if two matrices are close
/// Generated from method `JPH::DMat44::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM2` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_DMat44_IsClose(const JPH_DMat44 *_this, const JPH_DMat44 *inM2, const float *inMaxDistSq);

/// Multiply matrix by matrix
/// Generated from method `JPH::DMat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *Jolt_mul_JPH_DMat44_JPH_Mat44(const JPH_DMat44 *_this, const JPH_Mat44 *inM);

/// Multiply matrix by matrix
/// Generated from method `JPH::DMat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *Jolt_mul_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM);

/// Multiply vector by matrix
/// Generated from method `JPH::DMat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_mul_JPH_DMat44_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Multiply vector by matrix
/// Generated from method `JPH::DMat44::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_mul_JPH_DMat44_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inV);

/// Multiply vector by only 3x3 part of the matrix
/// Generated from method `JPH::DMat44::Multiply3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_Multiply3x3_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Multiply vector by only 3x3 part of the matrix
/// Generated from method `JPH::DMat44::Multiply3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DMat44_Multiply3x3_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inV);

/// Multiply vector by only 3x3 part of the transpose of the matrix (\f$result = this^T \: inV\f$)
/// Generated from method `JPH::DMat44::Multiply3x3Transposed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_Multiply3x3Transposed(const JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Scale a matrix: result = this * Mat44::sScale(inScale)
/// Generated from method `JPH::DMat44::PreScaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PreScaled(const JPH_DMat44 *_this, const JPH_Vec3 *inScale);

/// Scale a matrix: result = Mat44::sScale(inScale) * this
/// Generated from method `JPH::DMat44::PostScaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PostScaled(const JPH_DMat44 *_this, const JPH_Vec3 *inScale);

/// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
/// Generated from method `JPH::DMat44::PreTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PreTranslated_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inTranslation);

/// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
/// Generated from method `JPH::DMat44::PreTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PreTranslated_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inTranslation);

/// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
/// Generated from method `JPH::DMat44::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PostTranslated_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inTranslation);

/// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
/// Generated from method `JPH::DMat44::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_PostTranslated_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inTranslation);

/// Access to the columns
/// Generated from method `JPH::DMat44::GetAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_GetAxisX(const JPH_DMat44 *_this);

/// Generated from method `JPH::DMat44::SetAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetAxisX(JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::DMat44::GetAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_GetAxisY(const JPH_DMat44 *_this);

/// Generated from method `JPH::DMat44::SetAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetAxisY(JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::DMat44::GetAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_GetAxisZ(const JPH_DMat44 *_this);

/// Generated from method `JPH::DMat44::SetAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetAxisZ(JPH_DMat44 *_this, const JPH_Vec3 *inV);

/// Generated from method `JPH::DMat44::GetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *JPH_DMat44_GetTranslation(const JPH_DMat44 *_this);

/// Generated from method `JPH::DMat44::SetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetTranslation(JPH_DMat44 *_this, const JPH_DVec3 *inV);

/// Generated from method `JPH::DMat44::GetColumn3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DMat44_GetColumn3(const JPH_DMat44 *_this, unsigned int inCol);

/// Generated from method `JPH::DMat44::SetColumn3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetColumn3(JPH_DMat44 *_this, unsigned int inCol, const JPH_Vec3 *inV);

/// Generated from method `JPH::DMat44::GetColumn4`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_DMat44_GetColumn4(const JPH_DMat44 *_this, unsigned int inCol);

/// Generated from method `JPH::DMat44::SetColumn4`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetColumn4(JPH_DMat44 *_this, unsigned int inCol, const JPH_Vec4 *inV);

/// Transpose 3x3 subpart of matrix
/// Generated from method `JPH::DMat44::Transposed3x3`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_DMat44_Transposed3x3(const JPH_DMat44 *_this);

/// Inverse 4x4 matrix
/// Generated from method `JPH::DMat44::Inversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_Inversed(const JPH_DMat44 *_this);

/// Inverse 4x4 matrix when it only contains rotation and translation
/// Generated from method `JPH::DMat44::InversedRotationTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_InversedRotationTranslation(const JPH_DMat44 *_this);

/// Get rotation part only (note: retains the first 3 values from the bottom row)
/// Generated from method `JPH::DMat44::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_DMat44_GetRotation(const JPH_DMat44 *_this);

/// Updates the rotation part of this matrix (the first 3 columns)
/// Generated from method `JPH::DMat44::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_DMat44_SetRotation(JPH_DMat44 *_this, const JPH_Mat44 *inRotation);

/// Convert to quaternion
/// Generated from method `JPH::DMat44::GetQuaternion`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_DMat44_GetQuaternion(const JPH_DMat44 *_this);

/// Get matrix that transforms a direction with the same transform as this matrix (length is not preserved)
/// Generated from method `JPH::DMat44::GetDirectionPreservingMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_DMat44_GetDirectionPreservingMatrix(const JPH_DMat44 *_this);

/// Works identical to Mat44::Decompose
/// Generated from method `JPH::DMat44::Decompose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DMat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_DMat44 *JPH_DMat44_Decompose(const JPH_DMat44 *_this, JPH_Vec3 *outScale);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inM` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_DMat44(Jolt_std_ostream *inStream, const JPH_DMat44 *inM);

#ifdef __cplusplus
} // extern "C"
#endif
