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
typedef struct JPH_ConvexShape_Support JPH_ConvexShape_Support; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShape_SupportBuffer JPH_ConvexShape_SupportBuffer; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_DMat44 JPH_DMat44; // Defined in `#include <jolt/Jolt/Math/DMat44.h>`.
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


/// Class that constructs a TaperedCapsuleShape
/// Generated from class `JPH::TaperedCapsuleShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TaperedCapsuleShapeSettings JPH_TaperedCapsuleShapeSettings;

/// A capsule with different top and bottom radii
/// Generated from class `JPH::TaperedCapsuleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TaperedCapsuleShape JPH_TaperedCapsuleShape;

/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mHalfHeightOfTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder(const JPH_TaperedCapsuleShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mHalfHeightOfTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfHeightOfTaperedCylinder`.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Set_mHalfHeightOfTaperedCylinder(JPH_TaperedCapsuleShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mHalfHeightOfTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder(JPH_TaperedCapsuleShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCapsuleShapeSettings_Get_mTopRadius(const JPH_TaperedCapsuleShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTopRadius`.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Set_mTopRadius(JPH_TaperedCapsuleShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius(JPH_TaperedCapsuleShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius(const JPH_TaperedCapsuleShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBottomRadius`.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Set_mBottomRadius(JPH_TaperedCapsuleShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius(JPH_TaperedCapsuleShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCapsuleShapeSettings_Get_mDensity(const JPH_TaperedCapsuleShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Set_mDensity(JPH_TaperedCapsuleShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity(JPH_TaperedCapsuleShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_TaperedCapsuleShapeSettings_Get_mUserData(const JPH_TaperedCapsuleShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Set_mUserData(JPH_TaperedCapsuleShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::TaperedCapsuleShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData(JPH_TaperedCapsuleShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TaperedCapsuleShapeSettings_DestroyArray()`.
/// Use `JPH_TaperedCapsuleShapeSettings_OffsetMutablePtr()` and `JPH_TaperedCapsuleShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_OffsetPtr(const JPH_TaperedCapsuleShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_OffsetMutablePtr(JPH_TaperedCapsuleShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_TaperedCapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TaperedCapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_TaperedCapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_TaperedCapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_TaperedCapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_TaperedCapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_TaperedCapsuleShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_TaperedCapsuleShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::TaperedCapsuleShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TaperedCapsuleShapeSettings *_other);

/// Create a tapered capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and the other at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
/// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCapsuleShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_TaperedCapsuleShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Destroy(const JPH_TaperedCapsuleShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_TaperedCapsuleShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCapsuleShapeSettings_DestroyArray(const JPH_TaperedCapsuleShapeSettings *_this);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_AssignFromAnother(JPH_TaperedCapsuleShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_TaperedCapsuleShapeSettings *_other);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCapsuleShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCapsuleShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if the settings are valid
/// Generated from method `JPH::TaperedCapsuleShapeSettings::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCapsuleShapeSettings_IsValid(const JPH_TaperedCapsuleShapeSettings *_this);

/// Checks if the settings of this tapered capsule make this shape a sphere
/// Generated from method `JPH::TaperedCapsuleShapeSettings::IsSphere`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCapsuleShapeSettings_IsSphere(const JPH_TaperedCapsuleShapeSettings *_this);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::TaperedCapsuleShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShapeSettings_SetDensity(JPH_TaperedCapsuleShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::TaperedCapsuleShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShapeSettings_ClearCachedResult(JPH_TaperedCapsuleShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TaperedCapsuleShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShapeSettings_SetEmbedded(const JPH_TaperedCapsuleShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TaperedCapsuleShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCapsuleShapeSettings_GetRefCount(const JPH_TaperedCapsuleShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TaperedCapsuleShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShapeSettings_AddRef(const JPH_TaperedCapsuleShapeSettings *_this);

/// Generated from method `JPH::TaperedCapsuleShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShapeSettings_Release(const JPH_TaperedCapsuleShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TaperedCapsuleShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::TaperedCapsuleShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TaperedCapsuleShape_DestroyArray()`.
/// Use `JPH_TaperedCapsuleShape_OffsetMutablePtr()` and `JPH_TaperedCapsuleShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_OffsetPtr(const JPH_TaperedCapsuleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_OffsetMutablePtr(JPH_TaperedCapsuleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_TaperedCapsuleShape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_TaperedCapsuleShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(const JPH_TaperedCapsuleShape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_NonCopyable(JPH_TaperedCapsuleShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(const JPH_TaperedCapsuleShape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_Shape(JPH_TaperedCapsuleShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(const JPH_TaperedCapsuleShape *object);

/// Upcasts an instance of `JPH::TaperedCapsuleShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_ConvexShape(JPH_TaperedCapsuleShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::TaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Destroys a heap-allocated instance of `JPH_TaperedCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCapsuleShape_Destroy(const JPH_TaperedCapsuleShape *_this);

/// Destroys a heap-allocated array of `JPH_TaperedCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCapsuleShape_DestroyArray(const JPH_TaperedCapsuleShape *_this);

/// Get world space bounds including convex radius.
/// Generated from method `JPH::TaperedCapsuleShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_TaperedCapsuleShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_TaperedCapsuleShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Generated from method `JPH::TaperedCapsuleShape::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCapsuleShape_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCapsuleShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCapsuleShape_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCapsuleShape::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TaperedCapsuleShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get top radius of the tapered capsule
/// Generated from method `JPH::TaperedCapsuleShape::GetTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetTopRadius(const JPH_TaperedCapsuleShape *_this);

/// Get bottom radius of the tapered capsule
/// Generated from method `JPH::TaperedCapsuleShape::GetBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetBottomRadius(const JPH_TaperedCapsuleShape *_this);

/// Get half height between the top and bottom sphere center
/// Generated from method `JPH::TaperedCapsuleShape::GetHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetHalfHeight(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::TaperedCapsuleShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCapsuleShape_GetCenterOfMass(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::TaperedCapsuleShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_TaperedCapsuleShape_GetLocalBounds(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetWorldSpaceBounds
/// Generated from method `JPH::TaperedCapsuleShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_TaperedCapsuleShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_TaperedCapsuleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

// See Shape::GetInnerRadius
/// Generated from method `JPH::TaperedCapsuleShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetInnerRadius(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::TaperedCapsuleShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCapsuleShape_GetSurfaceNormal(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See ConvexShape::GetSupportFunction
/// Generated from method `JPH::TaperedCapsuleShape::GetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBuffer` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API const JPH_ConvexShape_Support *JPH_TaperedCapsuleShape_GetSupportFunction(const JPH_TaperedCapsuleShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale);

// See Shape::GetStats
/// Generated from method `JPH::TaperedCapsuleShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_TaperedCapsuleShape_GetStats(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::TaperedCapsuleShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetVolume(const JPH_TaperedCapsuleShape *_this);

// See Shape::IsValidScale
/// Generated from method `JPH::TaperedCapsuleShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCapsuleShape_IsValidScale(const JPH_TaperedCapsuleShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::TaperedCapsuleShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCapsuleShape_MakeScaleValid(const JPH_TaperedCapsuleShape *_this, const JPH_Vec3 *inScale);

// Register shape functions with the registry
/// Generated from method `JPH::TaperedCapsuleShape::sRegister`.
JOLT_API void JPH_TaperedCapsuleShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::TaperedCapsuleShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive(const JPH_TaperedCapsuleShape *_this);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::TaperedCapsuleShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_GetTrianglesStart(const JPH_TaperedCapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::TaperedCapsuleShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_TaperedCapsuleShape_GetTrianglesNext(const JPH_TaperedCapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Material of the shape
/// Generated from method `JPH::TaperedCapsuleShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_SetMaterial(JPH_TaperedCapsuleShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::TaperedCapsuleShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_SetDensity(JPH_TaperedCapsuleShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::TaperedCapsuleShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCapsuleShape_GetDensity(const JPH_TaperedCapsuleShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::TaperedCapsuleShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_TaperedCapsuleShape_GetUserData(const JPH_TaperedCapsuleShape *_this);

/// Generated from method `JPH::TaperedCapsuleShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_SetUserData(JPH_TaperedCapsuleShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::TaperedCapsuleShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCapsuleShape_MustBeStatic(const JPH_TaperedCapsuleShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::TaperedCapsuleShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_TaperedCapsuleShape_GetLeafShape(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::TaperedCapsuleShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_TaperedCapsuleShape_GetSubShapeUserData(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TaperedCapsuleShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_SetEmbedded(const JPH_TaperedCapsuleShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TaperedCapsuleShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCapsuleShape_GetRefCount(const JPH_TaperedCapsuleShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TaperedCapsuleShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_AddRef(const JPH_TaperedCapsuleShape *_this);

/// Generated from method `JPH::TaperedCapsuleShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCapsuleShape_Release(const JPH_TaperedCapsuleShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TaperedCapsuleShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_TaperedCapsuleShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
