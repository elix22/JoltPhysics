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
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// Class that can construct shapes and that is serializable using the ObjectStream system.
/// Can be used to store shape data in 'uncooked' form (i.e. in a form that is still human readable and authorable).
/// Once the shape has been created using the Create() function, the data will be moved into the Shape class
/// in a form that is optimized for collision detection. After this, the ShapeSettings object is no longer needed
/// and can be destroyed. Each shape class has a derived class of the ShapeSettings object to store shape specific
/// data.
/// Generated from class `JPH::ShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShapeSettings`
///     `JPH::ConvexShapeSettings`
///     `JPH::DecoratedShapeSettings`
///     `JPH::EmptyShapeSettings`
///     `JPH::HeightFieldShapeSettings`
///     `JPH::MeshShapeSettings`
///     `JPH::PlaneShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::BoxShapeSettings`
///     `JPH::CapsuleShapeSettings`
///     `JPH::ConvexHullShapeSettings`
///     `JPH::CylinderShapeSettings`
///     `JPH::MutableCompoundShapeSettings`
///     `JPH::OffsetCenterOfMassShapeSettings`
///     `JPH::RotatedTranslatedShapeSettings`
///     `JPH::ScaledShapeSettings`
///     `JPH::SphereShapeSettings`
///     `JPH::StaticCompoundShapeSettings`
///     `JPH::TaperedCapsuleShapeSettings`
///     `JPH::TaperedCylinderShapeSettings`
///     `JPH::TriangleShapeSettings`
typedef struct JPH_ShapeSettings JPH_ShapeSettings;

/// An opaque buffer that holds shape specific information during GetTrianglesStart/Next.
/// Generated from class `JPH::Shape::GetTrianglesContext`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Shape_GetTrianglesContext JPH_Shape_GetTrianglesContext;

/// Class that holds information about the shape that can be used for logging / data collection purposes
/// Generated from class `JPH::Shape::Stats`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Shape_Stats JPH_Shape_Stats;

