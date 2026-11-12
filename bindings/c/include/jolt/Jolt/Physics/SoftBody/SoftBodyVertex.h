// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Run time information for a single particle of a soft body
/// Note that at run-time you should only modify the inverse mass and/or velocity of a vertex to control the soft body.
/// Modifying the position can lead to missed collisions.
/// The other members are used internally by the soft body solver.
/// Generated from class `JPH::SoftBodyVertex`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyVertex JPH_SoftBodyVertex;

///< Internal use only. Position at the previous time step
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mPreviousPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SoftBodyVertex_Get_mPreviousPosition(const JPH_SoftBodyVertex *_this);

///< Internal use only. Position at the previous time step
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mPreviousPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mPreviousPosition(JPH_SoftBodyVertex *_this);

///< Position, relative to the center of mass of the soft body
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SoftBodyVertex_Get_mPosition(const JPH_SoftBodyVertex *_this);

///< Position, relative to the center of mass of the soft body
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mPosition(JPH_SoftBodyVertex *_this);

///< Velocity, relative to the center of mass of the soft body
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_SoftBodyVertex_Get_mVelocity(const JPH_SoftBodyVertex *_this);

///< Velocity, relative to the center of mass of the soft body
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mVelocity(JPH_SoftBodyVertex *_this);

///< Internal use only. Nearest collision plane, relative to the center of mass of the soft body
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mCollisionPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Plane *JPH_SoftBodyVertex_Get_mCollisionPlane(const JPH_SoftBodyVertex *_this);

///< Internal use only. Nearest collision plane, relative to the center of mass of the soft body
/// Modifies a member variable of class `JPH::SoftBodyVertex` named `mCollisionPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollisionPlane`.
/// When this function is called, this object will drop object references it held previously in `mCollisionPlane`.
JOLT_API void JPH_SoftBodyVertex_Set_mCollisionPlane(JPH_SoftBodyVertex *_this, const JPH_Plane *value);

///< Internal use only. Nearest collision plane, relative to the center of mass of the soft body
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mCollisionPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Plane *JPH_SoftBodyVertex_GetMutable_mCollisionPlane(JPH_SoftBodyVertex *_this);

///< Internal use only. Index in the colliding shapes list of the body we may collide with
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mCollidingShapeIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const int *JPH_SoftBodyVertex_Get_mCollidingShapeIndex(const JPH_SoftBodyVertex *_this);

///< Internal use only. Index in the colliding shapes list of the body we may collide with
/// Modifies a member variable of class `JPH::SoftBodyVertex` named `mCollidingShapeIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollidingShapeIndex`.
JOLT_API void JPH_SoftBodyVertex_Set_mCollidingShapeIndex(JPH_SoftBodyVertex *_this, int value);

///< Internal use only. Index in the colliding shapes list of the body we may collide with
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mCollidingShapeIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API int *JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex(JPH_SoftBodyVertex *_this);

///< True if the vertex has collided with anything in the last update
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mHasContact`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyVertex_Get_mHasContact(const JPH_SoftBodyVertex *_this);

///< True if the vertex has collided with anything in the last update
/// Modifies a member variable of class `JPH::SoftBodyVertex` named `mHasContact`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mHasContact`.
JOLT_API void JPH_SoftBodyVertex_Set_mHasContact(JPH_SoftBodyVertex *_this, bool value);

///< True if the vertex has collided with anything in the last update
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mHasContact`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyVertex_GetMutable_mHasContact(JPH_SoftBodyVertex *_this);

///< Internal use only. Used while finding the collision plane, stores the largest penetration found so far
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mLargestPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyVertex_Get_mLargestPenetration(const JPH_SoftBodyVertex *_this);

///< Internal use only. Used while finding the collision plane, stores the largest penetration found so far
/// Modifies a member variable of class `JPH::SoftBodyVertex` named `mLargestPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLargestPenetration`.
JOLT_API void JPH_SoftBodyVertex_Set_mLargestPenetration(JPH_SoftBodyVertex *_this, float value);

///< Internal use only. Used while finding the collision plane, stores the largest penetration found so far
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mLargestPenetration`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyVertex_GetMutable_mLargestPenetration(JPH_SoftBodyVertex *_this);

///< Inverse mass (1 / mass)
/// Returns a pointer to a member variable of class `JPH::SoftBodyVertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyVertex_Get_mInvMass(const JPH_SoftBodyVertex *_this);

///< Inverse mass (1 / mass)
/// Modifies a member variable of class `JPH::SoftBodyVertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMass`.
JOLT_API void JPH_SoftBodyVertex_Set_mInvMass(JPH_SoftBodyVertex *_this, float value);

///< Inverse mass (1 / mass)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyVertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyVertex_GetMutable_mInvMass(JPH_SoftBodyVertex *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyVertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyVertex_DestroyArray()`.
/// Use `JPH_SoftBodyVertex_OffsetMutablePtr()` and `JPH_SoftBodyVertex_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::SoftBodyVertex` elementwise.
/// Parameter `mPreviousPosition` can not be null. It is a single object.
/// The reference to the parameter `mPreviousPosition` might be preserved in the constructed object.
/// Parameter `mPosition` can not be null. It is a single object.
/// The reference to the parameter `mPosition` might be preserved in the constructed object.
/// Parameter `mVelocity` can not be null. It is a single object.
/// The reference to the parameter `mVelocity` might be preserved in the constructed object.
/// Parameter `mCollisionPlane` can not be null. It is a single object.
/// The reference to the parameter `mCollisionPlane` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyVertex_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_ConstructFrom(const JPH_Vec3 *mPreviousPosition, const JPH_Vec3 *mPosition, const JPH_Vec3 *mVelocity, const JPH_Plane *mCollisionPlane, int mCollidingShapeIndex, bool mHasContact, float mLargestPenetration, float mInvMass);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyVertex *JPH_SoftBodyVertex_OffsetPtr(const JPH_SoftBodyVertex *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_OffsetMutablePtr(JPH_SoftBodyVertex *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodyVertex::SoftBodyVertex`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyVertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_ConstructFromAnother(const JPH_SoftBodyVertex *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodyVertex`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyVertex_Destroy(const JPH_SoftBodyVertex *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyVertex`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyVertex_DestroyArray(const JPH_SoftBodyVertex *_this);

/// Generated from method `JPH::SoftBodyVertex::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyVertex *JPH_SoftBodyVertex_AssignFromAnother(JPH_SoftBodyVertex *_this, const JPH_SoftBodyVertex *_other);

/// Reset collision information to prepare for a new collision check
/// Generated from method `JPH::SoftBodyVertex::ResetCollision`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyVertex_ResetCollision(JPH_SoftBodyVertex *_this);

#ifdef __cplusplus
} // extern "C"
#endif
