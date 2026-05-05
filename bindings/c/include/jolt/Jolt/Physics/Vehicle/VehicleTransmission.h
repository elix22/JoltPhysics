// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// How gears are shifted
typedef unsigned char JPH_ETransmissionMode;
enum // JPH_ETransmissionMode
{
    ///< Automatically shift gear up and down
    JPH_ETransmissionMode_Auto = 0,
    ///< Manual gear shift (call SetTransmissionInput)
    JPH_ETransmissionMode_Manual = 1,
};

/// Configuration for the transmission of a vehicle (gear box)
/// Generated from class `JPH::VehicleTransmissionSettings`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleTransmission`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleTransmissionSettings JPH_VehicleTransmissionSettings;

/// Runtime data for transmission
/// Generated from class `JPH::VehicleTransmission`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleTransmissionSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleTransmission JPH_VehicleTransmission;

///< How to switch gears
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ETransmissionMode *JPH_VehicleTransmissionSettings_Get_mMode(const JPH_VehicleTransmissionSettings *_this);

///< How to switch gears
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMode`.
/// When this function is called, this object will drop object references it held previously in `mMode`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mMode(JPH_VehicleTransmissionSettings *_this, JPH_ETransmissionMode value);

///< How to switch gears
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ETransmissionMode *JPH_VehicleTransmissionSettings_GetMutable_mMode(JPH_VehicleTransmissionSettings *_this);

///< How long it takes to switch gears (s), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mSwitchTime(const JPH_VehicleTransmissionSettings *_this);

///< How long it takes to switch gears (s), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSwitchTime`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mSwitchTime(JPH_VehicleTransmissionSettings *_this, float value);

///< How long it takes to switch gears (s), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime(JPH_VehicleTransmissionSettings *_this);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime(const JPH_VehicleTransmissionSettings *_this);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mClutchReleaseTime`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mClutchReleaseTime(JPH_VehicleTransmissionSettings *_this, float value);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime(JPH_VehicleTransmissionSettings *_this);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mSwitchLatency(const JPH_VehicleTransmissionSettings *_this);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSwitchLatency`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mSwitchLatency(JPH_VehicleTransmissionSettings *_this, float value);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency(JPH_VehicleTransmissionSettings *_this);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mShiftUpRPM(const JPH_VehicleTransmissionSettings *_this);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mShiftUpRPM`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mShiftUpRPM(JPH_VehicleTransmissionSettings *_this, float value);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM(JPH_VehicleTransmissionSettings *_this);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mShiftDownRPM(const JPH_VehicleTransmissionSettings *_this);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mShiftDownRPM`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mShiftDownRPM(JPH_VehicleTransmissionSettings *_this, float value);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM(JPH_VehicleTransmissionSettings *_this);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Returns a pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmissionSettings_Get_mClutchStrength(const JPH_VehicleTransmissionSettings *_this);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Modifies a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mClutchStrength`.
JOLT_API void JPH_VehicleTransmissionSettings_Set_mClutchStrength(JPH_VehicleTransmissionSettings *_this, float value);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmissionSettings` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength(JPH_VehicleTransmissionSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTransmissionSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleTransmissionSettings_DestroyArray()`.
/// Use `JPH_VehicleTransmissionSettings_OffsetMutablePtr()` and `JPH_VehicleTransmissionSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_OffsetPtr(const JPH_VehicleTransmissionSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_OffsetMutablePtr(JPH_VehicleTransmissionSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTransmissionSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTransmissionSettings *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleTransmissionSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTransmissionSettings_Destroy(const JPH_VehicleTransmissionSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleTransmissionSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTransmissionSettings_DestroyArray(const JPH_VehicleTransmissionSettings *_this);

/// Generated from method `JPH::VehicleTransmissionSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_AssignFromAnother(JPH_VehicleTransmissionSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTransmissionSettings *_other);

/// Generated from method `JPH::VehicleTransmissionSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleTransmissionSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleTransmissionSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleTransmissionSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleTransmissionSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleTransmissionSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

///< How to switch gears
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ETransmissionMode *JPH_VehicleTransmission_Get_mMode(const JPH_VehicleTransmission *_this);

///< How to switch gears
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMode`.
/// When this function is called, this object will drop object references it held previously in `mMode`.
JOLT_API void JPH_VehicleTransmission_Set_mMode(JPH_VehicleTransmission *_this, JPH_ETransmissionMode value);

///< How to switch gears
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ETransmissionMode *JPH_VehicleTransmission_GetMutable_mMode(JPH_VehicleTransmission *_this);

///< How long it takes to switch gears (s), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mSwitchTime(const JPH_VehicleTransmission *_this);

///< How long it takes to switch gears (s), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSwitchTime`.
JOLT_API void JPH_VehicleTransmission_Set_mSwitchTime(JPH_VehicleTransmission *_this, float value);

///< How long it takes to switch gears (s), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mSwitchTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mSwitchTime(JPH_VehicleTransmission *_this);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mClutchReleaseTime(const JPH_VehicleTransmission *_this);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mClutchReleaseTime`.
JOLT_API void JPH_VehicleTransmission_Set_mClutchReleaseTime(JPH_VehicleTransmission *_this, float value);

///< How long it takes to release the clutch (go to full friction), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mClutchReleaseTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mClutchReleaseTime(JPH_VehicleTransmission *_this);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mSwitchLatency(const JPH_VehicleTransmission *_this);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSwitchLatency`.
JOLT_API void JPH_VehicleTransmission_Set_mSwitchLatency(JPH_VehicleTransmission *_this, float value);

