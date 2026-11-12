// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_SoftBodyVertex JPH_SoftBodyVertex; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyVertex.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_SoftBodyVertex Jolt_JPH_Array_JPH_SoftBodyVertex; // Defined in `#include <JPH_Array_JPH_SoftBodyVertex.h>`.


/// An interface to query which vertices of a soft body are colliding with other bodies
/// Generated from class `JPH::SoftBodyManifold`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodyManifold JPH_SoftBodyManifold;

/// Generated from constructor `JPH::SoftBodyManifold::SoftBodyManifold`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodyManifold_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodyManifold *JPH_SoftBodyManifold_ConstructFromAnother(const JPH_SoftBodyManifold *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodyManifold *JPH_SoftBodyManifold_OffsetPtr(const JPH_SoftBodyManifold *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodyManifold *JPH_SoftBodyManifold_OffsetMutablePtr(JPH_SoftBodyManifold *ptr, ptrdiff_t i);

/// Destroys a heap-allocated instance of `JPH_SoftBodyManifold`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyManifold_Destroy(const JPH_SoftBodyManifold *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodyManifold`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodyManifold_DestroyArray(const JPH_SoftBodyManifold *_this);

/// Get the vertices of the soft body for iterating
/// Generated from method `JPH::SoftBodyManifold::GetVertices`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const Jolt_JPH_Array_JPH_SoftBodyVertex *JPH_SoftBodyManifold_GetVertices(const JPH_SoftBodyManifold *_this);

/// Check if a vertex has collided with something in this update
/// Generated from method `JPH::SoftBodyManifold::HasContact`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVertex` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodyManifold_HasContact(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex);

/// Get the local space contact point (multiply by GetCenterOfMassTransform() of the soft body to get world space)
/// Generated from method `JPH::SoftBodyManifold::GetLocalContactPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVertex` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyManifold_GetLocalContactPoint(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex);

/// Get the contact normal for the vertex (assumes there is a contact).
/// Generated from method `JPH::SoftBodyManifold::GetContactNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVertex` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_SoftBodyManifold_GetContactNormal(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex);

/// Get the body with which the vertex has collided in this update
/// Generated from method `JPH::SoftBodyManifold::GetContactBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVertex` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_SoftBodyManifold_GetContactBodyID(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex);

/// Get the number of sensors that are in contact with the soft body
/// Generated from method `JPH::SoftBodyManifold::GetNumSensorContacts`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodyManifold_GetNumSensorContacts(const JPH_SoftBodyManifold *_this);

/// Get the i-th sensor that is in contact with the soft body
/// Generated from method `JPH::SoftBodyManifold::GetSensorContactBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_SoftBodyManifold_GetSensorContactBodyID(const JPH_SoftBodyManifold *_this, unsigned int inIndex);

#ifdef __cplusplus
} // extern "C"
#endif
