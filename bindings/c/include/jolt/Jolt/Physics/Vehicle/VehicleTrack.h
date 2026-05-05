// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// On which side of the vehicle the track is located (for steering)
typedef enum JPH_ETrackSide
{
    JPH_ETrackSide_Left = 0,
    JPH_ETrackSide_Right = 1,
    JPH_ETrackSide_Num = 2,
} JPH_ETrackSide;

/// Generic properties for tank tracks
/// Generated from class `JPH::VehicleTrackSettings`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleTrack`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleTrackSettings JPH_VehicleTrackSettings;

/// Runtime data for tank tracks
/// Generated from class `JPH::VehicleTrack`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleTrackSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleTrack JPH_VehicleTrack;

///< Which wheel on the track is connected to the engine
/// Returns a pointer to a member variable of class `JPH::VehicleTrackSettings` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_VehicleTrackSettings_Get_mDrivenWheel(const JPH_VehicleTrackSettings *_this);

///< Which wheel on the track is connected to the engine
/// Modifies a member variable of class `JPH::VehicleTrackSettings` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mDrivenWheel`.
/// When this function is called, this object will drop object references it held previously in `mDrivenWheel`.
JOLT_API void JPH_VehicleTrackSettings_Set_mDrivenWheel(JPH_VehicleTrackSettings *_this, unsigned int value);

///< Which wheel on the track is connected to the engine
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrackSettings` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_VehicleTrackSettings_GetMutable_mDrivenWheel(JPH_VehicleTrackSettings *_this);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrackSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrackSettings_Get_mInertia(const JPH_VehicleTrackSettings *_this);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrackSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertia`.
JOLT_API void JPH_VehicleTrackSettings_Set_mInertia(JPH_VehicleTrackSettings *_this, float value);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrackSettings` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrackSettings_GetMutable_mInertia(JPH_VehicleTrackSettings *_this);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrackSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrackSettings_Get_mAngularDamping(const JPH_VehicleTrackSettings *_this);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrackSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_VehicleTrackSettings_Set_mAngularDamping(JPH_VehicleTrackSettings *_this, float value);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrackSettings` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrackSettings_GetMutable_mAngularDamping(JPH_VehicleTrackSettings *_this);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrackSettings` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrackSettings_Get_mMaxBrakeTorque(const JPH_VehicleTrackSettings *_this);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrackSettings` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxBrakeTorque`.
JOLT_API void JPH_VehicleTrackSettings_Set_mMaxBrakeTorque(JPH_VehicleTrackSettings *_this, float value);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrackSettings` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque(JPH_VehicleTrackSettings *_this);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Returns a pointer to a member variable of class `JPH::VehicleTrackSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrackSettings_Get_mDifferentialRatio(const JPH_VehicleTrackSettings *_this);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Modifies a member variable of class `JPH::VehicleTrackSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDifferentialRatio`.
JOLT_API void JPH_VehicleTrackSettings_Set_mDifferentialRatio(JPH_VehicleTrackSettings *_this, float value);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrackSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio(JPH_VehicleTrackSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTrackSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleTrackSettings_DestroyArray()`.
/// Use `JPH_VehicleTrackSettings_OffsetMutablePtr()` and `JPH_VehicleTrackSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTrackSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTrackSettings *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleTrackSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTrackSettings_Destroy(const JPH_VehicleTrackSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleTrackSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTrackSettings_DestroyArray(const JPH_VehicleTrackSettings *_this);

/// Generated from method `JPH::VehicleTrackSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_AssignFromAnother(JPH_VehicleTrackSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTrackSettings *_other);

/// Generated from method `JPH::VehicleTrackSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleTrackSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleTrackSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTrackSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleTrackSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleTrackSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleTrackSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleTrackSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleTrackSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleTrackSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

///< Angular velocity of the driven wheel, will determine the speed of the entire track
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrack_Get_mAngularVelocity(const JPH_VehicleTrack *_this);

///< Angular velocity of the driven wheel, will determine the speed of the entire track
/// Modifies a member variable of class `JPH::VehicleTrack` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularVelocity`.
JOLT_API void JPH_VehicleTrack_Set_mAngularVelocity(JPH_VehicleTrack *_this, float value);

