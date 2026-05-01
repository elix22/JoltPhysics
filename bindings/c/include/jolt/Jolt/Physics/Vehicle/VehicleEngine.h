// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generic properties for a vehicle engine
/// Generated from class `JPH::VehicleEngineSettings`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleEngine`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleEngineSettings JPH_VehicleEngineSettings;

/// Runtime data for engine
/// Generated from class `JPH::VehicleEngine`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleEngineSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleEngine JPH_VehicleEngine;

///< Max amount of torque (Nm) that the engine can deliver
/// Returns a pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngineSettings_Get_mMaxTorque(const JPH_VehicleEngineSettings *_this);

///< Max amount of torque (Nm) that the engine can deliver
/// Modifies a member variable of class `JPH::VehicleEngineSettings` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxTorque`.
JOLT_API void JPH_VehicleEngineSettings_Set_mMaxTorque(JPH_VehicleEngineSettings *_this, float value);

///< Max amount of torque (Nm) that the engine can deliver
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngineSettings_GetMutable_mMaxTorque(JPH_VehicleEngineSettings *_this);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Returns a pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngineSettings_Get_mMinRPM(const JPH_VehicleEngineSettings *_this);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Modifies a member variable of class `JPH::VehicleEngineSettings` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinRPM`.
JOLT_API void JPH_VehicleEngineSettings_Set_mMinRPM(JPH_VehicleEngineSettings *_this, float value);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngineSettings_GetMutable_mMinRPM(JPH_VehicleEngineSettings *_this);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Returns a pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngineSettings_Get_mMaxRPM(const JPH_VehicleEngineSettings *_this);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Modifies a member variable of class `JPH::VehicleEngineSettings` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxRPM`.
JOLT_API void JPH_VehicleEngineSettings_Set_mMaxRPM(JPH_VehicleEngineSettings *_this, float value);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngineSettings` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngineSettings_GetMutable_mMaxRPM(JPH_VehicleEngineSettings *_this);

///< Moment of inertia (kg m^2) of the engine
/// Returns a pointer to a member variable of class `JPH::VehicleEngineSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngineSettings_Get_mInertia(const JPH_VehicleEngineSettings *_this);

///< Moment of inertia (kg m^2) of the engine
/// Modifies a member variable of class `JPH::VehicleEngineSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertia`.
JOLT_API void JPH_VehicleEngineSettings_Set_mInertia(JPH_VehicleEngineSettings *_this, float value);

