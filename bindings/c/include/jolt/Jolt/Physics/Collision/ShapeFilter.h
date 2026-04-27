// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// Filter class
/// Generated from class `JPH::ShapeFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ReversedShapeFilter`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ShapeFilter JPH_ShapeFilter;

/// Helper class to reverse the order of the shapes in the ShouldCollide function
/// Generated from class `JPH::ReversedShapeFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_ReversedShapeFilter JPH_ReversedShapeFilter;

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Returns a pointer to a member variable of class `JPH::ShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_ShapeFilter_Get_mBodyID2(const JPH_ShapeFilter *_this);

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Modifies a member variable of class `JPH::ShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID2`.
/// When this function is called, this object will drop object references it held previously in `mBodyID2`.
JOLT_API void JPH_ShapeFilter_Set_mBodyID2(JPH_ShapeFilter *_this, JPH_BodyID value);

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Returns a mutable pointer to a member variable of class `JPH::ShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_ShapeFilter_GetMutable_mBodyID2(JPH_ShapeFilter *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ShapeFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_ShapeFilter *JPH_ShapeFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ShapeFilter_DestroyArray()`.
/// Use `JPH_ShapeFilter_OffsetMutablePtr()` and `JPH_ShapeFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_ShapeFilter *JPH_ShapeFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeFilter *JPH_ShapeFilter_OffsetPtr(const JPH_ShapeFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeFilter *JPH_ShapeFilter_OffsetMutablePtr(JPH_ShapeFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_ShapeFilter *object);

/// Upcasts an instance of `JPH::ShapeFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ShapeFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeFilter *JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeFilter *JPH_ShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_ShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeFilter_Destroy(const JPH_ShapeFilter *_this);

/// Destroys a heap-allocated array of `JPH_ShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeFilter_DestroyArray(const JPH_ShapeFilter *_this);

/// Filter function to determine if we should collide with a shape. Returns true if the filter passes.
/// This overload is called when the query doesn't have a source shape (e.g. ray cast / collide point)
/// @param inShape2 Shape we're colliding against
/// @param inSubShapeIDOfShape2 The sub shape ID that will lead from the root shape to inShape2 (i.e. the shape of mBodyID2)
/// Generated from method `JPH::ShapeFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape2` can not be null. It is a single object.
JOLT_API bool JPH_ShapeFilter_ShouldCollide_2(const JPH_ShapeFilter *_this, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2);

/// Filter function to determine if two shapes should collide. Returns true if the filter passes.
/// This overload is called when querying a shape vs a shape (e.g. collide object / cast object).
/// It is called at each level of the shape hierarchy, so if you have a compound shape with a box, this function will be called twice.
/// It will not be called on triangles that are part of another shape, i.e a mesh shape will not trigger a callback per triangle. You can filter out individual triangles in the CollisionCollector::AddHit function by their sub shape ID.
/// @param inShape1 1st shape that is colliding
/// @param inSubShapeIDOfShape1 The sub shape ID that will lead from the root shape to inShape1 (i.e. the shape that is used to collide or cast against shape 2)
/// @param inShape2 2nd shape that is colliding
/// @param inSubShapeIDOfShape2 The sub shape ID that will lead from the root shape to inShape2 (i.e. the shape of mBodyID2)
/// Generated from method `JPH::ShapeFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape1` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape2` can not be null. It is a single object.
JOLT_API bool JPH_ShapeFilter_ShouldCollide_4(const JPH_ShapeFilter *_this, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2);

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Returns a pointer to a member variable of class `JPH::ReversedShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_ReversedShapeFilter_Get_mBodyID2(const JPH_ReversedShapeFilter *_this);

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Modifies a member variable of class `JPH::ReversedShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID2`.
/// When this function is called, this object will drop object references it held previously in `mBodyID2`.
JOLT_API void JPH_ReversedShapeFilter_Set_mBodyID2(JPH_ReversedShapeFilter *_this, JPH_BodyID value);

/// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
/// Provides context to the filter to indicate which body is colliding.
/// Returns a mutable pointer to a member variable of class `JPH::ReversedShapeFilter` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_ReversedShapeFilter_GetMutable_mBodyID2(JPH_ReversedShapeFilter *_this);

/// Constructor
/// Generated from constructor `JPH::ReversedShapeFilter::ReversedShapeFilter`.
/// Parameter `inFilter` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ReversedShapeFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_Construct(const JPH_ShapeFilter *inFilter);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_OffsetPtr(const JPH_ReversedShapeFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_OffsetMutablePtr(JPH_ReversedShapeFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ReversedShapeFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_ReversedShapeFilter *object);

/// Upcasts an instance of `JPH::ReversedShapeFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ReversedShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ReversedShapeFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ReversedShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ReversedShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ReversedShapeFilter` to its base class `JPH::ShapeFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeFilter *JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(const JPH_ReversedShapeFilter *object);

/// Upcasts an instance of `JPH::ReversedShapeFilter` to its base class `JPH::ShapeFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeFilter *JPH_ReversedShapeFilter_MutableUpcastTo_JPH_ShapeFilter(JPH_ReversedShapeFilter *object);

/// Downcasts an instance of `JPH::ShapeFilter` to a derived class `JPH::ReversedShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(const JPH_ShapeFilter *object);

/// Downcasts an instance of `JPH::ShapeFilter` to a derived class `JPH::ReversedShapeFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_MutableStaticDowncastFrom_JPH_ShapeFilter(JPH_ShapeFilter *object);

/// Destroys a heap-allocated instance of `JPH_ReversedShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ReversedShapeFilter_Destroy(const JPH_ReversedShapeFilter *_this);

/// Destroys a heap-allocated array of `JPH_ReversedShapeFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ReversedShapeFilter_DestroyArray(const JPH_ReversedShapeFilter *_this);

/// Generated from method `JPH::ReversedShapeFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape2` can not be null. It is a single object.
JOLT_API bool JPH_ReversedShapeFilter_ShouldCollide_2(const JPH_ReversedShapeFilter *_this, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2);

/// Generated from method `JPH::ReversedShapeFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape1` can not be null. It is a single object.
/// Parameter `inSubShapeIDOfShape2` can not be null. It is a single object.
JOLT_API bool JPH_ReversedShapeFilter_ShouldCollide_4(const JPH_ReversedShapeFilter *_this, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2);

#ifdef __cplusplus
} // extern "C"
#endif
