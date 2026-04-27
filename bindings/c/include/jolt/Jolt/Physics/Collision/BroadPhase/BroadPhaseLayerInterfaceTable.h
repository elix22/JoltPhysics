// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_BroadPhaseLayer JPH_BroadPhaseLayer; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_BroadPhaseLayerInterface JPH_BroadPhaseLayerInterface; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// BroadPhaseLayerInterface implementation.
/// This defines a mapping between object and broadphase layers.
/// This implementation uses a simple table
/// Generated from class `JPH::BroadPhaseLayerInterfaceTable`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseLayerInterface`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_BroadPhaseLayerInterfaceTable JPH_BroadPhaseLayerInterfaceTable;

/// Generated from constructor `JPH::BroadPhaseLayerInterfaceTable::BroadPhaseLayerInterfaceTable`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayerInterfaceTable_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_Construct(unsigned int inNumObjectLayers, unsigned int inNumBroadPhaseLayers);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_OffsetPtr(const JPH_BroadPhaseLayerInterfaceTable *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_OffsetMutablePtr(JPH_BroadPhaseLayerInterfaceTable *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceTable` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterfaceTable *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceTable` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceTable_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterfaceTable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterfaceTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BroadPhaseLayerInterfaceTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceTable` to its base class `JPH::BroadPhaseLayerInterface`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterfaceTable *object);

/// Upcasts an instance of `JPH::BroadPhaseLayerInterfaceTable` to its base class `JPH::BroadPhaseLayerInterface`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceTable_MutableUpcastTo_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterfaceTable *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerInterface` to a derived class `JPH::BroadPhaseLayerInterfaceTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterface *object);

/// Downcasts an instance of `JPH::BroadPhaseLayerInterface` to a derived class `JPH::BroadPhaseLayerInterfaceTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_MutableStaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterface *object);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseLayerInterfaceTable`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterfaceTable_Destroy(const JPH_BroadPhaseLayerInterfaceTable *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseLayerInterfaceTable`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseLayerInterfaceTable_DestroyArray(const JPH_BroadPhaseLayerInterfaceTable *_this);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t(unsigned long inCount);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t(unsigned long inCount);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::MapObjectToBroadPhaseLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayer` can not be null. It is a single object.
JOLT_API void JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer(JPH_BroadPhaseLayerInterfaceTable *_this, unsigned short inObjectLayer, const JPH_BroadPhaseLayer *inBroadPhaseLayer);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::GetNumBroadPhaseLayers`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterfaceTable *_this);

/// Generated from method `JPH::BroadPhaseLayerInterfaceTable::GetBroadPhaseLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseLayer_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterfaceTable *_this, unsigned short inLayer);

#ifdef __cplusplus
} // extern "C"
#endif
