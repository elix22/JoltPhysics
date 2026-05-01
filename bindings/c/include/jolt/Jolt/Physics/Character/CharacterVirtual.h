// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Body/MotionType.h>
#include <jolt/Jolt/Physics/Character/CharacterBase.h>
#include <jolt/Jolt/Physics/Collision/BackFaceMode.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyFilter JPH_BodyFilter; // Defined in `#include <jolt/Jolt/Physics/Body/BodyFilter.h>`.
typedef struct JPH_BroadPhaseLayerFilter JPH_BroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_CharacterBase JPH_CharacterBase; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterBase.h>`.
typedef struct JPH_CharacterBaseSettings JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterBase.h>`.
typedef struct JPH_CharacterID JPH_CharacterID; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterID.h>`.
typedef struct JPH_CollideShapeSettings JPH_CollideShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerFilter JPH_ObjectLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBase JPH_RefTarget_JPH_CharacterBase; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBaseSettings JPH_RefTarget_JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_ShapeCastSettings JPH_ShapeCastSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/ShapeCast.h>`.
typedef struct JPH_ShapeFilter JPH_ShapeFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ShapeFilter.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TempAllocator JPH_TempAllocator; // Defined in `#include <jolt/Jolt/Core/TempAllocator.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Contains the configuration of a character
/// Generated from class `JPH::CharacterVirtualSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBaseSettings`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterVirtualSettings JPH_CharacterVirtualSettings;

/// This class contains settings that allow you to override the behavior of a character's collision response
/// Generated from class `JPH::CharacterContactSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterContactSettings JPH_CharacterContactSettings;

/// This class receives callbacks when a virtual character hits something.
/// Once created, register it on a CharacterVirtual by using the character's SetListener method.
/// Generated from class `JPH::CharacterContactListener`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterContactListener JPH_CharacterContactListener;

/// Interface class that allows a CharacterVirtual to check collision with other CharacterVirtual instances.
/// Since CharacterVirtual instances are not registered anywhere, it is up to the application to test collision against relevant characters.
/// The characters could be stored in a tree structure to make this more efficient.
/// Generated from class `JPH::CharacterVsCharacterCollision`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVsCharacterCollisionSimple`
typedef struct JPH_CharacterVsCharacterCollision JPH_CharacterVsCharacterCollision;

/// Simple collision checker that loops over all registered characters.
/// This is a brute force checking algorithm. If you have a lot of characters you may want to store your characters
/// in a hierarchical structure to make this more efficient.
/// Note that this is not thread safe, so make sure that only one CharacterVirtual is checking collision at a time.
/// Generated from class `JPH::CharacterVsCharacterCollisionSimple`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVsCharacterCollision`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterVsCharacterCollisionSimple JPH_CharacterVsCharacterCollisionSimple;

/// Settings struct with settings for ExtendedUpdate
/// Generated from class `JPH::CharacterVirtual::ExtendedUpdateSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterVirtual_ExtendedUpdateSettings JPH_CharacterVirtual_ExtendedUpdateSettings;

/// Uniquely identifies a contact between a character and another body or character
/// Generated from class `JPH::CharacterVirtual::ContactKey`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVirtual::Contact`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterVirtual_ContactKey JPH_CharacterVirtual_ContactKey;

/// Encapsulates a collision contact
/// Generated from class `JPH::CharacterVirtual::Contact`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVirtual::ContactKey`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterVirtual_Contact JPH_CharacterVirtual_Contact;

/// Runtime character object.
/// This object usually represents the player. Contrary to the Character class it doesn't use a rigid body but moves doing collision checks only (hence the name virtual).
/// The advantage of this is that you can determine when the character moves in the frame (usually this has to happen at a very particular point in the frame)
/// but the downside is that other objects don't see this virtual character. To make a CharacterVirtual visible to the simulation, you can optionally create an inner
/// rigid body through CharacterVirtualSettings::mInnerBodyShape. A CharacterVirtual is not tracked by the PhysicsSystem so you need to update it yourself. This also means
/// that a call to PhysicsSystem::SaveState will not save its state, you need to call CharacterVirtual::SaveState yourself.
/// Generated from class `JPH::CharacterVirtual`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBase`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBase>`
///     `JPH::NonCopyable`
typedef struct JPH_CharacterVirtual JPH_CharacterVirtual;

/// ID to give to this character. This is used for deterministically sorting and as an identifier to represent the character in the contact removal callback.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterID *JPH_CharacterVirtualSettings_Get_mID(const JPH_CharacterVirtualSettings *_this);

/// ID to give to this character. This is used for deterministically sorting and as an identifier to represent the character in the contact removal callback.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mID`.
/// When this function is called, this object will drop object references it held previously in `mID`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mID(JPH_CharacterVirtualSettings *_this, const JPH_CharacterID *value);

/// ID to give to this character. This is used for deterministically sorting and as an identifier to represent the character in the contact removal callback.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterID *JPH_CharacterVirtualSettings_GetMutable_mID(JPH_CharacterVirtualSettings *_this);

/// Character mass (kg). Used to push down objects with gravity when the character is standing on top.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mMass(const JPH_CharacterVirtualSettings *_this);

/// Character mass (kg). Used to push down objects with gravity when the character is standing on top.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMass`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMass(JPH_CharacterVirtualSettings *_this, float value);

/// Character mass (kg). Used to push down objects with gravity when the character is standing on top.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mMass(JPH_CharacterVirtualSettings *_this);

/// Maximum force with which the character can push other bodies (N).
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mMaxStrength(const JPH_CharacterVirtualSettings *_this);

/// Maximum force with which the character can push other bodies (N).
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMaxStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxStrength`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMaxStrength(JPH_CharacterVirtualSettings *_this, float value);

/// Maximum force with which the character can push other bodies (N).
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxStrength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mMaxStrength(JPH_CharacterVirtualSettings *_this);

/// An extra offset applied to the shape in local space. This allows applying an extra offset to the shape in local space.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mShapeOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtualSettings_Get_mShapeOffset(const JPH_CharacterVirtualSettings *_this);

/// An extra offset applied to the shape in local space. This allows applying an extra offset to the shape in local space.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mShapeOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtualSettings_GetMutable_mShapeOffset(JPH_CharacterVirtualSettings *_this);

///< When colliding with back faces, the character will not be able to move through back facing triangles. Use this if you have triangles that need to collide on both sides.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_CharacterVirtualSettings_Get_mBackFaceMode(const JPH_CharacterVirtualSettings *_this);

///< When colliding with back faces, the character will not be able to move through back facing triangles. Use this if you have triangles that need to collide on both sides.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceMode`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceMode`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mBackFaceMode(JPH_CharacterVirtualSettings *_this, JPH_EBackFaceMode value);

///< When colliding with back faces, the character will not be able to move through back facing triangles. Use this if you have triangles that need to collide on both sides.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_CharacterVirtualSettings_GetMutable_mBackFaceMode(JPH_CharacterVirtualSettings *_this);

///< How far to scan outside of the shape for predictive contacts. A value of 0 will most likely cause the character to get stuck as it cannot properly calculate a sliding direction anymore. A value that's too high will cause ghost collisions.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mPredictiveContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance(const JPH_CharacterVirtualSettings *_this);

///< How far to scan outside of the shape for predictive contacts. A value of 0 will most likely cause the character to get stuck as it cannot properly calculate a sliding direction anymore. A value that's too high will cause ghost collisions.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mPredictiveContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPredictiveContactDistance`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mPredictiveContactDistance(JPH_CharacterVirtualSettings *_this, float value);

///< How far to scan outside of the shape for predictive contacts. A value of 0 will most likely cause the character to get stuck as it cannot properly calculate a sliding direction anymore. A value that's too high will cause ghost collisions.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mPredictiveContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance(JPH_CharacterVirtualSettings *_this);

///< Max amount of collision loops
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxCollisionIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations(const JPH_CharacterVirtualSettings *_this);