///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mSwitchLatency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mSwitchLatency(JPH_VehicleTransmission *_this);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mShiftUpRPM(const JPH_VehicleTransmission *_this);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mShiftUpRPM`.
JOLT_API void JPH_VehicleTransmission_Set_mShiftUpRPM(JPH_VehicleTransmission *_this, float value);

///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mShiftUpRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mShiftUpRPM(JPH_VehicleTransmission *_this);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mShiftDownRPM(const JPH_VehicleTransmission *_this);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mShiftDownRPM`.
JOLT_API void JPH_VehicleTransmission_Set_mShiftDownRPM(JPH_VehicleTransmission *_this, float value);

///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mShiftDownRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mShiftDownRPM(JPH_VehicleTransmission *_this);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Returns a pointer to a member variable of class `JPH::VehicleTransmission` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTransmission_Get_mClutchStrength(const JPH_VehicleTransmission *_this);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Modifies a member variable of class `JPH::VehicleTransmission` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mClutchStrength`.
JOLT_API void JPH_VehicleTransmission_Set_mClutchStrength(JPH_VehicleTransmission *_this, float value);

///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTransmission` named `mClutchStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTransmission_GetMutable_mClutchStrength(JPH_VehicleTransmission *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTransmission_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleTransmission_DestroyArray()`.
/// Use `JPH_VehicleTransmission_OffsetMutablePtr()` and `JPH_VehicleTransmission_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleTransmission *JPH_VehicleTransmission_OffsetPtr(const JPH_VehicleTransmission *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_OffsetMutablePtr(JPH_VehicleTransmission *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleTransmission` to its base class `JPH::VehicleTransmissionSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleTransmissionSettings *JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(const JPH_VehicleTransmission *object);

/// Upcasts an instance of `JPH::VehicleTransmission` to its base class `JPH::VehicleTransmissionSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleTransmissionSettings *JPH_VehicleTransmission_MutableUpcastTo_JPH_VehicleTransmissionSettings(JPH_VehicleTransmission *object);

/// Downcasts an instance of `JPH::VehicleTransmissionSettings` to a derived class `JPH::VehicleTransmission`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleTransmission *JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(const JPH_VehicleTransmissionSettings *object);

/// Downcasts an instance of `JPH::VehicleTransmissionSettings` to a derived class `JPH::VehicleTransmission`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_MutableStaticDowncastFrom_JPH_VehicleTransmissionSettings(JPH_VehicleTransmissionSettings *object);

/// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTransmission_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTransmission *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleTransmission`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTransmission_Destroy(const JPH_VehicleTransmission *_this);

/// Destroys a heap-allocated array of `JPH_VehicleTransmission`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTransmission_DestroyArray(const JPH_VehicleTransmission *_this);

/// Generated from method `JPH::VehicleTransmission::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleTransmission *JPH_VehicleTransmission_AssignFromAnother(JPH_VehicleTransmission *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTransmission *_other);

/// Set input from driver regarding the transmission (only relevant when transmission is set to manual mode)
/// @param inCurrentGear Current gear, -1 = reverse, 0 = neutral, 1 = 1st gear etc.
/// @param inClutchFriction Value between 0 and 1 indicating how much friction the clutch gives (0 = no friction, 1 = full friction)
/// Generated from method `JPH::VehicleTransmission::Set`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleTransmission_Set(JPH_VehicleTransmission *_this, int inCurrentGear, float inClutchFriction);

/// Update the current gear and clutch friction if the transmission is in auto mode
/// @param inDeltaTime Time step delta time in s
/// @param inCurrentRPM Current RPM for engine
/// @param inForwardInput Hint if the user wants to drive forward (> 0) or backwards (< 0)
/// @param inCanShiftUp Indicates if we want to allow the transmission to shift up (e.g. pass false if wheels are slipping)
/// Generated from method `JPH::VehicleTransmission::Update`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleTransmission_Update(JPH_VehicleTransmission *_this, float inDeltaTime, float inCurrentRPM, float inForwardInput, bool inCanShiftUp);

/// Current gear, -1 = reverse, 0 = neutral, 1 = 1st gear etc.
/// Generated from method `JPH::VehicleTransmission::GetCurrentGear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_VehicleTransmission_GetCurrentGear(const JPH_VehicleTransmission *_this);

/// Value between 0 and 1 indicating how much friction the clutch gives (0 = no friction, 1 = full friction)
/// Generated from method `JPH::VehicleTransmission::GetClutchFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleTransmission_GetClutchFriction(const JPH_VehicleTransmission *_this);

/// If the auto box is currently switching gears
/// Generated from method `JPH::VehicleTransmission::IsSwitchingGear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleTransmission_IsSwitchingGear(const JPH_VehicleTransmission *_this);

/// Return the transmission ratio based on the current gear (ratio between engine and differential)
/// Generated from method `JPH::VehicleTransmission::GetCurrentRatio`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleTransmission_GetCurrentRatio(const JPH_VehicleTransmission *_this);

/// Only allow sleeping when the transmission is idle
/// Generated from method `JPH::VehicleTransmission::AllowSleep`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleTransmission_AllowSleep(const JPH_VehicleTransmission *_this);

#ifdef __cplusplus
} // extern "C"
#endif
