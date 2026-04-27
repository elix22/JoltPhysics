// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_SubShapeIDPair JPH_SubShapeIDPair; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeIDPair.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Manifold class, describes the contact surface between two bodies
/// Generated from class `JPH::ContactManifold`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ContactManifold JPH_ContactManifold;

/// When a contact point is added or persisted, the callback gets a chance to override certain properties of the contact constraint.
/// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
/// Generated from class `JPH::ContactSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ContactSettings JPH_ContactSettings;

/// A listener class that receives collision contact events. It can be registered through PhysicsSystem::SetContactListener.
/// Only a single contact listener can be registered. A common pattern is to create a contact listener that casts Body::GetUserData
/// to a game object and then forwards the call to a handler specific for that game object.
/// Typically this is done on both objects involved in a collision event.
///
/// Note that contact listener callbacks are called from multiple threads at the same time when all bodies are locked, this means you cannot
/// use PhysicsSystem::GetBodyInterface / PhysicsSystem::GetBodyLockInterface but must use PhysicsSystem::GetBodyInterfaceNoLock / PhysicsSystem::GetBodyLockInterfaceNoLock instead.
/// If you use a locking interface, the simulation will deadlock. You're only allowed to read from the bodies and you can't change physics state.
/// During OnContactRemoved you cannot access the bodies at all, see the comments at that function.
///
/// While a callback can come from multiple threads, all callbacks relating to a single body pair are serialized.
/// For EMotionQuality::Discrete bodies, during every 'collision step' in a PhysicsSystem::Update, you will receive at most one OnContactAdded/Persisted/Removed call per body/sub shape pair.
/// For EMotionQuality::LinearCast bodies, you may get an OnContactAdded followed by an OnContactPersisted for the same body/sub shape pair.
/// This happens when a body collides both in the discrete and the continuous collision detection stage.
/// Generated from class `JPH::ContactListener`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_ContactListener JPH_ContactListener;

///< Offset to which all the contact points are relative
/// Returns a pointer to a member variable of class `JPH::ContactManifold` named `mBaseOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ContactManifold_Get_mBaseOffset(const JPH_ContactManifold *_this);

///< Offset to which all the contact points are relative
/// Returns a mutable pointer to a member variable of class `JPH::ContactManifold` named `mBaseOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ContactManifold_GetMutable_mBaseOffset(JPH_ContactManifold *_this);

///< Normal for this manifold, direction along which to move body 2 out of collision along the shortest path
/// Returns a pointer to a member variable of class `JPH::ContactManifold` named `mWorldSpaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ContactManifold_Get_mWorldSpaceNormal(const JPH_ContactManifold *_this);

///< Normal for this manifold, direction along which to move body 2 out of collision along the shortest path
/// Returns a mutable pointer to a member variable of class `JPH::ContactManifold` named `mWorldSpaceNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ContactManifold_GetMutable_mWorldSpaceNormal(JPH_ContactManifold *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If this value is negative, this is a speculative contact point and may not actually result in a velocity change as during solving the bodies may not actually collide.
/// Returns a pointer to a member variable of class `JPH::ContactManifold` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactManifold_Get_mPenetrationDepth(const JPH_ContactManifold *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If this value is negative, this is a speculative contact point and may not actually result in a velocity change as during solving the bodies may not actually collide.
/// Modifies a member variable of class `JPH::ContactManifold` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationDepth`.
JOLT_API void JPH_ContactManifold_Set_mPenetrationDepth(JPH_ContactManifold *_this, float value);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If this value is negative, this is a speculative contact point and may not actually result in a velocity change as during solving the bodies may not actually collide.
/// Returns a mutable pointer to a member variable of class `JPH::ContactManifold` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactManifold_GetMutable_mPenetrationDepth(JPH_ContactManifold *_this);

///< Sub shapes that formed this manifold (note that when multiple manifolds are combined because they're coplanar, we lose some information here because we only keep track of one sub shape pair that we encounter, see description at Body::SetUseManifoldReduction)
/// Returns a pointer to a member variable of class `JPH::ContactManifold` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_ContactManifold_Get_mSubShapeID1(const JPH_ContactManifold *_this);

///< Sub shapes that formed this manifold (note that when multiple manifolds are combined because they're coplanar, we lose some information here because we only keep track of one sub shape pair that we encounter, see description at Body::SetUseManifoldReduction)
/// Modifies a member variable of class `JPH::ContactManifold` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID1`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID1`.
JOLT_API void JPH_ContactManifold_Set_mSubShapeID1(JPH_ContactManifold *_this, const JPH_SubShapeID *value);

