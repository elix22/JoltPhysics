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
typedef struct JPH_TempAllocator JPH_TempAllocator; // Defined in `#include <jolt/Jolt/Core/TempAllocator.h>`.


/// Class that constructs a HeightFieldShape
/// Generated from class `JPH::HeightFieldShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ShapeSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_HeightFieldShapeSettings JPH_HeightFieldShapeSettings;

/// A height field shape. Cannot be used as a dynamic object.
///
/// Note: If you're using HeightFieldShape and are querying data while modifying the shape you'll have a race condition.
/// In this case it is best to create a new HeightFieldShape using the Clone function. You replace the shape on a body using BodyInterface::SetShape.
/// If a query is still working on the old shape, it will have taken a reference and keep the old shape alive until the query finishes.
/// Generated from class `JPH::HeightFieldShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Shape>`
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_HeightFieldShape JPH_HeightFieldShape;

/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mSampleCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HeightFieldShapeSettings_Get_mSampleCount(const JPH_HeightFieldShapeSettings *_this);

/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mSampleCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSampleCount`.
/// When this function is called, this object will drop object references it held previously in `mSampleCount`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mSampleCount(JPH_HeightFieldShapeSettings *_this, unsigned int value);

/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mSampleCount`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mSampleCount(JPH_HeightFieldShapeSettings *_this);

/// Artificial minimal value of mHeightSamples, used for compression and can be used to update the terrain after creating with lower height values. If there are any lower values in mHeightSamples, this value will be ignored.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMinHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HeightFieldShapeSettings_Get_mMinHeightValue(const JPH_HeightFieldShapeSettings *_this);

/// Artificial minimal value of mHeightSamples, used for compression and can be used to update the terrain after creating with lower height values. If there are any lower values in mHeightSamples, this value will be ignored.
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mMinHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinHeightValue`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mMinHeightValue(JPH_HeightFieldShapeSettings *_this, float value);

/// Artificial minimal value of mHeightSamples, used for compression and can be used to update the terrain after creating with lower height values. If there are any lower values in mHeightSamples, this value will be ignored.
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMinHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue(JPH_HeightFieldShapeSettings *_this);

/// Artificial maximum value of mHeightSamples, used for compression and can be used to update the terrain after creating with higher height values. If there are any higher values in mHeightSamples, this value will be ignored.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMaxHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HeightFieldShapeSettings_Get_mMaxHeightValue(const JPH_HeightFieldShapeSettings *_this);

/// Artificial maximum value of mHeightSamples, used for compression and can be used to update the terrain after creating with higher height values. If there are any higher values in mHeightSamples, this value will be ignored.
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mMaxHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxHeightValue`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mMaxHeightValue(JPH_HeightFieldShapeSettings *_this, float value);

/// Artificial maximum value of mHeightSamples, used for compression and can be used to update the terrain after creating with higher height values. If there are any higher values in mHeightSamples, this value will be ignored.
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMaxHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue(JPH_HeightFieldShapeSettings *_this);

/// When bigger than mMaterials.size() the internal material list will be preallocated to support this number of materials.
/// This avoids reallocations when calling HeightFieldShape::SetMaterials with new materials later.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMaterialsCapacity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity(const JPH_HeightFieldShapeSettings *_this);

/// When bigger than mMaterials.size() the internal material list will be preallocated to support this number of materials.
/// This avoids reallocations when calling HeightFieldShape::SetMaterials with new materials later.
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mMaterialsCapacity`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaterialsCapacity`.
/// When this function is called, this object will drop object references it held previously in `mMaterialsCapacity`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mMaterialsCapacity(JPH_HeightFieldShapeSettings *_this, unsigned int value);

/// When bigger than mMaterials.size() the internal material list will be preallocated to support this number of materials.
/// This avoids reallocations when calling HeightFieldShape::SetMaterials with new materials later.
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mMaterialsCapacity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity(JPH_HeightFieldShapeSettings *_this);

/// The heightfield is divided in blocks of mBlockSize * mBlockSize * 2 triangles and the acceleration structure culls blocks only,
/// bigger block sizes reduce memory consumption but also reduce query performance. Sensible values are [2, 8], does not need to be
/// a power of 2. Note that at run-time we'll perform one more grid subdivision, so the effective block size is half of what is provided here.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mBlockSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HeightFieldShapeSettings_Get_mBlockSize(const JPH_HeightFieldShapeSettings *_this);

