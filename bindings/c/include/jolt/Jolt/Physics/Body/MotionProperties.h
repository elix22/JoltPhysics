// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/MotionQuality.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_UVec4 JPH_UVec4; // Defined in `#include <jolt/Jolt/Math/UVec4.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// The Body class only keeps track of state for static bodies, the MotionProperties class keeps the additional state needed for a moving Body. It has a 1-on-1 relationship with the body.
/// Generated from class `JPH::MotionProperties`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::SoftBodyMotionProperties`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_MotionProperties JPH_MotionProperties;

///< Constant indicating that body is not active
/// Returns a pointer to a member variable of class `JPH::MotionProperties` named `cInactiveIndex`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_MotionProperties_Get_cInactiveIndex(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotionProperties_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotionProperties *JPH_MotionProperties_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_MotionProperties_DestroyArray()`.
/// Use `JPH_MotionProperties_OffsetMutablePtr()` and `JPH_MotionProperties_OffsetPtr()` to access the array elements.
JOLT_API JPH_MotionProperties *JPH_MotionProperties_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_MotionProperties *JPH_MotionProperties_OffsetPtr(const JPH_MotionProperties *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_MotionProperties *JPH_MotionProperties_OffsetMutablePtr(JPH_MotionProperties *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::MotionProperties::MotionProperties`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_MotionProperties_Destroy()` to free it when you're done using it.
JOLT_API JPH_MotionProperties *JPH_MotionProperties_ConstructFromAnother(const JPH_MotionProperties *_other);

/// Destroys a heap-allocated instance of `JPH_MotionProperties`. Does nothing if the pointer is null.
JOLT_API void JPH_MotionProperties_Destroy(const JPH_MotionProperties *_this);

/// Destroys a heap-allocated array of `JPH_MotionProperties`. Does nothing if the pointer is null.
JOLT_API void JPH_MotionProperties_DestroyArray(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_MotionProperties *JPH_MotionProperties_AssignFromAnother(JPH_MotionProperties *_this, const JPH_MotionProperties *_other);

/// Generated from method `JPH::MotionProperties::operator new`.
JOLT_API void *Jolt_new_JPH_MotionProperties_size_t(size_t inCount);

/// Generated from method `JPH::MotionProperties::operator delete`.
JOLT_API void Jolt_delete_JPH_MotionProperties_void_ptr(void *inPointer);

/// Generated from method `JPH::MotionProperties::operator delete`.
JOLT_API void Jolt_delete_JPH_MotionProperties_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotionProperties::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotionProperties_size_t(size_t inCount);

/// Generated from method `JPH::MotionProperties::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotionProperties_void_ptr(void *inPointer);

/// Generated from method `JPH::MotionProperties::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::MotionProperties::operator new`.
JOLT_API void *Jolt_new_JPH_MotionProperties_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotionProperties::operator delete`.
JOLT_API void Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::MotionProperties::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_MotionProperties_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::MotionProperties::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Motion quality, or how well it detects collisions when it has a high velocity
/// Generated from method `JPH::MotionProperties::GetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EMotionQuality JPH_MotionProperties_GetMotionQuality(const JPH_MotionProperties *_this);

/// If this body can go to sleep.
/// Generated from method `JPH::MotionProperties::GetAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_MotionProperties_GetAllowSleeping(const JPH_MotionProperties *_this);

/// Get world space linear velocity of the center of mass
/// Generated from method `JPH::MotionProperties::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetLinearVelocity(const JPH_MotionProperties *_this);

/// Set world space linear velocity of the center of mass
/// Generated from method `JPH::MotionProperties::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetLinearVelocity(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocity);

/// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity
/// Generated from method `JPH::MotionProperties::SetLinearVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetLinearVelocityClamped(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocity);

/// Get world space angular velocity of the center of mass
/// Generated from method `JPH::MotionProperties::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetAngularVelocity(const JPH_MotionProperties *_this);

/// Set world space angular velocity of the center of mass
/// Generated from method `JPH::MotionProperties::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetAngularVelocity(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocity);

/// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity
/// Generated from method `JPH::MotionProperties::SetAngularVelocityClamped`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetAngularVelocityClamped(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocity);

/// Set velocity of body such that it will be rotate/translate by inDeltaPosition/Rotation in inDeltaTime seconds.
/// Generated from method `JPH::MotionProperties::MoveKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDeltaPosition` can not be null. It is a single object.
/// Parameter `inDeltaRotation` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_MoveKinematic(JPH_MotionProperties *_this, const JPH_Vec3 *inDeltaPosition, const JPH_Quat *inDeltaRotation, float inDeltaTime);

/// Maximum linear velocity that a body can achieve. Used to prevent the system from exploding.
/// Generated from method `JPH::MotionProperties::GetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetMaxLinearVelocity(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetMaxLinearVelocity(JPH_MotionProperties *_this, float inLinearVelocity);

/// Maximum angular velocity that a body can achieve. Used to prevent the system from exploding.
/// Generated from method `JPH::MotionProperties::GetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetMaxAngularVelocity(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetMaxAngularVelocity(JPH_MotionProperties *_this, float inAngularVelocity);

/// Clamp velocity according to limit
/// Generated from method `JPH::MotionProperties::ClampLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ClampLinearVelocity(JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::ClampAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ClampAngularVelocity(JPH_MotionProperties *_this);

/// Get linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
/// Generated from method `JPH::MotionProperties::GetLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetLinearDamping(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetLinearDamping(JPH_MotionProperties *_this, float inLinearDamping);

/// Get angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
/// Generated from method `JPH::MotionProperties::GetAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetAngularDamping(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetAngularDamping(JPH_MotionProperties *_this, float inAngularDamping);

/// Get gravity factor (1 = normal gravity, 0 = no gravity)
/// Generated from method `JPH::MotionProperties::GetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetGravityFactor(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetGravityFactor(JPH_MotionProperties *_this, float inGravityFactor);

/// Get inverse mass (1 / mass). Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as 1 / mass = 0)
/// Generated from method `JPH::MotionProperties::GetInverseMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetInverseMass(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::GetInverseMassUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_MotionProperties_GetInverseMassUnchecked(const JPH_MotionProperties *_this);

/// Set the inverse mass (1 / mass).
/// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
/// If you change mass, inertia should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
/// If all your translation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
/// Generated from method `JPH::MotionProperties::SetInverseMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetInverseMass(JPH_MotionProperties *_this, float inInverseMass);

/// Diagonal of inverse inertia matrix: D. Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as D = 0)
/// Generated from method `JPH::MotionProperties::GetInverseInertiaDiagonal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetInverseInertiaDiagonal(const JPH_MotionProperties *_this);

/// Rotation (R) that takes inverse inertia diagonal to local space: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$
/// Generated from method `JPH::MotionProperties::GetInertiaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_MotionProperties_GetInertiaRotation(const JPH_MotionProperties *_this);

/// Set the inverse inertia tensor in local space by setting the diagonal and the rotation: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$.
/// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
/// If you change inertia, mass should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
/// If all your rotation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
/// Generated from method `JPH::MotionProperties::SetInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDiagonal` can not be null. It is a single object.
/// Parameter `inRot` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetInverseInertia(JPH_MotionProperties *_this, const JPH_Vec3 *inDiagonal, const JPH_Quat *inRot);

/// Sets the mass to inMass and scale the inertia tensor based on the ratio between the old and new mass.
/// Note that this only works when the current mass is finite (i.e. the body is dynamic and translational degrees of freedom are not restricted).
/// Generated from method `JPH::MotionProperties::ScaleToMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ScaleToMass(JPH_MotionProperties *_this, float inMass);

/// Get inverse inertia matrix (\f$I_{body}^{-1}\f$). Will be a matrix of zeros for a static or kinematic object.
/// Generated from method `JPH::MotionProperties::GetLocalSpaceInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_MotionProperties_GetLocalSpaceInverseInertia(const JPH_MotionProperties *_this);

/// Same as GetLocalSpaceInverseInertia() but doesn't check if the body is dynamic
/// Generated from method `JPH::MotionProperties::GetLocalSpaceInverseInertiaUnchecked`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked(const JPH_MotionProperties *_this);

/// Get inverse inertia matrix (\f$I^{-1}\f$) for a given object rotation (translation will be ignored). Zero if object is static or kinematic.
/// Generated from method `JPH::MotionProperties::GetInverseInertiaForRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_MotionProperties_GetInverseInertiaForRotation(const JPH_MotionProperties *_this, const JPH_Mat44 *inRotation);

/// Multiply a vector with the inverse world space inertia tensor (\f$I_{world}^{-1}\f$). Zero if object is static or kinematic.
/// Generated from method `JPH::MotionProperties::MultiplyWorldSpaceInverseInertiaByVector`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector(const JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inV);

/// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
/// Generated from method `JPH::MotionProperties::GetPointVelocityCOM`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPointRelativeToCOM` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetPointVelocityCOM(const JPH_MotionProperties *_this, const JPH_Vec3 *inPointRelativeToCOM);

// Get the total amount of force applied to the center of mass this time step (through Body::AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::MotionProperties::GetAccumulatedForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetAccumulatedForce(const JPH_MotionProperties *_this);

// Get the total amount of torque applied to the center of mass this time step (through Body::AddForce/Body::AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
/// Generated from method `JPH::MotionProperties::GetAccumulatedTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_GetAccumulatedTorque(const JPH_MotionProperties *_this);

// Reset the total accumulated force, note that this will be done automatically after every time step.
/// Generated from method `JPH::MotionProperties::ResetForce`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ResetForce(JPH_MotionProperties *_this);

// Reset the total accumulated torque, note that this will be done automatically after every time step.
/// Generated from method `JPH::MotionProperties::ResetTorque`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ResetTorque(JPH_MotionProperties *_this);

// Reset the current velocity and accumulated force and torque.
/// Generated from method `JPH::MotionProperties::ResetMotion`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ResetMotion(JPH_MotionProperties *_this);

/// Returns a vector where the linear components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
/// Generated from method `JPH::MotionProperties::GetLinearDOFsMask`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_MotionProperties_GetLinearDOFsMask(const JPH_MotionProperties *_this);

/// Takes a translation vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
/// Generated from method `JPH::MotionProperties::LockTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_LockTranslation(const JPH_MotionProperties *_this, const JPH_Vec3 *inV);

/// Returns a vector where the angular components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
/// Generated from method `JPH::MotionProperties::GetAngularDOFsMask`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_UVec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_UVec4 *JPH_MotionProperties_GetAngularDOFsMask(const JPH_MotionProperties *_this);

/// Takes an angular velocity / torque vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
/// Generated from method `JPH::MotionProperties::LockAngular`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_MotionProperties_LockAngular(const JPH_MotionProperties *_this, const JPH_Vec3 *inV);

/// Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::MotionProperties::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetNumVelocityStepsOverride(JPH_MotionProperties *_this, unsigned int inN);

/// Generated from method `JPH::MotionProperties::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MotionProperties_GetNumVelocityStepsOverride(const JPH_MotionProperties *_this);

/// Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::MotionProperties::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetNumPositionStepsOverride(JPH_MotionProperties *_this, unsigned int inN);

/// Generated from method `JPH::MotionProperties::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MotionProperties_GetNumPositionStepsOverride(const JPH_MotionProperties *_this);

///@name Update linear and angular velocity (used during constraint solving)
///@{
/// Generated from method `JPH::MotionProperties::AddLinearVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_AddLinearVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange);

/// Generated from method `JPH::MotionProperties::SubLinearVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SubLinearVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange);

/// Generated from method `JPH::MotionProperties::AddAngularVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_AddAngularVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange);

/// Generated from method `JPH::MotionProperties::SubAngularVelocityStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inAngularVelocityChange` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SubAngularVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange);

/// Apply the gyroscopic force (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
/// Generated from method `JPH::MotionProperties::ApplyGyroscopicForceInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ApplyGyroscopicForceInternal(JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, float inDeltaTime);

/// Apply all accumulated forces, torques and drag (should only be called by the PhysicsSystem)
/// Generated from method `JPH::MotionProperties::ApplyForceTorqueAndDragInternal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyRotation` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ApplyForceTorqueAndDragInternal(JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inGravity, float inDeltaTime);

/// Access to the island index
/// Generated from method `JPH::MotionProperties::GetIslandIndexInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MotionProperties_GetIslandIndexInternal(const JPH_MotionProperties *_this);

/// Generated from method `JPH::MotionProperties::SetIslandIndexInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_SetIslandIndexInternal(JPH_MotionProperties *_this, unsigned int inIndex);

/// Access to the index in the active bodies array
/// Generated from method `JPH::MotionProperties::GetIndexInActiveBodiesInternal`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_MotionProperties_GetIndexInActiveBodiesInternal(const JPH_MotionProperties *_this);

/// Reset spheres to center around inPoints with radius 0
/// Generated from method `JPH::MotionProperties::ResetSleepTestSpheres`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ResetSleepTestSpheres(JPH_MotionProperties *_this, const JPH_Vec3 *inPoints);

/// Reset the sleep test timer without resetting the sleep test spheres
/// Generated from method `JPH::MotionProperties::ResetSleepTestTimer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_MotionProperties_ResetSleepTestTimer(JPH_MotionProperties *_this);

#ifdef __cplusplus
} // extern "C"
#endif
