// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_RefTarget_JPH_SkeletonMapper JPH_RefTarget_JPH_SkeletonMapper; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Skeleton JPH_Skeleton; // Defined in `#include <jolt/Jolt/Skeleton/Skeleton.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_SkeletonMapper_Chain Jolt_JPH_Array_JPH_SkeletonMapper_Chain; // Defined in `#include <JPH_Array_JPH_SkeletonMapper_Chain.h>`.
typedef struct Jolt_JPH_Array_JPH_SkeletonMapper_Locked Jolt_JPH_Array_JPH_SkeletonMapper_Locked; // Defined in `#include <JPH_Array_JPH_SkeletonMapper_Locked.h>`.
typedef struct Jolt_JPH_Array_JPH_SkeletonMapper_Mapping Jolt_JPH_Array_JPH_SkeletonMapper_Mapping; // Defined in `#include <JPH_Array_JPH_SkeletonMapper_Mapping.h>`.
typedef struct Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped; // Defined in `#include <JPH_Array_JPH_SkeletonMapper_Unmapped.h>`.
typedef struct Jolt_JPH_Array_int Jolt_JPH_Array_int; // Defined in `#include <JPH_Array_int.h>`.


/// A joint that maps 1-on-1 to a joint in the other skeleton
/// Generated from class `JPH::SkeletonMapper::Mapping`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonMapper_Mapping JPH_SkeletonMapper_Mapping;

/// A joint chain that starts with a 1-on-1 mapped joint and ends with a 1-on-1 mapped joint with intermediate joints that cannot be mapped
/// Generated from class `JPH::SkeletonMapper::Chain`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonMapper_Chain JPH_SkeletonMapper_Chain;

/// Joints that could not be mapped from skeleton 1 to 2
/// Generated from class `JPH::SkeletonMapper::Unmapped`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonMapper_Unmapped JPH_SkeletonMapper_Unmapped;

/// Joints that should have their translation locked (fixed)
/// Generated from class `JPH::SkeletonMapper::Locked`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonMapper_Locked JPH_SkeletonMapper_Locked;

/// Class that is able to map a low detail (ragdoll) skeleton to a high detail (animation) skeleton and vice versa
/// Generated from class `JPH::SkeletonMapper`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::SkeletonMapper>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonMapper JPH_SkeletonMapper;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonMapper_DestroyArray()`.
/// Use `JPH_SkeletonMapper_OffsetMutablePtr()` and `JPH_SkeletonMapper_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper *JPH_SkeletonMapper_OffsetPtr(const JPH_SkeletonMapper *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_OffsetMutablePtr(JPH_SkeletonMapper *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SkeletonMapper` to its base class `JPH::RefTarget<JPH::SkeletonMapper>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SkeletonMapper *JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(const JPH_SkeletonMapper *object);

/// Upcasts an instance of `JPH::SkeletonMapper` to its base class `JPH::RefTarget<JPH::SkeletonMapper>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_SkeletonMapper_MutableUpcastTo_JPH_RefTarget_JPH_SkeletonMapper(JPH_SkeletonMapper *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SkeletonMapper>` to a derived class `JPH::SkeletonMapper`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper *JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(const JPH_RefTarget_JPH_SkeletonMapper *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SkeletonMapper>` to a derived class `JPH::SkeletonMapper`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(JPH_RefTarget_JPH_SkeletonMapper *object);

/// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonMapper *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletonMapper`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Destroy(const JPH_SkeletonMapper *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonMapper`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_DestroyArray(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper *JPH_SkeletonMapper_AssignFromAnother(JPH_SkeletonMapper *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonMapper *_other);

/// Default function that checks if the names of the joints are equal
/// Generated from method `JPH::SkeletonMapper::sDefaultCanMapJoint`.
JOLT_API bool JPH_SkeletonMapper_sDefaultCanMapJoint(const JPH_Skeleton *inSkeleton1, int inIndex1, const JPH_Skeleton *inSkeleton2, int inIndex2);

/// This can be called so lock the translation of a specified set of joints in skeleton 2.
/// Because constraints are never 100% rigid, there's always a little bit of stretch in the ragdoll when the ragdoll is under stress.
/// Locking the translations of the pose will remove the visual stretch from the ragdoll but will introduce a difference between the
/// physical simulation and the visual representation.
/// @param inSkeleton2 Target skeleton to map to.
/// @param inLockedTranslations An array of bools the size of inSkeleton2->GetJointCount(), for each joint indicating if the joint is locked.
/// @param inNeutralPose2 Neutral pose to take reference translations from
/// Generated from method `JPH::SkeletonMapper::LockTranslations`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_LockTranslations(JPH_SkeletonMapper *_this, const JPH_Skeleton *inSkeleton2, const bool *inLockedTranslations, const JPH_Mat44 *inNeutralPose2);

