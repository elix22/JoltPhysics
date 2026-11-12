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
typedef struct JPH_RefTarget_JPH_VehicleControllerSettings JPH_RefTarget_JPH_VehicleControllerSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_WheelSettings JPH_RefTarget_JPH_WheelSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_SpringSettings JPH_SpringSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/SpringSettings.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleController JPH_VehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleController.h>`.
typedef struct JPH_VehicleControllerSettings JPH_VehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleController.h>`.
typedef struct JPH_VehicleEngine JPH_VehicleEngine; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleEngine.h>`.
typedef struct JPH_VehicleEngineSettings JPH_VehicleEngineSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleEngine.h>`.
typedef struct JPH_VehicleTrackSettings JPH_VehicleTrackSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTrack.h>`.
typedef struct JPH_VehicleTransmission JPH_VehicleTransmission; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_VehicleTransmissionSettings JPH_VehicleTransmissionSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_Wheel JPH_Wheel; // Defined in `#include <jolt/Jolt/Physics/Vehicle/Wheel.h>`.
typedef struct JPH_WheelSettings JPH_WheelSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/Wheel.h>`.


/// WheelSettings object specifically for TrackedVehicleController
/// Generated from class `JPH::WheelSettingsTV`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::WheelSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::WheelSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_WheelSettingsTV JPH_WheelSettingsTV;

/// Wheel object specifically for TrackedVehicleController
/// Generated from class `JPH::WheelTV`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Wheel`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_WheelTV JPH_WheelTV;

/// Settings of a vehicle with tank tracks
///
/// Default settings are based around what I could find about the M1 Abrams tank.
/// Note to avoid issues with very heavy objects vs very light objects the mass of the tank should be a lot lower (say 10x) than that of a real tank. That means that the engine/brake torque is also 10x less.
/// Generated from class `JPH::TrackedVehicleControllerSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleControllerSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TrackedVehicleControllerSettings JPH_TrackedVehicleControllerSettings;

/// Runtime controller class for vehicle with tank tracks
/// Generated from class `JPH::TrackedVehicleController`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleController`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_TrackedVehicleController JPH_TrackedVehicleController;

///< Friction in forward direction of tire
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mLongitudinalFriction(const JPH_WheelSettingsTV *_this);

///< Friction in forward direction of tire
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLongitudinalFriction`.
JOLT_API void JPH_WheelSettingsTV_Set_mLongitudinalFriction(JPH_WheelSettingsTV *_this, float value);

///< Friction in forward direction of tire
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction(JPH_WheelSettingsTV *_this);

///< Friction in sideways direction of tire
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mLateralFriction(const JPH_WheelSettingsTV *_this);

///< Friction in sideways direction of tire
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLateralFriction`.
JOLT_API void JPH_WheelSettingsTV_Set_mLateralFriction(JPH_WheelSettingsTV *_this, float value);

///< Friction in sideways direction of tire
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mLateralFriction(JPH_WheelSettingsTV *_this);

///< Attachment point of wheel suspension in local space of the body
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mPosition(const JPH_WheelSettingsTV *_this);

