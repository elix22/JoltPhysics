// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generated from class `JPH::VehicleDifferentialSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleDifferentialSettings JPH_VehicleDifferentialSettings;

///< Index (in mWheels) that represents the left wheel of this differential (can be -1 to indicate no wheel)
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_VehicleDifferentialSettings_Get_mLeftWheel(const JPH_VehicleDifferentialSettings *_this);

///< Index (in mWheels) that represents the left wheel of this differential (can be -1 to indicate no wheel)
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeftWheel`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mLeftWheel(JPH_VehicleDifferentialSettings *_this, int value);

///< Index (in mWheels) that represents the left wheel of this differential (can be -1 to indicate no wheel)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel(JPH_VehicleDifferentialSettings *_this);

///< Index (in mWheels) that represents the right wheel of this differential (can be -1 to indicate no wheel)
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_VehicleDifferentialSettings_Get_mRightWheel(const JPH_VehicleDifferentialSettings *_this);

///< Index (in mWheels) that represents the right wheel of this differential (can be -1 to indicate no wheel)
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRightWheel`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mRightWheel(JPH_VehicleDifferentialSettings *_this, int value);

///< Index (in mWheels) that represents the right wheel of this differential (can be -1 to indicate no wheel)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_VehicleDifferentialSettings_GetMutable_mRightWheel(JPH_VehicleDifferentialSettings *_this);

///< Ratio between rotation speed of gear box and wheels
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleDifferentialSettings_Get_mDifferentialRatio(const JPH_VehicleDifferentialSettings *_this);

///< Ratio between rotation speed of gear box and wheels
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDifferentialRatio`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mDifferentialRatio(JPH_VehicleDifferentialSettings *_this, float value);

///< Ratio between rotation speed of gear box and wheels
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mDifferentialRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio(JPH_VehicleDifferentialSettings *_this);

///< Defines how the engine torque is split across the left and right wheel (0 = left, 0.5 = center, 1 = right)
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftRightSplit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleDifferentialSettings_Get_mLeftRightSplit(const JPH_VehicleDifferentialSettings *_this);

///< Defines how the engine torque is split across the left and right wheel (0 = left, 0.5 = center, 1 = right)
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftRightSplit`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeftRightSplit`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mLeftRightSplit(JPH_VehicleDifferentialSettings *_this, float value);

///< Defines how the engine torque is split across the left and right wheel (0 = left, 0.5 = center, 1 = right)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLeftRightSplit`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit(JPH_VehicleDifferentialSettings *_this);

///< Ratio max / min wheel speed. When this ratio is exceeded, all torque gets distributed to the slowest moving wheel. This allows implementing a limited slip differential. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio(const JPH_VehicleDifferentialSettings *_this);

///< Ratio max / min wheel speed. When this ratio is exceeded, all torque gets distributed to the slowest moving wheel. This allows implementing a limited slip differential. Set to FLT_MAX for an open differential. Value should be > 1.
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLimitedSlipRatio`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mLimitedSlipRatio(JPH_VehicleDifferentialSettings *_this, float value);

///< Ratio max / min wheel speed. When this ratio is exceeded, all torque gets distributed to the slowest moving wheel. This allows implementing a limited slip differential. Set to FLT_MAX for an open differential. Value should be > 1.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mLimitedSlipRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio(JPH_VehicleDifferentialSettings *_this);

///< How much of the engines torque is applied to this differential (0 = none, 1 = full), make sure the sum of all differentials is 1.
/// Returns a pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mEngineTorqueRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio(const JPH_VehicleDifferentialSettings *_this);

///< How much of the engines torque is applied to this differential (0 = none, 1 = full), make sure the sum of all differentials is 1.
/// Modifies a member variable of class `JPH::VehicleDifferentialSettings` named `mEngineTorqueRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEngineTorqueRatio`.
JOLT_API void JPH_VehicleDifferentialSettings_Set_mEngineTorqueRatio(JPH_VehicleDifferentialSettings *_this, float value);

///< How much of the engines torque is applied to this differential (0 = none, 1 = full), make sure the sum of all differentials is 1.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleDifferentialSettings` named `mEngineTorqueRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio(JPH_VehicleDifferentialSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleDifferentialSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleDifferentialSettings_DestroyArray()`.
/// Use `JPH_VehicleDifferentialSettings_OffsetMutablePtr()` and `JPH_VehicleDifferentialSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::VehicleDifferentialSettings` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleDifferentialSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_ConstructFrom(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_OffsetPtr(const JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_OffsetMutablePtr(JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::VehicleDifferentialSettings::VehicleDifferentialSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleDifferentialSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_ConstructFromAnother(const JPH_VehicleDifferentialSettings *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleDifferentialSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleDifferentialSettings_Destroy(const JPH_VehicleDifferentialSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleDifferentialSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleDifferentialSettings_DestroyArray(const JPH_VehicleDifferentialSettings *_this);

/// Generated from method `JPH::VehicleDifferentialSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_AssignFromAnother(JPH_VehicleDifferentialSettings *_this, const JPH_VehicleDifferentialSettings *_other);

/// Generated from method `JPH::VehicleDifferentialSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleDifferentialSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleDifferentialSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleDifferentialSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleDifferentialSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleDifferentialSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Calculate the torque ratio between left and right wheel
/// @param inLeftAngularVelocity Angular velocity of left wheel (rad / s)
/// @param inRightAngularVelocity Angular velocity of right wheel (rad / s)
/// @param outLeftTorqueFraction Fraction of torque that should go to the left wheel
/// @param outRightTorqueFraction Fraction of torque that should go to the right wheel
/// Generated from method `JPH::VehicleDifferentialSettings::CalculateTorqueRatio`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outLeftTorqueFraction` can not be null. It is a single object.
/// Parameter `outRightTorqueFraction` can not be null. It is a single object.
JOLT_API void JPH_VehicleDifferentialSettings_CalculateTorqueRatio(const JPH_VehicleDifferentialSettings *_this, float inLeftAngularVelocity, float inRightAngularVelocity, float *outLeftTorqueFraction, float *outRightTorqueFraction);

#ifdef __cplusplus
} // extern "C"
#endif