///< Moment of inertia (kg m^2) of the engine
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngineSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngineSettings_GetMutable_mInertia(JPH_VehicleEngineSettings *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::VehicleEngineSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngineSettings_Get_mAngularDamping(const JPH_VehicleEngineSettings *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::VehicleEngineSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_VehicleEngineSettings_Set_mAngularDamping(JPH_VehicleEngineSettings *_this, float value);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngineSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngineSettings_GetMutable_mAngularDamping(JPH_VehicleEngineSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleEngineSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleEngineSettings_DestroyArray()`.
/// Use `JPH_VehicleEngineSettings_OffsetMutablePtr()` and `JPH_VehicleEngineSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_OffsetPtr(const JPH_VehicleEngineSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_OffsetMutablePtr(JPH_VehicleEngineSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleEngineSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleEngineSettings *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleEngineSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleEngineSettings_Destroy(const JPH_VehicleEngineSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleEngineSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleEngineSettings_DestroyArray(const JPH_VehicleEngineSettings *_this);

/// Generated from method `JPH::VehicleEngineSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_AssignFromAnother(JPH_VehicleEngineSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleEngineSettings *_other);

/// Generated from method `JPH::VehicleEngineSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleEngineSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleEngineSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleEngineSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleEngineSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleEngineSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleEngineSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleEngineSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleEngineSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleEngineSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Multiply an angular velocity (rad/s) with this value to get rounds per minute (RPM)
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `cAngularVelocityToRPM`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const float *JPH_VehicleEngine_Get_cAngularVelocityToRPM(void);

///< Max amount of torque (Nm) that the engine can deliver
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngine_Get_mMaxTorque(const JPH_VehicleEngine *_this);

///< Max amount of torque (Nm) that the engine can deliver
/// Modifies a member variable of class `JPH::VehicleEngine` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxTorque`.
JOLT_API void JPH_VehicleEngine_Set_mMaxTorque(JPH_VehicleEngine *_this, float value);

///< Max amount of torque (Nm) that the engine can deliver
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngine` named `mMaxTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngine_GetMutable_mMaxTorque(JPH_VehicleEngine *_this);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngine_Get_mMinRPM(const JPH_VehicleEngine *_this);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Modifies a member variable of class `JPH::VehicleEngine` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinRPM`.
JOLT_API void JPH_VehicleEngine_Set_mMinRPM(JPH_VehicleEngine *_this, float value);

///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngine` named `mMinRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngine_GetMutable_mMinRPM(JPH_VehicleEngine *_this);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngine_Get_mMaxRPM(const JPH_VehicleEngine *_this);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Modifies a member variable of class `JPH::VehicleEngine` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxRPM`.
JOLT_API void JPH_VehicleEngine_Set_mMaxRPM(JPH_VehicleEngine *_this, float value);

///< Max amount of revolutions per minute (rpm) the engine can generate
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngine` named `mMaxRPM`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngine_GetMutable_mMaxRPM(JPH_VehicleEngine *_this);

///< Moment of inertia (kg m^2) of the engine
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngine_Get_mInertia(const JPH_VehicleEngine *_this);

///< Moment of inertia (kg m^2) of the engine
/// Modifies a member variable of class `JPH::VehicleEngine` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertia`.
JOLT_API void JPH_VehicleEngine_Set_mInertia(JPH_VehicleEngine *_this, float value);

///< Moment of inertia (kg m^2) of the engine
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngine` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngine_GetMutable_mInertia(JPH_VehicleEngine *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::VehicleEngine` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleEngine_Get_mAngularDamping(const JPH_VehicleEngine *_this);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::VehicleEngine` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_VehicleEngine_Set_mAngularDamping(JPH_VehicleEngine *_this, float value);

///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleEngine` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleEngine_GetMutable_mAngularDamping(JPH_VehicleEngine *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleEngine_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleEngine_DestroyArray()`.
/// Use `JPH_VehicleEngine_OffsetMutablePtr()` and `JPH_VehicleEngine_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleEngine *JPH_VehicleEngine_OffsetPtr(const JPH_VehicleEngine *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_OffsetMutablePtr(JPH_VehicleEngine *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleEngine` to its base class `JPH::VehicleEngineSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleEngineSettings *JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(const JPH_VehicleEngine *object);

/// Upcasts an instance of `JPH::VehicleEngine` to its base class `JPH::VehicleEngineSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleEngineSettings *JPH_VehicleEngine_MutableUpcastTo_JPH_VehicleEngineSettings(JPH_VehicleEngine *object);

/// Downcasts an instance of `JPH::VehicleEngineSettings` to a derived class `JPH::VehicleEngine`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleEngine *JPH_VehicleEngine_StaticDowncastFrom_JPH_VehicleEngineSettings(const JPH_VehicleEngineSettings *object);

/// Downcasts an instance of `JPH::VehicleEngineSettings` to a derived class `JPH::VehicleEngine`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_MutableStaticDowncastFrom_JPH_VehicleEngineSettings(JPH_VehicleEngineSettings *object);

/// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleEngine_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleEngine *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleEngine`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleEngine_Destroy(const JPH_VehicleEngine *_this);

/// Destroys a heap-allocated array of `JPH_VehicleEngine`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleEngine_DestroyArray(const JPH_VehicleEngine *_this);

/// Generated from method `JPH::VehicleEngine::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleEngine *JPH_VehicleEngine_AssignFromAnother(JPH_VehicleEngine *_this, Jolt_PassBy _other_pass_by, JPH_VehicleEngine *_other);

/// Clamp the RPM between min and max RPM
/// Generated from method `JPH::VehicleEngine::ClampRPM`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleEngine_ClampRPM(JPH_VehicleEngine *_this);

/// Current rotation speed of engine in rounds per minute
/// Generated from method `JPH::VehicleEngine::GetCurrentRPM`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleEngine_GetCurrentRPM(const JPH_VehicleEngine *_this);

/// Update rotation speed of engine in rounds per minute
/// Generated from method `JPH::VehicleEngine::SetCurrentRPM`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleEngine_SetCurrentRPM(JPH_VehicleEngine *_this, float inRPM);

/// Get current angular velocity of the engine in radians / second
/// Generated from method `JPH::VehicleEngine::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleEngine_GetAngularVelocity(const JPH_VehicleEngine *_this);

/// Get the amount of torque (N m) that the engine can supply
/// @param inAcceleration How much the gas pedal is pressed [0, 1]
/// Generated from method `JPH::VehicleEngine::GetTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleEngine_GetTorque(const JPH_VehicleEngine *_this, float inAcceleration);

/// Apply a torque to the engine rotation speed
/// @param inTorque Torque in N m
/// @param inDeltaTime Delta time in seconds
/// Generated from method `JPH::VehicleEngine::ApplyTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleEngine_ApplyTorque(JPH_VehicleEngine *_this, float inTorque, float inDeltaTime);

/// Update the engine RPM for damping
/// @param inDeltaTime Delta time in seconds
/// Generated from method `JPH::VehicleEngine::ApplyDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleEngine_ApplyDamping(JPH_VehicleEngine *_this, float inDeltaTime);

/// If the engine is idle we allow the vehicle to sleep
/// Generated from method `JPH::VehicleEngine::AllowSleep`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleEngine_AllowSleep(const JPH_VehicleEngine *_this);

#ifdef __cplusplus
} // extern "C"
#endif
