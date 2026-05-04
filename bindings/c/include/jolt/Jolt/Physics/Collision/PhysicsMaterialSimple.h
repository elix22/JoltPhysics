// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_RefTarget_JPH_PhysicsMaterial JPH_RefTarget_JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.


/// Sample implementation of PhysicsMaterial that just holds the needed properties directly
/// Generated from class `JPH::PhysicsMaterialSimple`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::PhysicsMaterial`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::PhysicsMaterial>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PhysicsMaterialSimple JPH_PhysicsMaterialSimple;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsMaterialSimple_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PhysicsMaterialSimple_DestroyArray()`.
/// Use `JPH_PhysicsMaterialSimple_OffsetMutablePtr()` and `JPH_PhysicsMaterialSimple_OffsetPtr()` to access the array elements.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_OffsetPtr(const JPH_PhysicsMaterialSimple *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_OffsetMutablePtr(JPH_PhysicsMaterialSimple *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(const JPH_PhysicsMaterialSimple *object);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_SerializableObject(JPH_PhysicsMaterialSimple *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::RefTarget<JPH::PhysicsMaterial>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_PhysicsMaterialSimple *object);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::RefTarget<JPH::PhysicsMaterial>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(JPH_PhysicsMaterialSimple *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PhysicsMaterial>` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_RefTarget_JPH_PhysicsMaterial *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::PhysicsMaterial>` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH_RefTarget_JPH_PhysicsMaterial *object);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::PhysicsMaterial`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(const JPH_PhysicsMaterialSimple *object);

/// Upcasts an instance of `JPH::PhysicsMaterialSimple` to its base class `JPH::PhysicsMaterial`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_PhysicsMaterial(JPH_PhysicsMaterialSimple *object);

/// Downcasts an instance of `JPH::PhysicsMaterial` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(const JPH_PhysicsMaterial *object);

/// Downcasts an instance of `JPH::PhysicsMaterial` to a derived class `JPH::PhysicsMaterialSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_PhysicsMaterial(JPH_PhysicsMaterial *object);

/// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsMaterialSimple_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PhysicsMaterialSimple *_other);

/// Destroys a heap-allocated instance of `JPH_PhysicsMaterialSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsMaterialSimple_Destroy(const JPH_PhysicsMaterialSimple *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsMaterialSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsMaterialSimple_DestroyArray(const JPH_PhysicsMaterialSimple *_this);

/// Generated from method `JPH::PhysicsMaterialSimple::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_AssignFromAnother(JPH_PhysicsMaterialSimple *_this, Jolt_PassBy _other_pass_by, JPH_PhysicsMaterialSimple *_other);

/// Generated from method `JPH::PhysicsMaterialSimple::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsMaterialSimple_size_t(size_t inCount);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PhysicsMaterialSimple::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsMaterialSimple_size_t(size_t inCount);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PhysicsMaterialSimple::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PhysicsMaterialSimple::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);

// Properties
/// Generated from method `JPH::PhysicsMaterialSimple::GetDebugName`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const char *JPH_PhysicsMaterialSimple_GetDebugName(const JPH_PhysicsMaterialSimple *_this);

/// Generated from method `JPH::PhysicsMaterialSimple::GetDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_PhysicsMaterialSimple_GetDebugColor(const JPH_PhysicsMaterialSimple *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PhysicsMaterialSimple::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterialSimple_SetEmbedded(const JPH_PhysicsMaterialSimple *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PhysicsMaterialSimple::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PhysicsMaterialSimple_GetRefCount(const JPH_PhysicsMaterialSimple *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PhysicsMaterialSimple::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterialSimple_AddRef(const JPH_PhysicsMaterialSimple *_this);

/// Generated from method `JPH::PhysicsMaterialSimple::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsMaterialSimple_Release(const JPH_PhysicsMaterialSimple *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PhysicsMaterialSimple::sInternalGetRefCountOffset`.
JOLT_API int JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
