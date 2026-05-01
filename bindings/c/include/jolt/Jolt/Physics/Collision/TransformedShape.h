// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_CollideShapeSettings JPH_CollideShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RRayCast JPH_RRayCast; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RShapeCast JPH_RShapeCast; // Defined in `#include <jolt/Jolt/Physics/Collision/ShapeCast.h>`.
typedef struct JPH_RayCastResult JPH_RayCastResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CastResult.h>`.
typedef struct JPH_RayCastSettings JPH_RayCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeCastSettings JPH_ShapeCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/ShapeCast.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Temporary data structure that contains a shape and a transform.
/// This structure can be obtained from a body (e.g. after a broad phase query) under lock protection.
/// The lock can then be released and collision detection operations can be safely performed since
/// the class takes a reference on the shape and does not use anything from the body anymore.
/// Generated from class `JPH::TransformedShape`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TransformedShape JPH_TransformedShape;

///< Center of mass world position of the shape
/// Returns a pointer to a member variable of class `JPH::TransformedShape` named `mShapePositionCOM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_TransformedShape_Get_mShapePositionCOM(const JPH_TransformedShape *_this);

///< Center of mass world position of the shape
/// Returns a mutable pointer to a member variable of class `JPH::TransformedShape` named `mShapePositionCOM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_TransformedShape_GetMutable_mShapePositionCOM(JPH_TransformedShape *_this);

///< Rotation of the shape
/// Returns a pointer to a member variable of class `JPH::TransformedShape` named `mShapeRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_TransformedShape_Get_mShapeRotation(const JPH_TransformedShape *_this);

///< Rotation of the shape
/// Returns a mutable pointer to a member variable of class `JPH::TransformedShape` named `mShapeRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_TransformedShape_GetMutable_mShapeRotation(JPH_TransformedShape *_this);

///< Not stored as Vec3 to get a nicely packed structure
/// Returns a pointer to a member variable of class `JPH::TransformedShape` named `mShapeScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Float3 *JPH_TransformedShape_Get_mShapeScale(const JPH_TransformedShape *_this);

///< Not stored as Vec3 to get a nicely packed structure
/// Returns a mutable pointer to a member variable of class `JPH::TransformedShape` named `mShapeScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Float3 *JPH_TransformedShape_GetMutable_mShapeScale(JPH_TransformedShape *_this);

///< Optional body ID from which this shape comes
/// Returns a pointer to a member variable of class `JPH::TransformedShape` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_TransformedShape_Get_mBodyID(const JPH_TransformedShape *_this);

///< Optional body ID from which this shape comes
/// Modifies a member variable of class `JPH::TransformedShape` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID`.
/// When this function is called, this object will drop object references it held previously in `mBodyID`.
JOLT_API void JPH_TransformedShape_Set_mBodyID(JPH_TransformedShape *_this, JPH_BodyID value);

///< Optional body ID from which this shape comes
/// Returns a mutable pointer to a member variable of class `JPH::TransformedShape` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_TransformedShape_GetMutable_mBodyID(JPH_TransformedShape *_this);

///< Optional sub shape ID creator for the shape (can be used when expanding compound shapes into multiple transformed shapes)
/// Returns a pointer to a member variable of class `JPH::TransformedShape` named `mSubShapeIDCreator`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeIDCreator *JPH_TransformedShape_Get_mSubShapeIDCreator(const JPH_TransformedShape *_this);

///< Optional sub shape ID creator for the shape (can be used when expanding compound shapes into multiple transformed shapes)
/// Modifies a member variable of class `JPH::TransformedShape` named `mSubShapeIDCreator`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeIDCreator`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeIDCreator`.
JOLT_API void JPH_TransformedShape_Set_mSubShapeIDCreator(JPH_TransformedShape *_this, const JPH_SubShapeIDCreator *value);

///< Optional sub shape ID creator for the shape (can be used when expanding compound shapes into multiple transformed shapes)
/// Returns a mutable pointer to a member variable of class `JPH::TransformedShape` named `mSubShapeIDCreator`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeIDCreator *JPH_TransformedShape_GetMutable_mSubShapeIDCreator(JPH_TransformedShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TransformedShape_DestroyArray()`.
/// Use `JPH_TransformedShape_OffsetMutablePtr()` and `JPH_TransformedShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TransformedShape *JPH_TransformedShape_OffsetPtr(const JPH_TransformedShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_OffsetMutablePtr(JPH_TransformedShape *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::TransformedShape::TransformedShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TransformedShape *_other);

/// Generated from constructor `JPH::TransformedShape::TransformedShape`.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` is a single object.
/// Parameter `inSubShapeIDCreator` has a default argument: `JPH::SubShapeIDCreator()`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_Construct(const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Shape *inShape, const JPH_BodyID *inBodyID, const JPH_SubShapeIDCreator *inSubShapeIDCreator);

/// Destroys a heap-allocated instance of `JPH_TransformedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TransformedShape_Destroy(const JPH_TransformedShape *_this);

/// Destroys a heap-allocated array of `JPH_TransformedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TransformedShape_DestroyArray(const JPH_TransformedShape *_this);

/// Generated from method `JPH::TransformedShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_AssignFromAnother(JPH_TransformedShape *_this, Jolt_PassBy _other_pass_by, JPH_TransformedShape *_other);

/// Generated from method `JPH::TransformedShape::operator new`.
JOLT_API void *Jolt_new_JPH_TransformedShape_size_t(size_t inCount);

