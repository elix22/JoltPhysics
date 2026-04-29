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


/// Class that constructs a RotatedTranslatedShape
/// Generated from class `JPH::RotatedTranslatedShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RotatedTranslatedShapeSettings JPH_RotatedTranslatedShapeSettings;

/// A rotated translated shape will rotate and translate a child shape.
/// Shifts the child object so that it is centered around the center of mass.
/// Generated from class `JPH::RotatedTranslatedShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RotatedTranslatedShape JPH_RotatedTranslatedShape;

///< Position of the sub shape
/// Returns a pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RotatedTranslatedShapeSettings_Get_mPosition(const JPH_RotatedTranslatedShapeSettings *_this);

///< Position of the sub shape
/// Returns a mutable pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShapeSettings_GetMutable_mPosition(JPH_RotatedTranslatedShapeSettings *_this);

///< Rotation of the sub shape
/// Returns a pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_RotatedTranslatedShapeSettings_Get_mRotation(const JPH_RotatedTranslatedShapeSettings *_this);

///< Rotation of the sub shape
/// Returns a mutable pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_RotatedTranslatedShapeSettings_GetMutable_mRotation(JPH_RotatedTranslatedShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_RotatedTranslatedShapeSettings_Get_mUserData(const JPH_RotatedTranslatedShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_RotatedTranslatedShapeSettings_Set_mUserData(JPH_RotatedTranslatedShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::RotatedTranslatedShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData(JPH_RotatedTranslatedShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RotatedTranslatedShapeSettings_DestroyArray()`.
/// Use `JPH_RotatedTranslatedShapeSettings_OffsetMutablePtr()` and `JPH_RotatedTranslatedShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_OffsetPtr(const JPH_RotatedTranslatedShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_OffsetMutablePtr(JPH_RotatedTranslatedShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_RotatedTranslatedShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_RotatedTranslatedShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_RotatedTranslatedShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_RotatedTranslatedShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_RotatedTranslatedShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_RotatedTranslatedShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_RotatedTranslatedShapeSettings *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_RotatedTranslatedShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::RotatedTranslatedShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object);

/// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RotatedTranslatedShapeSettings *_other);

/// Construct with shape settings, can be serialized.
/// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_ShapeSettings *inShape);

/// Variant that uses a concrete shape, which means this object cannot be serialized.
/// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape);

/// Destroys a heap-allocated instance of `JPH_RotatedTranslatedShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RotatedTranslatedShapeSettings_Destroy(const JPH_RotatedTranslatedShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_RotatedTranslatedShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RotatedTranslatedShapeSettings_DestroyArray(const JPH_RotatedTranslatedShapeSettings *_this);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_AssignFromAnother(JPH_RotatedTranslatedShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_RotatedTranslatedShapeSettings *_other);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RotatedTranslatedShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RotatedTranslatedShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RotatedTranslatedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RotatedTranslatedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::RotatedTranslatedShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShapeSettings_ClearCachedResult(JPH_RotatedTranslatedShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RotatedTranslatedShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShapeSettings_SetEmbedded(const JPH_RotatedTranslatedShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RotatedTranslatedShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RotatedTranslatedShapeSettings_GetRefCount(const JPH_RotatedTranslatedShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RotatedTranslatedShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShapeSettings_AddRef(const JPH_RotatedTranslatedShapeSettings *_this);

/// Generated from method `JPH::RotatedTranslatedShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShapeSettings_Release(const JPH_RotatedTranslatedShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RotatedTranslatedShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::RotatedTranslatedShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RotatedTranslatedShape_DestroyArray()`.
/// Use `JPH_RotatedTranslatedShape_OffsetMutablePtr()` and `JPH_RotatedTranslatedShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_OffsetPtr(const JPH_RotatedTranslatedShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_OffsetMutablePtr(JPH_RotatedTranslatedShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_RotatedTranslatedShape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_RotatedTranslatedShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(const JPH_RotatedTranslatedShape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_NonCopyable(JPH_RotatedTranslatedShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(const JPH_RotatedTranslatedShape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_Shape(JPH_RotatedTranslatedShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::DecoratedShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(const JPH_RotatedTranslatedShape *object);

/// Upcasts an instance of `JPH::RotatedTranslatedShape` to its base class `JPH::DecoratedShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_DecoratedShape(JPH_RotatedTranslatedShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::RotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object);

/// Generated from constructor `JPH::RotatedTranslatedShape::RotatedTranslatedShape`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RotatedTranslatedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_Construct_3(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape);

