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
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Cone constraint settings, used to create a cone constraint
/// Generated from class `JPH::ConeConstraintSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::ConstraintSettings>`
///     `JPH::ConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ConeConstraintSettings JPH_ConeConstraintSettings;

/// A cone constraint constraints 2 bodies to a single point and limits the swing between the twist axis within a cone:
///
/// t1 . t2 <= cos(theta)
///
/// Where:
///
/// t1 = twist axis of body 1.
/// t2 = twist axis of body 2.
/// theta = half cone angle (angle from the principal axis of the cone to the edge).
///
/// Calculating the Jacobian:
///
/// Constraint equation:
///
/// C = t1 . t2 - cos(theta)
///
/// Derivative:
///
/// d/dt C = d/dt (t1 . t2) = (d/dt t1) . t2 + t1 . (d/dt t2) = (w1 x t1) . t2 + t1 . (w2 x t2) = (t1 x t2) . w1 + (t2 x t1) . w2
///
/// d/dt C = J v = [0, -t2 x t1, 0, t2 x t1] [v1, w1, v2, w2]
///
/// Where J is the Jacobian.
///
/// Note that this is the exact same equation as used in AngleConstraintPart if we use t2 x t1 as the world space axis
/// Generated from class `JPH::ConeConstraint`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TwoBodyConstraint`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::Constraint>`
///     `JPH::NonCopyable`
///     `JPH::Constraint`
typedef struct JPH_ConeConstraint JPH_ConeConstraint;

/// Body 1 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mPoint1(const JPH_ConeConstraintSettings *_this);

/// Body 1 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mPoint1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mPoint1(JPH_ConeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mTwistAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mTwistAxis1(const JPH_ConeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mTwistAxis1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mTwistAxis1(JPH_ConeConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mPoint2(const JPH_ConeConstraintSettings *_this);

/// Body 2 constraint reference frame (space determined by mSpace)
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mPoint2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mPoint2(JPH_ConeConstraintSettings *_this);

/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mTwistAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mTwistAxis2(const JPH_ConeConstraintSettings *_this);

/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mTwistAxis2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mTwistAxis2(JPH_ConeConstraintSettings *_this);

/// Half of maximum angle between twist axis of body 1 and 2
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConeConstraintSettings_Get_mHalfConeAngle(const JPH_ConeConstraintSettings *_this);

/// Half of maximum angle between twist axis of body 1 and 2
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHalfConeAngle`.
JOLT_API void JPH_ConeConstraintSettings_Set_mHalfConeAngle(JPH_ConeConstraintSettings *_this, float value);

/// Half of maximum angle between twist axis of body 1 and 2
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConeConstraintSettings_GetMutable_mHalfConeAngle(JPH_ConeConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_ConeConstraintSettings_Get_mEnabled(const JPH_ConeConstraintSettings *_this);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnabled`.
JOLT_API void JPH_ConeConstraintSettings_Set_mEnabled(JPH_ConeConstraintSettings *_this, bool value);

/// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_ConeConstraintSettings_GetMutable_mEnabled(JPH_ConeConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_ConeConstraintSettings_Get_mConstraintPriority(const JPH_ConeConstraintSettings *_this);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mConstraintPriority`.
/// When this function is called, this object will drop object references it held previously in `mConstraintPriority`.
JOLT_API void JPH_ConeConstraintSettings_Set_mConstraintPriority(JPH_ConeConstraintSettings *_this, unsigned int value);

/// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_ConeConstraintSettings_GetMutable_mConstraintPriority(JPH_ConeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_ConeConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_ConeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocityStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocityStepsOverride`.
JOLT_API void JPH_ConeConstraintSettings_Set_mNumVelocityStepsOverride(JPH_ConeConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_ConeConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_ConeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_ConeConstraintSettings_Get_mNumPositionStepsOverride(const JPH_ConeConstraintSettings *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionStepsOverride`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionStepsOverride`.
JOLT_API void JPH_ConeConstraintSettings_Set_mNumPositionStepsOverride(JPH_ConeConstraintSettings *_this, unsigned int value);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_ConeConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_ConeConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ConeConstraintSettings_Get_mDrawConstraintSize(const JPH_ConeConstraintSettings *_this);

/// Size of constraint when drawing it through the debug renderer
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDrawConstraintSize`.
JOLT_API void JPH_ConeConstraintSettings_Set_mDrawConstraintSize(JPH_ConeConstraintSettings *_this, float value);

/// Size of constraint when drawing it through the debug renderer
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ConeConstraintSettings_GetMutable_mDrawConstraintSize(JPH_ConeConstraintSettings *_this);

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::ConeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_ConeConstraintSettings_Get_mUserData(const JPH_ConeConstraintSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::ConeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_ConeConstraintSettings_Set_mUserData(JPH_ConeConstraintSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::ConeConstraintSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_ConeConstraintSettings_GetMutable_mUserData(JPH_ConeConstraintSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConeConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ConeConstraintSettings_DestroyArray()`.
/// Use `JPH_ConeConstraintSettings_OffsetMutablePtr()` and `JPH_ConeConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_OffsetPtr(const JPH_ConeConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_OffsetMutablePtr(JPH_ConeConstraintSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_ConeConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_ConeConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConeConstraintSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_ConeConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_ConeConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::ConstraintSettings>` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_ConeConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::ConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_ConeConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object);

/// Downcasts an instance of `JPH::ConstraintSettings` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_ConeConstraintSettings *object);

/// Upcasts an instance of `JPH::ConeConstraintSettings` to its base class `JPH::TwoBodyConstraintSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_ConeConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object);

/// Downcasts an instance of `JPH::TwoBodyConstraintSettings` to a derived class `JPH::ConeConstraintSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object);

/// Generated from constructor `JPH::ConeConstraintSettings::ConeConstraintSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConeConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ConeConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_ConeConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConeConstraintSettings_Destroy(const JPH_ConeConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_ConeConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ConeConstraintSettings_DestroyArray(const JPH_ConeConstraintSettings *_this);

/// Generated from method `JPH::ConeConstraintSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_AssignFromAnother(JPH_ConeConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_ConeConstraintSettings *_other);

/// Generated from method `JPH::ConeConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConeConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::ConeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ConeConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConeConstraintSettings_size_t(size_t inCount);

/// Generated from method `JPH::ConeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::ConeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ConeConstraintSettings::operator new`.
JOLT_API void *Jolt_new_JPH_ConeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ConeConstraintSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConeConstraintSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ConeConstraintSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of this constraint
/// Generated from method `JPH::ConeConstraintSettings::Create`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_ConeConstraintSettings_Create(const JPH_ConeConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConeConstraintSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraintSettings_SetEmbedded(const JPH_ConeConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConeConstraintSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConeConstraintSettings_GetRefCount(const JPH_ConeConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConeConstraintSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraintSettings_AddRef(const JPH_ConeConstraintSettings *_this);

/// Generated from method `JPH::ConeConstraintSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraintSettings_Release(const JPH_ConeConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConeConstraintSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConeConstraintSettings_sInternalGetRefCountOffset(void);

/// Construct cone constraint
/// Generated from constructor `JPH::ConeConstraint::ConeConstraint`.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ConeConstraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_ConeConstraintSettings *inSettings);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ConeConstraint *JPH_ConeConstraint_OffsetPtr(const JPH_ConeConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_OffsetMutablePtr(JPH_ConeConstraint *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_ConeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_ConeConstraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::RefTarget<JPH::Constraint>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_ConeConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_ConeConstraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::Constraint>` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_ConeConstraint_UpcastTo_JPH_NonCopyable(const JPH_ConeConstraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_ConeConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_ConeConstraint *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::Constraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Constraint *JPH_ConeConstraint_UpcastTo_JPH_Constraint(const JPH_ConeConstraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::Constraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Constraint *JPH_ConeConstraint_MutableUpcastTo_JPH_Constraint(JPH_ConeConstraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object);

/// Downcasts an instance of `JPH::Constraint` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::TwoBodyConstraint`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TwoBodyConstraint *JPH_ConeConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_ConeConstraint *object);

/// Upcasts an instance of `JPH::ConeConstraint` to its base class `JPH::TwoBodyConstraint`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TwoBodyConstraint *JPH_ConeConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_ConeConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object);

/// Downcasts an instance of `JPH::TwoBodyConstraint` to a derived class `JPH::ConeConstraint`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object);

/// Destroys a heap-allocated instance of `JPH_ConeConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_ConeConstraint_Destroy(const JPH_ConeConstraint *_this);

/// Destroys a heap-allocated array of `JPH_ConeConstraint`. Does nothing if the pointer is null.
JOLT_API void JPH_ConeConstraint_DestroyArray(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_ConeConstraint_size_t(size_t inCount);

/// Generated from method `JPH::ConeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::ConeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ConeConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConeConstraint_size_t(size_t inCount);

/// Generated from method `JPH::ConeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraint_void_ptr(void *inPointer);

/// Generated from method `JPH::ConeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraint_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::ConeConstraint::operator new`.
JOLT_API void *Jolt_new_JPH_ConeConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ConeConstraint::operator delete`.
JOLT_API void Jolt_delete_JPH_ConeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConeConstraint::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_ConeConstraint_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::ConeConstraint::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_ConeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::ConeConstraint::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inDeltaCOM` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_NotifyShapeChanged(JPH_ConeConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM);

/// Generated from method `JPH::ConeConstraint::SetupVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetupVelocityConstraint(JPH_ConeConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::ConeConstraint::ResetWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_ResetWarmStart(JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::WarmStartVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_WarmStartVelocityConstraint(JPH_ConeConstraint *_this, float inWarmStartImpulseRatio);

/// Generated from method `JPH::ConeConstraint::SolveVelocityConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConeConstraint_SolveVelocityConstraint(JPH_ConeConstraint *_this, float inDeltaTime);

/// Generated from method `JPH::ConeConstraint::SolvePositionConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConeConstraint_SolvePositionConstraint(JPH_ConeConstraint *_this, float inDeltaTime, float inBaumgarte);

/// Generated from method `JPH::ConeConstraint::DrawConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_DrawConstraint(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Generated from method `JPH::ConeConstraint::DrawConstraintLimits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_DrawConstraintLimits(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer);

// See: TwoBodyConstraint
/// Generated from method `JPH::ConeConstraint::GetConstraintToBody1Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_ConeConstraint_GetConstraintToBody1Matrix(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::GetConstraintToBody2Matrix`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_ConeConstraint_GetConstraintToBody2Matrix(const JPH_ConeConstraint *_this);

/// Update maximum angle between body 1 and 2 (see ConeConstraintSettings)
/// Generated from method `JPH::ConeConstraint::SetHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetHalfConeAngle(JPH_ConeConstraint *_this, float inHalfConeAngle);

/// Generated from method `JPH::ConeConstraint::GetCosHalfConeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConeConstraint_GetCosHalfConeAngle(const JPH_ConeConstraint *_this);

///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
/// Generated from method `JPH::ConeConstraint::GetTotalLambdaPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ConeConstraint_GetTotalLambdaPosition(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::GetTotalLambdaRotation`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConeConstraint_GetTotalLambdaRotation(const JPH_ConeConstraint *_this);

/// Solver interface
/// Generated from method `JPH::ConeConstraint::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConeConstraint_IsActive(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::DrawConstraintReferenceFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_DrawConstraintReferenceFrame(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer);

/// Access to the connected bodies
/// Generated from method `JPH::ConeConstraint::GetBody1`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_ConeConstraint_GetBody1(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::GetBody2`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_ConeConstraint_GetBody2(const JPH_ConeConstraint *_this);

/// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
/// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
/// Generated from method `JPH::ConeConstraint::GetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConeConstraint_GetConstraintPriority(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::SetConstraintPriority`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetConstraintPriority(JPH_ConeConstraint *_this, unsigned int inPriority);

/// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::ConeConstraint::SetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetNumVelocityStepsOverride(JPH_ConeConstraint *_this, unsigned int inN);

/// Generated from method `JPH::ConeConstraint::GetNumVelocityStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConeConstraint_GetNumVelocityStepsOverride(const JPH_ConeConstraint *_this);

/// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
/// Generated from method `JPH::ConeConstraint::SetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetNumPositionStepsOverride(JPH_ConeConstraint *_this, unsigned int inN);

/// Generated from method `JPH::ConeConstraint::GetNumPositionStepsOverride`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConeConstraint_GetNumPositionStepsOverride(const JPH_ConeConstraint *_this);

/// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
/// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
/// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
/// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
/// Generated from method `JPH::ConeConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetEnabled(JPH_ConeConstraint *_this, bool inEnabled);

/// Test if a constraint is enabled.
/// Generated from method `JPH::ConeConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_ConeConstraint_GetEnabled(const JPH_ConeConstraint *_this);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::ConeConstraint::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_ConeConstraint_GetUserData(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetUserData(JPH_ConeConstraint *_this, uint64_t inUserData);

/// Size of constraint when drawing it through the debug renderer
/// Generated from method `JPH::ConeConstraint::GetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_ConeConstraint_GetDrawConstraintSize(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::SetDrawConstraintSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetDrawConstraintSize(JPH_ConeConstraint *_this, float inSize);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::ConeConstraint::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_SetEmbedded(const JPH_ConeConstraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::ConeConstraint::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_ConeConstraint_GetRefCount(const JPH_ConeConstraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::ConeConstraint::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_AddRef(const JPH_ConeConstraint *_this);

/// Generated from method `JPH::ConeConstraint::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_ConeConstraint_Release(const JPH_ConeConstraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::ConeConstraint::sInternalGetRefCountOffset`.
JOLT_API int JPH_ConeConstraint_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
