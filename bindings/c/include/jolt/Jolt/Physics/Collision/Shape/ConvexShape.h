// machine generated, do not edit
#pragma once

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


/// Class that constructs a ConvexShape (abstract)
/// Generated from class `JPH::ConvexShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::BoxShapeSettings`
///     `JPH::CapsuleShapeSettings`
///     `JPH::ConvexHullShapeSettings`
///     `JPH::CylinderShapeSettings`
///     `JPH::SphereShapeSettings`
///     `JPH::TaperedCapsuleShapeSettings`
///     `JPH::TaperedCylinderShapeSettings`
///     `JPH::TriangleShapeSettings`
typedef struct JPH_ConvexShapeSettings JPH_ConvexShapeSettings;

/// Function that provides an interface for GJK
/// Generated from class `JPH::ConvexShape::Support`.
typedef struct JPH_ConvexShape_Support JPH_ConvexShape_Support;

/// Buffer to hold a Support object, used to avoid dynamic memory allocations
/// Generated from class `JPH::ConvexShape::SupportBuffer`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ConvexShape_SupportBuffer JPH_ConvexShape_SupportBuffer;

/// How the GetSupport function should behave
typedef enum JPH_ConvexShape_ESupportMode
{
    ///< Return the shape excluding the convex radius, Support::GetConvexRadius will return the convex radius if there is one, but adding this radius may not result in the most accurate/efficient representation of shapes with sharp edges
    JPH_ConvexShape_ESupportMode_ExcludeConvexRadius = 0,
    ///< Return the shape including the convex radius, Support::GetSupport includes the convex radius if there is one, Support::GetConvexRadius will return 0
    JPH_ConvexShape_ESupportMode_IncludeConvexRadius = 1,
    ///< Use both Support::GetSupport add Support::GetConvexRadius to get a support point that matches the original shape as accurately/efficiently as possible
    JPH_ConvexShape_ESupportMode_Default = 2,
} JPH_ConvexShape_ESupportMode;

