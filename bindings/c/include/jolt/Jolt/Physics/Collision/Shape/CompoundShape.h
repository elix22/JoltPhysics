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


/// Generated from class `JPH::CompoundShapeSettings::SubShapeSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CompoundShapeSettings_SubShapeSettings JPH_CompoundShapeSettings_SubShapeSettings;

/// Base class settings to construct a compound shape
/// Generated from class `JPH::CompoundShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::MutableCompoundShapeSettings`
///     `JPH::StaticCompoundShapeSettings`
typedef struct JPH_CompoundShapeSettings JPH_CompoundShapeSettings;

/// Generated from class `JPH::CompoundShape::SubShape`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CompoundShape_SubShape JPH_CompoundShape_SubShape;

/// Base class for a compound shape
/// Generated from class `JPH::CompoundShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::MutableCompoundShape`
///     `JPH::StaticCompoundShape`
typedef struct JPH_CompoundShape JPH_CompoundShape;

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::CompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_CompoundShapeSettings_Get_mUserData(const JPH_CompoundShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::CompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_CompoundShapeSettings_Set_mUserData(JPH_CompoundShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::CompoundShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_CompoundShapeSettings_GetMutable_mUserData(JPH_CompoundShapeSettings *_this);

/// Destroys a heap-allocated instance of `JPH_CompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShapeSettings_Destroy(const JPH_CompoundShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_CompoundShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShapeSettings_DestroyArray(const JPH_CompoundShapeSettings *_this);

/// Generated from method `JPH::CompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CompoundShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::CompoundShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShapeSettings_ClearCachedResult(JPH_CompoundShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CompoundShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShapeSettings_SetEmbedded(const JPH_CompoundShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CompoundShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShapeSettings_GetRefCount(const JPH_CompoundShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CompoundShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShapeSettings_AddRef(const JPH_CompoundShapeSettings *_this);

/// Generated from method `JPH::CompoundShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShapeSettings_Release(const JPH_CompoundShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CompoundShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_CompoundShapeSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_OffsetPtr(const JPH_CompoundShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_OffsetMutablePtr(JPH_CompoundShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_CompoundShapeSettings *object);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_CompoundShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_CompoundShapeSettings *object);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_CompoundShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_CompoundShapeSettings *object);

/// Upcasts an instance of `JPH::CompoundShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_CompoundShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::CompoundShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// User data value (can be used by the application for any purpose).
/// Note this value can be retrieved through GetSubShape(...).mUserData, not through GetSubShapeUserData(...) as that returns Shape::GetUserData() of the leaf shape.
/// Use GetSubShapeIndexFromID get a shape index from a SubShapeID to pass to GetSubShape.
/// Returns a pointer to a member variable of class `JPH::CompoundShapeSettings::SubShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData(const JPH_CompoundShapeSettings_SubShapeSettings *_this);

/// User data value (can be used by the application for any purpose).
/// Note this value can be retrieved through GetSubShape(...).mUserData, not through GetSubShapeUserData(...) as that returns Shape::GetUserData() of the leaf shape.
/// Use GetSubShapeIndexFromID get a shape index from a SubShapeID to pass to GetSubShape.
/// Modifies a member variable of class `JPH::CompoundShapeSettings::SubShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_CompoundShapeSettings_SubShapeSettings_Set_mUserData(JPH_CompoundShapeSettings_SubShapeSettings *_this, unsigned int value);

/// User data value (can be used by the application for any purpose).
/// Note this value can be retrieved through GetSubShape(...).mUserData, not through GetSubShapeUserData(...) as that returns Shape::GetUserData() of the leaf shape.
/// Use GetSubShapeIndexFromID get a shape index from a SubShapeID to pass to GetSubShape.
/// Returns a mutable pointer to a member variable of class `JPH::CompoundShapeSettings::SubShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData(JPH_CompoundShapeSettings_SubShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CompoundShapeSettings_SubShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CompoundShapeSettings_SubShapeSettings_DestroyArray()`.
/// Use `JPH_CompoundShapeSettings_SubShapeSettings_OffsetMutablePtr()` and `JPH_CompoundShapeSettings_SubShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CompoundShapeSettings_SubShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CompoundShapeSettings_SubShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShapeSettings_SubShapeSettings_Destroy(const JPH_CompoundShapeSettings_SubShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_CompoundShapeSettings_SubShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShapeSettings_SubShapeSettings_DestroyArray(const JPH_CompoundShapeSettings_SubShapeSettings *_this);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(JPH_CompoundShapeSettings_SubShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *_other);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::CompoundShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Destroys a heap-allocated instance of `JPH_CompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShape_Destroy(const JPH_CompoundShape *_this);

/// Destroys a heap-allocated array of `JPH_CompoundShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShape_DestroyArray(const JPH_CompoundShape *_this);

/// Generated from method `JPH::CompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShape_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShape_size_t(unsigned long inCount);

/// Generated from method `JPH::CompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShape_void_ptr(void *inPointer);

/// Generated from method `JPH::CompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CompoundShape::operator new`.
JOLT_API void *Jolt_new_JPH_CompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShape::operator delete`.
JOLT_API void Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CompoundShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CompoundShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::MustBeStatic
/// Generated from method `JPH::CompoundShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CompoundShape_MustBeStatic(const JPH_CompoundShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::CompoundShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_CompoundShape_GetLocalBounds(const JPH_CompoundShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::CompoundShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShape_GetSubShapeIDBitsRecursive(const JPH_CompoundShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::CompoundShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CompoundShape_GetInnerRadius(const JPH_CompoundShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::CompoundShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_CompoundShape_GetMaterial(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

// See Shape::GetLeafShape
/// Generated from method `JPH::CompoundShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_CompoundShape_GetLeafShape(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetSubShapeUserData
/// Generated from method `JPH::CompoundShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_CompoundShape_GetSubShapeUserData(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Get which sub shape's bounding boxes overlap with an axis aligned box
/// @param inBox The axis aligned box to test against (relative to the center of mass of this shape)
/// @param outSubShapeIndices Buffer where to place the indices of the sub shapes that intersect
/// @param inMaxSubShapeIndices How many indices will fit in the buffer (normally you'd provide a buffer of GetNumSubShapes() indices)
/// @return How many indices were placed in outSubShapeIndices
/// Generated from method `JPH::CompoundShape::GetIntersectingSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
JOLT_API int JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_CompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices);

/// Get the total number of sub shapes
/// Generated from method `JPH::CompoundShape::GetNumSubShapes`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShape_GetNumSubShapes(const JPH_CompoundShape *_this);

/// Access to a particular sub shape
/// Generated from method `JPH::CompoundShape::GetSubShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CompoundShape_SubShape *JPH_CompoundShape_GetSubShape(const JPH_CompoundShape *_this, unsigned int inIdx);

/// Get the user data associated with a shape in this compound
/// Generated from method `JPH::CompoundShape::GetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShape_GetCompoundUserData(const JPH_CompoundShape *_this, unsigned int inIdx);

/// Set the user data associated with a shape in this compound
/// Generated from method `JPH::CompoundShape::SetCompoundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShape_SetCompoundUserData(JPH_CompoundShape *_this, unsigned int inIdx, unsigned int inUserData);

/// Check if a sub shape ID is still valid for this shape
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @return True if the ID is valid, false if not
/// Generated from method `JPH::CompoundShape::IsSubShapeIDValid`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API bool JPH_CompoundShape_IsSubShapeIDValid(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Convert SubShapeID to sub shape index
/// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
/// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
/// @return The index of the sub shape of this compound
/// Generated from method `JPH::CompoundShape::GetSubShapeIndexFromID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShape_GetSubShapeIndexFromID(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

// See Shape::GetVolume
/// Generated from method `JPH::CompoundShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CompoundShape_GetVolume(const JPH_CompoundShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::CompoundShape::sRegister`.
JOLT_API void JPH_CompoundShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::CompoundShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CompoundShape_GetUserData(const JPH_CompoundShape *_this);

/// Generated from method `JPH::CompoundShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShape_SetUserData(JPH_CompoundShape *_this, uint64_t inUserData);

/// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
/// Generated from method `JPH::CompoundShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_CompoundShape_GetStats(const JPH_CompoundShape *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CompoundShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShape_SetEmbedded(const JPH_CompoundShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CompoundShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CompoundShape_GetRefCount(const JPH_CompoundShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CompoundShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShape_AddRef(const JPH_CompoundShape *_this);

/// Generated from method `JPH::CompoundShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CompoundShape_Release(const JPH_CompoundShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CompoundShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_CompoundShape_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_CompoundShape_OffsetPtr(const JPH_CompoundShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_CompoundShape_OffsetMutablePtr(JPH_CompoundShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_CompoundShape *object);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_CompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_CompoundShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CompoundShape_UpcastTo_JPH_NonCopyable(const JPH_CompoundShape *object);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_CompoundShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_CompoundShape_UpcastTo_JPH_Shape(const JPH_CompoundShape *object);

/// Upcasts an instance of `JPH::CompoundShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_CompoundShape_MutableUpcastTo_JPH_Shape(JPH_CompoundShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::CompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

///< User data value (put here because it falls in padding bytes)
/// Returns a pointer to a member variable of class `JPH::CompoundShape::SubShape` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_CompoundShape_SubShape_Get_mUserData(const JPH_CompoundShape_SubShape *_this);

///< User data value (put here because it falls in padding bytes)
/// Modifies a member variable of class `JPH::CompoundShape::SubShape` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_CompoundShape_SubShape_Set_mUserData(JPH_CompoundShape_SubShape *_this, unsigned int value);

///< User data value (put here because it falls in padding bytes)
/// Returns a mutable pointer to a member variable of class `JPH::CompoundShape::SubShape` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_CompoundShape_SubShape_GetMutable_mUserData(JPH_CompoundShape_SubShape *_this);

///< If mRotation is close to identity (put here because it falls in padding bytes)
/// Returns a pointer to a member variable of class `JPH::CompoundShape::SubShape` named `mIsRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CompoundShape_SubShape_Get_mIsRotationIdentity(const JPH_CompoundShape_SubShape *_this);

///< If mRotation is close to identity (put here because it falls in padding bytes)
/// Modifies a member variable of class `JPH::CompoundShape::SubShape` named `mIsRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsRotationIdentity`.
JOLT_API void JPH_CompoundShape_SubShape_Set_mIsRotationIdentity(JPH_CompoundShape_SubShape *_this, bool value);

///< If mRotation is close to identity (put here because it falls in padding bytes)
/// Returns a mutable pointer to a member variable of class `JPH::CompoundShape::SubShape` named `mIsRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity(JPH_CompoundShape_SubShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CompoundShape_SubShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CompoundShape_SubShape_DestroyArray()`.
/// Use `JPH_CompoundShape_SubShape_OffsetMutablePtr()` and `JPH_CompoundShape_SubShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CompoundShape_SubShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CompoundShape_SubShape *_other);

/// Destroys a heap-allocated instance of `JPH_CompoundShape_SubShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShape_SubShape_Destroy(const JPH_CompoundShape_SubShape *_this);

/// Destroys a heap-allocated array of `JPH_CompoundShape_SubShape`. Does nothing if the pointer is null.
JOLT_API void JPH_CompoundShape_SubShape_DestroyArray(const JPH_CompoundShape_SubShape *_this);

/// Generated from method `JPH::CompoundShape::SubShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_AssignFromAnother(JPH_CompoundShape_SubShape *_this, Jolt_PassBy _other_pass_by, JPH_CompoundShape_SubShape *_other);

#ifdef __cplusplus
} // extern "C"
#endif
