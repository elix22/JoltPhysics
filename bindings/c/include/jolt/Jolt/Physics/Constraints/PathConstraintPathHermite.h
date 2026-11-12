// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_PathConstraintPath JPH_PathConstraintPath; // Defined in `#include <jolt/Jolt/Physics/Constraints/PathConstraintPath.h>`.
typedef struct JPH_RefTarget_JPH_PathConstraintPath JPH_RefTarget_JPH_PathConstraintPath; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Generated from class `JPH::PathConstraintPathHermite::Point`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PathConstraintPathHermite_Point JPH_PathConstraintPathHermite_Point;

/// A path that follows a Hermite spline
/// Generated from class `JPH::PathConstraintPathHermite`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::PathConstraintPath`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::PathConstraintPath>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PathConstraintPathHermite JPH_PathConstraintPathHermite;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PathConstraintPathHermite_Destroy()` to free it when you're done using it.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PathConstraintPathHermite_DestroyArray()`.
/// Use `JPH_PathConstraintPathHermite_OffsetMutablePtr()` and `JPH_PathConstraintPathHermite_OffsetPtr()` to access the array elements.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_OffsetPtr(const JPH_PathConstraintPathHermite *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_OffsetMutablePtr(JPH_PathConstraintPathHermite *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(const JPH_PathConstraintPathHermite *object);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_SerializableObject(JPH_PathConstraintPathHermite *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::RefTarget<JPH::PathConstraintPath>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(const JPH_PathConstraintPathHermite *object);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::RefTarget<JPH::PathConstraintPath>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_RefTarget_JPH_PathConstraintPath(JPH_PathConstraintPathHermite *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PathConstraintPath>` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(const JPH_RefTarget_JPH_PathConstraintPath *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PathConstraintPath>` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH_RefTarget_JPH_PathConstraintPath *object);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::PathConstraintPath`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPath *JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(const JPH_PathConstraintPathHermite *object);

/// Upcasts an instance of `JPH::PathConstraintPathHermite` to its base class `JPH::PathConstraintPath`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPath *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_PathConstraintPath(JPH_PathConstraintPathHermite *object);

/// Downcasts an instance of `JPH::PathConstraintPath` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_PathConstraintPath(const JPH_PathConstraintPath *object);

/// Downcasts an instance of `JPH::PathConstraintPath` to a derived class `JPH::PathConstraintPathHermite`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_PathConstraintPath(JPH_PathConstraintPath *object);

/// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PathConstraintPathHermite_Destroy()` to free it when you're done using it.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PathConstraintPathHermite *_other);

/// Destroys a heap-allocated instance of `JPH_PathConstraintPathHermite`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPathHermite_Destroy(const JPH_PathConstraintPathHermite *_this);

/// Destroys a heap-allocated array of `JPH_PathConstraintPathHermite`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPathHermite_DestroyArray(const JPH_PathConstraintPathHermite *_this);

/// Generated from method `JPH::PathConstraintPathHermite::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_AssignFromAnother(JPH_PathConstraintPathHermite *_this, Jolt_PassBy _other_pass_by, JPH_PathConstraintPathHermite *_other);

/// Generated from method `JPH::PathConstraintPathHermite::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPathHermite_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPathHermite::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPathHermite_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPathHermite::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PathConstraintPathHermite::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See PathConstraintPath::GetPathMaxFraction
/// Generated from method `JPH::PathConstraintPathHermite::GetPathMaxFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PathConstraintPathHermite_GetPathMaxFraction(const JPH_PathConstraintPathHermite *_this);

// See PathConstraintPath::GetClosestPoint
/// Generated from method `JPH::PathConstraintPathHermite::GetClosestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API float JPH_PathConstraintPathHermite_GetClosestPoint(const JPH_PathConstraintPathHermite *_this, const JPH_Vec3 *inPosition, float inFractionHint);

// See PathConstraintPath::GetPointOnPath
/// Generated from method `JPH::PathConstraintPathHermite::GetPointOnPath`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outPathPosition` can not be null. It is a single object.
/// Parameter `outPathTangent` can not be null. It is a single object.
/// Parameter `outPathNormal` can not be null. It is a single object.
/// Parameter `outPathBinormal` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_GetPointOnPath(const JPH_PathConstraintPathHermite *_this, float inFraction, JPH_Vec3 *outPathPosition, JPH_Vec3 *outPathTangent, JPH_Vec3 *outPathNormal, JPH_Vec3 *outPathBinormal);

