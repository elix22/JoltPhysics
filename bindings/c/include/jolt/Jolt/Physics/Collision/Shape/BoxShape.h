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
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_ConvexShape JPH_ConvexShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShapeSettings JPH_ConvexShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShape_Support JPH_ConvexShape_Support; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_ConvexShape_SupportBuffer JPH_ConvexShape_SupportBuffer; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/ConvexShape.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RayCast JPH_RayCast; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RayCastResult JPH_RayCastResult; // Defined in `#include <jolt/Jolt/Physics/Collision/CastResult.h>`.
typedef struct JPH_RayCastSettings JPH_RayCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/RayCast.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeSettings JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_Shape_Stats JPH_Shape_Stats; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that constructs a BoxShape
/// Generated from class `JPH::BoxShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BoxShapeSettings JPH_BoxShapeSettings;

/// A box, centered around the origin
/// Generated from class `JPH::BoxShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConvexShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BoxShape JPH_BoxShape;

///< Half the size of the box (including convex radius)
/// Returns a pointer to a member variable of class `JPH::BoxShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_BoxShapeSettings_Get_mHalfExtent(const JPH_BoxShapeSettings *_this);

///< Half the size of the box (including convex radius)
/// Returns a mutable pointer to a member variable of class `JPH::BoxShapeSettings` named `mHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_BoxShapeSettings_GetMutable_mHalfExtent(JPH_BoxShapeSettings *_this);

/// Returns a pointer to a member variable of class `JPH::BoxShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BoxShapeSettings_Get_mConvexRadius(const JPH_BoxShapeSettings *_this);

