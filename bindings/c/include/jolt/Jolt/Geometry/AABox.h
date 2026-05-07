// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DMat44 JPH_DMat44; // Defined in `#include <jolt/Jolt/Math/DMat44.h>`.
typedef struct JPH_DVec3 JPH_DVec3; // Defined in `#include <jolt/Jolt/Math/DVec3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_Float3 Jolt_JPH_Array_JPH_Float3; // Defined in `#include <JPH_Array_JPH_Float3.h>`.


/// Axis aligned box
/// Generated from class `JPH::AABox`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_AABox JPH_AABox;

/// Bounding box min and max
/// Returns a pointer to a member variable of class `JPH::AABox` named `mMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_AABox_Get_mMin(const JPH_AABox *_this);

/// Bounding box min and max
/// Returns a mutable pointer to a member variable of class `JPH::AABox` named `mMin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_AABox_GetMutable_mMin(JPH_AABox *_this);

/// Returns a pointer to a member variable of class `JPH::AABox` named `mMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_AABox_Get_mMax(const JPH_AABox *_this);

/// Returns a mutable pointer to a member variable of class `JPH::AABox` named `mMax`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_AABox_GetMutable_mMax(JPH_AABox *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_AABox_DestroyArray()`.
/// Use `JPH_AABox_OffsetMutablePtr()` and `JPH_AABox_OffsetPtr()` to access the array elements.
JOLT_API JPH_AABox *JPH_AABox_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_AABox *JPH_AABox_OffsetPtr(const JPH_AABox *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_AABox *JPH_AABox_OffsetMutablePtr(JPH_AABox *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::AABox::AABox`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_ConstructFromAnother(const JPH_AABox *_other);

/// Generated from constructor `JPH::AABox::AABox`.
/// Parameter `inMin` can not be null. It is a single object.
/// Parameter `inMax` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(const JPH_Vec3 *inMin, const JPH_Vec3 *inMax);

/// Generated from constructor `JPH::AABox::AABox`.
/// Parameter `inMin` can not be null. It is a single object.
/// Parameter `inMax` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Construct_const_JPH_DVec3_ref(const JPH_DVec3 *inMin, const JPH_DVec3 *inMax);

/// Generated from constructor `JPH::AABox::AABox`.
/// Parameter `inCenter` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Construct_const_JPH_Vec3_float(const JPH_Vec3 *inCenter, float inRadius);

/// Destroys a heap-allocated instance of `JPH_AABox`. Does nothing if the pointer is null.
JOLT_API void JPH_AABox_Destroy(const JPH_AABox *_this);

/// Destroys a heap-allocated array of `JPH_AABox`. Does nothing if the pointer is null.
JOLT_API void JPH_AABox_DestroyArray(const JPH_AABox *_this);

/// Generated from method `JPH::AABox::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_AABox *JPH_AABox_AssignFromAnother(JPH_AABox *_this, const JPH_AABox *_other);

/// Generated from method `JPH::AABox::operator new`.
JOLT_API void *Jolt_new_JPH_AABox_size_t(size_t inCount);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr(void *inPointer);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::AABox::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABox_size_t(size_t inCount);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr(void *inPointer);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::AABox::operator new`.
JOLT_API void *Jolt_new_JPH_AABox_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::AABox::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABox_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create box from 2 points
/// Generated from method `JPH::AABox::sFromTwoPoints`.
/// Parameter `inP1` can not be null. It is a single object.
/// Parameter `inP2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_sFromTwoPoints(const JPH_Vec3 *inP1, const JPH_Vec3 *inP2);

/// Get bounding box of size FLT_MAX
/// Generated from method `JPH::AABox::sBiggest`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_sBiggest(void);

/// Comparison operators
/// Generated from method `JPH::AABox::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inRHS);

/// Generated from method `JPH::AABox::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inRHS);

/// Reset the bounding box to an empty bounding box
/// Generated from method `JPH::AABox::SetEmpty`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_AABox_SetEmpty(JPH_AABox *_this);

/// Check if the bounding box is valid (max >= min)
/// Generated from method `JPH::AABox::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_AABox_IsValid(const JPH_AABox *_this);

/// Encapsulate point in bounding box
/// Generated from method `JPH::AABox::Encapsulate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPos` can not be null. It is a single object.
JOLT_API void JPH_AABox_Encapsulate_1_JPH_Vec3(JPH_AABox *_this, const JPH_Vec3 *inPos);

/// Encapsulate bounding box in bounding box
/// Generated from method `JPH::AABox::Encapsulate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API void JPH_AABox_Encapsulate_1_JPH_AABox(JPH_AABox *_this, const JPH_AABox *inRHS);

/// Intersect this bounding box with inOther, returns the intersection
/// Generated from method `JPH::AABox::Intersect`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Intersect(const JPH_AABox *_this, const JPH_AABox *inOther);

/// Make sure that each edge of the bounding box has a minimal length
/// Generated from method `JPH::AABox::EnsureMinimalEdgeLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_AABox_EnsureMinimalEdgeLength(JPH_AABox *_this, float inMinEdgeLength);

/// Widen the box on both sides by inVector
/// Generated from method `JPH::AABox::ExpandBy`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVector` can not be null. It is a single object.
JOLT_API void JPH_AABox_ExpandBy(JPH_AABox *_this, const JPH_Vec3 *inVector);

/// Get center of bounding box
/// Generated from method `JPH::AABox::GetCenter`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_AABox_GetCenter(const JPH_AABox *_this);

/// Get extent of bounding box (half of the size)
/// Generated from method `JPH::AABox::GetExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_AABox_GetExtent(const JPH_AABox *_this);

/// Get size of bounding box
/// Generated from method `JPH::AABox::GetSize`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_AABox_GetSize(const JPH_AABox *_this);

/// Get surface area of bounding box
/// Generated from method `JPH::AABox::GetSurfaceArea`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_AABox_GetSurfaceArea(const JPH_AABox *_this);

/// Get volume of bounding box
/// Generated from method `JPH::AABox::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_AABox_GetVolume(const JPH_AABox *_this);

/// Check if this box contains another box
/// Generated from method `JPH::AABox::Contains`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Contains_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther);

/// Check if this box contains a point
/// Generated from method `JPH::AABox::Contains`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Contains_JPH_Vec3(const JPH_AABox *_this, const JPH_Vec3 *inOther);

/// Check if this box contains a point
/// Generated from method `JPH::AABox::Contains`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Contains_JPH_DVec3(const JPH_AABox *_this, const JPH_DVec3 *inOther);

/// Check if this box overlaps with another box
/// Generated from method `JPH::AABox::Overlaps`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Overlaps_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther);

/// Check if this box overlaps with a plane
/// Generated from method `JPH::AABox::Overlaps`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPlane` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Overlaps_JPH_Plane(const JPH_AABox *_this, const JPH_Plane *inPlane);

/// Translate bounding box
/// Generated from method `JPH::AABox::Translate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
JOLT_API void JPH_AABox_Translate_JPH_Vec3(JPH_AABox *_this, const JPH_Vec3 *inTranslation);

/// Translate bounding box
/// Generated from method `JPH::AABox::Translate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
JOLT_API void JPH_AABox_Translate_JPH_DVec3(JPH_AABox *_this, const JPH_DVec3 *inTranslation);

/// Transform bounding box
/// Generated from method `JPH::AABox::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Transformed_JPH_Mat44(const JPH_AABox *_this, const JPH_Mat44 *inMatrix);

/// Transform bounding box
/// Generated from method `JPH::AABox::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Transformed_JPH_DMat44(const JPH_AABox *_this, const JPH_DMat44 *inMatrix);

/// Scale this bounding box, can handle non-uniform and negative scaling
/// Generated from method `JPH::AABox::Scaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_AABox_Scaled(const JPH_AABox *_this, const JPH_Vec3 *inScale);

/// Calculate the support vector for this convex shape.
/// Generated from method `JPH::AABox::GetSupport`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_AABox_GetSupport(const JPH_AABox *_this, const JPH_Vec3 *inDirection);

/// Get the closest point on or in this box to inPoint
/// Generated from method `JPH::AABox::GetClosestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_AABox_GetClosestPoint(const JPH_AABox *_this, const JPH_Vec3 *inPoint);

/// Get the squared distance between inPoint and this box (will be 0 if in Point is inside the box)
/// Generated from method `JPH::AABox::GetSqDistanceTo`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
JOLT_API float JPH_AABox_GetSqDistanceTo(const JPH_AABox *_this, const JPH_Vec3 *inPoint);

#ifdef __cplusplus
} // extern "C"
#endif
