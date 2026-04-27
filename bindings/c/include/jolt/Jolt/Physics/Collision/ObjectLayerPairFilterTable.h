// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerPairFilter JPH_ObjectLayerPairFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.


/// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
/// This implementation uses a table to determine if two layers can collide.
/// Generated from class `JPH::ObjectLayerPairFilterTable`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectLayerPairFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_ObjectLayerPairFilterTable JPH_ObjectLayerPairFilterTable;

/// Constructs the table with inNumObjectLayers Layers, initially all layer pairs are disabled
/// Generated from constructor `JPH::ObjectLayerPairFilterTable::ObjectLayerPairFilterTable`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectLayerPairFilterTable_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_Construct(unsigned int inNumObjectLayers);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_OffsetPtr(const JPH_ObjectLayerPairFilterTable *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_OffsetMutablePtr(JPH_ObjectLayerPairFilterTable *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterTable` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilterTable *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterTable` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectLayerPairFilterTable_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilterTable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterTable` to its base class `JPH::ObjectLayerPairFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilterTable *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterTable` to its base class `JPH::ObjectLayerPairFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterTable_MutableUpcastTo_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilterTable *object);

/// Downcasts an instance of `JPH::ObjectLayerPairFilter` to a derived class `JPH::ObjectLayerPairFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerPairFilter` to a derived class `JPH::ObjectLayerPairFilterTable`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_MutableStaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilter *object);

/// Destroys a heap-allocated instance of `JPH_ObjectLayerPairFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilterTable_Destroy(const JPH_ObjectLayerPairFilterTable *_this);

/// Destroys a heap-allocated array of `JPH_ObjectLayerPairFilterTable`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilterTable_DestroyArray(const JPH_ObjectLayerPairFilterTable *_this);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectLayerPairFilterTable_size_t(unsigned long inCount);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t(unsigned long inCount);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the number of object layers
/// Generated from method `JPH::ObjectLayerPairFilterTable::GetNumObjectLayers`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ObjectLayerPairFilterTable_GetNumObjectLayers(const JPH_ObjectLayerPairFilterTable *_this);

/// Disable collision between two object layers
/// Generated from method `JPH::ObjectLayerPairFilterTable::DisableCollision`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ObjectLayerPairFilterTable_DisableCollision(JPH_ObjectLayerPairFilterTable *_this, unsigned short inLayer1, unsigned short inLayer2);

/// Enable collision between two object layers
/// Generated from method `JPH::ObjectLayerPairFilterTable::EnableCollision`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ObjectLayerPairFilterTable_EnableCollision(JPH_ObjectLayerPairFilterTable *_this, unsigned short inLayer1, unsigned short inLayer2);

/// Returns true if two layers can collide
/// Generated from method `JPH::ObjectLayerPairFilterTable::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ObjectLayerPairFilterTable_ShouldCollide(const JPH_ObjectLayerPairFilterTable *_this, unsigned short inObject1, unsigned short inObject2);

#ifdef __cplusplus
} // extern "C"
#endif
