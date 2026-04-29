// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DVec3 JPH_DVec3; // Defined in `#include <jolt/Jolt/Math/DVec3.h>`.
typedef struct JPH_Float4 JPH_Float4; // Defined in `#include <jolt/Jolt/Math/Float4.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.


/// An infinite plane described by the formula X . Normal + Constant = 0.
/// Generated from class `JPH::Plane`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Plane JPH_Plane;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Plane_DestroyArray()`.
/// Use `JPH_Plane_OffsetMutablePtr()` and `JPH_Plane_OffsetPtr()` to access the array elements.
JOLT_API JPH_Plane *JPH_Plane_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Plane *JPH_Plane_OffsetPtr(const JPH_Plane *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Plane *JPH_Plane_OffsetMutablePtr(JPH_Plane *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Plane::Plane`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_ConstructFromAnother(const JPH_Plane *_other);

/// Generated from constructor `JPH::Plane::Plane`.
/// Parameter `inNormalAndConstant` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_Construct_1(const JPH_Vec4 *inNormalAndConstant);

/// Generated from constructor `JPH::Plane::Plane`.
/// Parameter `inNormal` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_Construct_2(const JPH_Vec3 *inNormal, float inConstant);

/// Destroys a heap-allocated instance of `JPH_Plane`. Does nothing if the pointer is null.
JOLT_API void JPH_Plane_Destroy(const JPH_Plane *_this);

/// Destroys a heap-allocated array of `JPH_Plane`. Does nothing if the pointer is null.
JOLT_API void JPH_Plane_DestroyArray(const JPH_Plane *_this);

/// Generated from method `JPH::Plane::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Plane *JPH_Plane_AssignFromAnother(JPH_Plane *_this, const JPH_Plane *_other);

/// Generated from method `JPH::Plane::operator new`.
JOLT_API void *Jolt_new_JPH_Plane_size_t(size_t inCount);

/// Generated from method `JPH::Plane::operator delete`.
JOLT_API void Jolt_delete_JPH_Plane_void_ptr(void *inPointer);

/// Generated from method `JPH::Plane::operator delete`.
JOLT_API void Jolt_delete_JPH_Plane_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Plane::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Plane_size_t(size_t inCount);

/// Generated from method `JPH::Plane::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Plane_void_ptr(void *inPointer);

/// Generated from method `JPH::Plane::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Plane_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Plane::operator new`.
JOLT_API void *Jolt_new_JPH_Plane_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Plane::operator delete`.
JOLT_API void Jolt_delete_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Plane::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Plane_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Plane::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create from point and normal
/// Generated from method `JPH::Plane::sFromPointAndNormal`.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_sFromPointAndNormal_JPH_Vec3(const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal);

/// Create from point and normal, double precision version that more accurately calculates the plane constant
/// Generated from method `JPH::Plane::sFromPointAndNormal`.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_sFromPointAndNormal_JPH_DVec3(const JPH_DVec3 *inPoint, const JPH_Vec3 *inNormal);

/// Create from 3 counter clockwise points
/// Generated from method `JPH::Plane::sFromPointsCCW`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_sFromPointsCCW(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3);

// Properties
/// Generated from method `JPH::Plane::GetNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Plane_GetNormal(const JPH_Plane *_this);

/// Generated from method `JPH::Plane::SetNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
JOLT_API void JPH_Plane_SetNormal(JPH_Plane *_this, const JPH_Vec3 *inNormal);

/// Generated from method `JPH::Plane::GetConstant`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Plane_GetConstant(const JPH_Plane *_this);

/// Generated from method `JPH::Plane::SetConstant`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Plane_SetConstant(JPH_Plane *_this, float inConstant);

/// Store as 4 floats
/// Generated from method `JPH::Plane::StoreFloat4`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Plane_StoreFloat4(const JPH_Plane *_this, JPH_Float4 *outV);

/// Offset the plane (positive value means move it in the direction of the plane normal)
/// Generated from method `JPH::Plane::Offset`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_Offset(const JPH_Plane *_this, float inDistance);

/// Transform the plane by a matrix
/// Generated from method `JPH::Plane::GetTransformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_GetTransformed(const JPH_Plane *_this, const JPH_Mat44 *inTransform);

/// Scale the plane, can handle non-uniform and negative scaling
/// Generated from method `JPH::Plane::Scaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Plane_Destroy()` to free it when you're done using it.
JOLT_API JPH_Plane *JPH_Plane_Scaled(const JPH_Plane *_this, const JPH_Vec3 *inScale);

/// Distance point to plane
/// Generated from method `JPH::Plane::SignedDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
JOLT_API float JPH_Plane_SignedDistance(const JPH_Plane *_this, const JPH_Vec3 *inPoint);

/// Project inPoint onto the plane
/// Generated from method `JPH::Plane::ProjectPointOnPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Plane_ProjectPointOnPlane(const JPH_Plane *_this, const JPH_Vec3 *inPoint);

/// Returns intersection point between 3 planes
/// Generated from method `JPH::Plane::sIntersectPlanes`.
/// Parameter `inP1` can not be null. It is a single object.
/// Parameter `inP2` can not be null. It is a single object.
/// Parameter `inP3` can not be null. It is a single object.
/// Parameter `outPoint` can not be null. It is a single object.
JOLT_API bool JPH_Plane_sIntersectPlanes(const JPH_Plane *inP1, const JPH_Plane *inP2, const JPH_Plane *inP3, JPH_Vec3 *outPoint);

#ifdef __cplusplus
} // extern "C"
#endif
