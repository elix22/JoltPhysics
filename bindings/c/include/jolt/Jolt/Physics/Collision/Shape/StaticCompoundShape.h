// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_CompoundShape JPH_CompoundShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/CompoundShape.h>`.
typedef struct JPH_CompoundShapeSettings JPH_CompoundShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/CompoundShape.h>`.
typedef struct JPH_CompoundShape_SubShape JPH_CompoundShape_SubShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/CompoundShape.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_Stats JPH_Shape_Stats; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TempAllocator JPH_TempAllocator; // Defined in `#include <jolt/Jolt/Core/TempAllocator.h>`.


/// Class that constructs a StaticCompoundShape. Note that if you only want a compound of 1 shape, use a RotatedTranslatedShape instead.
/// Generated from class `JPH::StaticCompoundShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_StaticCompoundShapeSettings JPH_StaticCompoundShapeSettings;

/// A compound shape, sub shapes can be rotated and translated.
/// Sub shapes cannot be modified once the shape is constructed.
/// Shifts all child objects so that they're centered around the center of mass.
/// Generated from class `JPH::StaticCompoundShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_StaticCompoundShape JPH_StaticCompoundShape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::StaticCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_StaticCompoundShapeSettings_Get_mUserData(const JPH_StaticCompoundShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::StaticCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_StaticCompoundShapeSettings_Set_mUserData(JPH_StaticCompoundShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::StaticCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_StaticCompoundShapeSettings_GetMutable_mUserData(JPH_StaticCompoundShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_StaticCompoundShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_StaticCompoundShapeSettings_DestroyArray()`.
/// Use `JPH_StaticCompoundShapeSettings_OffsetMutablePtr()` and `JPH_StaticCompoundShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_OffsetPtr(const JPH_StaticCompoundShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_OffsetMutablePtr(JPH_StaticCompoundShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_StaticCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_StaticCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_StaticCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_StaticCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_StaticCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_StaticCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::CompoundShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(const JPH_StaticCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::StaticCompoundShapeSettings` to its base class `JPH::CompoundShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_CompoundShapeSettings(JPH_StaticCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::CompoundShapeSettings` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_CompoundShapeSettings(const JPH_CompoundShapeSettings *object);

/// Downcasts an instance of `JPH::CompoundShapeSettings` to a derived class `JPH::StaticCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_CompoundShapeSettings(JPH_CompoundShapeSettings *object);

/// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_StaticCompoundShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_StaticCompoundShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_StaticCompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_StaticCompoundShapeSettings_Destroy(const JPH_StaticCompoundShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_StaticCompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_StaticCompoundShapeSettings_DestroyArray(const JPH_StaticCompoundShapeSettings *_this);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_AssignFromAnother(JPH_StaticCompoundShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_StaticCompoundShapeSettings *_other);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_StaticCompoundShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_StaticCompoundShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_StaticCompoundShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_StaticCompoundShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::StaticCompoundShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShapeSettings_ClearCachedResult(JPH_StaticCompoundShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::StaticCompoundShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShapeSettings_SetEmbedded(const JPH_StaticCompoundShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::StaticCompoundShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShapeSettings_GetRefCount(const JPH_StaticCompoundShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::StaticCompoundShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShapeSettings_AddRef(const JPH_StaticCompoundShapeSettings *_this);

/// Generated from method `JPH::StaticCompoundShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShapeSettings_Release(const JPH_StaticCompoundShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::StaticCompoundShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::StaticCompoundShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_StaticCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_StaticCompoundShape_DestroyArray()`.
/// Use `JPH_StaticCompoundShape_OffsetMutablePtr()` and `JPH_StaticCompoundShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShape *JPH_StaticCompoundShape_OffsetPtr(const JPH_StaticCompoundShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_OffsetMutablePtr(JPH_StaticCompoundShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_StaticCompoundShape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_StaticCompoundShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(const JPH_StaticCompoundShape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_StaticCompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_StaticCompoundShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_StaticCompoundShape_UpcastTo_JPH_Shape(const JPH_StaticCompoundShape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_Shape(JPH_StaticCompoundShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::CompoundShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(const JPH_StaticCompoundShape *object);

/// Upcasts an instance of `JPH::StaticCompoundShape` to its base class `JPH::CompoundShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_CompoundShape(JPH_StaticCompoundShape *object);