///< Sub shapes that formed this manifold (note that when multiple manifolds are combined because they're coplanar, we lose some information here because we only keep track of one sub shape pair that we encounter, see description at Body::SetUseManifoldReduction)
/// Returns a mutable pointer to a member variable of class `JPH::ContactManifold` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_ContactManifold_GetMutable_mSubShapeID1(JPH_ContactManifold *_this);

/// Returns a pointer to a member variable of class `JPH::ContactManifold` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_ContactManifold_Get_mSubShapeID2(const JPH_ContactManifold *_this);

/// Modifies a member variable of class `JPH::ContactManifold` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID2`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID2`.
JOLT_API void JPH_ContactManifold_Set_mSubShapeID2(JPH_ContactManifold *_this, const JPH_SubShapeID *value);

/// Returns a mutable pointer to a member variable of class `JPH::ContactManifold` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_ContactManifold_GetMutable_mSubShapeID2(JPH_ContactManifold *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactManifold_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactManifold *JPH_ContactManifold_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ContactManifold_DestroyArray()`.
/// Use `JPH_ContactManifold_OffsetMutablePtr()` and `JPH_ContactManifold_OffsetPtr()` to access the array elements.
JOLT_API JPH_ContactManifold *JPH_ContactManifold_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::ContactManifold::ContactManifold`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactManifold_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactManifold *JPH_ContactManifold_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ContactManifold *_other);

/// Destroys a heap-allocated instance of `JPH_ContactManifold`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactManifold_Destroy(const JPH_ContactManifold *_this);

/// Destroys a heap-allocated array of `JPH_ContactManifold`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactManifold_DestroyArray(const JPH_ContactManifold *_this);

/// Generated from method `JPH::ContactManifold::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ContactManifold *JPH_ContactManifold_AssignFromAnother(JPH_ContactManifold *_this, Jolt_PassBy _other_pass_by, JPH_ContactManifold *_other);

/// Swaps shape 1 and 2
/// Generated from method `JPH::ContactManifold::SwapShapes`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactManifold_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactManifold *JPH_ContactManifold_SwapShapes(const JPH_ContactManifold *_this);

/// Access to the world space contact positions
/// Generated from method `JPH::ContactManifold::GetWorldSpaceContactPointOn1`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ContactManifold_GetWorldSpaceContactPointOn1(const JPH_ContactManifold *_this, unsigned int inIndex);

/// Generated from method `JPH::ContactManifold::GetWorldSpaceContactPointOn2`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_ContactManifold_GetWorldSpaceContactPointOn2(const JPH_ContactManifold *_this, unsigned int inIndex);

///< Combined friction for the body pair (see: PhysicsSystem::SetCombineFriction)
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mCombinedFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mCombinedFriction(const JPH_ContactSettings *_this);

///< Combined friction for the body pair (see: PhysicsSystem::SetCombineFriction)
/// Modifies a member variable of class `JPH::ContactSettings` named `mCombinedFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedFriction`.
JOLT_API void JPH_ContactSettings_Set_mCombinedFriction(JPH_ContactSettings *_this, float value);

///< Combined friction for the body pair (see: PhysicsSystem::SetCombineFriction)
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mCombinedFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mCombinedFriction(JPH_ContactSettings *_this);

///< Combined restitution for the body pair (see: PhysicsSystem::SetCombineRestitution)
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mCombinedRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mCombinedRestitution(const JPH_ContactSettings *_this);

///< Combined restitution for the body pair (see: PhysicsSystem::SetCombineRestitution)
/// Modifies a member variable of class `JPH::ContactSettings` named `mCombinedRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCombinedRestitution`.
JOLT_API void JPH_ContactSettings_Set_mCombinedRestitution(JPH_ContactSettings *_this, float value);

///< Combined restitution for the body pair (see: PhysicsSystem::SetCombineRestitution)
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mCombinedRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mCombinedRestitution(JPH_ContactSettings *_this);

///< Scale factor for the inverse mass of body 1 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mInvMassScale1(const JPH_ContactSettings *_this);

///< Scale factor for the inverse mass of body 1 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Modifies a member variable of class `JPH::ContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMassScale1`.
JOLT_API void JPH_ContactSettings_Set_mInvMassScale1(JPH_ContactSettings *_this, float value);

///< Scale factor for the inverse mass of body 1 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mInvMassScale1(JPH_ContactSettings *_this);

