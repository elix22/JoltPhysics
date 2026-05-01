// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_WheelSettings JPH_RefTarget_JPH_WheelSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.


/// Base class for wheel settings, each VehicleController can implement a derived class of this
/// Generated from class `JPH::WheelSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::WheelSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::WheelSettingsWV`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_WheelSettings JPH_WheelSettings;

/// Base class for runtime data for a wheel, each VehicleController can implement a derived class of this
/// Generated from class `JPH::Wheel`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::WheelWV`
typedef struct JPH_Wheel JPH_Wheel;

///< Attachment point of wheel suspension in local space of the body
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mPosition(const JPH_WheelSettings *_this);

///< Attachment point of wheel suspension in local space of the body
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mPosition(JPH_WheelSettings *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mSuspensionForcePoint(const JPH_WheelSettings *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mSuspensionForcePoint(JPH_WheelSettings *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mSuspensionDirection(const JPH_WheelSettings *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mSuspensionDirection(JPH_WheelSettings *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mSteeringAxis(const JPH_WheelSettings *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mSteeringAxis(JPH_WheelSettings *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mWheelUp(const JPH_WheelSettings *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mWheelUp(JPH_WheelSettings *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettings_Get_mWheelForward(const JPH_WheelSettings *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettings_GetMutable_mWheelForward(JPH_WheelSettings *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettings_Get_mSuspensionMinLength(const JPH_WheelSettings *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettings` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMinLength`.
JOLT_API void JPH_WheelSettings_Set_mSuspensionMinLength(JPH_WheelSettings *_this, float value);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettings_GetMutable_mSuspensionMinLength(JPH_WheelSettings *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettings_Get_mSuspensionMaxLength(const JPH_WheelSettings *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettings` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMaxLength`.
JOLT_API void JPH_WheelSettings_Set_mSuspensionMaxLength(JPH_WheelSettings *_this, float value);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettings_GetMutable_mSuspensionMaxLength(JPH_WheelSettings *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettings_Get_mSuspensionPreloadLength(const JPH_WheelSettings *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Modifies a member variable of class `JPH::WheelSettings` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionPreloadLength`.
JOLT_API void JPH_WheelSettings_Set_mSuspensionPreloadLength(JPH_WheelSettings *_this, float value);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettings_GetMutable_mSuspensionPreloadLength(JPH_WheelSettings *_this);

///< Radius of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettings_Get_mRadius(const JPH_WheelSettings *_this);

///< Radius of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRadius`.
JOLT_API void JPH_WheelSettings_Set_mRadius(JPH_WheelSettings *_this, float value);

///< Radius of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettings_GetMutable_mRadius(JPH_WheelSettings *_this);

///< Width of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettings_Get_mWidth(const JPH_WheelSettings *_this);

///< Width of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettings` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWidth`.
JOLT_API void JPH_WheelSettings_Set_mWidth(JPH_WheelSettings *_this, float value);

///< Width of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettings_GetMutable_mWidth(JPH_WheelSettings *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a pointer to a member variable of class `JPH::WheelSettings` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_WheelSettings_Get_mEnableSuspensionForcePoint(const JPH_WheelSettings *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Modifies a member variable of class `JPH::WheelSettings` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnableSuspensionForcePoint`.
JOLT_API void JPH_WheelSettings_Set_mEnableSuspensionForcePoint(JPH_WheelSettings *_this, bool value);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettings` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_WheelSettings_DestroyArray()`.
/// Use `JPH_WheelSettings_OffsetMutablePtr()` and `JPH_WheelSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheelSettings *JPH_WheelSettings_OffsetPtr(const JPH_WheelSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_OffsetMutablePtr(JPH_WheelSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheelSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_WheelSettings_UpcastTo_JPH_SerializableObject(const JPH_WheelSettings *object);

/// Upcasts an instance of `JPH::WheelSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_WheelSettings_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettings *JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::WheelSettings` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettings *object);

/// Upcasts an instance of `JPH::WheelSettings` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettings_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettings *JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object);

/// Generated from constructor `JPH::WheelSettings::WheelSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettings *_other);

/// Destroys a heap-allocated instance of `JPH_WheelSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettings_Destroy(const JPH_WheelSettings *_this);

/// Destroys a heap-allocated array of `JPH_WheelSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettings_DestroyArray(const JPH_WheelSettings *_this);

/// Generated from method `JPH::WheelSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_WheelSettings *JPH_WheelSettings_AssignFromAnother(JPH_WheelSettings *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettings *_other);

/// Generated from method `JPH::WheelSettings::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettings_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettings_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettings::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheelSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::WheelSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettings_SetEmbedded(const JPH_WheelSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::WheelSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_WheelSettings_GetRefCount(const JPH_WheelSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::WheelSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettings_AddRef(const JPH_WheelSettings *_this);

/// Generated from method `JPH::WheelSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettings_Release(const JPH_WheelSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::WheelSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_WheelSettings_sInternalGetRefCountOffset(void);

/// Constructor / destructor
/// Generated from constructor `JPH::Wheel::Wheel`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Wheel_Destroy()` to free it when you're done using it.
JOLT_API JPH_Wheel *JPH_Wheel_Construct(const JPH_WheelSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Wheel *JPH_Wheel_OffsetPtr(const JPH_Wheel *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Wheel *JPH_Wheel_OffsetMutablePtr(JPH_Wheel *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Wheel` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Wheel_UpcastTo_JPH_NonCopyable(const JPH_Wheel *object);

/// Upcasts an instance of `JPH::Wheel` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Wheel_MutableUpcastTo_JPH_NonCopyable(JPH_Wheel *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Wheel`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Wheel *JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Wheel`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Wheel *JPH_Wheel_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_Wheel`. Does nothing if the pointer is null.
JOLT_API void JPH_Wheel_Destroy(const JPH_Wheel *_this);

/// Destroys a heap-allocated array of `JPH_Wheel`. Does nothing if the pointer is null.
JOLT_API void JPH_Wheel_DestroyArray(const JPH_Wheel *_this);

/// Generated from method `JPH::Wheel::operator new`.
JOLT_API void *Jolt_new_JPH_Wheel_size_t(size_t inCount);

/// Generated from method `JPH::Wheel::operator delete`.
JOLT_API void Jolt_delete_JPH_Wheel_void_ptr(void *inPointer);

/// Generated from method `JPH::Wheel::operator delete`.
JOLT_API void Jolt_delete_JPH_Wheel_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Wheel::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Wheel_size_t(size_t inCount);

/// Generated from method `JPH::Wheel::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Wheel_void_ptr(void *inPointer);

/// Generated from method `JPH::Wheel::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Wheel_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Wheel::operator new`.
JOLT_API void *Jolt_new_JPH_Wheel_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Wheel::operator delete`.
JOLT_API void Jolt_delete_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Wheel::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Wheel_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Wheel::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get settings for the wheel
/// Generated from method `JPH::Wheel::GetSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_WheelSettings *JPH_Wheel_GetSettings(const JPH_Wheel *_this);

/// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
/// Generated from method `JPH::Wheel::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetAngularVelocity(const JPH_Wheel *_this);

/// Update the angular velocity (rad/s)
/// Generated from method `JPH::Wheel::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Wheel_SetAngularVelocity(JPH_Wheel *_this, float inVel);

/// Get the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::Wheel::GetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetRotationAngle(const JPH_Wheel *_this);

/// Set the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::Wheel::SetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Wheel_SetRotationAngle(JPH_Wheel *_this, float inAngle);

/// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
/// Generated from method `JPH::Wheel::GetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetSteerAngle(const JPH_Wheel *_this);

/// Set the current steer angle of the wheel in radians [-pi, pi]
/// Generated from method `JPH::Wheel::SetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Wheel_SetSteerAngle(JPH_Wheel *_this, float inAngle);

/// Returns true if the wheel is touching an object
/// Generated from method `JPH::Wheel::HasContact`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Wheel_HasContact(const JPH_Wheel *_this);

/// Returns the body ID of the body that this wheel is touching
/// Generated from method `JPH::Wheel::GetContactBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_Wheel_GetContactBodyID(const JPH_Wheel *_this);

/// Returns the sub shape ID where we're contacting the body
/// Generated from method `JPH::Wheel::GetContactSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_Wheel_GetContactSubShapeID(const JPH_Wheel *_this);

/// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::Wheel::GetContactPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Wheel_GetContactPosition(const JPH_Wheel *_this);

/// Velocity of the contact point (m / s, not relative to the wheel but in world space)
/// Generated from method `JPH::Wheel::GetContactPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Wheel_GetContactPointVelocity(const JPH_Wheel *_this);

/// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::Wheel::GetContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Wheel_GetContactNormal(const JPH_Wheel *_this);

/// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::Wheel::GetContactLongitudinal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Wheel_GetContactLongitudinal(const JPH_Wheel *_this);

/// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::Wheel::GetContactLateral`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Wheel_GetContactLateral(const JPH_Wheel *_this);

/// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
/// Generated from method `JPH::Wheel::GetSuspensionLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetSuspensionLength(const JPH_Wheel *_this);

/// Check if the suspension hit its upper limit
/// Generated from method `JPH::Wheel::HasHitHardPoint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Wheel_HasHitHardPoint(const JPH_Wheel *_this);

/// Get the total impulse (N s) that was applied by the suspension
/// Generated from method `JPH::Wheel::GetSuspensionLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetSuspensionLambda(const JPH_Wheel *_this);

/// Get total impulse (N s) applied along the forward direction of the wheel
/// Generated from method `JPH::Wheel::GetLongitudinalLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetLongitudinalLambda(const JPH_Wheel *_this);

/// Get total impulse (N s) applied along the sideways direction of the wheel
/// Generated from method `JPH::Wheel::GetLateralLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Wheel_GetLateralLambda(const JPH_Wheel *_this);

/// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
/// Generated from method `JPH::Wheel::SolveLongitudinalConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_Wheel_SolveLongitudinalConstraintPart(JPH_Wheel *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

/// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
/// Generated from method `JPH::Wheel::SolveLateralConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_Wheel_SolveLateralConstraintPart(JPH_Wheel *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

#ifdef __cplusplus
} // extern "C"
#endif
