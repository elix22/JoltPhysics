// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Float4 JPH_Float4; // Defined in `#include <jolt/Jolt/Math/Float4.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.
typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// Quaternion class, quaternions are 4 dimensional vectors which can describe rotations in 3 dimensional
/// space if their length is 1.
///
/// They are written as:
///
/// \f$q = w + x \: i + y \: j + z \: k\f$
///
/// or in vector notation:
///
/// \f$q = [w, v] = [w, x, y, z]\f$
///
/// Where:
///
/// w = the real part
/// v = the imaginary part, (x, y, z)
///
/// Note that we store the quaternion in a Vec4 as [x, y, z, w] because that makes
/// it easy to extract the rotation axis of the quaternion:
///
/// q = [cos(angle / 2), sin(angle / 2) * rotation_axis]
/// Generated from class `JPH::Quat`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Quat JPH_Quat;

/// 4 vector that stores [x, y, z, w] parts of the quaternion
/// Returns a pointer to a member variable of class `JPH::Quat` named `mValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec4 *JPH_Quat_Get_mValue(const JPH_Quat *_this);

/// 4 vector that stores [x, y, z, w] parts of the quaternion
/// Returns a mutable pointer to a member variable of class `JPH::Quat` named `mValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec4 *JPH_Quat_GetMutable_mValue(JPH_Quat *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Quat_DestroyArray()`.
/// Use `JPH_Quat_OffsetMutablePtr()` and `JPH_Quat_OffsetPtr()` to access the array elements.
JOLT_API JPH_Quat *JPH_Quat_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Quat *JPH_Quat_OffsetPtr(const JPH_Quat *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Quat *JPH_Quat_OffsetMutablePtr(JPH_Quat *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Quat::Quat`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_ConstructFromAnother(const JPH_Quat *inRHS);

/// Generated from constructor `JPH::Quat::Quat`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Construct_4(float inX, float inY, float inZ, float inW);

/// Generated from constructor `JPH::Quat::Quat`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Construct_1_JPH_Float4(const JPH_Float4 *inV);

/// Generated from constructor `JPH::Quat::Quat`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Construct_1_JPH_Vec4(const JPH_Vec4 *inV);

/// Destroys a heap-allocated instance of `JPH_Quat`. Does nothing if the pointer is null.
JOLT_API void JPH_Quat_Destroy(const JPH_Quat *_this);

/// Destroys a heap-allocated array of `JPH_Quat`. Does nothing if the pointer is null.
JOLT_API void JPH_Quat_DestroyArray(const JPH_Quat *_this);

/// Generated from method `JPH::Quat::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Quat *JPH_Quat_AssignFromAnother(JPH_Quat *_this, const JPH_Quat *inRHS);

/// Generated from method `JPH::Quat::operator new`.
JOLT_API void *Jolt_new_JPH_Quat_size_t(unsigned long inCount);

/// Generated from method `JPH::Quat::operator delete`.
JOLT_API void Jolt_delete_JPH_Quat_void_ptr(void *inPointer);

/// Generated from method `JPH::Quat::operator delete`.
JOLT_API void Jolt_delete_JPH_Quat_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Quat::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Quat_size_t(unsigned long inCount);

/// Generated from method `JPH::Quat::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Quat_void_ptr(void *inPointer);

/// Generated from method `JPH::Quat::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Quat_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Quat::operator new`.
JOLT_API void *Jolt_new_JPH_Quat_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Quat::operator delete`.
JOLT_API void Jolt_delete_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Quat::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Quat_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Quat::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if two quaternions are exactly equal
/// Generated from method `JPH::Quat::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS);

/// Check if two quaternions are different
/// Generated from method `JPH::Quat::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS);

/// If this quaternion is close to inRHS. Note that q and -q represent the same rotation, this is not checked here.
/// Generated from method `JPH::Quat::IsClose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Parameter `inMaxDistSq` has a default argument: `9.99999996e-13f`, pass a null pointer to use it.
JOLT_API bool JPH_Quat_IsClose(const JPH_Quat *_this, const JPH_Quat *inRHS, const float *inMaxDistSq);

/// If the length of this quaternion is 1 +/- inTolerance
/// Generated from method `JPH::Quat::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTolerance` has a default argument: `9.99999974e-6f`, pass a null pointer to use it.
JOLT_API bool JPH_Quat_IsNormalized(const JPH_Quat *_this, const float *inTolerance);

/// If any component of this quaternion is a NaN (not a number)
/// Generated from method `JPH::Quat::IsNaN`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Quat_IsNaN(const JPH_Quat *_this);

/// Get X component (imaginary part i)
/// Generated from method `JPH::Quat::GetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_GetX(const JPH_Quat *_this);

/// Get Y component (imaginary part j)
/// Generated from method `JPH::Quat::GetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_GetY(const JPH_Quat *_this);

/// Get Z component (imaginary part k)
/// Generated from method `JPH::Quat::GetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_GetZ(const JPH_Quat *_this);

/// Get W component (real part)
/// Generated from method `JPH::Quat::GetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_GetW(const JPH_Quat *_this);

/// Get the imaginary part of the quaternion
/// Generated from method `JPH::Quat::GetXYZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_GetXYZ(const JPH_Quat *_this);

/// Get the quaternion as a Vec4
/// Generated from method `JPH::Quat::GetXYZW`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Quat_GetXYZW(const JPH_Quat *_this);

/// Set individual components
/// Generated from method `JPH::Quat::SetX`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_SetX(JPH_Quat *_this, float inX);

/// Generated from method `JPH::Quat::SetY`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_SetY(JPH_Quat *_this, float inY);

/// Generated from method `JPH::Quat::SetZ`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_SetZ(JPH_Quat *_this, float inZ);

/// Generated from method `JPH::Quat::SetW`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_SetW(JPH_Quat *_this, float inW);

/// Set all components
/// Generated from method `JPH::Quat::Set`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_Set(JPH_Quat *_this, float inX, float inY, float inZ, float inW);

/// @return [0, 0, 0, 0]
/// Generated from method `JPH::Quat::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sZero(void);

/// @return [1, 0, 0, 0] (or in storage format Quat(0, 0, 0, 1))
/// Generated from method `JPH::Quat::sIdentity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sIdentity(void);

/// Rotation from axis and angle
/// Generated from method `JPH::Quat::sRotation`.
/// Parameter `inAxis` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sRotation(const JPH_Vec3 *inAxis, float inAngle);

/// Get axis and angle that represents this quaternion, outAngle will always be in the range \f$[0, \pi]\f$
/// Generated from method `JPH::Quat::GetAxisAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outAxis` can not be null. It is a single object.
/// Parameter `outAngle` can not be null. It is a single object.
JOLT_API void JPH_Quat_GetAxisAngle(const JPH_Quat *_this, JPH_Vec3 *outAxis, float *outAngle);

/// Create quaternion that rotates a vector from the direction of inFrom to the direction of inTo along the shortest path
/// @see https://www.euclideanspace.com/maths/algebra/vectors/angleBetween/index.htm
/// Generated from method `JPH::Quat::sFromTo`.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sFromTo(const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo);

/// Conversion from Euler angles. Rotation order is X then Y then Z (RotZ * RotY * RotX). Angles in radians.
/// Generated from method `JPH::Quat::sEulerAngles`.
/// Parameter `inAngles` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sEulerAngles(const JPH_Vec3 *inAngles);

/// Conversion to Euler angles. Rotation order is X then Y then Z (RotZ * RotY * RotX). Angles in radians.
/// Generated from method `JPH::Quat::GetEulerAngles`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_GetEulerAngles(const JPH_Quat *_this);

/// Squared length of quaternion.
/// @return Squared length of quaternion (\f$|v|^2\f$)
/// Generated from method `JPH::Quat::LengthSq`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_LengthSq(const JPH_Quat *_this);

/// Length of quaternion.
/// @return Length of quaternion (\f$|v|\f$)
/// Generated from method `JPH::Quat::Length`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Quat_Length(const JPH_Quat *_this);

/// Normalize the quaternion (make it length 1)
/// Generated from method `JPH::Quat::Normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Normalized(const JPH_Quat *_this);

///@}
///@name Additions / multiplications
///@{
/// Generated from method `JPH::Quat::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API void JPH_Quat_add_assign(JPH_Quat *_this, const JPH_Quat *inRHS);

/// Generated from method `JPH::Quat::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API void JPH_Quat_sub_assign(JPH_Quat *_this, const JPH_Quat *inRHS);

/// Generated from method `JPH::Quat::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_mul_assign(JPH_Quat *_this, float inValue);

/// Generated from method `JPH::Quat::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_div_assign(JPH_Quat *_this, float inValue);

/// Generated from method `JPH::Quat::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_neg_JPH_Quat(const JPH_Quat *_this);

/// Generated from method `JPH::Quat::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_add_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS);

/// Generated from method `JPH::Quat::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_sub_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS);

// Jolt Physics Library (https://github.com/jrouwe/JoltPhysics)
// SPDX-FileCopyrightText: 2021 Jorrit Rouwe
// SPDX-License-Identifier: MIT
/// Generated from method `JPH::Quat::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_mul_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS);

/// Generated from method `JPH::Quat::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_mul_JPH_Quat_float(const JPH_Quat *_this, float inValue);

/// Generated from method `JPH::Quat::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_div_JPH_Quat_float(const JPH_Quat *_this, float inValue);

/// Rotate a vector by this quaternion
/// Generated from method `JPH::Quat::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inValue` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_mul_JPH_Quat_JPH_Vec3(const JPH_Quat *_this, const JPH_Vec3 *inValue);

/// Multiply a quaternion with imaginary components and no real component (x, y, z, 0) with a quaternion
/// Generated from method `JPH::Quat::sMultiplyImaginary`.
/// Parameter `inLHS` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sMultiplyImaginary(const JPH_Vec3 *inLHS, const JPH_Quat *inRHS);

/// Rotate a vector by the inverse of this quaternion
/// Generated from method `JPH::Quat::InverseRotate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inValue` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_InverseRotate(const JPH_Quat *_this, const JPH_Vec3 *inValue);

/// Rotate a the vector (1, 0, 0) with this quaternion
/// Generated from method `JPH::Quat::RotateAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_RotateAxisX(const JPH_Quat *_this);

/// Rotate a the vector (0, 1, 0) with this quaternion
/// Generated from method `JPH::Quat::RotateAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_RotateAxisY(const JPH_Quat *_this);

/// Rotate a the vector (0, 0, 1) with this quaternion
/// Generated from method `JPH::Quat::RotateAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Quat_RotateAxisZ(const JPH_Quat *_this);

/// Dot product
/// Generated from method `JPH::Quat::Dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API float JPH_Quat_Dot(const JPH_Quat *_this, const JPH_Quat *inRHS);

/// The conjugate [w, -x, -y, -z] is the same as the inverse for unit quaternions
/// Generated from method `JPH::Quat::Conjugated`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Conjugated(const JPH_Quat *_this);

/// Get inverse quaternion
/// Generated from method `JPH::Quat::Inversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_Inversed(const JPH_Quat *_this);

/// Ensures that the W component is positive by negating the entire quaternion if it is not. This is useful when you want to store a quaternion as a 3 vector by discarding W and reconstructing it as sqrt(1 - x^2 - y^2 - z^2).
/// Generated from method `JPH::Quat::EnsureWPositive`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_EnsureWPositive(const JPH_Quat *_this);

/// Get a quaternion that is perpendicular to this quaternion
/// Generated from method `JPH::Quat::GetPerpendicular`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_GetPerpendicular(const JPH_Quat *_this);

/// Get rotation angle around inAxis (uses Swing Twist Decomposition to get the twist quaternion and uses q(axis, angle) = [cos(angle / 2), axis * sin(angle / 2)])
/// Generated from method `JPH::Quat::GetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
JOLT_API float JPH_Quat_GetRotationAngle(const JPH_Quat *_this, const JPH_Vec3 *inAxis);

/// Swing Twist Decomposition: any quaternion can be split up as:
///
/// \f[q = q_{swing} \: q_{twist}\f]
///
/// where \f$q_{twist}\f$ rotates only around axis v.
///
/// \f$q_{twist}\f$ is:
///
/// \f[q_{twist} = \frac{[q_w, q_{ijk} \cdot v \: v]}{\left|[q_w, q_{ijk} \cdot v \: v]\right|}\f]
///
/// where q_w is the real part of the quaternion and q_i the imaginary part (a 3 vector).
///
/// The swing can then be calculated as:
///
/// \f[q_{swing} = q \: q_{twist}^* \f]
///
/// Where \f$q_{twist}^*\f$ = complex conjugate of \f$q_{twist}\f$
/// Generated from method `JPH::Quat::GetTwist`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_GetTwist(const JPH_Quat *_this, const JPH_Vec3 *inAxis);

/// Decomposes quaternion into swing and twist component:
///
/// \f$q = q_{swing} \: q_{twist}\f$
///
/// where \f$q_{swing} \: \hat{x} = q_{twist} \: \hat{y} = q_{twist} \: \hat{z} = 0\f$
///
/// In other words:
///
/// - \f$q_{twist}\f$ only rotates around the X-axis.
/// - \f$q_{swing}\f$ only rotates around the Y and Z-axis.
///
/// @see Gino van den Bergen - Rotational Joint Limits in Quaternion Space - GDC 2016
/// Generated from method `JPH::Quat::GetSwingTwist`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outSwing` can not be null. It is a single object.
/// Parameter `outTwist` can not be null. It is a single object.
JOLT_API void JPH_Quat_GetSwingTwist(const JPH_Quat *_this, JPH_Quat *outSwing, JPH_Quat *outTwist);

/// Linear interpolation between two quaternions (for small steps).
/// @param inFraction is in the range [0, 1]
/// @param inDestination The destination quaternion
/// @return (1 - inFraction) * this + fraction * inDestination
/// Generated from method `JPH::Quat::LERP`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDestination` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_LERP(const JPH_Quat *_this, const JPH_Quat *inDestination, float inFraction);

/// Spherical linear interpolation between two quaternions.
/// @param inFraction is in the range [0, 1]
/// @param inDestination The destination quaternion
/// @return When fraction is zero this quaternion is returned, when fraction is 1 inDestination is returned.
/// When fraction is between 0 and 1 an interpolation along the shortest path is returned.
/// Generated from method `JPH::Quat::SLERP`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDestination` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_SLERP(const JPH_Quat *_this, const JPH_Quat *inDestination, float inFraction);

/// Load 3 floats from memory (X, Y and Z component and then calculates W) reads 32 bits extra which it doesn't use
/// Generated from method `JPH::Quat::sLoadFloat3Unsafe`.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sLoadFloat3Unsafe(const JPH_Float3 *inV);

/// Store as 3 floats to memory (X, Y and Z component). Ensures that W is positive before storing.
/// Generated from method `JPH::Quat::StoreFloat3`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_StoreFloat3(const JPH_Quat *_this, JPH_Float3 *outV);

/// Store as 4 floats
/// Generated from method `JPH::Quat::StoreFloat4`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Quat_StoreFloat4(const JPH_Quat *_this, JPH_Float4 *outV);

/// Compress a unit quaternion to a 32 bit value, precision is around 0.5 degree
/// Generated from method `JPH::Quat::CompressUnitQuat`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Quat_CompressUnitQuat(const JPH_Quat *_this);

/// Decompress a unit quaternion from a 32 bit value
/// Generated from method `JPH::Quat::sDecompressUnitQuat`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Quat_sDecompressUnitQuat(unsigned int inValue);

/// Generated from function `JPH::operator*`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *Jolt_mul_float_JPH_Quat(float inValue, const JPH_Quat *inRHS);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inQ` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_Quat(Jolt_std_ostream *inStream, const JPH_Quat *inQ);

#ifdef __cplusplus
} // extern "C"
#endif