///< Scale factor for the inverse inertia of body 1 (usually same as mInvMassScale1)
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mInvInertiaScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mInvInertiaScale1(const JPH_ContactSettings *_this);

///< Scale factor for the inverse inertia of body 1 (usually same as mInvMassScale1)
/// Modifies a member variable of class `JPH::ContactSettings` named `mInvInertiaScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvInertiaScale1`.
JOLT_API void JPH_ContactSettings_Set_mInvInertiaScale1(JPH_ContactSettings *_this, float value);

///< Scale factor for the inverse inertia of body 1 (usually same as mInvMassScale1)
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mInvInertiaScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mInvInertiaScale1(JPH_ContactSettings *_this);

///< Scale factor for the inverse mass of body 2 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mInvMassScale2(const JPH_ContactSettings *_this);

///< Scale factor for the inverse mass of body 2 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Modifies a member variable of class `JPH::ContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMassScale2`.
JOLT_API void JPH_ContactSettings_Set_mInvMassScale2(JPH_ContactSettings *_this, float value);

///< Scale factor for the inverse mass of body 2 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mInvMassScale2(JPH_ContactSettings *_this);

///< Scale factor for the inverse inertia of body 2 (usually same as mInvMassScale2)
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_ContactSettings_Get_mInvInertiaScale2(const JPH_ContactSettings *_this);

///< Scale factor for the inverse inertia of body 2 (usually same as mInvMassScale2)
/// Modifies a member variable of class `JPH::ContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvInertiaScale2`.
JOLT_API void JPH_ContactSettings_Set_mInvInertiaScale2(JPH_ContactSettings *_this, float value);

///< Scale factor for the inverse inertia of body 2 (usually same as mInvMassScale2)
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_ContactSettings_GetMutable_mInvInertiaScale2(JPH_ContactSettings *_this);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_ContactSettings_Get_mIsSensor(const JPH_ContactSettings *_this);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Modifies a member variable of class `JPH::ContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsSensor`.
JOLT_API void JPH_ContactSettings_Set_mIsSensor(JPH_ContactSettings *_this, bool value);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_ContactSettings_GetMutable_mIsSensor(JPH_ContactSettings *_this);

///< Relative linear surface velocity between the bodies (world space surface velocity of body 2 - world space surface velocity of body 1), can be used to create a conveyor belt effect
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mRelativeLinearSurfaceVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity(const JPH_ContactSettings *_this);

///< Relative linear surface velocity between the bodies (world space surface velocity of body 2 - world space surface velocity of body 1), can be used to create a conveyor belt effect
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mRelativeLinearSurfaceVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity(JPH_ContactSettings *_this);

///< Relative angular surface velocity between the bodies (world space angular surface velocity of body 2 - world space angular surface velocity of body 1). Note that this angular velocity is relative to the center of mass of body 1, so if you want it relative to body 2's center of mass you need to add body 2 angular velocity x (body 1 world space center of mass - body 2 world space center of mass) to mRelativeLinearSurfaceVelocity.
/// Returns a pointer to a member variable of class `JPH::ContactSettings` named `mRelativeAngularSurfaceVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity(const JPH_ContactSettings *_this);

///< Relative angular surface velocity between the bodies (world space angular surface velocity of body 2 - world space angular surface velocity of body 1). Note that this angular velocity is relative to the center of mass of body 1, so if you want it relative to body 2's center of mass you need to add body 2 angular velocity x (body 1 world space center of mass - body 2 world space center of mass) to mRelativeLinearSurfaceVelocity.
/// Returns a mutable pointer to a member variable of class `JPH::ContactSettings` named `mRelativeAngularSurfaceVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity(JPH_ContactSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ContactSettings_DestroyArray()`.
/// Use `JPH_ContactSettings_OffsetMutablePtr()` and `JPH_ContactSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::ContactSettings` elementwise.
/// Parameter `mRelativeLinearSurfaceVelocity` can not be null. It is a single object.
/// The reference to the parameter `mRelativeLinearSurfaceVelocity` might be preserved in the constructed object.
/// Parameter `mRelativeAngularSurfaceVelocity` can not be null. It is a single object.
/// The reference to the parameter `mRelativeAngularSurfaceVelocity` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_ConstructFrom(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor, const JPH_Vec3 *mRelativeLinearSurfaceVelocity, const JPH_Vec3 *mRelativeAngularSurfaceVelocity);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ContactSettings *JPH_ContactSettings_OffsetPtr(const JPH_ContactSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_OffsetMutablePtr(JPH_ContactSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::ContactSettings::ContactSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_ConstructFromAnother(const JPH_ContactSettings *_other);

