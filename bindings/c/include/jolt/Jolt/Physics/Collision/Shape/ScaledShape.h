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
typedef struct JPH_DecoratedShape JPH_DecoratedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
typedef struct JPH_DecoratedShapeSettings JPH_DecoratedShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
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


/// Class that constructs a ScaledShape
/// Generated from class `JPH::ScaledShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ScaledShapeSettings JPH_ScaledShapeSettings;

/// A shape that scales a child shape in local space of that shape. The scale can be non-uniform and can even turn it inside out when one or three components of the scale are negative.
/// Generated from class `JPH::ScaledShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ScaledShape JPH_ScaledShape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ScaledShapeSettings_Get_mUserData(const JPH_ScaledShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ScaledShapeSettings_Set_mUserData(JPH_ScaledShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ScaledShapeSettings_GetMutable_mUserData(JPH_ScaledShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ScaledShapeSettings_DestroyArray()`.
/// Use `JPH_ScaledShapeSettings_OffsetMutablePtr()` and `JPH_ScaledShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetPtr(const JPH_ScaledShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetMutablePtr(JPH_ScaledShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ScaledShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object);

/// Generated from constructor `JPH::ScaledShapeSettings::ScaledShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_ScaledShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShapeSettings_Destroy(const JPH_ScaledShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ScaledShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShapeSettings_DestroyArray(const JPH_ScaledShapeSettings *_this);

/// Generated from method `JPH::ScaledShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_AssignFromAnother(JPH_ScaledShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other);

/// Generated from method `JPH::ScaledShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ScaledShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ScaledShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ScaledShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ScaledShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_ClearCachedResult(JPH_ScaledShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ScaledShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_SetEmbedded(const JPH_ScaledShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ScaledShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShapeSettings_GetRefCount(const JPH_ScaledShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ScaledShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_AddRef(const JPH_ScaledShapeSettings *_this);

/// Generated from method `JPH::ScaledShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_Release(const JPH_ScaledShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ScaledShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ScaledShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::ScaledShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_ScaledShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ScaledShape_DestroyArray()`.
/// Use `JPH_ScaledShape_OffsetMutablePtr()` and `JPH_ScaledShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_OffsetPtr(const JPH_ScaledShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_OffsetMutablePtr(JPH_ScaledShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ScaledShape_UpcastTo_JPH_NonCopyable(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ScaledShape_MutableUpcastTo_JPH_NonCopyable(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_Shape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_Shape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::DecoratedShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_ScaledShape_UpcastTo_JPH_DecoratedShape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::DecoratedShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_ScaledShape_MutableUpcastTo_JPH_DecoratedShape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object);

/// Destroys a heap-allocated instance of `JPH_ScaledShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShape_Destroy(const JPH_ScaledShape *_this);

/// Destroys a heap-allocated array of `JPH_ScaledShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShape_DestroyArray(const JPH_ScaledShape *_this);

/// Generated from method `JPH::ScaledShape::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ScaledShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ScaledShape::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ScaledShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::GetLocalBounds
/// Generated from method `JPH::ScaledShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ScaledShape_GetLocalBounds(const JPH_ScaledShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::ScaledShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ScaledShape_GetInnerRadius(const JPH_ScaledShape *_this);

// See Shape::GetStats
/// Generated from method `JPH::ScaledShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_ScaledShape_GetStats(const JPH_ScaledShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::ScaledShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ScaledShape_GetVolume(const JPH_ScaledShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::ScaledShape::sRegister`.
JOLT_API void JPH_ScaledShape_sRegister(void);

/// Access to the decorated inner shape
/// Generated from method `JPH::ScaledShape::GetInnerShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ScaledShape_GetInnerShape(const JPH_ScaledShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::ScaledShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ScaledShape_MustBeStatic(const JPH_ScaledShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::ScaledShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShape_GetSubShapeIDBitsRecursive(const JPH_ScaledShape *_this);

// See Shape::GetLeafShape
/// Generated from method `JPH::ScaledShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ScaledShape_GetLeafShape(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetMaterial
/// Generated from method `JPH::ScaledShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_ScaledShape_GetMaterial(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::ScaledShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_ScaledShape_GetSubShapeUserData(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID);

/// User data (to be used freely by the application)
/// Generated from method `JPH::ScaledShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_ScaledShape_GetUserData(const JPH_ScaledShape *_this);

/// Generated from method `JPH::ScaledShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_SetUserData(JPH_ScaledShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ScaledShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_SetEmbedded(const JPH_ScaledShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ScaledShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShape_GetRefCount(const JPH_ScaledShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ScaledShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_AddRef(const JPH_ScaledShape *_this);

/// Generated from method `JPH::ScaledShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_Release(const JPH_ScaledShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ScaledShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_ScaledShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
