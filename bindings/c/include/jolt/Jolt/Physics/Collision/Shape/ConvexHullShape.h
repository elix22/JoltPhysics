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


/// Class that constructs a ConvexHullShape
/// Generated from class `JPH::ConvexHullShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ConvexHullShapeSettings JPH_ConvexHullShapeSettings;

/// A convex hull
/// Generated from class `JPH::ConvexHullShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ConvexHullShape JPH_ConvexHullShape;

///< Convex radius as supplied by the constructor. Note that during hull creation the convex radius can be made smaller if the value is too big for the hull.
/// Returns a pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConvexHullShapeSettings_Get_mMaxConvexRadius(const JPH_ConvexHullShapeSettings *_this);

///< Convex radius as supplied by the constructor. Note that during hull creation the convex radius can be made smaller if the value is too big for the hull.
/// Modifies a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxConvexRadius`.
JOLT_API void JPH_ConvexHullShapeSettings_Set_mMaxConvexRadius(JPH_ConvexHullShapeSettings *_this, float value);

///< Convex radius as supplied by the constructor. Note that during hull creation the convex radius can be made smaller if the value is too big for the hull.
/// Returns a mutable pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConvexHullShapeSettings_GetMutable_mMaxConvexRadius(JPH_ConvexHullShapeSettings *_this);

///< Maximum distance between the shrunk hull + convex radius and the actual hull.
/// Returns a pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxErrorConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConvexHullShapeSettings_Get_mMaxErrorConvexRadius(const JPH_ConvexHullShapeSettings *_this);

///< Maximum distance between the shrunk hull + convex radius and the actual hull.
/// Modifies a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxErrorConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxErrorConvexRadius`.
JOLT_API void JPH_ConvexHullShapeSettings_Set_mMaxErrorConvexRadius(JPH_ConvexHullShapeSettings *_this, float value);

///< Maximum distance between the shrunk hull + convex radius and the actual hull.
/// Returns a mutable pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mMaxErrorConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConvexHullShapeSettings_GetMutable_mMaxErrorConvexRadius(JPH_ConvexHullShapeSettings *_this);

///< Points are allowed this far outside of the hull (increasing this yields a hull with less vertices). Note that the actual used value can be larger if the points of the hull are far apart.
/// Returns a pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mHullTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConvexHullShapeSettings_Get_mHullTolerance(const JPH_ConvexHullShapeSettings *_this);

///< Points are allowed this far outside of the hull (increasing this yields a hull with less vertices). Note that the actual used value can be larger if the points of the hull are far apart.
/// Modifies a member variable of class `JPH::ConvexHullShapeSettings` named `mHullTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHullTolerance`.
JOLT_API void JPH_ConvexHullShapeSettings_Set_mHullTolerance(JPH_ConvexHullShapeSettings *_this, float value);

///< Points are allowed this far outside of the hull (increasing this yields a hull with less vertices). Note that the actual used value can be larger if the points of the hull are far apart.
/// Returns a mutable pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mHullTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConvexHullShapeSettings_GetMutable_mHullTolerance(JPH_ConvexHullShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConvexHullShapeSettings_Get_mDensity(const JPH_ConvexHullShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::ConvexHullShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_ConvexHullShapeSettings_Set_mDensity(JPH_ConvexHullShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConvexHullShapeSettings_GetMutable_mDensity(JPH_ConvexHullShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ConvexHullShapeSettings_Get_mUserData(const JPH_ConvexHullShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ConvexHullShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ConvexHullShapeSettings_Set_mUserData(JPH_ConvexHullShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ConvexHullShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ConvexHullShapeSettings_GetMutable_mUserData(JPH_ConvexHullShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexHullShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ConvexHullShapeSettings_DestroyArray()`.
/// Use `JPH_ConvexHullShapeSettings_OffsetMutablePtr()` and `JPH_ConvexHullShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_OffsetPtr(const JPH_ConvexHullShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_OffsetMutablePtr(JPH_ConvexHullShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ConvexHullShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ConvexHullShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConvexHullShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ConvexHullShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ConvexHullShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ConvexHullShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ConvexHullShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_ConvexHullShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexHullShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_ConvexHullShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::ConvexHullShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::ConvexHullShapeSettings::ConvexHullShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexHullShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ConvexHullShapeSettings *_other);

