// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RayCast JPH_RayCast; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RayCastResult JPH_RayCastResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CastResult.h>`.
typedef struct JPH_RayCastSettings JPH_RayCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_Stats JPH_Shape_Stats; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that constructs a PlaneShape
/// Generated from class `JPH::PlaneShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PlaneShapeSettings JPH_PlaneShapeSettings;

/// A plane shape. The negative half space is considered solid. Planes cannot be dynamic objects, only static or kinematic.
/// The plane is considered an infinite shape, but testing collision outside of its bounding box (defined by the half-extent parameter) will not return a collision result.
/// At the edge of the bounding box collision with the plane will be inconsistent. If you need something of a well defined size, a box shape may be better.
/// Generated from class `JPH::PlaneShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PlaneShape JPH_PlaneShape;

///< Default half-extent of the plane (total size along 1 axis will be 2 * half-extent)
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `cDefaultHalfExtent`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const float *JPH_PlaneShapeSettings_Get_cDefaultHalfExtent(void);

///< Plane that describes the shape. The negative half space is considered solid.
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `mPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Plane *JPH_PlaneShapeSettings_Get_mPlane(const JPH_PlaneShapeSettings *_this);

///< Plane that describes the shape. The negative half space is considered solid.
/// Modifies a member variable of class `JPH::PlaneShapeSettings` named `mPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mPlane`.
/// When this function is called, this object will drop object references it held previously in `mPlane`.
JOLT_API void JPH_PlaneShapeSettings_Set_mPlane(JPH_PlaneShapeSettings *_this, const JPH_Plane *value);

///< Plane that describes the shape. The negative half space is considered solid.
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShapeSettings` named `mPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Plane *JPH_PlaneShapeSettings_GetMutable_mPlane(JPH_PlaneShapeSettings *_this);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PlaneShapeSettings_Get_mHalfExtent(const JPH_PlaneShapeSettings *_this);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Modifies a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfExtent`.
JOLT_API void JPH_PlaneShapeSettings_Set_mHalfExtent(JPH_PlaneShapeSettings *_this, float value);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PlaneShapeSettings_GetMutable_mHalfExtent(JPH_PlaneShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_PlaneShapeSettings_Get_mUserData(const JPH_PlaneShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_PlaneShapeSettings_Set_mUserData(JPH_PlaneShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_PlaneShapeSettings_GetMutable_mUserData(JPH_PlaneShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PlaneShapeSettings_DestroyArray()`.
/// Use `JPH_PlaneShapeSettings_OffsetMutablePtr()` and `JPH_PlaneShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetPtr(const JPH_PlaneShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetMutablePtr(JPH_PlaneShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other);

/// Create a plane shape.
/// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
/// Parameter `inPlane` can not be null. It is a single object.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Parameter `inHalfExtent` has a default argument: `cDefaultHalfExtent`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_Construct(const JPH_Plane *inPlane, const JPH_PhysicsMaterial *inMaterial, const float *inHalfExtent);

/// Destroys a heap-allocated instance of `JPH_PlaneShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShapeSettings_Destroy(const JPH_PlaneShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_PlaneShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShapeSettings_DestroyArray(const JPH_PlaneShapeSettings *_this);

/// Generated from method `JPH::PlaneShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_AssignFromAnother(JPH_PlaneShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other);

/// Generated from method `JPH::PlaneShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PlaneShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::PlaneShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_ClearCachedResult(JPH_PlaneShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PlaneShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_SetEmbedded(const JPH_PlaneShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PlaneShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShapeSettings_GetRefCount(const JPH_PlaneShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PlaneShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_AddRef(const JPH_PlaneShapeSettings *_this);

/// Generated from method `JPH::PlaneShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_Release(const JPH_PlaneShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PlaneShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_PlaneShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::PlaneShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::PlaneShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_PlaneShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::PlaneShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_PlaneShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_PlaneShape_GetMutable_sDrawSubmergedVolumes(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PlaneShape_DestroyArray()`.
/// Use `JPH_PlaneShape_OffsetMutablePtr()` and `JPH_PlaneShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_OffsetPtr(const JPH_PlaneShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_OffsetMutablePtr(JPH_PlaneShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_PlaneShape_UpcastTo_JPH_NonCopyable(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_PlaneShape_MutableUpcastTo_JPH_NonCopyable(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_Shape(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_Shape(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Generated from constructor `JPH::PlaneShape::PlaneShape`.
/// Parameter `inPlane` can not be null. It is a single object.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Parameter `inHalfExtent` has a default argument: `PlaneShapeSettings::cDefaultHalfExtent`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_Construct_3(const JPH_Plane *inPlane, const JPH_PhysicsMaterial *inMaterial, const float *inHalfExtent);

/// Destroys a heap-allocated instance of `JPH_PlaneShape`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShape_Destroy(const JPH_PlaneShape *_this);

/// Destroys a heap-allocated array of `JPH_PlaneShape`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShape_DestroyArray(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShape_size_t(size_t inCount);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PlaneShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShape_size_t(size_t inCount);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PlaneShape::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PlaneShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the plane
/// Generated from method `JPH::PlaneShape::GetPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Plane *JPH_PlaneShape_GetPlane(const JPH_PlaneShape *_this);

/// Get the half-extent of the bounding box of the plane
/// Generated from method `JPH::PlaneShape::GetHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetHalfExtent(const JPH_PlaneShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::PlaneShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PlaneShape_MustBeStatic(const JPH_PlaneShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::PlaneShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_PlaneShape_GetLocalBounds(const JPH_PlaneShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::PlaneShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShape_GetSubShapeIDBitsRecursive(const JPH_PlaneShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::PlaneShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetInnerRadius(const JPH_PlaneShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::PlaneShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_1(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::PlaneShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_PlaneShape_GetSurfaceNormal(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See Shape::Draw
/// Generated from method `JPH::PlaneShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_Draw(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

// See Shape::CastRay
/// Generated from method `JPH::PlaneShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_PlaneShape_CastRay_3(const JPH_PlaneShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::PlaneShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_GetTrianglesStart(const JPH_PlaneShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::PlaneShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_PlaneShape_GetTrianglesNext(const JPH_PlaneShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::PlaneShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_GetSubmergedVolume(const JPH_PlaneShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

// See Shape::GetStats
/// Generated from method `JPH::PlaneShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_PlaneShape_GetStats(const JPH_PlaneShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::PlaneShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetVolume(const JPH_PlaneShape *_this);

/// Material of the shape
/// Generated from method `JPH::PlaneShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetMaterial(JPH_PlaneShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Generated from method `JPH::PlaneShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_0(const JPH_PlaneShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::PlaneShape::sRegister`.
JOLT_API void JPH_PlaneShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::PlaneShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_PlaneShape_GetUserData(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetUserData(JPH_PlaneShape *_this, uint64_t inUserData);

/// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
/// Generated from method `JPH::PlaneShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_PlaneShape_GetCenterOfMass(const JPH_PlaneShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::PlaneShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_PlaneShape_GetLeafShape(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::PlaneShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_PlaneShape_GetSubShapeUserData(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::PlaneShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_PlaneShape_GetSubShapeTransformedShape(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

/// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::PlaneShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_DrawGetSupportFunction(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

/// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::PlaneShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_DrawGetSupportingFace(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Test if inScale is a valid scale for this shape. Some shapes can only be scaled uniformly, compound shapes cannot handle shapes
/// being rotated and scaled (this would cause shearing), scale can never be zero. When the scale is invalid, the function will return false.
///
/// Here's a list of supported scales:
/// * SphereShape: Scale must be uniform (signs of scale are ignored).
/// * BoxShape: Any scale supported (signs of scale are ignored).
/// * TriangleShape: Any scale supported when convex radius is zero, otherwise only uniform scale supported.
/// * CapsuleShape: Scale must be uniform (signs of scale are ignored).
/// * TaperedCapsuleShape: Scale must be uniform (sign of Y scale can be used to flip the capsule).
/// * CylinderShape: Scale must be uniform in XZ plane, Y can scale independently (signs of scale are ignored).
/// * RotatedTranslatedShape: Scale must not cause shear in the child shape.
/// * CompoundShape: Scale must not cause shear in any of the child shapes.
/// Generated from method `JPH::PlaneShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_PlaneShape_IsValidScale(const JPH_PlaneShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::PlaneShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_PlaneShape_MakeScaleValid(const JPH_PlaneShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PlaneShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetEmbedded(const JPH_PlaneShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PlaneShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShape_GetRefCount(const JPH_PlaneShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PlaneShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_AddRef(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_Release(const JPH_PlaneShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PlaneShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_PlaneShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