/// The heightfield is divided in blocks of mBlockSize * mBlockSize * 2 triangles and the acceleration structure culls blocks only,
/// bigger block sizes reduce memory consumption but also reduce query performance. Sensible values are [2, 8], does not need to be
/// a power of 2. Note that at run-time we'll perform one more grid subdivision, so the effective block size is half of what is provided here.
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mBlockSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBlockSize`.
/// When this function is called, this object will drop object references it held previously in `mBlockSize`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mBlockSize(JPH_HeightFieldShapeSettings *_this, unsigned int value);

/// The heightfield is divided in blocks of mBlockSize * mBlockSize * 2 triangles and the acceleration structure culls blocks only,
/// bigger block sizes reduce memory consumption but also reduce query performance. Sensible values are [2, 8], does not need to be
/// a power of 2. Note that at run-time we'll perform one more grid subdivision, so the effective block size is half of what is provided here.
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mBlockSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mBlockSize(JPH_HeightFieldShapeSettings *_this);

/// How many bits per sample to use to compress the height field. Can be in the range [1, 8].
/// Note that each sample is compressed relative to the min/max value of its block of mBlockSize * mBlockSize pixels so the effective precision is higher.
/// Also note that increasing mBlockSize saves more memory than reducing the amount of bits per sample.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mBitsPerSample`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_HeightFieldShapeSettings_Get_mBitsPerSample(const JPH_HeightFieldShapeSettings *_this);

/// How many bits per sample to use to compress the height field. Can be in the range [1, 8].
/// Note that each sample is compressed relative to the min/max value of its block of mBlockSize * mBlockSize pixels so the effective precision is higher.
/// Also note that increasing mBlockSize saves more memory than reducing the amount of bits per sample.
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mBitsPerSample`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBitsPerSample`.
/// When this function is called, this object will drop object references it held previously in `mBitsPerSample`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mBitsPerSample(JPH_HeightFieldShapeSettings *_this, unsigned int value);

/// How many bits per sample to use to compress the height field. Can be in the range [1, 8].
/// Note that each sample is compressed relative to the min/max value of its block of mBlockSize * mBlockSize pixels so the effective precision is higher.
/// Also note that increasing mBlockSize saves more memory than reducing the amount of bits per sample.
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mBitsPerSample`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample(JPH_HeightFieldShapeSettings *_this);

// cos(5 degrees)
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle(const JPH_HeightFieldShapeSettings *_this);

// cos(5 degrees)
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mActiveEdgeCosThresholdAngle`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mActiveEdgeCosThresholdAngle(JPH_HeightFieldShapeSettings *_this, float value);

// cos(5 degrees)
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mActiveEdgeCosThresholdAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(JPH_HeightFieldShapeSettings *_this);

/// User data (to be used freely by the application)
/// Returns a pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_HeightFieldShapeSettings_Get_mUserData(const JPH_HeightFieldShapeSettings *_this);

/// User data (to be used freely by the application)
/// Modifies a member variable of class `JPH::HeightFieldShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_HeightFieldShapeSettings_Set_mUserData(JPH_HeightFieldShapeSettings *_this, uint64_t value);

/// User data (to be used freely by the application)
/// Returns a mutable pointer to a member variable of class `JPH::HeightFieldShapeSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_HeightFieldShapeSettings_GetMutable_mUserData(JPH_HeightFieldShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HeightFieldShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_HeightFieldShapeSettings_DestroyArray()`.
/// Use `JPH_HeightFieldShapeSettings_OffsetMutablePtr()` and `JPH_HeightFieldShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_OffsetPtr(const JPH_HeightFieldShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_OffsetMutablePtr(JPH_HeightFieldShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_HeightFieldShapeSettings *object);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_HeightFieldShapeSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_HeightFieldShapeSettings *object);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::RefTarget<JPH::ShapeSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_HeightFieldShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ShapeSettings>` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::ShapeSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ShapeSettings *JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_HeightFieldShapeSettings *object);

/// Upcasts an instance of `JPH::HeightFieldShapeSettings` to its base class `JPH::ShapeSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ShapeSettings *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_HeightFieldShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object);

