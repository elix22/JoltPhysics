// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_VehicleControllerSettings JPH_RefTarget_JPH_VehicleControllerSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleController JPH_VehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleController.h>`.
typedef struct JPH_VehicleControllerSettings JPH_VehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleController.h>`.
typedef struct JPH_VehicleEngineSettings JPH_VehicleEngineSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleEngine.h>`.
typedef struct JPH_VehicleTransmissionSettings JPH_VehicleTransmissionSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleTransmission.h>`.
typedef struct JPH_WheeledVehicleController JPH_WheeledVehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleControllerSettings JPH_WheeledVehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float; // Defined in `#include <std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float.h>`.


/// Settings of a two wheeled motorcycle (adds a spring to balance the motorcycle)
/// Note: The motor cycle controller is still in development and may need a lot of tweaks/hacks to work properly!
/// Generated from class `JPH::MotorcycleControllerSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::WheeledVehicleControllerSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
///     `JPH::VehicleControllerSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MotorcycleControllerSettings JPH_MotorcycleControllerSettings;

/// Runtime controller class
/// Generated from class `JPH::MotorcycleController`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::WheeledVehicleController`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
///     `JPH::VehicleController`
typedef struct JPH_MotorcycleController JPH_MotorcycleController;

/// How far we're willing to make the bike lean over in turns (in radians)
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mMaxLeanAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle(const JPH_MotorcycleControllerSettings *_this);

/// How far we're willing to make the bike lean over in turns (in radians)
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mMaxLeanAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxLeanAngle`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mMaxLeanAngle(JPH_MotorcycleControllerSettings *_this, float value);

/// How far we're willing to make the bike lean over in turns (in radians)
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mMaxLeanAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle(JPH_MotorcycleControllerSettings *_this);

/// Spring constant for the lean spring
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringConstant`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant(const JPH_MotorcycleControllerSettings *_this);

/// Spring constant for the lean spring
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringConstant`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeanSpringConstant`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mLeanSpringConstant(JPH_MotorcycleControllerSettings *_this, float value);

/// Spring constant for the lean spring
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringConstant`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant(JPH_MotorcycleControllerSettings *_this);

/// Spring damping constant for the lean spring
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping(const JPH_MotorcycleControllerSettings *_this);

/// Spring damping constant for the lean spring
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeanSpringDamping`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mLeanSpringDamping(JPH_MotorcycleControllerSettings *_this, float value);

/// Spring damping constant for the lean spring
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping(JPH_MotorcycleControllerSettings *_this);

/// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficient`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient(const JPH_MotorcycleControllerSettings *_this);

/// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficient`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeanSpringIntegrationCoefficient`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mLeanSpringIntegrationCoefficient(JPH_MotorcycleControllerSettings *_this, float value);

/// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficient`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient(JPH_MotorcycleControllerSettings *_this);

/// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficientDecay`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay(const JPH_MotorcycleControllerSettings *_this);

/// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficientDecay`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeanSpringIntegrationCoefficientDecay`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleControllerSettings *_this, float value);

/// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSpringIntegrationCoefficientDecay`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleControllerSettings *_this);

/// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
/// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSmoothingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor(const JPH_MotorcycleControllerSettings *_this);

/// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
/// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSmoothingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeanSmoothingFactor`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mLeanSmoothingFactor(JPH_MotorcycleControllerSettings *_this, float value);

/// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
/// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mLeanSmoothingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor(JPH_MotorcycleControllerSettings *_this);

///< The properties of the engine
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleEngineSettings *JPH_MotorcycleControllerSettings_Get_mEngine(const JPH_MotorcycleControllerSettings *_this);

