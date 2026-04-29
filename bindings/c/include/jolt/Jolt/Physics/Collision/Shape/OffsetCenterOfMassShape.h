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
typedef struct JPH_DMat44 JPH_DMat44; // Defined in `#include <jolt/Jolt/Math/DMat44.h>`.
typedef struct JPH_DecoratedShape JPH_DecoratedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
typedef struct JPH_DecoratedShapeSettings JPH_DecoratedShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_Stats JPH_Shape_Stats; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that constructs an OffsetCenterOfMassShape
/// Generated from class `JPH::OffsetCenterOfMassShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_OffsetCenterOfMassShapeSettings JPH_OffsetCenterOfMassShapeSettings;

/// This shape will shift the center of mass of a child shape, it can e.g. be used to lower the center of mass of an unstable object like a boat to make it stable
/// Generated from class `JPH::OffsetCenterOfMassShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_OffsetCenterOfMassShape JPH_OffsetCenterOfMassShape;

///< Offset to be applied to the center of mass of the child shape
/// Returns a pointer to a member variable of class `JPH::OffsetCenterOfMassShapeSettings` named `mOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_OffsetCenterOfMassShapeSettings_Get_mOffset(const JPH_OffsetCenterOfMassShapeSettings *_this);

///< Offset to be applied to the center of mass of the child shape
/// Returns a mutable pointer to a member variable of class `JPH::OffsetCenterOfMassShapeSettings` named `mOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset(JPH_OffsetCenterOfMassShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::OffsetCenterOfMassShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_OffsetCenterOfMassShapeSettings_Get_mUserData(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::OffsetCenterOfMassShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_Set_mUserData(JPH_OffsetCenterOfMassShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::OffsetCenterOfMassShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData(JPH_OffsetCenterOfMassShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_OffsetCenterOfMassShapeSettings_DestroyArray()`.
/// Use `JPH_OffsetCenterOfMassShapeSettings_OffsetMutablePtr()` and `JPH_OffsetCenterOfMassShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_OffsetPtr(const JPH_OffsetCenterOfMassShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_OffsetMutablePtr(JPH_OffsetCenterOfMassShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_OffsetCenterOfMassShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_OffsetCenterOfMassShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::OffsetCenterOfMassShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object);

/// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_OffsetCenterOfMassShapeSettings *_other);

/// Construct with shape settings, can be serialized.
/// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
/// Parameter `inOffset` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_Vec3 *inOffset, const JPH_ShapeSettings *inShape);

/// Variant that uses a concrete shape, which means this object cannot be serialized.
/// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
/// Parameter `inOffset` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Vec3 *inOffset, const JPH_Shape *inShape);

/// Destroys a heap-allocated instance of `JPH_OffsetCenterOfMassShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_Destroy(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_OffsetCenterOfMassShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_DestroyArray(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother(JPH_OffsetCenterOfMassShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_OffsetCenterOfMassShapeSettings *_other);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult(JPH_OffsetCenterOfMassShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_SetEmbedded(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_OffsetCenterOfMassShapeSettings_GetRefCount(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_AddRef(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShapeSettings_Release(const JPH_OffsetCenterOfMassShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::OffsetCenterOfMassShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::OffsetCenterOfMassShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_OffsetCenterOfMassShape_DestroyArray()`.
/// Use `JPH_OffsetCenterOfMassShape_OffsetMutablePtr()` and `JPH_OffsetCenterOfMassShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_OffsetPtr(const JPH_OffsetCenterOfMassShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_OffsetMutablePtr(JPH_OffsetCenterOfMassShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_OffsetCenterOfMassShape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_OffsetCenterOfMassShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(const JPH_OffsetCenterOfMassShape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_NonCopyable(JPH_OffsetCenterOfMassShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(const JPH_OffsetCenterOfMassShape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_Shape(JPH_OffsetCenterOfMassShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::DecoratedShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(const JPH_OffsetCenterOfMassShape *object);

/// Upcasts an instance of `JPH::OffsetCenterOfMassShape` to its base class `JPH::DecoratedShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_DecoratedShape(JPH_OffsetCenterOfMassShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::OffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object);

/// Generated from constructor `JPH::OffsetCenterOfMassShape::OffsetCenterOfMassShape`.
/// Parameter `inOffset` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_OffsetCenterOfMassShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inOffset);

