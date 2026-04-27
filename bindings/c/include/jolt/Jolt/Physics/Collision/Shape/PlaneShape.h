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


/// Class that constructs a PlaneShape
/// Generated from class `JPH::PlaneShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PlaneShapeSettings JPH_PlaneShapeSettings;

/// A plane shape. The negative half space is considered solid. Planes cannot be dynamic objects, only static or kinematic.
/// The plane is considered an infinite shape, but testing collision outside of its bounding box (defined by the half-extent parameter) will not return a collision result.
/// At the edge of the bounding box collision with the plane will be inconsistent. If you need something of a well defined size, a box shape may be better.
/// Generated from class `JPH::PlaneShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PlaneShape JPH_PlaneShape;

///< Default half-extent of the plane (total size along 1 axis will be 2 * half-extent)
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `cDefaultHalfExtent`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const float *JPH_PlaneShapeSettings_Get_cDefaultHalfExtent(void);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PlaneShapeSettings_Get_mHalfExtent(const JPH_PlaneShapeSettings *_this);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Modifies a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfExtent`.
JOLT_API void JPH_PlaneShapeSettings_Set_mHalfExtent(JPH_PlaneShapeSettings *_this, float value);

///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PlaneShapeSettings_GetMutable_mHalfExtent(JPH_PlaneShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_PlaneShapeSettings_Get_mUserData(const JPH_PlaneShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_PlaneShapeSettings_Set_mUserData(JPH_PlaneShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::PlaneShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_PlaneShapeSettings_GetMutable_mUserData(JPH_PlaneShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PlaneShapeSettings_DestroyArray()`.
/// Use `JPH_PlaneShapeSettings_OffsetMutablePtr()` and `JPH_PlaneShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetPtr(const JPH_PlaneShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetMutablePtr(JPH_PlaneShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object);

/// Upcasts an instance of `JPH::PlaneShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_PlaneShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::PlaneShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_PlaneShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShapeSettings_Destroy(const JPH_PlaneShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_PlaneShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShapeSettings_DestroyArray(const JPH_PlaneShapeSettings *_this);

/// Generated from method `JPH::PlaneShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_AssignFromAnother(JPH_PlaneShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other);

/// Generated from method `JPH::PlaneShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PlaneShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::PlaneShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_ClearCachedResult(JPH_PlaneShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PlaneShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_SetEmbedded(const JPH_PlaneShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PlaneShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShapeSettings_GetRefCount(const JPH_PlaneShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PlaneShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_AddRef(const JPH_PlaneShapeSettings *_this);

/// Generated from method `JPH::PlaneShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShapeSettings_Release(const JPH_PlaneShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PlaneShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_PlaneShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::PlaneShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PlaneShape_DestroyArray()`.
/// Use `JPH_PlaneShape_OffsetMutablePtr()` and `JPH_PlaneShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_OffsetPtr(const JPH_PlaneShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_OffsetMutablePtr(JPH_PlaneShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_PlaneShape_UpcastTo_JPH_NonCopyable(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_PlaneShape_MutableUpcastTo_JPH_NonCopyable(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_Shape(const JPH_PlaneShape *object);

/// Upcasts an instance of `JPH::PlaneShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_Shape(JPH_PlaneShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::PlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Destroys a heap-allocated instance of `JPH_PlaneShape`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShape_Destroy(const JPH_PlaneShape *_this);

/// Destroys a heap-allocated array of `JPH_PlaneShape`. Does nothing if the pointer is null.
JOLT_API void JPH_PlaneShape_DestroyArray(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PlaneShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr(void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PlaneShape::operator new`.
JOLT_API void *Jolt_new_JPH_PlaneShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete`.
JOLT_API void Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PlaneShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PlaneShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PlaneShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the half-extent of the bounding box of the plane
/// Generated from method `JPH::PlaneShape::GetHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetHalfExtent(const JPH_PlaneShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::PlaneShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_PlaneShape_MustBeStatic(const JPH_PlaneShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::PlaneShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_PlaneShape_GetLocalBounds(const JPH_PlaneShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::PlaneShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShape_GetSubShapeIDBitsRecursive(const JPH_PlaneShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::PlaneShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetInnerRadius(const JPH_PlaneShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::PlaneShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_1(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetStats
/// Generated from method `JPH::PlaneShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_PlaneShape_GetStats(const JPH_PlaneShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::PlaneShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_PlaneShape_GetVolume(const JPH_PlaneShape *_this);

/// Material of the shape
/// Generated from method `JPH::PlaneShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetMaterial(JPH_PlaneShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Generated from method `JPH::PlaneShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_0(const JPH_PlaneShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::PlaneShape::sRegister`.
JOLT_API void JPH_PlaneShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::PlaneShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_PlaneShape_GetUserData(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetUserData(JPH_PlaneShape *_this, uint64_t inUserData);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::PlaneShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_PlaneShape_GetLeafShape(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::PlaneShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_PlaneShape_GetSubShapeUserData(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::PlaneShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_SetEmbedded(const JPH_PlaneShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::PlaneShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PlaneShape_GetRefCount(const JPH_PlaneShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::PlaneShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_AddRef(const JPH_PlaneShape *_this);

/// Generated from method `JPH::PlaneShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PlaneShape_Release(const JPH_PlaneShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::PlaneShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_PlaneShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
