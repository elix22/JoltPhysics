// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_RefTarget_JPH_PhysicsMaterial JPH_RefTarget_JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.


/// This structure describes the surface of (part of) a shape. You should inherit from it to define additional
/// information that is interesting for the simulation. The 2 materials involved in a contact could be used
/// to decide which sound or particle effects to play.
///
/// If you inherit from this material, don't forget to create a suitable default material in sDefault
/// Generated from class `JPH::PhysicsMaterial`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::PhysicsMaterial>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PhysicsMaterial_DestroyArray()`.
/// Use `JPH_PhysicsMaterial_OffsetMutablePtr()` and `JPH_PhysicsMaterial_OffsetPtr()` to access the array elements.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterial *JPH_PhysicsMaterial_OffsetPtr(const JPH_PhysicsMaterial *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterial_OffsetMutablePtr(JPH_PhysicsMaterial *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PhysicsMaterial` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(const JPH_PhysicsMaterial *object);

/// Upcasts an instance of `JPH::PhysicsMaterial` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PhysicsMaterial_MutableUpcastTo_JPH_SerializableObject(JPH_PhysicsMaterial *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PhysicsMaterial`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterial *JPH_PhysicsMaterial_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PhysicsMaterial`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PhysicsMaterial` to its base class `JPH::RefTarget<JPH::PhysicsMaterial>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_PhysicsMaterial *object);

/// Upcasts an instance of `JPH::PhysicsMaterial` to its base class `JPH::RefTarget<JPH::PhysicsMaterial>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableUpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(JPH_PhysicsMaterial *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PhysicsMaterial>` to a derived class `JPH::PhysicsMaterial`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterial *JPH_PhysicsMaterial_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_RefTarget_JPH_PhysicsMaterial *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PhysicsMaterial>` to a derived class `JPH::PhysicsMaterial`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH_RefTarget_JPH_PhysicsMaterial *object);

/// Destroys a heap-allocated instance of `JPH_PhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsMaterial_Destroy(const JPH_PhysicsMaterial *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsMaterial_DestroyArray(const JPH_PhysicsMaterial *_this);

/// Generated from method `JPH::PhysicsMaterial::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsMaterial_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PhysicsMaterial::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterial_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsMaterial::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterial_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PhysicsMaterial::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsMaterial_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PhysicsMaterial::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsMaterial_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PhysicsMaterial::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PhysicsMaterial::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsMaterial_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace);

// Properties
/// Generated from method `JPH::PhysicsMaterial::GetDebugName`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const char *JPH_PhysicsMaterial_GetDebugName(const JPH_PhysicsMaterial *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PhysicsMaterial::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterial_SetEmbedded(const JPH_PhysicsMaterial *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PhysicsMaterial::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PhysicsMaterial_GetRefCount(const JPH_PhysicsMaterial *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PhysicsMaterial::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterial_AddRef(const JPH_PhysicsMaterial *_this);

/// Generated from method `JPH::PhysicsMaterial::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterial_Release(const JPH_PhysicsMaterial *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PhysicsMaterial::sInternalGetRefCountOffset`.
JOLT_API int JPH_PhysicsMaterial_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
