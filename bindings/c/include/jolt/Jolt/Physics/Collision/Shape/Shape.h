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
typedef struct JPH_DMat44 JPH_DMat44; // Defined in `#include <jolt/Jolt/Math/DMat44.h>`.
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
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that can construct shapes and that is serializable using the ObjectStream system.
/// Can be used to store shape data in 'uncooked' form (i.e. in a form that is still human readable and authorable).
/// Once the shape has been created using the Create() function, the data will be moved into the Shape class
/// in a form that is optimized for collision detection. After this, the ShapeSettings object is no longer needed
/// and can be destroyed. Each shape class has a derived class of the ShapeSettings object to store shape specific
/// data.
/// Generated from class `JPH::ShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShapeSettings`
///     `JPH::ConvexShapeSettings`
///     `JPH::DecoratedShapeSettings`
///     `JPH::EmptyShapeSettings`
///     `JPH::HeightFieldShapeSettings`
///     `JPH::MeshShapeSettings`
///     `JPH::PlaneShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::BoxShapeSettings`
///     `JPH::CapsuleShapeSettings`
///     `JPH::ConvexHullShapeSettings`
///     `JPH::CylinderShapeSettings`
///     `JPH::MutableCompoundShapeSettings`
///     `JPH::OffsetCenterOfMassShapeSettings`
///     `JPH::RotatedTranslatedShapeSettings`
///     `JPH::ScaledShapeSettings`
///     `JPH::SphereShapeSettings`
///     `JPH::StaticCompoundShapeSettings`
///     `JPH::TaperedCapsuleShapeSettings`
///     `JPH::TaperedCylinderShapeSettings`
///     `JPH::TriangleShapeSettings`
typedef struct JPH_ShapeSettings JPH_ShapeSettings;

/// An opaque buffer that holds shape specific information during GetTrianglesStart/Next.
/// Generated from class `JPH::Shape::GetTrianglesContext`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext;

/// Class that holds information about the shape that can be used for logging / data collection purposes
/// Generated from class `JPH::Shape::Stats`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Shape_Stats JPH_Shape_Stats;

