// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generated from class `JPH::PhysicsSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PhysicsSettings JPH_PhysicsSettings;

/// Size of body pairs array, corresponds to the maximum amount of potential body pairs that can be in flight at any time.
/// Setting this to a low value will use less memory but slow down simulation as threads may run out of narrow phase work.
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mMaxInFlightBodyPairs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_PhysicsSettings_Get_mMaxInFlightBodyPairs(const JPH_PhysicsSettings *_this);

/// Size of body pairs array, corresponds to the maximum amount of potential body pairs that can be in flight at any time.
/// Setting this to a low value will use less memory but slow down simulation as threads may run out of narrow phase work.
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mMaxInFlightBodyPairs`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxInFlightBodyPairs`.
JOLT_API void JPH_PhysicsSettings_Set_mMaxInFlightBodyPairs(JPH_PhysicsSettings *_this, int value);

/// Size of body pairs array, corresponds to the maximum amount of potential body pairs that can be in flight at any time.
/// Setting this to a low value will use less memory but slow down simulation as threads may run out of narrow phase work.
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mMaxInFlightBodyPairs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_PhysicsSettings_GetMutable_mMaxInFlightBodyPairs(JPH_PhysicsSettings *_this);

/// How many PhysicsStepListeners to notify in 1 batch
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mStepListenersBatchSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_PhysicsSettings_Get_mStepListenersBatchSize(const JPH_PhysicsSettings *_this);

/// How many PhysicsStepListeners to notify in 1 batch
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mStepListenersBatchSize`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mStepListenersBatchSize`.
JOLT_API void JPH_PhysicsSettings_Set_mStepListenersBatchSize(JPH_PhysicsSettings *_this, int value);

/// How many PhysicsStepListeners to notify in 1 batch
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mStepListenersBatchSize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_PhysicsSettings_GetMutable_mStepListenersBatchSize(JPH_PhysicsSettings *_this);

/// How many step listener batches are needed before spawning another job (set to INT_MAX if no parallelism is desired)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mStepListenerBatchesPerJob`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_PhysicsSettings_Get_mStepListenerBatchesPerJob(const JPH_PhysicsSettings *_this);

/// How many step listener batches are needed before spawning another job (set to INT_MAX if no parallelism is desired)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mStepListenerBatchesPerJob`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mStepListenerBatchesPerJob`.
JOLT_API void JPH_PhysicsSettings_Set_mStepListenerBatchesPerJob(JPH_PhysicsSettings *_this, int value);

/// How many step listener batches are needed before spawning another job (set to INT_MAX if no parallelism is desired)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mStepListenerBatchesPerJob`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_PhysicsSettings_GetMutable_mStepListenerBatchesPerJob(JPH_PhysicsSettings *_this);

/// Baumgarte stabilization factor (how much of the position error to 'fix' in 1 update) (unit: dimensionless, 0 = nothing, 1 = 100%)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mBaumgarte`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mBaumgarte(const JPH_PhysicsSettings *_this);

/// Baumgarte stabilization factor (how much of the position error to 'fix' in 1 update) (unit: dimensionless, 0 = nothing, 1 = 100%)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mBaumgarte`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBaumgarte`.
JOLT_API void JPH_PhysicsSettings_Set_mBaumgarte(JPH_PhysicsSettings *_this, float value);

/// Baumgarte stabilization factor (how much of the position error to 'fix' in 1 update) (unit: dimensionless, 0 = nothing, 1 = 100%)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mBaumgarte`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mBaumgarte(JPH_PhysicsSettings *_this);

/// Radius around objects inside which speculative contact points will be detected. Note that if this is too big
/// you will get ghost collisions as speculative contacts are based on the closest points during the collision detection
/// step which may not be the actual closest points by the time the two objects hit (unit: meters)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mSpeculativeContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mSpeculativeContactDistance(const JPH_PhysicsSettings *_this);

/// Radius around objects inside which speculative contact points will be detected. Note that if this is too big
/// you will get ghost collisions as speculative contacts are based on the closest points during the collision detection
/// step which may not be the actual closest points by the time the two objects hit (unit: meters)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mSpeculativeContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSpeculativeContactDistance`.
JOLT_API void JPH_PhysicsSettings_Set_mSpeculativeContactDistance(JPH_PhysicsSettings *_this, float value);

