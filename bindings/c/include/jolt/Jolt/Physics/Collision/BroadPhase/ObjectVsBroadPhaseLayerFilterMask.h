// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_BroadPhaseLayer JPH_BroadPhaseLayer; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_BroadPhaseLayerInterfaceMask JPH_BroadPhaseLayerInterfaceMask; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceMask.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectVsBroadPhaseLayerFilter JPH_ObjectVsBroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.


/// Class that determines if an object layer can collide with a broadphase layer.
/// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectLayerPairFilterMask
/// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectVsBroadPhaseLayerFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_ObjectVsBroadPhaseLayerFilterMask JPH_ObjectVsBroadPhaseLayerFilterMask;

/// Constructor
/// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
/// Parameter `inBroadPhaseLayerInterface` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(const JPH_BroadPhaseLayerInterfaceMask *inBroadPhaseLayerInterface);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilterMask *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilterMask *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterMask` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilterMask *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterMask` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilterMask *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterMask` to its base class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilterMask *object);

/// Upcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilterMask` to its base class `JPH::ObjectVsBroadPhaseLayerFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableUpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilterMask *object);

/// Downcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Downcasts an instance of `JPH::ObjectVsBroadPhaseLayerFilter` to a derived class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableStaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilter *object);

/// Destroys a heap-allocated instance of `JPH_ObjectVsBroadPhaseLayerFilterMask`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this);

/// Destroys a heap-allocated array of `JPH_ObjectVsBroadPhaseLayerFilterMask`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectVsBroadPhaseLayerFilterMask_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(size_t inCount);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(size_t inCount);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Returns true if an object layer should collide with a broadphase layer
/// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer2` can not be null. It is a single object.
JOLT_API bool JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2);

#ifdef __cplusplus
} // extern "C"
#endif