/// Create a convex hull from inPoints and maximum convex radius inMaxConvexRadius, the radius is automatically lowered if the hull requires it.
/// (internally this will be subtracted so the total size will not grow with the convex radius).
/// Generated from constructor `JPH::ConvexHullShapeSettings::ConvexHullShapeSettings`.
/// Parameter `inMaxConvexRadius` has a default argument: `cDefaultConvexRadius`, pass a null pointer to use it.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexHullShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_Construct_4(const JPH_Vec3 *inPoints, int inNumPoints, const float *inMaxConvexRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_ConvexHullShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexHullShapeSettings_Destroy(const JPH_ConvexHullShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ConvexHullShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexHullShapeSettings_DestroyArray(const JPH_ConvexHullShapeSettings *_this);

/// Generated from method `JPH::ConvexHullShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_AssignFromAnother(JPH_ConvexHullShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_ConvexHullShapeSettings *_other);

/// Generated from method `JPH::ConvexHullShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexHullShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexHullShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexHullShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexHullShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexHullShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConvexHullShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexHullShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexHullShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::ConvexHullShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShapeSettings_SetDensity(JPH_ConvexHullShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ConvexHullShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShapeSettings_ClearCachedResult(JPH_ConvexHullShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConvexHullShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShapeSettings_SetEmbedded(const JPH_ConvexHullShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConvexHullShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShapeSettings_GetRefCount(const JPH_ConvexHullShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConvexHullShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShapeSettings_AddRef(const JPH_ConvexHullShapeSettings *_this);

/// Generated from method `JPH::ConvexHullShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShapeSettings_Release(const JPH_ConvexHullShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConvexHullShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConvexHullShapeSettings_sInternalGetRefCountOffset(void);

/// Maximum amount of points supported in a convex hull. Note that while constructing a hull, interior points are discarded so you can provide more points.
/// The ConvexHullShapeSettings::Create function will return an error when too many points are provided.
/// Returns a pointer to a member variable of class `JPH::ConvexHullShape` named `cMaxPointsInHull`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_ConvexHullShape_Get_cMaxPointsInHull(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::ConvexHullShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_ConvexHullShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexHullShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ConvexHullShape_DestroyArray()`.
/// Use `JPH_ConvexHullShape_OffsetMutablePtr()` and `JPH_ConvexHullShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShape *JPH_ConvexHullShape_OffsetPtr(const JPH_ConvexHullShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_OffsetMutablePtr(JPH_ConvexHullShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_ConvexHullShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ConvexHullShape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_ConvexHullShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ConvexHullShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ConvexHullShape_UpcastTo_JPH_NonCopyable(const JPH_ConvexHullShape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ConvexHullShape_MutableUpcastTo_JPH_NonCopyable(JPH_ConvexHullShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_ConvexHullShape_UpcastTo_JPH_Shape(const JPH_ConvexHullShape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_ConvexHullShape_MutableUpcastTo_JPH_Shape(JPH_ConvexHullShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_ConvexHullShape_UpcastTo_JPH_ConvexShape(const JPH_ConvexHullShape *object);

/// Upcasts an instance of `JPH::ConvexHullShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_ConvexHullShape_MutableUpcastTo_JPH_ConvexShape(JPH_ConvexHullShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::ConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Destroys a heap-allocated instance of `JPH_ConvexHullShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexHullShape_Destroy(const JPH_ConvexHullShape *_this);

/// Destroys a heap-allocated array of `JPH_ConvexHullShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexHullShape_DestroyArray(const JPH_ConvexHullShape *_this);

/// Generated from method `JPH::ConvexHullShape::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexHullShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexHullShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexHullShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexHullShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexHullShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexHullShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexHullShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexHullShape::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexHullShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexHullShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexHullShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConvexHullShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexHullShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexHullShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexHullShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::ConvexHullShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexHullShape_GetCenterOfMass(const JPH_ConvexHullShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::ConvexHullShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ConvexHullShape_GetLocalBounds(const JPH_ConvexHullShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::ConvexHullShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexHullShape_GetInnerRadius(const JPH_ConvexHullShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::ConvexHullShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexHullShape_GetSurfaceNormal(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See ConvexShape::GetSupportFunction
/// Generated from method `JPH::ConvexHullShape::GetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBuffer` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API const JPH_ConvexShape_Support *JPH_ConvexHullShape_GetSupportFunction(const JPH_ConvexHullShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::ConvexHullShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_GetTrianglesStart(const JPH_ConvexHullShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::ConvexHullShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_ConvexHullShape_GetTrianglesNext(const JPH_ConvexHullShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::ConvexHullShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_ConvexHullShape_GetStats(const JPH_ConvexHullShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::ConvexHullShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexHullShape_GetVolume(const JPH_ConvexHullShape *_this);

