// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Collision/ActiveEdgeMode.h>
#include <jolt/Jolt/Physics/Collision/BackFaceMode.h>
#include <jolt/Jolt/Physics/Collision/CollectFacesMode.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_CollideSettingsBase JPH_CollideSettingsBase; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_CollideShapeResult JPH_CollideShapeResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
/// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ShapeCast`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast;

/// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
/// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RShapeCast`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast;

/// Generated from class `JPH::ShapeCast`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeCast JPH_ShapeCast;

/// Generated from class `JPH::RShapeCast`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RShapeCast JPH_RShapeCast;

/// Settings to be passed with a shape cast
/// Generated from class `JPH::ShapeCastSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CollideSettingsBase`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeCastSettings JPH_ShapeCastSettings;

/// Result of a shape cast test
/// Generated from class `JPH::ShapeCastResult`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CollideShapeResult`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeCastResult JPH_ShapeCastResult;

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape *const *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Modifies a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mShape`.
/// When this function is called, this object will drop object references it held previously in `mShape`.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Set_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Shape *value);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape **JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

///< Scale in local space of the shape being cast (scales relative to its center of mass)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mCenterOfMassStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

///< Cached shape's world bounds, calculated in constructor
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` named `mShapeWorldBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_OffsetPtr(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_OffsetMutablePtr(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *ptr, ptrdiff_t i);

/// Constructor
/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inWorldSpaceBounds` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds);

/// Constructor
/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

/// Destroys a heap-allocated array of `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_DestroyArray(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Construct a shape cast using a world transform for a shape instead of a center of mass transform
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::sFromWorldTransform`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inWorldTransform` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection);

/// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::PostTransformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Mat44 *inTransform);

/// Translate this shape cast by inTranslation.
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, float inFraction);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape *const *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Modifies a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mShape`.
/// When this function is called, this object will drop object references it held previously in `mShape`.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Set_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Shape *value);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape **JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

///< Scale in local space of the shape being cast (scales relative to its center of mass)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mCenterOfMassStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

///< Cached shape's world bounds, calculated in constructor
/// Returns a pointer to a member variable of class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` named `mShapeWorldBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_OffsetPtr(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_OffsetMutablePtr(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *ptr, ptrdiff_t i);

/// Constructor
/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inWorldSpaceBounds` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds);

/// Constructor
/// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

/// Destroys a heap-allocated array of `JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_DestroyArray(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Construct a shape cast using a world transform for a shape instead of a center of mass transform
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::sFromWorldTransform`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inWorldTransform` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection);

/// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::PostTransformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Mat44 *inTransform);

/// Translate this shape cast by inTranslation.
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, float inFraction);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a pointer to a member variable of class `JPH::ShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape *const *JPH_ShapeCast_Get_mShape(const JPH_ShapeCast *_this);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Modifies a member variable of class `JPH::ShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mShape`.
/// When this function is called, this object will drop object references it held previously in `mShape`.
JOLT_API void JPH_ShapeCast_Set_mShape(JPH_ShapeCast *_this, const JPH_Shape *value);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape **JPH_ShapeCast_GetMutable_mShape(JPH_ShapeCast *_this);

///< Scale in local space of the shape being cast (scales relative to its center of mass)
/// Returns a pointer to a member variable of class `JPH::ShapeCast` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCast_Get_mScale(const JPH_ShapeCast *_this);

///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
/// Returns a pointer to a member variable of class `JPH::ShapeCast` named `mCenterOfMassStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_ShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::ShapeCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCast_Get_mDirection(const JPH_ShapeCast *_this);

///< Cached shape's world bounds, calculated in constructor
/// Returns a pointer to a member variable of class `JPH::ShapeCast` named `mShapeWorldBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_ShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCast *_this);

/// Generated from constructor `JPH::ShapeCast::ShapeCast`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_ConstructFromAnother(const JPH_ShapeCast *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeCast *JPH_ShapeCast_OffsetPtr(const JPH_ShapeCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_OffsetMutablePtr(JPH_ShapeCast *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeCast` to its base class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(const JPH_ShapeCast *object);

