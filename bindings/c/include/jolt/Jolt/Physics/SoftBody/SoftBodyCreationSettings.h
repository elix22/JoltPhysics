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

typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_SoftBodySharedSettings JPH_SoftBodySharedSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h>`.


/// This class contains the information needed to create a soft body object
/// Note: Soft bodies are still in development and come with several caveats. Read the Architecture and API documentation for more information!
/// Generated from class `JPH::SoftBodyCreationSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyCreationSettings JPH_SoftBodyCreationSettings;

/// User data value (can be used by application)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_SoftBodyCreationSettings_Get_mUserData(const JPH_SoftBodyCreationSettings *_this);

/// User data value (can be used by application)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mUserData`.
/// When this function is called, this object will drop object references it held previously in `mUserData`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mUserData(JPH_SoftBodyCreationSettings *_this, uint64_t value);

/// User data value (can be used by application)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_SoftBodyCreationSettings_GetMutable_mUserData(JPH_SoftBodyCreationSettings *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned short *JPH_SoftBodyCreationSettings_Get_mObjectLayer(const JPH_SoftBodyCreationSettings *_this);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mObjectLayer`.
/// When this function is called, this object will drop object references it held previously in `mObjectLayer`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mObjectLayer(JPH_SoftBodyCreationSettings *_this, unsigned short value);

///< The collision layer this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned short *JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer(JPH_SoftBodyCreationSettings *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CollisionGroup *JPH_SoftBodyCreationSettings_Get_mCollisionGroup(const JPH_SoftBodyCreationSettings *_this);

///< The collision group this body belongs to (determines if two objects can collide)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollisionGroup`.
/// When this function is called, this object will drop object references it held previously in `mCollisionGroup`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mCollisionGroup(JPH_SoftBodyCreationSettings *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value);

///< The collision group this body belongs to (determines if two objects can collide)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CollisionGroup *JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup(JPH_SoftBodyCreationSettings *_this);

///< Number of solver iterations
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodyCreationSettings_Get_mNumIterations(const JPH_SoftBodyCreationSettings *_this);

///< Number of solver iterations
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNumIterations`.
/// When this function is called, this object will drop object references it held previously in `mNumIterations`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mNumIterations(JPH_SoftBodyCreationSettings *_this, unsigned int value);

///< Number of solver iterations
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodyCreationSettings_GetMutable_mNumIterations(JPH_SoftBodyCreationSettings *_this);

///< Linear damping: dv/dt = -mLinearDamping * v. Value should be zero or positive and is usually close to 0.
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mLinearDamping(const JPH_SoftBodyCreationSettings *_this);

///< Linear damping: dv/dt = -mLinearDamping * v. Value should be zero or positive and is usually close to 0.
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLinearDamping`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mLinearDamping(JPH_SoftBodyCreationSettings *_this, float value);

///< Linear damping: dv/dt = -mLinearDamping * v. Value should be zero or positive and is usually close to 0.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping(JPH_SoftBodyCreationSettings *_this);

///< Maximum linear velocity that a vertex can reach (m/s)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity(const JPH_SoftBodyCreationSettings *_this);

///< Maximum linear velocity that a vertex can reach (m/s)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxLinearVelocity`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mMaxLinearVelocity(JPH_SoftBodyCreationSettings *_this, float value);

///< Maximum linear velocity that a vertex can reach (m/s)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity(JPH_SoftBodyCreationSettings *_this);

///< Restitution when colliding
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mRestitution(const JPH_SoftBodyCreationSettings *_this);

///< Restitution when colliding
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRestitution`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mRestitution(JPH_SoftBodyCreationSettings *_this, float value);

///< Restitution when colliding
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mRestitution(JPH_SoftBodyCreationSettings *_this);

///< Friction coefficient when colliding
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mFriction(const JPH_SoftBodyCreationSettings *_this);

///< Friction coefficient when colliding
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFriction`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mFriction(JPH_SoftBodyCreationSettings *_this, float value);

///< Friction coefficient when colliding
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mFriction(JPH_SoftBodyCreationSettings *_this);

