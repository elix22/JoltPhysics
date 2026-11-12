// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Float2 JPH_Float2; // Defined in `#include <jolt/Jolt/Math/Float2.h>`.


/// Ellipse centered around the origin
/// @see https://en.wikipedia.org/wiki/Ellipse
/// Generated from class `JPH::Ellipse`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Ellipse JPH_Ellipse;

/// Generated from constructor `JPH::Ellipse::Ellipse`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Ellipse_Destroy()` to free it when you're done using it.
JOLT_API JPH_Ellipse *JPH_Ellipse_ConstructFromAnother(const JPH_Ellipse *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Ellipse *JPH_Ellipse_OffsetPtr(const JPH_Ellipse *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Ellipse *JPH_Ellipse_OffsetMutablePtr(JPH_Ellipse *ptr, ptrdiff_t i);

/// Construct ellipse with radius A along the X-axis and B along the Y-axis
/// Generated from constructor `JPH::Ellipse::Ellipse`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Ellipse_Destroy()` to free it when you're done using it.
JOLT_API JPH_Ellipse *JPH_Ellipse_Construct(float inA, float inB);

/// Destroys a heap-allocated instance of `JPH_Ellipse`. Does nothing if the pointer is null.
JOLT_API void JPH_Ellipse_Destroy(const JPH_Ellipse *_this);

/// Destroys a heap-allocated array of `JPH_Ellipse`. Does nothing if the pointer is null.
JOLT_API void JPH_Ellipse_DestroyArray(const JPH_Ellipse *_this);

/// Generated from method `JPH::Ellipse::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Ellipse *JPH_Ellipse_AssignFromAnother(JPH_Ellipse *_this, const JPH_Ellipse *_other);

/// Generated from method `JPH::Ellipse::operator new`.
JOLT_API void *Jolt_new_JPH_Ellipse_size_t(size_t inCount);

/// Generated from method `JPH::Ellipse::operator delete`.
JOLT_API void Jolt_delete_JPH_Ellipse_void_ptr(void *inPointer);

/// Generated from method `JPH::Ellipse::operator delete`.
JOLT_API void Jolt_delete_JPH_Ellipse_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Ellipse::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Ellipse_size_t(size_t inCount);

/// Generated from method `JPH::Ellipse::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ellipse_void_ptr(void *inPointer);

/// Generated from method `JPH::Ellipse::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ellipse_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Ellipse::operator new`.
JOLT_API void *Jolt_new_JPH_Ellipse_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Ellipse::operator delete`.
JOLT_API void Jolt_delete_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Ellipse::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Ellipse_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Ellipse::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if inPoint is inside the ellipse
/// Generated from method `JPH::Ellipse::IsInside`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
JOLT_API bool JPH_Ellipse_IsInside(const JPH_Ellipse *_this, const JPH_Float2 *inPoint);

/// Get the closest point on the ellipse to inPoint
/// Assumes inPoint is outside the ellipse
/// @see Rotation Joint Limits in Quaternion Space by Gino van den Bergen, section 10.1 in Game Engine Gems 3.
/// Generated from method `JPH::Ellipse::GetClosestPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float2 *JPH_Ellipse_GetClosestPoint(const JPH_Ellipse *_this, const JPH_Float2 *inPoint);

/// Get normal at point inPoint (non-normalized vector)
/// Generated from method `JPH::Ellipse::GetNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Float2_Destroy()` to free it when you're done using it.
JOLT_API JPH_Float2 *JPH_Ellipse_GetNormal(const JPH_Ellipse *_this, const JPH_Float2 *inPoint);

#ifdef __cplusplus
} // extern "C"
#endif
