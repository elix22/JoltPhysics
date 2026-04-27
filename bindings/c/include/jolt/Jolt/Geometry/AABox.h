// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Axis aligned box
/// Generated from class `JPH::AABox`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_AABox JPH_AABox;

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
JOLT_API void *Jolt_new_JPH_AABox_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr(void *inPointer);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::AABox::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABox_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr(void *inPointer);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::AABox::operator new`.
JOLT_API void *Jolt_new_JPH_AABox_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::AABox::operator delete`.
JOLT_API void Jolt_delete_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::AABox::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABox_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::AABox::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);

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

/// Check if this box overlaps with another box
/// Generated from method `JPH::AABox::Overlaps`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_AABox_Overlaps_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther);

#ifdef __cplusplus
} // extern "C"
#endif
