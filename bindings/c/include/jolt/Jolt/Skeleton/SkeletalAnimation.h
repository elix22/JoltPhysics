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
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_SkeletalAnimation JPH_RefTarget_JPH_SkeletalAnimation; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SkeletonPose JPH_SkeletonPose; // Defined in `#include <jolt/Jolt/Skeleton/SkeletonPose.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Contains the current state of a joint, a local space transformation relative to its parent joint
/// Generated from class `JPH::SkeletalAnimation::JointState`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::SkeletalAnimation::Keyframe`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletalAnimation_JointState JPH_SkeletalAnimation_JointState;

/// Contains the state of a single joint at a particular time
/// Generated from class `JPH::SkeletalAnimation::Keyframe`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SkeletalAnimation::JointState`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletalAnimation_Keyframe JPH_SkeletalAnimation_Keyframe;

/// Contains the animation for a single joint
/// Generated from class `JPH::SkeletalAnimation::AnimatedJoint`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletalAnimation_AnimatedJoint JPH_SkeletalAnimation_AnimatedJoint;

/// Resource for a skinned animation
/// Generated from class `JPH::SkeletalAnimation`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::SkeletalAnimation>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SkeletalAnimation JPH_SkeletalAnimation;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletalAnimation_DestroyArray()`.
/// Use `JPH_SkeletalAnimation_OffsetMutablePtr()` and `JPH_SkeletalAnimation_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation *JPH_SkeletalAnimation_OffsetPtr(const JPH_SkeletalAnimation *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_OffsetMutablePtr(JPH_SkeletalAnimation *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SkeletalAnimation` to its base class `JPH::RefTarget<JPH::SkeletalAnimation>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SkeletalAnimation *JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(const JPH_SkeletalAnimation *object);

/// Upcasts an instance of `JPH::SkeletalAnimation` to its base class `JPH::RefTarget<JPH::SkeletalAnimation>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_SkeletalAnimation_MutableUpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(JPH_SkeletalAnimation *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SkeletalAnimation>` to a derived class `JPH::SkeletalAnimation`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation *JPH_SkeletalAnimation_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletalAnimation(const JPH_RefTarget_JPH_SkeletalAnimation *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SkeletalAnimation>` to a derived class `JPH::SkeletalAnimation`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SkeletalAnimation(JPH_RefTarget_JPH_SkeletalAnimation *object);

/// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletalAnimation`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_Destroy(const JPH_SkeletalAnimation *_this);

/// Destroys a heap-allocated array of `JPH_SkeletalAnimation`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_DestroyArray(const JPH_SkeletalAnimation *_this);

/// Generated from method `JPH::SkeletalAnimation::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletalAnimation *JPH_SkeletalAnimation_AssignFromAnother(JPH_SkeletalAnimation *_this, Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation *_other);

/// Generated from method `JPH::SkeletalAnimation::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SkeletalAnimation::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the length (in seconds) of this animation
/// Generated from method `JPH::SkeletalAnimation::GetDuration`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_SkeletalAnimation_GetDuration(const JPH_SkeletalAnimation *_this);

/// Scale the size of all joints by inScale
/// Generated from method `JPH::SkeletalAnimation::ScaleJoints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_ScaleJoints(JPH_SkeletalAnimation *_this, float inScale);

/// If the animation is looping or not. If an animation is looping, the animation will continue playing after completion
/// Generated from method `JPH::SkeletalAnimation::SetIsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_SetIsLooping(JPH_SkeletalAnimation *_this, bool inIsLooping);

/// Generated from method `JPH::SkeletalAnimation::IsLooping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SkeletalAnimation_IsLooping(const JPH_SkeletalAnimation *_this);

/// Get the (interpolated) joint transforms at time inTime
/// Generated from method `JPH::SkeletalAnimation::Sample`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ioPose` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_Sample(const JPH_SkeletalAnimation *_this, float inTime, JPH_SkeletonPose *ioPose);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SkeletalAnimation::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_SetEmbedded(const JPH_SkeletalAnimation *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SkeletalAnimation::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SkeletalAnimation_GetRefCount(const JPH_SkeletalAnimation *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SkeletalAnimation::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_AddRef(const JPH_SkeletalAnimation *_this);

