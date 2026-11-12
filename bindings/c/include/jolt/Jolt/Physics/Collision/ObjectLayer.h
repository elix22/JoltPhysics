// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// Filter class for object layers
/// Generated from class `JPH::ObjectLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DefaultObjectLayerFilter`
///     `JPH::SpecifiedObjectLayerFilter`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ObjectLayerFilter JPH_ObjectLayerFilter;

/// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
/// Generated from class `JPH::ObjectLayerPairFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ObjectLayerPairFilterMask`
///     `JPH::ObjectLayerPairFilterTable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ObjectLayerPairFilter JPH_ObjectLayerPairFilter;

/// Default filter class that uses the pair filter in combination with a specified layer to filter layers
/// Generated from class `JPH::DefaultObjectLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DefaultObjectLayerFilter JPH_DefaultObjectLayerFilter;

/// Allows objects from a specific layer only
/// Generated from class `JPH::SpecifiedObjectLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_SpecifiedObjectLayerFilter JPH_SpecifiedObjectLayerFilter;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ObjectLayerFilter_DestroyArray()`.
/// Use `JPH_ObjectLayerFilter_OffsetMutablePtr()` and `JPH_ObjectLayerFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_OffsetPtr(const JPH_ObjectLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_OffsetMutablePtr(JPH_ObjectLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerFilter *object);

/// Upcasts an instance of `JPH::ObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_ObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerFilter_Destroy(const JPH_ObjectLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_ObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerFilter_DestroyArray(const JPH_ObjectLayerFilter *_this);

/// Function to filter out object layers when doing collision query test (return true to allow testing against objects with this layer)
/// Generated from method `JPH::ObjectLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ObjectLayerFilter_ShouldCollide(const JPH_ObjectLayerFilter *_this, unsigned short inLayer);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectLayerPairFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ObjectLayerPairFilter_DestroyArray()`.
/// Use `JPH_ObjectLayerPairFilter_OffsetMutablePtr()` and `JPH_ObjectLayerPairFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_OffsetPtr(const JPH_ObjectLayerPairFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_OffsetMutablePtr(JPH_ObjectLayerPairFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectLayerPairFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilter *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectLayerPairFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_ObjectLayerPairFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilter_Destroy(const JPH_ObjectLayerPairFilter *_this);

/// Destroys a heap-allocated array of `JPH_ObjectLayerPairFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilter_DestroyArray(const JPH_ObjectLayerPairFilter *_this);

/// Returns true if two layers can collide
/// Generated from method `JPH::ObjectLayerPairFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ObjectLayerPairFilter_ShouldCollide(const JPH_ObjectLayerPairFilter *_this, unsigned short inLayer1, unsigned short inLayer2);

/// Copy constructor
/// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DefaultObjectLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_ConstructFromAnother(Jolt_PassBy inRHS_pass_by, JPH_DefaultObjectLayerFilter *inRHS);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_OffsetPtr(const JPH_DefaultObjectLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_OffsetMutablePtr(JPH_DefaultObjectLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DefaultObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_DefaultObjectLayerFilter *object);

/// Upcasts an instance of `JPH::DefaultObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DefaultObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_DefaultObjectLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DefaultObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DefaultObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::DefaultObjectLayerFilter` to its base class `JPH::ObjectLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerFilter *JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(const JPH_DefaultObjectLayerFilter *object);

/// Upcasts an instance of `JPH::DefaultObjectLayerFilter` to its base class `JPH::ObjectLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableUpcastTo_JPH_ObjectLayerFilter(JPH_DefaultObjectLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerFilter` to a derived class `JPH::DefaultObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(const JPH_ObjectLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerFilter` to a derived class `JPH::DefaultObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableStaticDowncastFrom_JPH_ObjectLayerFilter(JPH_ObjectLayerFilter *object);

/// Constructor
/// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
/// Parameter `inObjectLayerPairFilter` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DefaultObjectLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_Construct(const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter, unsigned short inLayer);

/// Destroys a heap-allocated instance of `JPH_DefaultObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_DefaultObjectLayerFilter_Destroy(const JPH_DefaultObjectLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_DefaultObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_DefaultObjectLayerFilter_DestroyArray(const JPH_DefaultObjectLayerFilter *_this);

// See ObjectLayerFilter::ShouldCollide
/// Generated from method `JPH::DefaultObjectLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_DefaultObjectLayerFilter_ShouldCollide(const JPH_DefaultObjectLayerFilter *_this, unsigned short inLayer);

/// Constructor
/// Generated from constructor `JPH::SpecifiedObjectLayerFilter::SpecifiedObjectLayerFilter`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SpecifiedObjectLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_Construct(unsigned short inLayer);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_OffsetPtr(const JPH_SpecifiedObjectLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_OffsetMutablePtr(JPH_SpecifiedObjectLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SpecifiedObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_SpecifiedObjectLayerFilter *object);

/// Upcasts an instance of `JPH::SpecifiedObjectLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SpecifiedObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SpecifiedObjectLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SpecifiedObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SpecifiedObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SpecifiedObjectLayerFilter` to its base class `JPH::ObjectLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(const JPH_SpecifiedObjectLayerFilter *object);

/// Upcasts an instance of `JPH::SpecifiedObjectLayerFilter` to its base class `JPH::ObjectLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableUpcastTo_JPH_ObjectLayerFilter(JPH_SpecifiedObjectLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerFilter` to a derived class `JPH::SpecifiedObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(const JPH_ObjectLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerFilter` to a derived class `JPH::SpecifiedObjectLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableStaticDowncastFrom_JPH_ObjectLayerFilter(JPH_ObjectLayerFilter *object);

/// Destroys a heap-allocated instance of `JPH_SpecifiedObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SpecifiedObjectLayerFilter_Destroy(const JPH_SpecifiedObjectLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_SpecifiedObjectLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SpecifiedObjectLayerFilter_DestroyArray(const JPH_SpecifiedObjectLayerFilter *_this);

// See ObjectLayerFilter::ShouldCollide
/// Generated from method `JPH::SpecifiedObjectLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SpecifiedObjectLayerFilter_ShouldCollide(const JPH_SpecifiedObjectLayerFilter *_this, unsigned short inLayer);

#ifdef __cplusplus
} // extern "C"
#endif
