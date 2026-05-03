// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_SpringSettings JPH_SpringSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/SpringSettings.h>`.


typedef enum JPH_EMotorState
{
    ///< Motor is off
    JPH_EMotorState_Off = 0,
    ///< Motor will drive to target velocity
    JPH_EMotorState_Velocity = 1,
    ///< Motor will drive to target position
    JPH_EMotorState_Position = 2,
} JPH_EMotorState;

/// Class that contains the settings for a constraint motor.
/// See the main page of the API documentation for more information on how to configure a motor.
/// Generated from class `JPH::MotorSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MotorSettings JPH_MotorSettings;

///< Settings for the spring that is used to drive to the position target (not used when motor is a velocity motor).
/// Returns a pointer to a member variable of class `JPH::MotorSettings` named `mSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SpringSettings *JPH_MotorSettings_Get_mSpringSettings(const JPH_MotorSettings *_this);

///< Settings for the spring that is used to drive to the position target (not used when motor is a velocity motor).
/// Returns a mutable pointer to a member variable of class `JPH::MotorSettings` named `mSpringSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SpringSettings *JPH_MotorSettings_GetMutable_mSpringSettings(JPH_MotorSettings *_this);

///< Minimum force to apply in case of a linear constraint (N). Usually this is -mMaxForceLimit unless you want a motor that can e.g. push but not pull. Not used when motor is an angular motor.
/// Returns a pointer to a member variable of class `JPH::MotorSettings` named `mMinForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorSettings_Get_mMinForceLimit(const JPH_MotorSettings *_this);

///< Minimum force to apply in case of a linear constraint (N). Usually this is -mMaxForceLimit unless you want a motor that can e.g. push but not pull. Not used when motor is an angular motor.
/// Modifies a member variable of class `JPH::MotorSettings` named `mMinForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinForceLimit`.
JOLT_API void JPH_MotorSettings_Set_mMinForceLimit(JPH_MotorSettings *_this, float value);

///< Minimum force to apply in case of a linear constraint (N). Usually this is -mMaxForceLimit unless you want a motor that can e.g. push but not pull. Not used when motor is an angular motor.
/// Returns a mutable pointer to a member variable of class `JPH::MotorSettings` named `mMinForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorSettings_GetMutable_mMinForceLimit(JPH_MotorSettings *_this);

///< Maximum force to apply in case of a linear constraint (N). Not used when motor is an angular motor.
/// Returns a pointer to a member variable of class `JPH::MotorSettings` named `mMaxForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorSettings_Get_mMaxForceLimit(const JPH_MotorSettings *_this);

///< Maximum force to apply in case of a linear constraint (N). Not used when motor is an angular motor.
/// Modifies a member variable of class `JPH::MotorSettings` named `mMaxForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxForceLimit`.
JOLT_API void JPH_MotorSettings_Set_mMaxForceLimit(JPH_MotorSettings *_this, float value);

///< Maximum force to apply in case of a linear constraint (N). Not used when motor is an angular motor.
/// Returns a mutable pointer to a member variable of class `JPH::MotorSettings` named `mMaxForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorSettings_GetMutable_mMaxForceLimit(JPH_MotorSettings *_this);

///< Minimum torque to apply in case of a angular constraint (N m). Usually this is -mMaxTorqueLimit unless you want a motor that can e.g. push but not pull. Not used when motor is a position motor.
/// Returns a pointer to a member variable of class `JPH::MotorSettings` named `mMinTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorSettings_Get_mMinTorqueLimit(const JPH_MotorSettings *_this);

///< Minimum torque to apply in case of a angular constraint (N m). Usually this is -mMaxTorqueLimit unless you want a motor that can e.g. push but not pull. Not used when motor is a position motor.
/// Modifies a member variable of class `JPH::MotorSettings` named `mMinTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinTorqueLimit`.
JOLT_API void JPH_MotorSettings_Set_mMinTorqueLimit(JPH_MotorSettings *_this, float value);

///< Minimum torque to apply in case of a angular constraint (N m). Usually this is -mMaxTorqueLimit unless you want a motor that can e.g. push but not pull. Not used when motor is a position motor.
/// Returns a mutable pointer to a member variable of class `JPH::MotorSettings` named `mMinTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorSettings_GetMutable_mMinTorqueLimit(JPH_MotorSettings *_this);

///< Maximum torque to apply in case of a angular constraint (N m). Not used when motor is a position motor.
/// Returns a pointer to a member variable of class `JPH::MotorSettings` named `mMaxTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_MotorSettings_Get_mMaxTorqueLimit(const JPH_MotorSettings *_this);

///< Maximum torque to apply in case of a angular constraint (N m). Not used when motor is a position motor.
/// Modifies a member variable of class `JPH::MotorSettings` named `mMaxTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxTorqueLimit`.
JOLT_API void JPH_MotorSettings_Set_mMaxTorqueLimit(JPH_MotorSettings *_this, float value);

///< Maximum torque to apply in case of a angular constraint (N m). Not used when motor is a position motor.
/// Returns a mutable pointer to a member variable of class `JPH::MotorSettings` named `mMaxTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_MotorSettings_GetMutable_mMaxTorqueLimit(JPH_MotorSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MotorSettings_DestroyArray()`.
/// Use `JPH_MotorSettings_OffsetMutablePtr()` and `JPH_MotorSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MotorSettings *JPH_MotorSettings_OffsetPtr(const JPH_MotorSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_OffsetMutablePtr(JPH_MotorSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::MotorSettings::MotorSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_ConstructFromAnother(const JPH_MotorSettings *_other);

/// Generated from constructor `JPH::MotorSettings::MotorSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_Construct_2(float inFrequency, float inDamping);

/// Generated from constructor `JPH::MotorSettings::MotorSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotorSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_Construct_4(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit);

/// Destroys a heap-allocated instance of `JPH_MotorSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorSettings_Destroy(const JPH_MotorSettings *_this);

/// Destroys a heap-allocated array of `JPH_MotorSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_MotorSettings_DestroyArray(const JPH_MotorSettings *_this);

/// Generated from method `JPH::MotorSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_MotorSettings *JPH_MotorSettings_AssignFromAnother(JPH_MotorSettings *_this, const JPH_MotorSettings *_other);

/// Generated from method `JPH::MotorSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MotorSettings_size_t(size_t inCount);

/// Generated from method `JPH::MotorSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorSettings_size_t(size_t inCount);

/// Generated from method `JPH::MotorSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::MotorSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotorSettings::operator new`.
JOLT_API void *Jolt_new_JPH_MotorSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MotorSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotorSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotorSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set asymmetric force limits
/// Generated from method `JPH::MotorSettings::SetForceLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorSettings_SetForceLimits(JPH_MotorSettings *_this, float inMin, float inMax);

/// Set asymmetric torque limits
/// Generated from method `JPH::MotorSettings::SetTorqueLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorSettings_SetTorqueLimits(JPH_MotorSettings *_this, float inMin, float inMax);

/// Set symmetric force limits
/// Generated from method `JPH::MotorSettings::SetForceLimit`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorSettings_SetForceLimit(JPH_MotorSettings *_this, float inLimit);

/// Set symmetric torque limits
/// Generated from method `JPH::MotorSettings::SetTorqueLimit`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotorSettings_SetTorqueLimit(JPH_MotorSettings *_this, float inLimit);

/// Check if settings are valid
/// Generated from method `JPH::MotorSettings::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MotorSettings_IsValid(const JPH_MotorSettings *_this);

#ifdef __cplusplus
} // extern "C"
#endif