/// Base class for all shapes (collision volume of a body). Defines a virtual interface for collision detection.
/// Generated from class `JPH::Shape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShape`
///     `JPH::ConvexShape`
///     `JPH::DecoratedShape`
///     `JPH::EmptyShape`
///     `JPH::HeightFieldShape`
///     `JPH::MeshShape`
///     `JPH::PlaneShape`
///   Indirect: (non-virtual)
///     `JPH::BoxShape`
///     `JPH::CapsuleShape`
///     `JPH::ConvexHullShape`
///     `JPH::CylinderShape`
///     `JPH::MutableCompoundShape`
///     `JPH::OffsetCenterOfMassShape`
///     `JPH::RotatedTranslatedShape`
///     `JPH::ScaledShape`
///     `JPH::SphereShape`
///     `JPH::StaticCompoundShape`
///     `JPH::TaperedCapsuleShape`
///     `JPH::TaperedCylinderShape`
///     `JPH::TriangleShape`
typedef struct JPH_Shape JPH_Shape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ShapeSettings_Get_mUserData(const JPH_ShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ShapeSettings_Set_mUserData(JPH_ShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ShapeSettings_GetMutable_mUserData(JPH_ShapeSettings *_this);

/// Destroys a heap-allocated instance of `JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeSettings_Destroy(const JPH_ShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeSettings_DestroyArray(const JPH_ShapeSettings *_this);

/// Generated from method `JPH::ShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_ClearCachedResult(JPH_ShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_SetEmbedded(const JPH_ShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ShapeSettings_GetRefCount(const JPH_ShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_AddRef(const JPH_ShapeSettings *_this);

/// Generated from method `JPH::ShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_Release(const JPH_ShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ShapeSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_OffsetPtr(const JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_OffsetMutablePtr(JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::Shape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_Shape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::Shape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_Shape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::Shape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_Shape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::Shape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_Shape_GetMutable_sDrawSubmergedVolumes(void);

/// Destroys a heap-allocated instance of `JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Destroy(const JPH_Shape *_this);

/// Destroys a heap-allocated array of `JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_DestroyArray(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::operator new`.
JOLT_API void *Jolt_new_JPH_Shape_size_t(size_t inCount);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr(void *inPointer);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Shape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Shape_size_t(size_t inCount);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr(void *inPointer);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Shape::operator new`.
JOLT_API void *Jolt_new_JPH_Shape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Shape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Shape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// User data (to be used freely by the application)
/// Generated from method `JPH::Shape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_Shape_GetUserData(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_SetUserData(JPH_Shape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::Shape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Shape_MustBeStatic(const JPH_Shape *_this);

/// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
/// Generated from method `JPH::Shape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Shape_GetCenterOfMass(const JPH_Shape *_this);

/// Get local bounding box including convex radius, this box is centered around the center of mass rather than the world transform
/// Generated from method `JPH::Shape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_Shape_GetLocalBounds(const JPH_Shape *_this);

/// Get the max number of sub shape ID bits that are needed to be able to address any leaf shape in this shape. Used mainly for checking that it is smaller or equal than SubShapeID::MaxBits.
/// Generated from method `JPH::Shape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Shape_GetSubShapeIDBitsRecursive(const JPH_Shape *_this);

/// Get world space bounds including convex radius.
/// This shape is scaled by inScale in local space first.
/// This function can be overridden to return a closer fitting world space bounding box, by default it will just transform what GetLocalBounds() returns.
/// Generated from method `JPH::Shape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_Shape_GetWorldSpaceBounds_JPH_Mat44(const JPH_Shape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Get world space bounds including convex radius.
/// Generated from method `JPH::Shape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_Shape_GetWorldSpaceBounds_JPH_DMat44(const JPH_Shape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Returns the radius of the biggest sphere that fits entirely in the shape. In case this shape consists of multiple sub shapes, it returns the smallest sphere of the parts.
/// This can be used as a measure of how far the shape can be moved without risking going through geometry.
/// Generated from method `JPH::Shape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Shape_GetInnerRadius(const JPH_Shape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::Shape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_Shape_GetLeafShape(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the material assigned to a particular sub shape ID
/// Generated from method `JPH::Shape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_Shape_GetMaterial(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the surface normal of a particular sub shape ID and point on surface (all vectors are relative to center of mass for this shape).
/// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetSurfaceNormal will only return face normals (and not vertex or edge normals).
/// Generated from method `JPH::Shape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Shape_GetSurfaceNormal(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::Shape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_Shape_GetSubShapeUserData(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::Shape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_Shape_GetSubShapeTransformedShape(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

/// Generated from method `JPH::Shape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_Shape_GetSubmergedVolume(const JPH_Shape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

/// Draw the shape at a particular location with a particular color (debugging purposes)
/// Generated from method `JPH::Shape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_Shape_Draw(const JPH_Shape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

/// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::Shape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_Shape_DrawGetSupportFunction(const JPH_Shape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

/// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::Shape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_Shape_DrawGetSupportingFace(const JPH_Shape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Cast a ray against this shape, returns true if it finds a hit closer than ioHit.mFraction and updates that fraction. Otherwise ioHit is left untouched and the function returns false.
/// Note that the ray should be relative to the center of mass of this shape (i.e. subtract Shape::GetCenterOfMass() from RayCast::mOrigin if you want to cast against the shape in the space it was created).
/// Convex objects will be treated as solid (meaning if the ray starts inside, you'll get a hit fraction of 0) and back face hits against triangles are returned.
/// If you want the surface normal of the hit use GetSurfaceNormal(ioHit.mSubShapeID2, inRay.GetPointOnRay(ioHit.mFraction)).
/// Generated from method `JPH::Shape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_Shape_CastRay_3(const JPH_Shape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

/// To start iterating over triangles, call this function first.
/// ioContext is a temporary buffer and should remain untouched until the last call to GetTrianglesNext.
/// inBox is the world space bounding in which you want to get the triangles.
/// inPositionCOM/inRotation/inScale describes the transform of this shape.
/// To get the actual triangles call GetTrianglesNext.
/// Generated from method `JPH::Shape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_Shape_GetTrianglesStart(const JPH_Shape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

/// Call this repeatedly to get all triangles in the box.
/// outTriangleVertices should be large enough to hold 3 * inMaxTriangleRequested entries.
/// outMaterials (if it is not null) should contain inMaxTrianglesRequested entries.
/// The function returns the amount of triangles that it found (which will be <= inMaxTrianglesRequested), or 0 if there are no more triangles.
/// Note that the function can return a value < inMaxTrianglesRequested and still have more triangles to process (triangles can be returned in blocks).
/// Note that the function may return triangles outside of the requested box, only coarse culling is performed on the returned triangles.
/// Generated from method `JPH::Shape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_Shape_GetTrianglesNext(const JPH_Shape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
/// Generated from method `JPH::Shape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_GetStats(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Shape_GetVolume(const JPH_Shape *_this);

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
/// Generated from method `JPH::Shape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_Shape_IsValidScale(const JPH_Shape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::Shape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Shape_MakeScaleValid(const JPH_Shape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::Shape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_SetEmbedded(const JPH_Shape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::Shape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Shape_GetRefCount(const JPH_Shape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::Shape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_AddRef(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_Release(const JPH_Shape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::Shape::sInternalGetRefCountOffset`.
JOLT_API int JPH_Shape_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_OffsetPtr(const JPH_Shape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_OffsetMutablePtr(JPH_Shape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_Shape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Shape_UpcastTo_JPH_NonCopyable(const JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Shape_MutableUpcastTo_JPH_NonCopyable(JPH_Shape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Returns a pointer to a member variable of class `JPH::Shape::GetTrianglesContext` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned char *JPH_Shape_GetTrianglesContext_Get_mData(const JPH_Shape_GetTrianglesContext *_this);

/// Returns a mutable pointer to a member variable of class `JPH::Shape::GetTrianglesContext` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned char *JPH_Shape_GetTrianglesContext_GetMutable_mData(JPH_Shape_GetTrianglesContext *_this);

/// Returns the size of the array member of class `JPH::Shape::GetTrianglesContext` named `mData`. The size is `4288`.
JOLT_API size_t JPH_Shape_GetTrianglesContext_GetSize_mData(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_GetTrianglesContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Shape_GetTrianglesContext_DestroyArray()`.
/// Use `JPH_Shape_GetTrianglesContext_OffsetMutablePtr()` and `JPH_Shape_GetTrianglesContext_OffsetPtr()` to access the array elements.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetPtr(const JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetMutablePtr(JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_GetTrianglesContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_ConstructFromAnother(const JPH_Shape_GetTrianglesContext *_other);

/// Destroys a heap-allocated instance of `JPH_Shape_GetTrianglesContext`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_GetTrianglesContext_Destroy(const JPH_Shape_GetTrianglesContext *_this);

/// Destroys a heap-allocated array of `JPH_Shape_GetTrianglesContext`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_GetTrianglesContext_DestroyArray(const JPH_Shape_GetTrianglesContext *_this);

/// Generated from method `JPH::Shape::GetTrianglesContext::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_AssignFromAnother(JPH_Shape_GetTrianglesContext *_this, const JPH_Shape_GetTrianglesContext *_other);

///< Amount of memory used by this shape (size in bytes)
/// Returns a pointer to a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const size_t *JPH_Shape_Stats_Get_mSizeBytes(const JPH_Shape_Stats *_this);

///< Amount of memory used by this shape (size in bytes)
/// Modifies a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSizeBytes`.
/// When this function is called, this object will drop object references it held previously in `mSizeBytes`.
JOLT_API void JPH_Shape_Stats_Set_mSizeBytes(JPH_Shape_Stats *_this, size_t value);

///< Amount of memory used by this shape (size in bytes)
/// Returns a mutable pointer to a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API size_t *JPH_Shape_Stats_GetMutable_mSizeBytes(JPH_Shape_Stats *_this);

///< Number of triangles in this shape (when applicable)
/// Returns a pointer to a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_Shape_Stats_Get_mNumTriangles(const JPH_Shape_Stats *_this);

///< Number of triangles in this shape (when applicable)
/// Modifies a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumTriangles`.
/// When this function is called, this object will drop object references it held previously in `mNumTriangles`.
JOLT_API void JPH_Shape_Stats_Set_mNumTriangles(JPH_Shape_Stats *_this, unsigned int value);

///< Number of triangles in this shape (when applicable)
/// Returns a mutable pointer to a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_Shape_Stats_GetMutable_mNumTriangles(JPH_Shape_Stats *_this);

/// Generated from constructor `JPH::Shape::Stats::Stats`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_ConstructFromAnother(const JPH_Shape_Stats *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape_Stats *JPH_Shape_Stats_OffsetPtr(const JPH_Shape_Stats *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_OffsetMutablePtr(JPH_Shape_Stats *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Shape::Stats::Stats`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_Construct(size_t inSizeBytes, unsigned int inNumTriangles);

/// Destroys a heap-allocated instance of `JPH_Shape_Stats`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Stats_Destroy(const JPH_Shape_Stats *_this);

/// Destroys a heap-allocated array of `JPH_Shape_Stats`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Stats_DestroyArray(const JPH_Shape_Stats *_this);

/// Generated from method `JPH::Shape::Stats::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_AssignFromAnother(JPH_Shape_Stats *_this, const JPH_Shape_Stats *_other);

#ifdef __cplusplus
} // extern "C"
#endif