/// Downcasts an instance of `JPH::ShapeSettings` to a derived class `JPH::HeightFieldShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object);

/// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HeightFieldShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_HeightFieldShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_HeightFieldShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_HeightFieldShapeSettings_Destroy(const JPH_HeightFieldShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_HeightFieldShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_HeightFieldShapeSettings_DestroyArray(const JPH_HeightFieldShapeSettings *_this);

/// Generated from method `JPH::HeightFieldShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_AssignFromAnother(JPH_HeightFieldShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_HeightFieldShapeSettings *_other);

/// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::HeightFieldShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::HeightFieldShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Determine the minimal and maximal value of mHeightSamples (will ignore cNoCollisionValue)
/// @param outMinValue The minimal value of mHeightSamples or FLT_MAX if no samples have collision
/// @param outMaxValue The maximal value of mHeightSamples or -FLT_MAX if no samples have collision
/// @param outQuantizationScale (value - outMinValue) * outQuantizationScale quantizes a height sample to 16 bits
/// Generated from method `JPH::HeightFieldShapeSettings::DetermineMinAndMaxSample`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outMinValue` can not be null. It is a single object.
/// Parameter `outMaxValue` can not be null. It is a single object.
/// Parameter `outQuantizationScale` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample(const JPH_HeightFieldShapeSettings *_this, float *outMinValue, float *outMaxValue, float *outQuantizationScale);

/// Given mBlockSize, mSampleCount and mHeightSamples, calculate the amount of bits needed to stay below absolute error inMaxError
/// @param inMaxError Maximum allowed error in mHeightSamples after compression (note that this does not take mScale.Y into account)
/// @return Needed bits per sample in the range [1, 8].
/// Generated from method `JPH::HeightFieldShapeSettings::CalculateBitsPerSampleForError`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError(const JPH_HeightFieldShapeSettings *_this, float inMaxError);

/// When creating a shape, the result is cached so that calling Create() again will return the same shape.
/// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
/// Generated from method `JPH::HeightFieldShapeSettings::ClearCachedResult`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShapeSettings_ClearCachedResult(JPH_HeightFieldShapeSettings *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::HeightFieldShapeSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShapeSettings_SetEmbedded(const JPH_HeightFieldShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::HeightFieldShapeSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShapeSettings_GetRefCount(const JPH_HeightFieldShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::HeightFieldShapeSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShapeSettings_AddRef(const JPH_HeightFieldShapeSettings *_this);

/// Generated from method `JPH::HeightFieldShapeSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShapeSettings_Release(const JPH_HeightFieldShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::HeightFieldShapeSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset(void);

/// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
/// Returns a pointer to a member variable of class `JPH::HeightFieldShape` named `cGetTrianglesMinTrianglesRequested`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const int *JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_HeightFieldShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_HeightFieldShape_DestroyArray()`.
/// Use `JPH_HeightFieldShape_OffsetMutablePtr()` and `JPH_HeightFieldShape_OffsetPtr()` to access the array elements.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShape *JPH_HeightFieldShape_OffsetPtr(const JPH_HeightFieldShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_OffsetMutablePtr(JPH_HeightFieldShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_HeightFieldShape *object);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::RefTarget<JPH::Shape>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_HeightFieldShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_HeightFieldShape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Shape>` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(const JPH_HeightFieldShape *object);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_HeightFieldShape_MutableUpcastTo_JPH_NonCopyable(JPH_HeightFieldShape *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::Shape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Shape *JPH_HeightFieldShape_UpcastTo_JPH_Shape(const JPH_HeightFieldShape *object);

/// Upcasts an instance of `JPH::HeightFieldShape` to its base class `JPH::Shape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Shape *JPH_HeightFieldShape_MutableUpcastTo_JPH_Shape(JPH_HeightFieldShape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object);

/// Downcasts an instance of `JPH::Shape` to a derived class `JPH::HeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object);

/// Destroys a heap-allocated instance of `JPH_HeightFieldShape`. Does nothing if the pointer is null.
JOLT_API void JPH_HeightFieldShape_Destroy(const JPH_HeightFieldShape *_this);

