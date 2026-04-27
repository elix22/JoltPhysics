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


/// Class that constructs a CapsuleShape
/// Generated from class `JPH::CapsuleShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CapsuleShapeSettings JPH_CapsuleShapeSettings;

/// A capsule, implemented as a line segment with convex radius
/// Generated from class `JPH::CapsuleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CapsuleShape JPH_CapsuleShape;

/// Returns a pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CapsuleShapeSettings_Get_mRadius(const JPH_CapsuleShapeSettings *_this);

/// Modifies a member variable of class `JPH::CapsuleShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRadius`.
JOLT_API void JPH_CapsuleShapeSettings_Set_mRadius(JPH_CapsuleShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CapsuleShapeSettings_GetMutable_mRadius(JPH_CapsuleShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mHalfHeightOfCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder(const JPH_CapsuleShapeSettings *_this);

/// Modifies a member variable of class `JPH::CapsuleShapeSettings` named `mHalfHeightOfCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfHeightOfCylinder`.
JOLT_API void JPH_CapsuleShapeSettings_Set_mHalfHeightOfCylinder(JPH_CapsuleShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mHalfHeightOfCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder(JPH_CapsuleShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CapsuleShapeSettings_Get_mDensity(const JPH_CapsuleShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::CapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_CapsuleShapeSettings_Set_mDensity(JPH_CapsuleShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CapsuleShapeSettings_GetMutable_mDensity(JPH_CapsuleShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_CapsuleShapeSettings_Get_mUserData(const JPH_CapsuleShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::CapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_CapsuleShapeSettings_Set_mUserData(JPH_CapsuleShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::CapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_CapsuleShapeSettings_GetMutable_mUserData(JPH_CapsuleShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CapsuleShapeSettings_DestroyArray()`.
/// Use `JPH_CapsuleShapeSettings_OffsetMutablePtr()` and `JPH_CapsuleShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_OffsetPtr(const JPH_CapsuleShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_OffsetMutablePtr(JPH_CapsuleShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_CapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_CapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_CapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_CapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_CapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_CapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_CapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::CapsuleShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_CapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::CapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CapsuleShapeSettings *_other);

/// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
/// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_Construct(float inHalfHeightOfCylinder, float inRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_CapsuleShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CapsuleShapeSettings_Destroy(const JPH_CapsuleShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_CapsuleShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CapsuleShapeSettings_DestroyArray(const JPH_CapsuleShapeSettings *_this);

/// Generated from method `JPH::CapsuleShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_AssignFromAnother(JPH_CapsuleShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_CapsuleShapeSettings *_other);

/// Generated from method `JPH::CapsuleShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CapsuleShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CapsuleShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CapsuleShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CapsuleShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CapsuleShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CapsuleShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CapsuleShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if this is a valid capsule shape
/// Generated from method `JPH::CapsuleShapeSettings::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CapsuleShapeSettings_IsValid(const JPH_CapsuleShapeSettings *_this);

/// Checks if the settings of this capsule make this shape a sphere
/// Generated from method `JPH::CapsuleShapeSettings::IsSphere`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CapsuleShapeSettings_IsSphere(const JPH_CapsuleShapeSettings *_this);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::CapsuleShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShapeSettings_SetDensity(JPH_CapsuleShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::CapsuleShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShapeSettings_ClearCachedResult(JPH_CapsuleShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CapsuleShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShapeSettings_SetEmbedded(const JPH_CapsuleShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CapsuleShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CapsuleShapeSettings_GetRefCount(const JPH_CapsuleShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CapsuleShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShapeSettings_AddRef(const JPH_CapsuleShapeSettings *_this);

/// Generated from method `JPH::CapsuleShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShapeSettings_Release(const JPH_CapsuleShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CapsuleShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_CapsuleShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::CapsuleShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CapsuleShape_DestroyArray()`.
/// Use `JPH_CapsuleShape_OffsetMutablePtr()` and `JPH_CapsuleShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CapsuleShape *JPH_CapsuleShape_OffsetPtr(const JPH_CapsuleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_OffsetMutablePtr(JPH_CapsuleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_CapsuleShape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_CapsuleShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_CapsuleShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(const JPH_CapsuleShape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CapsuleShape_MutableUpcastTo_JPH_NonCopyable(JPH_CapsuleShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_CapsuleShape_UpcastTo_JPH_Shape(const JPH_CapsuleShape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_CapsuleShape_MutableUpcastTo_JPH_Shape(JPH_CapsuleShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(const JPH_CapsuleShape *object);

/// Upcasts an instance of `JPH::CapsuleShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_CapsuleShape_MutableUpcastTo_JPH_ConvexShape(JPH_CapsuleShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::CapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
/// Generated from constructor `JPH::CapsuleShape::CapsuleShape`.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_CapsuleShape *JPH_CapsuleShape_Construct_3(float inHalfHeightOfCylinder, float inRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_CapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CapsuleShape_Destroy(const JPH_CapsuleShape *_this);

/// Destroys a heap-allocated array of `JPH_CapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CapsuleShape_DestroyArray(const JPH_CapsuleShape *_this);

/// Generated from method `JPH::CapsuleShape::operator new`.
JOLT_API void *Jolt_new_JPH_CapsuleShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::CapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShape_void_ptr(void *inPointer);

/// Generated from method `JPH::CapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CapsuleShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CapsuleShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::CapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShape_void_ptr(void *inPointer);

/// Generated from method `JPH::CapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CapsuleShape::operator new`.
JOLT_API void *Jolt_new_JPH_CapsuleShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CapsuleShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CapsuleShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Radius of the cylinder
/// Generated from method `JPH::CapsuleShape::GetRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CapsuleShape_GetRadius(const JPH_CapsuleShape *_this);

/// Get half of the height of the cylinder
/// Generated from method `JPH::CapsuleShape::GetHalfHeightOfCylinder`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CapsuleShape_GetHalfHeightOfCylinder(const JPH_CapsuleShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::CapsuleShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_CapsuleShape_GetLocalBounds(const JPH_CapsuleShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::CapsuleShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CapsuleShape_GetInnerRadius(const JPH_CapsuleShape *_this);

// See Shape::GetStats
/// Generated from method `JPH::CapsuleShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_CapsuleShape_GetStats(const JPH_CapsuleShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::CapsuleShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CapsuleShape_GetVolume(const JPH_CapsuleShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::CapsuleShape::sRegister`.
JOLT_API void JPH_CapsuleShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::CapsuleShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CapsuleShape_GetSubShapeIDBitsRecursive(const JPH_CapsuleShape *_this);

/// Material of the shape
/// Generated from method `JPH::CapsuleShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_SetMaterial(JPH_CapsuleShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::CapsuleShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_SetDensity(JPH_CapsuleShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::CapsuleShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CapsuleShape_GetDensity(const JPH_CapsuleShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::CapsuleShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CapsuleShape_GetUserData(const JPH_CapsuleShape *_this);

/// Generated from method `JPH::CapsuleShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_SetUserData(JPH_CapsuleShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::CapsuleShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CapsuleShape_MustBeStatic(const JPH_CapsuleShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::CapsuleShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_CapsuleShape_GetLeafShape(const JPH_CapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::CapsuleShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_CapsuleShape_GetSubShapeUserData(const JPH_CapsuleShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CapsuleShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_SetEmbedded(const JPH_CapsuleShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CapsuleShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CapsuleShape_GetRefCount(const JPH_CapsuleShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CapsuleShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_AddRef(const JPH_CapsuleShape *_this);

/// Generated from method `JPH::CapsuleShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CapsuleShape_Release(const JPH_CapsuleShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CapsuleShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_CapsuleShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
