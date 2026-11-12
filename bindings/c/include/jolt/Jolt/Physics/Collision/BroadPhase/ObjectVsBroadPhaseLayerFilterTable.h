// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_BroadPhaseLayer JPH_BroadPhaseLayer; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_BroadPhaseLayerInterface JPH_BroadPhaseLayerInterface; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerPairFilter JPH_ObjectLayerPairFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_ObjectVsBroadPhaseLayerFilter JPH_ObjectVsBroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.


/// Class that determines if an object layer can collide with a broadphase layer.
/// This implementation uses a table and constructs itself from an ObjectLayerPairFilter and a BroadPhaseLayerInterface.
/// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectVsBroadPhaseLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_ObjectVsBroadPhaseLayerFilterTable JPH_ObjectVsBroadPhaseLayerFilterTable;

/// Construct the table
/// @param inBroadPhaseLayerInterface The broad phase layer interface that maps object layers to broad phase layers
/// @param inNumBroadPhaseLayers Number of broad phase layers
/// @param inObjectLayerPairFilter The object layer pair filter that determines which object layers can collide
/// @param inNumObjectLayers Number of object layers
/// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterTable::ObjectVsBroadPhaseLayerFilterTable`.
/// Parameter `inBroadPhaseLayerInterface` can not be null. It is a single object.
/// Parameter `inObjectLayerPairFilter` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(const JPH_BroadPhaseLayerInterface *inBroadPhaseLayerInterface, unsigned int inNumBroadPhaseLayers, const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter, unsigned int inNumObjectLayers);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilterTable *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilterTable *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterTable` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilterTable *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterTable` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilterTable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterTable` to its base class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilterTable *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterTable` to its base class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableUpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilterTable *object);

/// Downcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableStaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Destroys a heap-allocated instance of `JPH_ObjectVsBroadPhaseLayerFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this);

/// Destroys a heap-allocated array of `JPH_ObjectVsBroadPhaseLayerFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilterTable_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(size_t inCount);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(size_t inCount);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Returns true if an object layer should collide with a broadphase layer
/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer2` can not be null. It is a single object.
JOLT_API bool JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2);

#ifdef __cplusplus
} // extern "C"
#endif
