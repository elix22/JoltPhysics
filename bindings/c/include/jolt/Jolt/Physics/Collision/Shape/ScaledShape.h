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
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_DMat44 JPH_DMat44; // Defined in `#include <jolt/Jolt/Math/DMat44.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_DecoratedShape JPH_DecoratedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
typedef struct JPH_DecoratedShapeSettings JPH_DecoratedShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h>`.
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


/// Class that constructs a ScaledShape
/// Generated from class `JPH::ScaledShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
///     `JPH::ShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ScaledShapeSettings JPH_ScaledShapeSettings;

/// A shape that scales a child shape in local space of that shape. The scale can be non-uniform and can even turn it inside out when one or three components of the scale are negative.
/// Generated from class `JPH::ScaledShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DecoratedShape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
///     `JPH::Shape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ScaledShape JPH_ScaledShape;

/// Returns a pointer to a member variable of class `JPH::ScaledShapeSettings` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ScaledShapeSettings_Get_mScale(const JPH_ScaledShapeSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::ScaledShapeSettings` named `mScale`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ScaledShapeSettings_GetMutable_mScale(JPH_ScaledShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ScaledShapeSettings_Get_mUserData(const JPH_ScaledShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ScaledShapeSettings_Set_mUserData(JPH_ScaledShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ScaledShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ScaledShapeSettings_GetMutable_mUserData(JPH_ScaledShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ScaledShapeSettings_DestroyArray()`.
/// Use `JPH_ScaledShapeSettings_OffsetMutablePtr()` and `JPH_ScaledShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetPtr(const JPH_ScaledShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetMutablePtr(JPH_ScaledShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ScaledShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_ScaledShapeSettings *object);

/// Upcasts an instance of `JPH::ScaledShapeSettings` to its base class `JPH::DecoratedShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_ScaledShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object);

/// Downcasts an instance of `JPH::DecoratedShapeSettings` to a derived class `JPH::ScaledShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object);

/// Generated from constructor `JPH::ScaledShapeSettings::ScaledShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other);

/// Constructor that decorates another shape with a scale
/// Generated from constructor `JPH::ScaledShapeSettings::ScaledShapeSettings`.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_ShapeSettings *inShape, const JPH_Vec3 *inScale);

/// Variant that uses a concrete shape, which means this object cannot be serialized.
/// Generated from constructor `JPH::ScaledShapeSettings::ScaledShapeSettings`.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inScale);

/// Destroys a heap-allocated instance of `JPH_ScaledShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShapeSettings_Destroy(const JPH_ScaledShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ScaledShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShapeSettings_DestroyArray(const JPH_ScaledShapeSettings *_this);

/// Generated from method `JPH::ScaledShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_AssignFromAnother(JPH_ScaledShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other);

/// Generated from method `JPH::ScaledShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ScaledShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ScaledShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ScaledShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ScaledShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ScaledShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_ClearCachedResult(JPH_ScaledShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ScaledShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_SetEmbedded(const JPH_ScaledShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ScaledShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShapeSettings_GetRefCount(const JPH_ScaledShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ScaledShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_AddRef(const JPH_ScaledShapeSettings *_this);

/// Generated from method `JPH::ScaledShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShapeSettings_Release(const JPH_ScaledShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ScaledShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ScaledShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::ScaledShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_ScaledShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::ScaledShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_ScaledShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::ScaledShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_ScaledShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::ScaledShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_ScaledShape_GetMutable_sDrawSubmergedVolumes(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ScaledShape_DestroyArray()`.
/// Use `JPH_ScaledShape_OffsetMutablePtr()` and `JPH_ScaledShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_OffsetPtr(const JPH_ScaledShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_OffsetMutablePtr(JPH_ScaledShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ScaledShape_UpcastTo_JPH_NonCopyable(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ScaledShape_MutableUpcastTo_JPH_NonCopyable(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_Shape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_Shape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::DecoratedShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DecoratedShape *JPH_ScaledShape_UpcastTo_JPH_DecoratedShape(const JPH_ScaledShape *object);

/// Upcasts an instance of `JPH::ScaledShape` to its base class `JPH::DecoratedShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DecoratedShape *JPH_ScaledShape_MutableUpcastTo_JPH_DecoratedShape(JPH_ScaledShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object);

/// Downcasts an instance of `JPH::DecoratedShape` to a derived class `JPH::ScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object);

/// Constructor that decorates another shape with a scale
/// Generated from constructor `JPH::ScaledShape::ScaledShape`.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ScaledShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_ScaledShape *JPH_ScaledShape_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inScale);

