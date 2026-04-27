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


/// Class that constructs a MutableCompoundShape.
/// Generated from class `JPH::MutableCompoundShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MutableCompoundShapeSettings JPH_MutableCompoundShapeSettings;

/// A compound shape, sub shapes can be rotated and translated.
/// This shape is optimized for adding / removing and changing the rotation / translation of sub shapes but is less efficient in querying.
/// Shifts all child objects so that they're centered around the center of mass (which needs to be kept up to date by calling AdjustCenterOfMass).
///
/// Note: If you're using MutableCompoundShape and are querying data while modifying the shape you'll have a race condition.
/// In this case it is best to create a new MutableCompoundShape using the Clone function. You replace the shape on a body using BodyInterface::SetShape.
/// If a query is still working on the old shape, it will have taken a reference and keep the old shape alive until the query finishes.
///
/// When you modify a MutableCompoundShape, beware that the SubShapeIDs of all other shapes can change. So be careful when storing SubShapeIDs.
/// Generated from class `JPH::MutableCompoundShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MutableCompoundShape JPH_MutableCompoundShape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::MutableCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_MutableCompoundShapeSettings_Get_mUserData(const JPH_MutableCompoundShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::MutableCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_MutableCompoundShapeSettings_Set_mUserData(JPH_MutableCompoundShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::MutableCompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_MutableCompoundShapeSettings_GetMutable_mUserData(JPH_MutableCompoundShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MutableCompoundShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MutableCompoundShapeSettings_DestroyArray()`.
/// Use `JPH_MutableCompoundShapeSettings_OffsetMutablePtr()` and `JPH_MutableCompoundShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_OffsetPtr(const JPH_MutableCompoundShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_OffsetMutablePtr(JPH_MutableCompoundShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_MutableCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MutableCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_MutableCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_MutableCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_MutableCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_MutableCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::CompoundShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(const JPH_MutableCompoundShapeSettings *object);

/// Upcasts an instance of `JPH::MutableCompoundShapeSettings` to its base class `JPH::CompoundShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_CompoundShapeSettings(JPH_MutableCompoundShapeSettings *object);

/// Downcasts an instance of `JPH::CompoundShapeSettings` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_CompoundShapeSettings(const JPH_CompoundShapeSettings *object);

/// Downcasts an instance of `JPH::CompoundShapeSettings` to a derived class `JPH::MutableCompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_CompoundShapeSettings(JPH_CompoundShapeSettings *object);

/// Generated from constructor `JPH::MutableCompoundShapeSettings::MutableCompoundShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MutableCompoundShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MutableCompoundShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_MutableCompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MutableCompoundShapeSettings_Destroy(const JPH_MutableCompoundShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_MutableCompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MutableCompoundShapeSettings_DestroyArray(const JPH_MutableCompoundShapeSettings *_this);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_AssignFromAnother(JPH_MutableCompoundShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_MutableCompoundShapeSettings *_other);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MutableCompoundShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MutableCompoundShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MutableCompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MutableCompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::MutableCompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::MutableCompoundShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShapeSettings_ClearCachedResult(JPH_MutableCompoundShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::MutableCompoundShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShapeSettings_SetEmbedded(const JPH_MutableCompoundShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::MutableCompoundShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShapeSettings_GetRefCount(const JPH_MutableCompoundShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::MutableCompoundShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShapeSettings_AddRef(const JPH_MutableCompoundShapeSettings *_this);

/// Generated from method `JPH::MutableCompoundShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShapeSettings_Release(const JPH_MutableCompoundShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::MutableCompoundShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_MutableCompoundShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::MutableCompoundShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_MutableCompoundShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MutableCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MutableCompoundShape_DestroyArray()`.
/// Use `JPH_MutableCompoundShape_OffsetMutablePtr()` and `JPH_MutableCompoundShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShape *JPH_MutableCompoundShape_OffsetPtr(const JPH_MutableCompoundShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_OffsetMutablePtr(JPH_MutableCompoundShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_MutableCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_MutableCompoundShape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_MutableCompoundShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_MutableCompoundShape_UpcastTo_JPH_NonCopyable(const JPH_MutableCompoundShape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_MutableCompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_MutableCompoundShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_MutableCompoundShape_UpcastTo_JPH_Shape(const JPH_MutableCompoundShape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_Shape(JPH_MutableCompoundShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::CompoundShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_MutableCompoundShape_UpcastTo_JPH_CompoundShape(const JPH_MutableCompoundShape *object);

/// Upcasts an instance of `JPH::MutableCompoundShape` to its base class `JPH::CompoundShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_CompoundShape(JPH_MutableCompoundShape *object);

/// Downcasts an instance of `JPH::CompoundShape` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_CompoundShape(const JPH_CompoundShape *object);

/// Downcasts an instance of `JPH::CompoundShape` to a derived class `JPH::MutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_CompoundShape(JPH_CompoundShape *object);