///< Max amount of collision loops
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMaxCollisionIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaxCollisionIterations`.
/// When this function is called, this object will drop object references it held previously in `mMaxCollisionIterations`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMaxCollisionIterations(JPH_CharacterVirtualSettings *_this, unsigned int value);

///< Max amount of collision loops
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxCollisionIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations(JPH_CharacterVirtualSettings *_this);

///< How often to try stepping in the constraint solving
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxConstraintIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations(const JPH_CharacterVirtualSettings *_this);

///< How often to try stepping in the constraint solving
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMaxConstraintIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaxConstraintIterations`.
/// When this function is called, this object will drop object references it held previously in `mMaxConstraintIterations`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMaxConstraintIterations(JPH_CharacterVirtualSettings *_this, unsigned int value);

///< How often to try stepping in the constraint solving
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxConstraintIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations(JPH_CharacterVirtualSettings *_this);

///< Early out condition: If this much time is left to simulate we are done
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMinTimeRemaining`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mMinTimeRemaining(const JPH_CharacterVirtualSettings *_this);

///< Early out condition: If this much time is left to simulate we are done
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMinTimeRemaining`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinTimeRemaining`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMinTimeRemaining(JPH_CharacterVirtualSettings *_this, float value);

///< Early out condition: If this much time is left to simulate we are done
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMinTimeRemaining`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining(JPH_CharacterVirtualSettings *_this);

///< How far we're willing to penetrate geometry
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mCollisionTolerance(const JPH_CharacterVirtualSettings *_this);

///< How far we're willing to penetrate geometry
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollisionTolerance`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mCollisionTolerance(JPH_CharacterVirtualSettings *_this, float value);

///< How far we're willing to penetrate geometry
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance(JPH_CharacterVirtualSettings *_this);

///< How far we try to stay away from the geometry, this ensures that the sweep will hit as little as possible lowering the collision cost and reducing the risk of getting stuck
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mCharacterPadding`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mCharacterPadding(const JPH_CharacterVirtualSettings *_this);

///< How far we try to stay away from the geometry, this ensures that the sweep will hit as little as possible lowering the collision cost and reducing the risk of getting stuck
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mCharacterPadding`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCharacterPadding`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mCharacterPadding(JPH_CharacterVirtualSettings *_this, float value);

///< How far we try to stay away from the geometry, this ensures that the sweep will hit as little as possible lowering the collision cost and reducing the risk of getting stuck
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mCharacterPadding`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding(JPH_CharacterVirtualSettings *_this);

///< Max num hits to collect in order to avoid excess of contact points collection
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxNumHits`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxNumHits(const JPH_CharacterVirtualSettings *_this);

///< Max num hits to collect in order to avoid excess of contact points collection
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMaxNumHits`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaxNumHits`.
/// When this function is called, this object will drop object references it held previously in `mMaxNumHits`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMaxNumHits(JPH_CharacterVirtualSettings *_this, unsigned int value);

///< Max num hits to collect in order to avoid excess of contact points collection
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxNumHits`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits(JPH_CharacterVirtualSettings *_this);

///< Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mHitReductionCosMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle(const JPH_CharacterVirtualSettings *_this);

///< Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mHitReductionCosMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHitReductionCosMaxAngle`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mHitReductionCosMaxAngle(JPH_CharacterVirtualSettings *_this, float value);

///< Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mHitReductionCosMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle(JPH_CharacterVirtualSettings *_this);

///< This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mPenetrationRecoverySpeed`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed(const JPH_CharacterVirtualSettings *_this);

///< This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mPenetrationRecoverySpeed`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationRecoverySpeed`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mPenetrationRecoverySpeed(JPH_CharacterVirtualSettings *_this, float value);

///< This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mPenetrationRecoverySpeed`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed(JPH_CharacterVirtualSettings *_this);

/// For a deterministic simulation, it is important to have a deterministic body ID. When set and when mInnerBodyShape is specified,
/// the inner body will be created with this specified ID instead of a generated ID.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyIDOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride(const JPH_CharacterVirtualSettings *_this);

/// For a deterministic simulation, it is important to have a deterministic body ID. When set and when mInnerBodyShape is specified,
/// the inner body will be created with this specified ID instead of a generated ID.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyIDOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mInnerBodyIDOverride`.
/// When this function is called, this object will drop object references it held previously in `mInnerBodyIDOverride`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mInnerBodyIDOverride(JPH_CharacterVirtualSettings *_this, JPH_BodyID value);

/// For a deterministic simulation, it is important to have a deterministic body ID. When set and when mInnerBodyShape is specified,
/// the inner body will be created with this specified ID instead of a generated ID.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyIDOverride`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride(JPH_CharacterVirtualSettings *_this);

/// Layer that the inner rigid body will be added to
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned short *JPH_CharacterVirtualSettings_Get_mInnerBodyLayer(const JPH_CharacterVirtualSettings *_this);

