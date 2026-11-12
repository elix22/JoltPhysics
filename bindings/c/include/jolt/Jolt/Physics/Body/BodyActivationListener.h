// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.


/// A listener class that receives events when a body activates or deactivates.
/// It can be registered with the BodyManager (or PhysicsSystem).
/// Generated from class `JPH::BodyActivationListener`.
typedef struct JPH_BodyActivationListener JPH_BodyActivationListener;

/// Destroys a heap-allocated instance of `JPH_BodyActivationListener`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyActivationListener_Destroy(const JPH_BodyActivationListener *_this);

/// Destroys a heap-allocated array of `JPH_BodyActivationListener`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyActivationListener_DestroyArray(const JPH_BodyActivationListener *_this);

/// Called whenever a body activates, note this can be called from any thread so make sure your code is thread safe.
/// At the time of the callback the body inBodyID will be locked and no bodies can be written/activated/deactivated from the callback.
/// Generated from method `JPH::BodyActivationListener::OnBodyActivated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyActivationListener_OnBodyActivated(JPH_BodyActivationListener *_this, const JPH_BodyID *inBodyID, uint64_t inBodyUserData);

/// Called whenever a body deactivates, note this can be called from any thread so make sure your code is thread safe.
/// At the time of the callback the body inBodyID will be locked and no bodies can be written/activated/deactivated from the callback.
/// Generated from method `JPH::BodyActivationListener::OnBodyDeactivated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyActivationListener_OnBodyDeactivated(JPH_BodyActivationListener *_this, const JPH_BodyID *inBodyID, uint64_t inBodyUserData);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BodyActivationListener *JPH_BodyActivationListener_OffsetPtr(const JPH_BodyActivationListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BodyActivationListener *JPH_BodyActivationListener_OffsetMutablePtr(JPH_BodyActivationListener *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
