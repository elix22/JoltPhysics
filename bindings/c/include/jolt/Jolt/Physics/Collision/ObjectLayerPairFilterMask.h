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
/// Uses group bits and mask bits. Two layers can collide if Object1.Group & Object2.Mask is non-zero and Object2.Group & Object1.Mask is non-zero.
/// The behavior is similar to that in e.g. Bullet.
/// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectVsBroadPhaseLayerFilterMask
/// Generated from class `JPH::ObjectLayerPairFilterMask`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ObjectLayerPairFilter`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ObjectLayerPairFilterMask JPH_ObjectLayerPairFilterMask;

/// Number of bits for the group and mask bits
/// Returns a pointer to a member variable of class `JPH::ObjectLayerPairFilterMask` named `cNumBits`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_ObjectLayerPairFilterMask_Get_cNumBits(void);

/// Returns a pointer to a member variable of class `JPH::ObjectLayerPairFilterMask` named `cMask`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_ObjectLayerPairFilterMask_Get_cMask(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ObjectLayerPairFilterMask_Destroy()` to free it when you're done using it.
JOLT_API JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ObjectLayerPairFilterMask_DestroyArray()`.
/// Use `JPH_ObjectLayerPairFilterMask_OffsetMutablePtr()` and `JPH_ObjectLayerPairFilterMask_OffsetPtr()` to access the array elements.
JOLT_API JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_OffsetPtr(const JPH_ObjectLayerPairFilterMask *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_OffsetMutablePtr(JPH_ObjectLayerPairFilterMask *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterMask` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilterMask *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterMask` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ObjectLayerPairFilterMask_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilterMask *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ObjectLayerPairFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterMask` to its base class `JPH::ObjectLayerPairFilter`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilterMask *object);

/// Upcasts an instance of `JPH::ObjectLayerPairFilterMask` to its base class `JPH::ObjectLayerPairFilter`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterMask_MutableUpcastTo_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilterMask *object);

/// Downcasts an instance of `JPH::ObjectLayerPairFilter` to a derived class `JPH::ObjectLayerPairFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilter *object);

/// Downcasts an instance of `JPH::ObjectLayerPairFilter` to a derived class `JPH::ObjectLayerPairFilterMask`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_MutableStaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilter *object);

/// Destroys a heap-allocated instance of `JPH_ObjectLayerPairFilterMask`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilterMask_Destroy(const JPH_ObjectLayerPairFilterMask *_this);

/// Destroys a heap-allocated array of `JPH_ObjectLayerPairFilterMask`. Does nothing if the pointer is null.
JOLT_API void JPH_ObjectLayerPairFilterMask_DestroyArray(const JPH_ObjectLayerPairFilterMask *_this);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectLayerPairFilterMask_size_t(size_t inCount);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t(size_t inCount);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator new`.
JOLT_API void *Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
JOLT_API void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Construct an ObjectLayer from a group and mask bits
/// Generated from method `JPH::ObjectLayerPairFilterMask::sGetObjectLayer`.
/// Parameter `inMask` has a default argument: `cMask`, pass a null pointer to use it.
JOLT_API unsigned short JPH_ObjectLayerPairFilterMask_sGetObjectLayer(unsigned int inGroup, const unsigned int *inMask);

/// Get the group bits from an ObjectLayer
/// Generated from method `JPH::ObjectLayerPairFilterMask::sGetGroup`.
JOLT_API unsigned int JPH_ObjectLayerPairFilterMask_sGetGroup(unsigned short inObjectLayer);

/// Get the mask bits from an ObjectLayer
/// Generated from method `JPH::ObjectLayerPairFilterMask::sGetMask`.
JOLT_API unsigned int JPH_ObjectLayerPairFilterMask_sGetMask(unsigned short inObjectLayer);

/// Returns true if two layers can collide
/// Generated from method `JPH::ObjectLayerPairFilterMask::ShouldCollide`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ObjectLayerPairFilterMask_ShouldCollide(const JPH_ObjectLayerPairFilterMask *_this, unsigned short inObject1, unsigned short inObject2);

#ifdef __cplusplus
} // extern "C"
#endif
