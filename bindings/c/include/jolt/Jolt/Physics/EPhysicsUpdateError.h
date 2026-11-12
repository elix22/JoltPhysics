// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// Enum used by PhysicsSystem to report error conditions during the PhysicsSystem::Update call. This is a bit field, multiple errors can trigger in the same update.
typedef enum JPH_EPhysicsUpdateError
{
    ///< No errors
    JPH_EPhysicsUpdateError_None = 0,
    ///< The manifold cache is full, this means that the total number of contacts between bodies is too high. Some contacts were ignored. Increase inMaxContactConstraints in PhysicsSystem::Init.
    JPH_EPhysicsUpdateError_ManifoldCacheFull = 1,
    ///< The body pair cache is full, this means that too many bodies contacted. Some contacts were ignored. Increase inMaxBodyPairs in PhysicsSystem::Init.
    JPH_EPhysicsUpdateError_BodyPairCacheFull = 2,
    ///< The contact constraints buffer is full. Some contacts were ignored. Increase inMaxContactConstraints in PhysicsSystem::Init.
    JPH_EPhysicsUpdateError_ContactConstraintsFull = 4,
} JPH_EPhysicsUpdateError;

#ifdef __cplusplus
} // extern "C"
#endif
