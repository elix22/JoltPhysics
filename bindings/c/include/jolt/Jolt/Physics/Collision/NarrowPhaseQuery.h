// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that provides an interface for doing precise collision detection against the broad and then the narrow phase.
/// Unlike a BroadPhaseQuery, the NarrowPhaseQuery will test against shapes and will return collision information against triangles, spheres etc.
/// Generated from class `JPH::NarrowPhaseQuery`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_NarrowPhaseQuery JPH_NarrowPhaseQuery;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_NarrowPhaseQuery_Destroy()` to free it when you're done using it.
JOLT_API JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_NarrowPhaseQuery_DestroyArray()`.
/// Use `JPH_NarrowPhaseQuery_OffsetMutablePtr()` and `JPH_NarrowPhaseQuery_OffsetPtr()` to access the array elements.
JOLT_API JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_OffsetPtr(const JPH_NarrowPhaseQuery *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_OffsetMutablePtr(JPH_NarrowPhaseQuery *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::NarrowPhaseQuery` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(const JPH_NarrowPhaseQuery *object);

/// Upcasts an instance of `JPH::NarrowPhaseQuery` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_NarrowPhaseQuery_MutableUpcastTo_JPH_NonCopyable(JPH_NarrowPhaseQuery *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::NarrowPhaseQuery`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::NarrowPhaseQuery`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_NarrowPhaseQuery`. Does nothing if the pointer is null.
JOLT_API void JPH_NarrowPhaseQuery_Destroy(const JPH_NarrowPhaseQuery *_this);

/// Destroys a heap-allocated array of `JPH_NarrowPhaseQuery`. Does nothing if the pointer is null.
JOLT_API void JPH_NarrowPhaseQuery_DestroyArray(const JPH_NarrowPhaseQuery *_this);

#ifdef __cplusplus
} // extern "C"
#endif