/// Destroys a heap-allocated array of `JPH_HeightFieldShape`. Does nothing if the pointer is null.
JOLT_API void JPH_HeightFieldShape_DestroyArray(const JPH_HeightFieldShape *_this);

/// Generated from method `JPH::HeightFieldShape::operator new`.
JOLT_API void *Jolt_new_JPH_HeightFieldShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::HeightFieldShape::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShape_void_ptr(void *inPointer);

/// Generated from method `JPH::HeightFieldShape::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::HeightFieldShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HeightFieldShape_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::HeightFieldShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShape_void_ptr(void *inPointer);

/// Generated from method `JPH::HeightFieldShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShape_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::HeightFieldShape::operator new`.
JOLT_API void *Jolt_new_JPH_HeightFieldShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::HeightFieldShape::operator delete`.
JOLT_API void Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::HeightFieldShape::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_HeightFieldShape_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::HeightFieldShape::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See Shape::MustBeStatic
/// Generated from method `JPH::HeightFieldShape::MustBeStatic`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HeightFieldShape_MustBeStatic(const JPH_HeightFieldShape *_this);

/// Get the size of the height field. Note that this will always be rounded up to the nearest multiple of GetBlockSize().
/// Generated from method `JPH::HeightFieldShape::GetSampleCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShape_GetSampleCount(const JPH_HeightFieldShape *_this);

/// Get the size of a block
/// Generated from method `JPH::HeightFieldShape::GetBlockSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShape_GetBlockSize(const JPH_HeightFieldShape *_this);

// See Shape::GetLocalBounds
/// Generated from method `JPH::HeightFieldShape::GetLocalBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_HeightFieldShape_GetLocalBounds(const JPH_HeightFieldShape *_this);

// See Shape::GetSubShapeIDBitsRecursive
/// Generated from method `JPH::HeightFieldShape::GetSubShapeIDBitsRecursive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShape_GetSubShapeIDBitsRecursive(const JPH_HeightFieldShape *_this);

// See Shape::GetInnerRadius
/// Generated from method `JPH::HeightFieldShape::GetInnerRadius`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HeightFieldShape_GetInnerRadius(const JPH_HeightFieldShape *_this);

// See Shape::GetMaterial
/// Generated from method `JPH::HeightFieldShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_HeightFieldShape_GetMaterial_1(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Overload to get the material at a particular location
/// Generated from method `JPH::HeightFieldShape::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_HeightFieldShape_GetMaterial_2(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY);

/// Check if height field at sampled location (inX, inY) has collision (has a hole or not)
/// Generated from method `JPH::HeightFieldShape::IsNoCollision`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_HeightFieldShape_IsNoCollision(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY);

/// Returns the coordinates of the triangle that a sub shape ID represents
/// @param inSubShapeID The sub shape ID to decode
/// @param outX X coordinate of the triangle (in the range [0, mSampleCount - 2])
/// @param outY Y coordinate of the triangle (in the range [0, mSampleCount - 2])
/// @param outTriangleIndex Triangle within the quad (0 = lower triangle or 1 = upper triangle)
/// Generated from method `JPH::HeightFieldShape::GetSubShapeCoordinates`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outX` can not be null. It is a single object.
/// Parameter `outY` can not be null. It is a single object.
/// Parameter `outTriangleIndex` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_GetSubShapeCoordinates(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID, unsigned int *outX, unsigned int *outY, unsigned int *outTriangleIndex);

/// Get the range of height values that this height field can encode. Can be used to determine the allowed range when setting the height values with SetHeights.
/// Generated from method `JPH::HeightFieldShape::GetMinHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HeightFieldShape_GetMinHeightValue(const JPH_HeightFieldShape *_this);

/// Generated from method `JPH::HeightFieldShape::GetMaxHeightValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HeightFieldShape_GetMaxHeightValue(const JPH_HeightFieldShape *_this);

/// Get the height values of a block of data.
/// Note that the height values are decompressed so will be slightly different from what the shape was originally created with.
/// @param inX Start X position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
/// @param inY Start Y position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
/// @param inSizeX Number of samples in X direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inX]
/// @param inSizeY Number of samples in Y direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inY]
/// @param outHeights Returned height values, must be at least inSizeX * inSizeY floats. Values are returned in x-major order and can be cNoCollisionValue.
/// @param inHeightsStride Stride in floats between two consecutive rows of outHeights (can be negative if the data is upside down).
/// Generated from method `JPH::HeightFieldShape::GetHeights`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_GetHeights(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, float *outHeights, long inHeightsStride);

