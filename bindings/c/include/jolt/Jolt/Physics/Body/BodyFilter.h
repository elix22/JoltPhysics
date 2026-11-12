// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// Class function to filter out bodies, returns true if test should collide with body
/// Generated from class `JPH::BodyFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::IgnoreMultipleBodiesFilter`
///     `JPH::IgnoreSingleBodyFilter`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BodyFilter JPH_BodyFilter;

/// A simple body filter implementation that ignores a single, specified body
/// Generated from class `JPH::IgnoreSingleBodyFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BodyFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_IgnoreSingleBodyFilter JPH_IgnoreSingleBodyFilter;

/// A simple body filter implementation that ignores multiple, specified bodies
/// Generated from class `JPH::IgnoreMultipleBodiesFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BodyFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_IgnoreMultipleBodiesFilter JPH_IgnoreMultipleBodiesFilter;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyFilter *JPH_BodyFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BodyFilter_DestroyArray()`.
/// Use `JPH_BodyFilter_OffsetMutablePtr()` and `JPH_BodyFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_BodyFilter *JPH_BodyFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BodyFilter *JPH_BodyFilter_OffsetPtr(const JPH_BodyFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BodyFilter *JPH_BodyFilter_OffsetMutablePtr(JPH_BodyFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BodyFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BodyFilter_UpcastTo_JPH_NonCopyable(const JPH_BodyFilter *object);

/// Upcasts an instance of `JPH::BodyFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BodyFilter_MutableUpcastTo_JPH_NonCopyable(JPH_BodyFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BodyFilter *JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BodyFilter *JPH_BodyFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_BodyFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyFilter_Destroy(const JPH_BodyFilter *_this);

/// Destroys a heap-allocated array of `JPH_BodyFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyFilter_DestroyArray(const JPH_BodyFilter *_this);

/// Filter function. Returns true if we should collide with inBodyID
/// Generated from method `JPH::BodyFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyFilter_ShouldCollide(const JPH_BodyFilter *_this, const JPH_BodyID *inBodyID);

/// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
/// Generated from method `JPH::BodyFilter::ShouldCollideLocked`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API bool JPH_BodyFilter_ShouldCollideLocked(const JPH_BodyFilter *_this, const JPH_Body *inBody);

/// Constructor, pass the body you want to ignore
/// Generated from constructor `JPH::IgnoreSingleBodyFilter::IgnoreSingleBodyFilter`.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_IgnoreSingleBodyFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_Construct(const JPH_BodyID *inBodyID);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_OffsetPtr(const JPH_IgnoreSingleBodyFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_OffsetMutablePtr(JPH_IgnoreSingleBodyFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::IgnoreSingleBodyFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(const JPH_IgnoreSingleBodyFilter *object);

/// Upcasts an instance of `JPH::IgnoreSingleBodyFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_IgnoreSingleBodyFilter_MutableUpcastTo_JPH_NonCopyable(JPH_IgnoreSingleBodyFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::IgnoreSingleBodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::IgnoreSingleBodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::IgnoreSingleBodyFilter` to its base class `JPH::BodyFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BodyFilter *JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(const JPH_IgnoreSingleBodyFilter *object);

/// Upcasts an instance of `JPH::IgnoreSingleBodyFilter` to its base class `JPH::BodyFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BodyFilter *JPH_IgnoreSingleBodyFilter_MutableUpcastTo_JPH_BodyFilter(JPH_IgnoreSingleBodyFilter *object);

/// Downcasts an instance of `JPH::BodyFilter` to a derived class `JPH::IgnoreSingleBodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(const JPH_BodyFilter *object);

/// Downcasts an instance of `JPH::BodyFilter` to a derived class `JPH::IgnoreSingleBodyFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_MutableStaticDowncastFrom_JPH_BodyFilter(JPH_BodyFilter *object);

/// Destroys a heap-allocated instance of `JPH_IgnoreSingleBodyFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_IgnoreSingleBodyFilter_Destroy(const JPH_IgnoreSingleBodyFilter *_this);

/// Destroys a heap-allocated array of `JPH_IgnoreSingleBodyFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_IgnoreSingleBodyFilter_DestroyArray(const JPH_IgnoreSingleBodyFilter *_this);

