// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Enum used by constraints to specify how the spring is defined
typedef unsigned char JPH_ESpringMode;
enum // JPH_ESpringMode
{
    ///< Frequency and damping are specified.
    JPH_ESpringMode_FrequencyAndDamping = 0,
    ///< Stiffness and damping are specified.
    JPH_ESpringMode_StiffnessAndDamping = 1,
    ///< Stiffness and damping divided by mass / inertia are specified (also known as acceleration mode). This makes it easier to tune the spring and makes it mass independent.
    JPH_ESpringMode_MassNormalizedStiffnessAndDamping = 2,
};

/// Settings for a linear or angular spring
/// Generated from class `JPH::SpringSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SpringSettings JPH_SpringSettings;

/// Selects the way in which the spring is defined. See the descriptions of the mFrequency, mStiffness and mDamping properties.
/// Returns a pointer to a member variable of class `JPH::SpringSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ESpringMode *JPH_SpringSettings_Get_mMode(const JPH_SpringSettings *_this);

/// Selects the way in which the spring is defined. See the descriptions of the mFrequency, mStiffness and mDamping properties.
/// Modifies a member variable of class `JPH::SpringSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMode`.
/// When this function is called, this object will drop object references it held previously in `mMode`.
JOLT_API void JPH_SpringSettings_Set_mMode(JPH_SpringSettings *_this, JPH_ESpringMode value);

/// Selects the way in which the spring is defined. See the descriptions of the mFrequency, mStiffness and mDamping properties.
/// Returns a mutable pointer to a member variable of class `JPH::SpringSettings` named `mMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ESpringMode *JPH_SpringSettings_GetMutable_mMode(JPH_SpringSettings *_this);

/// Valid when mMode = ESpringMode::FrequencyAndDamping.
/// If > 0 the constraint will be soft and this specifies the oscillation frequency in Hz.
/// If <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
/// Returns a pointer to a member variable of class `JPH::SpringSettings` named `mFrequency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SpringSettings_Get_mFrequency(const JPH_SpringSettings *_this);

/// Valid when mMode = ESpringMode::FrequencyAndDamping.
/// If > 0 the constraint will be soft and this specifies the oscillation frequency in Hz.
/// If <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
/// Modifies a member variable of class `JPH::SpringSettings` named `mFrequency`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFrequency`.
JOLT_API void JPH_SpringSettings_Set_mFrequency(JPH_SpringSettings *_this, float value);

/// Valid when mMode = ESpringMode::FrequencyAndDamping.
/// If > 0 the constraint will be soft and this specifies the oscillation frequency in Hz.
/// If <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
/// Returns a mutable pointer to a member variable of class `JPH::SpringSettings` named `mFrequency`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SpringSettings_GetMutable_mFrequency(JPH_SpringSettings *_this);

/// When mMode = ESpringMode::StiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N / m for a linear spring and N m / rad for an angular spring.
///
/// Note that stiffness values are large numbers. To calculate a ballpark value for the needed stiffness you can use:
/// force = stiffness * delta_spring_length = mass * gravity <=> stiffness = mass * gravity / delta_spring_length.
/// So if your object weighs 1500 kg and the spring compresses by 2 meters, you need a stiffness in the order of 1500 * 9.81 / 2 ~ 7500 N/m.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s^2 for a linear spring and 1 / rad s^2 for an angular spring.
///
/// Since the stiffness is multiplied by the effective mass / inertia of the constraint, you can use much smaller stiffness values and they will be mass independent.
/// Returns a pointer to a member variable of class `JPH::SpringSettings` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SpringSettings_Get_mStiffness(const JPH_SpringSettings *_this);

/// When mMode = ESpringMode::StiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N / m for a linear spring and N m / rad for an angular spring.
///
/// Note that stiffness values are large numbers. To calculate a ballpark value for the needed stiffness you can use:
/// force = stiffness * delta_spring_length = mass * gravity <=> stiffness = mass * gravity / delta_spring_length.
/// So if your object weighs 1500 kg and the spring compresses by 2 meters, you need a stiffness in the order of 1500 * 9.81 / 2 ~ 7500 N/m.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s^2 for a linear spring and 1 / rad s^2 for an angular spring.
///
/// Since the stiffness is multiplied by the effective mass / inertia of the constraint, you can use much smaller stiffness values and they will be mass independent.
/// Modifies a member variable of class `JPH::SpringSettings` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mStiffness`.
JOLT_API void JPH_SpringSettings_Set_mStiffness(JPH_SpringSettings *_this, float value);

/// When mMode = ESpringMode::StiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N / m for a linear spring and N m / rad for an angular spring.
///
/// Note that stiffness values are large numbers. To calculate a ballpark value for the needed stiffness you can use:
/// force = stiffness * delta_spring_length = mass * gravity <=> stiffness = mass * gravity / delta_spring_length.
/// So if your object weighs 1500 kg and the spring compresses by 2 meters, you need a stiffness in the order of 1500 * 9.81 / 2 ~ 7500 N/m.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping:
/// Specifies the stiffness (k) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s^2 for a linear spring and 1 / rad s^2 for an angular spring.
///
/// Since the stiffness is multiplied by the effective mass / inertia of the constraint, you can use much smaller stiffness values and they will be mass independent.
/// Returns a mutable pointer to a member variable of class `JPH::SpringSettings` named `mStiffness`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SpringSettings_GetMutable_mStiffness(JPH_SpringSettings *_this);

