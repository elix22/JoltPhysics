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
typedef struct JPH_VehicleTransmission JPH_VehicleTransmission; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_VehicleTransmissionSettings JPH_VehicleTransmissionSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_Wheel JPH_Wheel; // Defined in `#include <jolt/Jolt/Physics/Vehicle/Wheel.h>`.
typedef struct JPH_WheelSettings JPH_WheelSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/Wheel.h>`.
typedef struct Jolt_JPH_Array_JPH_VehicleDifferentialSettings Jolt_JPH_Array_JPH_VehicleDifferentialSettings; // Defined in `#include <JPH_Array_JPH_VehicleDifferentialSettings.h>`.
typedef struct Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float; // Defined in `#include <std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float.h>`.


/// WheelSettings object specifically for WheeledVehicleController
/// Generated from class `JPH::WheelSettingsWV`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::WheelSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::WheelSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_WheelSettingsWV JPH_WheelSettingsWV;

/// Wheel object specifically for WheeledVehicleController
/// Generated from class `JPH::WheelWV`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Wheel`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_WheelWV JPH_WheelWV;

/// Settings of a vehicle with regular wheels
///
/// The properties in this controller are largely based on "Car Physics for Games" by Marco Monster.
/// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
/// Generated from class `JPH::WheeledVehicleControllerSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleControllerSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::MotorcycleControllerSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_WheeledVehicleControllerSettings JPH_WheeledVehicleControllerSettings;

/// Runtime controller class
/// Generated from class `JPH::WheeledVehicleController`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleController`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::MotorcycleController`
typedef struct JPH_WheeledVehicleController JPH_WheeledVehicleController;

///< Moment of inertia (kg m^2), for a cylinder this would be 0.5 * M * R^2 which is 0.9 for a wheel with a mass of 20 kg and radius 0.3 m
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mInertia(const JPH_WheelSettingsWV *_this);

///< Moment of inertia (kg m^2), for a cylinder this would be 0.5 * M * R^2 which is 0.9 for a wheel with a mass of 20 kg and radius 0.3 m
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertia`.
JOLT_API void JPH_WheelSettingsWV_Set_mInertia(JPH_WheelSettingsWV *_this, float value);

///< Moment of inertia (kg m^2), for a cylinder this would be 0.5 * M * R^2 which is 0.9 for a wheel with a mass of 20 kg and radius 0.3 m
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mInertia(JPH_WheelSettingsWV *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mAngularDamping(const JPH_WheelSettingsWV *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_WheelSettingsWV_Set_mAngularDamping(JPH_WheelSettingsWV *_this, float value);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mAngularDamping(JPH_WheelSettingsWV *_this);

///< How much this wheel can steer (radians)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mMaxSteerAngle(const JPH_WheelSettingsWV *_this);

///< How much this wheel can steer (radians)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mMaxSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxSteerAngle`.
JOLT_API void JPH_WheelSettingsWV_Set_mMaxSteerAngle(JPH_WheelSettingsWV *_this, float value);

///< How much this wheel can steer (radians)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle(JPH_WheelSettingsWV *_this);

///< How much torque (Nm) the brakes can apply to this wheel
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mMaxBrakeTorque(const JPH_WheelSettingsWV *_this);

///< How much torque (Nm) the brakes can apply to this wheel
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxBrakeTorque`.
JOLT_API void JPH_WheelSettingsWV_Set_mMaxBrakeTorque(JPH_WheelSettingsWV *_this, float value);

///< How much torque (Nm) the brakes can apply to this wheel
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque(JPH_WheelSettingsWV *_this);

///< How much torque (Nm) the hand brake can apply to this wheel (usually only applied to the rear wheels)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxHandBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque(const JPH_WheelSettingsWV *_this);

///< How much torque (Nm) the hand brake can apply to this wheel (usually only applied to the rear wheels)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mMaxHandBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxHandBrakeTorque`.
JOLT_API void JPH_WheelSettingsWV_Set_mMaxHandBrakeTorque(JPH_WheelSettingsWV *_this, float value);