/// Radius around objects inside which speculative contact points will be detected. Note that if this is too big
/// you will get ghost collisions as speculative contacts are based on the closest points during the collision detection
/// step which may not be the actual closest points by the time the two objects hit (unit: meters)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mSpeculativeContactDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mSpeculativeContactDistance(JPH_PhysicsSettings *_this);

/// How much bodies are allowed to sink into each other (unit: meters)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mPenetrationSlop`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mPenetrationSlop(const JPH_PhysicsSettings *_this);

/// How much bodies are allowed to sink into each other (unit: meters)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mPenetrationSlop`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationSlop`.
JOLT_API void JPH_PhysicsSettings_Set_mPenetrationSlop(JPH_PhysicsSettings *_this, float value);

/// How much bodies are allowed to sink into each other (unit: meters)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mPenetrationSlop`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mPenetrationSlop(JPH_PhysicsSettings *_this);

/// Fraction of its inner radius a body must move per step to enable casting for the LinearCast motion quality
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mLinearCastThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mLinearCastThreshold(const JPH_PhysicsSettings *_this);

/// Fraction of its inner radius a body must move per step to enable casting for the LinearCast motion quality
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mLinearCastThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLinearCastThreshold`.
JOLT_API void JPH_PhysicsSettings_Set_mLinearCastThreshold(JPH_PhysicsSettings *_this, float value);

/// Fraction of its inner radius a body must move per step to enable casting for the LinearCast motion quality
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mLinearCastThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mLinearCastThreshold(JPH_PhysicsSettings *_this);

/// Fraction of its inner radius a body may penetrate another body for the LinearCast motion quality
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mLinearCastMaxPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mLinearCastMaxPenetration(const JPH_PhysicsSettings *_this);

/// Fraction of its inner radius a body may penetrate another body for the LinearCast motion quality
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mLinearCastMaxPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLinearCastMaxPenetration`.
JOLT_API void JPH_PhysicsSettings_Set_mLinearCastMaxPenetration(JPH_PhysicsSettings *_this, float value);

/// Fraction of its inner radius a body may penetrate another body for the LinearCast motion quality
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mLinearCastMaxPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mLinearCastMaxPenetration(JPH_PhysicsSettings *_this);

/// Max distance to use to determine if two points are on the same plane for determining the contact manifold between two shape faces (unit: meter)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mManifoldTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mManifoldTolerance(const JPH_PhysicsSettings *_this);

/// Max distance to use to determine if two points are on the same plane for determining the contact manifold between two shape faces (unit: meter)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mManifoldTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mManifoldTolerance`.
JOLT_API void JPH_PhysicsSettings_Set_mManifoldTolerance(JPH_PhysicsSettings *_this, float value);

/// Max distance to use to determine if two points are on the same plane for determining the contact manifold between two shape faces (unit: meter)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mManifoldTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mManifoldTolerance(JPH_PhysicsSettings *_this);

/// Maximum distance to correct in a single iteration when solving position constraints (unit: meters)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mMaxPenetrationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mMaxPenetrationDistance(const JPH_PhysicsSettings *_this);

/// Maximum distance to correct in a single iteration when solving position constraints (unit: meters)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mMaxPenetrationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxPenetrationDistance`.
JOLT_API void JPH_PhysicsSettings_Set_mMaxPenetrationDistance(JPH_PhysicsSettings *_this, float value);

/// Maximum distance to correct in a single iteration when solving position constraints (unit: meters)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mMaxPenetrationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mMaxPenetrationDistance(JPH_PhysicsSettings *_this);

///< 1 mm
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheMaxDeltaPositionSq`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mBodyPairCacheMaxDeltaPositionSq(const JPH_PhysicsSettings *_this);

///< 1 mm
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheMaxDeltaPositionSq`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBodyPairCacheMaxDeltaPositionSq`.
JOLT_API void JPH_PhysicsSettings_Set_mBodyPairCacheMaxDeltaPositionSq(JPH_PhysicsSettings *_this, float value);

///< 1 mm
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheMaxDeltaPositionSq`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mBodyPairCacheMaxDeltaPositionSq(JPH_PhysicsSettings *_this);

///< cos(2 degrees / 2)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheCosMaxDeltaRotationDiv2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mBodyPairCacheCosMaxDeltaRotationDiv2(const JPH_PhysicsSettings *_this);

///< cos(2 degrees / 2)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheCosMaxDeltaRotationDiv2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBodyPairCacheCosMaxDeltaRotationDiv2`.
JOLT_API void JPH_PhysicsSettings_Set_mBodyPairCacheCosMaxDeltaRotationDiv2(JPH_PhysicsSettings *_this, float value);

