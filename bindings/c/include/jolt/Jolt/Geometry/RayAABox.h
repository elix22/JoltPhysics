// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_UVec4 JPH_UVec4; // Defined in `#include <jolt/Jolt/Math/UVec4.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Helper structure holding the reciprocal of a ray for Ray vs AABox testing
/// Generated from class `JPH::RayInvDirection`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayInvDirection JPH_RayInvDirection;

///< 1 / ray direction
/// Returns a pointer to a member variable of class `JPH::RayInvDirection` named `mInvDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayInvDirection_Get_mInvDirection(const JPH_RayInvDirection *_this);

///< 1 / ray direction
/// Returns a mutable pointer to a member variable of class `JPH::RayInvDirection` named `mInvDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayInvDirection_GetMutable_mInvDirection(JPH_RayInvDirection *_this);

///< for each component if it is parallel to the coordinate axis
/// Returns a pointer to a member variable of class `JPH::RayInvDirection` named `mIsParallel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_UVec4 *JPH_RayInvDirection_Get_mIsParallel(const JPH_RayInvDirection *_this);

///< for each component if it is parallel to the coordinate axis
/// Returns a mutable pointer to a member variable of class `JPH::RayInvDirection` named `mIsParallel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_UVec4 *JPH_RayInvDirection_GetMutable_mIsParallel(JPH_RayInvDirection *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayInvDirection_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayInvDirection_DestroyArray()`.
/// Use `JPH_RayInvDirection_OffsetMutablePtr()` and `JPH_RayInvDirection_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayInvDirection *JPH_RayInvDirection_OffsetPtr(const JPH_RayInvDirection *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_OffsetMutablePtr(JPH_RayInvDirection *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayInvDirection_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_ConstructFromAnother(const JPH_RayInvDirection *_other);

/// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayInvDirection_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_Construct(const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_RayInvDirection`. Does nothing if the pointer is null.
JOLT_API void JPH_RayInvDirection_Destroy(const JPH_RayInvDirection *_this);

/// Destroys a heap-allocated array of `JPH_RayInvDirection`. Does nothing if the pointer is null.
JOLT_API void JPH_RayInvDirection_DestroyArray(const JPH_RayInvDirection *_this);

/// Generated from method `JPH::RayInvDirection::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayInvDirection *JPH_RayInvDirection_AssignFromAnother(JPH_RayInvDirection *_this, const JPH_RayInvDirection *_other);

/// Set reciprocal from ray direction
/// Generated from method `JPH::RayInvDirection::Set`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
JOLT_API void JPH_RayInvDirection_Set(JPH_RayInvDirection *_this, const JPH_Vec3 *inDirection);

#ifdef __cplusplus
} // extern "C"
#endif
