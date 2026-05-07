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
typedef struct Jolt_JPH_Array_JPH_Float3 Jolt_JPH_Array_JPH_Float3; // Defined in `#include <JPH_Array_JPH_Float3.h>`.


typedef enum JPH_MeshShapeSettings_EBuildQuality
{
    ///< Favor runtime performance, takes more time to build the MeshShape but performs better
    JPH_MeshShapeSettings_EBuildQuality_FavorRuntimePerformance = 0,
    ///< Favor build speed, build the tree faster but the MeshShape will be slower
    JPH_MeshShapeSettings_EBuildQuality_FavorBuildSpeed = 1,
} JPH_MeshShapeSettings_EBuildQuality;

/// Class that constructs a MeshShape
/// Generated from class `JPH::MeshShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MeshShapeSettings JPH_MeshShapeSettings;

/// A mesh shape, consisting of triangles. Mesh shapes are mostly used for static geometry.
/// They can be used by dynamic or kinematic objects but only if they don't collide with other mesh or heightfield shapes as those collisions are currently not supported.
/// Note that if you make a mesh shape a dynamic or kinematic object, you need to provide a mass yourself as mesh shapes don't need to form a closed hull so don't have a well defined volume from which the mass can be calculated.
/// Generated from class `JPH::MeshShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MeshShape JPH_MeshShape;

/// Vertices belonging to mIndexedTriangles
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mTriangleVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_JPH_Float3 *JPH_MeshShapeSettings_Get_mTriangleVertices(const JPH_MeshShapeSettings *_this);

/// Vertices belonging to mIndexedTriangles
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mTriangleVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mTriangleVertices`.
/// When this function is called, this object will drop object references it held previously in `mTriangleVertices`.
JOLT_API void JPH_MeshShapeSettings_Set_mTriangleVertices(JPH_MeshShapeSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_Float3 *value);

/// Vertices belonging to mIndexedTriangles
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mTriangleVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_JPH_Float3 *JPH_MeshShapeSettings_GetMutable_mTriangleVertices(JPH_MeshShapeSettings *_this);

/// Maximum number of triangles in each leaf of the axis aligned box tree. This is a balance between memory and performance. Can be in the range [1, MeshShape::MaxTrianglesPerLeaf].
/// Sensible values are between 4 (for better performance) and 8 (for less memory usage).
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mMaxTrianglesPerLeaf`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_MeshShapeSettings_Get_mMaxTrianglesPerLeaf(const JPH_MeshShapeSettings *_this);

/// Maximum number of triangles in each leaf of the axis aligned box tree. This is a balance between memory and performance. Can be in the range [1, MeshShape::MaxTrianglesPerLeaf].
/// Sensible values are between 4 (for better performance) and 8 (for less memory usage).
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mMaxTrianglesPerLeaf`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaxTrianglesPerLeaf`.
/// When this function is called, this object will drop object references it held previously in `mMaxTrianglesPerLeaf`.
JOLT_API void JPH_MeshShapeSettings_Set_mMaxTrianglesPerLeaf(JPH_MeshShapeSettings *_this, unsigned int value);

/// Maximum number of triangles in each leaf of the axis aligned box tree. This is a balance between memory and performance. Can be in the range [1, MeshShape::MaxTrianglesPerLeaf].
/// Sensible values are between 4 (for better performance) and 8 (for less memory usage).
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mMaxTrianglesPerLeaf`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_MeshShapeSettings_GetMutable_mMaxTrianglesPerLeaf(JPH_MeshShapeSettings *_this);

// cos(5 degrees)
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MeshShapeSettings_Get_mActiveEdgeCosThresholdAngle(const JPH_MeshShapeSettings *_this);

// cos(5 degrees)
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mActiveEdgeCosThresholdAngle`.
JOLT_API void JPH_MeshShapeSettings_Set_mActiveEdgeCosThresholdAngle(JPH_MeshShapeSettings *_this, float value);

// cos(5 degrees)
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MeshShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(JPH_MeshShapeSettings *_this);

/// When true, we store the user data coming from Triangle::mUserData or IndexedTriangle::mUserData in the mesh shape.
/// This can be used to store additional data like the original index of the triangle in the mesh.
/// Can be retrieved using MeshShape::GetTriangleUserData.
/// Turning this on increases the memory used by the MeshShape by roughly 25%.
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mPerTriangleUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_MeshShapeSettings_Get_mPerTriangleUserData(const JPH_MeshShapeSettings *_this);