/// Generated from method `JPH::SkeletalAnimation::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_Release(const JPH_SkeletalAnimation *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SkeletalAnimation::sInternalGetRefCountOffset`.
JOLT_API int JPH_SkeletalAnimation_sInternalGetRefCountOffset(void);

///< Local space rotation of the joint
/// Returns a pointer to a member variable of class `JPH::SkeletalAnimation::JointState` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_SkeletalAnimation_JointState_Get_mRotation(const JPH_SkeletalAnimation_JointState *_this);

///< Local space rotation of the joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletalAnimation::JointState` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_SkeletalAnimation_JointState_GetMutable_mRotation(JPH_SkeletalAnimation_JointState *_this);

///< Local space translation of the joint
/// Returns a pointer to a member variable of class `JPH::SkeletalAnimation::JointState` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SkeletalAnimation_JointState_Get_mTranslation(const JPH_SkeletalAnimation_JointState *_this);

///< Local space translation of the joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletalAnimation::JointState` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SkeletalAnimation_JointState_GetMutable_mTranslation(JPH_SkeletalAnimation_JointState *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_JointState_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletalAnimation_JointState_DestroyArray()`.
/// Use `JPH_SkeletalAnimation_JointState_OffsetMutablePtr()` and `JPH_SkeletalAnimation_JointState_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::SkeletalAnimation::JointState` elementwise.
/// Parameter `mRotation` can not be null. It is a single object.
/// The reference to the parameter `mRotation` might be preserved in the constructed object.
/// Parameter `mTranslation` can not be null. It is a single object.
/// The reference to the parameter `mTranslation` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_JointState_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_ConstructFrom(const JPH_Quat *mRotation, const JPH_Vec3 *mTranslation);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_OffsetPtr(const JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_OffsetMutablePtr(JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SkeletalAnimation::JointState::JointState`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_JointState_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_ConstructFromAnother(const JPH_SkeletalAnimation_JointState *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletalAnimation_JointState`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_JointState_Destroy(const JPH_SkeletalAnimation_JointState *_this);

/// Destroys a heap-allocated array of `JPH_SkeletalAnimation_JointState`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_JointState_DestroyArray(const JPH_SkeletalAnimation_JointState *_this);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_AssignFromAnother(JPH_SkeletalAnimation_JointState *_this, const JPH_SkeletalAnimation_JointState *_other);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_JointState_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Convert from a local space matrix
/// Generated from method `JPH::SkeletalAnimation::JointState::FromMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_JointState_FromMatrix(JPH_SkeletalAnimation_JointState *_this, const JPH_Mat44 *inMatrix);

/// Convert to matrix representation
/// Generated from method `JPH::SkeletalAnimation::JointState::ToMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SkeletalAnimation_JointState_ToMatrix(const JPH_SkeletalAnimation_JointState *_this);

///< Time of keyframe in seconds
/// Returns a pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SkeletalAnimation_Keyframe_Get_mTime(const JPH_SkeletalAnimation_Keyframe *_this);

///< Time of keyframe in seconds
/// Modifies a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTime`.
JOLT_API void JPH_SkeletalAnimation_Keyframe_Set_mTime(JPH_SkeletalAnimation_Keyframe *_this, float value);

///< Time of keyframe in seconds
/// Returns a mutable pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SkeletalAnimation_Keyframe_GetMutable_mTime(JPH_SkeletalAnimation_Keyframe *_this);

///< Local space rotation of the joint
/// Returns a pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Quat *JPH_SkeletalAnimation_Keyframe_Get_mRotation(const JPH_SkeletalAnimation_Keyframe *_this);

///< Local space rotation of the joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Quat *JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation(JPH_SkeletalAnimation_Keyframe *_this);