/// Generated from method `JPH::TransformedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TransformedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TransformedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TransformedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TransformedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TransformedShape_size_t(size_t inCount);

/// Generated from method `JPH::TransformedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TransformedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TransformedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TransformedShape::operator new`.
JOLT_API void *Jolt_new_JPH_TransformedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TransformedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TransformedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TransformedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TransformedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Cast a ray and find the closest hit. Returns true if it finds a hit. Hits further than ioHit.mFraction will not be considered and in this case ioHit will remain unmodified (and the function will return false).
/// Convex objects will be treated as solid (meaning if the ray starts inside, you'll get a hit fraction of 0) and back face hits are returned.
/// If you want the surface normal of the hit use GetWorldSpaceSurfaceNormal(ioHit.mSubShapeID2, inRay.GetPointOnRay(ioHit.mFraction)) on this object.
/// Generated from method `JPH::TransformedShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_TransformedShape_CastRay_2(const JPH_TransformedShape *_this, const JPH_RRayCast *inRay, JPH_RayCastResult *ioHit);

/// To start iterating over triangles, call this function first.
/// To get the actual triangles call GetTrianglesNext.
/// @param ioContext A temporary buffer and should remain untouched until the last call to GetTrianglesNext.
/// @param inBox The world space bounding in which you want to get the triangles.
/// @param inBaseOffset All hit results will be returned relative to this offset, can be zero to get results in world position, but when you're testing far from the origin you get better precision by picking a position that's closer e.g. inBox.GetCenter() since floats are most accurate near the origin
/// Generated from method `JPH::TransformedShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_TransformedShape_GetTrianglesStart(const JPH_TransformedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inBaseOffset);

/// Call this repeatedly to get all triangles in the box.
/// outTriangleVertices should be large enough to hold 3 * inMaxTriangleRequested entries
/// outMaterials (if it is not null) should contain inMaxTrianglesRequested entries
/// The function returns the amount of triangles that it found (which will be <= inMaxTrianglesRequested), or 0 if there are no more triangles.
/// Note that the function can return a value < inMaxTrianglesRequested and still have more triangles to process (triangles can be returned in blocks)
/// Note that the function may return triangles outside of the requested box, only coarse culling is performed on the returned triangles
/// Generated from method `JPH::TransformedShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_TransformedShape_GetTrianglesNext(const JPH_TransformedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Get/set the scale of the shape as a Vec3
/// Generated from method `JPH::TransformedShape::GetShapeScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TransformedShape_GetShapeScale(const JPH_TransformedShape *_this);

/// Generated from method `JPH::TransformedShape::SetShapeScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_TransformedShape_SetShapeScale(JPH_TransformedShape *_this, const JPH_Vec3 *inScale);

/// Calculates the transform for this shape's center of mass (excluding scale)
/// Generated from method `JPH::TransformedShape::GetCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_TransformedShape_GetCenterOfMassTransform(const JPH_TransformedShape *_this);

/// Calculates the inverse of the transform for this shape's center of mass (excluding scale)
/// Generated from method `JPH::TransformedShape::GetInverseCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_TransformedShape_GetInverseCenterOfMassTransform(const JPH_TransformedShape *_this);

/// Sets the world transform (including scale) of this transformed shape (not from the center of mass but in the space the shape was created)
/// Generated from method `JPH::TransformedShape::SetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_TransformedShape_SetWorldTransform_3(JPH_TransformedShape *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

/// Sets the world transform (including scale) of this transformed shape (not from the center of mass but in the space the shape was created)
/// Generated from method `JPH::TransformedShape::SetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
JOLT_API void JPH_TransformedShape_SetWorldTransform_1(JPH_TransformedShape *_this, const JPH_Mat44 *inTransform);

/// Calculates the world transform including scale of this shape (not from the center of mass but in the space the shape was created)
/// Generated from method `JPH::TransformedShape::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_TransformedShape_GetWorldTransform(const JPH_TransformedShape *_this);

/// Get the world space bounding box for this transformed shape
/// Generated from method `JPH::TransformedShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_TransformedShape_GetWorldSpaceBounds(const JPH_TransformedShape *_this);

/// Make inSubShapeID relative to mShape. When mSubShapeIDCreator is not empty, this is needed in order to get the correct path to the sub shape.
/// Generated from method `JPH::TransformedShape::MakeSubShapeIDRelativeToShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_TransformedShape_MakeSubShapeIDRelativeToShape(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get surface normal of a particular sub shape and its world space surface position on this body.
/// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetWorldSpaceSurfaceNormal will only return face normals (and not vertex or edge normals).
/// Generated from method `JPH::TransformedShape::GetWorldSpaceSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TransformedShape_GetWorldSpaceSurfaceNormal(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPosition);

/// Get material of a particular sub shape
/// Generated from method `JPH::TransformedShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_TransformedShape_GetMaterial(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the user data of a particular sub shape
/// Generated from method `JPH::TransformedShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_TransformedShape_GetSubShapeUserData(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::TransformedShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_TransformedShape_GetSubShapeTransformedShape(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Helper function to return the body id from a transformed shape. If the transformed shape is null an invalid body ID will be returned.
/// Generated from method `JPH::TransformedShape::sGetBodyID`.
JOLT_API JPH_BodyID JPH_TransformedShape_sGetBodyID(const JPH_TransformedShape *inTS);

#ifdef __cplusplus
} // extern "C"
#endif