/// When mMode = ESpringMode::FrequencyAndDamping this is the damping ratio (0 = no damping, 1 = critical damping).
///
/// When mMode = ESpringMode::StiffnessAndDamping this is the damping (c) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N s / m for a linear spring and N s m / rad for an angular spring.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping this is the damping (c) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s for a linear spring and 1 / rad s for an angular spring.
///
/// Note that if you set this to 0, you will not get an infinite oscillation. Because we integrate physics using an explicit Euler scheme, there is always energy loss.
/// This is done to keep the simulation from exploding, because with a damping of 0 and even the slightest rounding error, the oscillation could become bigger and bigger until the simulation explodes.
/// Returns a pointer to a member variable of class `JPH::SpringSettings` named `mDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SpringSettings_Get_mDamping(const JPH_SpringSettings *_this);

/// When mMode = ESpringMode::FrequencyAndDamping this is the damping ratio (0 = no damping, 1 = critical damping).
///
/// When mMode = ESpringMode::StiffnessAndDamping this is the damping (c) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N s / m for a linear spring and N s m / rad for an angular spring.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping this is the damping (c) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s for a linear spring and 1 / rad s for an angular spring.
///
/// Note that if you set this to 0, you will not get an infinite oscillation. Because we integrate physics using an explicit Euler scheme, there is always energy loss.
/// This is done to keep the simulation from exploding, because with a damping of 0 and even the slightest rounding error, the oscillation could become bigger and bigger until the simulation explodes.
/// Modifies a member variable of class `JPH::SpringSettings` named `mDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDamping`.
JOLT_API void JPH_SpringSettings_Set_mDamping(JPH_SpringSettings *_this, float value);

/// When mMode = ESpringMode::FrequencyAndDamping this is the damping ratio (0 = no damping, 1 = critical damping).
///
/// When mMode = ESpringMode::StiffnessAndDamping this is the damping (c) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
/// Units are N s / m for a linear spring and N s m / rad for an angular spring.
///
/// When mMode = ESpringMode::MassNormalizedStiffnessAndDamping this is the damping (c) in the spring equation F = m_eff * (-k * x - c * v) for a linear or T = i_eff * (-k * theta - c * w) for an angular spring.
/// m_eff / i_eff is the effective mass / inertia of the constraint.
/// Units are 1 / s for a linear spring and 1 / rad s for an angular spring.
///
/// Note that if you set this to 0, you will not get an infinite oscillation. Because we integrate physics using an explicit Euler scheme, there is always energy loss.
/// This is done to keep the simulation from exploding, because with a damping of 0 and even the slightest rounding error, the oscillation could become bigger and bigger until the simulation explodes.
/// Returns a mutable pointer to a member variable of class `JPH::SpringSettings` named `mDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SpringSettings_GetMutable_mDamping(JPH_SpringSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SpringSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SpringSettings_DestroyArray()`.
/// Use `JPH_SpringSettings_OffsetMutablePtr()` and `JPH_SpringSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SpringSettings *JPH_SpringSettings_OffsetPtr(const JPH_SpringSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_OffsetMutablePtr(JPH_SpringSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SpringSettings::SpringSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SpringSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_ConstructFromAnother(const JPH_SpringSettings *_other);

/// Generated from constructor `JPH::SpringSettings::SpringSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SpringSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_Construct(JPH_ESpringMode inMode, float inFrequencyOrStiffness, float inDamping);

/// Destroys a heap-allocated instance of `JPH_SpringSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SpringSettings_Destroy(const JPH_SpringSettings *_this);

/// Destroys a heap-allocated array of `JPH_SpringSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SpringSettings_DestroyArray(const JPH_SpringSettings *_this);

/// Generated from method `JPH::SpringSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SpringSettings *JPH_SpringSettings_AssignFromAnother(JPH_SpringSettings *_this, const JPH_SpringSettings *_other);

/// Generated from method `JPH::SpringSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SpringSettings_size_t(size_t inCount);

/// Generated from method `JPH::SpringSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SpringSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SpringSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SpringSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SpringSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SpringSettings_size_t(size_t inCount);

/// Generated from method `JPH::SpringSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SpringSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SpringSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SpringSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SpringSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SpringSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SpringSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SpringSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SpringSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if the spring has a valid frequency / stiffness, if not the spring will be hard
/// Generated from method `JPH::SpringSettings::HasStiffness`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SpringSettings_HasStiffness(const JPH_SpringSettings *_this);

/// Check if this spring has stiffness or damping (making it active), if not the constraint will be hard
/// Generated from method `JPH::SpringSettings::HasStiffnessOrDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SpringSettings_HasStiffnessOrDamping(const JPH_SpringSettings *_this);

#ifdef __cplusplus
} // extern "C"
#endif
