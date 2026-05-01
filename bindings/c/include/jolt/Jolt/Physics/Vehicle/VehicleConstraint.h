// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_Constraint JPH_Constraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/Constraint.h>`.
typedef struct JPH_ConstraintSettings JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/Constraint.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsStepListener JPH_PhysicsStepListener; // Defined in `#include <jolt/Jolt/Physics/PhysicsStepListener.h>`.
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleCollisionTester JPH_VehicleCollisionTester; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleCollisionTester.h>`.
typedef struct JPH_VehicleController JPH_VehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleController.h>`.
typedef struct JPH_Wheel JPH_Wheel; // Defined in `#include <jolt/Jolt/Physics/Vehicle/Wheel.h>`.
typedef struct Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref; // Defined in `#include <std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref.h>`.
typedef struct Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref; // Defined in `#include <std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_re__883b.h>`.


/// Configuration for constraint that simulates a wheeled vehicle.
///
/// The properties in this constraint are largely based on "Car Physics for Games" by Marco Monster.
/// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
/// Generated from class `JPH::VehicleConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::ConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_VehicleConstraintSettings JPH_VehicleConstraintSettings;

/// Constraint that simulates a vehicle
/// Note: Don't forget to register the constraint as a StepListener with the PhysicsSystem!
///
/// When the vehicle drives over very light objects (rubble) you may see the car body dip down. This is a known issue and is an artifact of the iterative solver that Jolt is using.
/// Basically if a light object is sandwiched between two heavy objects (the static floor and the car body), the light object is not able to transfer enough force from the ground to
/// the car body to keep the car body up. You can see this effect in the HeavyOnLightTest sample, the boxes on the right have a lot of penetration because they're on top of light objects.
///
/// There are a couple of ways to improve this:
///
/// 1. You can increase the number of velocity steps (global settings PhysicsSettings::mNumVelocitySteps or if you only want to increase it on
/// the vehicle you can use VehicleConstraintSettings::mNumVelocityStepsOverride). E.g. going from 10 to 30 steps in the HeavyOnLightTest sample makes the penetration a lot less.
/// The number of position steps can also be increased (the first prevents the body from going down, the second corrects it if the problem did
/// occur which inevitably happens due to numerical drift). This solution costs CPU cycles.
///
/// 2. You can reduce the mass difference between the vehicle body and the rubble on the floor (by making the rubble heavier or the car lighter).
///
/// 3. You could filter out collisions between the vehicle collision test and the rubble completely. This would make the wheels ignore the rubble but would cause the vehicle to drive
/// through it as if nothing happened. You could create fake wheels (keyframed bodies) that move along with the vehicle and that only collide with rubble (and not the vehicle or the ground).
/// This would cause the vehicle to push away the rubble without the rubble being able to affect the vehicle (unless it hits the main body of course).
///
/// Note that when driving over rubble, you may see the wheel jump up and down quite quickly because one frame a collision is found and the next frame not.
/// To alleviate this, it may be needed to smooth the motion of the visual mesh for the wheel.
/// Generated from class `JPH::VehicleConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::Constraint`
///     `JPH::PhysicsStepListener`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint;

///< Vector indicating the up direction of the vehicle (in local space to the body)
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_VehicleConstraintSettings_Get_mUp(const JPH_VehicleConstraintSettings *_this);

///< Vector indicating the up direction of the vehicle (in local space to the body)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_VehicleConstraintSettings_GetMutable_mUp(JPH_VehicleConstraintSettings *_this);

///< Vector indicating forward direction of the vehicle (in local space to the body)
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_VehicleConstraintSettings_Get_mForward(const JPH_VehicleConstraintSettings *_this);

///< Vector indicating forward direction of the vehicle (in local space to the body)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_VehicleConstraintSettings_GetMutable_mForward(JPH_VehicleConstraintSettings *_this);

///< Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mMaxPitchRollAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle(const JPH_VehicleConstraintSettings *_this);

///< Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mMaxPitchRollAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxPitchRollAngle`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mMaxPitchRollAngle(JPH_VehicleConstraintSettings *_this, float value);

///< Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mMaxPitchRollAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle(JPH_VehicleConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_VehicleConstraintSettings_Get_mEnabled(const JPH_VehicleConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mEnabled(JPH_VehicleConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_VehicleConstraintSettings_GetMutable_mEnabled(JPH_VehicleConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_VehicleConstraintSettings_Get_mConstraintPriority(const JPH_VehicleConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mConstraintPriority(JPH_VehicleConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority(JPH_VehicleConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_VehicleConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mNumVelocityStepsOverride(JPH_VehicleConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_VehicleConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride(const JPH_VehicleConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mNumPositionStepsOverride(JPH_VehicleConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_VehicleConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_VehicleConstraintSettings_Get_mDrawConstraintSize(const JPH_VehicleConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mDrawConstraintSize(JPH_VehicleConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize(JPH_VehicleConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_VehicleConstraintSettings_Get_mUserData(const JPH_VehicleConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::VehicleConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_VehicleConstraintSettings_Set_mUserData(JPH_VehicleConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::VehicleConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_VehicleConstraintSettings_GetMutable_mUserData(JPH_VehicleConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_VehicleConstraintSettings_DestroyArray()`.
/// Use `JPH_VehicleConstraintSettings_OffsetMutablePtr()` and `JPH_VehicleConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_OffsetPtr(const JPH_VehicleConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_OffsetMutablePtr(JPH_VehicleConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_VehicleConstraintSettings *object);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_VehicleConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_VehicleConstraintSettings *object);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_VehicleConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_VehicleConstraintSettings *object);

/// Upcasts an instance of `JPH::VehicleConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_VehicleConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::VehicleConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_VehicleConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleConstraintSettings_Destroy(const JPH_VehicleConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleConstraintSettings_DestroyArray(const JPH_VehicleConstraintSettings *_this);

/// Generated from method `JPH::VehicleConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_AssignFromAnother(JPH_VehicleConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleConstraintSettings *_other);

/// Generated from method `JPH::VehicleConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraintSettings_SetEmbedded(const JPH_VehicleConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraintSettings_GetRefCount(const JPH_VehicleConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraintSettings_AddRef(const JPH_VehicleConstraintSettings *_this);

/// Generated from method `JPH::VehicleConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraintSettings_Release(const JPH_VehicleConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleConstraintSettings_sInternalGetRefCountOffset(void);

/// Constructor / destructor
/// Generated from constructor `JPH::VehicleConstraint::VehicleConstraint`.
/// Parameter `inVehicleBody` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_Construct(JPH_Body *inVehicleBody, const JPH_VehicleConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleConstraint_OffsetPtr(const JPH_VehicleConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_OffsetMutablePtr(JPH_VehicleConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_VehicleConstraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_VehicleConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_VehicleConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(const JPH_VehicleConstraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_VehicleConstraint_UpcastTo_JPH_Constraint(const JPH_VehicleConstraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_VehicleConstraint_MutableUpcastTo_JPH_Constraint(JPH_VehicleConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::PhysicsStepListener`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsStepListener *JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(const JPH_VehicleConstraint *object);

/// Upcasts an instance of `JPH::VehicleConstraint` to its base class `JPH::PhysicsStepListener`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsStepListener *JPH_VehicleConstraint_MutableUpcastTo_JPH_PhysicsStepListener(JPH_VehicleConstraint *object);

/// Downcasts an instance of `JPH::PhysicsStepListener` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_PhysicsStepListener(const JPH_PhysicsStepListener *object);

/// Downcasts an instance of `JPH::PhysicsStepListener` to a derived class `JPH::VehicleConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_PhysicsStepListener(JPH_PhysicsStepListener *object);

/// Destroys a heap-allocated instance of `JPH_VehicleConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleConstraint_Destroy(const JPH_VehicleConstraint *_this);

/// Destroys a heap-allocated array of `JPH_VehicleConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleConstraint_DestroyArray(const JPH_VehicleConstraint *_this);

/// Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
/// Generated from method `JPH::VehicleConstraint::SetMaxPitchRollAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetMaxPitchRollAngle(JPH_VehicleConstraint *_this, float inMaxPitchRollAngle);

/// Generated from method `JPH::VehicleConstraint::GetMaxPitchRollAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleConstraint_GetMaxPitchRollAngle(const JPH_VehicleConstraint *_this);

/// Set the interface that tests collision between wheel and ground
/// Generated from method `JPH::VehicleConstraint::SetVehicleCollisionTester`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetVehicleCollisionTester(JPH_VehicleConstraint *_this, const JPH_VehicleCollisionTester *inTester);

/// Generated from method `JPH::VehicleConstraint::GetVehicleCollisionTester`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleConstraint_GetVehicleCollisionTester(const JPH_VehicleConstraint *_this);

/// Set the function that combines the friction of two bodies and returns it
/// Default method is the geometric mean: sqrt(friction1 * friction2).
/// Generated from method `JPH::VehicleConstraint::SetCombineFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCombineFriction` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetCombineFriction(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *inCombineFriction);

/// Generated from method `JPH::VehicleConstraint::GetCombineFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *JPH_VehicleConstraint_GetCombineFriction(const JPH_VehicleConstraint *_this);

/// Callback function to notify that PhysicsStepListener::OnStep has started for this vehicle. Default is to do nothing.
/// Can be used to allow higher-level code to e.g. control steering. This is the last moment that the position/orientation of the vehicle can be changed.
/// Wheel collision checks have not been performed yet.
/// Generated from method `JPH::VehicleConstraint::GetPreStepCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPreStepCallback(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetPreStepCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPreStepCallback` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetPreStepCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPreStepCallback);