/// Destroys a heap-allocated instance of `JPH_ContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactSettings_Destroy(const JPH_ContactSettings *_this);

/// Destroys a heap-allocated array of `JPH_ContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactSettings_DestroyArray(const JPH_ContactSettings *_this);

/// Generated from method `JPH::ContactSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ContactSettings *JPH_ContactSettings_AssignFromAnother(JPH_ContactSettings *_this, const JPH_ContactSettings *_other);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactListener *JPH_ContactListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_ContactListener_DestroyArray()`.
/// Use `JPH_ContactListener_OffsetMutablePtr()` and `JPH_ContactListener_OffsetPtr()` to access the array elements.
JOLT_API JPH_ContactListener *JPH_ContactListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_ContactListener *JPH_ContactListener_OffsetPtr(const JPH_ContactListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_ContactListener *JPH_ContactListener_OffsetMutablePtr(JPH_ContactListener *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::ContactListener::ContactListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_ContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_ContactListener *JPH_ContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ContactListener *_other);

/// Destroys a heap-allocated instance of `JPH_ContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactListener_Destroy(const JPH_ContactListener *_this);

/// Destroys a heap-allocated array of `JPH_ContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_ContactListener_DestroyArray(const JPH_ContactListener *_this);

/// Generated from method `JPH::ContactListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_ContactListener *JPH_ContactListener_AssignFromAnother(JPH_ContactListener *_this, Jolt_PassBy _other_pass_by, JPH_ContactListener *_other);

/// Called whenever a new contact point is detected.
///
/// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
///
/// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
///
/// Note that only active bodies will report contacts, as soon as a body goes to sleep the contacts between that body and all other
/// bodies will receive an OnContactRemoved callback, if this is the case then Body::IsActive() will return false during the callback.
///
/// When contacts are added, the constraint solver has not run yet, so the collision impulse is unknown at that point.
/// The velocities of inBody1 and inBody2 are the velocities before the contact has been resolved, so you can use this to
/// estimate the collision impulse to e.g. determine the volume of the impact sound to play (see: EstimateCollisionResponse).
/// Generated from method `JPH::ContactListener::OnContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_ContactListener_OnContactAdded(JPH_ContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Called whenever a contact is detected that was also detected last update.
///
/// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
///
/// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
///
/// If the structure of the shape of a body changes between simulation steps (e.g. by adding/removing a child shape of a compound shape),
/// it is possible that the same sub shape ID used to identify the removed child shape is now reused for a different child shape. The physics
/// system cannot detect this, so may send a 'contact persisted' callback even though the contact is now on a different child shape. You can
/// detect this by keeping the old shape (before adding/removing a part) around until the next PhysicsSystem::Update (when the OnContactPersisted
/// callbacks are triggered) and resolving the sub shape ID against both the old and new shape to see if they still refer to the same child shape.
/// Generated from method `JPH::ContactListener::OnContactPersisted`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1` can not be null. It is a single object.
/// Parameter `inBody2` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API void JPH_ContactListener_OnContactPersisted(JPH_ContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings);

/// Called whenever a contact was detected last update but is not detected anymore.
///
/// You cannot access the bodies at the time of this callback because:
/// - All bodies are locked at the time of this callback.
/// - Some properties of the bodies are being modified from another thread at the same time.
/// - The body may have been removed and destroyed (you'll receive an OnContactRemoved callback in the PhysicsSystem::Update after the body has been removed).
///
/// Cache what you need in the OnContactAdded and OnContactPersisted callbacks and store it in a separate structure to use during this callback.
/// Alternatively, you could just record that the contact was removed and process it after PhysicsSystem::Update.
///
/// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
///
/// The sub shape IDs were created in the previous simulation step, so if the structure of a shape changes (e.g. by adding/removing a child shape of a compound shape),
/// the sub shape ID may not be valid / may not point to the same sub shape anymore.
/// If you want to know if this is the last contact between the two bodies, use PhysicsSystem::WereBodiesInContact.
/// Generated from method `JPH::ContactListener::OnContactRemoved`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSubShapePair` can not be null. It is a single object.
JOLT_API void JPH_ContactListener_OnContactRemoved(JPH_ContactListener *_this, const JPH_SubShapeIDPair *inSubShapePair);

#ifdef __cplusplus
} // extern "C"
#endif
