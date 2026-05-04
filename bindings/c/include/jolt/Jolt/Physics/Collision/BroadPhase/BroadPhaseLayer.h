// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// An object layer can be mapped to a broadphase layer. Objects with the same broadphase layer will end up in the same sub structure (usually a tree) of the broadphase.
/// When there are many layers, this reduces the total amount of sub structures the broad phase needs to manage. Usually you want objects that don't collide with each other
/// in different broad phase layers, but there could be exceptions if objects layers only contain a minor amount of objects so it is not beneficial to give each layer its
/// own sub structure in the broadphase.
/// Note: This class requires explicit casting from and to Type to avoid confusion with ObjectLayer
/// Generated from class `JPH::BroadPhaseLayer`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BroadPhaseLayer JPH_BroadPhaseLayer;

/// Interface that the application should implement to allow mapping object layers to broadphase layers
/// Generated from class `JPH::BroadPhaseLayerInterface`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseLayerInterfaceMask`
///     `JPH::BroadPhaseLayerInterfaceTable`
typedef struct JPH_BroadPhaseLayerInterface JPH_BroadPhaseLayerInterface;

/// Class to test if an object can collide with a broadphase layer. Used while finding collision pairs.
/// Generated from class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ObjectVsBroadPhaseLayerFilterMask`
///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ObjectVsBroadPhaseLayerFilter JPH_ObjectVsBroadPhaseLayerFilter;

/// Filter class for broadphase layers
/// Generated from class `JPH::BroadPhaseLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DefaultBroadPhaseLayerFilter`
///     `JPH::SpecifiedBroadPhaseLayerFilter`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BroadPhaseLayerFilter JPH_BroadPhaseLayerFilter;

/// Default filter class that uses the pair filter in combination with a specified layer to filter layers
/// Generated from class `JPH::DefaultBroadPhaseLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_DefaultBroadPhaseLayerFilter JPH_DefaultBroadPhaseLayerFilter;

/// Allows objects from a specific broad phase layer only
/// Generated from class `JPH::SpecifiedBroadPhaseLayerFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_SpecifiedBroadPhaseLayerFilter JPH_SpecifiedBroadPhaseLayerFilter;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BroadPhaseLayer_DestroyArray()`.
/// Use `JPH_BroadPhaseLayer_OffsetMutablePtr()` and `JPH_BroadPhaseLayer_OffsetPtr()` to access the array elements.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_OffsetPtr(const JPH_BroadPhaseLayer *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_OffsetMutablePtr(JPH_BroadPhaseLayer *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_ConstructFromAnother(const JPH_BroadPhaseLayer *_other);

/// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_Construct(unsigned char inValue);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseLayer`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayer_Destroy(const JPH_BroadPhaseLayer *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseLayer`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayer_DestroyArray(const JPH_BroadPhaseLayer *_this);

/// Generated from conversion operator `JPH::BroadPhaseLayer::operator unsigned char`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_BroadPhaseLayer_ConvertTo_unsigned_char(const JPH_BroadPhaseLayer *_this);

/// Generated from method `JPH::BroadPhaseLayer::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_AssignFromAnother(JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *_other);

/// Generated from method `JPH::BroadPhaseLayer::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS);

/// Generated from method `JPH::BroadPhaseLayer::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS);

/// Generated from method `JPH::BroadPhaseLayer::operator<`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_less_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS);

/// Generated from method `JPH::BroadPhaseLayer::GetValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_BroadPhaseLayer_GetValue(const JPH_BroadPhaseLayer *_this);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseLayerInterface`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterface_Destroy(const JPH_BroadPhaseLayerInterface *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseLayerInterface`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterface_DestroyArray(const JPH_BroadPhaseLayerInterface *_this);

/// Return the number of broadphase layers there are
/// Generated from method `JPH::BroadPhaseLayerInterface::GetNumBroadPhaseLayers`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterface *_this);

/// Convert an object layer to the corresponding broadphase layer
/// Generated from method `JPH::BroadPhaseLayerInterface::GetBroadPhaseLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterface *_this, unsigned short inLayer);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_OffsetPtr(const JPH_BroadPhaseLayerInterface *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_OffsetMutablePtr(JPH_BroadPhaseLayerInterface *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterface` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterface *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterface` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BroadPhaseLayerInterface_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterface *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterface`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterface`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectVsBroadPhaseLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ObjectVsBroadPhaseLayerFilter_DestroyArray()`.
/// Use `JPH_ObjectVsBroadPhaseLayerFilter_OffsetMutablePtr()` and `JPH_ObjectVsBroadPhaseLayerFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_ObjectVsBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilter_Destroy(const JPH_ObjectVsBroadPhaseLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_ObjectVsBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilter_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilter *_this);