/// Callback function to notify that PhysicsStepListener::OnStep has just completed wheel collision checks. Default is to do nothing.
/// Can be used to allow higher-level code to e.g. detect tire contact or to modify the velocity of the vehicle based on the wheel contacts.
/// You should not change the position of the vehicle in this callback as the wheel collision checks have already been performed.
/// Generated from method `JPH::VehicleConstraint::GetPostCollideCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPostCollideCallback(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetPostCollideCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPostCollideCallback` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetPostCollideCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPostCollideCallback);

/// Callback function to notify that PhysicsStepListener::OnStep has completed for this vehicle. Default is to do nothing.
/// Can be used to allow higher-level code to e.g. control the vehicle in the air.
/// You should not change the position of the vehicle in this callback as the wheel collision checks have already been performed.
/// Generated from method `JPH::VehicleConstraint::GetPostStepCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPostStepCallback(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetPostStepCallback`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPostStepCallback` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetPostStepCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPostStepCallback);

/// Override gravity for this vehicle. Note that overriding gravity will set the gravity factor of the vehicle body to 0 and apply gravity in the PhysicsStepListener instead.
/// Generated from method `JPH::VehicleConstraint::OverrideGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_OverrideGravity(JPH_VehicleConstraint *_this, const JPH_Vec3 *inGravity);

/// Generated from method `JPH::VehicleConstraint::IsGravityOverridden`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleConstraint_IsGravityOverridden(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::GetGravityOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_VehicleConstraint_GetGravityOverride(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::ResetGravityOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_ResetGravityOverride(JPH_VehicleConstraint *_this);

/// Get the local space forward vector of the vehicle
/// Generated from method `JPH::VehicleConstraint::GetLocalForward`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_VehicleConstraint_GetLocalForward(const JPH_VehicleConstraint *_this);

/// Get the local space up vector of the vehicle
/// Generated from method `JPH::VehicleConstraint::GetLocalUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_VehicleConstraint_GetLocalUp(const JPH_VehicleConstraint *_this);

/// Vector indicating the world space up direction (used to limit vehicle pitch/roll), calculated every frame by inverting gravity
/// Generated from method `JPH::VehicleConstraint::GetWorldUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_VehicleConstraint_GetWorldUp(const JPH_VehicleConstraint *_this);

/// Access to the vehicle body
/// Generated from method `JPH::VehicleConstraint::GetVehicleBody`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_VehicleConstraint_GetVehicleBody(const JPH_VehicleConstraint *_this);

/// Access to the vehicle controller interface (determines acceleration / deceleration)
/// Generated from method `JPH::VehicleConstraint::GetController`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_VehicleController *JPH_VehicleConstraint_GetController(const JPH_VehicleConstraint *_this);

/// Access to the vehicle controller interface (determines acceleration / deceleration)
/// Generated from method `JPH::VehicleConstraint::GetController`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_VehicleController *JPH_VehicleConstraint_GetController_mut(JPH_VehicleConstraint *_this);

/// Get the state of a wheel
/// Generated from method `JPH::VehicleConstraint::GetWheel`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Wheel *JPH_VehicleConstraint_GetWheel_mut(JPH_VehicleConstraint *_this, unsigned int inIdx);

/// Generated from method `JPH::VehicleConstraint::GetWheel`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Wheel *JPH_VehicleConstraint_GetWheel(const JPH_VehicleConstraint *_this, unsigned int inIdx);

/// Get the basis vectors for the wheel in local space to the vehicle body (note: basis does not rotate when the wheel rotates around its axis)
/// @param inWheel Wheel to fetch basis for
/// @param outForward Forward vector for the wheel
/// @param outUp Up vector for the wheel
/// @param outRight Right vector for the wheel
/// Generated from method `JPH::VehicleConstraint::GetWheelLocalBasis`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outForward` can not be null. It is a single object.
/// Parameter `outUp` can not be null. It is a single object.
/// Parameter `outRight` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_GetWheelLocalBasis(const JPH_VehicleConstraint *_this, const JPH_Wheel *inWheel, JPH_Vec3 *outForward, JPH_Vec3 *outUp, JPH_Vec3 *outRight);

/// Get the transform of a wheel in local space to the vehicle body, returns a matrix that transforms a cylinder aligned with the Y axis in body space (not COM space)
/// @param inWheelIndex Index of the wheel to fetch
/// @param inWheelRight Unit vector that indicates right in model space of the wheel (so if you only have 1 wheel model, you probably want to specify the opposite direction for the left and right wheels)
/// @param inWheelUp Unit vector that indicates up in model space of the wheel
/// Generated from method `JPH::VehicleConstraint::GetWheelLocalTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inWheelRight` can not be null. It is a single object.
/// Parameter `inWheelUp` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_VehicleConstraint_GetWheelLocalTransform(const JPH_VehicleConstraint *_this, unsigned int inWheelIndex, const JPH_Vec3 *inWheelRight, const JPH_Vec3 *inWheelUp);

