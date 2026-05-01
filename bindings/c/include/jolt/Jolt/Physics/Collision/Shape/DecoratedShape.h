// machine generated, do not edit
#pragma once

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


/// Class that constructs a DecoratedShape
/// Generated from class `JPH::DecoratedShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::OffsetCenterOfMassShapeSettings`
///     `JPH::RotatedTranslatedShapeSettings`
///     `JPH::ScaledShapeSettings`
typedef struct JPH_DecoratedShapeSettings JPH_DecoratedShapeSettings;

/// Base class for shapes that decorate another shape with extra functionality (e.g. scale, translation etc.)
/// Generated from class `JPH::DecoratedShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::OffsetCenterOfMassShape`
///     `JPH::RotatedTranslatedShape`
///     `JPH::ScaledShape`
typedef struct JPH_DecoratedShape JPH_DecoratedShape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::DecoratedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_DecoratedShapeSettings_Get_mUserData(const JPH_DecoratedShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::DecoratedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_DecoratedShapeSettings_Set_mUserData(JPH_DecoratedShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::DecoratedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_DecoratedShapeSettings_GetMutable_mUserData(JPH_DecoratedShapeSettings *_this);

/// Destroys a heap-allocated instance of `JPH_DecoratedShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_DecoratedShapeSettings_Destroy(const JPH_DecoratedShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_DecoratedShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_DecoratedShapeSettings_DestroyArray(const JPH_DecoratedShapeSettings *_this);

/// Generated from method `JPH::DecoratedShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_DecoratedShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DecoratedShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DecoratedShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DecoratedShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_DecoratedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DecoratedShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DecoratedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DecoratedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::DecoratedShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShapeSettings_ClearCachedResult(JPH_DecoratedShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::DecoratedShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShapeSettings_SetEmbedded(const JPH_DecoratedShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::DecoratedShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DecoratedShapeSettings_GetRefCount(const JPH_DecoratedShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::DecoratedShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShapeSettings_AddRef(const JPH_DecoratedShapeSettings *_this);

/// Generated from method `JPH::DecoratedShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShapeSettings_Release(const JPH_DecoratedShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::DecoratedShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_DecoratedShapeSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_OffsetPtr(const JPH_DecoratedShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_OffsetMutablePtr(JPH_DecoratedShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_DecoratedShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_DecoratedShapeSettings *object);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_DecoratedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_DecoratedShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Upcasts an instance of `JPH::DecoratedShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::DecoratedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::DecoratedShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_DecoratedShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::DecoratedShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_DecoratedShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::DecoratedShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_DecoratedShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::DecoratedShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_DecoratedShape_GetMutable_sDrawSubmergedVolumes(void);

/// Destroys a heap-allocated instance of `JPH_DecoratedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_DecoratedShape_Destroy(const JPH_DecoratedShape *_this);

/// Destroys a heap-allocated array of `JPH_DecoratedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_DecoratedShape_DestroyArray(const JPH_DecoratedShape *_this);

/// Generated from method `JPH::DecoratedShape::operator new`.
JOLT_API void *Jolt_new_JPH_DecoratedShape_size_t(size_t inCount);

/// Generated from method `JPH::DecoratedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::DecoratedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DecoratedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DecoratedShape_size_t(size_t inCount);

/// Generated from method `JPH::DecoratedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::DecoratedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DecoratedShape::operator new`.
JOLT_API void *Jolt_new_JPH_DecoratedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DecoratedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_DecoratedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DecoratedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DecoratedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DecoratedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DecoratedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access to the decorated inner shape
/// Generated from method `JPH::DecoratedShape::GetInnerShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_DecoratedShape_GetInnerShape(const JPH_DecoratedShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::DecoratedShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DecoratedShape_MustBeStatic(const JPH_DecoratedShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::DecoratedShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DecoratedShape_GetCenterOfMass(const JPH_DecoratedShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::DecoratedShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DecoratedShape_GetSubShapeIDBitsRecursive(const JPH_DecoratedShape *_this);

// See Shape::GetLeafShape
/// Generated from method `JPH::DecoratedShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_DecoratedShape_GetLeafShape(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetMaterial
/// Generated from method `JPH::DecoratedShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_DecoratedShape_GetMaterial(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::DecoratedShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_DecoratedShape_GetSubShapeUserData(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::IsValidScale
/// Generated from method `JPH::DecoratedShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_DecoratedShape_IsValidScale(const JPH_DecoratedShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::DecoratedShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DecoratedShape_MakeScaleValid(const JPH_DecoratedShape *_this, const JPH_Vec3 *inScale);

/// User data (to be used freely by the application)
/// Generated from method `JPH::DecoratedShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_DecoratedShape_GetUserData(const JPH_DecoratedShape *_this);

/// Generated from method `JPH::DecoratedShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_SetUserData(JPH_DecoratedShape *_this, uint64_t inUserData);

/// Get local bounding box including convex radius, this box is centered around the center of mass rather than the world transform
/// Generated from method `JPH::DecoratedShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_DecoratedShape_GetLocalBounds(const JPH_DecoratedShape *_this);

/// Returns the radius of the biggest sphere that fits entirely in the shape. In case this shape consists of multiple sub shapes, it returns the smallest sphere of the parts.
/// This can be used as a measure of how far the shape can be moved without risking going through geometry.
/// Generated from method `JPH::DecoratedShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_DecoratedShape_GetInnerRadius(const JPH_DecoratedShape *_this);

/// Get the surface normal of a particular sub shape ID and point on surface (all vectors are relative to center of mass for this shape).
/// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetSurfaceNormal will only return face normals (and not vertex or edge normals).
/// Generated from method `JPH::DecoratedShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_DecoratedShape_GetSurfaceNormal(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::DecoratedShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_DecoratedShape_GetSubShapeTransformedShape(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

/// Generated from method `JPH::DecoratedShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_GetSubmergedVolume(const JPH_DecoratedShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

/// Draw the shape at a particular location with a particular color (debugging purposes)
/// Generated from method `JPH::DecoratedShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_Draw(const JPH_DecoratedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

/// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::DecoratedShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_DrawGetSupportFunction(const JPH_DecoratedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

/// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::DecoratedShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_DrawGetSupportingFace(const JPH_DecoratedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// To start iterating over triangles, call this function first.
/// ioContext is a temporary buffer and should remain untouched until the last call to GetTrianglesNext.
/// inBox is the world space bounding in which you want to get the triangles.
/// inPositionCOM/inRotation/inScale describes the transform of this shape.
/// To get the actual triangles call GetTrianglesNext.
/// Generated from method `JPH::DecoratedShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_GetTrianglesStart(const JPH_DecoratedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

/// Call this repeatedly to get all triangles in the box.
/// outTriangleVertices should be large enough to hold 3 * inMaxTriangleRequested entries.
/// outMaterials (if it is not null) should contain inMaxTrianglesRequested entries.
/// The function returns the amount of triangles that it found (which will be <= inMaxTrianglesRequested), or 0 if there are no more triangles.
/// Note that the function can return a value < inMaxTrianglesRequested and still have more triangles to process (triangles can be returned in blocks).
/// Note that the function may return triangles outside of the requested box, only coarse culling is performed on the returned triangles.
/// Generated from method `JPH::DecoratedShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_DecoratedShape_GetTrianglesNext(const JPH_DecoratedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
/// Generated from method `JPH::DecoratedShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_DecoratedShape_GetStats(const JPH_DecoratedShape *_this);

/// Generated from method `JPH::DecoratedShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_DecoratedShape_GetVolume(const JPH_DecoratedShape *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::DecoratedShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_SetEmbedded(const JPH_DecoratedShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::DecoratedShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DecoratedShape_GetRefCount(const JPH_DecoratedShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::DecoratedShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_AddRef(const JPH_DecoratedShape *_this);

/// Generated from method `JPH::DecoratedShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DecoratedShape_Release(const JPH_DecoratedShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::DecoratedShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_DecoratedShape_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_DecoratedShape_OffsetPtr(const JPH_DecoratedShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_DecoratedShape_OffsetMutablePtr(JPH_DecoratedShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_DecoratedShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_DecoratedShape *object);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_DecoratedShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DecoratedShape_UpcastTo_JPH_NonCopyable(const JPH_DecoratedShape *object);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DecoratedShape_MutableUpcastTo_JPH_NonCopyable(JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_DecoratedShape_UpcastTo_JPH_Shape(const JPH_DecoratedShape *object);

/// Upcasts an instance of `JPH::DecoratedShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_DecoratedShape_MutableUpcastTo_JPH_Shape(JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::DecoratedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

#ifdef __cplusplus
} // extern "C"
#endif
