// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// An anti rollbar is a stiff spring that connects two wheels to reduce the amount of roll the vehicle makes in sharp corners
/// See: https://en.wikipedia.org/wiki/Anti-roll_bar
/// Generated from class `JPH::VehicleAntiRollBar`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleAntiRollBar JPH_VehicleAntiRollBar;

///< Index (in mWheels) that represents the left wheel of this anti-rollbar
/// Returns a pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_VehicleAntiRollBar_Get_mLeftWheel(const JPH_VehicleAntiRollBar *_this);

///< Index (in mWheels) that represents the left wheel of this anti-rollbar
/// Modifies a member variable of class `JPH::VehicleAntiRollBar` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLeftWheel`.
JOLT_API void JPH_VehicleAntiRollBar_Set_mLeftWheel(JPH_VehicleAntiRollBar *_this, int value);

///< Index (in mWheels) that represents the left wheel of this anti-rollbar
/// Returns a mutable pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mLeftWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_VehicleAntiRollBar_GetMutable_mLeftWheel(JPH_VehicleAntiRollBar *_this);

///< Index (in mWheels) that represents the right wheel of this anti-rollbar
/// Returns a pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_VehicleAntiRollBar_Get_mRightWheel(const JPH_VehicleAntiRollBar *_this);

///< Index (in mWheels) that represents the right wheel of this anti-rollbar
/// Modifies a member variable of class `JPH::VehicleAntiRollBar` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRightWheel`.
JOLT_API void JPH_VehicleAntiRollBar_Set_mRightWheel(JPH_VehicleAntiRollBar *_this, int value);

///< Index (in mWheels) that represents the right wheel of this anti-rollbar
/// Returns a mutable pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mRightWheel`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_VehicleAntiRollBar_GetMutable_mRightWheel(JPH_VehicleAntiRollBar *_this);

///< Stiffness (spring constant in N/m) of anti rollbar, can be 0 to disable the anti-rollbar
/// Returns a pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleAntiRollBar_Get_mStiffness(const JPH_VehicleAntiRollBar *_this);

///< Stiffness (spring constant in N/m) of anti rollbar, can be 0 to disable the anti-rollbar
/// Modifies a member variable of class `JPH::VehicleAntiRollBar` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mStiffness`.
JOLT_API void JPH_VehicleAntiRollBar_Set_mStiffness(JPH_VehicleAntiRollBar *_this, float value);

///< Stiffness (spring constant in N/m) of anti rollbar, can be 0 to disable the anti-rollbar
/// Returns a mutable pointer to a member variable of class `JPH::VehicleAntiRollBar` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleAntiRollBar_GetMutable_mStiffness(JPH_VehicleAntiRollBar *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleAntiRollBar_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleAntiRollBar_DestroyArray()`.
/// Use `JPH_VehicleAntiRollBar_OffsetMutablePtr()` and `JPH_VehicleAntiRollBar_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::VehicleAntiRollBar` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleAntiRollBar_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_ConstructFrom(int mLeftWheel, int mRightWheel, float mStiffness);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_OffsetPtr(const JPH_VehicleAntiRollBar *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_OffsetMutablePtr(JPH_VehicleAntiRollBar *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::VehicleAntiRollBar::VehicleAntiRollBar`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleAntiRollBar_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_ConstructFromAnother(const JPH_VehicleAntiRollBar *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleAntiRollBar`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleAntiRollBar_Destroy(const JPH_VehicleAntiRollBar *_this);

/// Destroys a heap-allocated array of `JPH_VehicleAntiRollBar`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleAntiRollBar_DestroyArray(const JPH_VehicleAntiRollBar *_this);

/// Generated from method `JPH::VehicleAntiRollBar::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_AssignFromAnother(JPH_VehicleAntiRollBar *_this, const JPH_VehicleAntiRollBar *_other);

/// Generated from method `JPH::VehicleAntiRollBar::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleAntiRollBar_size_t(size_t inCount);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleAntiRollBar::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleAntiRollBar_size_t(size_t inCount);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleAntiRollBar::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleAntiRollBar::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
