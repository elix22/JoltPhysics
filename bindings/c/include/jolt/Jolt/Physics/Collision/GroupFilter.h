// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_RefTarget_JPH_GroupFilter JPH_RefTarget_JPH_GroupFilter; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.


/// Abstract class that checks if two CollisionGroups collide
/// Generated from class `JPH::GroupFilter`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::GroupFilter>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::GroupFilterTable`
typedef struct JPH_GroupFilter JPH_GroupFilter;

/// Destroys a heap-allocated instance of `JPH_GroupFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_GroupFilter_Destroy(const JPH_GroupFilter *_this);

/// Destroys a heap-allocated array of `JPH_GroupFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_GroupFilter_DestroyArray(const JPH_GroupFilter *_this);

/// Generated from method `JPH::GroupFilter::operator new`.
JOLT_API void *Jolt_new_JPH_GroupFilter_size_t(size_t inCount);

/// Generated from method `JPH::GroupFilter::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilter_void_ptr(void *inPointer);

/// Generated from method `JPH::GroupFilter::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilter_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GroupFilter::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GroupFilter_size_t(size_t inCount);

/// Generated from method `JPH::GroupFilter::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilter_void_ptr(void *inPointer);

/// Generated from method `JPH::GroupFilter::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::GroupFilter::operator new`.
JOLT_API void *Jolt_new_JPH_GroupFilter_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GroupFilter::operator delete`.
JOLT_API void Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::GroupFilter::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_GroupFilter_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::GroupFilter::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if two groups collide
/// Generated from method `JPH::GroupFilter::CanCollide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGroup1` can not be null. It is a single object.
/// Parameter `inGroup2` can not be null. It is a single object.
JOLT_API bool JPH_GroupFilter_CanCollide(const JPH_GroupFilter *_this, const JPH_CollisionGroup *inGroup1, const JPH_CollisionGroup *inGroup2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::GroupFilter::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilter_SetEmbedded(const JPH_GroupFilter *_this);

/// Get current refcount of this object
/// Generated from method `JPH::GroupFilter::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_GroupFilter_GetRefCount(const JPH_GroupFilter *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::GroupFilter::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilter_AddRef(const JPH_GroupFilter *_this);

/// Generated from method `JPH::GroupFilter::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_GroupFilter_Release(const JPH_GroupFilter *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::GroupFilter::sInternalGetRefCountOffset`.
JOLT_API int JPH_GroupFilter_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_GroupFilter *JPH_GroupFilter_OffsetPtr(const JPH_GroupFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_GroupFilter *JPH_GroupFilter_OffsetMutablePtr(JPH_GroupFilter *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::GroupFilter` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_GroupFilter_UpcastTo_JPH_SerializableObject(const JPH_GroupFilter *object);

/// Upcasts an instance of `JPH::GroupFilter` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_GroupFilter_MutableUpcastTo_JPH_SerializableObject(JPH_GroupFilter *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GroupFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilter *JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::GroupFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilter *JPH_GroupFilter_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::GroupFilter` to its base class `JPH::RefTarget<JPH::GroupFilter>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(const JPH_GroupFilter *object);

/// Upcasts an instance of `JPH::GroupFilter` to its base class `JPH::RefTarget<JPH::GroupFilter>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilter_MutableUpcastTo_JPH_RefTarget_JPH_GroupFilter(JPH_GroupFilter *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::GroupFilter>` to a derived class `JPH::GroupFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_GroupFilter *JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(const JPH_RefTarget_JPH_GroupFilter *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::GroupFilter>` to a derived class `JPH::GroupFilter`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_GroupFilter *JPH_GroupFilter_MutableStaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH_RefTarget_JPH_GroupFilter *object);

#ifdef __cplusplus
} // extern "C"
#endif