/// Get the transform of a wheel in world space, returns a matrix that transforms a cylinder aligned with the Y axis in world space
/// @param inWheelIndex Index of the wheel to fetch
/// @param inWheelRight Unit vector that indicates right in model space of the wheel (so if you only have 1 wheel model, you probably want to specify the opposite direction for the left and right wheels)
/// @param inWheelUp Unit vector that indicates up in model space of the wheel
/// Generated from method `JPH::VehicleConstraint::GetWheelWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inWheelRight` can not be null. It is a single object.
/// Parameter `inWheelUp` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_VehicleConstraint_GetWheelWorldTransform(const JPH_VehicleConstraint *_this, unsigned int inWheelIndex, const JPH_Vec3 *inWheelRight, const JPH_Vec3 *inWheelUp);

/// Number of simulation steps between wheel collision tests when the vehicle is active. Default is 1. 0 = never, 1 = every step, 2 = every other step, etc.
/// Note that if a vehicle has multiple wheels and the number of steps > 1, the wheels will be tested in a round robin fashion.
/// If there are multiple vehicles, the tests will be spread out based on the BodyID of the vehicle.
/// If you set this to test less than every step, you may see simulation artifacts. This setting can be used to reduce the cost of simulating vehicles in the distance.
/// Generated from method `JPH::VehicleConstraint::SetNumStepsBetweenCollisionTestActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive(JPH_VehicleConstraint *_this, unsigned int inSteps);

/// Generated from method `JPH::VehicleConstraint::GetNumStepsBetweenCollisionTestActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive(const JPH_VehicleConstraint *_this);

/// Number of simulation steps between wheel collision tests when the vehicle is inactive. Default is 1. 0 = never, 1 = every step, 2 = every other step, etc.
/// Note that if a vehicle has multiple wheels and the number of steps > 1, the wheels will be tested in a round robin fashion.
/// If there are multiple vehicles, the tests will be spread out based on the BodyID of the vehicle.
/// This number can be lower than the number of steps when the vehicle is active as the only purpose of this test is
/// to allow the vehicle to wake up in response to bodies moving into the wheels but not touching the body of the vehicle.
/// Generated from method `JPH::VehicleConstraint::SetNumStepsBetweenCollisionTestInactive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive(JPH_VehicleConstraint *_this, unsigned int inSteps);

/// Generated from method `JPH::VehicleConstraint::GetNumStepsBetweenCollisionTestInactive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive(const JPH_VehicleConstraint *_this);

// Generic interface of a constraint
/// Generated from method `JPH::VehicleConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleConstraint_IsActive(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_NotifyShapeChanged(JPH_VehicleConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::VehicleConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetupVelocityConstraint(JPH_VehicleConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::VehicleConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_ResetWarmStart(JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_WarmStartVelocityConstraint(JPH_VehicleConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::VehicleConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleConstraint_SolveVelocityConstraint(JPH_VehicleConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::VehicleConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleConstraint_SolvePositionConstraint(JPH_VehicleConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::VehicleConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_DrawConstraint(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Generated from method `JPH::VehicleConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_DrawConstraintLimits(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::VehicleConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetConstraintPriority(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetConstraintPriority(JPH_VehicleConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::VehicleConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetNumVelocityStepsOverride(JPH_VehicleConstraint *_this, unsigned int inN);

/// Generated from method `JPH::VehicleConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetNumVelocityStepsOverride(const JPH_VehicleConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::VehicleConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetNumPositionStepsOverride(JPH_VehicleConstraint *_this, unsigned int inN);

/// Generated from method `JPH::VehicleConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetNumPositionStepsOverride(const JPH_VehicleConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::VehicleConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetEnabled(JPH_VehicleConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::VehicleConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_VehicleConstraint_GetEnabled(const JPH_VehicleConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::VehicleConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_VehicleConstraint_GetUserData(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetUserData(JPH_VehicleConstraint *_this, uint64_t inUserData);

/// Generated from method `JPH::VehicleConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_DrawConstraintReferenceFrame(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::VehicleConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_VehicleConstraint_GetDrawConstraintSize(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetDrawConstraintSize(JPH_VehicleConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_SetEmbedded(const JPH_VehicleConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleConstraint_GetRefCount(const JPH_VehicleConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_AddRef(const JPH_VehicleConstraint *_this);

/// Generated from method `JPH::VehicleConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleConstraint_Release(const JPH_VehicleConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