///< Angular velocity of the driven wheel, will determine the speed of the entire track
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrack_GetMutable_mAngularVelocity(JPH_VehicleTrack *_this);

///< Which wheel on the track is connected to the engine
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_VehicleTrack_Get_mDrivenWheel(const JPH_VehicleTrack *_this);

///< Which wheel on the track is connected to the engine
/// Modifies a member variable of class `JPH::VehicleTrack` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mDrivenWheel`.
/// When this function is called, this object will drop object references it held previously in `mDrivenWheel`.
JOLT_API void JPH_VehicleTrack_Set_mDrivenWheel(JPH_VehicleTrack *_this, unsigned int value);

///< Which wheel on the track is connected to the engine
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mDrivenWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_VehicleTrack_GetMutable_mDrivenWheel(JPH_VehicleTrack *_this);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrack_Get_mInertia(const JPH_VehicleTrack *_this);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrack` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInertia`.
JOLT_API void JPH_VehicleTrack_Set_mInertia(JPH_VehicleTrack *_this, float value);

///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrack_GetMutable_mInertia(JPH_VehicleTrack *_this);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrack_Get_mAngularDamping(const JPH_VehicleTrack *_this);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrack` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAngularDamping`.
JOLT_API void JPH_VehicleTrack_Set_mAngularDamping(JPH_VehicleTrack *_this, float value);

///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrack_GetMutable_mAngularDamping(JPH_VehicleTrack *_this);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrack_Get_mMaxBrakeTorque(const JPH_VehicleTrack *_this);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Modifies a member variable of class `JPH::VehicleTrack` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxBrakeTorque`.
JOLT_API void JPH_VehicleTrack_Set_mMaxBrakeTorque(JPH_VehicleTrack *_this, float value);

///< How much torque (Nm) the brakes can apply on the driven wheel
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mMaxBrakeTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrack_GetMutable_mMaxBrakeTorque(JPH_VehicleTrack *_this);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Returns a pointer to a member variable of class `JPH::VehicleTrack` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleTrack_Get_mDifferentialRatio(const JPH_VehicleTrack *_this);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Modifies a member variable of class `JPH::VehicleTrack` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDifferentialRatio`.
JOLT_API void JPH_VehicleTrack_Set_mDifferentialRatio(JPH_VehicleTrack *_this, float value);

///< Ratio between rotation speed of gear box and driven wheel of track
/// Returns a mutable pointer to a member variable of class `JPH::VehicleTrack` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleTrack_GetMutable_mDifferentialRatio(JPH_VehicleTrack *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTrack_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleTrack_DestroyArray()`.
/// Use `JPH_VehicleTrack_OffsetMutablePtr()` and `JPH_VehicleTrack_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleTrack *JPH_VehicleTrack_OffsetPtr(const JPH_VehicleTrack *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_OffsetMutablePtr(JPH_VehicleTrack *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleTrack` to its base class `JPH::VehicleTrackSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleTrackSettings *JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(const JPH_VehicleTrack *object);

/// Upcasts an instance of `JPH::VehicleTrack` to its base class `JPH::VehicleTrackSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleTrackSettings *JPH_VehicleTrack_MutableUpcastTo_JPH_VehicleTrackSettings(JPH_VehicleTrack *object);

/// Downcasts an instance of `JPH::VehicleTrackSettings` to a derived class `JPH::VehicleTrack`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleTrack *JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(const JPH_VehicleTrackSettings *object);

/// Downcasts an instance of `JPH::VehicleTrackSettings` to a derived class `JPH::VehicleTrack`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_MutableStaticDowncastFrom_JPH_VehicleTrackSettings(JPH_VehicleTrackSettings *object);

/// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleTrack_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTrack *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleTrack`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTrack_Destroy(const JPH_VehicleTrack *_this);

/// Destroys a heap-allocated array of `JPH_VehicleTrack`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleTrack_DestroyArray(const JPH_VehicleTrack *_this);

/// Generated from method `JPH::VehicleTrack::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleTrack *JPH_VehicleTrack_AssignFromAnother(JPH_VehicleTrack *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTrack *_other);

#ifdef __cplusplus
} // extern "C"
#endif