/// Returns true if an object layer should collide with a broadphase layer
/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer2` can not be null. It is a single object.
JOLT_API bool JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilter *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BroadPhaseLayerFilter_DestroyArray()`.
/// Use `JPH_BroadPhaseLayerFilter_OffsetMutablePtr()` and `JPH_BroadPhaseLayerFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_OffsetPtr(const JPH_BroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_OffsetMutablePtr(JPH_BroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerFilter_Destroy(const JPH_BroadPhaseLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerFilter_DestroyArray(const JPH_BroadPhaseLayerFilter *_this);

/// Function to filter out broadphase layers when doing collision query test (return true to allow testing against objects with this layer)
/// Generated from method `JPH::BroadPhaseLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer` can not be null. It is a single object.
JOLT_API bool JPH_BroadPhaseLayerFilter_ShouldCollide(const JPH_BroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer);

/// Constructor
/// Generated from constructor `JPH::DefaultBroadPhaseLayerFilter::DefaultBroadPhaseLayerFilter`.
/// Parameter `inObjectVsBroadPhaseLayerFilter` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DefaultBroadPhaseLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_Construct(const JPH_ObjectVsBroadPhaseLayerFilter *inObjectVsBroadPhaseLayerFilter, unsigned short inLayer);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_OffsetPtr(const JPH_DefaultBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_OffsetMutablePtr(JPH_DefaultBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DefaultBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_DefaultBroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::DefaultBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DefaultBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_DefaultBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DefaultBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DefaultBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::DefaultBroadPhaseLayerFilter` to its base class `JPH::BroadPhaseLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(const JPH_DefaultBroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::DefaultBroadPhaseLayerFilter` to its base class `JPH::BroadPhaseLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableUpcastTo_JPH_BroadPhaseLayerFilter(JPH_DefaultBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerFilter` to a derived class `JPH::DefaultBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(const JPH_BroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerFilter` to a derived class `JPH::DefaultBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH_BroadPhaseLayerFilter *object);

/// Destroys a heap-allocated instance of `JPH_DefaultBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_DefaultBroadPhaseLayerFilter_Destroy(const JPH_DefaultBroadPhaseLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_DefaultBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_DefaultBroadPhaseLayerFilter_DestroyArray(const JPH_DefaultBroadPhaseLayerFilter *_this);

// See BroadPhaseLayerFilter::ShouldCollide
/// Generated from method `JPH::DefaultBroadPhaseLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer` can not be null. It is a single object.
JOLT_API bool JPH_DefaultBroadPhaseLayerFilter_ShouldCollide(const JPH_DefaultBroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer);

/// Constructor
/// Generated from constructor `JPH::SpecifiedBroadPhaseLayerFilter::SpecifiedBroadPhaseLayerFilter`.
/// Parameter `inLayer` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SpecifiedBroadPhaseLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_Construct(const JPH_BroadPhaseLayer *inLayer);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_OffsetPtr(const JPH_SpecifiedBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_OffsetMutablePtr(JPH_SpecifiedBroadPhaseLayerFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SpecifiedBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_SpecifiedBroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::SpecifiedBroadPhaseLayerFilter` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SpecifiedBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SpecifiedBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SpecifiedBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SpecifiedBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SpecifiedBroadPhaseLayerFilter` to its base class `JPH::BroadPhaseLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(const JPH_SpecifiedBroadPhaseLayerFilter *object);

/// Upcasts an instance of `JPH::SpecifiedBroadPhaseLayerFilter` to its base class `JPH::BroadPhaseLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableUpcastTo_JPH_BroadPhaseLayerFilter(JPH_SpecifiedBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerFilter` to a derived class `JPH::SpecifiedBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(const JPH_BroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerFilter` to a derived class `JPH::SpecifiedBroadPhaseLayerFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH_BroadPhaseLayerFilter *object);

/// Destroys a heap-allocated instance of `JPH_SpecifiedBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SpecifiedBroadPhaseLayerFilter_Destroy(const JPH_SpecifiedBroadPhaseLayerFilter *_this);

/// Destroys a heap-allocated array of `JPH_SpecifiedBroadPhaseLayerFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_SpecifiedBroadPhaseLayerFilter_DestroyArray(const JPH_SpecifiedBroadPhaseLayerFilter *_this);

// See BroadPhaseLayerFilter::ShouldCollide
/// Generated from method `JPH::SpecifiedBroadPhaseLayerFilter::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer` can not be null. It is a single object.
JOLT_API bool JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide(const JPH_SpecifiedBroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer);

#ifdef __cplusplus
} // extern "C"
#endif
