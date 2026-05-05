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
typedef struct JPH_RayCast JPH_RayCast; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RayCastResult JPH_RayCastResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CastResult.h>`.
typedef struct JPH_RayCastSettings JPH_RayCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_Stats JPH_Shape_Stats; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Shape used exclusively for soft bodies. Adds the ability to perform collision checks against soft bodies.
/// Generated from class `JPH::SoftBodyShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyShape JPH_SoftBodyShape;

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::SoftBodyShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_SoftBodyShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::SoftBodyShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_SoftBodyShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::SoftBodyShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_SoftBodyShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_SoftBodyShape_GetMutable_sDrawSubmergedVolumes(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyShape_DestroyArray()`.
/// Use `JPH_SoftBodyShape_OffsetMutablePtr()` and `JPH_SoftBodyShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyShape *JPH_SoftBodyShape_OffsetPtr(const JPH_SoftBodyShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_OffsetMutablePtr(JPH_SoftBodyShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_SoftBodyShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_SoftBodyShape *object);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_SoftBodyShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_SoftBodyShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SoftBodyShape_UpcastTo_JPH_NonCopyable(const JPH_SoftBodyShape *object);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SoftBodyShape_MutableUpcastTo_JPH_NonCopyable(JPH_SoftBodyShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_SoftBodyShape_UpcastTo_JPH_Shape(const JPH_SoftBodyShape *object);

/// Upcasts an instance of `JPH::SoftBodyShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_SoftBodyShape_MutableUpcastTo_JPH_Shape(JPH_SoftBodyShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::SoftBodyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Destroys a heap-allocated instance of `JPH_SoftBodyShape`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyShape_Destroy(const JPH_SoftBodyShape *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyShape`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyShape_DestroyArray(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodyShape_size_t(size_t inCount);

/// Generated from method `JPH::SoftBodyShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyShape_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodyShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SoftBodyShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodyShape_size_t(size_t inCount);

/// Generated from method `JPH::SoftBodyShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyShape_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodyShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SoftBodyShape::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodyShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SoftBodyShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodyShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodyShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SoftBodyShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Determine amount of bits needed to encode sub shape id
/// Generated from method `JPH::SoftBodyShape::GetSubShapeIDBits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyShape_GetSubShapeIDBits(const JPH_SoftBodyShape *_this);

/// Convert a sub shape ID back to a face index
/// Generated from method `JPH::SoftBodyShape::GetFaceIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyShape_GetFaceIndex(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape
/// Generated from method `JPH::SoftBodyShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyShape_MustBeStatic(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyShape_GetCenterOfMass(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_SoftBodyShape_GetLocalBounds(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyShape_GetSubShapeIDBitsRecursive(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyShape_GetInnerRadius(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_SoftBodyShape_GetMaterial(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Generated from method `JPH::SoftBodyShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyShape_GetSurfaceNormal(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

/// Generated from method `JPH::SoftBodyShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_GetSubmergedVolume(const JPH_SoftBodyShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

/// Generated from method `JPH::SoftBodyShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_Draw(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

/// Generated from method `JPH::SoftBodyShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyShape_CastRay_3(const JPH_SoftBodyShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

/// Generated from method `JPH::SoftBodyShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_GetTrianglesStart(const JPH_SoftBodyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

/// Generated from method `JPH::SoftBodyShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_SoftBodyShape_GetTrianglesNext(const JPH_SoftBodyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Generated from method `JPH::SoftBodyShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_SoftBodyShape_GetStats(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SoftBodyShape_GetVolume(const JPH_SoftBodyShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::SoftBodyShape::sRegister`.
JOLT_API void JPH_SoftBodyShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::SoftBodyShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SoftBodyShape_GetUserData(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_SetUserData(JPH_SoftBodyShape *_this, uint64_t inUserData);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::SoftBodyShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_SoftBodyShape_GetLeafShape(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::SoftBodyShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_SoftBodyShape_GetSubShapeUserData(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::SoftBodyShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_SoftBodyShape_GetSubShapeTransformedShape(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

/// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::SoftBodyShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_DrawGetSupportFunction(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

/// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::SoftBodyShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_DrawGetSupportingFace(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

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
/// Generated from method `JPH::SoftBodyShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyShape_IsValidScale(const JPH_SoftBodyShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::SoftBodyShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyShape_MakeScaleValid(const JPH_SoftBodyShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SoftBodyShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_SetEmbedded(const JPH_SoftBodyShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SoftBodyShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyShape_GetRefCount(const JPH_SoftBodyShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SoftBodyShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_AddRef(const JPH_SoftBodyShape *_this);

/// Generated from method `JPH::SoftBodyShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyShape_Release(const JPH_SoftBodyShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SoftBodyShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_SoftBodyShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