/// Set the height values of a block of data.
/// Note that this requires decompressing and recompressing a border of size mBlockSize in the negative x/y direction so will cause some precision loss.
/// Beware this can create a race condition if you're running collision queries in parallel. See class documentation for more information.
/// @param inX Start X position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
/// @param inY Start Y position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
/// @param inSizeX Number of samples in X direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inX]
/// @param inSizeY Number of samples in Y direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inY]
/// @param inHeights The new height values to set, must be an array of inSizeX * inSizeY floats, can be cNoCollisionValue. Values outside of the range [GetMinHeightValue(), GetMaxHeightValue()] will be clamped.
/// @param inHeightsStride Stride in floats between two consecutive rows of inHeights (can be negative if the data is upside down).
/// @param inAllocator Allocator to use for temporary memory
/// @param inActiveEdgeCosThresholdAngle Cosine of the threshold angle (if the angle between the two triangles is bigger than this, the edge is active, note that a concave edge is always inactive).
/// Generated from method `JPH::HeightFieldShape::SetHeights`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
/// Parameter `inActiveEdgeCosThresholdAngle` has a default argument: `0.996195018F`, pass a null pointer to use it.
JOLT_API void JPH_HeightFieldShape_SetHeights(JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, const float *inHeights, long inHeightsStride, JPH_TempAllocator *inAllocator, const float *inActiveEdgeCosThresholdAngle);

/// Get the material indices of a block of data.
/// @param inX Start X position, must in the range [0, mSampleCount - 1]
/// @param inY Start Y position, must in the range [0, mSampleCount - 1]
/// @param inSizeX Number of samples in X direction
/// @param inSizeY Number of samples in Y direction
/// @param outMaterials Returned material indices, must be at least inSizeX * inSizeY uint8s. Values are returned in x-major order.
/// @param inMaterialsStride Stride in uint8s between two consecutive rows of outMaterials (can be negative if the data is upside down).
/// Generated from method `JPH::HeightFieldShape::GetMaterials`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_GetMaterials(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, unsigned char *outMaterials, long inMaterialsStride);

// See Shape::GetStats
/// Generated from method `JPH::HeightFieldShape::GetStats`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Shape_Stats_Destroy()` to free it when you're done using it.
JOLT_API JPH_Shape_Stats *JPH_HeightFieldShape_GetStats(const JPH_HeightFieldShape *_this);

// See Shape::GetVolume
/// Generated from method `JPH::HeightFieldShape::GetVolume`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_HeightFieldShape_GetVolume(const JPH_HeightFieldShape *_this);

// Register shape functions with the registry
/// Generated from method `JPH::HeightFieldShape::sRegister`.
JOLT_API void JPH_HeightFieldShape_sRegister(void);

/// User data (to be used freely by the application)
/// Generated from method `JPH::HeightFieldShape::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_HeightFieldShape_GetUserData(const JPH_HeightFieldShape *_this);

/// Generated from method `JPH::HeightFieldShape::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_SetUserData(JPH_HeightFieldShape *_this, uint64_t inUserData);

/// Get the leaf shape for a particular sub shape ID.
/// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
/// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
/// @return The shape or null if the sub shape ID is invalid
/// Generated from method `JPH::HeightFieldShape::GetLeafShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_HeightFieldShape_GetLeafShape(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder);

/// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
/// Generated from method `JPH::HeightFieldShape::GetSubShapeUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API uint64_t JPH_HeightFieldShape_GetSubShapeUserData(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::HeightFieldShape::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_SetEmbedded(const JPH_HeightFieldShape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::HeightFieldShape::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_HeightFieldShape_GetRefCount(const JPH_HeightFieldShape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::HeightFieldShape::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_AddRef(const JPH_HeightFieldShape *_this);

/// Generated from method `JPH::HeightFieldShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_HeightFieldShape_Release(const JPH_HeightFieldShape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::HeightFieldShape::sInternalGetRefCountOffset`.
JOLT_API int JPH_HeightFieldShape_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