///< n * R * T, amount of substance * ideal gas constant * absolute temperature, see https://en.wikipedia.org/wiki/Pressure
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mPressure`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mPressure(const JPH_SoftBodyCreationSettings *_this);

///< n * R * T, amount of substance * ideal gas constant * absolute temperature, see https://en.wikipedia.org/wiki/Pressure
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mPressure`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPressure`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mPressure(JPH_SoftBodyCreationSettings *_this, float value);

///< n * R * T, amount of substance * ideal gas constant * absolute temperature, see https://en.wikipedia.org/wiki/Pressure
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mPressure`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mPressure(JPH_SoftBodyCreationSettings *_this);

///< Value to multiply gravity with for this body
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mGravityFactor(const JPH_SoftBodyCreationSettings *_this);

///< Value to multiply gravity with for this body
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mGravityFactor`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mGravityFactor(JPH_SoftBodyCreationSettings *_this, float value);

///< Value to multiply gravity with for this body
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor(JPH_SoftBodyCreationSettings *_this);

///< How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mVertexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyCreationSettings_Get_mVertexRadius(const JPH_SoftBodyCreationSettings *_this);

///< How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mVertexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mVertexRadius`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mVertexRadius(JPH_SoftBodyCreationSettings *_this, float value);

///< How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mVertexRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius(JPH_SoftBodyCreationSettings *_this);

///< Update the position of the body while simulating (set to false for something that is attached to the static world)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mUpdatePosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyCreationSettings_Get_mUpdatePosition(const JPH_SoftBodyCreationSettings *_this);

///< Update the position of the body while simulating (set to false for something that is attached to the static world)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mUpdatePosition`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mUpdatePosition`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mUpdatePosition(JPH_SoftBodyCreationSettings *_this, bool value);

///< Update the position of the body while simulating (set to false for something that is attached to the static world)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mUpdatePosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition(JPH_SoftBodyCreationSettings *_this);

///< Bake specified mRotation in the vertices and set the body rotation to identity (simulation is slightly more accurate if the rotation of a soft body is kept to identity)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mMakeRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity(const JPH_SoftBodyCreationSettings *_this);

///< Bake specified mRotation in the vertices and set the body rotation to identity (simulation is slightly more accurate if the rotation of a soft body is kept to identity)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mMakeRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMakeRotationIdentity`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mMakeRotationIdentity(JPH_SoftBodyCreationSettings *_this, bool value);

///< Bake specified mRotation in the vertices and set the body rotation to identity (simulation is slightly more accurate if the rotation of a soft body is kept to identity)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mMakeRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity(JPH_SoftBodyCreationSettings *_this);

///< If this body can go to sleep or not
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyCreationSettings_Get_mAllowSleeping(const JPH_SoftBodyCreationSettings *_this);

///< If this body can go to sleep or not
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mAllowSleeping`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mAllowSleeping(JPH_SoftBodyCreationSettings *_this, bool value);

///< If this body can go to sleep or not
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mAllowSleeping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping(JPH_SoftBodyCreationSettings *_this);

///< If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
/// Returns a pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mFacesDoubleSided`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided(const JPH_SoftBodyCreationSettings *_this);

///< If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
/// Modifies a member variable of class `JPH::SoftBodyCreationSettings` named `mFacesDoubleSided`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFacesDoubleSided`.
JOLT_API void JPH_SoftBodyCreationSettings_Set_mFacesDoubleSided(JPH_SoftBodyCreationSettings *_this, bool value);

///< If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyCreationSettings` named `mFacesDoubleSided`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided(JPH_SoftBodyCreationSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyCreationSettings_DestroyArray()`.
/// Use `JPH_SoftBodyCreationSettings_OffsetMutablePtr()` and `JPH_SoftBodyCreationSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_OffsetPtr(const JPH_SoftBodyCreationSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_OffsetMutablePtr(JPH_SoftBodyCreationSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodyCreationSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyCreationSettings_Destroy(const JPH_SoftBodyCreationSettings *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyCreationSettings_DestroyArray(const JPH_SoftBodyCreationSettings *_this);

/// Generated from method `JPH::SoftBodyCreationSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_AssignFromAnother(JPH_SoftBodyCreationSettings *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodyCreationSettings *_other);

/// Generated from method `JPH::SoftBodyCreationSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodyCreationSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodyCreationSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodyCreationSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodyCreationSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodyCreationSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodyCreationSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodyCreationSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