///< cos(2 degrees / 2)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mBodyPairCacheCosMaxDeltaRotationDiv2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mBodyPairCacheCosMaxDeltaRotationDiv2(JPH_PhysicsSettings *_this);

///< cos(5 degree)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mContactNormalCosMaxDeltaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mContactNormalCosMaxDeltaRotation(const JPH_PhysicsSettings *_this);

///< cos(5 degree)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mContactNormalCosMaxDeltaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mContactNormalCosMaxDeltaRotation`.
JOLT_API void JPH_PhysicsSettings_Set_mContactNormalCosMaxDeltaRotation(JPH_PhysicsSettings *_this, float value);

///< cos(5 degree)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mContactNormalCosMaxDeltaRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mContactNormalCosMaxDeltaRotation(JPH_PhysicsSettings *_this);

///< 1 cm
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mContactPointPreserveLambdaMaxDistSq`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mContactPointPreserveLambdaMaxDistSq(const JPH_PhysicsSettings *_this);

///< 1 cm
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mContactPointPreserveLambdaMaxDistSq`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mContactPointPreserveLambdaMaxDistSq`.
JOLT_API void JPH_PhysicsSettings_Set_mContactPointPreserveLambdaMaxDistSq(JPH_PhysicsSettings *_this, float value);

///< 1 cm
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mContactPointPreserveLambdaMaxDistSq`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mContactPointPreserveLambdaMaxDistSq(JPH_PhysicsSettings *_this);

/// Number of solver velocity iterations to run
/// Note that this needs to be >= 2 in order for friction to work (friction is applied using the non-penetration impulse from the previous iteration)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mNumVelocitySteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PhysicsSettings_Get_mNumVelocitySteps(const JPH_PhysicsSettings *_this);

/// Number of solver velocity iterations to run
/// Note that this needs to be >= 2 in order for friction to work (friction is applied using the non-penetration impulse from the previous iteration)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mNumVelocitySteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumVelocitySteps`.
/// When this function is called, this object will drop object references it held previously in `mNumVelocitySteps`.
JOLT_API void JPH_PhysicsSettings_Set_mNumVelocitySteps(JPH_PhysicsSettings *_this, unsigned int value);

/// Number of solver velocity iterations to run
/// Note that this needs to be >= 2 in order for friction to work (friction is applied using the non-penetration impulse from the previous iteration)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mNumVelocitySteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PhysicsSettings_GetMutable_mNumVelocitySteps(JPH_PhysicsSettings *_this);

/// Number of solver position iterations to run
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mNumPositionSteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_PhysicsSettings_Get_mNumPositionSteps(const JPH_PhysicsSettings *_this);

/// Number of solver position iterations to run
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mNumPositionSteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumPositionSteps`.
/// When this function is called, this object will drop object references it held previously in `mNumPositionSteps`.
JOLT_API void JPH_PhysicsSettings_Set_mNumPositionSteps(JPH_PhysicsSettings *_this, unsigned int value);

/// Number of solver position iterations to run
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mNumPositionSteps`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_PhysicsSettings_GetMutable_mNumPositionSteps(JPH_PhysicsSettings *_this);

/// Minimal velocity needed before a collision can be elastic. If the relative velocity between colliding objects
/// in the direction of the contact normal is lower than this, the restitution will be zero regardless of the configured
/// value. This lets an object settle sooner. Must be a positive number. (unit: m)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mMinVelocityForRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mMinVelocityForRestitution(const JPH_PhysicsSettings *_this);

/// Minimal velocity needed before a collision can be elastic. If the relative velocity between colliding objects
/// in the direction of the contact normal is lower than this, the restitution will be zero regardless of the configured
/// value. This lets an object settle sooner. Must be a positive number. (unit: m)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mMinVelocityForRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMinVelocityForRestitution`.
JOLT_API void JPH_PhysicsSettings_Set_mMinVelocityForRestitution(JPH_PhysicsSettings *_this, float value);

/// Minimal velocity needed before a collision can be elastic. If the relative velocity between colliding objects
/// in the direction of the contact normal is lower than this, the restitution will be zero regardless of the configured
/// value. This lets an object settle sooner. Must be a positive number. (unit: m)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mMinVelocityForRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mMinVelocityForRestitution(JPH_PhysicsSettings *_this);

/// Time before object is allowed to go to sleep (unit: seconds)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mTimeBeforeSleep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mTimeBeforeSleep(const JPH_PhysicsSettings *_this);