/// Base class for all shapes (collision volume of a body). Defines a virtual interface for collision detection.
/// Generated from class `JPH::Shape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CompoundShape`
///     `JPH::ConvexShape`
///     `JPH::DecoratedShape`
///     `JPH::EmptyShape`
///     `JPH::HeightFieldShape`
///     `JPH::MeshShape`
///     `JPH::PlaneShape`
///   Indirect: (non-virtual)
///     `JPH::BoxShape`
///     `JPH::CapsuleShape`
///     `JPH::ConvexHullShape`
///     `JPH::CylinderShape`
///     `JPH::MutableCompoundShape`
///     `JPH::OffsetCenterOfMassShape`
///     `JPH::RotatedTranslatedShape`
///     `JPH::ScaledShape`
///     `JPH::SphereShape`
///     `JPH::StaticCompoundShape`
///     `JPH::TaperedCapsuleShape`
///     `JPH::TaperedCylinderShape`
///     `JPH::TriangleShape`
typedef struct JPH_Shape JPH_Shape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ShapeSettings_Get_mUserData(const JPH_ShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ShapeSettings_Set_mUserData(JPH_ShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::ShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ShapeSettings_GetMutable_mUserData(JPH_ShapeSettings *_this);

/// Destroys a heap-allocated instance of `JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeSettings_Destroy(const JPH_ShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ShapeSettings_DestroyArray(const JPH_ShapeSettings *_this);

/// Generated from method `JPH::ShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::ShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::ShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::ShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_ClearCachedResult(JPH_ShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_SetEmbedded(const JPH_ShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ShapeSettings_GetRefCount(const JPH_ShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_AddRef(const JPH_ShapeSettings *_this);

/// Generated from method `JPH::ShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ShapeSettings_Release(const JPH_ShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ShapeSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_OffsetPtr(const JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_OffsetMutablePtr(JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::ShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::ShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::Shape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_Shape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Destroys a heap-allocated instance of `JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Destroy(const JPH_Shape *_this);

/// Destroys a heap-allocated array of `JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_DestroyArray(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::operator new`.
JOLT_API void *Jolt_new_JPH_Shape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr(void *inPointer);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Shape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Shape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr(void *inPointer);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::Shape::operator new`.
JOLT_API void *Jolt_new_JPH_Shape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Shape::operator delete`.
JOLT_API void Jolt_delete_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Shape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Shape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::Shape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// User data (to be used freely by the application)
/// Generated from method `JPH::Shape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_Shape_GetUserData(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_SetUserData(JPH_Shape *_this, uint64_t inUserData);

/// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
/// Generated from method `JPH::Shape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Shape_MustBeStatic(const JPH_Shape *_this);

/// Get local bounding box including convex radius, this box is centered around the center of mass rather than the world transform
/// Generated from method `JPH::Shape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_Shape_GetLocalBounds(const JPH_Shape *_this);

/// Get the max number of sub shape ID bits that are needed to be able to address any leaf shape in this shape. Used mainly for checking that it is smaller or equal than SubShapeID::MaxBits.
/// Generated from method `JPH::Shape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Shape_GetSubShapeIDBitsRecursive(const JPH_Shape *_this);

/// Returns the radius of the biggest sphere that fits entirely in the shape. In case this shape consists of multiple sub shapes, it returns the smallest sphere of the parts.
/// This can be used as a measure of how far the shape can be moved without risking going through geometry.
/// Generated from method `JPH::Shape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Shape_GetInnerRadius(const JPH_Shape *_this);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::Shape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_Shape_GetLeafShape(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the material assigned to a particular sub shape ID
/// Generated from method `JPH::Shape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_Shape_GetMaterial(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::Shape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_Shape_GetSubShapeUserData(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
/// Generated from method `JPH::Shape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_GetStats(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Shape_GetVolume(const JPH_Shape *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::Shape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_SetEmbedded(const JPH_Shape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::Shape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Shape_GetRefCount(const JPH_Shape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::Shape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_AddRef(const JPH_Shape *_this);

/// Generated from method `JPH::Shape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Shape_Release(const JPH_Shape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::Shape::sInternalGetRefCountOffset`.
JOLT_API int JPH_Shape_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_OffsetPtr(const JPH_Shape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_OffsetMutablePtr(JPH_Shape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_Shape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Shape_UpcastTo_JPH_NonCopyable(const JPH_Shape *object);

/// Upcasts an instance of `JPH::Shape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Shape_MutableUpcastTo_JPH_NonCopyable(JPH_Shape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Shape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Returns a pointer to a member variable of class `JPH::Shape::GetTrianglesContext` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned char *JPH_Shape_GetTrianglesContext_Get_mData(const JPH_Shape_GetTrianglesContext *_this);

/// Returns a mutable pointer to a member variable of class `JPH::Shape::GetTrianglesContext` named `mData`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned char *JPH_Shape_GetTrianglesContext_GetMutable_mData(JPH_Shape_GetTrianglesContext *_this);

/// Returns the size of the array member of class `JPH::Shape::GetTrianglesContext` named `mData`. The size is `4288`.
JOLT_API size_t JPH_Shape_GetTrianglesContext_GetSize_mData(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_GetTrianglesContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Shape_GetTrianglesContext_DestroyArray()`.
/// Use `JPH_Shape_GetTrianglesContext_OffsetMutablePtr()` and `JPH_Shape_GetTrianglesContext_OffsetPtr()` to access the array elements.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetPtr(const JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetMutablePtr(JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_GetTrianglesContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_ConstructFromAnother(const JPH_Shape_GetTrianglesContext *_other);

/// Destroys a heap-allocated instance of `JPH_Shape_GetTrianglesContext`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_GetTrianglesContext_Destroy(const JPH_Shape_GetTrianglesContext *_this);

/// Destroys a heap-allocated array of `JPH_Shape_GetTrianglesContext`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_GetTrianglesContext_DestroyArray(const JPH_Shape_GetTrianglesContext *_this);

/// Generated from method `JPH::Shape::GetTrianglesContext::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_AssignFromAnother(JPH_Shape_GetTrianglesContext *_this, const JPH_Shape_GetTrianglesContext *_other);

///< Amount of memory used by this shape (size in bytes)
/// Returns a pointer to a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned long *JPH_Shape_Stats_Get_mSizeBytes(const JPH_Shape_Stats *_this);

///< Amount of memory used by this shape (size in bytes)
/// Modifies a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSizeBytes`.
/// When this function is called, this object will drop object references it held previously in `mSizeBytes`.
JOLT_API void JPH_Shape_Stats_Set_mSizeBytes(JPH_Shape_Stats *_this, unsigned long value);

///< Amount of memory used by this shape (size in bytes)
/// Returns a mutable pointer to a member variable of class `JPH::Shape::Stats` named `mSizeBytes`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned long *JPH_Shape_Stats_GetMutable_mSizeBytes(JPH_Shape_Stats *_this);

///< Number of triangles in this shape (when applicable)
/// Returns a pointer to a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_Shape_Stats_Get_mNumTriangles(const JPH_Shape_Stats *_this);

///< Number of triangles in this shape (when applicable)
/// Modifies a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumTriangles`.
/// When this function is called, this object will drop object references it held previously in `mNumTriangles`.
JOLT_API void JPH_Shape_Stats_Set_mNumTriangles(JPH_Shape_Stats *_this, unsigned int value);

///< Number of triangles in this shape (when applicable)
/// Returns a mutable pointer to a member variable of class `JPH::Shape::Stats` named `mNumTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_Shape_Stats_GetMutable_mNumTriangles(JPH_Shape_Stats *_this);

/// Generated from constructor `JPH::Shape::Stats::Stats`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_ConstructFromAnother(const JPH_Shape_Stats *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Shape_Stats *JPH_Shape_Stats_OffsetPtr(const JPH_Shape_Stats *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_OffsetMutablePtr(JPH_Shape_Stats *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Shape::Stats::Stats`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_Construct(unsigned long inSizeBytes, unsigned int inNumTriangles);

/// Destroys a heap-allocated instance of `JPH_Shape_Stats`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Stats_Destroy(const JPH_Shape_Stats *_this);

/// Destroys a heap-allocated array of `JPH_Shape_Stats`. Does nothing if the pointer is null.
JOLT_API void JPH_Shape_Stats_DestroyArray(const JPH_Shape_Stats *_this);

/// Generated from method `JPH::Shape::Stats::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Shape_Stats *JPH_Shape_Stats_AssignFromAnother(JPH_Shape_Stats *_this, const JPH_Shape_Stats *_other);

#ifdef __cplusplus
} // extern "C"
#endif