/// Layer that the inner rigid body will be added to
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mInnerBodyLayer`.
/// When this function is called, this object will drop object references it held previously in `mInnerBodyLayer`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mInnerBodyLayer(JPH_CharacterVirtualSettings *_this, unsigned short value);

/// Layer that the inner rigid body will be added to
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mInnerBodyLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned short *JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer(JPH_CharacterVirtualSettings *_this);

/// Vector indicating the up direction of the character
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtualSettings_Get_mUp(const JPH_CharacterVirtualSettings *_this);

/// Vector indicating the up direction of the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtualSettings_GetMutable_mUp(JPH_CharacterVirtualSettings *_this);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Plane *JPH_CharacterVirtualSettings_Get_mSupportingVolume(const JPH_CharacterVirtualSettings *_this);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSupportingVolume`.
/// When this function is called, this object will drop object references it held previously in `mSupportingVolume`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mSupportingVolume(JPH_CharacterVirtualSettings *_this, const JPH_Plane *value);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Plane *JPH_CharacterVirtualSettings_GetMutable_mSupportingVolume(JPH_CharacterVirtualSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle(const JPH_CharacterVirtualSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxSlopeAngle`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mMaxSlopeAngle(JPH_CharacterVirtualSettings *_this, float value);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterVirtualSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterVirtualSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Modifies a member variable of class `JPH::CharacterVirtualSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnhancedInternalEdgeRemoval`.
JOLT_API void JPH_CharacterVirtualSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterVirtualSettings *_this, bool value);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtualSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterVirtualSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtualSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterVirtualSettings_DestroyArray()`.
/// Use `JPH_CharacterVirtualSettings_OffsetMutablePtr()` and `JPH_CharacterVirtualSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_OffsetPtr(const JPH_CharacterVirtualSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_OffsetMutablePtr(JPH_CharacterVirtualSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterVirtualSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterVirtualSettings *object);

/// Upcasts an instance of `JPH::CharacterVirtualSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterVirtualSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterVirtualSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterVirtualSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Upcasts an instance of `JPH::CharacterVirtualSettings` to its base class `JPH::CharacterBaseSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(const JPH_CharacterVirtualSettings *object);

/// Upcasts an instance of `JPH::CharacterVirtualSettings` to its base class `JPH::CharacterBaseSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_MutableUpcastTo_JPH_CharacterBaseSettings(JPH_CharacterVirtualSettings *object);

/// Downcasts an instance of `JPH::CharacterBaseSettings` to a derived class `JPH::CharacterVirtualSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::CharacterBaseSettings` to a derived class `JPH::CharacterVirtualSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_MutableStaticDowncastFrom_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object);

/// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtualSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterVirtualSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterVirtualSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtualSettings_Destroy(const JPH_CharacterVirtualSettings *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVirtualSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtualSettings_DestroyArray(const JPH_CharacterVirtualSettings *_this);

/// Generated from method `JPH::CharacterVirtualSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_AssignFromAnother(JPH_CharacterVirtualSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterVirtualSettings *_other);

/// Generated from method `JPH::CharacterVirtualSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterVirtualSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterVirtualSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterVirtualSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterVirtualSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterVirtualSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterVirtualSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterVirtualSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CharacterVirtualSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtualSettings_SetEmbedded(const JPH_CharacterVirtualSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CharacterVirtualSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterVirtualSettings_GetRefCount(const JPH_CharacterVirtualSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CharacterVirtualSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtualSettings_AddRef(const JPH_CharacterVirtualSettings *_this);

/// Generated from method `JPH::CharacterVirtualSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtualSettings_Release(const JPH_CharacterVirtualSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CharacterVirtualSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_CharacterVirtualSettings_sInternalGetRefCountOffset(void);

/// True when the object can push the virtual character.
/// Returns a pointer to a member variable of class `JPH::CharacterContactSettings` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterContactSettings_Get_mCanPushCharacter(const JPH_CharacterContactSettings *_this);

/// True when the object can push the virtual character.
/// Modifies a member variable of class `JPH::CharacterContactSettings` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCanPushCharacter`.
JOLT_API void JPH_CharacterContactSettings_Set_mCanPushCharacter(JPH_CharacterContactSettings *_this, bool value);

/// True when the object can push the virtual character.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterContactSettings` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterContactSettings_GetMutable_mCanPushCharacter(JPH_CharacterContactSettings *_this);

/// True when the virtual character can apply impulses (push) the body.
/// Note that this only works against rigid bodies. Other CharacterVirtual objects can only be moved in their own update,
/// so you must ensure that in their OnCharacterContactAdded mCanPushCharacter is true.
/// Returns a pointer to a member variable of class `JPH::CharacterContactSettings` named `mCanReceiveImpulses`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterContactSettings_Get_mCanReceiveImpulses(const JPH_CharacterContactSettings *_this);

/// True when the virtual character can apply impulses (push) the body.
/// Note that this only works against rigid bodies. Other CharacterVirtual objects can only be moved in their own update,
/// so you must ensure that in their OnCharacterContactAdded mCanPushCharacter is true.
/// Modifies a member variable of class `JPH::CharacterContactSettings` named `mCanReceiveImpulses`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCanReceiveImpulses`.
JOLT_API void JPH_CharacterContactSettings_Set_mCanReceiveImpulses(JPH_CharacterContactSettings *_this, bool value);

/// True when the virtual character can apply impulses (push) the body.
/// Note that this only works against rigid bodies. Other CharacterVirtual objects can only be moved in their own update,
/// so you must ensure that in their OnCharacterContactAdded mCanPushCharacter is true.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterContactSettings` named `mCanReceiveImpulses`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses(JPH_CharacterContactSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterContactSettings_DestroyArray()`.
/// Use `JPH_CharacterContactSettings_OffsetMutablePtr()` and `JPH_CharacterContactSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::CharacterContactSettings` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterContactSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_ConstructFrom(bool mCanPushCharacter, bool mCanReceiveImpulses);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterContactSettings *JPH_CharacterContactSettings_OffsetPtr(const JPH_CharacterContactSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_OffsetMutablePtr(JPH_CharacterContactSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CharacterContactSettings::CharacterContactSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_ConstructFromAnother(const JPH_CharacterContactSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterContactSettings_Destroy(const JPH_CharacterContactSettings *_this);

/// Destroys a heap-allocated array of `JPH_CharacterContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterContactSettings_DestroyArray(const JPH_CharacterContactSettings *_this);

/// Generated from method `JPH::CharacterContactSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterContactSettings *JPH_CharacterContactSettings_AssignFromAnother(JPH_CharacterContactSettings *_this, const JPH_CharacterContactSettings *_other);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterContactListener *JPH_CharacterContactListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterContactListener_DestroyArray()`.
/// Use `JPH_CharacterContactListener_OffsetMutablePtr()` and `JPH_CharacterContactListener_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterContactListener *JPH_CharacterContactListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterContactListener *JPH_CharacterContactListener_OffsetPtr(const JPH_CharacterContactListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterContactListener *JPH_CharacterContactListener_OffsetMutablePtr(JPH_CharacterContactListener *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterContactListener *JPH_CharacterContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterContactListener *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterContactListener_Destroy(const JPH_CharacterContactListener *_this);

/// Destroys a heap-allocated array of `JPH_CharacterContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterContactListener_DestroyArray(const JPH_CharacterContactListener *_this);

/// Generated from method `JPH::CharacterContactListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterContactListener *JPH_CharacterContactListener_AssignFromAnother(JPH_CharacterContactListener *_this, Jolt_PassBy _other_pass_by, JPH_CharacterContactListener *_other);

/// Callback to adjust the velocity of a body as seen by the character. Can be adjusted to e.g. implement a conveyor belt or an inertial dampener system of a sci-fi space ship.
/// Note that inBody2 is locked during the callback so you can read its properties freely.
/// Generated from method `JPH::CharacterContactListener::OnAdjustBodyVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `ioLinearVelocity` can not be null. It is a single object.
/// Parameter `ioAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnAdjustBodyVelocity(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_Body *inBody2, JPH_Vec3 *ioLinearVelocity, JPH_Vec3 *ioAngularVelocity);

/// Checks if a character can collide with specified body. Return true if the contact is valid.
/// Generated from method `JPH::CharacterContactListener::OnContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
JOLT_API bool JPH_CharacterContactListener_OnContactValidate(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2);

/// Same as OnContactValidate but when colliding with a CharacterVirtual
/// Generated from method `JPH::CharacterContactListener::OnCharacterContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
JOLT_API bool JPH_CharacterContactListener_OnCharacterContactValidate(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2);

/// Called whenever the character collides with a body for the first time.
/// @param inCharacter Character that is being solved
/// @param inBodyID2 Body ID of body that is being hit
/// @param inSubShapeID2 Sub shape ID of shape that is being hit
/// @param inContactPosition World space contact position
/// @param inContactNormal World space contact normal
/// @param ioSettings Settings returned by the contact callback to indicate how the character should behave
/// Generated from method `JPH::CharacterContactListener::OnContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnContactAdded(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings);

/// Called whenever the character persists colliding with a body.
/// @param inCharacter Character that is being solved
/// @param inBodyID2 Body ID of body that is being hit
/// @param inSubShapeID2 Sub shape ID of shape that is being hit
/// @param inContactPosition World space contact position
/// @param inContactNormal World space contact normal
/// @param ioSettings Settings returned by the contact callback to indicate how the character should behave
/// Generated from method `JPH::CharacterContactListener::OnContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnContactPersisted(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings);

/// Called whenever the character loses contact with a body.
/// Note that there is no guarantee that the body or its sub shape still exists at this point. The body may have been deleted since the last update.
/// @param inCharacter Character that is being solved
/// @param inBodyID2 Body ID of body that is being hit
/// @param inSubShapeID2 Sub shape ID of shape that is being hit
/// Generated from method `JPH::CharacterContactListener::OnContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnContactRemoved(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2);

/// Same as OnContactAdded but when colliding with a CharacterVirtual
/// Generated from method `JPH::CharacterContactListener::OnCharacterContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnCharacterContactAdded(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings);

/// Same as OnContactPersisted but when colliding with a CharacterVirtual
/// Generated from method `JPH::CharacterContactListener::OnCharacterContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnCharacterContactPersisted(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings);

/// Same as OnContactRemoved but when colliding with a CharacterVirtual
/// Note that inOtherCharacterID can be the ID of a character that has been deleted. This happens if the character was in contact with this character during the last update, but has been deleted since.
/// Generated from method `JPH::CharacterContactListener::OnCharacterContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOtherCharacterID` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnCharacterContactRemoved(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterID *inOtherCharacterID, const JPH_SubShapeID *inSubShapeID2);

/// Called whenever a contact is being used by the solver. Allows the listener to override the resulting character velocity (e.g. by preventing sliding along certain surfaces).
/// @param inCharacter Character that is being solved
/// @param inBodyID2 Body ID of body that is being hit
/// @param inSubShapeID2 Sub shape ID of shape that is being hit
/// @param inContactPosition World space contact position
/// @param inContactNormal World space contact normal
/// @param inContactVelocity World space velocity of contact point (e.g. for a moving platform)
/// @param inContactMaterial Material of contact point
/// @param inCharacterVelocity World space velocity of the character prior to hitting this contact
/// @param ioNewCharacterVelocity Contains the calculated world space velocity of the character after hitting this contact, this velocity slides along the surface of the contact. Can be modified by the listener to provide an alternative velocity.
/// Generated from method `JPH::CharacterContactListener::OnContactSolve`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `inContactVelocity` can not be null. It is a single object.
/// Parameter `inCharacterVelocity` can not be null. It is a single object.
/// Parameter `ioNewCharacterVelocity` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnContactSolve(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, const JPH_Vec3 *inContactVelocity, const JPH_PhysicsMaterial *inContactMaterial, const JPH_Vec3 *inCharacterVelocity, JPH_Vec3 *ioNewCharacterVelocity);

/// Same as OnContactSolve but when colliding with a CharacterVirtual
/// Generated from method `JPH::CharacterContactListener::OnCharacterContactSolve`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inContactPosition` can not be null. It is a single object.
/// Parameter `inContactNormal` can not be null. It is a single object.
/// Parameter `inContactVelocity` can not be null. It is a single object.
/// Parameter `inCharacterVelocity` can not be null. It is a single object.
/// Parameter `ioNewCharacterVelocity` can not be null. It is a single object.
JOLT_API void JPH_CharacterContactListener_OnCharacterContactSolve(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, const JPH_Vec3 *inContactVelocity, const JPH_PhysicsMaterial *inContactMaterial, const JPH_Vec3 *inCharacterVelocity, JPH_Vec3 *ioNewCharacterVelocity);

/// Destroys a heap-allocated instance of `JPH_CharacterVsCharacterCollision`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVsCharacterCollision_Destroy(const JPH_CharacterVsCharacterCollision *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVsCharacterCollision`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVsCharacterCollision_DestroyArray(const JPH_CharacterVsCharacterCollision *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_OffsetPtr(const JPH_CharacterVsCharacterCollision *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_OffsetMutablePtr(JPH_CharacterVsCharacterCollision *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollision` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(const JPH_CharacterVsCharacterCollision *object);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollision` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CharacterVsCharacterCollision_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVsCharacterCollision *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVsCharacterCollision`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVsCharacterCollision`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVsCharacterCollisionSimple_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterVsCharacterCollisionSimple_DestroyArray()`.
/// Use `JPH_CharacterVsCharacterCollisionSimple_OffsetMutablePtr()` and `JPH_CharacterVsCharacterCollisionSimple_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_OffsetPtr(const JPH_CharacterVsCharacterCollisionSimple *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_OffsetMutablePtr(JPH_CharacterVsCharacterCollisionSimple *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollisionSimple` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(const JPH_CharacterVsCharacterCollisionSimple *object);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollisionSimple` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CharacterVsCharacterCollisionSimple_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVsCharacterCollisionSimple *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVsCharacterCollisionSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVsCharacterCollisionSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollisionSimple` to its base class `JPH::CharacterVsCharacterCollision`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(const JPH_CharacterVsCharacterCollisionSimple *object);

/// Upcasts an instance of `JPH::CharacterVsCharacterCollisionSimple` to its base class `JPH::CharacterVsCharacterCollision`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollisionSimple_MutableUpcastTo_JPH_CharacterVsCharacterCollision(JPH_CharacterVsCharacterCollisionSimple *object);

/// Downcasts an instance of `JPH::CharacterVsCharacterCollision` to a derived class `JPH::CharacterVsCharacterCollisionSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_StaticDowncastFrom_JPH_CharacterVsCharacterCollision(const JPH_CharacterVsCharacterCollision *object);

/// Downcasts an instance of `JPH::CharacterVsCharacterCollision` to a derived class `JPH::CharacterVsCharacterCollisionSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_MutableStaticDowncastFrom_JPH_CharacterVsCharacterCollision(JPH_CharacterVsCharacterCollision *object);

/// Destroys a heap-allocated instance of `JPH_CharacterVsCharacterCollisionSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVsCharacterCollisionSimple_Destroy(const JPH_CharacterVsCharacterCollisionSimple *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVsCharacterCollisionSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVsCharacterCollisionSimple_DestroyArray(const JPH_CharacterVsCharacterCollisionSimple *_this);

/// Add a character to the list of characters to check collision against.
/// Generated from method `JPH::CharacterVsCharacterCollisionSimple::Add`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVsCharacterCollisionSimple_Add(JPH_CharacterVsCharacterCollisionSimple *_this, JPH_CharacterVirtual *inCharacter);

/// Remove a character from the list of characters to check collision against.
/// Generated from method `JPH::CharacterVsCharacterCollisionSimple::Remove`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVsCharacterCollisionSimple_Remove(JPH_CharacterVsCharacterCollisionSimple *_this, const JPH_CharacterVirtual *inCharacter);

/// Constructor
/// @param inSettings The settings for the character
/// @param inPosition Initial position for the character
/// @param inRotation Initial rotation for the character (usually only around the up-axis)
/// @param inUserData Application specific value
/// @param inSystem Physics system that this character will be added to
/// Generated from constructor `JPH::CharacterVirtual::CharacterVirtual`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_Construct_5(const JPH_CharacterVirtualSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, uint64_t inUserData, JPH_PhysicsSystem *inSystem);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual *JPH_CharacterVirtual_OffsetPtr(const JPH_CharacterVirtual *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_OffsetMutablePtr(JPH_CharacterVirtual *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBase *JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_CharacterVirtual *object);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_CharacterVirtual_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_CharacterVirtual *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(const JPH_CharacterVirtual *object);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CharacterVirtual_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVirtual *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::CharacterBase`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBase *JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(const JPH_CharacterVirtual *object);

/// Upcasts an instance of `JPH::CharacterVirtual` to its base class `JPH::CharacterBase`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBase *JPH_CharacterVirtual_MutableUpcastTo_JPH_CharacterBase(JPH_CharacterVirtual *object);

/// Downcasts an instance of `JPH::CharacterBase` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_CharacterBase(const JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::CharacterBase` to a derived class `JPH::CharacterVirtual`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_CharacterBase(JPH_CharacterBase *object);

/// Constructor without user data
/// Generated from constructor `JPH::CharacterVirtual::CharacterVirtual`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual *JPH_CharacterVirtual_Construct_4(const JPH_CharacterVirtualSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_PhysicsSystem *inSystem);

/// Destroys a heap-allocated instance of `JPH_CharacterVirtual`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_Destroy(const JPH_CharacterVirtual *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVirtual`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_DestroyArray(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterVirtual_size_t(size_t inCount);

/// Generated from method `JPH::CharacterVirtual::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtual_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterVirtual::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtual_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterVirtual::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterVirtual_size_t(size_t inCount);

/// Generated from method `JPH::CharacterVirtual::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtual_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterVirtual::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtual_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterVirtual::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterVirtual_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterVirtual::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterVirtual::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterVirtual_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterVirtual::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// The ID of this character
/// Generated from method `JPH::CharacterVirtual::GetID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CharacterID *JPH_CharacterVirtual_GetID(const JPH_CharacterVirtual *_this);

/// Set the contact listener
/// Generated from method `JPH::CharacterVirtual::SetListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetListener(JPH_CharacterVirtual *_this, JPH_CharacterContactListener *inListener);

/// Get the current contact listener
/// Generated from method `JPH::CharacterVirtual::GetListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_CharacterContactListener *JPH_CharacterVirtual_GetListener(const JPH_CharacterVirtual *_this);

/// Set the character vs character collision interface
/// Generated from method `JPH::CharacterVirtual::SetCharacterVsCharacterCollision`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetCharacterVsCharacterCollision(JPH_CharacterVirtual *_this, JPH_CharacterVsCharacterCollision *inCharacterVsCharacterCollision);

/// Get the linear velocity of the character (m / s)
/// Generated from method `JPH::CharacterVirtual::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetLinearVelocity(const JPH_CharacterVirtual *_this);

/// Set the linear velocity of the character (m / s)
/// Generated from method `JPH::CharacterVirtual::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetLinearVelocity(JPH_CharacterVirtual *_this, const JPH_Vec3 *inLinearVelocity);

/// Get the position of the character
/// Generated from method `JPH::CharacterVirtual::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetPosition(const JPH_CharacterVirtual *_this);

/// Set the position of the character
/// Generated from method `JPH::CharacterVirtual::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetPosition(JPH_CharacterVirtual *_this, const JPH_Vec3 *inPosition);

/// Get the rotation of the character
/// Generated from method `JPH::CharacterVirtual::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_CharacterVirtual_GetRotation(const JPH_CharacterVirtual *_this);

/// Set the rotation of the character
/// Generated from method `JPH::CharacterVirtual::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetRotation(JPH_CharacterVirtual *_this, const JPH_Quat *inRotation);

// Get the center of mass position of the shape
/// Generated from method `JPH::CharacterVirtual::GetCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetCenterOfMassPosition(const JPH_CharacterVirtual *_this);

/// Calculate the world transform of the character
/// Generated from method `JPH::CharacterVirtual::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_CharacterVirtual_GetWorldTransform(const JPH_CharacterVirtual *_this);

/// Calculates the transform for this character's center of mass
/// Generated from method `JPH::CharacterVirtual::GetCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_CharacterVirtual_GetCenterOfMassTransform(const JPH_CharacterVirtual *_this);

/// Character mass (kg)
/// Generated from method `JPH::CharacterVirtual::GetMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetMass(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetMass`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetMass(JPH_CharacterVirtual *_this, float inMass);

/// Maximum force with which the character can push other bodies (N)
/// Generated from method `JPH::CharacterVirtual::GetMaxStrength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetMaxStrength(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetMaxStrength`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetMaxStrength(JPH_CharacterVirtual *_this, float inMaxStrength);

/// This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
/// Generated from method `JPH::CharacterVirtual::GetPenetrationRecoverySpeed`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetPenetrationRecoverySpeed(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetPenetrationRecoverySpeed`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetPenetrationRecoverySpeed(JPH_CharacterVirtual *_this, float inSpeed);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Generated from method `JPH::CharacterVirtual::GetEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(JPH_CharacterVirtual *_this, bool inApply);

/// Character padding
/// Generated from method `JPH::CharacterVirtual::GetCharacterPadding`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetCharacterPadding(const JPH_CharacterVirtual *_this);

/// Max num hits to collect in order to avoid excess of contact points collection
/// Generated from method `JPH::CharacterVirtual::GetMaxNumHits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterVirtual_GetMaxNumHits(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetMaxNumHits`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetMaxNumHits(JPH_CharacterVirtual *_this, unsigned int inMaxHits);

/// Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
/// Generated from method `JPH::CharacterVirtual::GetHitReductionCosMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetHitReductionCosMaxAngle(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetHitReductionCosMaxAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetHitReductionCosMaxAngle(JPH_CharacterVirtual *_this, float inCosMaxAngle);

/// Returns if we exceeded the maximum number of hits during the last collision check and had to discard hits based on distance.
/// This can be used to find areas that have too complex geometry for the character to navigate properly.
/// To solve you can either increase the max number of hits or simplify the geometry. Note that the character simulation will
/// try to do its best to select the most relevant contacts to avoid the character from getting stuck.
/// Generated from method `JPH::CharacterVirtual::GetMaxHitsExceeded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_GetMaxHitsExceeded(const JPH_CharacterVirtual *_this);

/// An extra offset applied to the shape in local space. This allows applying an extra offset to the shape in local space. Note that setting it on the fly can cause the shape to teleport into collision.
/// Generated from method `JPH::CharacterVirtual::GetShapeOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetShapeOffset(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetShapeOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inShapeOffset` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetShapeOffset(JPH_CharacterVirtual *_this, const JPH_Vec3 *inShapeOffset);

/// Access to the user data, can be used for anything by the application
/// Generated from method `JPH::CharacterVirtual::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterVirtual_GetUserData(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetUserData(JPH_CharacterVirtual *_this, uint64_t inUserData);

/// Optional inner rigid body that proxies the character in the world. Can be used to update body properties.
/// Generated from method `JPH::CharacterVirtual::GetInnerBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_CharacterVirtual_GetInnerBodyID(const JPH_CharacterVirtual *_this);

/// This function can be called prior to calling Update() to convert a desired velocity into a velocity that won't make the character move further onto steep slopes.
/// This velocity can then be set on the character using SetLinearVelocity()
/// @param inDesiredVelocity Velocity to clamp against steep walls
/// @return A new velocity vector that won't make the character move up steep slopes
/// Generated from method `JPH::CharacterVirtual::CancelVelocityTowardsSteepSlopes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inDesiredVelocity` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inDesiredVelocity);

/// This function is internally called by Update, WalkStairs, StickToFloor and ExtendedUpdate and is responsible for tracking if contacts are added, persisted or removed.
/// If you want to do multiple operations on a character (e.g. first Update then WalkStairs), you can surround the code with a StartTrackingContactChanges and FinishTrackingContactChanges pair
/// to only receive a single callback per contact on the CharacterContactListener. If you don't do this then you could for example receive a contact added callback during the Update and a
/// contact persisted callback during WalkStairs.
/// Generated from method `JPH::CharacterVirtual::StartTrackingContactChanges`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_StartTrackingContactChanges(JPH_CharacterVirtual *_this);

/// This call triggers contact removal callbacks and is used in conjunction with StartTrackingContactChanges.
/// Generated from method `JPH::CharacterVirtual::FinishTrackingContactChanges`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_FinishTrackingContactChanges(JPH_CharacterVirtual *_this);

/// This is the main update function. It moves the character according to its current velocity (the character is similar to a kinematic body in the sense
/// that you set the velocity and the character will follow unless collision is blocking the way). Note it's your own responsibility to apply gravity to the character velocity!
/// Different surface materials (like ice) can be emulated by getting the ground material and adjusting the velocity and/or the max slope angle accordingly every frame.
/// @param inDeltaTime Time step to simulate.
/// @param inGravity Gravity vector (m/s^2). This gravity vector is only used when the character is standing on top of another object to apply downward force.
/// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
/// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
/// @param inBodyFilter Filter that is used to check if a character collides with a body.
/// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
/// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
/// Generated from method `JPH::CharacterVirtual::Update`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_Update(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inGravity, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// This function will return true if the character has moved into a slope that is too steep (e.g. a vertical wall).
/// You would call WalkStairs to attempt to step up stairs.
/// @param inLinearVelocity The linear velocity that the player desired. This is used to determine if we're pushing into a step.
/// Generated from method `JPH::CharacterVirtual::CanWalkStairs`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_CanWalkStairs(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inLinearVelocity);

/// When stair walking is needed, you can call the WalkStairs function to cast up, forward and down again to try to find a valid position
/// @param inDeltaTime Time step to simulate.
/// @param inStepUp The direction and distance to step up (this corresponds to the max step height)
/// @param inStepForward The direction and distance to step forward after the step up
/// @param inStepForwardTest When running at a high frequency, inStepForward can be very small and it's likely that you hit the side of the stairs on the way down. This could produce a normal that violates the max slope angle. If this happens, we test again using this distance from the up position to see if we find a valid slope.
/// @param inStepDownExtra An additional translation that is added when stepping down at the end. Allows you to step further down than up. Set to zero if you don't want this. Should be in the opposite direction of up.
/// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
/// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
/// @param inBodyFilter Filter that is used to check if a character collides with a body.
/// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
/// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
/// @return true if the stair walk was successful
/// Generated from method `JPH::CharacterVirtual::WalkStairs`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inStepUp` can not be null. It is a single object.
/// Parameter `inStepForward` can not be null. It is a single object.
/// Parameter `inStepForwardTest` can not be null. It is a single object.
/// Parameter `inStepDownExtra` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_WalkStairs(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inStepUp, const JPH_Vec3 *inStepForward, const JPH_Vec3 *inStepForwardTest, const JPH_Vec3 *inStepDownExtra, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// This function can be used to artificially keep the character to the floor. Normally when a character is on a small step and starts moving horizontally, the character will
/// lose contact with the floor because the initial vertical velocity is zero while the horizontal velocity is quite high. To prevent the character from losing contact with the floor,
/// we do an additional collision check downwards and if we find the floor within a certain distance, we project the character onto the floor.
/// @param inStepDown Max amount to project the character downwards (if no floor is found within this distance, the function will return false)
/// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
/// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
/// @param inBodyFilter Filter that is used to check if a character collides with a body.
/// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
/// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
/// @return True if the character was successfully projected onto the floor.
/// Generated from method `JPH::CharacterVirtual::StickToFloor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inStepDown` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_StickToFloor(JPH_CharacterVirtual *_this, const JPH_Vec3 *inStepDown, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// This function combines Update, StickToFloor and WalkStairs. This function serves as an example of how these functions could be combined.
/// Before calling, call SetLinearVelocity to update the horizontal/vertical speed of the character, typically this is:
/// - When on OnGround and not moving away from ground: velocity = GetGroundVelocity() + horizontal speed as input by player + optional vertical jump velocity + delta time * gravity
/// - Else: velocity = current vertical velocity + horizontal speed as input by player + delta time * gravity
/// @param inDeltaTime Time step to simulate.
/// @param inGravity Gravity vector (m/s^2). This gravity vector is only used when the character is standing on top of another object to apply downward force.
/// @param inSettings A structure containing settings for the algorithm.
/// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
/// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
/// @param inBodyFilter Filter that is used to check if a character collides with a body.
/// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
/// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
/// Generated from method `JPH::CharacterVirtual::ExtendedUpdate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdate(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inGravity, const JPH_CharacterVirtual_ExtendedUpdateSettings *inSettings, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// This function can be used after a character has teleported to determine the new contacts with the world.
/// Generated from method `JPH::CharacterVirtual::RefreshContacts`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_RefreshContacts(JPH_CharacterVirtual *_this, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// Use the ground body ID to get an updated estimate of the ground velocity. This function can be used if the ground body has moved / changed velocity and you want a new estimate of the ground velocity.
/// It will not perform collision detection, so is less accurate than RefreshContacts but a lot faster.
/// Generated from method `JPH::CharacterVirtual::UpdateGroundVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_UpdateGroundVelocity(JPH_CharacterVirtual *_this);

/// Switch the shape of the character (e.g. for stance).
/// @param inShape The shape to switch to.
/// @param inMaxPenetrationDepth When inMaxPenetrationDepth is not FLT_MAX, it checks if the new shape collides before switching shape. This is the max penetration we're willing to accept after the switch.
/// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
/// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
/// @param inBodyFilter Filter that is used to check if a character collides with a body.
/// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
/// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
/// @return Returns true if the switch succeeded.
/// Generated from method `JPH::CharacterVirtual::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
/// Parameter `inBodyFilter` can not be null. It is a single object.
/// Parameter `inShapeFilter` can not be null. It is a single object.
/// Parameter `inAllocator` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_SetShape(JPH_CharacterVirtual *_this, const JPH_Shape *inShape, float inMaxPenetrationDepth, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator);

/// Updates the shape of the inner rigid body. Should be called after a successful call to SetShape.
/// Generated from method `JPH::CharacterVirtual::SetInnerBodyShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetInnerBodyShape(JPH_CharacterVirtual *_this, const JPH_Shape *inShape);

/// Get the transformed shape that represents the volume of the character, can be used for collision checks.
/// Generated from method `JPH::CharacterVirtual::GetTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_CharacterVirtual_GetTransformedShape(const JPH_CharacterVirtual *_this);

/// Get the character settings that can recreate this character
/// Generated from method `JPH::CharacterVirtual::GetCharacterVirtualSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtualSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtualSettings *JPH_CharacterVirtual_GetCharacterVirtualSettings(const JPH_CharacterVirtual *_this);

/// Check if the character is currently in contact with or has collided with another body in the last operation (e.g. Update or WalkStairs)
/// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID(const JPH_CharacterVirtual *_this, const JPH_BodyID *inBody);

/// Check if the character is currently in contact with or has collided with another character in the last time step (e.g. Update or WalkStairs)
/// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCharacterID` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID(const JPH_CharacterVirtual *_this, const JPH_CharacterID *inCharacterID);

/// Check if the character is currently in contact with or has collided with another character in the last time step (e.g. Update or WalkStairs)
/// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr(const JPH_CharacterVirtual *_this, const JPH_CharacterVirtual *inCharacter);

/// Set the maximum angle of slope that character can still walk on (radians)
/// Generated from method `JPH::CharacterVirtual::SetMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetMaxSlopeAngle(JPH_CharacterVirtual *_this, float inMaxSlopeAngle);

/// Generated from method `JPH::CharacterVirtual::GetCosMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterVirtual_GetCosMaxSlopeAngle(const JPH_CharacterVirtual *_this);

/// Set the up vector for the character
/// Generated from method `JPH::CharacterVirtual::SetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inUp` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetUp(JPH_CharacterVirtual *_this, const JPH_Vec3 *inUp);

/// Generated from method `JPH::CharacterVirtual::GetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetUp(const JPH_CharacterVirtual *_this);

/// Check if the normal of the ground surface is too steep to walk on
/// Generated from method `JPH::CharacterVirtual::IsSlopeTooSteep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_IsSlopeTooSteep(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inNormal);

/// Get the current shape that the character is using.
/// Generated from method `JPH::CharacterVirtual::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_CharacterVirtual_GetShape(const JPH_CharacterVirtual *_this);

/// Debug function to convert enum values to string
/// Generated from method `JPH::CharacterVirtual::sToString`.
JOLT_API const char *JPH_CharacterVirtual_sToString(JPH_CharacterBase_EGroundState inState);

/// Current ground state
/// Generated from method `JPH::CharacterVirtual::GetGroundState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_CharacterBase_EGroundState JPH_CharacterVirtual_GetGroundState(const JPH_CharacterVirtual *_this);

/// Returns true if the player is supported by normal or steep ground
/// Generated from method `JPH::CharacterVirtual::IsSupported`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_IsSupported(const JPH_CharacterVirtual *_this);

/// Get the contact point with the ground
/// Generated from method `JPH::CharacterVirtual::GetGroundPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetGroundPosition(const JPH_CharacterVirtual *_this);

/// Get the contact normal with the ground
/// Generated from method `JPH::CharacterVirtual::GetGroundNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetGroundNormal(const JPH_CharacterVirtual *_this);

/// Velocity in world space of ground
/// Generated from method `JPH::CharacterVirtual::GetGroundVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_GetGroundVelocity(const JPH_CharacterVirtual *_this);

/// Material that the character is standing on
/// Generated from method `JPH::CharacterVirtual::GetGroundMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_CharacterVirtual_GetGroundMaterial(const JPH_CharacterVirtual *_this);

/// BodyID of the object the character is standing on. Note may have been removed!
/// Generated from method `JPH::CharacterVirtual::GetGroundBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_CharacterVirtual_GetGroundBodyID(const JPH_CharacterVirtual *_this);

/// Sub part of the body that we're standing on.
/// Generated from method `JPH::CharacterVirtual::GetGroundSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_CharacterVirtual_GetGroundSubShapeID(const JPH_CharacterVirtual *_this);

/// User data value of the body that we're standing on
/// Generated from method `JPH::CharacterVirtual::GetGroundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterVirtual_GetGroundUserData(const JPH_CharacterVirtual *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CharacterVirtual::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_SetEmbedded(const JPH_CharacterVirtual *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CharacterVirtual::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterVirtual_GetRefCount(const JPH_CharacterVirtual *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CharacterVirtual::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_AddRef(const JPH_CharacterVirtual *_this);

/// Generated from method `JPH::CharacterVirtual::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterVirtual_Release(const JPH_CharacterVirtual *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CharacterVirtual::sInternalGetRefCountOffset`.
JOLT_API int JPH_CharacterVirtual_sInternalGetRefCountOffset(void);

///< See StickToFloor inStepDown parameter. Can be zero to turn off.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mStickToFloorStepDown`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mStickToFloorStepDown(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See StickToFloor inStepDown parameter. Can be zero to turn off.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mStickToFloorStepDown`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mStickToFloorStepDown(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepUp parameter. Can be zero to turn off.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepUp(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepUp parameter. Can be zero to turn off.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepUp(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepForward parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsMinStepForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepForward parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Modifies a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsMinStepForward`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWalkStairsMinStepForward`.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsMinStepForward(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value);

///< See WalkStairs inStepForward parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsMinStepForward`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepForwardTest parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepForwardTest`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepForwardTest parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Modifies a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepForwardTest`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWalkStairsStepForwardTest`.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsStepForwardTest(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value);

///< See WalkStairs inStepForwardTest parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepForwardTest`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< Cos(angle) where angle is the maximum angle between the ground normal in the horizontal plane and the character forward vector where we're willing to adjust the step forward test towards the contact normal.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsCosAngleForwardContact`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< Cos(angle) where angle is the maximum angle between the ground normal in the horizontal plane and the character forward vector where we're willing to adjust the step forward test towards the contact normal.
/// Modifies a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsCosAngleForwardContact`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWalkStairsCosAngleForwardContact`.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsCosAngleForwardContact(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value);

///< Cos(angle) where angle is the maximum angle between the ground normal in the horizontal plane and the character forward vector where we're willing to adjust the step forward test towards the contact normal.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsCosAngleForwardContact`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepDownExtra
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepDownExtra`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepDownExtra(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

///< See WalkStairs inStepDownExtra
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ExtendedUpdateSettings` named `mWalkStairsStepDownExtra`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepDownExtra(JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterVirtual_ExtendedUpdateSettings_DestroyArray()`.
/// Use `JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetMutablePtr()` and `JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::CharacterVirtual::ExtendedUpdateSettings` elementwise.
/// Parameter `mStickToFloorStepDown` can not be null. It is a single object.
/// The reference to the parameter `mStickToFloorStepDown` might be preserved in the constructed object.
/// Parameter `mWalkStairsStepUp` can not be null. It is a single object.
/// The reference to the parameter `mWalkStairsStepUp` might be preserved in the constructed object.
/// Parameter `mWalkStairsStepDownExtra` can not be null. It is a single object.
/// The reference to the parameter `mWalkStairsStepDownExtra` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFrom(const JPH_Vec3 *mStickToFloorStepDown, const JPH_Vec3 *mWalkStairsStepUp, float mWalkStairsMinStepForward, float mWalkStairsStepForwardTest, float mWalkStairsCosAngleForwardContact, const JPH_Vec3 *mWalkStairsStepDownExtra);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetPtr(const JPH_CharacterVirtual_ExtendedUpdateSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetMutablePtr(JPH_CharacterVirtual_ExtendedUpdateSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CharacterVirtual::ExtendedUpdateSettings::ExtendedUpdateSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(const JPH_CharacterVirtual_ExtendedUpdateSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterVirtual_ExtendedUpdateSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVirtual_ExtendedUpdateSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_ExtendedUpdateSettings_DestroyArray(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this);

/// Generated from method `JPH::CharacterVirtual::ExtendedUpdateSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, const JPH_CharacterVirtual_ExtendedUpdateSettings *_other);

///< ID of body we're colliding with (if not invalid)
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_CharacterVirtual_ContactKey_Get_mBodyB(const JPH_CharacterVirtual_ContactKey *_this);

///< ID of body we're colliding with (if not invalid)
/// Modifies a member variable of class `JPH::CharacterVirtual::ContactKey` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyB`.
/// When this function is called, this object will drop object references it held previously in `mBodyB`.
JOLT_API void JPH_CharacterVirtual_ContactKey_Set_mBodyB(JPH_CharacterVirtual_ContactKey *_this, JPH_BodyID value);

///< ID of body we're colliding with (if not invalid)
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB(JPH_CharacterVirtual_ContactKey *_this);

///< Character we're colliding with (if not invalid)
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterID *JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB(const JPH_CharacterVirtual_ContactKey *_this);

///< Character we're colliding with (if not invalid)
/// Modifies a member variable of class `JPH::CharacterVirtual::ContactKey` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCharacterIDB`.
/// When this function is called, this object will drop object references it held previously in `mCharacterIDB`.
JOLT_API void JPH_CharacterVirtual_ContactKey_Set_mCharacterIDB(JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterID *value);

///< Character we're colliding with (if not invalid)
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterID *JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB(JPH_CharacterVirtual_ContactKey *_this);

///< Sub shape ID of body or character we're colliding with
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB(const JPH_CharacterVirtual_ContactKey *_this);

///< Sub shape ID of body or character we're colliding with
/// Modifies a member variable of class `JPH::CharacterVirtual::ContactKey` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeIDB`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeIDB`.
JOLT_API void JPH_CharacterVirtual_ContactKey_Set_mSubShapeIDB(JPH_CharacterVirtual_ContactKey *_this, const JPH_SubShapeID *value);

///< Sub shape ID of body or character we're colliding with
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::ContactKey` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB(JPH_CharacterVirtual_ContactKey *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ContactKey_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterVirtual_ContactKey_DestroyArray()`.
/// Use `JPH_CharacterVirtual_ContactKey_OffsetMutablePtr()` and `JPH_CharacterVirtual_ContactKey_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_OffsetPtr(const JPH_CharacterVirtual_ContactKey *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_OffsetMutablePtr(JPH_CharacterVirtual_ContactKey *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
/// Parameter `inContact` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inContact` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ContactKey_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_ConstructFromAnother(const JPH_CharacterVirtual_ContactKey *inContact);

/// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
/// Parameter `inBodyB` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ContactKey_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(const JPH_BodyID *inBodyB, const JPH_SubShapeID *inSubShapeID);

/// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
/// Parameter `inCharacterIDB` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_ContactKey_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(const JPH_CharacterID *inCharacterIDB, const JPH_SubShapeID *inSubShapeID);

/// Destroys a heap-allocated instance of `JPH_CharacterVirtual_ContactKey`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_ContactKey_Destroy(const JPH_CharacterVirtual_ContactKey *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVirtual_ContactKey`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_ContactKey_DestroyArray(const JPH_CharacterVirtual_ContactKey *_this);

/// Generated from method `JPH::CharacterVirtual::ContactKey::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inContact` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inContact` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_AssignFromAnother(JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inContact);

/// Checks if two contacts refer to the same body (or virtual character)
/// Generated from method `JPH::CharacterVirtual::ContactKey::IsSameBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_ContactKey_IsSameBody(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inOther);

/// Equality operator
/// Generated from method `JPH::CharacterVirtual::ContactKey::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inRHS);

/// Generated from method `JPH::CharacterVirtual::ContactKey::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inRHS);

/// Hash of this structure
/// Generated from method `JPH::CharacterVirtual::ContactKey::GetHash`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterVirtual_ContactKey_GetHash(const JPH_CharacterVirtual_ContactKey *_this);

///< Position where the character makes contact
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mPosition(const JPH_CharacterVirtual_Contact *_this);

///< Position where the character makes contact
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mPosition(JPH_CharacterVirtual_Contact *_this);

///< Velocity of the contact point
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mLinearVelocity(const JPH_CharacterVirtual_Contact *_this);

///< Velocity of the contact point
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mLinearVelocity(JPH_CharacterVirtual_Contact *_this);

///< Contact normal, pointing towards the character
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mContactNormal(const JPH_CharacterVirtual_Contact *_this);

///< Contact normal, pointing towards the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mContactNormal(JPH_CharacterVirtual_Contact *_this);

///< Surface normal of the contact
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mSurfaceNormal(const JPH_CharacterVirtual_Contact *_this);

///< Surface normal of the contact
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mSurfaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mSurfaceNormal(JPH_CharacterVirtual_Contact *_this);

///< Distance to the contact <= 0 means that it is an actual contact, > 0 means predictive
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtual_Contact_Get_mDistance(const JPH_CharacterVirtual_Contact *_this);

///< Distance to the contact <= 0 means that it is an actual contact, > 0 means predictive
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDistance`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mDistance(JPH_CharacterVirtual_Contact *_this, float value);

///< Distance to the contact <= 0 means that it is an actual contact, > 0 means predictive
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtual_Contact_GetMutable_mDistance(JPH_CharacterVirtual_Contact *_this);

///< Fraction along the path where this contact takes place
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterVirtual_Contact_Get_mFraction(const JPH_CharacterVirtual_Contact *_this);

///< Fraction along the path where this contact takes place
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFraction`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mFraction(JPH_CharacterVirtual_Contact *_this, float value);

///< Fraction along the path where this contact takes place
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterVirtual_Contact_GetMutable_mFraction(JPH_CharacterVirtual_Contact *_this);

///< Motion type of B, used to determine the priority of the contact
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mMotionTypeB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EMotionType *JPH_CharacterVirtual_Contact_Get_mMotionTypeB(const JPH_CharacterVirtual_Contact *_this);

///< Motion type of B, used to determine the priority of the contact
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mMotionTypeB`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMotionTypeB`.
/// When this function is called, this object will drop object references it held previously in `mMotionTypeB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mMotionTypeB(JPH_CharacterVirtual_Contact *_this, JPH_EMotionType value);

///< Motion type of B, used to determine the priority of the contact
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mMotionTypeB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EMotionType *JPH_CharacterVirtual_Contact_GetMutable_mMotionTypeB(JPH_CharacterVirtual_Contact *_this);

///< If B is a sensor
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mIsSensorB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterVirtual_Contact_Get_mIsSensorB(const JPH_CharacterVirtual_Contact *_this);

///< If B is a sensor
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mIsSensorB`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsSensorB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mIsSensorB(JPH_CharacterVirtual_Contact *_this, bool value);

///< If B is a sensor
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mIsSensorB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB(JPH_CharacterVirtual_Contact *_this);

///< Character we're colliding with (if not nullptr). Note that this may be a dangling pointer when accessed through GetActiveContacts(), use mCharacterIDB instead.
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterVirtual *const *JPH_CharacterVirtual_Contact_Get_mCharacterB(const JPH_CharacterVirtual_Contact *_this);

///< Character we're colliding with (if not nullptr). Note that this may be a dangling pointer when accessed through GetActiveContacts(), use mCharacterIDB instead.
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterB`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCharacterB`.
/// When this function is called, this object will drop object references it held previously in `mCharacterB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mCharacterB(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual *value);

///< Character we're colliding with (if not nullptr). Note that this may be a dangling pointer when accessed through GetActiveContacts(), use mCharacterIDB instead.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterVirtual **JPH_CharacterVirtual_Contact_GetMutable_mCharacterB(JPH_CharacterVirtual_Contact *_this);

///< User data of B
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_CharacterVirtual_Contact_Get_mUserData(const JPH_CharacterVirtual_Contact *_this);

///< User data of B
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mUserData(JPH_CharacterVirtual_Contact *_this, uint64_t value);

///< User data of B
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_CharacterVirtual_Contact_GetMutable_mUserData(JPH_CharacterVirtual_Contact *_this);

///< Material of B
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_PhysicsMaterial *const *JPH_CharacterVirtual_Contact_Get_mMaterial(const JPH_CharacterVirtual_Contact *_this);

///< Material of B
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaterial`.
/// When this function is called, this object will drop object references it held previously in `mMaterial`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mMaterial(JPH_CharacterVirtual_Contact *_this, const JPH_PhysicsMaterial *value);

///< Material of B
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_PhysicsMaterial **JPH_CharacterVirtual_Contact_GetMutable_mMaterial(JPH_CharacterVirtual_Contact *_this);

///< If the character actually collided with the contact (can be false if a predictive contact never becomes a real one)
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mHadCollision`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterVirtual_Contact_Get_mHadCollision(const JPH_CharacterVirtual_Contact *_this);

///< If the character actually collided with the contact (can be false if a predictive contact never becomes a real one)
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mHadCollision`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHadCollision`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mHadCollision(JPH_CharacterVirtual_Contact *_this, bool value);

///< If the character actually collided with the contact (can be false if a predictive contact never becomes a real one)
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mHadCollision`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterVirtual_Contact_GetMutable_mHadCollision(JPH_CharacterVirtual_Contact *_this);

///< If the contact validate callback chose to discard this contact or when the body is a sensor
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mWasDiscarded`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterVirtual_Contact_Get_mWasDiscarded(const JPH_CharacterVirtual_Contact *_this);

///< If the contact validate callback chose to discard this contact or when the body is a sensor
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mWasDiscarded`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWasDiscarded`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mWasDiscarded(JPH_CharacterVirtual_Contact *_this, bool value);

///< If the contact validate callback chose to discard this contact or when the body is a sensor
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mWasDiscarded`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded(JPH_CharacterVirtual_Contact *_this);

///< When true, the velocity of the contact point can push the character
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterVirtual_Contact_Get_mCanPushCharacter(const JPH_CharacterVirtual_Contact *_this);

///< When true, the velocity of the contact point can push the character
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCanPushCharacter`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mCanPushCharacter(JPH_CharacterVirtual_Contact *_this, bool value);

///< When true, the velocity of the contact point can push the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCanPushCharacter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter(JPH_CharacterVirtual_Contact *_this);

///< ID of body we're colliding with (if not invalid)
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_CharacterVirtual_Contact_Get_mBodyB(const JPH_CharacterVirtual_Contact *_this);

///< ID of body we're colliding with (if not invalid)
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyB`.
/// When this function is called, this object will drop object references it held previously in `mBodyB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mBodyB(JPH_CharacterVirtual_Contact *_this, JPH_BodyID value);

///< ID of body we're colliding with (if not invalid)
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_CharacterVirtual_Contact_GetMutable_mBodyB(JPH_CharacterVirtual_Contact *_this);

///< Character we're colliding with (if not invalid)
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterID *JPH_CharacterVirtual_Contact_Get_mCharacterIDB(const JPH_CharacterVirtual_Contact *_this);

///< Character we're colliding with (if not invalid)
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCharacterIDB`.
/// When this function is called, this object will drop object references it held previously in `mCharacterIDB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mCharacterIDB(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterID *value);

///< Character we're colliding with (if not invalid)
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mCharacterIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterID *JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB(JPH_CharacterVirtual_Contact *_this);

///< Sub shape ID of body or character we're colliding with
/// Returns a pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_CharacterVirtual_Contact_Get_mSubShapeIDB(const JPH_CharacterVirtual_Contact *_this);

///< Sub shape ID of body or character we're colliding with
/// Modifies a member variable of class `JPH::CharacterVirtual::Contact` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeIDB`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeIDB`.
JOLT_API void JPH_CharacterVirtual_Contact_Set_mSubShapeIDB(JPH_CharacterVirtual_Contact *_this, const JPH_SubShapeID *value);

///< Sub shape ID of body or character we're colliding with
/// Returns a mutable pointer to a member variable of class `JPH::CharacterVirtual::Contact` named `mSubShapeIDB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB(JPH_CharacterVirtual_Contact *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_Contact_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterVirtual_Contact_DestroyArray()`.
/// Use `JPH_CharacterVirtual_Contact_OffsetMutablePtr()` and `JPH_CharacterVirtual_Contact_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_OffsetPtr(const JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_OffsetMutablePtr(JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterVirtual::Contact` to its base class `JPH::CharacterVirtual::ContactKey`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *object);

/// Upcasts an instance of `JPH::CharacterVirtual::Contact` to its base class `JPH::CharacterVirtual::ContactKey`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_Contact_MutableUpcastTo_JPH_CharacterVirtual_ContactKey(JPH_CharacterVirtual_Contact *object);

/// Downcasts an instance of `JPH::CharacterVirtual::ContactKey` to a derived class `JPH::CharacterVirtual::Contact`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_StaticDowncastFrom_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *object);

/// Downcasts an instance of `JPH::CharacterVirtual::ContactKey` to a derived class `JPH::CharacterVirtual::Contact`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_MutableStaticDowncastFrom_JPH_CharacterVirtual_ContactKey(JPH_CharacterVirtual_ContactKey *object);

/// Generated from constructor `JPH::CharacterVirtual::Contact::Contact`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterVirtual_Contact_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_ConstructFromAnother(const JPH_CharacterVirtual_Contact *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterVirtual_Contact`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_Contact_Destroy(const JPH_CharacterVirtual_Contact *_this);

/// Destroys a heap-allocated array of `JPH_CharacterVirtual_Contact`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterVirtual_Contact_DestroyArray(const JPH_CharacterVirtual_Contact *_this);

/// Generated from method `JPH::CharacterVirtual::Contact::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_AssignFromAnother(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_Contact *_other);

/// Checks if two contacts refer to the same body (or virtual character)
/// Generated from method `JPH::CharacterVirtual::Contact::IsSameBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inOther` can not be null. It is a single object.
JOLT_API bool JPH_CharacterVirtual_Contact_IsSameBody(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inOther);

/// Equality operator
/// Generated from method `JPH::CharacterVirtual::Contact::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inRHS);

/// Generated from method `JPH::CharacterVirtual::Contact::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inRHS);

/// Hash of this structure
/// Generated from method `JPH::CharacterVirtual::Contact::GetHash`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterVirtual_Contact_GetHash(const JPH_CharacterVirtual_Contact *_this);

#ifdef __cplusplus
} // extern "C"
#endif