/// After Initialize(), this can be called to lock the translation of all joints in skeleton 2 below the first mapped joint to those of the neutral pose.
/// Because constraints are never 100% rigid, there's always a little bit of stretch in the ragdoll when the ragdoll is under stress.
/// Locking the translations of the pose will remove the visual stretch from the ragdoll but will introduce a difference between the
/// physical simulation and the visual representation.
/// @param inSkeleton2 Target skeleton to map to.
/// @param inNeutralPose2 Neutral pose to take reference translations from
/// Generated from method `JPH::SkeletonMapper::LockAllTranslations`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_LockAllTranslations(JPH_SkeletonMapper *_this, const JPH_Skeleton *inSkeleton2, const JPH_Mat44 *inNeutralPose2);

/// Map a pose. Joints that were directly mappable will be copied in model space from pose 1 to pose 2. Any joints that are only present in skeleton 2
/// will get their model space transform calculated through the local space transforms of pose 2. Joints that are part of a joint chain between two
/// mapped joints will be reoriented towards the next joint in skeleton 1. This means that it is possible for unmapped joints to have some animation,
/// but very extreme animation poses will show artifacts.
/// @param inPose1ModelSpace Pose on skeleton 1 in model space
/// @param inPose2LocalSpace Pose on skeleton 2 in local space (used for the joints that cannot be mapped)
/// @param outPose2ModelSpace Model space pose on skeleton 2 (the output of the mapping)
/// Generated from method `JPH::SkeletonMapper::Map`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_Map(const JPH_SkeletonMapper *_this, const JPH_Mat44 *inPose1ModelSpace, const JPH_Mat44 *inPose2LocalSpace, JPH_Mat44 *outPose2ModelSpace);

/// Reverse map a pose, this will only use the mappings and not the chains (it assumes that all joints in skeleton 1 are mapped)
/// @param inPose2ModelSpace Model space pose on skeleton 2
/// @param outPose1ModelSpace When the function returns this will contain the model space pose for skeleton 1
/// Generated from method `JPH::SkeletonMapper::MapReverse`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_MapReverse(const JPH_SkeletonMapper *_this, const JPH_Mat44 *inPose2ModelSpace, JPH_Mat44 *outPose1ModelSpace);

/// Search through the directly mapped joints (mMappings) and find inJoint1Idx, returns the corresponding Joint2Idx or -1 if not found.
/// Generated from method `JPH::SkeletonMapper::GetMappedJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_SkeletonMapper_GetMappedJointIdx(const JPH_SkeletonMapper *_this, int inJoint1Idx);

/// Search through the locked translations (mLockedTranslations) and find if joint inJoint2Idx is locked.
/// Generated from method `JPH::SkeletonMapper::IsJointTranslationLocked`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SkeletonMapper_IsJointTranslationLocked(const JPH_SkeletonMapper *_this, int inJoint2Idx);

///@name Access to the mapped joints
///@{
/// Generated from method `JPH::SkeletonMapper::GetMappings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_GetMappings(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetMappings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_GetMappings_mut(JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetChains`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_GetChains(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetChains`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_GetChains_mut(JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetUnmapped`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_GetUnmapped(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetUnmapped`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_GetUnmapped_mut(JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetLockedTranslations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_GetLockedTranslations(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::GetLockedTranslations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_GetLockedTranslations_mut(JPH_SkeletonMapper *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SkeletonMapper::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_SetEmbedded(const JPH_SkeletonMapper *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SkeletonMapper::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SkeletonMapper_GetRefCount(const JPH_SkeletonMapper *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SkeletonMapper::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_AddRef(const JPH_SkeletonMapper *_this);

/// Generated from method `JPH::SkeletonMapper::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonMapper_Release(const JPH_SkeletonMapper *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SkeletonMapper::sInternalGetRefCountOffset`.
JOLT_API int JPH_SkeletonMapper_sInternalGetRefCountOffset(void);

///< Index of joint from skeleton 1
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Mapping_Get_mJointIdx1(const JPH_SkeletonMapper_Mapping *_this);

///< Index of joint from skeleton 1
/// Modifies a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx1`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mJointIdx1`.
JOLT_API void JPH_SkeletonMapper_Mapping_Set_mJointIdx1(JPH_SkeletonMapper_Mapping *_this, int value);

///< Index of joint from skeleton 1
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1(JPH_SkeletonMapper_Mapping *_this);

///< Corresponding index of joint from skeleton 2
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Mapping_Get_mJointIdx2(const JPH_SkeletonMapper_Mapping *_this);

///< Corresponding index of joint from skeleton 2
/// Modifies a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mJointIdx2`.
JOLT_API void JPH_SkeletonMapper_Mapping_Set_mJointIdx2(JPH_SkeletonMapper_Mapping *_this, int value);

