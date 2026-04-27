// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_ConvexShape JPH_ConvexShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShapeSettings JPH_ConvexShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShape_SupportBuffer JPH_ConvexShape_SupportBuffer; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
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


/// Class that constructs a SphereShape
/// Generated from class `JPH::SphereShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SphereShapeSettings JPH_SphereShapeSettings;

/// A sphere, centered around the origin.
/// Note that it is implemented as a point with convex radius.
/// Generated from class `JPH::SphereShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SphereShape JPH_SphereShape;

/// Returns a pointer to a member variable of class `JPH::SphereShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SphereShapeSettings_Get_mRadius(const JPH_SphereShapeSettings *_this);

/// Modifies a member variable of class `JPH::SphereShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRadius`.
JOLT_API void JPH_SphereShapeSettings_Set_mRadius(JPH_SphereShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::SphereShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SphereShapeSettings_GetMutable_mRadius(JPH_SphereShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::SphereShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SphereShapeSettings_Get_mDensity(const JPH_SphereShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::SphereShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_SphereShapeSettings_Set_mDensity(JPH_SphereShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::SphereShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SphereShapeSettings_GetMutable_mDensity(JPH_SphereShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::SphereShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_SphereShapeSettings_Get_mUserData(const JPH_SphereShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::SphereShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_SphereShapeSettings_Set_mUserData(JPH_SphereShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::SphereShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_SphereShapeSettings_GetMutable_mUserData(JPH_SphereShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SphereShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SphereShapeSettings_DestroyArray()`.
/// Use `JPH_SphereShapeSettings_OffsetMutablePtr()` and `JPH_SphereShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SphereShapeSettings *JPH_SphereShapeSettings_OffsetPtr(const JPH_SphereShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_OffsetMutablePtr(JPH_SphereShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_SphereShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_SphereShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_SphereShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SphereShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_SphereShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_SphereShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_SphereShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_SphereShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_SphereShapeSettings *object);

/// Upcasts an instance of `JPH::SphereShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_SphereShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::SphereShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::SphereShapeSettings::SphereShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SphereShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SphereShapeSettings *_other);

/// Create a sphere with radius inRadius
/// Generated from constructor `JPH::SphereShapeSettings::SphereShapeSettings`.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SphereShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_Construct(float inRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_SphereShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SphereShapeSettings_Destroy(const JPH_SphereShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_SphereShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SphereShapeSettings_DestroyArray(const JPH_SphereShapeSettings *_this);

/// Generated from method `JPH::SphereShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SphereShapeSettings *JPH_SphereShapeSettings_AssignFromAnother(JPH_SphereShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_SphereShapeSettings *_other);

/// Generated from method `JPH::SphereShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SphereShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SphereShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SphereShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SphereShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SphereShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SphereShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SphereShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SphereShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SphereShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SphereShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SphereShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SphereShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SphereShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::SphereShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShapeSettings_SetDensity(JPH_SphereShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::SphereShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShapeSettings_ClearCachedResult(JPH_SphereShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SphereShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShapeSettings_SetEmbedded(const JPH_SphereShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SphereShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SphereShapeSettings_GetRefCount(const JPH_SphereShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SphereShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShapeSettings_AddRef(const JPH_SphereShapeSettings *_this);

/// Generated from method `JPH::SphereShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShapeSettings_Release(const JPH_SphereShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SphereShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_SphereShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::SphereShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_SphereShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SphereShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_SphereShape *JPH_SphereShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SphereShape_DestroyArray()`.
/// Use `JPH_SphereShape_OffsetMutablePtr()` and `JPH_SphereShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_SphereShape *JPH_SphereShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SphereShape *JPH_SphereShape_OffsetPtr(const JPH_SphereShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SphereShape *JPH_SphereShape_OffsetMutablePtr(JPH_SphereShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_SphereShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_SphereShape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_SphereShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_SphereShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_SphereShape_UpcastTo_JPH_NonCopyable(const JPH_SphereShape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_SphereShape_MutableUpcastTo_JPH_NonCopyable(JPH_SphereShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_SphereShape_UpcastTo_JPH_Shape(const JPH_SphereShape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_SphereShape_MutableUpcastTo_JPH_Shape(JPH_SphereShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_SphereShape_UpcastTo_JPH_ConvexShape(const JPH_SphereShape *object);

/// Upcasts an instance of `JPH::SphereShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_SphereShape_MutableUpcastTo_JPH_ConvexShape(JPH_SphereShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::SphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Create a sphere with radius inRadius
/// Generated from constructor `JPH::SphereShape::SphereShape`.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SphereShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_SphereShape *JPH_SphereShape_Construct_float(float inRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_SphereShape`. Does nothing if the pointer is null.
JOLT_API void JPH_SphereShape_Destroy(const JPH_SphereShape *_this);

/// Destroys a heap-allocated array of `JPH_SphereShape`. Does nothing if the pointer is null.
JOLT_API void JPH_SphereShape_DestroyArray(const JPH_SphereShape *_this);

/// Generated from method `JPH::SphereShape::operator new`.
JOLT_API void *Jolt_new_JPH_SphereShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SphereShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShape_void_ptr(void *inPointer);

/// Generated from method `JPH::SphereShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SphereShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SphereShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SphereShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShape_void_ptr(void *inPointer);

/// Generated from method `JPH::SphereShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SphereShape::operator new`.
JOLT_API void *Jolt_new_JPH_SphereShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SphereShape::operator delete`.
JOLT_API void Jolt_delete_JPH_SphereShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SphereShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SphereShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SphereShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SphereShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Radius of the sphere
/// Generated from method `JPH::SphereShape::GetRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SphereShape_GetRadius(const JPH_SphereShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::SphereShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_SphereShape_GetLocalBounds(const JPH_SphereShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::SphereShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SphereShape_GetInnerRadius(const JPH_SphereShape *_this);

// See Shape::GetStats
/// Generated from method `JPH::SphereShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_SphereShape_GetStats(const JPH_SphereShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::SphereShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SphereShape_GetVolume(const JPH_SphereShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::SphereShape::sRegister`.
JOLT_API void JPH_SphereShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::SphereShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SphereShape_GetSubShapeIDBitsRecursive(const JPH_SphereShape *_this);

/// Material of the shape
/// Generated from method `JPH::SphereShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_SetMaterial(JPH_SphereShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::SphereShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_SetDensity(JPH_SphereShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::SphereShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SphereShape_GetDensity(const JPH_SphereShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::SphereShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SphereShape_GetUserData(const JPH_SphereShape *_this);

/// Generated from method `JPH::SphereShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_SetUserData(JPH_SphereShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::SphereShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SphereShape_MustBeStatic(const JPH_SphereShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::SphereShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_SphereShape_GetLeafShape(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::SphereShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_SphereShape_GetSubShapeUserData(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SphereShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_SetEmbedded(const JPH_SphereShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SphereShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SphereShape_GetRefCount(const JPH_SphereShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SphereShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_AddRef(const JPH_SphereShape *_this);

/// Generated from method `JPH::SphereShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SphereShape_Release(const JPH_SphereShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SphereShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_SphereShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