/// Destroys a heap-allocated instance of `JPH_OffsetCenterOfMassShape`. Does nothing if the pointer is null.
JOLT_API void JPH_OffsetCenterOfMassShape_Destroy(const JPH_OffsetCenterOfMassShape *_this);

/// Destroys a heap-allocated array of `JPH_OffsetCenterOfMassShape`. Does nothing if the pointer is null.
JOLT_API void JPH_OffsetCenterOfMassShape_DestroyArray(const JPH_OffsetCenterOfMassShape *_this);

/// Get world space bounds including convex radius.
/// Generated from method `JPH::OffsetCenterOfMassShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_OffsetCenterOfMassShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator new`.
JOLT_API void *Jolt_new_JPH_OffsetCenterOfMassShape_size_t(size_t inCount);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t(size_t inCount);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator new`.
JOLT_API void *Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
JOLT_API void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access the offset that is applied to the center of mass
/// Generated from method `JPH::OffsetCenterOfMassShape::GetOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetOffset(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::OffsetCenterOfMassShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetCenterOfMass(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::OffsetCenterOfMassShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_OffsetCenterOfMassShape_GetLocalBounds(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetWorldSpaceBounds
/// Generated from method `JPH::OffsetCenterOfMassShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_OffsetCenterOfMassShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

// See Shape::GetInnerRadius
/// Generated from method `JPH::OffsetCenterOfMassShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_OffsetCenterOfMassShape_GetInnerRadius(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::OffsetCenterOfMassShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetSurfaceNormal(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::OffsetCenterOfMassShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_GetSubmergedVolume(const JPH_OffsetCenterOfMassShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::OffsetCenterOfMassShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_GetTrianglesStart(const JPH_OffsetCenterOfMassShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::OffsetCenterOfMassShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_OffsetCenterOfMassShape_GetTrianglesNext(const JPH_OffsetCenterOfMassShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::OffsetCenterOfMassShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_OffsetCenterOfMassShape_GetStats(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::OffsetCenterOfMassShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_OffsetCenterOfMassShape_GetVolume(const JPH_OffsetCenterOfMassShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::OffsetCenterOfMassShape::sRegister`.
JOLT_API void JPH_OffsetCenterOfMassShape_sRegister(void);

/// Access to the decorated inner shape
/// Generated from method `JPH::OffsetCenterOfMassShape::GetInnerShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_OffsetCenterOfMassShape_GetInnerShape(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::OffsetCenterOfMassShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_OffsetCenterOfMassShape_MustBeStatic(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::OffsetCenterOfMassShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive(const JPH_OffsetCenterOfMassShape *_this);

// See Shape::GetLeafShape
/// Generated from method `JPH::OffsetCenterOfMassShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_OffsetCenterOfMassShape_GetLeafShape(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetMaterial
/// Generated from method `JPH::OffsetCenterOfMassShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_OffsetCenterOfMassShape_GetMaterial(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::OffsetCenterOfMassShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_OffsetCenterOfMassShape_GetSubShapeUserData(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::IsValidScale
/// Generated from method `JPH::OffsetCenterOfMassShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_OffsetCenterOfMassShape_IsValidScale(const JPH_OffsetCenterOfMassShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::OffsetCenterOfMassShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_OffsetCenterOfMassShape_MakeScaleValid(const JPH_OffsetCenterOfMassShape *_this, const JPH_Vec3 *inScale);

/// User data (to be used freely by the application)
/// Generated from method `JPH::OffsetCenterOfMassShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_OffsetCenterOfMassShape_GetUserData(const JPH_OffsetCenterOfMassShape *_this);

/// Generated from method `JPH::OffsetCenterOfMassShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_SetUserData(JPH_OffsetCenterOfMassShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::OffsetCenterOfMassShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_SetEmbedded(const JPH_OffsetCenterOfMassShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::OffsetCenterOfMassShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_OffsetCenterOfMassShape_GetRefCount(const JPH_OffsetCenterOfMassShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::OffsetCenterOfMassShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_AddRef(const JPH_OffsetCenterOfMassShape *_this);

/// Generated from method `JPH::OffsetCenterOfMassShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_OffsetCenterOfMassShape_Release(const JPH_OffsetCenterOfMassShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::OffsetCenterOfMassShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