/// Modifies a member variable of class `JPH::BoxShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mConvexRadius`.
JOLT_API void JPH_BoxShapeSettings_Set_mConvexRadius(JPH_BoxShapeSettings *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::BoxShapeSettings` named `mConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BoxShapeSettings_GetMutable_mConvexRadius(JPH_BoxShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::BoxShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BoxShapeSettings_Get_mDensity(const JPH_BoxShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::BoxShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_BoxShapeSettings_Set_mDensity(JPH_BoxShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::BoxShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BoxShapeSettings_GetMutable_mDensity(JPH_BoxShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::BoxShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_BoxShapeSettings_Get_mUserData(const JPH_BoxShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::BoxShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_BoxShapeSettings_Set_mUserData(JPH_BoxShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::BoxShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_BoxShapeSettings_GetMutable_mUserData(JPH_BoxShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BoxShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BoxShapeSettings_DestroyArray()`.
/// Use `JPH_BoxShapeSettings_OffsetMutablePtr()` and `JPH_BoxShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BoxShapeSettings *JPH_BoxShapeSettings_OffsetPtr(const JPH_BoxShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_OffsetMutablePtr(JPH_BoxShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_BoxShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_BoxShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_BoxShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_BoxShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_BoxShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_BoxShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_BoxShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_BoxShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_BoxShapeSettings *object);

/// Upcasts an instance of `JPH::BoxShapeSettings` to its base class `JPH::ConvexShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_BoxShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ConvexShapeSettings` to a derived class `JPH::BoxShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object);

/// Generated from constructor `JPH::BoxShapeSettings::BoxShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BoxShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_BoxShapeSettings *_other);

/// Create a box with half edge length inHalfExtent and convex radius inConvexRadius.
/// (internally the convex radius will be subtracted from the half extent so the total box will not grow with the convex radius).
/// Generated from constructor `JPH::BoxShapeSettings::BoxShapeSettings`.
/// Parameter `inHalfExtent` can not be null. It is a single object.
/// Parameter `inConvexRadius` has a default argument: `cDefaultConvexRadius`, pass a null pointer to use it.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BoxShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_Construct(const JPH_Vec3 *inHalfExtent, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_BoxShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_BoxShapeSettings_Destroy(const JPH_BoxShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_BoxShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_BoxShapeSettings_DestroyArray(const JPH_BoxShapeSettings *_this);

/// Generated from method `JPH::BoxShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BoxShapeSettings *JPH_BoxShapeSettings_AssignFromAnother(JPH_BoxShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_BoxShapeSettings *_other);

/// Generated from method `JPH::BoxShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_BoxShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::BoxShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::BoxShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BoxShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BoxShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::BoxShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::BoxShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BoxShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_BoxShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BoxShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BoxShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BoxShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BoxShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::BoxShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShapeSettings_SetDensity(JPH_BoxShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::BoxShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShapeSettings_ClearCachedResult(JPH_BoxShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::BoxShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShapeSettings_SetEmbedded(const JPH_BoxShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::BoxShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BoxShapeSettings_GetRefCount(const JPH_BoxShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::BoxShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShapeSettings_AddRef(const JPH_BoxShapeSettings *_this);

/// Generated from method `JPH::BoxShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShapeSettings_Release(const JPH_BoxShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::BoxShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_BoxShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::BoxShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_BoxShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::BoxShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_BoxShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::BoxShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_BoxShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::BoxShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_BoxShape_GetMutable_sDrawSubmergedVolumes(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BoxShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_BoxShape *JPH_BoxShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BoxShape_DestroyArray()`.
/// Use `JPH_BoxShape_OffsetMutablePtr()` and `JPH_BoxShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_BoxShape *JPH_BoxShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BoxShape *JPH_BoxShape_OffsetPtr(const JPH_BoxShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BoxShape *JPH_BoxShape_OffsetMutablePtr(JPH_BoxShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_BoxShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_BoxShape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_BoxShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_BoxShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BoxShape_UpcastTo_JPH_NonCopyable(const JPH_BoxShape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BoxShape_MutableUpcastTo_JPH_NonCopyable(JPH_BoxShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_BoxShape_UpcastTo_JPH_Shape(const JPH_BoxShape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_BoxShape_MutableUpcastTo_JPH_Shape(JPH_BoxShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::ConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_BoxShape_UpcastTo_JPH_ConvexShape(const JPH_BoxShape *object);

/// Upcasts an instance of `JPH::BoxShape` to its base class `JPH::ConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_BoxShape_MutableUpcastTo_JPH_ConvexShape(JPH_BoxShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::ConvexShape` to a derived class `JPH::BoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object);

/// Create a box with half edge length inHalfExtent and convex radius inConvexRadius.
/// (internally the convex radius will be subtracted from the half extent so the total box will not grow with the convex radius).
/// Generated from constructor `JPH::BoxShape::BoxShape`.
/// Parameter `inHalfExtent` can not be null. It is a single object.
/// Parameter `inConvexRadius` has a default argument: `cDefaultConvexRadius`, pass a null pointer to use it.
/// Parameter `inMaterial` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BoxShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_BoxShape *JPH_BoxShape_Construct_3(const JPH_Vec3 *inHalfExtent, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial);

/// Destroys a heap-allocated instance of `JPH_BoxShape`. Does nothing if the pointer is null.
JOLT_API void JPH_BoxShape_Destroy(const JPH_BoxShape *_this);

/// Destroys a heap-allocated array of `JPH_BoxShape`. Does nothing if the pointer is null.
JOLT_API void JPH_BoxShape_DestroyArray(const JPH_BoxShape *_this);

/// Generated from method `JPH::BoxShape::operator new`.
JOLT_API void *Jolt_new_JPH_BoxShape_size_t(size_t inCount);

/// Generated from method `JPH::BoxShape::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShape_void_ptr(void *inPointer);

/// Generated from method `JPH::BoxShape::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BoxShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BoxShape_size_t(size_t inCount);

/// Generated from method `JPH::BoxShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShape_void_ptr(void *inPointer);

/// Generated from method `JPH::BoxShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BoxShape::operator new`.
JOLT_API void *Jolt_new_JPH_BoxShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BoxShape::operator delete`.
JOLT_API void Jolt_delete_JPH_BoxShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BoxShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BoxShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BoxShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BoxShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get half extent of box
/// Generated from method `JPH::BoxShape::GetHalfExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BoxShape_GetHalfExtent(const JPH_BoxShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::BoxShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_BoxShape_GetLocalBounds(const JPH_BoxShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::BoxShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_BoxShape_GetInnerRadius(const JPH_BoxShape *_this);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::BoxShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BoxShape_GetSurfaceNormal(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See ConvexShape::GetSupportFunction
/// Generated from method `JPH::BoxShape::GetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBuffer` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API const JPH_ConvexShape_Support *JPH_BoxShape_GetSupportFunction(const JPH_BoxShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale);

// See Shape::Draw
/// Generated from method `JPH::BoxShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_Draw(const JPH_BoxShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

// See Shape::CastRay
/// Generated from method `JPH::BoxShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_BoxShape_CastRay_3(const JPH_BoxShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::BoxShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_GetTrianglesStart(const JPH_BoxShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::BoxShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_BoxShape_GetTrianglesNext(const JPH_BoxShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::BoxShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_BoxShape_GetStats(const JPH_BoxShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::BoxShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_BoxShape_GetVolume(const JPH_BoxShape *_this);

/// Get the convex radius of this box
/// Generated from method `JPH::BoxShape::GetConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_BoxShape_GetConvexRadius(const JPH_BoxShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::BoxShape::sRegister`.
JOLT_API void JPH_BoxShape_sRegister(void);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::BoxShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BoxShape_GetSubShapeIDBitsRecursive(const JPH_BoxShape *_this);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::BoxShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_GetSubmergedVolume(const JPH_BoxShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

/// Material of the shape
/// Generated from method `JPH::BoxShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_SetMaterial(JPH_BoxShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::BoxShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_SetDensity(JPH_BoxShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::BoxShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_BoxShape_GetDensity(const JPH_BoxShape *_this);

// See Shape::DrawGetSupportFunction
/// Generated from method `JPH::BoxShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_DrawGetSupportFunction(const JPH_BoxShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

// See Shape::DrawGetSupportingFace
/// Generated from method `JPH::BoxShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_DrawGetSupportingFace(const JPH_BoxShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// User data (to be used freely by the application)
/// Generated from method `JPH::BoxShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_BoxShape_GetUserData(const JPH_BoxShape *_this);

/// Generated from method `JPH::BoxShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_SetUserData(JPH_BoxShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::BoxShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BoxShape_MustBeStatic(const JPH_BoxShape *_this);

/// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
/// Generated from method `JPH::BoxShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BoxShape_GetCenterOfMass(const JPH_BoxShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::BoxShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_BoxShape_GetLeafShape(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::BoxShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_BoxShape_GetSubShapeUserData(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::BoxShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_BoxShape_GetSubShapeTransformedShape(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

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
/// Generated from method `JPH::BoxShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_BoxShape_IsValidScale(const JPH_BoxShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::BoxShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BoxShape_MakeScaleValid(const JPH_BoxShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::BoxShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_SetEmbedded(const JPH_BoxShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::BoxShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BoxShape_GetRefCount(const JPH_BoxShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::BoxShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_AddRef(const JPH_BoxShape *_this);

/// Generated from method `JPH::BoxShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BoxShape_Release(const JPH_BoxShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::BoxShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_BoxShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