/// Destroys a heap-allocated instance of `JPH_ScaledShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShape_Destroy(const JPH_ScaledShape *_this);

/// Destroys a heap-allocated array of `JPH_ScaledShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ScaledShape_DestroyArray(const JPH_ScaledShape *_this);

/// Get world space bounds including convex radius.
/// Generated from method `JPH::ScaledShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ScaledShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_ScaledShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

/// Generated from method `JPH::ScaledShape::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShape_size_t(size_t inCount);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ScaledShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShape_size_t(size_t inCount);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ScaledShape::operator new`.
JOLT_API void *Jolt_new_JPH_ScaledShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ScaledShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ScaledShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ScaledShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the scale
/// Generated from method `JPH::ScaledShape::GetScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ScaledShape_GetScale(const JPH_ScaledShape *_this);

// See Shape::GetCenterOfMass
/// Generated from method `JPH::ScaledShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ScaledShape_GetCenterOfMass(const JPH_ScaledShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::ScaledShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ScaledShape_GetLocalBounds(const JPH_ScaledShape *_this);

// See Shape::GetWorldSpaceBounds
/// Generated from method `JPH::ScaledShape::GetWorldSpaceBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ScaledShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_ScaledShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

// See Shape::GetInnerRadius
/// Generated from method `JPH::ScaledShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ScaledShape_GetInnerRadius(const JPH_ScaledShape *_this);

// See Shape::GetSubShapeTransformedShape
/// Generated from method `JPH::ScaledShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_ScaledShape_GetSubShapeTransformedShape(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::ScaledShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ScaledShape_GetSurfaceNormal(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::ScaledShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_GetSubmergedVolume(const JPH_ScaledShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

// See Shape::Draw
/// Generated from method `JPH::ScaledShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_Draw(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

// See Shape::DrawGetSupportFunction
/// Generated from method `JPH::ScaledShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_DrawGetSupportFunction(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

// See Shape::DrawGetSupportingFace
/// Generated from method `JPH::ScaledShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_DrawGetSupportingFace(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

// See Shape::CastRay
/// Generated from method `JPH::ScaledShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_ScaledShape_CastRay_3(const JPH_ScaledShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::ScaledShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_GetTrianglesStart(const JPH_ScaledShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::ScaledShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_ScaledShape_GetTrianglesNext(const JPH_ScaledShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetStats
/// Generated from method `JPH::ScaledShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_ScaledShape_GetStats(const JPH_ScaledShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::ScaledShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ScaledShape_GetVolume(const JPH_ScaledShape *_this);

// See Shape::IsValidScale
/// Generated from method `JPH::ScaledShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_ScaledShape_IsValidScale(const JPH_ScaledShape *_this, const JPH_Vec3 *inScale);

// See Shape::MakeScaleValid
/// Generated from method `JPH::ScaledShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ScaledShape_MakeScaleValid(const JPH_ScaledShape *_this, const JPH_Vec3 *inScale);

// Register shape functions with the registry
/// Generated from method `JPH::ScaledShape::sRegister`.
JOLT_API void JPH_ScaledShape_sRegister(void);

/// Access to the decorated inner shape
/// Generated from method `JPH::ScaledShape::GetInnerShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ScaledShape_GetInnerShape(const JPH_ScaledShape *_this);

// See Shape::MustBeStatic
/// Generated from method `JPH::ScaledShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ScaledShape_MustBeStatic(const JPH_ScaledShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::ScaledShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShape_GetSubShapeIDBitsRecursive(const JPH_ScaledShape *_this);

// See Shape::GetLeafShape
/// Generated from method `JPH::ScaledShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ScaledShape_GetLeafShape(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetMaterial
/// Generated from method `JPH::ScaledShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_ScaledShape_GetMaterial(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::ScaledShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_ScaledShape_GetSubShapeUserData(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID);

/// User data (to be used freely by the application)
/// Generated from method `JPH::ScaledShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_ScaledShape_GetUserData(const JPH_ScaledShape *_this);

/// Generated from method `JPH::ScaledShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_SetUserData(JPH_ScaledShape *_this, uint64_t inUserData);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ScaledShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_SetEmbedded(const JPH_ScaledShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ScaledShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ScaledShape_GetRefCount(const JPH_ScaledShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ScaledShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_AddRef(const JPH_ScaledShape *_this);

/// Generated from method `JPH::ScaledShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ScaledShape_Release(const JPH_ScaledShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ScaledShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_ScaledShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