/// Destroys a heap-allocated instance of `JPH_MutableCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_MutableCompoundShape_Destroy(const JPH_MutableCompoundShape *_this);

/// Destroys a heap-allocated array of `JPH_MutableCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_MutableCompoundShape_DestroyArray(const JPH_MutableCompoundShape *_this);

/// Generated from method `JPH::MutableCompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_MutableCompoundShape_size_t(unsigned long inCount);

/// Generated from method `JPH::MutableCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::MutableCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::MutableCompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MutableCompoundShape_size_t(unsigned long inCount);

/// Generated from method `JPH::MutableCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::MutableCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::MutableCompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_MutableCompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::MutableCompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MutableCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MutableCompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MutableCompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::MutableCompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: CompoundShape::GetIntersectingSubShapes
/// Generated from method `JPH::MutableCompoundShape::GetIntersectingSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
JOLT_API int JPH_MutableCompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_MutableCompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices);

// See Shape::GetStats
/// Generated from method `JPH::MutableCompoundShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_MutableCompoundShape_GetStats(const JPH_MutableCompoundShape *_this);

/// Remove a shape by index.
/// Beware this can create a race condition if you're running collision queries in parallel. See class documentation for more information.
/// Generated from method `JPH::MutableCompoundShape::RemoveShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_RemoveShape(JPH_MutableCompoundShape *_this, unsigned int inIndex);

/// Recalculate the center of mass and shift all objects so they're centered around it
/// (this needs to be done of dynamic bodies and if the center of mass changes significantly due to adding / removing / repositioning sub shapes or else the simulation will look unnatural)
/// Note that after adjusting the center of mass of an object you need to call BodyInterface::NotifyShapeChanged and Constraint::NotifyShapeChanged on the relevant bodies / constraints.
/// Beware this can create a race condition if you're running collision queries in parallel. See class documentation for more information.
/// Generated from method `JPH::MutableCompoundShape::AdjustCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_AdjustCenterOfMass(JPH_MutableCompoundShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::MutableCompoundShape::sRegister`.
JOLT_API void JPH_MutableCompoundShape_sRegister(void);

// See Shape::MustBeStatic
/// Generated from method `JPH::MutableCompoundShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MutableCompoundShape_MustBeStatic(const JPH_MutableCompoundShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::MutableCompoundShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_MutableCompoundShape_GetLocalBounds(const JPH_MutableCompoundShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::MutableCompoundShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShape_GetSubShapeIDBitsRecursive(const JPH_MutableCompoundShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::MutableCompoundShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MutableCompoundShape_GetInnerRadius(const JPH_MutableCompoundShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::MutableCompoundShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_MutableCompoundShape_GetMaterial(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetLeafShape
/// Generated from method `JPH::MutableCompoundShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_MutableCompoundShape_GetLeafShape(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::MutableCompoundShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_MutableCompoundShape_GetSubShapeUserData(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the total number of sub shapes
/// Generated from method `JPH::MutableCompoundShape::GetNumSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShape_GetNumSubShapes(const JPH_MutableCompoundShape *_this);

/// Access to a particular sub shape
/// Generated from method `JPH::MutableCompoundShape::GetSubShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CompoundShape_SubShape *JPH_MutableCompoundShape_GetSubShape(const JPH_MutableCompoundShape *_this, unsigned int inIdx);

/// Get the user data associated with a shape in this compound
/// Generated from method `JPH::MutableCompoundShape::GetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShape_GetCompoundUserData(const JPH_MutableCompoundShape *_this, unsigned int inIdx);

/// Set the user data associated with a shape in this compound
/// Generated from method `JPH::MutableCompoundShape::SetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_SetCompoundUserData(JPH_MutableCompoundShape *_this, unsigned int inIdx, unsigned int inUserData);

/// Check if a sub shape ID is still valid for this shape
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @return True if the ID is valid, false if not
/// Generated from method `JPH::MutableCompoundShape::IsSubShapeIDValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API bool JPH_MutableCompoundShape_IsSubShapeIDValid(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Convert SubShapeID to sub shape index
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
/// @return The index of the sub shape of this compound
/// Generated from method `JPH::MutableCompoundShape::GetSubShapeIndexFromID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShape_GetSubShapeIndexFromID(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetVolume
/// Generated from method `JPH::MutableCompoundShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MutableCompoundShape_GetVolume(const JPH_MutableCompoundShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::MutableCompoundShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_MutableCompoundShape_GetUserData(const JPH_MutableCompoundShape *_this);

/// Generated from method `JPH::MutableCompoundShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_SetUserData(JPH_MutableCompoundShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::MutableCompoundShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_SetEmbedded(const JPH_MutableCompoundShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::MutableCompoundShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MutableCompoundShape_GetRefCount(const JPH_MutableCompoundShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::MutableCompoundShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_AddRef(const JPH_MutableCompoundShape *_this);

/// Generated from method `JPH::MutableCompoundShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MutableCompoundShape_Release(const JPH_MutableCompoundShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::MutableCompoundShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_MutableCompoundShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