/// Upcasts an instance of `JPH::ShapeCast` to its base class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCast_MutableUpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH_ShapeCast *object);

/// Downcasts an instance of `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` to a derived class `JPH::ShapeCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeCast *JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *object);

/// Downcasts an instance of `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>` to a derived class `JPH::ShapeCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_MutableStaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *object);

/// Constructor
/// Generated from constructor `JPH::ShapeCast::ShapeCast`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inWorldSpaceBounds` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds);

/// Constructor
/// Generated from constructor `JPH::ShapeCast::ShapeCast`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_ShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCast_Destroy(const JPH_ShapeCast *_this);

/// Destroys a heap-allocated array of `JPH_ShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCast_DestroyArray(const JPH_ShapeCast *_this);

/// Construct a shape cast using a world transform for a shape instead of a center of mass transform
/// Generated from method `JPH::ShapeCast::sFromWorldTransform`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inWorldTransform` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection);

/// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
/// Generated from method `JPH::ShapeCast::PostTransformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_PostTransformed(const JPH_ShapeCast *_this, const JPH_Mat44 *inTransform);

/// Translate this shape cast by inTranslation.
/// Generated from method `JPH::ShapeCast::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_ShapeCast_PostTranslated(const JPH_ShapeCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::ShapeCast::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ShapeCast_GetPointOnRay(const JPH_ShapeCast *_this, float inFraction);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a pointer to a member variable of class `JPH::RShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape *const *JPH_RShapeCast_Get_mShape(const JPH_RShapeCast *_this);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Modifies a member variable of class `JPH::RShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mShape`.
/// When this function is called, this object will drop object references it held previously in `mShape`.
JOLT_API void JPH_RShapeCast_Set_mShape(JPH_RShapeCast *_this, const JPH_Shape *value);

///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
/// Returns a mutable pointer to a member variable of class `JPH::RShapeCast` named `mShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Shape **JPH_RShapeCast_GetMutable_mShape(JPH_RShapeCast *_this);

///< Scale in local space of the shape being cast (scales relative to its center of mass)
/// Returns a pointer to a member variable of class `JPH::RShapeCast` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RShapeCast_Get_mScale(const JPH_RShapeCast *_this);

///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
/// Returns a pointer to a member variable of class `JPH::RShapeCast` named `mCenterOfMassStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_RShapeCast_Get_mCenterOfMassStart(const JPH_RShapeCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::RShapeCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RShapeCast_Get_mDirection(const JPH_RShapeCast *_this);

///< Cached shape's world bounds, calculated in constructor
/// Returns a pointer to a member variable of class `JPH::RShapeCast` named `mShapeWorldBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_RShapeCast_Get_mShapeWorldBounds(const JPH_RShapeCast *_this);

/// Generated from constructor `JPH::RShapeCast::RShapeCast`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_ConstructFromAnother(const JPH_RShapeCast *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RShapeCast *JPH_RShapeCast_OffsetPtr(const JPH_RShapeCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_OffsetMutablePtr(JPH_RShapeCast *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RShapeCast` to its base class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(const JPH_RShapeCast *object);

/// Upcasts an instance of `JPH::RShapeCast` to its base class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_RShapeCast_MutableUpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH_RShapeCast *object);

/// Downcasts an instance of `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` to a derived class `JPH::RShapeCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RShapeCast *JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *object);

/// Downcasts an instance of `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>` to a derived class `JPH::RShapeCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_MutableStaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *object);

/// Constructor
/// Generated from constructor `JPH::RShapeCast::RShapeCast`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inWorldSpaceBounds` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds);

/// Constructor
/// Generated from constructor `JPH::RShapeCast::RShapeCast`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inCenterOfMassStart` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection);

/// Convert from ShapeCast, converts single to double precision
/// Generated from constructor `JPH::RShapeCast::RShapeCast`.
/// Parameter `inCast` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_Construct_1(const JPH_ShapeCast *inCast);

/// Destroys a heap-allocated instance of `JPH_RShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RShapeCast_Destroy(const JPH_RShapeCast *_this);