/// Filter function. Returns true if we should collide with inBodyID
/// Generated from method `JPH::IgnoreSingleBodyFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_IgnoreSingleBodyFilter_ShouldCollide(const JPH_IgnoreSingleBodyFilter *_this, const JPH_BodyID *inBodyID);

/// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
/// Generated from method `JPH::IgnoreSingleBodyFilter::ShouldCollideLocked`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API bool JPH_IgnoreSingleBodyFilter_ShouldCollideLocked(const JPH_IgnoreSingleBodyFilter *_this, const JPH_Body *inBody);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_IgnoreMultipleBodiesFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_IgnoreMultipleBodiesFilter_DestroyArray()`.
/// Use `JPH_IgnoreMultipleBodiesFilter_OffsetMutablePtr()` and `JPH_IgnoreMultipleBodiesFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_OffsetPtr(const JPH_IgnoreMultipleBodiesFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_OffsetMutablePtr(JPH_IgnoreMultipleBodiesFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::IgnoreMultipleBodiesFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(const JPH_IgnoreMultipleBodiesFilter *object);

/// Upcasts an instance of `JPH::IgnoreMultipleBodiesFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_IgnoreMultipleBodiesFilter_MutableUpcastTo_JPH_NonCopyable(JPH_IgnoreMultipleBodiesFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::IgnoreMultipleBodiesFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::IgnoreMultipleBodiesFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::IgnoreMultipleBodiesFilter` to its base class `JPH::BodyFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BodyFilter *JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(const JPH_IgnoreMultipleBodiesFilter *object);

/// Upcasts an instance of `JPH::IgnoreMultipleBodiesFilter` to its base class `JPH::BodyFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BodyFilter *JPH_IgnoreMultipleBodiesFilter_MutableUpcastTo_JPH_BodyFilter(JPH_IgnoreMultipleBodiesFilter *object);

/// Downcasts an instance of `JPH::BodyFilter` to a derived class `JPH::IgnoreMultipleBodiesFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(const JPH_BodyFilter *object);

/// Downcasts an instance of `JPH::BodyFilter` to a derived class `JPH::IgnoreMultipleBodiesFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_MutableStaticDowncastFrom_JPH_BodyFilter(JPH_BodyFilter *object);

/// Destroys a heap-allocated instance of `JPH_IgnoreMultipleBodiesFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_IgnoreMultipleBodiesFilter_Destroy(const JPH_IgnoreMultipleBodiesFilter *_this);

/// Destroys a heap-allocated array of `JPH_IgnoreMultipleBodiesFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_IgnoreMultipleBodiesFilter_DestroyArray(const JPH_IgnoreMultipleBodiesFilter *_this);

/// Remove all bodies from the filter
/// Generated from method `JPH::IgnoreMultipleBodiesFilter::Clear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_IgnoreMultipleBodiesFilter_Clear(JPH_IgnoreMultipleBodiesFilter *_this);

/// Reserve space for inSize body ID's
/// Generated from method `JPH::IgnoreMultipleBodiesFilter::Reserve`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_IgnoreMultipleBodiesFilter_Reserve(JPH_IgnoreMultipleBodiesFilter *_this, unsigned int inSize);

/// Add a body to be ignored
/// Generated from method `JPH::IgnoreMultipleBodiesFilter::IgnoreBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_IgnoreMultipleBodiesFilter_IgnoreBody(JPH_IgnoreMultipleBodiesFilter *_this, const JPH_BodyID *inBodyID);

/// Filter function. Returns true if we should collide with inBodyID
/// Generated from method `JPH::IgnoreMultipleBodiesFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_IgnoreMultipleBodiesFilter_ShouldCollide(const JPH_IgnoreMultipleBodiesFilter *_this, const JPH_BodyID *inBodyID);

/// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
/// Generated from method `JPH::IgnoreMultipleBodiesFilter::ShouldCollideLocked`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API bool JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked(const JPH_IgnoreMultipleBodiesFilter *_this, const JPH_Body *inBody);

#ifdef __cplusplus
} // extern "C"
#endif