/// When true, we store the user data coming from Triangle::mUserData or IndexedTriangle::mUserData in the mesh shape.
/// This can be used to store additional data like the original index of the triangle in the mesh.
/// Can be retrieved using MeshShape::GetTriangleUserData.
/// Turning this on increases the memory used by the MeshShape by roughly 25%.
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mPerTriangleUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPerTriangleUserData`.
JOLT_API void JPH_MeshShapeSettings_Set_mPerTriangleUserData(JPH_MeshShapeSettings *_this, bool value);

/// When true, we store the user data coming from Triangle::mUserData or IndexedTriangle::mUserData in the mesh shape.
/// This can be used to store additional data like the original index of the triangle in the mesh.
/// Can be retrieved using MeshShape::GetTriangleUserData.
/// Turning this on increases the memory used by the MeshShape by roughly 25%.
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mPerTriangleUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_MeshShapeSettings_GetMutable_mPerTriangleUserData(JPH_MeshShapeSettings *_this);

/// Determines the quality of the tree building process.
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mBuildQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_MeshShapeSettings_EBuildQuality *JPH_MeshShapeSettings_Get_mBuildQuality(const JPH_MeshShapeSettings *_this);

/// Determines the quality of the tree building process.
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mBuildQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBuildQuality`.
/// When this function is called, this object will drop object references it held previously in `mBuildQuality`.
JOLT_API void JPH_MeshShapeSettings_Set_mBuildQuality(JPH_MeshShapeSettings *_this, JPH_MeshShapeSettings_EBuildQuality value);