/// Destroys a heap-allocated array of `JPH_RShapeCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RShapeCast_DestroyArray(const JPH_RShapeCast *_this);

/// Convert to ShapeCast, which implies casting from double precision to single precision
/// Generated from conversion operator `JPH::RShapeCast::operator JPH::ShapeCast`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCast *JPH_RShapeCast_ConvertTo_JPH_ShapeCast(const JPH_RShapeCast *_this);

/// Construct a shape cast using a world transform for a shape instead of a center of mass transform
/// Generated from method `JPH::RShapeCast::sFromWorldTransform`.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inWorldTransform` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection);

/// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
/// Generated from method `JPH::RShapeCast::PostTransformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_PostTransformed(const JPH_RShapeCast *_this, const JPH_Mat44 *inTransform);

/// Translate this shape cast by inTranslation.
/// Generated from method `JPH::RShapeCast::PostTranslated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RShapeCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RShapeCast *JPH_RShapeCast_PostTranslated(const JPH_RShapeCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::RShapeCast::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RShapeCast_GetPointOnRay(const JPH_RShapeCast *_this, float inFraction);

/// How backfacing triangles should be treated (should we report moving from back to front for triangle based shapes, e.g. for MeshShape/HeightFieldShape?)
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_ShapeCastSettings_Get_mBackFaceModeTriangles(const JPH_ShapeCastSettings *_this);

/// How backfacing triangles should be treated (should we report moving from back to front for triangle based shapes, e.g. for MeshShape/HeightFieldShape?)
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceModeTriangles`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceModeTriangles`.
JOLT_API void JPH_ShapeCastSettings_Set_mBackFaceModeTriangles(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode value);

/// How backfacing triangles should be treated (should we report moving from back to front for triangle based shapes, e.g. for MeshShape/HeightFieldShape?)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles(JPH_ShapeCastSettings *_this);

/// How backfacing convex objects should be treated (should we report starting inside an object and moving out?)
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_ShapeCastSettings_Get_mBackFaceModeConvex(const JPH_ShapeCastSettings *_this);

/// How backfacing convex objects should be treated (should we report starting inside an object and moving out?)
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceModeConvex`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceModeConvex`.
JOLT_API void JPH_ShapeCastSettings_Set_mBackFaceModeConvex(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode value);

/// How backfacing convex objects should be treated (should we report starting inside an object and moving out?)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex(JPH_ShapeCastSettings *_this);

/// Indicates if we want to shrink the shape by the convex radius and then expand it again. This speeds up collision detection and gives a more accurate normal at the cost of a more 'rounded' shape.
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mUseShrunkenShapeAndConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius(const JPH_ShapeCastSettings *_this);

/// Indicates if we want to shrink the shape by the convex radius and then expand it again. This speeds up collision detection and gives a more accurate normal at the cost of a more 'rounded' shape.
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mUseShrunkenShapeAndConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseShrunkenShapeAndConvexRadius`.
JOLT_API void JPH_ShapeCastSettings_Set_mUseShrunkenShapeAndConvexRadius(JPH_ShapeCastSettings *_this, bool value);

/// Indicates if we want to shrink the shape by the convex radius and then expand it again. This speeds up collision detection and gives a more accurate normal at the cost of a more 'rounded' shape.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mUseShrunkenShapeAndConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius(JPH_ShapeCastSettings *_this);

/// When true, and the shape is intersecting at the beginning of the cast (fraction = 0) then this will calculate the deepest penetration point (costing additional CPU time)
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mReturnDeepestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_ShapeCastSettings_Get_mReturnDeepestPoint(const JPH_ShapeCastSettings *_this);

/// When true, and the shape is intersecting at the beginning of the cast (fraction = 0) then this will calculate the deepest penetration point (costing additional CPU time)
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mReturnDeepestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mReturnDeepestPoint`.
JOLT_API void JPH_ShapeCastSettings_Set_mReturnDeepestPoint(JPH_ShapeCastSettings *_this, bool value);

