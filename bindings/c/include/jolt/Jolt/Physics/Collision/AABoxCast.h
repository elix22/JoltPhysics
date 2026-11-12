// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Structure that holds AABox moving linearly through 3d space
/// Generated from class `JPH::AABoxCast`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_AABoxCast JPH_AABoxCast;

///< Axis aligned box at starting location
/// Returns a pointer to a member variable of class `JPH::AABoxCast` named `mBox`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_AABoxCast_Get_mBox(const JPH_AABoxCast *_this);

///< Axis aligned box at starting location
/// Modifies a member variable of class `JPH::AABoxCast` named `mBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBox`.
/// When this function is called, this object will drop object references it held previously in `mBox`.
JOLT_API void JPH_AABoxCast_Set_mBox(JPH_AABoxCast *_this, const JPH_AABox *value);

///< Axis aligned box at starting location
/// Returns a mutable pointer to a member variable of class `JPH::AABoxCast` named `mBox`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_AABox *JPH_AABoxCast_GetMutable_mBox(JPH_AABoxCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::AABoxCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_AABoxCast_Get_mDirection(const JPH_AABoxCast *_this);

///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
/// Returns a mutable pointer to a member variable of class `JPH::AABoxCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_AABoxCast_GetMutable_mDirection(JPH_AABoxCast *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABoxCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_AABoxCast_DestroyArray()`.
/// Use `JPH_AABoxCast_OffsetMutablePtr()` and `JPH_AABoxCast_OffsetPtr()` to access the array elements.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::AABoxCast` elementwise.
/// Parameter `mBox` can not be null. It is a single object.
/// The reference to the parameter `mBox` might be preserved in the constructed object.
/// Parameter `mDirection` can not be null. It is a single object.
/// The reference to the parameter `mDirection` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABoxCast_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_ConstructFrom(const JPH_AABox *mBox, const JPH_Vec3 *mDirection);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_AABoxCast *JPH_AABoxCast_OffsetPtr(const JPH_AABoxCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_OffsetMutablePtr(JPH_AABoxCast *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::AABoxCast::AABoxCast`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABoxCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_ConstructFromAnother(const JPH_AABoxCast *_other);

/// Destroys a heap-allocated instance of `JPH_AABoxCast`. Does nothing if the pointer is null.
JOLT_API void JPH_AABoxCast_Destroy(const JPH_AABoxCast *_this);

/// Destroys a heap-allocated array of `JPH_AABoxCast`. Does nothing if the pointer is null.
JOLT_API void JPH_AABoxCast_DestroyArray(const JPH_AABoxCast *_this);

/// Generated from method `JPH::AABoxCast::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_AABoxCast *JPH_AABoxCast_AssignFromAnother(JPH_AABoxCast *_this, const JPH_AABoxCast *_other);

/// Generated from method `JPH::AABoxCast::operator new`.
JOLT_API void *Jolt_new_JPH_AABoxCast_size_t(size_t inCount);

/// Generated from method `JPH::AABoxCast::operator delete`.
JOLT_API void Jolt_delete_JPH_AABoxCast_void_ptr(void *inPointer);

/// Generated from method `JPH::AABoxCast::operator delete`.
JOLT_API void Jolt_delete_JPH_AABoxCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::AABoxCast::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABoxCast_size_t(size_t inCount);

/// Generated from method `JPH::AABoxCast::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABoxCast_void_ptr(void *inPointer);

/// Generated from method `JPH::AABoxCast::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::AABoxCast::operator new`.
JOLT_API void *Jolt_new_JPH_AABoxCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::AABoxCast::operator delete`.
JOLT_API void Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::AABoxCast::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_AABoxCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::AABoxCast::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