///< Attachment point of wheel suspension in local space of the body
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mPosition(JPH_WheelSettingsTV *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSuspensionForcePoint(const JPH_WheelSettingsTV *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint(JPH_WheelSettingsTV *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSuspensionDirection(const JPH_WheelSettingsTV *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSuspensionDirection(JPH_WheelSettingsTV *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSteeringAxis(const JPH_WheelSettingsTV *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSteeringAxis(JPH_WheelSettingsTV *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mWheelUp(const JPH_WheelSettingsTV *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mWheelUp(JPH_WheelSettingsTV *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsTV_Get_mWheelForward(const JPH_WheelSettingsTV *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mWheelForward(JPH_WheelSettingsTV *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mSuspensionMinLength(const JPH_WheelSettingsTV *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMinLength`.
JOLT_API void JPH_WheelSettingsTV_Set_mSuspensionMinLength(JPH_WheelSettingsTV *_this, float value);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength(JPH_WheelSettingsTV *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mSuspensionMaxLength(const JPH_WheelSettingsTV *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMaxLength`.
JOLT_API void JPH_WheelSettingsTV_Set_mSuspensionMaxLength(JPH_WheelSettingsTV *_this, float value);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength(JPH_WheelSettingsTV *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mSuspensionPreloadLength(const JPH_WheelSettingsTV *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionPreloadLength`.
JOLT_API void JPH_WheelSettingsTV_Set_mSuspensionPreloadLength(JPH_WheelSettingsTV *_this, float value);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength(JPH_WheelSettingsTV *_this);

///< Settings for the suspension spring
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionSpring`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SpringSettings *JPH_WheelSettingsTV_Get_mSuspensionSpring(const JPH_WheelSettingsTV *_this);

///< Settings for the suspension spring
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mSuspensionSpring`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SpringSettings *JPH_WheelSettingsTV_GetMutable_mSuspensionSpring(JPH_WheelSettingsTV *_this);

///< Radius of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mRadius(const JPH_WheelSettingsTV *_this);

///< Radius of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRadius`.
JOLT_API void JPH_WheelSettingsTV_Set_mRadius(JPH_WheelSettingsTV *_this, float value);

///< Radius of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mRadius(JPH_WheelSettingsTV *_this);

///< Width of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsTV_Get_mWidth(const JPH_WheelSettingsTV *_this);

///< Width of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWidth`.
JOLT_API void JPH_WheelSettingsTV_Set_mWidth(JPH_WheelSettingsTV *_this, float value);

///< Width of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsTV_GetMutable_mWidth(JPH_WheelSettingsTV *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsTV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint(const JPH_WheelSettingsTV *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Modifies a member variable of class `JPH::WheelSettingsTV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnableSuspensionForcePoint`.
JOLT_API void JPH_WheelSettingsTV_Set_mEnableSuspensionForcePoint(JPH_WheelSettingsTV *_this, bool value);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsTV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettingsTV *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettingsTV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_WheelSettingsTV_DestroyArray()`.
/// Use `JPH_WheelSettingsTV_OffsetMutablePtr()` and `JPH_WheelSettingsTV_OffsetPtr()` to access the array elements.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsTV *JPH_WheelSettingsTV_OffsetPtr(const JPH_WheelSettingsTV *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_OffsetMutablePtr(JPH_WheelSettingsTV *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(const JPH_WheelSettingsTV *object);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_WheelSettingsTV_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettingsTV *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettingsTV *object);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsTV_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettingsTV *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::WheelSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettings *JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(const JPH_WheelSettingsTV *object);

/// Upcasts an instance of `JPH::WheelSettingsTV` to its base class `JPH::WheelSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettings *JPH_WheelSettingsTV_MutableUpcastTo_JPH_WheelSettings(JPH_WheelSettingsTV *object);

/// Downcasts an instance of `JPH::WheelSettings` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(const JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::WheelSettings` to a derived class `JPH::WheelSettingsTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_WheelSettings(JPH_WheelSettings *object);

/// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettingsTV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettingsTV *_other);

/// Destroys a heap-allocated instance of `JPH_WheelSettingsTV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettingsTV_Destroy(const JPH_WheelSettingsTV *_this);

/// Destroys a heap-allocated array of `JPH_WheelSettingsTV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettingsTV_DestroyArray(const JPH_WheelSettingsTV *_this);

/// Generated from method `JPH::WheelSettingsTV::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_WheelSettingsTV *JPH_WheelSettingsTV_AssignFromAnother(JPH_WheelSettingsTV *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettingsTV *_other);

/// Generated from method `JPH::WheelSettingsTV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettingsTV_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettingsTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsTV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettingsTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettingsTV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettingsTV_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettingsTV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettingsTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheelSettingsTV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::WheelSettingsTV::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsTV_SetEmbedded(const JPH_WheelSettingsTV *_this);

/// Get current refcount of this object
/// Generated from method `JPH::WheelSettingsTV::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_WheelSettingsTV_GetRefCount(const JPH_WheelSettingsTV *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::WheelSettingsTV::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsTV_AddRef(const JPH_WheelSettingsTV *_this);

/// Generated from method `JPH::WheelSettingsTV::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsTV_Release(const JPH_WheelSettingsTV *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::WheelSettingsTV::sInternalGetRefCountOffset`.
JOLT_API int JPH_WheelSettingsTV_sInternalGetRefCountOffset(void);

///< Index in mTracks to which this wheel is attached (calculated on initialization)
/// Returns a pointer to a member variable of class `JPH::WheelTV` named `mTrackIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_WheelTV_Get_mTrackIndex(const JPH_WheelTV *_this);

///< Index in mTracks to which this wheel is attached (calculated on initialization)
/// Modifies a member variable of class `JPH::WheelTV` named `mTrackIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTrackIndex`.
JOLT_API void JPH_WheelTV_Set_mTrackIndex(JPH_WheelTV *_this, int value);

///< Index in mTracks to which this wheel is attached (calculated on initialization)
/// Returns a mutable pointer to a member variable of class `JPH::WheelTV` named `mTrackIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_WheelTV_GetMutable_mTrackIndex(JPH_WheelTV *_this);

///< Combined friction coefficient in longitudinal direction (combines terrain and track)
/// Returns a pointer to a member variable of class `JPH::WheelTV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelTV_Get_mCombinedLongitudinalFriction(const JPH_WheelTV *_this);

///< Combined friction coefficient in longitudinal direction (combines terrain and track)
/// Modifies a member variable of class `JPH::WheelTV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedLongitudinalFriction`.
JOLT_API void JPH_WheelTV_Set_mCombinedLongitudinalFriction(JPH_WheelTV *_this, float value);

///< Combined friction coefficient in longitudinal direction (combines terrain and track)
/// Returns a mutable pointer to a member variable of class `JPH::WheelTV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction(JPH_WheelTV *_this);

///< Combined friction coefficient in lateral direction (combines terrain and track)
/// Returns a pointer to a member variable of class `JPH::WheelTV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelTV_Get_mCombinedLateralFriction(const JPH_WheelTV *_this);

///< Combined friction coefficient in lateral direction (combines terrain and track)
/// Modifies a member variable of class `JPH::WheelTV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedLateralFriction`.
JOLT_API void JPH_WheelTV_Set_mCombinedLateralFriction(JPH_WheelTV *_this, float value);

///< Combined friction coefficient in lateral direction (combines terrain and track)
/// Returns a mutable pointer to a member variable of class `JPH::WheelTV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelTV_GetMutable_mCombinedLateralFriction(JPH_WheelTV *_this);

///< Amount of impulse that the brakes can apply to the floor (excluding friction), spread out from brake impulse applied on track
/// Returns a pointer to a member variable of class `JPH::WheelTV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelTV_Get_mBrakeImpulse(const JPH_WheelTV *_this);

///< Amount of impulse that the brakes can apply to the floor (excluding friction), spread out from brake impulse applied on track
/// Modifies a member variable of class `JPH::WheelTV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBrakeImpulse`.
JOLT_API void JPH_WheelTV_Set_mBrakeImpulse(JPH_WheelTV *_this, float value);

///< Amount of impulse that the brakes can apply to the floor (excluding friction), spread out from brake impulse applied on track
/// Returns a mutable pointer to a member variable of class `JPH::WheelTV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelTV_GetMutable_mBrakeImpulse(JPH_WheelTV *_this);

/// Constructor
/// Generated from constructor `JPH::WheelTV::WheelTV`.
/// Parameter `inWheel` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelTV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelTV *JPH_WheelTV_Construct(const JPH_WheelSettingsTV *inWheel);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheelTV *JPH_WheelTV_OffsetPtr(const JPH_WheelTV *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheelTV *JPH_WheelTV_OffsetMutablePtr(JPH_WheelTV *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheelTV` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_WheelTV_UpcastTo_JPH_NonCopyable(const JPH_WheelTV *object);

/// Upcasts an instance of `JPH::WheelTV` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_WheelTV_MutableUpcastTo_JPH_NonCopyable(JPH_WheelTV *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheelTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelTV *JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheelTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelTV *JPH_WheelTV_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::WheelTV` to its base class `JPH::Wheel`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Wheel *JPH_WheelTV_UpcastTo_JPH_Wheel(const JPH_WheelTV *object);

/// Upcasts an instance of `JPH::WheelTV` to its base class `JPH::Wheel`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Wheel *JPH_WheelTV_MutableUpcastTo_JPH_Wheel(JPH_WheelTV *object);

/// Downcasts an instance of `JPH::Wheel` to a derived class `JPH::WheelTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelTV *JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(const JPH_Wheel *object);

/// Downcasts an instance of `JPH::Wheel` to a derived class `JPH::WheelTV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelTV *JPH_WheelTV_MutableStaticDowncastFrom_JPH_Wheel(JPH_Wheel *object);

/// Destroys a heap-allocated instance of `JPH_WheelTV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelTV_Destroy(const JPH_WheelTV *_this);

/// Destroys a heap-allocated array of `JPH_WheelTV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelTV_DestroyArray(const JPH_WheelTV *_this);

/// Generated from method `JPH::WheelTV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelTV_size_t(size_t inCount);

/// Generated from method `JPH::WheelTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelTV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelTV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelTV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelTV_size_t(size_t inCount);

/// Generated from method `JPH::WheelTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelTV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelTV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelTV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelTV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelTV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheelTV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelTV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelTV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Override GetSettings and cast to the correct class
/// Generated from method `JPH::WheelTV::GetSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_WheelSettingsTV *JPH_WheelTV_GetSettings(const JPH_WheelTV *_this);

/// Update the angular velocity of the wheel based on the angular velocity of the track
/// Generated from method `JPH::WheelTV::CalculateAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API void JPH_WheelTV_CalculateAngularVelocity(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint);

/// Update the wheel rotation based on the current angular velocity
/// Generated from method `JPH::WheelTV::Update`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API void JPH_WheelTV_Update(JPH_WheelTV *_this, unsigned int inWheelIndex, float inDeltaTime, const JPH_VehicleConstraint *inConstraint);

/// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
/// Generated from method `JPH::WheelTV::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetAngularVelocity(const JPH_WheelTV *_this);

/// Update the angular velocity (rad/s)
/// Generated from method `JPH::WheelTV::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelTV_SetAngularVelocity(JPH_WheelTV *_this, float inVel);

/// Get the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::WheelTV::GetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetRotationAngle(const JPH_WheelTV *_this);

/// Set the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::WheelTV::SetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelTV_SetRotationAngle(JPH_WheelTV *_this, float inAngle);

/// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
/// Generated from method `JPH::WheelTV::GetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetSteerAngle(const JPH_WheelTV *_this);

/// Set the current steer angle of the wheel in radians [-pi, pi]
/// Generated from method `JPH::WheelTV::SetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelTV_SetSteerAngle(JPH_WheelTV *_this, float inAngle);

/// Returns true if the wheel is touching an object
/// Generated from method `JPH::WheelTV::HasContact`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_WheelTV_HasContact(const JPH_WheelTV *_this);

/// Returns the body ID of the body that this wheel is touching
/// Generated from method `JPH::WheelTV::GetContactBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_WheelTV_GetContactBodyID(const JPH_WheelTV *_this);

/// Returns the sub shape ID where we're contacting the body
/// Generated from method `JPH::WheelTV::GetContactSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_WheelTV_GetContactSubShapeID(const JPH_WheelTV *_this);

/// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelTV::GetContactPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelTV_GetContactPosition(const JPH_WheelTV *_this);

/// Velocity of the contact point (m / s, not relative to the wheel but in world space)
/// Generated from method `JPH::WheelTV::GetContactPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelTV_GetContactPointVelocity(const JPH_WheelTV *_this);

/// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelTV::GetContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelTV_GetContactNormal(const JPH_WheelTV *_this);

/// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelTV::GetContactLongitudinal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelTV_GetContactLongitudinal(const JPH_WheelTV *_this);

/// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelTV::GetContactLateral`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelTV_GetContactLateral(const JPH_WheelTV *_this);

/// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
/// Generated from method `JPH::WheelTV::GetSuspensionLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetSuspensionLength(const JPH_WheelTV *_this);

/// Check if the suspension hit its upper limit
/// Generated from method `JPH::WheelTV::HasHitHardPoint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_WheelTV_HasHitHardPoint(const JPH_WheelTV *_this);

/// Get the total impulse (N s) that was applied by the suspension
/// Generated from method `JPH::WheelTV::GetSuspensionLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetSuspensionLambda(const JPH_WheelTV *_this);

/// Get total impulse (N s) applied along the forward direction of the wheel
/// Generated from method `JPH::WheelTV::GetLongitudinalLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetLongitudinalLambda(const JPH_WheelTV *_this);

/// Get total impulse (N s) applied along the sideways direction of the wheel
/// Generated from method `JPH::WheelTV::GetLateralLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelTV_GetLateralLambda(const JPH_WheelTV *_this);

/// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
/// Generated from method `JPH::WheelTV::SolveLongitudinalConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_WheelTV_SolveLongitudinalConstraintPart(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

/// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
/// Generated from method `JPH::WheelTV::SolveLateralConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_WheelTV_SolveLateralConstraintPart(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

///< The properties of the engine
/// Returns a pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleEngineSettings *JPH_TrackedVehicleControllerSettings_Get_mEngine(const JPH_TrackedVehicleControllerSettings *_this);

///< The properties of the engine
/// Modifies a member variable of class `JPH::TrackedVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mEngine`.
/// When this function is called, this object will drop object references it held previously in `mEngine`.
JOLT_API void JPH_TrackedVehicleControllerSettings_Set_mEngine(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value);

///< The properties of the engine
/// Returns a mutable pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleEngineSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mEngine(JPH_TrackedVehicleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Returns a pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleTransmissionSettings *JPH_TrackedVehicleControllerSettings_Get_mTransmission(const JPH_TrackedVehicleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Modifies a member variable of class `JPH::TrackedVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mTransmission`.
/// When this function is called, this object will drop object references it held previously in `mTransmission`.
JOLT_API void JPH_TrackedVehicleControllerSettings_Set_mTransmission(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value);

///< The properties of the transmission (aka gear box)
/// Returns a mutable pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleTransmissionSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission(JPH_TrackedVehicleControllerSettings *_this);

///< List of tracks and their properties
/// Returns a pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mTracks`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleTrackSettings *JPH_TrackedVehicleControllerSettings_Get_mTracks(const JPH_TrackedVehicleControllerSettings *_this);

///< List of tracks and their properties
/// Returns a mutable pointer to a member variable of class `JPH::TrackedVehicleControllerSettings` named `mTracks`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleTrackSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mTracks(JPH_TrackedVehicleControllerSettings *_this);

/// Returns the size of the array member of class `JPH::TrackedVehicleControllerSettings` named `mTracks`. The size is `2`.
JOLT_API size_t JPH_TrackedVehicleControllerSettings_GetSize_mTracks(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TrackedVehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TrackedVehicleControllerSettings_DestroyArray()`.
/// Use `JPH_TrackedVehicleControllerSettings_OffsetMutablePtr()` and `JPH_TrackedVehicleControllerSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_OffsetPtr(const JPH_TrackedVehicleControllerSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_OffsetMutablePtr(JPH_TrackedVehicleControllerSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_TrackedVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TrackedVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_TrackedVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_TrackedVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_TrackedVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::TrackedVehicleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_TrackedVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::TrackedVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object);

/// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TrackedVehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TrackedVehicleControllerSettings *_other);

/// Destroys a heap-allocated instance of `JPH_TrackedVehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TrackedVehicleControllerSettings_Destroy(const JPH_TrackedVehicleControllerSettings *_this);

/// Destroys a heap-allocated array of `JPH_TrackedVehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_TrackedVehicleControllerSettings_DestroyArray(const JPH_TrackedVehicleControllerSettings *_this);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_AssignFromAnother(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_TrackedVehicleControllerSettings *_other);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TrackedVehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleControllerSettings
/// Generated from method `JPH::TrackedVehicleControllerSettings::ConstructController`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API JPH_VehicleController *JPH_TrackedVehicleControllerSettings_ConstructController(const JPH_TrackedVehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::TrackedVehicleControllerSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleControllerSettings_SetEmbedded(const JPH_TrackedVehicleControllerSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::TrackedVehicleControllerSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_TrackedVehicleControllerSettings_GetRefCount(const JPH_TrackedVehicleControllerSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::TrackedVehicleControllerSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleControllerSettings_AddRef(const JPH_TrackedVehicleControllerSettings *_this);

/// Generated from method `JPH::TrackedVehicleControllerSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleControllerSettings_Release(const JPH_TrackedVehicleControllerSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::TrackedVehicleControllerSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// Generated from constructor `JPH::TrackedVehicleController::TrackedVehicleController`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TrackedVehicleController_Destroy()` to free it when you're done using it.
JOLT_API JPH_TrackedVehicleController *JPH_TrackedVehicleController_Construct(const JPH_TrackedVehicleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleController *JPH_TrackedVehicleController_OffsetPtr(const JPH_TrackedVehicleController *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleController *JPH_TrackedVehicleController_OffsetMutablePtr(JPH_TrackedVehicleController *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TrackedVehicleController` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(const JPH_TrackedVehicleController *object);

/// Upcasts an instance of `JPH::TrackedVehicleController` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TrackedVehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_TrackedVehicleController *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TrackedVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleController *JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TrackedVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleController *JPH_TrackedVehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TrackedVehicleController` to its base class `JPH::VehicleController`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleController *JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(const JPH_TrackedVehicleController *object);

/// Upcasts an instance of `JPH::TrackedVehicleController` to its base class `JPH::VehicleController`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleController *JPH_TrackedVehicleController_MutableUpcastTo_JPH_VehicleController(JPH_TrackedVehicleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::TrackedVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TrackedVehicleController *JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::TrackedVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TrackedVehicleController *JPH_TrackedVehicleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object);

/// Destroys a heap-allocated instance of `JPH_TrackedVehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_TrackedVehicleController_Destroy(const JPH_TrackedVehicleController *_this);

/// Destroys a heap-allocated array of `JPH_TrackedVehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_TrackedVehicleController_DestroyArray(const JPH_TrackedVehicleController *_this);

/// Generated from method `JPH::TrackedVehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_TrackedVehicleController_size_t(size_t inCount);

/// Generated from method `JPH::TrackedVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::TrackedVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TrackedVehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TrackedVehicleController_size_t(size_t inCount);

/// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::TrackedVehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TrackedVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TrackedVehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set input from driver
/// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// @param inLeftRatio Value between -1 and 1 indicating an extra multiplier to the rotation rate of the left track (used for steering)
/// @param inRightRatio Value between -1 and 1 indicating an extra multiplier to the rotation rate of the right track (used for steering)
/// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
/// Generated from method `JPH::TrackedVehicleController::SetDriverInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetDriverInput(JPH_TrackedVehicleController *_this, float inForward, float inLeftRatio, float inRightRatio, float inBrake);

/// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// Generated from method `JPH::TrackedVehicleController::SetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetForwardInput(JPH_TrackedVehicleController *_this, float inForward);

/// Generated from method `JPH::TrackedVehicleController::GetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TrackedVehicleController_GetForwardInput(const JPH_TrackedVehicleController *_this);

/// Value between -1 and 1 indicating an extra multiplier to the rotation rate of the left track (used for steering)
/// Generated from method `JPH::TrackedVehicleController::SetLeftRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetLeftRatio(JPH_TrackedVehicleController *_this, float inLeftRatio);

/// Generated from method `JPH::TrackedVehicleController::GetLeftRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TrackedVehicleController_GetLeftRatio(const JPH_TrackedVehicleController *_this);

/// Value between -1 and 1 indicating an extra multiplier to the rotation rate of the right track (used for steering)
/// Generated from method `JPH::TrackedVehicleController::SetRightRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetRightRatio(JPH_TrackedVehicleController *_this, float inRightRatio);

/// Generated from method `JPH::TrackedVehicleController::GetRightRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TrackedVehicleController_GetRightRatio(const JPH_TrackedVehicleController *_this);

/// Value between 0 and 1 indicating how strong the brake pedal is pressed
/// Generated from method `JPH::TrackedVehicleController::SetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetBrakeInput(JPH_TrackedVehicleController *_this, float inBrake);

/// Generated from method `JPH::TrackedVehicleController::GetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_TrackedVehicleController_GetBrakeInput(const JPH_TrackedVehicleController *_this);

/// Get current engine state
/// Generated from method `JPH::TrackedVehicleController::GetEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_VehicleEngine *JPH_TrackedVehicleController_GetEngine(const JPH_TrackedVehicleController *_this);

/// Get current engine state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
/// Generated from method `JPH::TrackedVehicleController::GetEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_VehicleEngine *JPH_TrackedVehicleController_GetEngine_mut(JPH_TrackedVehicleController *_this);

/// Get current transmission state
/// Generated from method `JPH::TrackedVehicleController::GetTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_VehicleTransmission *JPH_TrackedVehicleController_GetTransmission(const JPH_TrackedVehicleController *_this);

/// Get current transmission state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
/// Generated from method `JPH::TrackedVehicleController::GetTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_VehicleTransmission *JPH_TrackedVehicleController_GetTransmission_mut(JPH_TrackedVehicleController *_this);

/// Debug drawing of RPM meter
/// Generated from method `JPH::TrackedVehicleController::SetRPMMeter`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_TrackedVehicleController_SetRPMMeter(JPH_TrackedVehicleController *_this, const JPH_Vec3 *inPosition, float inSize);

#ifdef __cplusplus
} // extern "C"
#endif