///< Local space translation of the joint
/// Returns a pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SkeletalAnimation_Keyframe_Get_mTranslation(const JPH_SkeletalAnimation_Keyframe *_this);

///< Local space translation of the joint
/// Returns a mutable pointer to a member variable of class `JPH::SkeletalAnimation::Keyframe` named `mTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation(JPH_SkeletalAnimation_Keyframe *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_Keyframe_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletalAnimation_Keyframe_DestroyArray()`.
/// Use `JPH_SkeletalAnimation_Keyframe_OffsetMutablePtr()` and `JPH_SkeletalAnimation_Keyframe_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_OffsetPtr(const JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_OffsetMutablePtr(JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SkeletalAnimation::Keyframe` to its base class `JPH::SkeletalAnimation::JointState`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(const JPH_SkeletalAnimation_Keyframe *object);

/// Upcasts an instance of `JPH::SkeletalAnimation::Keyframe` to its base class `JPH::SkeletalAnimation::JointState`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_Keyframe_MutableUpcastTo_JPH_SkeletalAnimation_JointState(JPH_SkeletalAnimation_Keyframe *object);

/// Downcasts an instance of `JPH::SkeletalAnimation::JointState` to a derived class `JPH::SkeletalAnimation::Keyframe`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_StaticDowncastFrom_JPH_SkeletalAnimation_JointState(const JPH_SkeletalAnimation_JointState *object);

/// Downcasts an instance of `JPH::SkeletalAnimation::JointState` to a derived class `JPH::SkeletalAnimation::Keyframe`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_MutableStaticDowncastFrom_JPH_SkeletalAnimation_JointState(JPH_SkeletalAnimation_JointState *object);

/// Generated from constructor `JPH::SkeletalAnimation::Keyframe::Keyframe`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_Keyframe_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(const JPH_SkeletalAnimation_Keyframe *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletalAnimation_Keyframe`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_Keyframe_Destroy(const JPH_SkeletalAnimation_Keyframe *_this);

/// Destroys a heap-allocated array of `JPH_SkeletalAnimation_Keyframe`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_Keyframe_DestroyArray(const JPH_SkeletalAnimation_Keyframe *_this);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_AssignFromAnother(JPH_SkeletalAnimation_Keyframe *_this, const JPH_SkeletalAnimation_Keyframe *_other);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Convert from a local space matrix
/// Generated from method `JPH::SkeletalAnimation::Keyframe::FromMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
JOLT_API void JPH_SkeletalAnimation_Keyframe_FromMatrix(JPH_SkeletalAnimation_Keyframe *_this, const JPH_Mat44 *inMatrix);

/// Convert to matrix representation
/// Generated from method `JPH::SkeletalAnimation::Keyframe::ToMatrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_SkeletalAnimation_Keyframe_ToMatrix(const JPH_SkeletalAnimation_Keyframe *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_AnimatedJoint_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SkeletalAnimation_AnimatedJoint_DestroyArray()`.
/// Use `JPH_SkeletalAnimation_AnimatedJoint_OffsetMutablePtr()` and `JPH_SkeletalAnimation_AnimatedJoint_OffsetPtr()` to access the array elements.
JOLT_API JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SkeletalAnimation_AnimatedJoint_Destroy()` to free it when you're done using it.
JOLT_API JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation_AnimatedJoint *_other);

/// Destroys a heap-allocated instance of `JPH_SkeletalAnimation_AnimatedJoint`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_AnimatedJoint_Destroy(const JPH_SkeletalAnimation_AnimatedJoint *_this);

/// Destroys a heap-allocated array of `JPH_SkeletalAnimation_AnimatedJoint`. Does nothing if the pointer is null.
JOLT_API void JPH_SkeletalAnimation_AnimatedJoint_DestroyArray(const JPH_SkeletalAnimation_AnimatedJoint *_this);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother(JPH_SkeletalAnimation_AnimatedJoint *_this, Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation_AnimatedJoint *_other);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t(size_t inCount);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new`.
JOLT_API void *Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
JOLT_API void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