/// Destroys a heap-allocated instance of `JPH_RotatedTranslatedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_RotatedTranslatedShape_Destroy(const JPH_RotatedTranslatedShape *_this);

/// Destroys a heap-allocated array of `JPH_RotatedTranslatedShape`. Does nothing if the pointer is null.
JOLT_API void JPH_RotatedTranslatedShape_DestroyArray(const JPH_RotatedTranslatedShape *_this);

/// Get world space bounds including convex radius.
/// Generated from method `JPH::RotatedTranslatedShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_RotatedTranslatedShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_RotatedTranslatedShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Generated from method `JPH::RotatedTranslatedShape::operator new`.
JOLT_API void *Jolt_new_JPH_RotatedTranslatedShape_size_t(size_t inCount);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RotatedTranslatedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RotatedTranslatedShape_size_t(size_t inCount);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr(void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RotatedTranslatedShape::operator new`.
JOLT_API void *Jolt_new_JPH_RotatedTranslatedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
JOLT_API void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RotatedTranslatedShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RotatedTranslatedShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access the rotation that is applied to the inner shape
/// Generated from method `JPH::RotatedTranslatedShape::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_RotatedTranslatedShape_GetRotation(const JPH_RotatedTranslatedShape *_this);

/// Access the translation that has been applied to the inner shape
/// Generated from method `JPH::RotatedTranslatedShape::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShape_GetPosition(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::RotatedTranslatedShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShape_GetCenterOfMass(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::RotatedTranslatedShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_RotatedTranslatedShape_GetLocalBounds(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetWorldSpaceBounds
/// Generated from method `JPH::RotatedTranslatedShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_RotatedTranslatedShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_RotatedTranslatedShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

// See Shape::GetInnerRadius
/// Generated from method `JPH::RotatedTranslatedShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_RotatedTranslatedShape_GetInnerRadius(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::RotatedTranslatedShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShape_GetSurfaceNormal(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::RotatedTranslatedShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_GetSubmergedVolume(const JPH_RotatedTranslatedShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::RotatedTranslatedShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_GetTrianglesStart(const JPH_RotatedTranslatedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::RotatedTranslatedShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_RotatedTranslatedShape_GetTrianglesNext(const JPH_RotatedTranslatedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::RotatedTranslatedShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_RotatedTranslatedShape_GetStats(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::RotatedTranslatedShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_RotatedTranslatedShape_GetVolume(const JPH_RotatedTranslatedShape *_this);

// See Shape::IsValidScale
/// Generated from method `JPH::RotatedTranslatedShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_RotatedTranslatedShape_IsValidScale(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::RotatedTranslatedShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShape_MakeScaleValid(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale);

/// Transform the scale to the local space of the child shape
/// Generated from method `JPH::RotatedTranslatedShape::TransformScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RotatedTranslatedShape_TransformScale(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale);

// Register shape functions with the registry
/// Generated from method `JPH::RotatedTranslatedShape::sRegister`.
JOLT_API void JPH_RotatedTranslatedShape_sRegister(void);

/// Access to the decorated inner shape
/// Generated from method `JPH::RotatedTranslatedShape::GetInnerShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_RotatedTranslatedShape_GetInnerShape(const JPH_RotatedTranslatedShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::RotatedTranslatedShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_RotatedTranslatedShape_MustBeStatic(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::RotatedTranslatedShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive(const JPH_RotatedTranslatedShape *_this);

// See Shape::GetLeafShape
/// Generated from method `JPH::RotatedTranslatedShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_RotatedTranslatedShape_GetLeafShape(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetMaterial
/// Generated from method `JPH::RotatedTranslatedShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_RotatedTranslatedShape_GetMaterial(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::RotatedTranslatedShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_RotatedTranslatedShape_GetSubShapeUserData(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID);

/// User data (to be used freely by the application)
/// Generated from method `JPH::RotatedTranslatedShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_RotatedTranslatedShape_GetUserData(const JPH_RotatedTranslatedShape *_this);

/// Generated from method `JPH::RotatedTranslatedShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_SetUserData(JPH_RotatedTranslatedShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RotatedTranslatedShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_SetEmbedded(const JPH_RotatedTranslatedShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RotatedTranslatedShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RotatedTranslatedShape_GetRefCount(const JPH_RotatedTranslatedShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RotatedTranslatedShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_AddRef(const JPH_RotatedTranslatedShape *_this);

/// Generated from method `JPH::RotatedTranslatedShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RotatedTranslatedShape_Release(const JPH_RotatedTranslatedShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RotatedTranslatedShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_RotatedTranslatedShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
