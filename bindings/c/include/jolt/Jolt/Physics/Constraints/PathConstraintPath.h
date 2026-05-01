// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_RefTarget_JPH_PathConstraintPath JPH_RefTarget_JPH_PathConstraintPath; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// The path for a path constraint. It allows attaching two bodies to each other while giving the second body the freedom to move along a path relative to the first.
/// Generated from class `JPH::PathConstraintPath`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::PathConstraintPath>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::PathConstraintPathHermite`
typedef struct JPH_PathConstraintPath JPH_PathConstraintPath;

/// Destroys a heap-allocated instance of `JPH_PathConstraintPath`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPath_Destroy(const JPH_PathConstraintPath *_this);

/// Destroys a heap-allocated array of `JPH_PathConstraintPath`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPath_DestroyArray(const JPH_PathConstraintPath *_this);

/// Generated from method `JPH::PathConstraintPath::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPath_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPath::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPath_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPath::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPath::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPath_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPath::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPath_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPath::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPath::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPath_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPath::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PathConstraintPath::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPath::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Gets the max fraction along the path. I.e. sort of the length of the path.
/// Generated from method `JPH::PathConstraintPath::GetPathMaxFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PathConstraintPath_GetPathMaxFraction(const JPH_PathConstraintPath *_this);

/// Get the globally closest point on the curve (Could be slow!)
/// @param inPosition Position to find closest point for
/// @param inFractionHint Last known fraction along the path (can be used to speed up the search)
/// @return Fraction of closest point along the path
/// Generated from method `JPH::PathConstraintPath::GetClosestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API float JPH_PathConstraintPath_GetClosestPoint(const JPH_PathConstraintPath *_this, const JPH_Vec3 *inPosition, float inFractionHint);

/// Given the fraction along the path, get the point, tangent and normal.
/// @param inFraction Fraction along the path [0, GetPathMaxFraction()].
/// @param outPathPosition Returns the closest position to inSearchPosition on the path.
/// @param outPathTangent Returns the tangent to the path at outPathPosition (the vector that follows the direction of the path)
/// @param outPathNormal Return the normal to the path at outPathPosition (a vector that's perpendicular to outPathTangent)
/// @param outPathBinormal Returns the binormal to the path at outPathPosition (a vector so that normal cross tangent = binormal)
/// Generated from method `JPH::PathConstraintPath::GetPointOnPath`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outPathPosition` can not be null. It is a single object.
/// Parameter `outPathTangent` can not be null. It is a single object.
/// Parameter `outPathNormal` can not be null. It is a single object.
/// Parameter `outPathBinormal` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPath_GetPointOnPath(const JPH_PathConstraintPath *_this, float inFraction, JPH_Vec3 *outPathPosition, JPH_Vec3 *outPathTangent, JPH_Vec3 *outPathNormal, JPH_Vec3 *outPathBinormal);

/// If the path is looping or not. If a path is looping, the first and last point are automatically connected to each other. They should not be the same points.
/// Generated from method `JPH::PathConstraintPath::SetIsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPath_SetIsLooping(JPH_PathConstraintPath *_this, bool inIsLooping);

/// Generated from method `JPH::PathConstraintPath::IsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PathConstraintPath_IsLooping(const JPH_PathConstraintPath *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PathConstraintPath::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPath_SetEmbedded(const JPH_PathConstraintPath *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PathConstraintPath::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PathConstraintPath_GetRefCount(const JPH_PathConstraintPath *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PathConstraintPath::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPath_AddRef(const JPH_PathConstraintPath *_this);

/// Generated from method `JPH::PathConstraintPath::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPath_Release(const JPH_PathConstraintPath *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PathConstraintPath::sInternalGetRefCountOffset`.
JOLT_API int JPH_PathConstraintPath_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPath *JPH_PathConstraintPath_OffsetPtr(const JPH_PathConstraintPath *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PathConstraintPath *JPH_PathConstraintPath_OffsetMutablePtr(JPH_PathConstraintPath *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PathConstraintPath` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(const JPH_PathConstraintPath *object);

/// Upcasts an instance of `JPH::PathConstraintPath` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PathConstraintPath_MutableUpcastTo_JPH_SerializableObject(JPH_PathConstraintPath *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PathConstraintPath`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPath *JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PathConstraintPath`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPath *JPH_PathConstraintPath_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PathConstraintPath` to its base class `JPH::RefTarget<JPH::PathConstraintPath>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(const JPH_PathConstraintPath *object);

/// Upcasts an instance of `JPH::PathConstraintPath` to its base class `JPH::RefTarget<JPH::PathConstraintPath>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPath_MutableUpcastTo_JPH_RefTarget_JPH_PathConstraintPath(JPH_PathConstraintPath *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PathConstraintPath>` to a derived class `JPH::PathConstraintPath`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPath *JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(const JPH_RefTarget_JPH_PathConstraintPath *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PathConstraintPath>` to a derived class `JPH::PathConstraintPath`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPath *JPH_PathConstraintPath_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH_RefTarget_JPH_PathConstraintPath *object);

#ifdef __cplusplus
} // extern "C"
#endif
