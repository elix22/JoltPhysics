// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_SkeletalAnimation_JointState JPH_SkeletalAnimation_JointState; // Defined in `#include <jolt/Jolt/Skeleton/SkeletalAnimation.h>`.
typedef struct JPH_Skeleton JPH_Skeleton; // Defined in `#include <jolt/Jolt/Skeleton/Skeleton.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_Mat44 Jolt_JPH_Array_JPH_Mat44; // Defined in `#include <JPH_Array_JPH_Mat44.h>`.
typedef struct Jolt_JPH_Array_JPH_SkeletalAnimation_JointState Jolt_JPH_Array_JPH_SkeletalAnimation_JointState; // Defined in `#include <JPH_Array_JPH_SkeletalAnimation_JointState.h>`.


/// Draw settings
/// Generated from class `JPH::SkeletonPose::DrawSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonPose_DrawSettings JPH_SkeletonPose_DrawSettings;

/// Instance of a skeleton, contains the pose the current skeleton is in
/// Generated from class `JPH::SkeletonPose`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletonPose JPH_SkeletonPose;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonPose_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonPose *JPH_SkeletonPose_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonPose_DestroyArray()`.
/// Use `JPH_SkeletonPose_OffsetMutablePtr()` and `JPH_SkeletonPose_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonPose *JPH_SkeletonPose_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonPose *JPH_SkeletonPose_OffsetPtr(const JPH_SkeletonPose *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonPose *JPH_SkeletonPose_OffsetMutablePtr(JPH_SkeletonPose *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonPose_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonPose *JPH_SkeletonPose_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonPose *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletonPose`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonPose_Destroy(const JPH_SkeletonPose *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonPose`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonPose_DestroyArray(const JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonPose *JPH_SkeletonPose_AssignFromAnother(JPH_SkeletonPose *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonPose *_other);

/// Generated from method `JPH::SkeletonPose::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletonPose_size_t(size_t inCount);

/// Generated from method `JPH::SkeletonPose::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletonPose_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletonPose::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletonPose::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletonPose_size_t(size_t inCount);

/// Generated from method `JPH::SkeletonPose::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletonPose_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletonPose::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletonPose::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletonPose_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletonPose::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SkeletonPose::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletonPose::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace);

///@name Skeleton
///@{
/// Generated from method `JPH::SkeletonPose::SetSkeleton`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonPose_SetSkeleton(JPH_SkeletonPose *_this, const JPH_Skeleton *inSkeleton);

/// Generated from method `JPH::SkeletonPose::GetSkeleton`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Skeleton *JPH_SkeletonPose_GetSkeleton(const JPH_SkeletonPose *_this);

/// Extra offset applied to the root (and therefore also to all of its children)
/// Generated from method `JPH::SkeletonPose::SetRootOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOffset` can not be null. It is a single object.
JOLT_API void JPH_SkeletonPose_SetRootOffset(JPH_SkeletonPose *_this, const JPH_Vec3 *inOffset);

/// Generated from method `JPH::SkeletonPose::GetRootOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SkeletonPose_GetRootOffset(const JPH_SkeletonPose *_this);

///@name Properties of the joints
///@{
/// Generated from method `JPH::SkeletonPose::GetJointCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SkeletonPose_GetJointCount(const JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::GetJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoints(const JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::GetJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoints_mut(JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::GetJoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoint(const JPH_SkeletonPose *_this, int inJoint);

/// Generated from method `JPH::SkeletonPose::GetJoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoint_mut(JPH_SkeletonPose *_this, int inJoint);

///@name Joint matrices
///@{
/// Generated from method `JPH::SkeletonPose::GetJointMatrices`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_Mat44 *JPH_SkeletonPose_GetJointMatrices(const JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::GetJointMatrices`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_Mat44 *JPH_SkeletonPose_GetJointMatrices_mut(JPH_SkeletonPose *_this);

/// Generated from method `JPH::SkeletonPose::GetJointMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Mat44 *JPH_SkeletonPose_GetJointMatrix(const JPH_SkeletonPose *_this, int inJoint);