/// Adds a point to the path
/// Generated from method `JPH::PathConstraintPathHermite::AddPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inTangent` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_AddPoint(JPH_PathConstraintPathHermite *_this, const JPH_Vec3 *inPosition, const JPH_Vec3 *inTangent, const JPH_Vec3 *inNormal);

/// If the path is looping or not. If a path is looping, the first and last point are automatically connected to each other. They should not be the same points.
/// Generated from method `JPH::PathConstraintPathHermite::SetIsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_SetIsLooping(JPH_PathConstraintPathHermite *_this, bool inIsLooping);

/// Generated from method `JPH::PathConstraintPathHermite::IsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PathConstraintPathHermite_IsLooping(const JPH_PathConstraintPathHermite *_this);

/// Draw the path relative to inBaseTransform. Used for debug purposes.
/// Generated from method `JPH::PathConstraintPathHermite::DrawPath`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBaseTransform` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_DrawPath(const JPH_PathConstraintPathHermite *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inBaseTransform);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PathConstraintPathHermite::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_SetEmbedded(const JPH_PathConstraintPathHermite *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PathConstraintPathHermite::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PathConstraintPathHermite_GetRefCount(const JPH_PathConstraintPathHermite *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PathConstraintPathHermite::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_AddRef(const JPH_PathConstraintPathHermite *_this);

/// Generated from method `JPH::PathConstraintPathHermite::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PathConstraintPathHermite_Release(const JPH_PathConstraintPathHermite *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PathConstraintPathHermite::sInternalGetRefCountOffset`.
JOLT_API int JPH_PathConstraintPathHermite_sInternalGetRefCountOffset(void);

///< Position on the path
/// Returns a pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mPosition(const JPH_PathConstraintPathHermite_Point *_this);

///< Position on the path
/// Returns a mutable pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mPosition(JPH_PathConstraintPathHermite_Point *_this);

///< Tangent of the path, does not need to be normalized (in the direction of the path)
/// Returns a pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mTangent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mTangent(const JPH_PathConstraintPathHermite_Point *_this);

///< Tangent of the path, does not need to be normalized (in the direction of the path)
/// Returns a mutable pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mTangent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mTangent(JPH_PathConstraintPathHermite_Point *_this);

///< Normal of the path (together with the tangent along the curve this forms a basis for the constraint)
/// Returns a pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mNormal(const JPH_PathConstraintPathHermite_Point *_this);

///< Normal of the path (together with the tangent along the curve this forms a basis for the constraint)
/// Returns a mutable pointer to a member variable of class `JPH::PathConstraintPathHermite::Point` named `mNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mNormal(JPH_PathConstraintPathHermite_Point *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PathConstraintPathHermite_Point_Destroy()` to free it when you're done using it.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PathConstraintPathHermite_Point_DestroyArray()`.
/// Use `JPH_PathConstraintPathHermite_Point_OffsetMutablePtr()` and `JPH_PathConstraintPathHermite_Point_OffsetPtr()` to access the array elements.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::PathConstraintPathHermite::Point` elementwise.
/// Parameter `mPosition` can not be null. It is a single object.
/// The reference to the parameter `mPosition` might be preserved in the constructed object.
/// Parameter `mTangent` can not be null. It is a single object.
/// The reference to the parameter `mTangent` might be preserved in the constructed object.
/// Parameter `mNormal` can not be null. It is a single object.
/// The reference to the parameter `mNormal` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PathConstraintPathHermite_Point_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_ConstructFrom(const JPH_Vec3 *mPosition, const JPH_Vec3 *mTangent, const JPH_Vec3 *mNormal);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_OffsetPtr(const JPH_PathConstraintPathHermite_Point *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_OffsetMutablePtr(JPH_PathConstraintPathHermite_Point *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::PathConstraintPathHermite::Point::Point`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PathConstraintPathHermite_Point_Destroy()` to free it when you're done using it.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_ConstructFromAnother(const JPH_PathConstraintPathHermite_Point *_other);

/// Destroys a heap-allocated instance of `JPH_PathConstraintPathHermite_Point`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPathHermite_Point_Destroy(const JPH_PathConstraintPathHermite_Point *_this);

/// Destroys a heap-allocated array of `JPH_PathConstraintPathHermite_Point`. Does nothing if the pointer is null.
JOLT_API void JPH_PathConstraintPathHermite_Point_DestroyArray(const JPH_PathConstraintPathHermite_Point *_this);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_AssignFromAnother(JPH_PathConstraintPathHermite_Point *_this, const JPH_PathConstraintPathHermite_Point *_other);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPathHermite_Point_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t(size_t inCount);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator new`.
JOLT_API void *Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
JOLT_API void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
