// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// Interface to the broadphase that can perform collision queries. These queries will only test the bounding box of the body to quickly determine a potential set of colliding bodies.
/// The shapes of the bodies are not tested, if you want this then you should use the NarrowPhaseQuery interface.
/// Generated from class `JPH::BroadPhaseQuery`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_BroadPhaseQuery JPH_BroadPhaseQuery;

/// Destroys a heap-allocated instance of `JPH_BroadPhaseQuery`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseQuery_Destroy(const JPH_BroadPhaseQuery *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseQuery`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseQuery_DestroyArray(const JPH_BroadPhaseQuery *_this);

/// Get the bounding box of all objects in the broadphase
/// Generated from method `JPH::BroadPhaseQuery::GetBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_BroadPhaseQuery_GetBounds(const JPH_BroadPhaseQuery *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_OffsetPtr(const JPH_BroadPhaseQuery *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_OffsetMutablePtr(JPH_BroadPhaseQuery *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BroadPhaseQuery` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseQuery *object);

/// Upcasts an instance of `JPH::BroadPhaseQuery` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BroadPhaseQuery_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseQuery *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseQuery`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseQuery`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

#ifdef __cplusplus
} // extern "C"
#endif