/// Get the convex radius of this convex hull
/// Generated from method `JPH::ConvexHullShape::GetConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexHullShape_GetConvexRadius(const JPH_ConvexHullShape *_this);

/// Get the number of vertices in this convex hull
/// Generated from method `JPH::ConvexHullShape::GetNumPoints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetNumPoints(const JPH_ConvexHullShape *_this);

/// Get a vertex of this convex hull relative to the center of mass
/// Generated from method `JPH::ConvexHullShape::GetPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexHullShape_GetPoint(const JPH_ConvexHullShape *_this, unsigned int inIndex);

/// Get the number of faces in this convex hull
/// Generated from method `JPH::ConvexHullShape::GetNumFaces`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetNumFaces(const JPH_ConvexHullShape *_this);

/// Get the number of vertices in a face
/// Generated from method `JPH::ConvexHullShape::GetNumVerticesInFace`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetNumVerticesInFace(const JPH_ConvexHullShape *_this, unsigned int inFaceIndex);

/// Get the vertices indices of a face
/// @param inFaceIndex Index of the face.
/// @param inMaxVertices Maximum number of vertices to return.
/// @param outVertices Array of vertices indices, must be at least inMaxVertices in size, the vertices are returned in counter clockwise order and the positions can be obtained using GetPoint(index).
/// @return Number of vertices in face, if this is bigger than inMaxVertices, not all vertices were retrieved.
/// Generated from method `JPH::ConvexHullShape::GetFaceVertices`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetFaceVertices(const JPH_ConvexHullShape *_this, unsigned int inFaceIndex, unsigned int inMaxVertices, unsigned int *outVertices);

// Register shape functions with the registry
/// Generated from method `JPH::ConvexHullShape::sRegister`.
JOLT_API void JPH_ConvexHullShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::ConvexHullShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetSubShapeIDBitsRecursive(const JPH_ConvexHullShape *_this);

/// Material of the shape
/// Generated from method `JPH::ConvexHullShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_SetMaterial(JPH_ConvexHullShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::ConvexHullShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_SetDensity(JPH_ConvexHullShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::ConvexHullShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexHullShape_GetDensity(const JPH_ConvexHullShape *_this);

/// User data (to be used freely by the application)
/// Generated from method `JPH::ConvexHullShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_ConvexHullShape_GetUserData(const JPH_ConvexHullShape *_this);

/// Generated from method `JPH::ConvexHullShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_SetUserData(JPH_ConvexHullShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::ConvexHullShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConvexHullShape_MustBeStatic(const JPH_ConvexHullShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::ConvexHullShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ConvexHullShape_GetLeafShape(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::ConvexHullShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_ConvexHullShape_GetSubShapeUserData(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Test if inScale is a valid scale for this shape. Some shapes can only be scaled uniformly, compound shapes cannot handle shapes
/// being rotated and scaled (this would cause shearing), scale can never be zero. When the scale is invalid, the function will return false.
///
/// Here's a list of supported scales:
/// * SphereShape: Scale must be uniform (signs of scale are ignored).
/// * BoxShape: Any scale supported (signs of scale are ignored).
/// * TriangleShape: Any scale supported when convex radius is zero, otherwise only uniform scale supported.
/// * CapsuleShape: Scale must be uniform (signs of scale are ignored).
/// * TaperedCapsuleShape: Scale must be uniform (sign of Y scale can be used to flip the capsule).
/// * CylinderShape: Scale must be uniform in XZ plane, Y can scale independently (signs of scale are ignored).
/// * RotatedTranslatedShape: Scale must not cause shear in the child shape.
/// * CompoundShape: Scale must not cause shear in any of the child shapes.
/// Generated from method `JPH::ConvexHullShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_ConvexHullShape_IsValidScale(const JPH_ConvexHullShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::ConvexHullShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexHullShape_MakeScaleValid(const JPH_ConvexHullShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConvexHullShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_SetEmbedded(const JPH_ConvexHullShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConvexHullShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexHullShape_GetRefCount(const JPH_ConvexHullShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConvexHullShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_AddRef(const JPH_ConvexHullShape *_this);

/// Generated from method `JPH::ConvexHullShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexHullShape_Release(const JPH_ConvexHullShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConvexHullShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConvexHullShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