///< How much torque (Nm) the hand brake can apply to this wheel (usually only applied to the rear wheels)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mMaxHandBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque(JPH_WheelSettingsWV *_this);

///< Attachment point of wheel suspension in local space of the body
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mPosition(const JPH_WheelSettingsWV *_this);

///< Attachment point of wheel suspension in local space of the body
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mPosition(JPH_WheelSettingsWV *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSuspensionForcePoint(const JPH_WheelSettingsWV *_this);

///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint(JPH_WheelSettingsWV *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSuspensionDirection(const JPH_WheelSettingsWV *_this);

///< Direction of the suspension in local space of the body, should point down
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSuspensionDirection(JPH_WheelSettingsWV *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSteeringAxis(const JPH_WheelSettingsWV *_this);

///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSteeringAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSteeringAxis(JPH_WheelSettingsWV *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mWheelUp(const JPH_WheelSettingsWV *_this);

///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mWheelUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mWheelUp(JPH_WheelSettingsWV *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_WheelSettingsWV_Get_mWheelForward(const JPH_WheelSettingsWV *_this);

///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mWheelForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mWheelForward(JPH_WheelSettingsWV *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mSuspensionMinLength(const JPH_WheelSettingsWV *_this);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMinLength`.
JOLT_API void JPH_WheelSettingsWV_Set_mSuspensionMinLength(JPH_WheelSettingsWV *_this, float value);

///< How long the suspension is in max raised position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMinLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength(JPH_WheelSettingsWV *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mSuspensionMaxLength(const JPH_WheelSettingsWV *_this);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionMaxLength`.
JOLT_API void JPH_WheelSettingsWV_Set_mSuspensionMaxLength(JPH_WheelSettingsWV *_this, float value);

///< How long the suspension is in max droop position relative to the attachment point (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionMaxLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength(JPH_WheelSettingsWV *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mSuspensionPreloadLength(const JPH_WheelSettingsWV *_this);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSuspensionPreloadLength`.
JOLT_API void JPH_WheelSettingsWV_Set_mSuspensionPreloadLength(JPH_WheelSettingsWV *_this, float value);

///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionPreloadLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength(JPH_WheelSettingsWV *_this);

///< Settings for the suspension spring
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionSpring`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SpringSettings *JPH_WheelSettingsWV_Get_mSuspensionSpring(const JPH_WheelSettingsWV *_this);

///< Settings for the suspension spring
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mSuspensionSpring`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SpringSettings *JPH_WheelSettingsWV_GetMutable_mSuspensionSpring(JPH_WheelSettingsWV *_this);

///< Radius of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mRadius(const JPH_WheelSettingsWV *_this);

///< Radius of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRadius`.
JOLT_API void JPH_WheelSettingsWV_Set_mRadius(JPH_WheelSettingsWV *_this, float value);

///< Radius of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mRadius(JPH_WheelSettingsWV *_this);

///< Width of the wheel (m)
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelSettingsWV_Get_mWidth(const JPH_WheelSettingsWV *_this);

///< Width of the wheel (m)
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWidth`.
JOLT_API void JPH_WheelSettingsWV_Set_mWidth(JPH_WheelSettingsWV *_this, float value);

///< Width of the wheel (m)
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mWidth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelSettingsWV_GetMutable_mWidth(JPH_WheelSettingsWV *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a pointer to a member variable of class `JPH::WheelSettingsWV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint(const JPH_WheelSettingsWV *_this);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Modifies a member variable of class `JPH::WheelSettingsWV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnableSuspensionForcePoint`.
JOLT_API void JPH_WheelSettingsWV_Set_mEnableSuspensionForcePoint(JPH_WheelSettingsWV *_this, bool value);

///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
/// Returns a mutable pointer to a member variable of class `JPH::WheelSettingsWV` named `mEnableSuspensionForcePoint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettingsWV *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettingsWV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_WheelSettingsWV_DestroyArray()`.
/// Use `JPH_WheelSettingsWV_OffsetMutablePtr()` and `JPH_WheelSettingsWV_OffsetPtr()` to access the array elements.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsWV *JPH_WheelSettingsWV_OffsetPtr(const JPH_WheelSettingsWV *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_OffsetMutablePtr(JPH_WheelSettingsWV *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(const JPH_WheelSettingsWV *object);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_WheelSettingsWV_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettingsWV *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettingsWV *object);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::RefTarget<JPH::WheelSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsWV_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettingsWV *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::WheelSettings>` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::WheelSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettings *JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(const JPH_WheelSettingsWV *object);

/// Upcasts an instance of `JPH::WheelSettingsWV` to its base class `JPH::WheelSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettings *JPH_WheelSettingsWV_MutableUpcastTo_JPH_WheelSettings(JPH_WheelSettingsWV *object);

/// Downcasts an instance of `JPH::WheelSettings` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(const JPH_WheelSettings *object);

/// Downcasts an instance of `JPH::WheelSettings` to a derived class `JPH::WheelSettingsWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_WheelSettings(JPH_WheelSettings *object);

/// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelSettingsWV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettingsWV *_other);

/// Destroys a heap-allocated instance of `JPH_WheelSettingsWV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettingsWV_Destroy(const JPH_WheelSettingsWV *_this);

/// Destroys a heap-allocated array of `JPH_WheelSettingsWV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelSettingsWV_DestroyArray(const JPH_WheelSettingsWV *_this);

/// Generated from method `JPH::WheelSettingsWV::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_WheelSettingsWV *JPH_WheelSettingsWV_AssignFromAnother(JPH_WheelSettingsWV *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettingsWV *_other);

/// Generated from method `JPH::WheelSettingsWV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettingsWV_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettingsWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsWV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettingsWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettingsWV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettingsWV_size_t(size_t inCount);

/// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelSettingsWV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettingsWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheelSettingsWV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::WheelSettingsWV::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsWV_SetEmbedded(const JPH_WheelSettingsWV *_this);

/// Get current refcount of this object
/// Generated from method `JPH::WheelSettingsWV::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_WheelSettingsWV_GetRefCount(const JPH_WheelSettingsWV *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::WheelSettingsWV::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsWV_AddRef(const JPH_WheelSettingsWV *_this);

/// Generated from method `JPH::WheelSettingsWV::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelSettingsWV_Release(const JPH_WheelSettingsWV *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::WheelSettingsWV::sInternalGetRefCountOffset`.
JOLT_API int JPH_WheelSettingsWV_sInternalGetRefCountOffset(void);

///< Velocity difference between ground and wheel relative to ground velocity
/// Returns a pointer to a member variable of class `JPH::WheelWV` named `mLongitudinalSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelWV_Get_mLongitudinalSlip(const JPH_WheelWV *_this);

///< Velocity difference between ground and wheel relative to ground velocity
/// Modifies a member variable of class `JPH::WheelWV` named `mLongitudinalSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLongitudinalSlip`.
JOLT_API void JPH_WheelWV_Set_mLongitudinalSlip(JPH_WheelWV *_this, float value);

///< Velocity difference between ground and wheel relative to ground velocity
/// Returns a mutable pointer to a member variable of class `JPH::WheelWV` named `mLongitudinalSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelWV_GetMutable_mLongitudinalSlip(JPH_WheelWV *_this);

///< Angular difference (in radians) between ground and wheel relative to ground velocity
/// Returns a pointer to a member variable of class `JPH::WheelWV` named `mLateralSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelWV_Get_mLateralSlip(const JPH_WheelWV *_this);

///< Angular difference (in radians) between ground and wheel relative to ground velocity
/// Modifies a member variable of class `JPH::WheelWV` named `mLateralSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLateralSlip`.
JOLT_API void JPH_WheelWV_Set_mLateralSlip(JPH_WheelWV *_this, float value);

///< Angular difference (in radians) between ground and wheel relative to ground velocity
/// Returns a mutable pointer to a member variable of class `JPH::WheelWV` named `mLateralSlip`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelWV_GetMutable_mLateralSlip(JPH_WheelWV *_this);

///< Combined friction coefficient in longitudinal direction (combines terrain and tires)
/// Returns a pointer to a member variable of class `JPH::WheelWV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelWV_Get_mCombinedLongitudinalFriction(const JPH_WheelWV *_this);

///< Combined friction coefficient in longitudinal direction (combines terrain and tires)
/// Modifies a member variable of class `JPH::WheelWV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedLongitudinalFriction`.
JOLT_API void JPH_WheelWV_Set_mCombinedLongitudinalFriction(JPH_WheelWV *_this, float value);

///< Combined friction coefficient in longitudinal direction (combines terrain and tires)
/// Returns a mutable pointer to a member variable of class `JPH::WheelWV` named `mCombinedLongitudinalFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction(JPH_WheelWV *_this);

///< Combined friction coefficient in lateral direction (combines terrain and tires)
/// Returns a pointer to a member variable of class `JPH::WheelWV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelWV_Get_mCombinedLateralFriction(const JPH_WheelWV *_this);

///< Combined friction coefficient in lateral direction (combines terrain and tires)
/// Modifies a member variable of class `JPH::WheelWV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedLateralFriction`.
JOLT_API void JPH_WheelWV_Set_mCombinedLateralFriction(JPH_WheelWV *_this, float value);

///< Combined friction coefficient in lateral direction (combines terrain and tires)
/// Returns a mutable pointer to a member variable of class `JPH::WheelWV` named `mCombinedLateralFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelWV_GetMutable_mCombinedLateralFriction(JPH_WheelWV *_this);

///< Amount of impulse that the brakes can apply to the floor (excluding friction)
/// Returns a pointer to a member variable of class `JPH::WheelWV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheelWV_Get_mBrakeImpulse(const JPH_WheelWV *_this);

///< Amount of impulse that the brakes can apply to the floor (excluding friction)
/// Modifies a member variable of class `JPH::WheelWV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBrakeImpulse`.
JOLT_API void JPH_WheelWV_Set_mBrakeImpulse(JPH_WheelWV *_this, float value);

///< Amount of impulse that the brakes can apply to the floor (excluding friction)
/// Returns a mutable pointer to a member variable of class `JPH::WheelWV` named `mBrakeImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheelWV_GetMutable_mBrakeImpulse(JPH_WheelWV *_this);

/// Constructor
/// Generated from constructor `JPH::WheelWV::WheelWV`.
/// Parameter `inWheel` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheelWV_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheelWV *JPH_WheelWV_Construct(const JPH_WheelSettingsWV *inWheel);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheelWV *JPH_WheelWV_OffsetPtr(const JPH_WheelWV *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheelWV *JPH_WheelWV_OffsetMutablePtr(JPH_WheelWV *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheelWV` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_WheelWV_UpcastTo_JPH_NonCopyable(const JPH_WheelWV *object);

/// Upcasts an instance of `JPH::WheelWV` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_WheelWV_MutableUpcastTo_JPH_NonCopyable(JPH_WheelWV *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheelWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelWV *JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheelWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelWV *JPH_WheelWV_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::WheelWV` to its base class `JPH::Wheel`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Wheel *JPH_WheelWV_UpcastTo_JPH_Wheel(const JPH_WheelWV *object);

/// Upcasts an instance of `JPH::WheelWV` to its base class `JPH::Wheel`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Wheel *JPH_WheelWV_MutableUpcastTo_JPH_Wheel(JPH_WheelWV *object);

/// Downcasts an instance of `JPH::Wheel` to a derived class `JPH::WheelWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheelWV *JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(const JPH_Wheel *object);

/// Downcasts an instance of `JPH::Wheel` to a derived class `JPH::WheelWV`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheelWV *JPH_WheelWV_MutableStaticDowncastFrom_JPH_Wheel(JPH_Wheel *object);

/// Destroys a heap-allocated instance of `JPH_WheelWV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelWV_Destroy(const JPH_WheelWV *_this);

/// Destroys a heap-allocated array of `JPH_WheelWV`. Does nothing if the pointer is null.
JOLT_API void JPH_WheelWV_DestroyArray(const JPH_WheelWV *_this);

/// Generated from method `JPH::WheelWV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelWV_size_t(size_t inCount);

/// Generated from method `JPH::WheelWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelWV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelWV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelWV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelWV_size_t(size_t inCount);

/// Generated from method `JPH::WheelWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelWV_void_ptr(void *inPointer);

/// Generated from method `JPH::WheelWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelWV_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheelWV::operator new`.
JOLT_API void *Jolt_new_JPH_WheelWV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelWV::operator delete`.
JOLT_API void Jolt_delete_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheelWV::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheelWV_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheelWV::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Override GetSettings and cast to the correct class
/// Generated from method `JPH::WheelWV::GetSettings`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_WheelSettingsWV *JPH_WheelWV_GetSettings(const JPH_WheelWV *_this);

/// Apply a torque (N m) to the wheel for a particular delta time
/// Generated from method `JPH::WheelWV::ApplyTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelWV_ApplyTorque(JPH_WheelWV *_this, float inTorque, float inDeltaTime);

/// Update the wheel rotation based on the current angular velocity
/// Generated from method `JPH::WheelWV::Update`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API void JPH_WheelWV_Update(JPH_WheelWV *_this, unsigned int inWheelIndex, float inDeltaTime, const JPH_VehicleConstraint *inConstraint);

/// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
/// Generated from method `JPH::WheelWV::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetAngularVelocity(const JPH_WheelWV *_this);

/// Update the angular velocity (rad/s)
/// Generated from method `JPH::WheelWV::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelWV_SetAngularVelocity(JPH_WheelWV *_this, float inVel);

/// Get the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::WheelWV::GetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetRotationAngle(const JPH_WheelWV *_this);

/// Set the current rotation angle of the wheel in radians [0, 2 pi]
/// Generated from method `JPH::WheelWV::SetRotationAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelWV_SetRotationAngle(JPH_WheelWV *_this, float inAngle);

/// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
/// Generated from method `JPH::WheelWV::GetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetSteerAngle(const JPH_WheelWV *_this);

/// Set the current steer angle of the wheel in radians [-pi, pi]
/// Generated from method `JPH::WheelWV::SetSteerAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheelWV_SetSteerAngle(JPH_WheelWV *_this, float inAngle);

/// Returns true if the wheel is touching an object
/// Generated from method `JPH::WheelWV::HasContact`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_WheelWV_HasContact(const JPH_WheelWV *_this);

/// Returns the body ID of the body that this wheel is touching
/// Generated from method `JPH::WheelWV::GetContactBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_WheelWV_GetContactBodyID(const JPH_WheelWV *_this);

/// Returns the sub shape ID where we're contacting the body
/// Generated from method `JPH::WheelWV::GetContactSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_WheelWV_GetContactSubShapeID(const JPH_WheelWV *_this);

/// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelWV::GetContactPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelWV_GetContactPosition(const JPH_WheelWV *_this);

/// Velocity of the contact point (m / s, not relative to the wheel but in world space)
/// Generated from method `JPH::WheelWV::GetContactPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelWV_GetContactPointVelocity(const JPH_WheelWV *_this);

/// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelWV::GetContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelWV_GetContactNormal(const JPH_WheelWV *_this);

/// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelWV::GetContactLongitudinal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelWV_GetContactLongitudinal(const JPH_WheelWV *_this);

/// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
/// Generated from method `JPH::WheelWV::GetContactLateral`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_WheelWV_GetContactLateral(const JPH_WheelWV *_this);

/// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
/// Generated from method `JPH::WheelWV::GetSuspensionLength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetSuspensionLength(const JPH_WheelWV *_this);

/// Check if the suspension hit its upper limit
/// Generated from method `JPH::WheelWV::HasHitHardPoint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_WheelWV_HasHitHardPoint(const JPH_WheelWV *_this);

/// Get the total impulse (N s) that was applied by the suspension
/// Generated from method `JPH::WheelWV::GetSuspensionLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetSuspensionLambda(const JPH_WheelWV *_this);

/// Get total impulse (N s) applied along the forward direction of the wheel
/// Generated from method `JPH::WheelWV::GetLongitudinalLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetLongitudinalLambda(const JPH_WheelWV *_this);

/// Get total impulse (N s) applied along the sideways direction of the wheel
/// Generated from method `JPH::WheelWV::GetLateralLambda`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheelWV_GetLateralLambda(const JPH_WheelWV *_this);

/// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
/// Generated from method `JPH::WheelWV::SolveLongitudinalConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_WheelWV_SolveLongitudinalConstraintPart(JPH_WheelWV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

/// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
/// Generated from method `JPH::WheelWV::SolveLateralConstraintPart`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API bool JPH_WheelWV_SolveLateralConstraintPart(JPH_WheelWV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse);

///< The properties of the engine
/// Returns a pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleEngineSettings *JPH_WheeledVehicleControllerSettings_Get_mEngine(const JPH_WheeledVehicleControllerSettings *_this);

///< The properties of the engine
/// Modifies a member variable of class `JPH::WheeledVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mEngine`.
/// When this function is called, this object will drop object references it held previously in `mEngine`.
JOLT_API void JPH_WheeledVehicleControllerSettings_Set_mEngine(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value);

///< The properties of the engine
/// Returns a mutable pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleEngineSettings *JPH_WheeledVehicleControllerSettings_GetMutable_mEngine(JPH_WheeledVehicleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Returns a pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleTransmissionSettings *JPH_WheeledVehicleControllerSettings_Get_mTransmission(const JPH_WheeledVehicleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Modifies a member variable of class `JPH::WheeledVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mTransmission`.
/// When this function is called, this object will drop object references it held previously in `mTransmission`.
JOLT_API void JPH_WheeledVehicleControllerSettings_Set_mTransmission(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value);

///< The properties of the transmission (aka gear box)
/// Returns a mutable pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleTransmissionSettings *JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission(JPH_WheeledVehicleControllerSettings *_this);

///< List of differentials and their properties
/// Returns a pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentials`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *JPH_WheeledVehicleControllerSettings_Get_mDifferentials(const JPH_WheeledVehicleControllerSettings *_this);

///< List of differentials and their properties
/// Modifies a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentials`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mDifferentials`.
/// When this function is called, this object will drop object references it held previously in `mDifferentials`.
JOLT_API void JPH_WheeledVehicleControllerSettings_Set_mDifferentials(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_VehicleDifferentialSettings *value);

///< List of differentials and their properties
/// Returns a mutable pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentials`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_JPH_VehicleDifferentialSettings *JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentials(JPH_WheeledVehicleControllerSettings *_this);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio(const JPH_WheeledVehicleControllerSettings *_this);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Modifies a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDifferentialLimitedSlipRatio`.
JOLT_API void JPH_WheeledVehicleControllerSettings_Set_mDifferentialLimitedSlipRatio(JPH_WheeledVehicleControllerSettings *_this, float value);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a mutable pointer to a member variable of class `JPH::WheeledVehicleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(JPH_WheeledVehicleControllerSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheeledVehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_WheeledVehicleControllerSettings_DestroyArray()`.
/// Use `JPH_WheeledVehicleControllerSettings_OffsetMutablePtr()` and `JPH_WheeledVehicleControllerSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_OffsetPtr(const JPH_WheeledVehicleControllerSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_OffsetMutablePtr(JPH_WheeledVehicleControllerSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_WheeledVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_WheeledVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object);

/// Upcasts an instance of `JPH::WheeledVehicleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::WheeledVehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object);

/// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheeledVehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheeledVehicleControllerSettings *_other);

/// Destroys a heap-allocated instance of `JPH_WheeledVehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_WheeledVehicleControllerSettings_Destroy(const JPH_WheeledVehicleControllerSettings *_this);

/// Destroys a heap-allocated array of `JPH_WheeledVehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_WheeledVehicleControllerSettings_DestroyArray(const JPH_WheeledVehicleControllerSettings *_this);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_AssignFromAnother(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_WheeledVehicleControllerSettings *_other);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_WheeledVehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleControllerSettings
/// Generated from method `JPH::WheeledVehicleControllerSettings::ConstructController`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API JPH_VehicleController *JPH_WheeledVehicleControllerSettings_ConstructController(const JPH_WheeledVehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::WheeledVehicleControllerSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleControllerSettings_SetEmbedded(const JPH_WheeledVehicleControllerSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::WheeledVehicleControllerSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_WheeledVehicleControllerSettings_GetRefCount(const JPH_WheeledVehicleControllerSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::WheeledVehicleControllerSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleControllerSettings_AddRef(const JPH_WheeledVehicleControllerSettings *_this);

/// Generated from method `JPH::WheeledVehicleControllerSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleControllerSettings_Release(const JPH_WheeledVehicleControllerSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::WheeledVehicleControllerSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// Generated from constructor `JPH::WheeledVehicleController::WheeledVehicleController`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_WheeledVehicleController_Destroy()` to free it when you're done using it.
JOLT_API JPH_WheeledVehicleController *JPH_WheeledVehicleController_Construct(const JPH_WheeledVehicleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleController *JPH_WheeledVehicleController_OffsetPtr(const JPH_WheeledVehicleController *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleController *JPH_WheeledVehicleController_OffsetMutablePtr(JPH_WheeledVehicleController *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::WheeledVehicleController` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(const JPH_WheeledVehicleController *object);

/// Upcasts an instance of `JPH::WheeledVehicleController` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_WheeledVehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_WheeledVehicleController *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheeledVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleController *JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::WheeledVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleController *JPH_WheeledVehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::WheeledVehicleController` to its base class `JPH::VehicleController`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleController *JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(const JPH_WheeledVehicleController *object);

/// Upcasts an instance of `JPH::WheeledVehicleController` to its base class `JPH::VehicleController`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleController *JPH_WheeledVehicleController_MutableUpcastTo_JPH_VehicleController(JPH_WheeledVehicleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::WheeledVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleController *JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::WheeledVehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleController *JPH_WheeledVehicleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object);

/// Destroys a heap-allocated instance of `JPH_WheeledVehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_WheeledVehicleController_Destroy(const JPH_WheeledVehicleController *_this);

/// Destroys a heap-allocated array of `JPH_WheeledVehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_WheeledVehicleController_DestroyArray(const JPH_WheeledVehicleController *_this);

/// Generated from method `JPH::WheeledVehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_WheeledVehicleController_size_t(size_t inCount);

/// Generated from method `JPH::WheeledVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::WheeledVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheeledVehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheeledVehicleController_size_t(size_t inCount);

/// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::WheeledVehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheeledVehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::WheeledVehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set input from driver
/// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// @param inRight Value between -1 and 1 indicating desired steering angle (1 = right)
/// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
/// @param inHandBrake Value between 0 and 1 indicating how strong the hand brake is pulled
/// Generated from method `JPH::WheeledVehicleController::SetDriverInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetDriverInput(JPH_WheeledVehicleController *_this, float inForward, float inRight, float inBrake, float inHandBrake);

/// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// Generated from method `JPH::WheeledVehicleController::SetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetForwardInput(JPH_WheeledVehicleController *_this, float inForward);

/// Generated from method `JPH::WheeledVehicleController::GetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetForwardInput(const JPH_WheeledVehicleController *_this);

/// Value between -1 and 1 indicating desired steering angle (1 = right)
/// Generated from method `JPH::WheeledVehicleController::SetRightInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetRightInput(JPH_WheeledVehicleController *_this, float inRight);

/// Generated from method `JPH::WheeledVehicleController::GetRightInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetRightInput(const JPH_WheeledVehicleController *_this);

/// Value between 0 and 1 indicating how strong the brake pedal is pressed
/// Generated from method `JPH::WheeledVehicleController::SetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetBrakeInput(JPH_WheeledVehicleController *_this, float inBrake);

/// Generated from method `JPH::WheeledVehicleController::GetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetBrakeInput(const JPH_WheeledVehicleController *_this);

/// Value between 0 and 1 indicating how strong the hand brake is pulled
/// Generated from method `JPH::WheeledVehicleController::SetHandBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetHandBrakeInput(JPH_WheeledVehicleController *_this, float inHandBrake);

/// Generated from method `JPH::WheeledVehicleController::GetHandBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetHandBrakeInput(const JPH_WheeledVehicleController *_this);

/// Get current engine state
/// Generated from method `JPH::WheeledVehicleController::GetEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_VehicleEngine *JPH_WheeledVehicleController_GetEngine(const JPH_WheeledVehicleController *_this);

/// Get current engine state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
/// Generated from method `JPH::WheeledVehicleController::GetEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_VehicleEngine *JPH_WheeledVehicleController_GetEngine_mut(JPH_WheeledVehicleController *_this);

/// Get current transmission state
/// Generated from method `JPH::WheeledVehicleController::GetTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_VehicleTransmission *JPH_WheeledVehicleController_GetTransmission(const JPH_WheeledVehicleController *_this);

/// Get current transmission state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
/// Generated from method `JPH::WheeledVehicleController::GetTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_VehicleTransmission *JPH_WheeledVehicleController_GetTransmission_mut(JPH_WheeledVehicleController *_this);

/// Get the differentials this vehicle has
/// Generated from method `JPH::WheeledVehicleController::GetDifferentials`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *JPH_WheeledVehicleController_GetDifferentials(const JPH_WheeledVehicleController *_this);

/// Get the differentials this vehicle has (writable interface, allows you to make changes to the configuration which will take effect the next time step)
/// Generated from method `JPH::WheeledVehicleController::GetDifferentials`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_JPH_Array_JPH_VehicleDifferentialSettings *JPH_WheeledVehicleController_GetDifferentials_mut(JPH_WheeledVehicleController *_this);

/// Ratio max / min average wheel speed of each differential (measured at the clutch).
/// Generated from method `JPH::WheeledVehicleController::GetDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio(const JPH_WheeledVehicleController *_this);

/// Generated from method `JPH::WheeledVehicleController::SetDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio(JPH_WheeledVehicleController *_this, float inV);

/// Get the average wheel speed of all driven wheels (measured at the clutch)
/// Generated from method `JPH::WheeledVehicleController::GetWheelSpeedAtClutch`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_WheeledVehicleController_GetWheelSpeedAtClutch(const JPH_WheeledVehicleController *_this);

/// Generated from method `JPH::WheeledVehicleController::GetTireMaxImpulseCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *JPH_WheeledVehicleController_GetTireMaxImpulseCallback(const JPH_WheeledVehicleController *_this);

/// Generated from method `JPH::WheeledVehicleController::SetTireMaxImpulseCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTireMaxImpulseCallback` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetTireMaxImpulseCallback(JPH_WheeledVehicleController *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *inTireMaxImpulseCallback);

/// Debug drawing of RPM meter
/// Generated from method `JPH::WheeledVehicleController::SetRPMMeter`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_WheeledVehicleController_SetRPMMeter(JPH_WheeledVehicleController *_this, const JPH_Vec3 *inPosition, float inSize);

#ifdef __cplusplus
} // extern "C"
#endif