/// Generated from method `JPH::SkeletonPose::GetJointMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_Mat44 *JPH_SkeletonPose_GetJointMatrix_mut(JPH_SkeletonPose *_this, int inJoint);

/// Convert the joint states to joint matrices
/// Generated from method `JPH::SkeletonPose::CalculateJointMatrices`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonPose_CalculateJointMatrices(JPH_SkeletonPose *_this);

/// Convert joint matrices to joint states
/// Generated from method `JPH::SkeletonPose::CalculateJointStates`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonPose_CalculateJointStates(JPH_SkeletonPose *_this);

/// Outputs the joint matrices in local space (ensure that outMatrices has GetJointCount() elements, assumes that values in GetJoints() is up to date)
/// Generated from method `JPH::SkeletonPose::CalculateLocalSpaceJointMatrices`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(const JPH_SkeletonPose *_this, JPH_Mat44 *outMatrices);

/// Draw current pose
/// Generated from method `JPH::SkeletonPose::Draw`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDrawSettings` can not be null. It is a single object.
/// Parameter `inOffset` is a single object.
/// Parameter `inOffset` has a default argument: `JPH::RMat44::sIdentity()`, pass a null pointer to use it.
JOLT_API void JPH_SkeletonPose_Draw(const JPH_SkeletonPose *_this, const JPH_SkeletonPose_DrawSettings *inDrawSettings, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inOffset);

/// Returns a pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJoints(const JPH_SkeletonPose_DrawSettings *_this);

/// Modifies a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawJoints`.
JOLT_API void JPH_SkeletonPose_DrawSettings_Set_mDrawJoints(JPH_SkeletonPose_DrawSettings *_this, bool value);

/// Returns a mutable pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJoints`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints(JPH_SkeletonPose_DrawSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointOrientations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations(const JPH_SkeletonPose_DrawSettings *_this);

/// Modifies a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointOrientations`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawJointOrientations`.
JOLT_API void JPH_SkeletonPose_DrawSettings_Set_mDrawJointOrientations(JPH_SkeletonPose_DrawSettings *_this, bool value);

/// Returns a mutable pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointOrientations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations(JPH_SkeletonPose_DrawSettings *_this);

/// Returns a pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointNames`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames(const JPH_SkeletonPose_DrawSettings *_this);

/// Modifies a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointNames`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawJointNames`.
JOLT_API void JPH_SkeletonPose_DrawSettings_Set_mDrawJointNames(JPH_SkeletonPose_DrawSettings *_this, bool value);

/// Returns a mutable pointer to a member variable of class `JPH::SkeletonPose::DrawSettings` named `mDrawJointNames`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames(JPH_SkeletonPose_DrawSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonPose_DrawSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletonPose_DrawSettings_DestroyArray()`.
/// Use `JPH_SkeletonPose_DrawSettings_OffsetMutablePtr()` and `JPH_SkeletonPose_DrawSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::SkeletonPose::DrawSettings` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonPose_DrawSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_ConstructFrom(bool mDrawJoints, bool mDrawJointOrientations, bool mDrawJointNames);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_OffsetPtr(const JPH_SkeletonPose_DrawSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_OffsetMutablePtr(JPH_SkeletonPose_DrawSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletonPose::DrawSettings::DrawSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletonPose_DrawSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_ConstructFromAnother(const JPH_SkeletonPose_DrawSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletonPose_DrawSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonPose_DrawSettings_Destroy(const JPH_SkeletonPose_DrawSettings *_this);

/// Destroys a heap-allocated array of `JPH_SkeletonPose_DrawSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletonPose_DrawSettings_DestroyArray(const JPH_SkeletonPose_DrawSettings *_this);

/// Generated from method `JPH::SkeletonPose::DrawSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_AssignFromAnother(JPH_SkeletonPose_DrawSettings *_this, const JPH_SkeletonPose_DrawSettings *_other);

#ifdef __cplusplus
} // extern "C"
#endif
