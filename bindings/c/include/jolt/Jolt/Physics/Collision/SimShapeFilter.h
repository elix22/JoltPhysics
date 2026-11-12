// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// Filter class used during the simulation (PhysicsSystem::Update) to filter out collisions at shape level
/// Generated from class `JPH::SimShapeFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SimShapeFilter JPH_SimShapeFilter;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SimShapeFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_SimShapeFilter *JPH_SimShapeFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SimShapeFilter_DestroyArray()`.
/// Use `JPH_SimShapeFilter_OffsetMutablePtr()` and `JPH_SimShapeFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_SimShapeFilter *JPH_SimShapeFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SimShapeFilter *JPH_SimShapeFilter_OffsetPtr(const JPH_SimShapeFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SimShapeFilter *JPH_SimShapeFilter_OffsetMutablePtr(JPH_SimShapeFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SimShapeFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_SimShapeFilter *object);

/// Upcasts an instance of `JPH::SimShapeFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SimShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SimShapeFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SimShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SimShapeFilter *JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SimShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SimShapeFilter *JPH_SimShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_SimShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SimShapeFilter_Destroy(const JPH_SimShapeFilter *_this);

/// Destroys a heap-allocated array of `JPH_SimShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SimShapeFilter_DestroyArray(const JPH_SimShapeFilter *_this);

/// Filter function to determine if two shapes should collide. Returns true if the filter passes.
/// This overload is called during the simulation (PhysicsSystem::Update) and must be registered with PhysicsSystem::SetSimShapeFilter.
/// It is called at each level of the shape hierarchy, so if you have a compound shape with a box, this function will be called twice.
/// It will not be called on triangles that are part of another shape, i.e a mesh shape will not trigger a callback per triangle.
/// Note that this function is called from multiple threads and must be thread safe. All properties are read only.
/// @param inBody1 1st body that is colliding
/// @param inShape1 1st shape that is colliding
/// @param inSubShapeIDOfShape1 The sub shape ID that will lead from inBody1.GetShape() to inShape1
/// @param inBody2 2nd body that is colliding
/// @param inShape2 2nd shape that is colliding
/// @param inSubShapeIDOfShape2 The sub shape ID that will lead from inBody2.GetShape() to inShape2
/// Generated from method `JPH::SimShapeFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape2` can not be null. It is a single object.
JOLT_API bool JPH_SimShapeFilter_ShouldCollide(const JPH_SimShapeFilter *_this, const JPH_Body *inBody1, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Body *inBody2, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2);

#ifdef __cplusplus
} // extern "C"
#endif