///< Corresponding index of joint from skeleton 2
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJointIdx2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2(JPH_SkeletonMapper_Mapping *_this);

///< Transforms this joint from skeleton 1 to 2
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJoint1To2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_SkeletonMapper_Mapping_Get_mJoint1To2(const JPH_SkeletonMapper_Mapping *_this);

///< Transforms this joint from skeleton 1 to 2
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJoint1To2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Mat44 *JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2(JPH_SkeletonMapper_Mapping *_this);

///< Inverse of the transform above
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJoint2To1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Mat44 *JPH_SkeletonMapper_Mapping_Get_mJoint2To1(const JPH_SkeletonMapper_Mapping *_this);

///< Inverse of the transform above
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Mapping` named `mJoint2To1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Mat44 *JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1(JPH_SkeletonMapper_Mapping *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Mapping_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonMapper_Mapping_DestroyArray()`.
/// Use `JPH_SkeletonMapper_Mapping_OffsetMutablePtr()` and `JPH_SkeletonMapper_Mapping_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_OffsetPtr(const JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_OffsetMutablePtr(JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Mapping_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_ConstructFromAnother(const JPH_SkeletonMapper_Mapping *_other);

/// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
/// Parameter `inJoint1To2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Mapping_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_Construct(int inJointIdx1, int inJointIdx2, const JPH_Mat44 *inJoint1To2);

/// Destroys a heap-allocated instance of `JPH_SkeletonMapper_Mapping`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Mapping_Destroy(const JPH_SkeletonMapper_Mapping *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonMapper_Mapping`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Mapping_DestroyArray(const JPH_SkeletonMapper_Mapping *_this);

/// Generated from method `JPH::SkeletonMapper::Mapping::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_AssignFromAnother(JPH_SkeletonMapper_Mapping *_this, const JPH_SkeletonMapper_Mapping *_other);

///< Joint chain from skeleton 1
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_int *JPH_SkeletonMapper_Chain_Get_mJointIndices1(const JPH_SkeletonMapper_Chain *_this);

///< Joint chain from skeleton 1
/// Modifies a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices1`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mJointIndices1`.
/// When this function is called, this object will drop object references it held previously in `mJointIndices1`.
JOLT_API void JPH_SkeletonMapper_Chain_Set_mJointIndices1(JPH_SkeletonMapper_Chain *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_int *value);

///< Joint chain from skeleton 1
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_int *JPH_SkeletonMapper_Chain_GetMutable_mJointIndices1(JPH_SkeletonMapper_Chain *_this);

///< Corresponding joint chain from skeleton 2
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_int *JPH_SkeletonMapper_Chain_Get_mJointIndices2(const JPH_SkeletonMapper_Chain *_this);

///< Corresponding joint chain from skeleton 2
/// Modifies a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mJointIndices2`.
/// When this function is called, this object will drop object references it held previously in `mJointIndices2`.
JOLT_API void JPH_SkeletonMapper_Chain_Set_mJointIndices2(JPH_SkeletonMapper_Chain *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_int *value);

///< Corresponding joint chain from skeleton 2
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Chain` named `mJointIndices2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_int *JPH_SkeletonMapper_Chain_GetMutable_mJointIndices2(JPH_SkeletonMapper_Chain *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Chain_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonMapper_Chain_DestroyArray()`.
/// Use `JPH_SkeletonMapper_Chain_OffsetMutablePtr()` and `JPH_SkeletonMapper_Chain_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_OffsetPtr(const JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_OffsetMutablePtr(JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Chain_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonMapper_Chain *_other);

/// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
/// Parameter `inJointIndices1` can not be null. It is a single object.
/// In C++ this parameter takes an rvalue reference: it might invalidate the passed object,
///   but if your pointer is owning, you must still destroy it manually later.
/// Parameter `inJointIndices2` can not be null. It is a single object.
/// In C++ this parameter takes an rvalue reference: it might invalidate the passed object,
///   but if your pointer is owning, you must still destroy it manually later.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Chain_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_Construct(Jolt_JPH_Array_int *inJointIndices1, Jolt_JPH_Array_int *inJointIndices2);

/// Destroys a heap-allocated instance of `JPH_SkeletonMapper_Chain`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Chain_Destroy(const JPH_SkeletonMapper_Chain *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonMapper_Chain`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Chain_DestroyArray(const JPH_SkeletonMapper_Chain *_this);

/// Generated from method `JPH::SkeletonMapper::Chain::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_AssignFromAnother(JPH_SkeletonMapper_Chain *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonMapper_Chain *_other);

///< Joint index of unmappable joint
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Unmapped` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Unmapped_Get_mJointIdx(const JPH_SkeletonMapper_Unmapped *_this);

///< Joint index of unmappable joint
/// Modifies a member variable of class `JPH::SkeletonMapper::Unmapped` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mJointIdx`.
JOLT_API void JPH_SkeletonMapper_Unmapped_Set_mJointIdx(JPH_SkeletonMapper_Unmapped *_this, int value);

///< Joint index of unmappable joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Unmapped` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx(JPH_SkeletonMapper_Unmapped *_this);

///< Parent joint index of unmappable joint
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Unmapped` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx(const JPH_SkeletonMapper_Unmapped *_this);

///< Parent joint index of unmappable joint
/// Modifies a member variable of class `JPH::SkeletonMapper::Unmapped` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mParentJointIdx`.
JOLT_API void JPH_SkeletonMapper_Unmapped_Set_mParentJointIdx(JPH_SkeletonMapper_Unmapped *_this, int value);

///< Parent joint index of unmappable joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Unmapped` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx(JPH_SkeletonMapper_Unmapped *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Unmapped_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonMapper_Unmapped_DestroyArray()`.
/// Use `JPH_SkeletonMapper_Unmapped_OffsetMutablePtr()` and `JPH_SkeletonMapper_Unmapped_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_OffsetPtr(const JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_OffsetMutablePtr(JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Unmapped_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_ConstructFromAnother(const JPH_SkeletonMapper_Unmapped *_other);

/// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Unmapped_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_Construct(int inJointIdx, int inParentJointIdx);

/// Destroys a heap-allocated instance of `JPH_SkeletonMapper_Unmapped`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Unmapped_Destroy(const JPH_SkeletonMapper_Unmapped *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonMapper_Unmapped`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Unmapped_DestroyArray(const JPH_SkeletonMapper_Unmapped *_this);

/// Generated from method `JPH::SkeletonMapper::Unmapped::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_AssignFromAnother(JPH_SkeletonMapper_Unmapped *_this, const JPH_SkeletonMapper_Unmapped *_other);

///< Joint index of joint with locked translation (in skeleton 2)
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Locked_Get_mJointIdx(const JPH_SkeletonMapper_Locked *_this);

///< Joint index of joint with locked translation (in skeleton 2)
/// Modifies a member variable of class `JPH::SkeletonMapper::Locked` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mJointIdx`.
JOLT_API void JPH_SkeletonMapper_Locked_Set_mJointIdx(JPH_SkeletonMapper_Locked *_this, int value);

///< Joint index of joint with locked translation (in skeleton 2)
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Locked_GetMutable_mJointIdx(JPH_SkeletonMapper_Locked *_this);

///< Parent joint index of joint with locked translation (in skeleton 2)
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SkeletonMapper_Locked_Get_mParentJointIdx(const JPH_SkeletonMapper_Locked *_this);

///< Parent joint index of joint with locked translation (in skeleton 2)
/// Modifies a member variable of class `JPH::SkeletonMapper::Locked` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mParentJointIdx`.
JOLT_API void JPH_SkeletonMapper_Locked_Set_mParentJointIdx(JPH_SkeletonMapper_Locked *_this, int value);

///< Parent joint index of joint with locked translation (in skeleton 2)
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mParentJointIdx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx(JPH_SkeletonMapper_Locked *_this);

///< Translation of neutral pose
/// Returns a pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SkeletonMapper_Locked_Get_mTranslation(const JPH_SkeletonMapper_Locked *_this);

///< Translation of neutral pose
/// Returns a mutable pointer to a member variable of class `JPH::SkeletonMapper::Locked` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SkeletonMapper_Locked_GetMutable_mTranslation(JPH_SkeletonMapper_Locked *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Locked_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonMapper_Locked_DestroyArray()`.
/// Use `JPH_SkeletonMapper_Locked_OffsetMutablePtr()` and `JPH_SkeletonMapper_Locked_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::SkeletonMapper::Locked` elementwise.
/// Parameter `mTranslation` can not be null. It is a single object.
/// The reference to the parameter `mTranslation` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Locked_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_ConstructFrom(int mJointIdx, int mParentJointIdx, const JPH_Vec3 *mTranslation);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_OffsetPtr(const JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_OffsetMutablePtr(JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonMapper::Locked::Locked`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonMapper_Locked_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_ConstructFromAnother(const JPH_SkeletonMapper_Locked *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletonMapper_Locked`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Locked_Destroy(const JPH_SkeletonMapper_Locked *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonMapper_Locked`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonMapper_Locked_DestroyArray(const JPH_SkeletonMapper_Locked *_this);

/// Generated from method `JPH::SkeletonMapper::Locked::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_AssignFromAnother(JPH_SkeletonMapper_Locked *_this, const JPH_SkeletonMapper_Locked *_other);

#ifdef __cplusplus
} // extern "C"
#endif
