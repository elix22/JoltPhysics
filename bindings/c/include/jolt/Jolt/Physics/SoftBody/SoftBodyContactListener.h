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
typedef struct JPH_SoftBodyManifold JPH_SoftBodyManifold; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyManifold.h>`.


/// Return value for the OnSoftBodyContactValidate callback. Determines if the contact will be processed or not.
typedef enum JPH_SoftBodyValidateResult
{
    ///< Accept this contact
    JPH_SoftBodyValidateResult_AcceptContact = 0,
    ///< Reject this contact
    JPH_SoftBodyValidateResult_RejectContact = 1,
} JPH_SoftBodyValidateResult;

/// Contact settings for a soft body contact.
/// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
/// Generated from class `JPH::SoftBodyContactSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyContactSettings JPH_SoftBodyContactSettings;

/// A listener class that receives collision contact events for soft bodies against rigid bodies.
/// It can be registered with the PhysicsSystem.
/// Generated from class `JPH::SoftBodyContactListener`.
/// Derived classes:
///   Direct: (non-virtual)
///     `SoftBodyContactListenerTrampoline`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyContactListener JPH_SoftBodyContactListener;

///< Scale factor for the inverse mass of the soft body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyContactSettings_Get_mInvMassScale1(const JPH_SoftBodyContactSettings *_this);

///< Scale factor for the inverse mass of the soft body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Modifies a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMassScale1`.
JOLT_API void JPH_SoftBodyContactSettings_Set_mInvMassScale1(JPH_SoftBodyContactSettings *_this, float value);

///< Scale factor for the inverse mass of the soft body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1(JPH_SoftBodyContactSettings *_this);

///< Scale factor for the inverse mass of the other body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyContactSettings_Get_mInvMassScale2(const JPH_SoftBodyContactSettings *_this);

///< Scale factor for the inverse mass of the other body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Modifies a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMassScale2`.
JOLT_API void JPH_SoftBodyContactSettings_Set_mInvMassScale2(JPH_SoftBodyContactSettings *_this, float value);

///< Scale factor for the inverse mass of the other body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvMassScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2(JPH_SoftBodyContactSettings *_this);

///< Scale factor for the inverse inertia of the other body (usually same as mInvMassScale2)
/// Returns a pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodyContactSettings_Get_mInvInertiaScale2(const JPH_SoftBodyContactSettings *_this);

///< Scale factor for the inverse inertia of the other body (usually same as mInvMassScale2)
/// Modifies a member variable of class `JPH::SoftBodyContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvInertiaScale2`.
JOLT_API void JPH_SoftBodyContactSettings_Set_mInvInertiaScale2(JPH_SoftBodyContactSettings *_this, float value);

///< Scale factor for the inverse inertia of the other body (usually same as mInvMassScale2)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mInvInertiaScale2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2(JPH_SoftBodyContactSettings *_this);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Returns a pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_SoftBodyContactSettings_Get_mIsSensor(const JPH_SoftBodyContactSettings *_this);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Modifies a member variable of class `JPH::SoftBodyContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsSensor`.
JOLT_API void JPH_SoftBodyContactSettings_Set_mIsSensor(JPH_SoftBodyContactSettings *_this, bool value);

///< If the contact should be treated as a sensor vs body contact (no collision response)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodyContactSettings` named `mIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_SoftBodyContactSettings_GetMutable_mIsSensor(JPH_SoftBodyContactSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyContactSettings_DestroyArray()`.
/// Use `JPH_SoftBodyContactSettings_OffsetMutablePtr()` and `JPH_SoftBodyContactSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::SoftBodyContactSettings` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyContactSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_ConstructFrom(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_OffsetPtr(const JPH_SoftBodyContactSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_OffsetMutablePtr(JPH_SoftBodyContactSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodyContactSettings::SoftBodyContactSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyContactSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_ConstructFromAnother(const JPH_SoftBodyContactSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodyContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyContactSettings_Destroy(const JPH_SoftBodyContactSettings *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyContactSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyContactSettings_DestroyArray(const JPH_SoftBodyContactSettings *_this);

/// Generated from method `JPH::SoftBodyContactSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_AssignFromAnother(JPH_SoftBodyContactSettings *_this, const JPH_SoftBodyContactSettings *_other);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodyContactListener_DestroyArray()`.
/// Use `JPH_SoftBodyContactListener_OffsetMutablePtr()` and `JPH_SoftBodyContactListener_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_OffsetPtr(const JPH_SoftBodyContactListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_OffsetMutablePtr(JPH_SoftBodyContactListener *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyContactListener_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodyContactListener *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodyContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyContactListener_Destroy(const JPH_SoftBodyContactListener *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyContactListener`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyContactListener_DestroyArray(const JPH_SoftBodyContactListener *_this);

/// Generated from method `JPH::SoftBodyContactListener::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_AssignFromAnother(JPH_SoftBodyContactListener *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodyContactListener *_other);

/// Called whenever the soft body's aabox overlaps with another body's aabox (so receiving this callback doesn't tell if any of the vertices will collide).
/// This callback can be used to change the behavior of the collision response for all vertices in the soft body or to completely reject the contact.
/// Note that this callback is called when all bodies are locked, so don't use any locking functions!
/// @param inSoftBody The soft body that collided. It is safe to access this as the soft body is only updated on the current thread.
/// @param inOtherBody The other body that collided. Note that accessing the position/orientation/velocity of inOtherBody may result in a race condition as other threads may be modifying the body at the same time.
/// @param ioSettings The settings for all contact points that are generated by this collision.
/// @return Whether the contact should be processed or not.
/// Generated from method `JPH::SoftBodyContactListener::OnSoftBodyContactValidate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSoftBody` can not be null. It is a single object.
/// Parameter `inOtherBody` can not be null. It is a single object.
/// Parameter `ioSettings` can not be null. It is a single object.
JOLT_API JPH_SoftBodyValidateResult JPH_SoftBodyContactListener_OnSoftBodyContactValidate(JPH_SoftBodyContactListener *_this, const JPH_Body *inSoftBody, const JPH_Body *inOtherBody, JPH_SoftBodyContactSettings *ioSettings);

/// Called after all contact points for a soft body have been handled.
/// Note that this callback is called when all bodies are locked, so don't use any locking functions!
/// You will receive a single callback for a soft body per simulation step for performance reasons, this callback will apply to all vertices in the soft body.
/// @param inSoftBody The soft body that collided. It is safe to access this as the soft body is only updated on the current thread.
/// @param inManifold The manifold that describes which vertices collide and with what body they collide. Other bodies may be modified by other threads during this callback.
/// Generated from method `JPH::SoftBodyContactListener::OnSoftBodyContactAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSoftBody` can not be null. It is a single object.
/// Parameter `inManifold` can not be null. It is a single object.
JOLT_API void JPH_SoftBodyContactListener_OnSoftBodyContactAdded(JPH_SoftBodyContactListener *_this, const JPH_Body *inSoftBody, const JPH_SoftBodyManifold *inManifold);

#ifdef __cplusplus
} // extern "C"
#endif