/// Base class for all convex shapes. Defines a virtual interface.
/// Generated from class `JPH::ConvexShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::BoxShape`
///     `JPH::CapsuleShape`
///     `JPH::ConvexHullShape`
///     `JPH::CylinderShape`
///     `JPH::SphereShape`
///     `JPH::TaperedCapsuleShape`
///     `JPH::TaperedCylinderShape`
///     `JPH::TriangleShape`
typedef struct JPH_ConvexShape JPH_ConvexShape;

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a pointer to a member variable of class `JPH::ConvexShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConvexShapeSettings_Get_mDensity(const JPH_ConvexShapeSettings *_this);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Modifies a member variable of class `JPH::ConvexShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDensity`.
JOLT_API void JPH_ConvexShapeSettings_Set_mDensity(JPH_ConvexShapeSettings *_this, float value);

///< Uniform density of the interior of the convex object (kg / m^3)
/// Returns a mutable pointer to a member variable of class `JPH::ConvexShapeSettings` named `mDensity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConvexShapeSettings_GetMutable_mDensity(JPH_ConvexShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ConvexShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ConvexShapeSettings_Get_mUserData(const JPH_ConvexShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ConvexShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ConvexShapeSettings_Set_mUserData(JPH_ConvexShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ConvexShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ConvexShapeSettings_GetMutable_mUserData(JPH_ConvexShapeSettings *_this);

/// Destroys a heap-allocated instance of `JPH_ConvexShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShapeSettings_Destroy(const JPH_ConvexShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ConvexShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShapeSettings_DestroyArray(const JPH_ConvexShapeSettings *_this);

/// Generated from method `JPH::ConvexShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConvexShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the density of the object in kg / m^3
/// Generated from method `JPH::ConvexShapeSettings::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShapeSettings_SetDensity(JPH_ConvexShapeSettings *_this, float inDensity);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ConvexShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShapeSettings_ClearCachedResult(JPH_ConvexShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConvexShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShapeSettings_SetEmbedded(const JPH_ConvexShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConvexShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexShapeSettings_GetRefCount(const JPH_ConvexShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConvexShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShapeSettings_AddRef(const JPH_ConvexShapeSettings *_this);

/// Generated from method `JPH::ConvexShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShapeSettings_Release(const JPH_ConvexShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConvexShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConvexShapeSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_OffsetPtr(const JPH_ConvexShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_OffsetMutablePtr(JPH_ConvexShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ConvexShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ConvexShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ConvexShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ConvexShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ConvexShapeSettings *object);

/// Upcasts an instance of `JPH::ConvexShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ConvexShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::ConvexShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::ConvexShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_ConvexShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Destroys a heap-allocated instance of `JPH_ConvexShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_Destroy(const JPH_ConvexShape *_this);

/// Destroys a heap-allocated array of `JPH_ConvexShape`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_DestroyArray(const JPH_ConvexShape *_this);

/// Generated from method `JPH::ConvexShape::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexShape_size_t(unsigned long inCount);

/// Generated from method `JPH::ConvexShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShape_void_ptr(void *inPointer);

/// Generated from method `JPH::ConvexShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ConvexShape::operator new`.
JOLT_API void *Jolt_new_JPH_ConvexShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexShape::operator delete`.
JOLT_API void Jolt_delete_JPH_ConvexShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConvexShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConvexShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ConvexShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConvexShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::ConvexShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexShape_GetSubShapeIDBitsRecursive(const JPH_ConvexShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::ConvexShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_ConvexShape_GetMaterial_1(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::ConvexShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_GetTrianglesStart(const JPH_ConvexShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::ConvexShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_ConvexShape_GetTrianglesNext(const JPH_ConvexShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

/// Returns an object that provides the GetSupport function for this shape.
/// inMode determines if this support function includes or excludes the convex radius.
/// of the values returned by the GetSupport function. This improves numerical accuracy of the results.
/// inScale scales this shape in local space.
/// Generated from method `JPH::ConvexShape::GetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBuffer` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API const JPH_ConvexShape_Support *JPH_ConvexShape_GetSupportFunction(const JPH_ConvexShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale);

/// Material of the shape
/// Generated from method `JPH::ConvexShape::SetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_SetMaterial(JPH_ConvexShape *_this, const JPH_PhysicsMaterial *inMaterial);

/// Generated from method `JPH::ConvexShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_ConvexShape_GetMaterial_0(const JPH_ConvexShape *_this);

/// Set density of the shape (kg / m^3)
/// Generated from method `JPH::ConvexShape::SetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_SetDensity(JPH_ConvexShape *_this, float inDensity);

/// Get density of the shape (kg / m^3)
/// Generated from method `JPH::ConvexShape::GetDensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexShape_GetDensity(const JPH_ConvexShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::ConvexShape::sRegister`.
JOLT_API void JPH_ConvexShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::ConvexShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_ConvexShape_GetUserData(const JPH_ConvexShape *_this);

/// Generated from method `JPH::ConvexShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_SetUserData(JPH_ConvexShape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::ConvexShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConvexShape_MustBeStatic(const JPH_ConvexShape *_this);

/// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
/// Generated from method `JPH::ConvexShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexShape_GetCenterOfMass(const JPH_ConvexShape *_this);

/// Get local bounding box including convex radius, this box is centered around the center of mass rather than the world transform
/// Generated from method `JPH::ConvexShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_ConvexShape_GetLocalBounds(const JPH_ConvexShape *_this);

/// Returns the radius of the biggest sphere that fits entirely in the shape. In case this shape consists of multiple sub shapes, it returns the smallest sphere of the parts.
/// This can be used as a measure of how far the shape can be moved without risking going through geometry.
/// Generated from method `JPH::ConvexShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexShape_GetInnerRadius(const JPH_ConvexShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::ConvexShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_ConvexShape_GetLeafShape(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the surface normal of a particular sub shape ID and point on surface (all vectors are relative to center of mass for this shape).
/// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetSurfaceNormal will only return face normals (and not vertex or edge normals).
/// Generated from method `JPH::ConvexShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexShape_GetSurfaceNormal(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::ConvexShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_ConvexShape_GetSubShapeUserData(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
/// Generated from method `JPH::ConvexShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_ConvexShape_GetStats(const JPH_ConvexShape *_this);

/// Generated from method `JPH::ConvexShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexShape_GetVolume(const JPH_ConvexShape *_this);

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
/// Generated from method `JPH::ConvexShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_ConvexShape_IsValidScale(const JPH_ConvexShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::ConvexShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexShape_MakeScaleValid(const JPH_ConvexShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConvexShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_SetEmbedded(const JPH_ConvexShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConvexShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConvexShape_GetRefCount(const JPH_ConvexShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConvexShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_AddRef(const JPH_ConvexShape *_this);

/// Generated from method `JPH::ConvexShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConvexShape_Release(const JPH_ConvexShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConvexShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConvexShape_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_ConvexShape_OffsetPtr(const JPH_ConvexShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_ConvexShape_OffsetMutablePtr(JPH_ConvexShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_ConvexShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ConvexShape *object);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_ConvexShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ConvexShape_UpcastTo_JPH_NonCopyable(const JPH_ConvexShape *object);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ConvexShape_MutableUpcastTo_JPH_NonCopyable(JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_ConvexShape_UpcastTo_JPH_Shape(const JPH_ConvexShape *object);

/// Upcasts an instance of `JPH::ConvexShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_ConvexShape_MutableUpcastTo_JPH_Shape(JPH_ConvexShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::ConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Destroys a heap-allocated instance of `JPH_ConvexShape_Support`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_Support_Destroy(const JPH_ConvexShape_Support *_this);

/// Destroys a heap-allocated array of `JPH_ConvexShape_Support`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_Support_DestroyArray(const JPH_ConvexShape_Support *_this);

/// Calculate the support vector for this convex shape (includes / excludes the convex radius depending on how this was obtained).
/// Support vector is relative to the center of mass of the shape.
/// Generated from method `JPH::ConvexShape::Support::GetSupport`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConvexShape_Support_GetSupport(const JPH_ConvexShape_Support *_this, const JPH_Vec3 *inDirection);

/// Convex radius of shape. Collision detection on penetrating shapes is much more expensive,
/// so you can add a radius around objects to increase the shape. This makes it far less likely that they will actually penetrate.
/// Generated from method `JPH::ConvexShape::Support::GetConvexRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConvexShape_Support_GetConvexRadius(const JPH_ConvexShape_Support *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexShape_Support *JPH_ConvexShape_Support_OffsetPtr(const JPH_ConvexShape_Support *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexShape_Support *JPH_ConvexShape_Support_OffsetMutablePtr(JPH_ConvexShape_Support *ptr, ptrdiff_t i);

/// Returns a pointer to a member variable of class `JPH::ConvexShape::SupportBuffer` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned char *JPH_ConvexShape_SupportBuffer_Get_mData(const JPH_ConvexShape_SupportBuffer *_this);

/// Returns a mutable pointer to a member variable of class `JPH::ConvexShape::SupportBuffer` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned char *JPH_ConvexShape_SupportBuffer_GetMutable_mData(JPH_ConvexShape_SupportBuffer *_this);

/// Returns the size of the array member of class `JPH::ConvexShape::SupportBuffer` named `mData`. The size is `4160`.
JOLT_API size_t JPH_ConvexShape_SupportBuffer_GetSize_mData(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexShape_SupportBuffer_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ConvexShape_SupportBuffer_DestroyArray()`.
/// Use `JPH_ConvexShape_SupportBuffer_OffsetMutablePtr()` and `JPH_ConvexShape_SupportBuffer_OffsetPtr()` to access the array elements.
JOLT_API JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_OffsetPtr(const JPH_ConvexShape_SupportBuffer *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_OffsetMutablePtr(JPH_ConvexShape_SupportBuffer *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::ConvexShape::SupportBuffer::SupportBuffer`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConvexShape_SupportBuffer_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_ConstructFromAnother(const JPH_ConvexShape_SupportBuffer *_other);

/// Destroys a heap-allocated instance of `JPH_ConvexShape_SupportBuffer`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_SupportBuffer_Destroy(const JPH_ConvexShape_SupportBuffer *_this);

/// Destroys a heap-allocated array of `JPH_ConvexShape_SupportBuffer`. Does nothing if the pointer is null.
JOLT_API void JPH_ConvexShape_SupportBuffer_DestroyArray(const JPH_ConvexShape_SupportBuffer *_this);

/// Generated from method `JPH::ConvexShape::SupportBuffer::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_AssignFromAnother(JPH_ConvexShape_SupportBuffer *_this, const JPH_ConvexShape_SupportBuffer *_other);

#ifdef __cplusplus
} // extern "C"
#endif