/// Determines the quality of the tree building process.
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mBuildQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_MeshShapeSettings_EBuildQuality *JPH_MeshShapeSettings_GetMutable_mBuildQuality(JPH_MeshShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::MeshShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_MeshShapeSettings_Get_mUserData(const JPH_MeshShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::MeshShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_MeshShapeSettings_Set_mUserData(JPH_MeshShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::MeshShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_MeshShapeSettings_GetMutable_mUserData(JPH_MeshShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MeshShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MeshShapeSettings_DestroyArray()`.
/// Use `JPH_MeshShapeSettings_OffsetMutablePtr()` and `JPH_MeshShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MeshShapeSettings *JPH_MeshShapeSettings_OffsetPtr(const JPH_MeshShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_OffsetMutablePtr(JPH_MeshShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_MeshShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_MeshShapeSettings *object);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_MeshShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MeshShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_MeshShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_MeshShapeSettings *object);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_MeshShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_MeshShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_MeshShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_MeshShapeSettings *object);

/// Upcasts an instance of `JPH::MeshShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_MeshShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_MeshShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::MeshShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Generated from constructor `JPH::MeshShapeSettings::MeshShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MeshShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MeshShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_MeshShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MeshShapeSettings_Destroy(const JPH_MeshShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_MeshShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MeshShapeSettings_DestroyArray(const JPH_MeshShapeSettings *_this);

/// Generated from method `JPH::MeshShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_MeshShapeSettings *JPH_MeshShapeSettings_AssignFromAnother(JPH_MeshShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_MeshShapeSettings *_other);

/// Generated from method `JPH::MeshShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MeshShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::MeshShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MeshShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MeshShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MeshShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::MeshShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MeshShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MeshShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MeshShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MeshShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MeshShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MeshShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MeshShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Sanitize the mesh data. Remove duplicate and degenerate triangles. This is called automatically when constructing the MeshShapeSettings with a list of (indexed-) triangles.
/// Generated from method `JPH::MeshShapeSettings::Sanitize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShapeSettings_Sanitize(JPH_MeshShapeSettings *_this);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::MeshShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShapeSettings_ClearCachedResult(JPH_MeshShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::MeshShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShapeSettings_SetEmbedded(const JPH_MeshShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::MeshShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MeshShapeSettings_GetRefCount(const JPH_MeshShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::MeshShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShapeSettings_AddRef(const JPH_MeshShapeSettings *_this);

/// Generated from method `JPH::MeshShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShapeSettings_Release(const JPH_MeshShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::MeshShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_MeshShapeSettings_sInternalGetRefCountOffset(void);

// Settings
/// Returns a pointer to a member variable of class `JPH::MeshShape` named `sDrawTriangleGroups`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_MeshShape_Get_sDrawTriangleGroups(void);

// Settings
/// Modifies a member variable of class `JPH::MeshShape` named `sDrawTriangleGroups`.
/// When this function is called, this object will drop object references it held previously in `sDrawTriangleGroups`.
JOLT_API void JPH_MeshShape_Set_sDrawTriangleGroups(bool value);

// Settings
/// Returns a mutable pointer to a member variable of class `JPH::MeshShape` named `sDrawTriangleGroups`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_MeshShape_GetMutable_sDrawTriangleGroups(void);

/// Returns a pointer to a member variable of class `JPH::MeshShape` named `sDrawTriangleOutlines`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_MeshShape_Get_sDrawTriangleOutlines(void);

/// Modifies a member variable of class `JPH::MeshShape` named `sDrawTriangleOutlines`.
/// When this function is called, this object will drop object references it held previously in `sDrawTriangleOutlines`.
JOLT_API void JPH_MeshShape_Set_sDrawTriangleOutlines(bool value);

/// Returns a mutable pointer to a member variable of class `JPH::MeshShape` named `sDrawTriangleOutlines`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_MeshShape_GetMutable_sDrawTriangleOutlines(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::MeshShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_MeshShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a pointer to a member variable of class `JPH::MeshShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_MeshShape_Get_sDrawSubmergedVolumes(void);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Modifies a member variable of class `JPH::MeshShape` named `sDrawSubmergedVolumes`.
/// When this function is called, this object will drop object references it held previously in `sDrawSubmergedVolumes`.
JOLT_API void JPH_MeshShape_Set_sDrawSubmergedVolumes(bool value);

/// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
/// Returns a mutable pointer to a member variable of class `JPH::MeshShape` named `sDrawSubmergedVolumes`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API bool *JPH_MeshShape_GetMutable_sDrawSubmergedVolumes(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MeshShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_MeshShape *JPH_MeshShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MeshShape_DestroyArray()`.
/// Use `JPH_MeshShape_OffsetMutablePtr()` and `JPH_MeshShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_MeshShape *JPH_MeshShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MeshShape *JPH_MeshShape_OffsetPtr(const JPH_MeshShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MeshShape *JPH_MeshShape_OffsetMutablePtr(JPH_MeshShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_MeshShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_MeshShape *object);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_MeshShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_MeshShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_MeshShape_UpcastTo_JPH_NonCopyable(const JPH_MeshShape *object);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_MeshShape_MutableUpcastTo_JPH_NonCopyable(JPH_MeshShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_MeshShape_UpcastTo_JPH_Shape(const JPH_MeshShape *object);

/// Upcasts an instance of `JPH::MeshShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_MeshShape_MutableUpcastTo_JPH_Shape(JPH_MeshShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::MeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Destroys a heap-allocated instance of `JPH_MeshShape`. Does nothing if the pointer is null.
JOLT_API void JPH_MeshShape_Destroy(const JPH_MeshShape *_this);

/// Destroys a heap-allocated array of `JPH_MeshShape`. Does nothing if the pointer is null.
JOLT_API void JPH_MeshShape_DestroyArray(const JPH_MeshShape *_this);

/// Generated from method `JPH::MeshShape::operator new`.
JOLT_API void *Jolt_new_JPH_MeshShape_size_t(size_t inCount);

/// Generated from method `JPH::MeshShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShape_void_ptr(void *inPointer);

/// Generated from method `JPH::MeshShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MeshShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MeshShape_size_t(size_t inCount);

/// Generated from method `JPH::MeshShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShape_void_ptr(void *inPointer);

/// Generated from method `JPH::MeshShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShape_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MeshShape::operator new`.
JOLT_API void *Jolt_new_JPH_MeshShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MeshShape::operator delete`.
JOLT_API void Jolt_delete_JPH_MeshShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MeshShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MeshShape_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MeshShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MeshShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::MustBeStatic
/// Generated from method `JPH::MeshShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MeshShape_MustBeStatic(const JPH_MeshShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::MeshShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_MeshShape_GetLocalBounds(const JPH_MeshShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::MeshShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MeshShape_GetSubShapeIDBitsRecursive(const JPH_MeshShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::MeshShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MeshShape_GetInnerRadius(const JPH_MeshShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::MeshShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_MeshShape_GetMaterial(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Determine which material index a particular sub shape uses (note that if there are no materials this function will return 0 so check the array size)
/// Note: This could for example be used to create a decorator shape around a mesh shape that overrides the GetMaterial call to replace a material with another material.
/// Generated from method `JPH::MeshShape::GetMaterialIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API unsigned int JPH_MeshShape_GetMaterialIndex(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetSurfaceNormal
/// Generated from method `JPH::MeshShape::GetSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inLocalSurfacePosition` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MeshShape_GetSurfaceNormal(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition);

// See Shape::Draw
/// Generated from method `JPH::MeshShape::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_Draw(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe);

// See Shape::CastRay
/// Generated from method `JPH::MeshShape::CastRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRay` can not be null. It is a single object.
/// Parameter `inSubShapeIDCreator` can not be null. It is a single object.
/// Parameter `ioHit` can not be null. It is a single object.
JOLT_API bool JPH_MeshShape_CastRay_3(const JPH_MeshShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit);

// See Shape::GetTrianglesStart
/// Generated from method `JPH::MeshShape::GetTrianglesStart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_GetTrianglesStart(const JPH_MeshShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale);

// See Shape::GetTrianglesNext
/// Generated from method `JPH::MeshShape::GetTrianglesNext`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioContext` can not be null. It is a single object.
/// Parameter `outMaterials` defaults to a null pointer in C++.
JOLT_API int JPH_MeshShape_GetTrianglesNext(const JPH_MeshShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials);

// See Shape::GetSubmergedVolume
/// Generated from method `JPH::MeshShape::GetSubmergedVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inSurface` can not be null. It is a single object.
/// Parameter `outTotalVolume` can not be null. It is a single object.
/// Parameter `outSubmergedVolume` can not be null. It is a single object.
/// Parameter `outCenterOfBuoyancy` can not be null. It is a single object.
/// Parameter `inBaseOffset` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_GetSubmergedVolume(const JPH_MeshShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset);

// See Shape::GetStats
/// Generated from method `JPH::MeshShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_MeshShape_GetStats(const JPH_MeshShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::MeshShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MeshShape_GetVolume(const JPH_MeshShape *_this);

// When MeshShape::mPerTriangleUserData is true, this function can be used to retrieve the user data that was stored in the mesh shape.
/// Generated from method `JPH::MeshShape::GetTriangleUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API unsigned int JPH_MeshShape_GetTriangleUserData(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID);

// Register shape functions with the registry
/// Generated from method `JPH::MeshShape::sRegister`.
JOLT_API void JPH_MeshShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::MeshShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_MeshShape_GetUserData(const JPH_MeshShape *_this);

/// Generated from method `JPH::MeshShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_SetUserData(JPH_MeshShape *_this, uint64_t inUserData);

/// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
/// Generated from method `JPH::MeshShape::GetCenterOfMass`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MeshShape_GetCenterOfMass(const JPH_MeshShape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::MeshShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_MeshShape_GetLeafShape(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::MeshShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_MeshShape_GetSubShapeUserData(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the direct child sub shape and its transform for a sub shape ID.
/// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
/// @param inPositionCOM The position of the center of mass of this shape
/// @param inRotation The orientation of this shape
/// @param inScale Scale in local space of the shape (scales relative to its center of mass)
/// @param outRemainder The remainder of the sub shape ID after removing the sub shape
/// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
/// Generated from method `JPH::MeshShape::GetSubShapeTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `inPositionCOM` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_MeshShape_GetSubShapeTransformedShape(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder);

/// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::MeshShape::DrawGetSupportFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_DrawGetSupportFunction(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection);

/// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
/// Generated from method `JPH::MeshShape::DrawGetSupportingFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenterOfMassTransform` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_DrawGetSupportingFace(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale);

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
/// Generated from method `JPH::MeshShape::IsValidScale`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
JOLT_API bool JPH_MeshShape_IsValidScale(const JPH_MeshShape *_this, const JPH_Vec3 *inScale);

/// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
/// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
/// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
/// @param inScale Local space scale for this shape.
/// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
/// Generated from method `JPH::MeshShape::MakeScaleValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inScale` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MeshShape_MakeScaleValid(const JPH_MeshShape *_this, const JPH_Vec3 *inScale);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::MeshShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_SetEmbedded(const JPH_MeshShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::MeshShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MeshShape_GetRefCount(const JPH_MeshShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::MeshShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_AddRef(const JPH_MeshShape *_this);

/// Generated from method `JPH::MeshShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MeshShape_Release(const JPH_MeshShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::MeshShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_MeshShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
