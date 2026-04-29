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


/// Class that constructs a TaperedCylinderShape
/// Generated from class `JPH::TaperedCylinderShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TaperedCylinderShapeSettings JPH_TaperedCylinderShapeSettings;

/// A cylinder with different top and bottom radii
/// Generated from class `JPH::TaperedCylinderShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TaperedCylinderShape JPH_TaperedCylinderShape;

/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCylinderShapeSettings_Get_mHalfHeight(const JPH_TaperedCylinderShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfHeight`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mHalfHeight(JPH_TaperedCylinderShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight(JPH_TaperedCylinderShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCylinderShapeSettings_Get_mTopRadius(const JPH_TaperedCylinderShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTopRadius`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mTopRadius(JPH_TaperedCylinderShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius(JPH_TaperedCylinderShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCylinderShapeSettings_Get_mBottomRadius(const JPH_TaperedCylinderShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBottomRadius`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mBottomRadius(JPH_TaperedCylinderShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius(JPH_TaperedCylinderShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCylinderShapeSettings_Get_mConvexRadius(const JPH_TaperedCylinderShapeSettings *_this);

/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mConvexRadius`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mConvexRadius(JPH_TaperedCylinderShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius(JPH_TaperedCylinderShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_TaperedCylinderShapeSettings_Get_mDensity(const JPH_TaperedCylinderShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mDensity(JPH_TaperedCylinderShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_TaperedCylinderShapeSettings_GetMutable_mDensity(JPH_TaperedCylinderShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_TaperedCylinderShapeSettings_Get_mUserData(const JPH_TaperedCylinderShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::TaperedCylinderShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_TaperedCylinderShapeSettings_Set_mUserData(JPH_TaperedCylinderShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::TaperedCylinderShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_TaperedCylinderShapeSettings_GetMutable_mUserData(JPH_TaperedCylinderShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCylinderShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TaperedCylinderShapeSettings_DestroyArray()`.
/// Use `JPH_TaperedCylinderShapeSettings_OffsetMutablePtr()` and `JPH_TaperedCylinderShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_OffsetPtr(const JPH_TaperedCylinderShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_OffsetMutablePtr(JPH_TaperedCylinderShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_TaperedCylinderShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TaperedCylinderShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_TaperedCylinderShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_TaperedCylinderShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_TaperedCylinderShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_TaperedCylinderShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_TaperedCylinderShapeSettings *object);

/// Upcasts an instance of `JPH::TaperedCylinderShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_TaperedCylinderShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::TaperedCylinderShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCylinderShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TaperedCylinderShapeSettings *_other);

/// Create a tapered cylinder centered around the origin with bottom at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and top at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
/// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
/// Parameter `inConvexRadius` has a default argument: `cDefaultConvexRadius`, pass a null pointer to use it.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCylinderShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_TaperedCylinderShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCylinderShapeSettings_Destroy(const JPH_TaperedCylinderShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_TaperedCylinderShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCylinderShapeSettings_DestroyArray(const JPH_TaperedCylinderShapeSettings *_this);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_AssignFromAnother(JPH_TaperedCylinderShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_TaperedCylinderShapeSettings *_other);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCylinderShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::TaperedCylinderShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShapeSettings_SetDensity(JPH_TaperedCylinderShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::TaperedCylinderShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShapeSettings_ClearCachedResult(JPH_TaperedCylinderShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TaperedCylinderShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShapeSettings_SetEmbedded(const JPH_TaperedCylinderShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TaperedCylinderShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCylinderShapeSettings_GetRefCount(const JPH_TaperedCylinderShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TaperedCylinderShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShapeSettings_AddRef(const JPH_TaperedCylinderShapeSettings *_this);

/// Generated from method `JPH::TaperedCylinderShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShapeSettings_Release(const JPH_TaperedCylinderShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TaperedCylinderShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::TaperedCylinderShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TaperedCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TaperedCylinderShape_DestroyArray()`.
/// Use `JPH_TaperedCylinderShape_OffsetMutablePtr()` and `JPH_TaperedCylinderShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_OffsetPtr(const JPH_TaperedCylinderShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_OffsetMutablePtr(JPH_TaperedCylinderShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_TaperedCylinderShape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_TaperedCylinderShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(const JPH_TaperedCylinderShape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_NonCopyable(JPH_TaperedCylinderShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(const JPH_TaperedCylinderShape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_Shape(JPH_TaperedCylinderShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(const JPH_TaperedCylinderShape *object);

/// Upcasts an instance of `JPH::TaperedCylinderShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_ConvexShape(JPH_TaperedCylinderShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::TaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Destroys a heap-allocated instance of `JPH_TaperedCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCylinderShape_Destroy(const JPH_TaperedCylinderShape *_this);

/// Destroys a heap-allocated array of `JPH_TaperedCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JPH_TaperedCylinderShape_DestroyArray(const JPH_TaperedCylinderShape *_this);

/// Generated from method `JPH::TaperedCylinderShape::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCylinderShape_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCylinderShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCylinderShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCylinderShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCylinderShape_size_t(size_t inCount);

/// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr(void *inPointer);

/// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TaperedCylinderShape::operator new`.
JOLT_API void *Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCylinderShape::operator delete`.
JOLT_API void Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TaperedCylinderShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get top radius of the tapered cylinder
/// Generated from method `JPH::TaperedCylinderShape::GetTopRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetTopRadius(const JPH_TaperedCylinderShape *_this);

/// Get bottom radius of the tapered cylinder
/// Generated from method `JPH::TaperedCylinderShape::GetBottomRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetBottomRadius(const JPH_TaperedCylinderShape *_this);

/// Get convex radius of the tapered cylinder
/// Generated from method `JPH::TaperedCylinderShape::GetConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetConvexRadius(const JPH_TaperedCylinderShape *_this);

/// Get half height of the tapered cylinder
/// Generated from method `JPH::TaperedCylinderShape::GetHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetHalfHeight(const JPH_TaperedCylinderShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::TaperedCylinderShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCylinderShape_GetCenterOfMass(const JPH_TaperedCylinderShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::TaperedCylinderShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_TaperedCylinderShape_GetLocalBounds(const JPH_TaperedCylinderShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::TaperedCylinderShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetInnerRadius(const JPH_TaperedCylinderShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::TaperedCylinderShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCylinderShape_GetSurfaceNormal(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See ConvexShape::GetSupportFunction
/// Generated from method `JPH::TaperedCylinderShape::GetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBuffer` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API const JPH_ConvexShape_Support *JPH_TaperedCylinderShape_GetSupportFunction(const JPH_TaperedCylinderShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::TaperedCylinderShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_GetTrianglesStart(const JPH_TaperedCylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::TaperedCylinderShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_TaperedCylinderShape_GetTrianglesNext(const JPH_TaperedCylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::TaperedCylinderShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_TaperedCylinderShape_GetStats(const JPH_TaperedCylinderShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::TaperedCylinderShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetVolume(const JPH_TaperedCylinderShape *_this);

// See Shape::IsValidScale
/// Generated from method `JPH::TaperedCylinderShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCylinderShape_IsValidScale(const JPH_TaperedCylinderShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::TaperedCylinderShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_TaperedCylinderShape_MakeScaleValid(const JPH_TaperedCylinderShape *_this, const JPH_Vec3 *inScale);

// Register shape functions with the registry
/// Generated from method `JPH::TaperedCylinderShape::sRegister`.
JOLT_API void JPH_TaperedCylinderShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::TaperedCylinderShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive(const JPH_TaperedCylinderShape *_this);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::TaperedCylinderShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_GetSubmergedVolume(const JPH_TaperedCylinderShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy);

/// Material of the shape
/// Generated from method `JPH::TaperedCylinderShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_SetMaterial(JPH_TaperedCylinderShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::TaperedCylinderShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_SetDensity(JPH_TaperedCylinderShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::TaperedCylinderShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TaperedCylinderShape_GetDensity(const JPH_TaperedCylinderShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::TaperedCylinderShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_TaperedCylinderShape_GetUserData(const JPH_TaperedCylinderShape *_this);

/// Generated from method `JPH::TaperedCylinderShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_SetUserData(JPH_TaperedCylinderShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::TaperedCylinderShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TaperedCylinderShape_MustBeStatic(const JPH_TaperedCylinderShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::TaperedCylinderShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_TaperedCylinderShape_GetLeafShape(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::TaperedCylinderShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_TaperedCylinderShape_GetSubShapeUserData(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TaperedCylinderShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_SetEmbedded(const JPH_TaperedCylinderShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TaperedCylinderShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TaperedCylinderShape_GetRefCount(const JPH_TaperedCylinderShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TaperedCylinderShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_AddRef(const JPH_TaperedCylinderShape *_this);

/// Generated from method `JPH::TaperedCylinderShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TaperedCylinderShape_Release(const JPH_TaperedCylinderShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TaperedCylinderShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_TaperedCylinderShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