/// Downcasts an instance of `JPH::CompoundShape` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_CompoundShape(const JPH_CompoundShape *object);

/// Downcasts an instance of `JPH::CompoundShape` to a derived class `JPH::StaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_CompoundShape(JPH_CompoundShape *object);

/// Destroys a heap-allocated instance of `JPH_StaticCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_StaticCompoundShape_Destroy(const JPH_StaticCompoundShape *_this);

/// Destroys a heap-allocated array of `JPH_StaticCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_StaticCompoundShape_DestroyArray(const JPH_StaticCompoundShape *_this);

/// Generated from method `JPH::StaticCompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_StaticCompoundShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::StaticCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::StaticCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::StaticCompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_StaticCompoundShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::StaticCompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_StaticCompoundShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::StaticCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::StaticCompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_StaticCompoundShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: CompoundShape::GetIntersectingSubShapes
/// Generated from method `JPH::StaticCompoundShape::GetIntersectingSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
JOLT_API int JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_StaticCompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices);

// See Shape::GetStats
/// Generated from method `JPH::StaticCompoundShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_StaticCompoundShape_GetStats(const JPH_StaticCompoundShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::StaticCompoundShape::sRegister`.
JOLT_API void JPH_StaticCompoundShape_sRegister(void);

// See Shape::MustBeStatic
/// Generated from method `JPH::StaticCompoundShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_StaticCompoundShape_MustBeStatic(const JPH_StaticCompoundShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::StaticCompoundShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_StaticCompoundShape_GetLocalBounds(const JPH_StaticCompoundShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::StaticCompoundShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive(const JPH_StaticCompoundShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::StaticCompoundShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_StaticCompoundShape_GetInnerRadius(const JPH_StaticCompoundShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::StaticCompoundShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_StaticCompoundShape_GetMaterial(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetLeafShape
/// Generated from method `JPH::StaticCompoundShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_StaticCompoundShape_GetLeafShape(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::StaticCompoundShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_StaticCompoundShape_GetSubShapeUserData(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the total number of sub shapes
/// Generated from method `JPH::StaticCompoundShape::GetNumSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShape_GetNumSubShapes(const JPH_StaticCompoundShape *_this);

/// Access to a particular sub shape
/// Generated from method `JPH::StaticCompoundShape::GetSubShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CompoundShape_SubShape *JPH_StaticCompoundShape_GetSubShape(const JPH_StaticCompoundShape *_this, unsigned int inIdx);

/// Get the user data associated with a shape in this compound
/// Generated from method `JPH::StaticCompoundShape::GetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShape_GetCompoundUserData(const JPH_StaticCompoundShape *_this, unsigned int inIdx);

/// Set the user data associated with a shape in this compound
/// Generated from method `JPH::StaticCompoundShape::SetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShape_SetCompoundUserData(JPH_StaticCompoundShape *_this, unsigned int inIdx, unsigned int inUserData);

/// Check if a sub shape ID is still valid for this shape
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @return True if the ID is valid, false if not
/// Generated from method `JPH::StaticCompoundShape::IsSubShapeIDValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API bool JPH_StaticCompoundShape_IsSubShapeIDValid(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Convert SubShapeID to sub shape index
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
/// @return The index of the sub shape of this compound
/// Generated from method `JPH::StaticCompoundShape::GetSubShapeIndexFromID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShape_GetSubShapeIndexFromID(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetVolume
/// Generated from method `JPH::StaticCompoundShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_StaticCompoundShape_GetVolume(const JPH_StaticCompoundShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::StaticCompoundShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_StaticCompoundShape_GetUserData(const JPH_StaticCompoundShape *_this);

/// Generated from method `JPH::StaticCompoundShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShape_SetUserData(JPH_StaticCompoundShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::StaticCompoundShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShape_SetEmbedded(const JPH_StaticCompoundShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::StaticCompoundShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_StaticCompoundShape_GetRefCount(const JPH_StaticCompoundShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::StaticCompoundShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShape_AddRef(const JPH_StaticCompoundShape *_this);

/// Generated from method `JPH::StaticCompoundShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_StaticCompoundShape_Release(const JPH_StaticCompoundShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::StaticCompoundShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_StaticCompoundShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