///< The properties of the engine
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mEngine`.
/// When this function is called, this object will drop object references it held previously in `mEngine`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mEngine(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value);

///< The properties of the engine
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mEngine`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleEngineSettings *JPH_MotorcycleControllerSettings_GetMutable_mEngine(JPH_MotorcycleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_VehicleTransmissionSettings *JPH_MotorcycleControllerSettings_Get_mTransmission(const JPH_MotorcycleControllerSettings *_this);

///< The properties of the transmission (aka gear box)
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mTransmission`.
/// When this function is called, this object will drop object references it held previously in `mTransmission`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mTransmission(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value);

///< The properties of the transmission (aka gear box)
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mTransmission`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_VehicleTransmissionSettings *JPH_MotorcycleControllerSettings_GetMutable_mTransmission(JPH_MotorcycleControllerSettings *_this);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio(const JPH_MotorcycleControllerSettings *_this);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Modifies a member variable of class `JPH::MotorcycleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDifferentialLimitedSlipRatio`.
JOLT_API void JPH_MotorcycleControllerSettings_Set_mDifferentialLimitedSlipRatio(JPH_MotorcycleControllerSettings *_this, float value);

///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a mutable pointer to a member variable of class `JPH::MotorcycleControllerSettings` named `mDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(JPH_MotorcycleControllerSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorcycleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MotorcycleControllerSettings_DestroyArray()`.
/// Use `JPH_MotorcycleControllerSettings_OffsetMutablePtr()` and `JPH_MotorcycleControllerSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_OffsetPtr(const JPH_MotorcycleControllerSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_OffsetMutablePtr(JPH_MotorcycleControllerSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_MotorcycleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MotorcycleControllerSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_MotorcycleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_MotorcycleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_MotorcycleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::VehicleControllerSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_MotorcycleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::VehicleControllerSettings` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::WheeledVehicleControllerSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(const JPH_MotorcycleControllerSettings *object);

/// Upcasts an instance of `JPH::MotorcycleControllerSettings` to its base class `JPH::WheeledVehicleControllerSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_WheeledVehicleControllerSettings(JPH_MotorcycleControllerSettings *object);

/// Downcasts an instance of `JPH::WheeledVehicleControllerSettings` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object);

/// Downcasts an instance of `JPH::WheeledVehicleControllerSettings` to a derived class `JPH::MotorcycleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_WheeledVehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object);

/// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorcycleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MotorcycleControllerSettings *_other);

/// Destroys a heap-allocated instance of `JPH_MotorcycleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorcycleControllerSettings_Destroy(const JPH_MotorcycleControllerSettings *_this);

/// Destroys a heap-allocated array of `JPH_MotorcycleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorcycleControllerSettings_DestroyArray(const JPH_MotorcycleControllerSettings *_this);

/// Generated from method `JPH::MotorcycleControllerSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_AssignFromAnother(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_MotorcycleControllerSettings *_other);

/// Generated from method `JPH::MotorcycleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MotorcycleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorcycleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorcycleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorcycleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MotorcycleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleControllerSettings
/// Generated from method `JPH::MotorcycleControllerSettings::ConstructController`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API JPH_VehicleController *JPH_MotorcycleControllerSettings_ConstructController(const JPH_MotorcycleControllerSettings *_this, JPH_VehicleConstraint *inConstraint);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::MotorcycleControllerSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleControllerSettings_SetEmbedded(const JPH_MotorcycleControllerSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::MotorcycleControllerSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MotorcycleControllerSettings_GetRefCount(const JPH_MotorcycleControllerSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::MotorcycleControllerSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleControllerSettings_AddRef(const JPH_MotorcycleControllerSettings *_this);

/// Generated from method `JPH::MotorcycleControllerSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleControllerSettings_Release(const JPH_MotorcycleControllerSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::MotorcycleControllerSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// Generated from constructor `JPH::MotorcycleController::MotorcycleController`.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorcycleController_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorcycleController *JPH_MotorcycleController_Construct(const JPH_MotorcycleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MotorcycleController *JPH_MotorcycleController_OffsetPtr(const JPH_MotorcycleController *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MotorcycleController *JPH_MotorcycleController_OffsetMutablePtr(JPH_MotorcycleController *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(const JPH_MotorcycleController *object);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_MotorcycleController_MutableUpcastTo_JPH_NonCopyable(JPH_MotorcycleController *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::VehicleController`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleController *JPH_MotorcycleController_UpcastTo_JPH_VehicleController(const JPH_MotorcycleController *object);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::VehicleController`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleController *JPH_MotorcycleController_MutableUpcastTo_JPH_VehicleController(JPH_MotorcycleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object);

/// Downcasts an instance of `JPH::VehicleController` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::WheeledVehicleController`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_WheeledVehicleController *JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(const JPH_MotorcycleController *object);

/// Upcasts an instance of `JPH::MotorcycleController` to its base class `JPH::WheeledVehicleController`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_WheeledVehicleController *JPH_MotorcycleController_MutableUpcastTo_JPH_WheeledVehicleController(JPH_MotorcycleController *object);

/// Downcasts an instance of `JPH::WheeledVehicleController` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(const JPH_WheeledVehicleController *object);

/// Downcasts an instance of `JPH::WheeledVehicleController` to a derived class `JPH::MotorcycleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_WheeledVehicleController(JPH_WheeledVehicleController *object);

/// Destroys a heap-allocated instance of `JPH_MotorcycleController`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorcycleController_Destroy(const JPH_MotorcycleController *_this);

/// Destroys a heap-allocated array of `JPH_MotorcycleController`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorcycleController_DestroyArray(const JPH_MotorcycleController *_this);

/// Generated from method `JPH::MotorcycleController::operator new`.
JOLT_API void *Jolt_new_JPH_MotorcycleController_size_t(size_t inCount);

/// Generated from method `JPH::MotorcycleController::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleController_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorcycleController::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorcycleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorcycleController_size_t(size_t inCount);

/// Generated from method `JPH::MotorcycleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleController_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorcycleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorcycleController::operator new`.
JOLT_API void *Jolt_new_JPH_MotorcycleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorcycleController::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MotorcycleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorcycleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the distance between the front and back wheels
/// Generated from method `JPH::MotorcycleController::GetWheelBase`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetWheelBase(const JPH_MotorcycleController *_this);

/// Enable or disable the lean spring. This allows you to temporarily disable the lean spring to allow the motorcycle to fall over.
/// Generated from method `JPH::MotorcycleController::EnableLeanController`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_EnableLeanController(JPH_MotorcycleController *_this, bool inEnable);

/// Check if the lean spring is enabled.
/// Generated from method `JPH::MotorcycleController::IsLeanControllerEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MotorcycleController_IsLeanControllerEnabled(const JPH_MotorcycleController *_this);

/// Enable or disable the lean steering limit. When enabled (default) the steering angle is limited based on the vehicle speed to prevent steering that would cause an inertial force that causes the motorcycle to topple over.
/// Generated from method `JPH::MotorcycleController::EnableLeanSteeringLimit`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_EnableLeanSteeringLimit(JPH_MotorcycleController *_this, bool inEnable);

/// Generated from method `JPH::MotorcycleController::IsLeanSteeringLimitEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MotorcycleController_IsLeanSteeringLimitEnabled(const JPH_MotorcycleController *_this);

/// Spring constant for the lean spring
/// Generated from method `JPH::MotorcycleController::SetLeanSpringConstant`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetLeanSpringConstant(JPH_MotorcycleController *_this, float inConstant);

/// Generated from method `JPH::MotorcycleController::GetLeanSpringConstant`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetLeanSpringConstant(const JPH_MotorcycleController *_this);

/// Spring damping constant for the lean spring
/// Generated from method `JPH::MotorcycleController::SetLeanSpringDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetLeanSpringDamping(JPH_MotorcycleController *_this, float inDamping);

/// Generated from method `JPH::MotorcycleController::GetLeanSpringDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetLeanSpringDamping(const JPH_MotorcycleController *_this);

/// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
/// Generated from method `JPH::MotorcycleController::SetLeanSpringIntegrationCoefficient`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient(JPH_MotorcycleController *_this, float inCoefficient);

/// Generated from method `JPH::MotorcycleController::GetLeanSpringIntegrationCoefficient`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient(const JPH_MotorcycleController *_this);

/// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
/// Generated from method `JPH::MotorcycleController::SetLeanSpringIntegrationCoefficientDecay`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleController *_this, float inDecay);

/// Generated from method `JPH::MotorcycleController::GetLeanSpringIntegrationCoefficientDecay`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay(const JPH_MotorcycleController *_this);

/// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
/// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
/// Generated from method `JPH::MotorcycleController::SetLeanSmoothingFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetLeanSmoothingFactor(JPH_MotorcycleController *_this, float inFactor);

/// Generated from method `JPH::MotorcycleController::GetLeanSmoothingFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetLeanSmoothingFactor(const JPH_MotorcycleController *_this);

/// Set input from driver
/// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// @param inRight Value between -1 and 1 indicating desired steering angle (1 = right)
/// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
/// @param inHandBrake Value between 0 and 1 indicating how strong the hand brake is pulled
/// Generated from method `JPH::MotorcycleController::SetDriverInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetDriverInput(JPH_MotorcycleController *_this, float inForward, float inRight, float inBrake, float inHandBrake);

/// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
/// Generated from method `JPH::MotorcycleController::SetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetForwardInput(JPH_MotorcycleController *_this, float inForward);

/// Generated from method `JPH::MotorcycleController::GetForwardInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetForwardInput(const JPH_MotorcycleController *_this);

/// Value between -1 and 1 indicating desired steering angle (1 = right)
/// Generated from method `JPH::MotorcycleController::SetRightInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetRightInput(JPH_MotorcycleController *_this, float inRight);

/// Generated from method `JPH::MotorcycleController::GetRightInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetRightInput(const JPH_MotorcycleController *_this);

/// Value between 0 and 1 indicating how strong the brake pedal is pressed
/// Generated from method `JPH::MotorcycleController::SetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetBrakeInput(JPH_MotorcycleController *_this, float inBrake);

/// Generated from method `JPH::MotorcycleController::GetBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetBrakeInput(const JPH_MotorcycleController *_this);

/// Value between 0 and 1 indicating how strong the hand brake is pulled
/// Generated from method `JPH::MotorcycleController::SetHandBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetHandBrakeInput(JPH_MotorcycleController *_this, float inHandBrake);

/// Generated from method `JPH::MotorcycleController::GetHandBrakeInput`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetHandBrakeInput(const JPH_MotorcycleController *_this);

/// Ratio max / min average wheel speed of each differential (measured at the clutch).
/// Generated from method `JPH::MotorcycleController::GetDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetDifferentialLimitedSlipRatio(const JPH_MotorcycleController *_this);

/// Generated from method `JPH::MotorcycleController::SetDifferentialLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetDifferentialLimitedSlipRatio(JPH_MotorcycleController *_this, float inV);

/// Get the average wheel speed of all driven wheels (measured at the clutch)
/// Generated from method `JPH::MotorcycleController::GetWheelSpeedAtClutch`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotorcycleController_GetWheelSpeedAtClutch(const JPH_MotorcycleController *_this);

/// Generated from method `JPH::MotorcycleController::GetTireMaxImpulseCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *JPH_MotorcycleController_GetTireMaxImpulseCallback(const JPH_MotorcycleController *_this);

/// Generated from method `JPH::MotorcycleController::SetTireMaxImpulseCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTireMaxImpulseCallback` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetTireMaxImpulseCallback(JPH_MotorcycleController *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *inTireMaxImpulseCallback);

/// Debug drawing of RPM meter
/// Generated from method `JPH::MotorcycleController::SetRPMMeter`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_MotorcycleController_SetRPMMeter(JPH_MotorcycleController *_this, const JPH_Vec3 *inPosition, float inSize);

#ifdef __cplusplus
} // extern "C"
#endif