/// Time before object is allowed to go to sleep (unit: seconds)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mTimeBeforeSleep`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTimeBeforeSleep`.
JOLT_API void JPH_PhysicsSettings_Set_mTimeBeforeSleep(JPH_PhysicsSettings *_this, float value);

/// Time before object is allowed to go to sleep (unit: seconds)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mTimeBeforeSleep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mTimeBeforeSleep(JPH_PhysicsSettings *_this);

/// To detect if an object is sleeping, we use 3 points:
/// - The center of mass.
/// - The centers of the faces of the bounding box that are furthest away from the center.
/// The movement of these points is tracked and if the velocity of all 3 points is lower than this value,
/// the object is allowed to go to sleep. Must be a positive number. (unit: m/s)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mPointVelocitySleepThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsSettings_Get_mPointVelocitySleepThreshold(const JPH_PhysicsSettings *_this);

/// To detect if an object is sleeping, we use 3 points:
/// - The center of mass.
/// - The centers of the faces of the bounding box that are furthest away from the center.
/// The movement of these points is tracked and if the velocity of all 3 points is lower than this value,
/// the object is allowed to go to sleep. Must be a positive number. (unit: m/s)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mPointVelocitySleepThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPointVelocitySleepThreshold`.
JOLT_API void JPH_PhysicsSettings_Set_mPointVelocitySleepThreshold(JPH_PhysicsSettings *_this, float value);

/// To detect if an object is sleeping, we use 3 points:
/// - The center of mass.
/// - The centers of the faces of the bounding box that are furthest away from the center.
/// The movement of these points is tracked and if the velocity of all 3 points is lower than this value,
/// the object is allowed to go to sleep. Must be a positive number. (unit: m/s)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mPointVelocitySleepThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsSettings_GetMutable_mPointVelocitySleepThreshold(JPH_PhysicsSettings *_this);

/// By default the simulation is deterministic, it is possible to turn this off by setting this setting to false. This will make the simulation run faster but it will no longer be deterministic.
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mDeterministicSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mDeterministicSimulation(const JPH_PhysicsSettings *_this);

/// By default the simulation is deterministic, it is possible to turn this off by setting this setting to false. This will make the simulation run faster but it will no longer be deterministic.
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mDeterministicSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDeterministicSimulation`.
JOLT_API void JPH_PhysicsSettings_Set_mDeterministicSimulation(JPH_PhysicsSettings *_this, bool value);

/// By default the simulation is deterministic, it is possible to turn this off by setting this setting to false. This will make the simulation run faster but it will no longer be deterministic.
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mDeterministicSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mDeterministicSimulation(JPH_PhysicsSettings *_this);

/// Whether or not to use warm starting for constraints (initially applying previous frames impulses)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mConstraintWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mConstraintWarmStart(const JPH_PhysicsSettings *_this);

/// Whether or not to use warm starting for constraints (initially applying previous frames impulses)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mConstraintWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mConstraintWarmStart`.
JOLT_API void JPH_PhysicsSettings_Set_mConstraintWarmStart(JPH_PhysicsSettings *_this, bool value);

/// Whether or not to use warm starting for constraints (initially applying previous frames impulses)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mConstraintWarmStart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mConstraintWarmStart(JPH_PhysicsSettings *_this);

/// Whether or not to use the body pair cache, which removes the need for narrow phase collision detection when orientation between two bodies didn't change
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mUseBodyPairContactCache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mUseBodyPairContactCache(const JPH_PhysicsSettings *_this);

/// Whether or not to use the body pair cache, which removes the need for narrow phase collision detection when orientation between two bodies didn't change
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mUseBodyPairContactCache`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseBodyPairContactCache`.
JOLT_API void JPH_PhysicsSettings_Set_mUseBodyPairContactCache(JPH_PhysicsSettings *_this, bool value);

/// Whether or not to use the body pair cache, which removes the need for narrow phase collision detection when orientation between two bodies didn't change
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mUseBodyPairContactCache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mUseBodyPairContactCache(JPH_PhysicsSettings *_this);

/// Whether or not to reduce manifolds with similar contact normals into one contact manifold (see description at Body::SetUseManifoldReduction)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mUseManifoldReduction(const JPH_PhysicsSettings *_this);

/// Whether or not to reduce manifolds with similar contact normals into one contact manifold (see description at Body::SetUseManifoldReduction)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseManifoldReduction`.
JOLT_API void JPH_PhysicsSettings_Set_mUseManifoldReduction(JPH_PhysicsSettings *_this, bool value);

