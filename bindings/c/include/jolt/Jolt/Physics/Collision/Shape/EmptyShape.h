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
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
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


/// Class that constructs an EmptyShape
/// Generated from class `JPH::EmptyShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_EmptyShapeSettings JPH_EmptyShapeSettings;

/// An empty shape that has no volume and collides with nothing.
///
/// Possible use cases:
/// - As a placeholder for a shape that will be created later. E.g. if you first need to create a body and only then know what shape it will have.
/// - If you need a kinematic body to attach a constraint to, but you don't want the body to collide with anything.
///
/// Note that, if possible, you should also put your body in an ObjectLayer that doesn't collide with anything.
/// This ensures that collisions will be filtered out at broad phase level instead of at narrow phase level, this is more efficient.
/// Generated from class `JPH::EmptyShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_EmptyShape JPH_EmptyShape;

///< Determines the center of mass for this shape
/// Returns a pointer to a member variable of class `JPH::EmptyShapeSettings` named `mCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_EmptyShapeSettings_Get_mCenterOfMass(const JPH_EmptyShapeSettings *_this);

///< Determines the center of mass for this shape
/// Returns a mutable pointer to a member variable of class `JPH::EmptyShapeSettings` named `mCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_EmptyShapeSettings_GetMutable_mCenterOfMass(JPH_EmptyShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::EmptyShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_EmptyShapeSettings_Get_mUserData(const JPH_EmptyShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::EmptyShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_EmptyShapeSettings_Set_mUserData(JPH_EmptyShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::EmptyShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_EmptyShapeSettings_GetMutable_mUserData(JPH_EmptyShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_EmptyShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_EmptyShapeSettings_DestroyArray()`.
/// Use `JPH_EmptyShapeSettings_OffsetMutablePtr()` and `JPH_EmptyShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_OffsetPtr(const JPH_EmptyShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_OffsetMutablePtr(JPH_EmptyShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_EmptyShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_EmptyShapeSettings *object);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_EmptyShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_EmptyShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_EmptyShapeSettings *object);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_EmptyShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_EmptyShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_EmptyShapeSettings *object);

/// Upcasts an instance of `JPH::EmptyShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_EmptyShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::EmptyShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Generated from constructor `JPH::EmptyShapeSettings::EmptyShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_EmptyShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_EmptyShapeSettings *_other);

/// Generated from constructor `JPH::EmptyShapeSettings::EmptyShapeSettings`.
/// Parameter `inCenterOfMass` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_EmptyShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_Construct(const JPH_Vec3 *inCenterOfMass);

/// Destroys a heap-allocated instance of `JPH_EmptyShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_EmptyShapeSettings_Destroy(const JPH_EmptyShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_EmptyShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_EmptyShapeSettings_DestroyArray(const JPH_EmptyShapeSettings *_this);

/// Generated from method `JPH::EmptyShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_AssignFromAnother(JPH_EmptyShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_EmptyShapeSettings *_other);

/// Generated from method `JPH::EmptyShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_EmptyShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::EmptyShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_EmptyShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::EmptyShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_EmptyShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::EmptyShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_EmptyShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::EmptyShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::EmptyShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::EmptyShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_EmptyShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::EmptyShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_EmptyShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::EmptyShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_EmptyShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::EmptyShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::EmptyShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShapeSettings_ClearCachedResult(JPH_EmptyShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::EmptyShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShapeSettings_SetEmbedded(const JPH_EmptyShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::EmptyShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_EmptyShapeSettings_GetRefCount(const JPH_EmptyShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::EmptyShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShapeSettings_AddRef(const JPH_EmptyShapeSettings *_this);

/// Generated from method `JPH::EmptyShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShapeSettings_Release(const JPH_EmptyShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::EmptyShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_EmptyShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::EmptyShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_EmptyShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_EmptyShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_EmptyShape_DestroyArray()`.
/// Use `JPH_EmptyShape_OffsetMutablePtr()` and `JPH_EmptyShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_EmptyShape *JPH_EmptyShape_OffsetPtr(const JPH_EmptyShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_OffsetMutablePtr(JPH_EmptyShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_EmptyShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_EmptyShape *object);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_EmptyShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_EmptyShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_EmptyShape_UpcastTo_JPH_NonCopyable(const JPH_EmptyShape *object);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_EmptyShape_MutableUpcastTo_JPH_NonCopyable(JPH_EmptyShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_EmptyShape_UpcastTo_JPH_Shape(const JPH_EmptyShape *object);

/// Upcasts an instance of `JPH::EmptyShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_EmptyShape_MutableUpcastTo_JPH_Shape(JPH_EmptyShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::EmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Generated from constructor `JPH::EmptyShape::EmptyShape`.
/// Parameter `inCenterOfMass` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_EmptyShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_EmptyShape *JPH_EmptyShape_Construct_1(const JPH_Vec3 *inCenterOfMass);

/// Destroys a heap-allocated instance of `JPH_EmptyShape`. Does nothing if the pointer is null.
JOLT_API void JPH_EmptyShape_Destroy(const JPH_EmptyShape *_this);

/// Destroys a heap-allocated array of `JPH_EmptyShape`. Does nothing if the pointer is null.
JOLT_API void JPH_EmptyShape_DestroyArray(const JPH_EmptyShape *_this);

// See: Shape
/// Generated from method `JPH::EmptyShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_EmptyShape_GetCenterOfMass(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_EmptyShape_GetLocalBounds(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_EmptyShape_GetSubShapeIDBitsRecursive(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_EmptyShape_GetInnerRadius(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_EmptyShape_GetMaterial(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Generated from method `JPH::EmptyShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_EmptyShape_GetSurfaceNormal(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

/// Generated from method `JPH::EmptyShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_EmptyShape_GetTrianglesStart(const JPH_EmptyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

/// Generated from method `JPH::EmptyShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_EmptyShape_GetTrianglesNext(const JPH_EmptyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Generated from method `JPH::EmptyShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_EmptyShape_GetStats(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_EmptyShape_GetVolume(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_EmptyShape_IsValidScale(const JPH_EmptyShape *_this, const JPH_Vec3 *inScale);

// Register shape functions with the registry
/// Generated from method `JPH::EmptyShape::sRegister`.
JOLT_API void JPH_EmptyShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::EmptyShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_EmptyShape_GetUserData(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShape_SetUserData(JPH_EmptyShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::EmptyShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_EmptyShape_MustBeStatic(const JPH_EmptyShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::EmptyShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_EmptyShape_GetLeafShape(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::EmptyShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_EmptyShape_GetSubShapeUserData(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::EmptyShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_EmptyShape_MakeScaleValid(const JPH_EmptyShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::EmptyShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShape_SetEmbedded(const JPH_EmptyShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::EmptyShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_EmptyShape_GetRefCount(const JPH_EmptyShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::EmptyShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShape_AddRef(const JPH_EmptyShape *_this);

/// Generated from method `JPH::EmptyShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_EmptyShape_Release(const JPH_EmptyShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::EmptyShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_EmptyShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
