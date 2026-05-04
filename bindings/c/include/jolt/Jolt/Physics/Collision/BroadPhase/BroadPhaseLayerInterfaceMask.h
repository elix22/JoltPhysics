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


/// BroadPhaseLayerInterface implementation.
/// This defines a mapping between object and broadphase layers.
/// This implementation works together with ObjectLayerPairFilterMask and ObjectVsBroadPhaseLayerFilterMask.
/// A broadphase layer is suitable for an object if its group & inGroupsToInclude is not zero and its group & inGroupsToExclude is zero.
/// The broadphase layers are iterated from lowest to highest value and the first one that matches is taken. If none match then it takes the last layer.
/// Generated from class `JPH::BroadPhaseLayerInterfaceMask`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseLayerInterface`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_BroadPhaseLayerInterfaceMask JPH_BroadPhaseLayerInterfaceMask;

/// Generated from constructor `JPH::BroadPhaseLayerInterfaceMask::BroadPhaseLayerInterfaceMask`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayerInterfaceMask_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_Construct(unsigned int inNumBroadPhaseLayers);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_OffsetPtr(const JPH_BroadPhaseLayerInterfaceMask *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_OffsetMutablePtr(JPH_BroadPhaseLayerInterfaceMask *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceMask` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterfaceMask *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceMask` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceMask_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterfaceMask *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterfaceMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterfaceMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceMask` to its base class `JPH::BroadPhaseLayerInterface`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterfaceMask *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceMask` to its base class `JPH::BroadPhaseLayerInterface`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceMask_MutableUpcastTo_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterfaceMask *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerInterface` to a derived class `JPH::BroadPhaseLayerInterfaceMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterface *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerInterface` to a derived class `JPH::BroadPhaseLayerInterfaceMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_MutableStaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterface *object);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseLayerInterfaceMask`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterfaceMask_Destroy(const JPH_BroadPhaseLayerInterfaceMask *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseLayerInterfaceMask`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterfaceMask_DestroyArray(const JPH_BroadPhaseLayerInterfaceMask *_this);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t(size_t inCount);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t(size_t inCount);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

// Configures a broadphase layer.
/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::ConfigureLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayer` can not be null. It is a single object.
JOLT_API void JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer(JPH_BroadPhaseLayerInterfaceMask *_this, const JPH_BroadPhaseLayer *inBroadPhaseLayer, unsigned int inGroupsToInclude, unsigned int inGroupsToExclude);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::GetNumBroadPhaseLayers`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterfaceMask *_this);

/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::GetBroadPhaseLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterfaceMask *_this, unsigned short inLayer);

/// Returns true if an object layer should collide with a broadphase layer, this function is being called from ObjectVsBroadPhaseLayerFilterMask
/// Generated from method `JPH::BroadPhaseLayerInterfaceMask::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLayer2` can not be null. It is a single object.
JOLT_API bool JPH_BroadPhaseLayerInterfaceMask_ShouldCollide(const JPH_BroadPhaseLayerInterfaceMask *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2);

#ifdef __cplusplus
} // extern "C"
#endif