/// Whether or not to reduce manifolds with similar contact normals into one contact manifold (see description at Body::SetUseManifoldReduction)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mUseManifoldReduction(JPH_PhysicsSettings *_this);

/// If we split up large islands into smaller parallel batches of work (to improve performance)
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mUseLargeIslandSplitter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mUseLargeIslandSplitter(const JPH_PhysicsSettings *_this);

/// If we split up large islands into smaller parallel batches of work (to improve performance)
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mUseLargeIslandSplitter`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUseLargeIslandSplitter`.
JOLT_API void JPH_PhysicsSettings_Set_mUseLargeIslandSplitter(JPH_PhysicsSettings *_this, bool value);

/// If we split up large islands into smaller parallel batches of work (to improve performance)
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mUseLargeIslandSplitter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mUseLargeIslandSplitter(JPH_PhysicsSettings *_this);

/// If objects can go to sleep or not
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mAllowSleeping(const JPH_PhysicsSettings *_this);

/// If objects can go to sleep or not
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowSleeping`.
JOLT_API void JPH_PhysicsSettings_Set_mAllowSleeping(JPH_PhysicsSettings *_this, bool value);

/// If objects can go to sleep or not
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mAllowSleeping(JPH_PhysicsSettings *_this);

/// When false, we prevent collision against non-active (shared) edges. Mainly for debugging the algorithm.
/// Returns a pointer to a member variable of class `JPH::PhysicsSettings` named `mCheckActiveEdges`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsSettings_Get_mCheckActiveEdges(const JPH_PhysicsSettings *_this);

/// When false, we prevent collision against non-active (shared) edges. Mainly for debugging the algorithm.
/// Modifies a member variable of class `JPH::PhysicsSettings` named `mCheckActiveEdges`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCheckActiveEdges`.
JOLT_API void JPH_PhysicsSettings_Set_mCheckActiveEdges(JPH_PhysicsSettings *_this, bool value);

/// When false, we prevent collision against non-active (shared) edges. Mainly for debugging the algorithm.
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsSettings` named `mCheckActiveEdges`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsSettings_GetMutable_mCheckActiveEdges(JPH_PhysicsSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PhysicsSettings_DestroyArray()`.
/// Use `JPH_PhysicsSettings_OffsetMutablePtr()` and `JPH_PhysicsSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::PhysicsSettings` elementwise.
/// The reference to the parameter `mNumVelocitySteps` might be preserved in the constructed object.
/// The reference to the parameter `mNumPositionSteps` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_ConstructFrom(int mMaxInFlightBodyPairs, int mStepListenersBatchSize, int mStepListenerBatchesPerJob, float mBaumgarte, float mSpeculativeContactDistance, float mPenetrationSlop, float mLinearCastThreshold, float mLinearCastMaxPenetration, float mManifoldTolerance, float mMaxPenetrationDistance, float mBodyPairCacheMaxDeltaPositionSq, float mBodyPairCacheCosMaxDeltaRotationDiv2, float mContactNormalCosMaxDeltaRotation, float mContactPointPreserveLambdaMaxDistSq, unsigned int mNumVelocitySteps, unsigned int mNumPositionSteps, float mMinVelocityForRestitution, float mTimeBeforeSleep, float mPointVelocitySleepThreshold, bool mDeterministicSimulation, bool mConstraintWarmStart, bool mUseBodyPairContactCache, bool mUseManifoldReduction, bool mUseLargeIslandSplitter, bool mAllowSleeping, bool mCheckActiveEdges);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsSettings *JPH_PhysicsSettings_OffsetPtr(const JPH_PhysicsSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_OffsetMutablePtr(JPH_PhysicsSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::PhysicsSettings::PhysicsSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_ConstructFromAnother(const JPH_PhysicsSettings *_other);

/// Destroys a heap-allocated instance of `JPH_PhysicsSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsSettings_Destroy(const JPH_PhysicsSettings *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsSettings_DestroyArray(const JPH_PhysicsSettings *_this);

/// Generated from method `JPH::PhysicsSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PhysicsSettings *JPH_PhysicsSettings_AssignFromAnother(JPH_PhysicsSettings *_this, const JPH_PhysicsSettings *_other);

/// Generated from method `JPH::PhysicsSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PhysicsSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PhysicsSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::PhysicsSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::PhysicsSettings::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PhysicsSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PhysicsSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::PhysicsSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