/// When true, and the shape is intersecting at the beginning of the cast (fraction = 0) then this will calculate the deepest penetration point (costing additional CPU time)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mReturnDeepestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint(JPH_ShapeCastSettings *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EActiveEdgeMode *JPH_ShapeCastSettings_Get_mActiveEdgeMode(const JPH_ShapeCastSettings *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mActiveEdgeMode`.
/// When this function is called, this object will drop object references it held previously in `mActiveEdgeMode`.
JOLT_API void JPH_ShapeCastSettings_Set_mActiveEdgeMode(JPH_ShapeCastSettings *_this, JPH_EActiveEdgeMode value);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EActiveEdgeMode *JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode(JPH_ShapeCastSettings *_this);

/// If colliding faces should be collected or only the collision point
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ECollectFacesMode *JPH_ShapeCastSettings_Get_mCollectFacesMode(const JPH_ShapeCastSettings *_this);

/// If colliding faces should be collected or only the collision point
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollectFacesMode`.
/// When this function is called, this object will drop object references it held previously in `mCollectFacesMode`.
JOLT_API void JPH_ShapeCastSettings_Set_mCollectFacesMode(JPH_ShapeCastSettings *_this, JPH_ECollectFacesMode value);

/// If colliding faces should be collected or only the collision point
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ECollectFacesMode *JPH_ShapeCastSettings_GetMutable_mCollectFacesMode(JPH_ShapeCastSettings *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ShapeCastSettings_Get_mCollisionTolerance(const JPH_ShapeCastSettings *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollisionTolerance`.
JOLT_API void JPH_ShapeCastSettings_Set_mCollisionTolerance(JPH_ShapeCastSettings *_this, float value);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ShapeCastSettings_GetMutable_mCollisionTolerance(JPH_ShapeCastSettings *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ShapeCastSettings_Get_mPenetrationTolerance(const JPH_ShapeCastSettings *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Modifies a member variable of class `JPH::ShapeCastSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationTolerance`.
JOLT_API void JPH_ShapeCastSettings_Set_mPenetrationTolerance(JPH_ShapeCastSettings *_this, float value);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance(JPH_ShapeCastSettings *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a pointer to a member variable of class `JPH::ShapeCastSettings` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection(const JPH_ShapeCastSettings *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastSettings` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection(JPH_ShapeCastSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ShapeCastSettings_DestroyArray()`.
/// Use `JPH_ShapeCastSettings_OffsetMutablePtr()` and `JPH_ShapeCastSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeCastSettings *JPH_ShapeCastSettings_OffsetPtr(const JPH_ShapeCastSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_OffsetMutablePtr(JPH_ShapeCastSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeCastSettings` to its base class `JPH::CollideSettingsBase`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CollideSettingsBase *JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(const JPH_ShapeCastSettings *object);

/// Upcasts an instance of `JPH::ShapeCastSettings` to its base class `JPH::CollideSettingsBase`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CollideSettingsBase *JPH_ShapeCastSettings_MutableUpcastTo_JPH_CollideSettingsBase(JPH_ShapeCastSettings *object);

/// Downcasts an instance of `JPH::CollideSettingsBase` to a derived class `JPH::ShapeCastSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeCastSettings *JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(const JPH_CollideSettingsBase *object);

/// Downcasts an instance of `JPH::CollideSettingsBase` to a derived class `JPH::ShapeCastSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_MutableStaticDowncastFrom_JPH_CollideSettingsBase(JPH_CollideSettingsBase *object);

/// Generated from constructor `JPH::ShapeCastSettings::ShapeCastSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_ConstructFromAnother(const JPH_ShapeCastSettings *_other);

/// Destroys a heap-allocated instance of `JPH_ShapeCastSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastSettings_Destroy(const JPH_ShapeCastSettings *_this);

/// Destroys a heap-allocated array of `JPH_ShapeCastSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastSettings_DestroyArray(const JPH_ShapeCastSettings *_this);

/// Generated from method `JPH::ShapeCastSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ShapeCastSettings *JPH_ShapeCastSettings_AssignFromAnother(JPH_ShapeCastSettings *_this, const JPH_ShapeCastSettings *_other);

/// Generated from method `JPH::ShapeCastSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastSettings_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastSettings_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeCastSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the backfacing mode for all shapes
/// Generated from method `JPH::ShapeCastSettings::SetBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeCastSettings_SetBackFaceMode(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode inMode);

///< This is the fraction where the shape hit the other shape: CenterOfMassOnHit = Start + value * (End - Start)
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ShapeCastResult_Get_mFraction(const JPH_ShapeCastResult *_this);

///< This is the fraction where the shape hit the other shape: CenterOfMassOnHit = Start + value * (End - Start)
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFraction`.
JOLT_API void JPH_ShapeCastResult_Set_mFraction(JPH_ShapeCastResult *_this, float value);

///< This is the fraction where the shape hit the other shape: CenterOfMassOnHit = Start + value * (End - Start)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ShapeCastResult_GetMutable_mFraction(JPH_ShapeCastResult *_this);

///< True if the shape was hit from the back side
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mIsBackFaceHit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_ShapeCastResult_Get_mIsBackFaceHit(const JPH_ShapeCastResult *_this);

///< True if the shape was hit from the back side
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mIsBackFaceHit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsBackFaceHit`.
JOLT_API void JPH_ShapeCastResult_Set_mIsBackFaceHit(JPH_ShapeCastResult *_this, bool value);

///< True if the shape was hit from the back side
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mIsBackFaceHit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_ShapeCastResult_GetMutable_mIsBackFaceHit(JPH_ShapeCastResult *_this);

///< Contact point on the surface of shape 1 (in world space or relative to base offset)
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mContactPointOn1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastResult_Get_mContactPointOn1(const JPH_ShapeCastResult *_this);

///< Contact point on the surface of shape 1 (in world space or relative to base offset)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mContactPointOn1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mContactPointOn1(JPH_ShapeCastResult *_this);

///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mContactPointOn2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastResult_Get_mContactPointOn2(const JPH_ShapeCastResult *_this);

///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mContactPointOn2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mContactPointOn2(JPH_ShapeCastResult *_this);

///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mPenetrationAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ShapeCastResult_Get_mPenetrationAxis(const JPH_ShapeCastResult *_this);

///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mPenetrationAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mPenetrationAxis(JPH_ShapeCastResult *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ShapeCastResult_Get_mPenetrationDepth(const JPH_ShapeCastResult *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationDepth`.
JOLT_API void JPH_ShapeCastResult_Set_mPenetrationDepth(JPH_ShapeCastResult *_this, float value);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ShapeCastResult_GetMutable_mPenetrationDepth(JPH_ShapeCastResult *_this);

///< Sub shape ID that identifies the face on shape 1
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_ShapeCastResult_Get_mSubShapeID1(const JPH_ShapeCastResult *_this);

///< Sub shape ID that identifies the face on shape 1
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID1`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID1`.
JOLT_API void JPH_ShapeCastResult_Set_mSubShapeID1(JPH_ShapeCastResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID that identifies the face on shape 1
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_ShapeCastResult_GetMutable_mSubShapeID1(JPH_ShapeCastResult *_this);

///< Sub shape ID that identifies the face on shape 2
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_ShapeCastResult_Get_mSubShapeID2(const JPH_ShapeCastResult *_this);

///< Sub shape ID that identifies the face on shape 2
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID2`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID2`.
JOLT_API void JPH_ShapeCastResult_Set_mSubShapeID2(JPH_ShapeCastResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID that identifies the face on shape 2
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_ShapeCastResult_GetMutable_mSubShapeID2(JPH_ShapeCastResult *_this);

///< BodyID to which shape 2 belongs to
/// Returns a pointer to a member variable of class `JPH::ShapeCastResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_ShapeCastResult_Get_mBodyID2(const JPH_ShapeCastResult *_this);

///< BodyID to which shape 2 belongs to
/// Modifies a member variable of class `JPH::ShapeCastResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID2`.
/// When this function is called, this object will drop object references it held previously in `mBodyID2`.
JOLT_API void JPH_ShapeCastResult_Set_mBodyID2(JPH_ShapeCastResult *_this, JPH_BodyID value);

///< BodyID to which shape 2 belongs to
/// Returns a mutable pointer to a member variable of class `JPH::ShapeCastResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_ShapeCastResult_GetMutable_mBodyID2(JPH_ShapeCastResult *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ShapeCastResult_DestroyArray()`.
/// Use `JPH_ShapeCastResult_OffsetMutablePtr()` and `JPH_ShapeCastResult_OffsetPtr()` to access the array elements.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeCastResult *JPH_ShapeCastResult_OffsetPtr(const JPH_ShapeCastResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_OffsetMutablePtr(JPH_ShapeCastResult *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeCastResult` to its base class `JPH::CollideShapeResult`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CollideShapeResult *JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(const JPH_ShapeCastResult *object);

/// Upcasts an instance of `JPH::ShapeCastResult` to its base class `JPH::CollideShapeResult`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CollideShapeResult *JPH_ShapeCastResult_MutableUpcastTo_JPH_CollideShapeResult(JPH_ShapeCastResult *object);

/// Downcasts an instance of `JPH::CollideShapeResult` to a derived class `JPH::ShapeCastResult`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeCastResult *JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(const JPH_CollideShapeResult *object);

/// Downcasts an instance of `JPH::CollideShapeResult` to a derived class `JPH::ShapeCastResult`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_MutableStaticDowncastFrom_JPH_CollideShapeResult(JPH_CollideShapeResult *object);

/// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ShapeCastResult *_other);

/// Constructor
/// @param inFraction Fraction at which the cast hit
/// @param inContactPoint1 Contact point on shape 1
/// @param inContactPoint2 Contact point on shape 2
/// @param inContactNormalOrPenetrationDepth Contact normal pointing from shape 1 to 2 or penetration depth vector when the objects are penetrating (also from 1 to 2)
/// @param inBackFaceHit If this hit was a back face hit
/// @param inSubShapeID1 Sub shape id for shape 1
/// @param inSubShapeID2 Sub shape id for shape 2
/// @param inBodyID2 BodyID that was hit
/// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
/// Parameter `inContactPoint1` can not be null. It is a single object.
/// Parameter `inContactPoint2` can not be null. It is a single object.
/// Parameter `inContactNormalOrPenetrationDepth` can not be null. It is a single object.
/// Parameter `inSubShapeID1` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_Construct(float inFraction, const JPH_Vec3 *inContactPoint1, const JPH_Vec3 *inContactPoint2, const JPH_Vec3 *inContactNormalOrPenetrationDepth, bool inBackFaceHit, const JPH_SubShapeID *inSubShapeID1, const JPH_SubShapeID *inSubShapeID2, const JPH_BodyID *inBodyID2);

/// Destroys a heap-allocated instance of `JPH_ShapeCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastResult_Destroy(const JPH_ShapeCastResult *_this);

/// Destroys a heap-allocated array of `JPH_ShapeCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeCastResult_DestroyArray(const JPH_ShapeCastResult *_this);

/// Generated from method `JPH::ShapeCastResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_AssignFromAnother(JPH_ShapeCastResult *_this, Jolt_PassBy _other_pass_by, JPH_ShapeCastResult *_other);

/// Generated from method `JPH::ShapeCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastResult_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastResult_size_t(size_t inCount);

/// Generated from method `JPH::ShapeCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ShapeCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeCastResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ShapeCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction. The fraction and penetration depth are combined in such a way that deeper hits at fraction 0 go first.
/// Generated from method `JPH::ShapeCastResult::GetEarlyOutFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ShapeCastResult_GetEarlyOutFraction(const JPH_ShapeCastResult *_this);

/// Reverses the hit result, swapping contact point 1 with contact point 2 etc.
/// @param inWorldSpaceCastDirection Direction of the shape cast in world space
/// Generated from method `JPH::ShapeCastResult::Reversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inWorldSpaceCastDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeCastResult *JPH_ShapeCastResult_Reversed(const JPH_ShapeCastResult *_this, const JPH_Vec3 *inWorldSpaceCastDirection);

#ifdef __cplusplus
} // extern "C"
#endif
