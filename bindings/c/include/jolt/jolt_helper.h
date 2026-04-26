// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Single-precision 3D vector (velocities, forces, normals).
/// Generated from class `JoltVec3f`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltVec3f JoltVec3f;

/// Double-precision 3D vector (world-space positions).
/// Generated from class `JoltVec3`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltVec3 JoltVec3;

/// Single-precision quaternion (rotation).
/// Generated from class `JoltQuat`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltQuat JoltQuat;

/// Float-precision 4x4 column-major transform matrix.
/// Columns: 0=right(x), 1=up(y), 2=forward(z), 3=translation.
/// Generated from class `JoltMat44`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltMat44 JoltMat44;

/// Real-precision 4x4 transform: float 3x3 rotation + double translation.
/// Columns 0-2 are the rotation axes (float); tx/ty/tz is world-space translation.
/// Generated from class `JoltRMat44`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltRMat44 JoltRMat44;

/// World-space AABB (double-precision min/max).
/// Generated from class `JoltAABox`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltAABox JoltAABox;

/// Body collision group and sub-group IDs (no group filter = all collide).
/// Generated from class `JoltCollisionGroup`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltCollisionGroup JoltCollisionGroup;

/// Non-owning handle to a JPH::PhysicsMaterial.
/// Obtain via JoltBodyInterface::GetMaterial(). Do not outlive the physics system.
/// Generated from class `JoltPhysicsMaterial`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltPhysicsMaterial JoltPhysicsMaterial;

/// Non-owning handle to a JPH::TwoBodyConstraint.
/// Obtain via JoltPhysicsSystem::GetConstraintHandle() or JoltBodyInterface::ActivateConstraint().
/// Generated from class `JoltTwoBodyConstraint`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltTwoBodyConstraint JoltTwoBodyConstraint;

/// Opaque handle to a physics body.
/// Generated from class `JoltBodyID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyID JoltBodyID;

/// Growable list of JoltBodyIDs. Used with batch add/remove on JoltBodyInterface.
/// Generated from class `JoltBodyIDList`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyIDList JoltBodyIDList;

/// Opaque handle to a constraint.
/// Generated from class `JoltConstraintID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltConstraintID JoltConstraintID;

/// Wraps JPH::BodyInterface. Obtain via JoltPhysicsSystem::GetBodyInterface().
/// Generated from class `JoltBodyInterface`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyInterface JoltBodyInterface;

/// Base class for all collision shapes.
/// Shapes are ref-counted; call Release() when you no longer need the handle.
/// Generated from class `JoltShape`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JoltBoxShape`
///     `JoltCapsuleShape`
///     `JoltConvexHullShape`
///     `JoltCylinderShape`
///     `JoltEmptyShape`
///     `JoltHeightFieldShape`
///     `JoltMeshShape`
///     `JoltMutableCompoundShape`
///     `JoltOffsetCenterOfMassShape`
///     `JoltPlaneShape`
///     `JoltRotatedTranslatedShape`
///     `JoltScaledShape`
///     `JoltSphereShape`
///     `JoltStaticCompoundShape`
///     `JoltTaperedCapsuleShape`
///     `JoltTaperedCylinderShape`
///     `JoltTriangleShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltShape JoltShape;

/// Axis-aligned box shape.
/// Generated from class `JoltBoxShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBoxShape JoltBoxShape;

/// Sphere shape.
/// Generated from class `JoltSphereShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltSphereShape JoltSphereShape;

/// Capsule shape (cylinder with hemispherical caps).  halfHeight is the
/// half-height of the cylinder part only (total body height = 2*(halfHeight+radius)).
/// Generated from class `JoltCapsuleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltCapsuleShape JoltCapsuleShape;

/// Upright cylinder shape.
/// Generated from class `JoltCylinderShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltCylinderShape JoltCylinderShape;

/// A shape rotated and translated relative to a child shape.
/// Generated from class `JoltRotatedTranslatedShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltRotatedTranslatedShape JoltRotatedTranslatedShape;

/// Capsule with different radii at each end.
/// Generated from class `JoltTaperedCapsuleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltTaperedCapsuleShape JoltTaperedCapsuleShape;

/// Cylinder with different radii at each end.
/// Generated from class `JoltTaperedCylinderShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltTaperedCylinderShape JoltTaperedCylinderShape;

/// Single triangle shape. Useful for debugging and simple static colliders.
/// Generated from class `JoltTriangleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltTriangleShape JoltTriangleShape;

/// Infinite half-space plane. The plane is defined by a normal (nx, ny, nz) and a signed
/// distance constant d, giving the equation: dot(n, p) + d = 0.
/// halfExtent controls the broad-phase AABB size (default 1000).
/// Generated from class `JoltPlaneShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltPlaneShape JoltPlaneShape;

/// Zero-volume placeholder shape. comX/Y/Z places the center of mass.
/// Generated from class `JoltEmptyShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltEmptyShape JoltEmptyShape;

/// Scales a child shape non-uniformly along each axis.
/// Generated from class `JoltScaledShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltScaledShape JoltScaledShape;

/// Shifts the center-of-mass of a child shape.
/// Generated from class `JoltOffsetCenterOfMassShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltOffsetCenterOfMassShape JoltOffsetCenterOfMassShape;

/// Static (immutable after finalization) compound of multiple child shapes.
/// Call AddSubShape() to build, then Finalize() before using as a shape.
/// Generated from class `JoltStaticCompoundShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltStaticCompoundShape JoltStaticCompoundShape;

/// Mutable compound shape — sub-shapes can be modified after finalization.
/// Call AddSubShape() + Finalize() to build, then use Append/Remove/Modify
/// for runtime changes.
/// Generated from class `JoltMutableCompoundShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltMutableCompoundShape JoltMutableCompoundShape;

/// Triangle-mesh shape (static terrain/level geometry).
/// Call AddVertex() + AddFace() to build, then Finalize().
/// Generated from class `JoltMeshShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltMeshShape JoltMeshShape;

/// Convex hull shape built from a point cloud.
/// Call AddPoint() for each input point, then Finalize(convexRadius).
/// Generated from class `JoltConvexHullShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltConvexHullShape JoltConvexHullShape;

/// Height-field terrain shape (uniform sampleCount × sampleCount grid).
/// Call SetSample() to fill height values, then Finalize().
/// Position of sample (x,y) = offset + scale * (x, height, y).
/// Generated from class `JoltHeightFieldShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `JoltShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltHeightFieldShape JoltHeightFieldShape;

/// Parameters used when adding a body to the physics system.
/// Generated from class `JoltBodyCreationSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyCreationSettings JoltBodyCreationSettings;

/// Defines the mesh topology of a soft body: vertices, faces, edge constraints.
/// Shared (ref-counted) between multiple soft body instances.
/// Build order: AddVertex → AddFace → AddEdgeConstraint (or CalculateEdgeLengths) → Optimize.
/// Generated from class `JoltSoftBodySharedSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltSoftBodySharedSettings JoltSoftBodySharedSettings;

/// Parameters for creating a soft body.
/// Generated from class `JoltSoftBodyCreationSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltSoftBodyCreationSettings JoltSoftBodyCreationSettings;

/// The main Jolt physics simulation. Manages a job system, temp allocator,
/// and the full PhysicsSystem internally. The Jolt library itself is
/// initialised automatically on first construction and cleaned up on last
/// destruction.
/// Generated from class `JoltPhysicsSystem`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltPhysicsSystem JoltPhysicsSystem;

/// Simplified wrapper kept for backward compatibility. Prefer JoltPhysicsSystem
/// for new code.
/// Generated from class `JoltWorld`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltWorld JoltWorld;

/// Returns a pointer to a member variable of class `JoltVec3f` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltVec3f_Get_x(const JoltVec3f *_this);

/// Modifies a member variable of class `JoltVec3f` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JoltVec3f_Set_x(JoltVec3f *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltVec3f` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltVec3f_GetMutable_x(JoltVec3f *_this);

/// Returns a pointer to a member variable of class `JoltVec3f` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltVec3f_Get_y(const JoltVec3f *_this);

/// Modifies a member variable of class `JoltVec3f` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JoltVec3f_Set_y(JoltVec3f *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltVec3f` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltVec3f_GetMutable_y(JoltVec3f *_this);

/// Returns a pointer to a member variable of class `JoltVec3f` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltVec3f_Get_z(const JoltVec3f *_this);

/// Modifies a member variable of class `JoltVec3f` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JoltVec3f_Set_z(JoltVec3f *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltVec3f` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltVec3f_GetMutable_z(JoltVec3f *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltVec3f_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltVec3f_DestroyArray()`.
/// Use `JoltVec3f_OffsetMutablePtr()` and `JoltVec3f_OffsetPtr()` to access the array elements.
JOLT_API JoltVec3f *JoltVec3f_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltVec3f *JoltVec3f_OffsetPtr(const JoltVec3f *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltVec3f *JoltVec3f_OffsetMutablePtr(JoltVec3f *ptr, ptrdiff_t i);

/// Generated from constructor `JoltVec3f::JoltVec3f`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltVec3f_ConstructFromAnother(const JoltVec3f *_other);

/// Generated from constructor `JoltVec3f::JoltVec3f`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltVec3f_Construct(float x, float y, float z);

/// Destroys a heap-allocated instance of `JoltVec3f`. Does nothing if the pointer is null.
JOLT_API void JoltVec3f_Destroy(const JoltVec3f *_this);

/// Destroys a heap-allocated array of `JoltVec3f`. Does nothing if the pointer is null.
JOLT_API void JoltVec3f_DestroyArray(const JoltVec3f *_this);

/// Generated from method `JoltVec3f::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltVec3f *JoltVec3f_AssignFromAnother(JoltVec3f *_this, const JoltVec3f *_other);

/// Returns a pointer to a member variable of class `JoltVec3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltVec3_Get_x(const JoltVec3 *_this);

/// Modifies a member variable of class `JoltVec3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JoltVec3_Set_x(JoltVec3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltVec3` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltVec3_GetMutable_x(JoltVec3 *_this);

/// Returns a pointer to a member variable of class `JoltVec3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltVec3_Get_y(const JoltVec3 *_this);

/// Modifies a member variable of class `JoltVec3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JoltVec3_Set_y(JoltVec3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltVec3` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltVec3_GetMutable_y(JoltVec3 *_this);

/// Returns a pointer to a member variable of class `JoltVec3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltVec3_Get_z(const JoltVec3 *_this);

/// Modifies a member variable of class `JoltVec3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JoltVec3_Set_z(JoltVec3 *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltVec3` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltVec3_GetMutable_z(JoltVec3 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltVec3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltVec3_DestroyArray()`.
/// Use `JoltVec3_OffsetMutablePtr()` and `JoltVec3_OffsetPtr()` to access the array elements.
JOLT_API JoltVec3 *JoltVec3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltVec3 *JoltVec3_OffsetPtr(const JoltVec3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltVec3 *JoltVec3_OffsetMutablePtr(JoltVec3 *ptr, ptrdiff_t i);

/// Generated from constructor `JoltVec3::JoltVec3`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltVec3_ConstructFromAnother(const JoltVec3 *_other);

/// Generated from constructor `JoltVec3::JoltVec3`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltVec3_Construct(double x, double y, double z);

/// Destroys a heap-allocated instance of `JoltVec3`. Does nothing if the pointer is null.
JOLT_API void JoltVec3_Destroy(const JoltVec3 *_this);

/// Destroys a heap-allocated array of `JoltVec3`. Does nothing if the pointer is null.
JOLT_API void JoltVec3_DestroyArray(const JoltVec3 *_this);

/// Generated from method `JoltVec3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltVec3 *JoltVec3_AssignFromAnother(JoltVec3 *_this, const JoltVec3 *_other);

/// Returns a pointer to a member variable of class `JoltQuat` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltQuat_Get_x(const JoltQuat *_this);

/// Modifies a member variable of class `JoltQuat` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `x`.
JOLT_API void JoltQuat_Set_x(JoltQuat *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltQuat` named `x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltQuat_GetMutable_x(JoltQuat *_this);

/// Returns a pointer to a member variable of class `JoltQuat` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltQuat_Get_y(const JoltQuat *_this);

/// Modifies a member variable of class `JoltQuat` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `y`.
JOLT_API void JoltQuat_Set_y(JoltQuat *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltQuat` named `y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltQuat_GetMutable_y(JoltQuat *_this);

/// Returns a pointer to a member variable of class `JoltQuat` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltQuat_Get_z(const JoltQuat *_this);

/// Modifies a member variable of class `JoltQuat` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `z`.
JOLT_API void JoltQuat_Set_z(JoltQuat *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltQuat` named `z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltQuat_GetMutable_z(JoltQuat *_this);

/// Returns a pointer to a member variable of class `JoltQuat` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltQuat_Get_w(const JoltQuat *_this);

/// Modifies a member variable of class `JoltQuat` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `w`.
JOLT_API void JoltQuat_Set_w(JoltQuat *_this, float value);

/// Returns a mutable pointer to a member variable of class `JoltQuat` named `w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltQuat_GetMutable_w(JoltQuat *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltQuat_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltQuat_DestroyArray()`.
/// Use `JoltQuat_OffsetMutablePtr()` and `JoltQuat_OffsetPtr()` to access the array elements.
JOLT_API JoltQuat *JoltQuat_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltQuat *JoltQuat_OffsetPtr(const JoltQuat *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltQuat *JoltQuat_OffsetMutablePtr(JoltQuat *ptr, ptrdiff_t i);

/// Generated from constructor `JoltQuat::JoltQuat`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltQuat_ConstructFromAnother(const JoltQuat *_other);

/// Generated from constructor `JoltQuat::JoltQuat`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltQuat_Construct(float x, float y, float z, float w);

/// Destroys a heap-allocated instance of `JoltQuat`. Does nothing if the pointer is null.
JOLT_API void JoltQuat_Destroy(const JoltQuat *_this);

/// Destroys a heap-allocated array of `JoltQuat`. Does nothing if the pointer is null.
JOLT_API void JoltQuat_DestroyArray(const JoltQuat *_this);

/// Generated from method `JoltQuat::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltQuat *JoltQuat_AssignFromAnother(JoltQuat *_this, const JoltQuat *_other);

/// Generated from method `JoltQuat::Identity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltQuat_Identity(void);

/// Generated from method `JoltQuat::IsNormalized`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltQuat_IsNormalized(const JoltQuat *_this, float tolerance);

/// Generated from method `JoltQuat::RotateAxisX`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltQuat_RotateAxisX(const JoltQuat *_this);

/// Generated from method `JoltQuat::RotateAxisY`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltQuat_RotateAxisY(const JoltQuat *_this);

/// Generated from method `JoltQuat::RotateAxisZ`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltQuat_RotateAxisZ(const JoltQuat *_this);

// column 0
/// Returns a pointer to a member variable of class `JoltMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e00(const JoltMat44 *_this);

// column 0
/// Modifies a member variable of class `JoltMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e00`.
JOLT_API void JoltMat44_Set_e00(JoltMat44 *_this, float value);

// column 0
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e00(JoltMat44 *_this);

// column 0
/// Returns a pointer to a member variable of class `JoltMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e10(const JoltMat44 *_this);

// column 0
/// Modifies a member variable of class `JoltMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e10`.
JOLT_API void JoltMat44_Set_e10(JoltMat44 *_this, float value);

// column 0
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e10(JoltMat44 *_this);

// column 0
/// Returns a pointer to a member variable of class `JoltMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e20(const JoltMat44 *_this);

// column 0
/// Modifies a member variable of class `JoltMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e20`.
JOLT_API void JoltMat44_Set_e20(JoltMat44 *_this, float value);

// column 0
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e20(JoltMat44 *_this);

// column 0
/// Returns a pointer to a member variable of class `JoltMat44` named `e30`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e30(const JoltMat44 *_this);

// column 0
/// Modifies a member variable of class `JoltMat44` named `e30`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e30`.
JOLT_API void JoltMat44_Set_e30(JoltMat44 *_this, float value);

// column 0
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e30`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e30(JoltMat44 *_this);

// column 1
/// Returns a pointer to a member variable of class `JoltMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e01(const JoltMat44 *_this);

// column 1
/// Modifies a member variable of class `JoltMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e01`.
JOLT_API void JoltMat44_Set_e01(JoltMat44 *_this, float value);

// column 1
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e01(JoltMat44 *_this);

// column 1
/// Returns a pointer to a member variable of class `JoltMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e11(const JoltMat44 *_this);

// column 1
/// Modifies a member variable of class `JoltMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e11`.
JOLT_API void JoltMat44_Set_e11(JoltMat44 *_this, float value);

// column 1
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e11(JoltMat44 *_this);

// column 1
/// Returns a pointer to a member variable of class `JoltMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e21(const JoltMat44 *_this);

// column 1
/// Modifies a member variable of class `JoltMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e21`.
JOLT_API void JoltMat44_Set_e21(JoltMat44 *_this, float value);

// column 1
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e21(JoltMat44 *_this);

// column 1
/// Returns a pointer to a member variable of class `JoltMat44` named `e31`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e31(const JoltMat44 *_this);

// column 1
/// Modifies a member variable of class `JoltMat44` named `e31`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e31`.
JOLT_API void JoltMat44_Set_e31(JoltMat44 *_this, float value);

// column 1
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e31`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e31(JoltMat44 *_this);

// column 2
/// Returns a pointer to a member variable of class `JoltMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e02(const JoltMat44 *_this);

// column 2
/// Modifies a member variable of class `JoltMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e02`.
JOLT_API void JoltMat44_Set_e02(JoltMat44 *_this, float value);

// column 2
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e02(JoltMat44 *_this);

// column 2
/// Returns a pointer to a member variable of class `JoltMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e12(const JoltMat44 *_this);

// column 2
/// Modifies a member variable of class `JoltMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e12`.
JOLT_API void JoltMat44_Set_e12(JoltMat44 *_this, float value);

// column 2
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e12(JoltMat44 *_this);

// column 2
/// Returns a pointer to a member variable of class `JoltMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e22(const JoltMat44 *_this);

// column 2
/// Modifies a member variable of class `JoltMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e22`.
JOLT_API void JoltMat44_Set_e22(JoltMat44 *_this, float value);

// column 2
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e22(JoltMat44 *_this);

// column 2
/// Returns a pointer to a member variable of class `JoltMat44` named `e32`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e32(const JoltMat44 *_this);

// column 2
/// Modifies a member variable of class `JoltMat44` named `e32`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e32`.
JOLT_API void JoltMat44_Set_e32(JoltMat44 *_this, float value);

// column 2
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e32`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e32(JoltMat44 *_this);

// column 3 (translation)
/// Returns a pointer to a member variable of class `JoltMat44` named `e03`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e03(const JoltMat44 *_this);

// column 3 (translation)
/// Modifies a member variable of class `JoltMat44` named `e03`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e03`.
JOLT_API void JoltMat44_Set_e03(JoltMat44 *_this, float value);

// column 3 (translation)
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e03`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e03(JoltMat44 *_this);

// column 3 (translation)
/// Returns a pointer to a member variable of class `JoltMat44` named `e13`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e13(const JoltMat44 *_this);

// column 3 (translation)
/// Modifies a member variable of class `JoltMat44` named `e13`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e13`.
JOLT_API void JoltMat44_Set_e13(JoltMat44 *_this, float value);

// column 3 (translation)
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e13`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e13(JoltMat44 *_this);

// column 3 (translation)
/// Returns a pointer to a member variable of class `JoltMat44` named `e23`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e23(const JoltMat44 *_this);

// column 3 (translation)
/// Modifies a member variable of class `JoltMat44` named `e23`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e23`.
JOLT_API void JoltMat44_Set_e23(JoltMat44 *_this, float value);

// column 3 (translation)
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e23`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e23(JoltMat44 *_this);

// column 3 (translation)
/// Returns a pointer to a member variable of class `JoltMat44` named `e33`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltMat44_Get_e33(const JoltMat44 *_this);

// column 3 (translation)
/// Modifies a member variable of class `JoltMat44` named `e33`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e33`.
JOLT_API void JoltMat44_Set_e33(JoltMat44 *_this, float value);

// column 3 (translation)
/// Returns a mutable pointer to a member variable of class `JoltMat44` named `e33`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltMat44_GetMutable_e33(JoltMat44 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltMat44 *JoltMat44_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltMat44_DestroyArray()`.
/// Use `JoltMat44_OffsetMutablePtr()` and `JoltMat44_OffsetPtr()` to access the array elements.
JOLT_API JoltMat44 *JoltMat44_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltMat44 *JoltMat44_OffsetPtr(const JoltMat44 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltMat44 *JoltMat44_OffsetMutablePtr(JoltMat44 *ptr, ptrdiff_t i);

/// Generated from constructor `JoltMat44::JoltMat44`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltMat44 *JoltMat44_ConstructFromAnother(const JoltMat44 *_other);

/// Destroys a heap-allocated instance of `JoltMat44`. Does nothing if the pointer is null.
JOLT_API void JoltMat44_Destroy(const JoltMat44 *_this);

/// Destroys a heap-allocated array of `JoltMat44`. Does nothing if the pointer is null.
JOLT_API void JoltMat44_DestroyArray(const JoltMat44 *_this);

/// Generated from method `JoltMat44::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltMat44 *JoltMat44_AssignFromAnother(JoltMat44 *_this, const JoltMat44 *_other);

/// Generated from method `JoltMat44::Identity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltMat44 *JoltMat44_Identity(void);

/// Generated from method `JoltMat44::GetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltMat44_GetTranslation(const JoltMat44 *_this);

/// Generated from method `JoltMat44::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltMat44_GetRotation(const JoltMat44 *_this);

// column 0 (right)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e00(const JoltRMat44 *_this);

// column 0 (right)
/// Modifies a member variable of class `JoltRMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e00`.
JOLT_API void JoltRMat44_Set_e00(JoltRMat44 *_this, float value);

// column 0 (right)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e00`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e00(JoltRMat44 *_this);

// column 0 (right)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e10(const JoltRMat44 *_this);

// column 0 (right)
/// Modifies a member variable of class `JoltRMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e10`.
JOLT_API void JoltRMat44_Set_e10(JoltRMat44 *_this, float value);

// column 0 (right)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e10`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e10(JoltRMat44 *_this);

// column 0 (right)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e20(const JoltRMat44 *_this);

// column 0 (right)
/// Modifies a member variable of class `JoltRMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e20`.
JOLT_API void JoltRMat44_Set_e20(JoltRMat44 *_this, float value);

// column 0 (right)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e20`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e20(JoltRMat44 *_this);

// column 1 (up)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e01(const JoltRMat44 *_this);

// column 1 (up)
/// Modifies a member variable of class `JoltRMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e01`.
JOLT_API void JoltRMat44_Set_e01(JoltRMat44 *_this, float value);

// column 1 (up)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e01`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e01(JoltRMat44 *_this);

// column 1 (up)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e11(const JoltRMat44 *_this);

// column 1 (up)
/// Modifies a member variable of class `JoltRMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e11`.
JOLT_API void JoltRMat44_Set_e11(JoltRMat44 *_this, float value);

// column 1 (up)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e11`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e11(JoltRMat44 *_this);

// column 1 (up)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e21(const JoltRMat44 *_this);

// column 1 (up)
/// Modifies a member variable of class `JoltRMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e21`.
JOLT_API void JoltRMat44_Set_e21(JoltRMat44 *_this, float value);

// column 1 (up)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e21`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e21(JoltRMat44 *_this);

// column 2 (forward)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e02(const JoltRMat44 *_this);

// column 2 (forward)
/// Modifies a member variable of class `JoltRMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e02`.
JOLT_API void JoltRMat44_Set_e02(JoltRMat44 *_this, float value);

// column 2 (forward)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e02`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e02(JoltRMat44 *_this);

// column 2 (forward)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e12(const JoltRMat44 *_this);

// column 2 (forward)
/// Modifies a member variable of class `JoltRMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e12`.
JOLT_API void JoltRMat44_Set_e12(JoltRMat44 *_this, float value);

// column 2 (forward)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e12`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e12(JoltRMat44 *_this);

// column 2 (forward)
/// Returns a pointer to a member variable of class `JoltRMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JoltRMat44_Get_e22(const JoltRMat44 *_this);

// column 2 (forward)
/// Modifies a member variable of class `JoltRMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `e22`.
JOLT_API void JoltRMat44_Set_e22(JoltRMat44 *_this, float value);

// column 2 (forward)
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `e22`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JoltRMat44_GetMutable_e22(JoltRMat44 *_this);

// world-space translation
/// Returns a pointer to a member variable of class `JoltRMat44` named `tx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltRMat44_Get_tx(const JoltRMat44 *_this);

// world-space translation
/// Modifies a member variable of class `JoltRMat44` named `tx`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `tx`.
JOLT_API void JoltRMat44_Set_tx(JoltRMat44 *_this, double value);

// world-space translation
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `tx`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltRMat44_GetMutable_tx(JoltRMat44 *_this);

// world-space translation
/// Returns a pointer to a member variable of class `JoltRMat44` named `ty`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltRMat44_Get_ty(const JoltRMat44 *_this);

// world-space translation
/// Modifies a member variable of class `JoltRMat44` named `ty`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `ty`.
JOLT_API void JoltRMat44_Set_ty(JoltRMat44 *_this, double value);

// world-space translation
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `ty`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltRMat44_GetMutable_ty(JoltRMat44 *_this);

// world-space translation
/// Returns a pointer to a member variable of class `JoltRMat44` named `tz`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltRMat44_Get_tz(const JoltRMat44 *_this);

// world-space translation
/// Modifies a member variable of class `JoltRMat44` named `tz`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `tz`.
JOLT_API void JoltRMat44_Set_tz(JoltRMat44 *_this, double value);

// world-space translation
/// Returns a mutable pointer to a member variable of class `JoltRMat44` named `tz`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltRMat44_GetMutable_tz(JoltRMat44 *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltRMat44 *JoltRMat44_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltRMat44_DestroyArray()`.
/// Use `JoltRMat44_OffsetMutablePtr()` and `JoltRMat44_OffsetPtr()` to access the array elements.
JOLT_API JoltRMat44 *JoltRMat44_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltRMat44 *JoltRMat44_OffsetPtr(const JoltRMat44 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltRMat44 *JoltRMat44_OffsetMutablePtr(JoltRMat44 *ptr, ptrdiff_t i);

/// Generated from constructor `JoltRMat44::JoltRMat44`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltRMat44 *JoltRMat44_ConstructFromAnother(const JoltRMat44 *_other);

/// Destroys a heap-allocated instance of `JoltRMat44`. Does nothing if the pointer is null.
JOLT_API void JoltRMat44_Destroy(const JoltRMat44 *_this);

/// Destroys a heap-allocated array of `JoltRMat44`. Does nothing if the pointer is null.
JOLT_API void JoltRMat44_DestroyArray(const JoltRMat44 *_this);

/// Generated from method `JoltRMat44::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltRMat44 *JoltRMat44_AssignFromAnother(JoltRMat44 *_this, const JoltRMat44 *_other);

/// Generated from method `JoltRMat44::Identity`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltRMat44 *JoltRMat44_Identity(void);

/// Generated from method `JoltRMat44::GetTranslation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltRMat44_GetTranslation(const JoltRMat44 *_this);

/// Generated from method `JoltRMat44::GetTranslationF`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltRMat44_GetTranslationF(const JoltRMat44 *_this);

/// Generated from method `JoltRMat44::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltRMat44_GetRotation(const JoltRMat44 *_this);

/// Generated from method `JoltRMat44::ToMat44`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltMat44 *JoltRMat44_ToMat44(const JoltRMat44 *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `minX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_minX(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `minX`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `minX`.
JOLT_API void JoltAABox_Set_minX(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `minX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_minX(JoltAABox *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `minY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_minY(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `minY`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `minY`.
JOLT_API void JoltAABox_Set_minY(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `minY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_minY(JoltAABox *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `minZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_minZ(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `minZ`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `minZ`.
JOLT_API void JoltAABox_Set_minZ(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `minZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_minZ(JoltAABox *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `maxX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_maxX(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `maxX`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `maxX`.
JOLT_API void JoltAABox_Set_maxX(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `maxX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_maxX(JoltAABox *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `maxY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_maxY(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `maxY`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `maxY`.
JOLT_API void JoltAABox_Set_maxY(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `maxY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_maxY(JoltAABox *_this);

/// Returns a pointer to a member variable of class `JoltAABox` named `maxZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const double *JoltAABox_Get_maxZ(const JoltAABox *_this);

/// Modifies a member variable of class `JoltAABox` named `maxZ`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `maxZ`.
JOLT_API void JoltAABox_Set_maxZ(JoltAABox *_this, double value);

/// Returns a mutable pointer to a member variable of class `JoltAABox` named `maxZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API double *JoltAABox_GetMutable_maxZ(JoltAABox *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltAABox_Destroy()` to free it when you're done using it.
JOLT_API JoltAABox *JoltAABox_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltAABox_DestroyArray()`.
/// Use `JoltAABox_OffsetMutablePtr()` and `JoltAABox_OffsetPtr()` to access the array elements.
JOLT_API JoltAABox *JoltAABox_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltAABox *JoltAABox_OffsetPtr(const JoltAABox *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltAABox *JoltAABox_OffsetMutablePtr(JoltAABox *ptr, ptrdiff_t i);

/// Generated from constructor `JoltAABox::JoltAABox`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltAABox_Destroy()` to free it when you're done using it.
JOLT_API JoltAABox *JoltAABox_ConstructFromAnother(const JoltAABox *_other);

/// Generated from constructor `JoltAABox::JoltAABox`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltAABox_Destroy()` to free it when you're done using it.
JOLT_API JoltAABox *JoltAABox_Construct(double minX, double minY, double minZ, double maxX, double maxY, double maxZ);

/// Destroys a heap-allocated instance of `JoltAABox`. Does nothing if the pointer is null.
JOLT_API void JoltAABox_Destroy(const JoltAABox *_this);

/// Destroys a heap-allocated array of `JoltAABox`. Does nothing if the pointer is null.
JOLT_API void JoltAABox_DestroyArray(const JoltAABox *_this);

/// Generated from method `JoltAABox::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltAABox *JoltAABox_AssignFromAnother(JoltAABox *_this, const JoltAABox *_other);

/// Generated from method `JoltAABox::GetCenter`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltAABox_GetCenter(const JoltAABox *_this);

/// Generated from method `JoltAABox::GetExtent`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltAABox_GetExtent(const JoltAABox *_this);

/// Generated from method `JoltAABox::Contains`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltAABox_Contains(const JoltAABox *_this, double x, double y, double z);

/// Generated from method `JoltAABox::Overlaps`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
JOLT_API bool JoltAABox_Overlaps(const JoltAABox *_this, const JoltAABox *other);

/// Generated from method `JoltAABox::Encapsulate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltAABox_Encapsulate(JoltAABox *_this, double x, double y, double z);

/// Returns a pointer to a member variable of class `JoltCollisionGroup` named `InvalidGroup`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JoltCollisionGroup_Get_InvalidGroup(void);

/// Returns a pointer to a member variable of class `JoltCollisionGroup` named `InvalidSubGroup`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JoltCollisionGroup_Get_InvalidSubGroup(void);

/// Returns a pointer to a member variable of class `JoltCollisionGroup` named `groupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JoltCollisionGroup_Get_groupID(const JoltCollisionGroup *_this);

/// Modifies a member variable of class `JoltCollisionGroup` named `groupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `groupID`.
/// When this function is called, this object will drop object references it held previously in `groupID`.
JOLT_API void JoltCollisionGroup_Set_groupID(JoltCollisionGroup *_this, unsigned int value);

/// Returns a mutable pointer to a member variable of class `JoltCollisionGroup` named `groupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JoltCollisionGroup_GetMutable_groupID(JoltCollisionGroup *_this);

/// Returns a pointer to a member variable of class `JoltCollisionGroup` named `subGroupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JoltCollisionGroup_Get_subGroupID(const JoltCollisionGroup *_this);

/// Modifies a member variable of class `JoltCollisionGroup` named `subGroupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `subGroupID`.
/// When this function is called, this object will drop object references it held previously in `subGroupID`.
JOLT_API void JoltCollisionGroup_Set_subGroupID(JoltCollisionGroup *_this, unsigned int value);

/// Returns a mutable pointer to a member variable of class `JoltCollisionGroup` named `subGroupID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JoltCollisionGroup_GetMutable_subGroupID(JoltCollisionGroup *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltCollisionGroup_DestroyArray()`.
/// Use `JoltCollisionGroup_OffsetMutablePtr()` and `JoltCollisionGroup_OffsetPtr()` to access the array elements.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltCollisionGroup *JoltCollisionGroup_OffsetPtr(const JoltCollisionGroup *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_OffsetMutablePtr(JoltCollisionGroup *ptr, ptrdiff_t i);

/// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_ConstructFromAnother(const JoltCollisionGroup *_other);

/// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_Construct(unsigned int groupID, unsigned int subGroupID);

/// Destroys a heap-allocated instance of `JoltCollisionGroup`. Does nothing if the pointer is null.
JOLT_API void JoltCollisionGroup_Destroy(const JoltCollisionGroup *_this);

/// Destroys a heap-allocated array of `JoltCollisionGroup`. Does nothing if the pointer is null.
JOLT_API void JoltCollisionGroup_DestroyArray(const JoltCollisionGroup *_this);

/// Generated from method `JoltCollisionGroup::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltCollisionGroup *JoltCollisionGroup_AssignFromAnother(JoltCollisionGroup *_this, const JoltCollisionGroup *_other);

///< JPH::PhysicsMaterial*; nullptr = default material
/// Returns a pointer to a member variable of class `JoltPhysicsMaterial` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltPhysicsMaterial_Get_mPtr(const JoltPhysicsMaterial *_this);

///< JPH::PhysicsMaterial*; nullptr = default material
/// Modifies a member variable of class `JoltPhysicsMaterial` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mPtr`.
/// When this function is called, this object will drop object references it held previously in `mPtr`.
JOLT_API void JoltPhysicsMaterial_Set_mPtr(JoltPhysicsMaterial *_this, void *value);

///< JPH::PhysicsMaterial*; nullptr = default material
/// Returns a mutable pointer to a member variable of class `JoltPhysicsMaterial` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltPhysicsMaterial_GetMutable_mPtr(JoltPhysicsMaterial *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsMaterial *JoltPhysicsMaterial_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltPhysicsMaterial_DestroyArray()`.
/// Use `JoltPhysicsMaterial_OffsetMutablePtr()` and `JoltPhysicsMaterial_OffsetPtr()` to access the array elements.
JOLT_API JoltPhysicsMaterial *JoltPhysicsMaterial_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltPhysicsMaterial *JoltPhysicsMaterial_OffsetPtr(const JoltPhysicsMaterial *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltPhysicsMaterial *JoltPhysicsMaterial_OffsetMutablePtr(JoltPhysicsMaterial *ptr, ptrdiff_t i);

/// Generated from constructor `JoltPhysicsMaterial::JoltPhysicsMaterial`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsMaterial *JoltPhysicsMaterial_ConstructFromAnother(const JoltPhysicsMaterial *_other);

/// Destroys a heap-allocated instance of `JoltPhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JoltPhysicsMaterial_Destroy(const JoltPhysicsMaterial *_this);

/// Destroys a heap-allocated array of `JoltPhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JoltPhysicsMaterial_DestroyArray(const JoltPhysicsMaterial *_this);

/// Generated from method `JoltPhysicsMaterial::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltPhysicsMaterial *JoltPhysicsMaterial_AssignFromAnother(JoltPhysicsMaterial *_this, const JoltPhysicsMaterial *_other);

/// Generated from method `JoltPhysicsMaterial::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltPhysicsMaterial_IsValid(const JoltPhysicsMaterial *_this);

/// Generated from method `JoltPhysicsMaterial::GetDebugName`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const char *JoltPhysicsMaterial_GetDebugName(const JoltPhysicsMaterial *_this);

///< JPH::TwoBodyConstraint*; nullptr = invalid
/// Returns a pointer to a member variable of class `JoltTwoBodyConstraint` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltTwoBodyConstraint_Get_mPtr(const JoltTwoBodyConstraint *_this);

///< JPH::TwoBodyConstraint*; nullptr = invalid
/// Modifies a member variable of class `JoltTwoBodyConstraint` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mPtr`.
/// When this function is called, this object will drop object references it held previously in `mPtr`.
JOLT_API void JoltTwoBodyConstraint_Set_mPtr(JoltTwoBodyConstraint *_this, void *value);

///< JPH::TwoBodyConstraint*; nullptr = invalid
/// Returns a mutable pointer to a member variable of class `JoltTwoBodyConstraint` named `mPtr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltTwoBodyConstraint_GetMutable_mPtr(JoltTwoBodyConstraint *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTwoBodyConstraint_Destroy()` to free it when you're done using it.
JOLT_API JoltTwoBodyConstraint *JoltTwoBodyConstraint_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltTwoBodyConstraint_DestroyArray()`.
/// Use `JoltTwoBodyConstraint_OffsetMutablePtr()` and `JoltTwoBodyConstraint_OffsetPtr()` to access the array elements.
JOLT_API JoltTwoBodyConstraint *JoltTwoBodyConstraint_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltTwoBodyConstraint *JoltTwoBodyConstraint_OffsetPtr(const JoltTwoBodyConstraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltTwoBodyConstraint *JoltTwoBodyConstraint_OffsetMutablePtr(JoltTwoBodyConstraint *ptr, ptrdiff_t i);

/// Generated from constructor `JoltTwoBodyConstraint::JoltTwoBodyConstraint`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTwoBodyConstraint_Destroy()` to free it when you're done using it.
JOLT_API JoltTwoBodyConstraint *JoltTwoBodyConstraint_ConstructFromAnother(const JoltTwoBodyConstraint *_other);

/// Destroys a heap-allocated instance of `JoltTwoBodyConstraint`. Does nothing if the pointer is null.
JOLT_API void JoltTwoBodyConstraint_Destroy(const JoltTwoBodyConstraint *_this);

/// Destroys a heap-allocated array of `JoltTwoBodyConstraint`. Does nothing if the pointer is null.
JOLT_API void JoltTwoBodyConstraint_DestroyArray(const JoltTwoBodyConstraint *_this);

/// Generated from method `JoltTwoBodyConstraint::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltTwoBodyConstraint *JoltTwoBodyConstraint_AssignFromAnother(JoltTwoBodyConstraint *_this, const JoltTwoBodyConstraint *_other);

/// Generated from method `JoltTwoBodyConstraint::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltTwoBodyConstraint_IsValid(const JoltTwoBodyConstraint *_this);

/// Generated from method `JoltTwoBodyConstraint::GetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltTwoBodyConstraint_GetEnabled(const JoltTwoBodyConstraint *_this);

/// Generated from method `JoltTwoBodyConstraint::SetEnabled`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltTwoBodyConstraint_SetEnabled(JoltTwoBodyConstraint *_this, bool enabled);

/// Returns a pointer to a member variable of class `JoltBodyID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JoltBodyID_Get_value(const JoltBodyID *_this);

/// Modifies a member variable of class `JoltBodyID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `value`.
/// When this function is called, this object will drop object references it held previously in `value`.
JOLT_API void JoltBodyID_Set_value(JoltBodyID *_this, unsigned int value);

/// Returns a mutable pointer to a member variable of class `JoltBodyID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JoltBodyID_GetMutable_value(JoltBodyID *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyID_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltBodyID_DestroyArray()`.
/// Use `JoltBodyID_OffsetMutablePtr()` and `JoltBodyID_OffsetPtr()` to access the array elements.
JOLT_API JoltBodyID *JoltBodyID_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltBodyID *JoltBodyID_OffsetPtr(const JoltBodyID *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltBodyID *JoltBodyID_OffsetMutablePtr(JoltBodyID *ptr, ptrdiff_t i);

/// Generated from constructor `JoltBodyID::JoltBodyID`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyID_ConstructFromAnother(const JoltBodyID *_other);

/// Destroys a heap-allocated instance of `JoltBodyID`. Does nothing if the pointer is null.
JOLT_API void JoltBodyID_Destroy(const JoltBodyID *_this);

/// Destroys a heap-allocated array of `JoltBodyID`. Does nothing if the pointer is null.
JOLT_API void JoltBodyID_DestroyArray(const JoltBodyID *_this);

/// Generated from method `JoltBodyID::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltBodyID *JoltBodyID_AssignFromAnother(JoltBodyID *_this, const JoltBodyID *_other);

/// Generated from method `JoltBodyID::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltBodyID_IsValid(const JoltBodyID *_this);

/// Generated from method `JoltBodyID::IsInvalid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltBodyID_IsInvalid(const JoltBodyID *_this);

// points to internal std::vector; do not use directly
/// Returns a pointer to a member variable of class `JoltBodyIDList` named `mData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltBodyIDList_Get_mData(const JoltBodyIDList *_this);

// points to internal std::vector; do not use directly
/// Modifies a member variable of class `JoltBodyIDList` named `mData`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mData`.
/// When this function is called, this object will drop object references it held previously in `mData`.
JOLT_API void JoltBodyIDList_Set_mData(JoltBodyIDList *_this, void *value);

// points to internal std::vector; do not use directly
/// Returns a mutable pointer to a member variable of class `JoltBodyIDList` named `mData`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltBodyIDList_GetMutable_mData(JoltBodyIDList *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyIDList_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyIDList *JoltBodyIDList_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltBodyIDList_DestroyArray()`.
/// Use `JoltBodyIDList_OffsetMutablePtr()` and `JoltBodyIDList_OffsetPtr()` to access the array elements.
JOLT_API JoltBodyIDList *JoltBodyIDList_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltBodyIDList *JoltBodyIDList_OffsetPtr(const JoltBodyIDList *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltBodyIDList *JoltBodyIDList_OffsetMutablePtr(JoltBodyIDList *ptr, ptrdiff_t i);

/// Generated from constructor `JoltBodyIDList::JoltBodyIDList`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyIDList_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyIDList *JoltBodyIDList_ConstructFromAnother(const JoltBodyIDList *_other);

/// Destroys a heap-allocated instance of `JoltBodyIDList`. Does nothing if the pointer is null.
JOLT_API void JoltBodyIDList_Destroy(const JoltBodyIDList *_this);

/// Destroys a heap-allocated array of `JoltBodyIDList`. Does nothing if the pointer is null.
JOLT_API void JoltBodyIDList_DestroyArray(const JoltBodyIDList *_this);

/// Generated from method `JoltBodyIDList::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltBodyIDList *JoltBodyIDList_AssignFromAnother(JoltBodyIDList *_this, const JoltBodyIDList *_other);

/// Generated from method `JoltBodyIDList::Add`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyIDList_Add(JoltBodyIDList *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyIDList::Clear`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyIDList_Clear(JoltBodyIDList *_this);

/// Generated from method `JoltBodyIDList::Count`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JoltBodyIDList_Count(const JoltBodyIDList *_this);

/// Generated from method `JoltBodyIDList::Get`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyIDList_Get(const JoltBodyIDList *_this, int index);

/// Returns a pointer to a member variable of class `JoltConstraintID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JoltConstraintID_Get_value(const JoltConstraintID *_this);

/// Modifies a member variable of class `JoltConstraintID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `value`.
/// When this function is called, this object will drop object references it held previously in `value`.
JOLT_API void JoltConstraintID_Set_value(JoltConstraintID *_this, unsigned int value);

/// Returns a mutable pointer to a member variable of class `JoltConstraintID` named `value`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JoltConstraintID_GetMutable_value(JoltConstraintID *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltConstraintID_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltConstraintID_DestroyArray()`.
/// Use `JoltConstraintID_OffsetMutablePtr()` and `JoltConstraintID_OffsetPtr()` to access the array elements.
JOLT_API JoltConstraintID *JoltConstraintID_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltConstraintID *JoltConstraintID_OffsetPtr(const JoltConstraintID *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltConstraintID *JoltConstraintID_OffsetMutablePtr(JoltConstraintID *ptr, ptrdiff_t i);

/// Generated from constructor `JoltConstraintID::JoltConstraintID`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltConstraintID_ConstructFromAnother(const JoltConstraintID *_other);

/// Destroys a heap-allocated instance of `JoltConstraintID`. Does nothing if the pointer is null.
JOLT_API void JoltConstraintID_Destroy(const JoltConstraintID *_this);

/// Destroys a heap-allocated array of `JoltConstraintID`. Does nothing if the pointer is null.
JOLT_API void JoltConstraintID_DestroyArray(const JoltConstraintID *_this);

/// Generated from method `JoltConstraintID::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltConstraintID *JoltConstraintID_AssignFromAnother(JoltConstraintID *_this, const JoltConstraintID *_other);

/// Generated from method `JoltConstraintID::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltConstraintID_IsValid(const JoltConstraintID *_this);

/// Generated from constructor `JoltBodyInterface::JoltBodyInterface`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyInterface_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyInterface *JoltBodyInterface_ConstructFromAnother(const JoltBodyInterface *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltBodyInterface *JoltBodyInterface_OffsetPtr(const JoltBodyInterface *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltBodyInterface *JoltBodyInterface_OffsetMutablePtr(JoltBodyInterface *ptr, ptrdiff_t i);

/// Destroys a heap-allocated instance of `JoltBodyInterface`. Does nothing if the pointer is null.
JOLT_API void JoltBodyInterface_Destroy(const JoltBodyInterface *_this);

/// Destroys a heap-allocated array of `JoltBodyInterface`. Does nothing if the pointer is null.
JOLT_API void JoltBodyInterface_DestroyArray(const JoltBodyInterface *_this);

/// Generated from method `JoltBodyInterface::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltBodyInterface *JoltBodyInterface_AssignFromAnother(JoltBodyInterface *_this, const JoltBodyInterface *_other);

/// Generated from method `JoltBodyInterface::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_IsValid(const JoltBodyInterface *_this);

/// Create a body but do not add it to the simulation yet.
/// Returns an invalid ID when out of bodies.
/// Generated from method `JoltBodyInterface::CreateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyInterface_CreateBody(JoltBodyInterface *_this, JoltBodyCreationSettings *settings);

/// Create a body with a specific ID (for deterministic/replicated simulations).
/// Returns an invalid ID when the body ID is invalid or already in use.
/// Generated from method `JoltBodyInterface::CreateBodyWithID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `targetID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyInterface_CreateBodyWithID(JoltBodyInterface *_this, const JoltBodyID *targetID, JoltBodyCreationSettings *settings);

/// Create a body and immediately add it to the simulation.
/// Generated from method `JoltBodyInterface::CreateAndAddBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyInterface_CreateAndAddBody(JoltBodyInterface *_this, JoltBodyCreationSettings *settings, int activation);

/// Generated from method `JoltBodyInterface::AddBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddBody(JoltBodyInterface *_this, const JoltBodyID *id, int activation);

/// Generated from method `JoltBodyInterface::RemoveBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_RemoveBody(JoltBodyInterface *_this, const JoltBodyID *id);

/// Destroy a body that has already been removed from the simulation.
/// Generated from method `JoltBodyInterface::DestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_DestroyBody(JoltBodyInterface *_this, const JoltBodyID *id);

/// Remove and destroy in one call.
/// Generated from method `JoltBodyInterface::RemoveAndDestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_RemoveAndDestroyBody(JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::IsAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_IsAdded(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Prepare adding bodies in batch; safe to call from a background thread.
/// Returns an opaque state handle — pass to AddBodiesFinalize or AddBodiesAbort.
/// The JoltBodyIDList must remain unmodified until Finalize/Abort is called.
/// Generated from method `JoltBodyInterface::AddBodiesPrepare`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltBodyInterface_AddBodiesPrepare(JoltBodyInterface *_this, JoltBodyIDList *bodies);

/// Finalize a batch add; atomically inserts all bodies into the simulation.
/// Generated from method `JoltBodyInterface::AddBodiesFinalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddBodiesFinalize(JoltBodyInterface *_this, JoltBodyIDList *bodies, void *addState, int activation);

/// Abort a prepared batch add without inserting bodies.
/// Generated from method `JoltBodyInterface::AddBodiesAbort`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddBodiesAbort(JoltBodyInterface *_this, JoltBodyIDList *bodies, void *addState);

/// Remove multiple bodies from the simulation in one call.
/// Generated from method `JoltBodyInterface::RemoveBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_RemoveBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies);

/// Destroy multiple bodies (must all be removed from the simulation first).
/// Generated from method `JoltBodyInterface::DestroyBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_DestroyBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies);

/// Replace the shape on a body.
/// updateMassProperties: recompute mass/inertia from new shape.
/// Generated from method `JoltBodyInterface::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetShape(const JoltBodyInterface *_this, const JoltBodyID *id, JoltShape *shape, bool updateMassProperties, int activation);

/// Notify systems that a MutableCompoundShape was changed in-place.
/// prevComX/Y/Z: center of mass before the change.
/// Generated from method `JoltBodyInterface::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_NotifyShapeChanged(const JoltBodyInterface *_this, const JoltBodyID *id, double prevComX, double prevComY, double prevComZ, bool updateMassProperties, int activation);

// ---- Position / rotation -------------------------------------------------
/// Generated from method `JoltBodyInterface::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetPosition(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, int activation);

/// Generated from method `JoltBodyInterface::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltBodyInterface_GetPosition(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::GetCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltBodyInterface_GetCenterOfMassPosition(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetRotation(JoltBodyInterface *_this, const JoltBodyID *id, float qx, float qy, float qz, float qw, int activation);

/// Generated from method `JoltBodyInterface::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltBodyInterface_GetRotation(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::GetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Parameter `outPosition` can not be null. It is a single object.
/// Parameter `outRotation` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_GetPositionAndRotation(const JoltBodyInterface *_this, const JoltBodyID *id, JoltVec3 *outPosition, JoltQuat *outRotation);

/// Generated from method `JoltBodyInterface::SetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetPositionAndRotation(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);

/// Like SetPositionAndRotation but only updates when the change is above a small threshold.
/// Generated from method `JoltBodyInterface::SetPositionAndRotationWhenChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetPositionAndRotationWhenChanged(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);

/// Generated from method `JoltBodyInterface::MoveKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_MoveKinematic(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, float deltaTime);

/// Generated from method `JoltBodyInterface::SetPositionRotationAndVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetPositionRotationAndVelocity(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, float lvx, float lvy, float lvz, float avx, float avy, float avz);

// ---- Velocity ------------------------------------------------------------
/// Generated from method `JoltBodyInterface::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz);

/// Generated from method `JoltBodyInterface::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltBodyInterface_GetLinearVelocity(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::AddLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz);

/// Generated from method `JoltBodyInterface::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz);

/// Generated from method `JoltBodyInterface::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltBodyInterface_GetAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetLinearAndAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);

/// Generated from method `JoltBodyInterface::GetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Parameter `outLinear` can not be null. It is a single object.
/// Parameter `outAngular` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_GetLinearAndAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id, JoltVec3f *outLinear, JoltVec3f *outAngular);

/// Generated from method `JoltBodyInterface::AddLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddLinearAndAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);

/// Generated from method `JoltBodyInterface::GetPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltBodyInterface_GetPointVelocity(const JoltBodyInterface *_this, const JoltBodyID *id, double px, double py, double pz);

// ---- Forces / impulses ---------------------------------------------------
/// Generated from method `JoltBodyInterface::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddForce(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz);

/// Generated from method `JoltBodyInterface::AddForceAtPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddForceAtPosition(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz, double px, double py, double pz);

/// Generated from method `JoltBodyInterface::AddTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddTorque(JoltBodyInterface *_this, const JoltBodyID *id, float tx, float ty, float tz);

/// Generated from method `JoltBodyInterface::AddForceAndTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddForceAndTorque(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz, float tx, float ty, float tz);

/// Generated from method `JoltBodyInterface::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddImpulse(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz);

/// Generated from method `JoltBodyInterface::AddImpulseAtPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddImpulseAtPosition(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz, double px, double py, double pz);

/// Generated from method `JoltBodyInterface::AddAngularImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_AddAngularImpulse(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz);

/// Apply a buoyancy impulse. Returns true when the body is in the fluid.
/// surfaceNX/Y/Z: world-space surface normal pointing away from fluid.
/// fluidVX/Y/Z: velocity of the fluid (usually zero for still water).
/// gravX/Y/Z: gravity vector (e.g. 0,-9.81,0).
/// Generated from method `JoltBodyInterface::ApplyBuoyancyImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_ApplyBuoyancyImpulse(JoltBodyInterface *_this, const JoltBodyID *id, double surfacePosX, double surfacePosY, double surfacePosZ, float surfaceNX, float surfaceNY, float surfaceNZ, float buoyancy, float linearDrag, float angularDrag, float fluidVX, float fluidVY, float fluidVZ, float gravX, float gravY, float gravZ, float deltaTime);

/// Returns JoltBodyType_RigidBody or JoltBodyType_SoftBody.
/// Generated from method `JoltBodyInterface::GetBodyType`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API int JoltBodyInterface_GetBodyType(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetMotionType(JoltBodyInterface *_this, const JoltBodyID *id, int motionType, int activation);

/// Returns JoltMotionType_*.
/// Generated from method `JoltBodyInterface::GetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API int JoltBodyInterface_GetMotionType(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetMotionQuality(JoltBodyInterface *_this, const JoltBodyID *id, int motionQuality);

/// Returns JoltMotionQuality_*.
/// Generated from method `JoltBodyInterface::GetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API int JoltBodyInterface_GetMotionQuality(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetObjectLayer(JoltBodyInterface *_this, const JoltBodyID *id, unsigned int layer);

/// Generated from method `JoltBodyInterface::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API unsigned int JoltBodyInterface_GetObjectLayer(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetFriction(JoltBodyInterface *_this, const JoltBodyID *id, float friction);

/// Generated from method `JoltBodyInterface::GetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltBodyInterface_GetFriction(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetRestitution(JoltBodyInterface *_this, const JoltBodyID *id, float restitution);

/// Generated from method `JoltBodyInterface::GetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltBodyInterface_GetRestitution(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetGravityFactor(JoltBodyInterface *_this, const JoltBodyID *id, float factor);

/// Generated from method `JoltBodyInterface::GetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltBodyInterface_GetGravityFactor(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetMaxLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float v);

/// Generated from method `JoltBodyInterface::GetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltBodyInterface_GetMaxLinearVelocity(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetMaxAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float v);

/// Generated from method `JoltBodyInterface::GetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltBodyInterface_GetMaxAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetIsSensor(JoltBodyInterface *_this, const JoltBodyID *id, bool isSensor);

/// Generated from method `JoltBodyInterface::IsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_IsSensor(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetUseManifoldReduction(JoltBodyInterface *_this, const JoltBodyID *id, bool useReduction);

/// Generated from method `JoltBodyInterface::GetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_GetUseManifoldReduction(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API unsigned long long JoltBodyInterface_GetUserData(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetUserData(JoltBodyInterface *_this, const JoltBodyID *id, unsigned long long userData);

// ---- Activation ----------------------------------------------------------
/// Generated from method `JoltBodyInterface::ActivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_ActivateBody(JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::ActivateBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_ActivateBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies);

/// Generated from method `JoltBodyInterface::DeactivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_DeactivateBody(JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::DeactivateBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_DeactivateBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies);

/// Generated from method `JoltBodyInterface::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltBodyInterface_IsActive(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::ResetSleepTimer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_ResetSleepTimer(JoltBodyInterface *_this, const JoltBodyID *id);

// ---- Misc ----------------------------------------------------------------
/// Generated from method `JoltBodyInterface::InvalidateContactCache`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_InvalidateContactCache(JoltBodyInterface *_this, const JoltBodyID *id);

// ---- Transforms ----------------------------------------------------------
/// Generated from method `JoltBodyInterface::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltRMat44 *JoltBodyInterface_GetWorldTransform(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::GetCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltRMat44 *JoltBodyInterface_GetCenterOfMassTransform(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Generated from method `JoltBodyInterface::GetInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMat44_Destroy()` to free it when you're done using it.
JOLT_API JoltMat44 *JoltBodyInterface_GetInverseInertia(const JoltBodyInterface *_this, const JoltBodyID *id);

// ---- Collision group -----------------------------------------------------
/// Generated from method `JoltBodyInterface::SetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Parameter `group` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_SetCollisionGroup(JoltBodyInterface *_this, const JoltBodyID *id, const JoltCollisionGroup *group);

/// Generated from method `JoltBodyInterface::GetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCollisionGroup_Destroy()` to free it when you're done using it.
JOLT_API JoltCollisionGroup *JoltBodyInterface_GetCollisionGroup(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Activate all bodies whose bounding box overlaps box, across all object layers.
/// Generated from method `JoltBodyInterface::ActivateBodiesInAABox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `box` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_ActivateBodiesInAABox(JoltBodyInterface *_this, const JoltAABox *box);

/// Get the material for the body's root sub-shape (works for simple, non-compound shapes).
/// Generated from method `JoltBodyInterface::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsMaterial *JoltBodyInterface_GetMaterial(const JoltBodyInterface *_this, const JoltBodyID *id);

/// Activate non-static bodies attached to a constraint.
/// Generated from method `JoltBodyInterface::ActivateConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `constraint` can not be null. It is a single object.
JOLT_API void JoltBodyInterface_ActivateConstraint(JoltBodyInterface *_this, const JoltTwoBodyConstraint *constraint);

// ---- Soft body -----------------------------------------------------------
/// Generated from method `JoltBodyInterface::CreateSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyInterface_CreateSoftBody(JoltBodyInterface *_this, JoltSoftBodyCreationSettings *settings);

/// Generated from method `JoltBodyInterface::CreateAndAddSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltBodyInterface_CreateAndAddSoftBody(JoltBodyInterface *_this, JoltSoftBodyCreationSettings *settings, int activation);

/// Generated from constructor `JoltShape::JoltShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltShape_Destroy()` to free it when you're done using it.
JOLT_API JoltShape *JoltShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltShape *JoltShape_OffsetPtr(const JoltShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltShape *JoltShape_OffsetMutablePtr(JoltShape *ptr, ptrdiff_t i);

/// Destroys a heap-allocated instance of `JoltShape`. Does nothing if the pointer is null.
JOLT_API void JoltShape_Destroy(const JoltShape *_this);

/// Destroys a heap-allocated array of `JoltShape`. Does nothing if the pointer is null.
JOLT_API void JoltShape_DestroyArray(const JoltShape *_this);

/// Generated from method `JoltShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltShape *JoltShape_AssignFromAnother(JoltShape *_this, Jolt_PassBy _other_pass_by, JoltShape *_other);

/// Generated from method `JoltShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltShape_Release(JoltShape *_this);

/// Generated from method `JoltShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltShape_IsValid(const JoltShape *_this);

/// Generated from method `JoltShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltShape_getHandle(const JoltShape *_this);

/// Generated from constructor `JoltBoxShape::JoltBoxShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBoxShape_Destroy()` to free it when you're done using it.
JOLT_API JoltBoxShape *JoltBoxShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltBoxShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltBoxShape *JoltBoxShape_OffsetPtr(const JoltBoxShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltBoxShape *JoltBoxShape_OffsetMutablePtr(JoltBoxShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltBoxShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltBoxShape_UpcastTo_JoltShape(const JoltBoxShape *object);

/// Upcasts an instance of `JoltBoxShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltBoxShape_MutableUpcastTo_JoltShape(JoltBoxShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltBoxShape *JoltBoxShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltBoxShape *JoltBoxShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltBoxShape *JoltBoxShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltBoxShape *JoltBoxShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltBoxShape *JoltBoxShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltBoxShape *JoltBoxShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltBoxShape::JoltBoxShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBoxShape_Destroy()` to free it when you're done using it.
JOLT_API JoltBoxShape *JoltBoxShape_Construct_4(double halfX, double halfY, double halfZ, float convexRadius);

/// Generated from constructor `JoltBoxShape::JoltBoxShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBoxShape_Destroy()` to free it when you're done using it.
JOLT_API JoltBoxShape *JoltBoxShape_Construct_3(double halfX, double halfY, double halfZ);

/// Destroys a heap-allocated instance of `JoltBoxShape`. Does nothing if the pointer is null.
JOLT_API void JoltBoxShape_Destroy(const JoltBoxShape *_this);

/// Destroys a heap-allocated array of `JoltBoxShape`. Does nothing if the pointer is null.
JOLT_API void JoltBoxShape_DestroyArray(const JoltBoxShape *_this);

/// Generated from method `JoltBoxShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltBoxShape *JoltBoxShape_AssignFromAnother(JoltBoxShape *_this, Jolt_PassBy _other_pass_by, JoltBoxShape *_other);

/// Generated from method `JoltBoxShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBoxShape_Release(JoltBoxShape *_this);

/// Generated from method `JoltBoxShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltBoxShape_IsValid(const JoltBoxShape *_this);

/// Generated from method `JoltBoxShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltBoxShape_getHandle(const JoltBoxShape *_this);

/// Generated from constructor `JoltSphereShape::JoltSphereShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSphereShape_Destroy()` to free it when you're done using it.
JOLT_API JoltSphereShape *JoltSphereShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltSphereShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltSphereShape *JoltSphereShape_OffsetPtr(const JoltSphereShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltSphereShape *JoltSphereShape_OffsetMutablePtr(JoltSphereShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltSphereShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltSphereShape_UpcastTo_JoltShape(const JoltSphereShape *object);

/// Upcasts an instance of `JoltSphereShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltSphereShape_MutableUpcastTo_JoltShape(JoltSphereShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltSphereShape *JoltSphereShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltSphereShape *JoltSphereShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltSphereShape *JoltSphereShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltSphereShape *JoltSphereShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltSphereShape *JoltSphereShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltSphereShape *JoltSphereShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltSphereShape::JoltSphereShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSphereShape_Destroy()` to free it when you're done using it.
JOLT_API JoltSphereShape *JoltSphereShape_Construct(float radius);

/// Destroys a heap-allocated instance of `JoltSphereShape`. Does nothing if the pointer is null.
JOLT_API void JoltSphereShape_Destroy(const JoltSphereShape *_this);

/// Destroys a heap-allocated array of `JoltSphereShape`. Does nothing if the pointer is null.
JOLT_API void JoltSphereShape_DestroyArray(const JoltSphereShape *_this);

/// Generated from method `JoltSphereShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltSphereShape *JoltSphereShape_AssignFromAnother(JoltSphereShape *_this, Jolt_PassBy _other_pass_by, JoltSphereShape *_other);

/// Generated from method `JoltSphereShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSphereShape_Release(JoltSphereShape *_this);

/// Generated from method `JoltSphereShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltSphereShape_IsValid(const JoltSphereShape *_this);

/// Generated from method `JoltSphereShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltSphereShape_getHandle(const JoltSphereShape *_this);

/// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltCapsuleShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltCapsuleShape *JoltCapsuleShape_OffsetPtr(const JoltCapsuleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_OffsetMutablePtr(JoltCapsuleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltCapsuleShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltCapsuleShape_UpcastTo_JoltShape(const JoltCapsuleShape *object);

/// Upcasts an instance of `JoltCapsuleShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltCapsuleShape_MutableUpcastTo_JoltShape(JoltCapsuleShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltCapsuleShape *JoltCapsuleShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltCapsuleShape *JoltCapsuleShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltCapsuleShape *JoltCapsuleShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_Construct(float halfHeight, float radius);

/// Destroys a heap-allocated instance of `JoltCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JoltCapsuleShape_Destroy(const JoltCapsuleShape *_this);

/// Destroys a heap-allocated array of `JoltCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JoltCapsuleShape_DestroyArray(const JoltCapsuleShape *_this);

/// Generated from method `JoltCapsuleShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltCapsuleShape *JoltCapsuleShape_AssignFromAnother(JoltCapsuleShape *_this, Jolt_PassBy _other_pass_by, JoltCapsuleShape *_other);

/// Generated from method `JoltCapsuleShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltCapsuleShape_Release(JoltCapsuleShape *_this);

/// Generated from method `JoltCapsuleShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltCapsuleShape_IsValid(const JoltCapsuleShape *_this);

/// Generated from method `JoltCapsuleShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltCapsuleShape_getHandle(const JoltCapsuleShape *_this);

/// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltCylinderShape *JoltCylinderShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltCylinderShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltCylinderShape *JoltCylinderShape_OffsetPtr(const JoltCylinderShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltCylinderShape *JoltCylinderShape_OffsetMutablePtr(JoltCylinderShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltCylinderShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltCylinderShape_UpcastTo_JoltShape(const JoltCylinderShape *object);

/// Upcasts an instance of `JoltCylinderShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltCylinderShape_MutableUpcastTo_JoltShape(JoltCylinderShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltCylinderShape *JoltCylinderShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltCylinderShape *JoltCylinderShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltCylinderShape *JoltCylinderShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltCylinderShape *JoltCylinderShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltCylinderShape *JoltCylinderShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltCylinderShape *JoltCylinderShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltCylinderShape *JoltCylinderShape_Construct_3(float halfHeight, float radius, float convexRadius);

/// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltCylinderShape *JoltCylinderShape_Construct_2(float halfHeight, float radius);

/// Destroys a heap-allocated instance of `JoltCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JoltCylinderShape_Destroy(const JoltCylinderShape *_this);

/// Destroys a heap-allocated array of `JoltCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JoltCylinderShape_DestroyArray(const JoltCylinderShape *_this);

/// Generated from method `JoltCylinderShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltCylinderShape *JoltCylinderShape_AssignFromAnother(JoltCylinderShape *_this, Jolt_PassBy _other_pass_by, JoltCylinderShape *_other);

/// Generated from method `JoltCylinderShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltCylinderShape_Release(JoltCylinderShape *_this);

/// Generated from method `JoltCylinderShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltCylinderShape_IsValid(const JoltCylinderShape *_this);

/// Generated from method `JoltCylinderShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltCylinderShape_getHandle(const JoltCylinderShape *_this);

/// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRotatedTranslatedShape_Destroy()` to free it when you're done using it.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltRotatedTranslatedShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_OffsetPtr(const JoltRotatedTranslatedShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_OffsetMutablePtr(JoltRotatedTranslatedShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltRotatedTranslatedShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltRotatedTranslatedShape_UpcastTo_JoltShape(const JoltRotatedTranslatedShape *object);

/// Upcasts an instance of `JoltRotatedTranslatedShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltRotatedTranslatedShape_MutableUpcastTo_JoltShape(JoltRotatedTranslatedShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltRotatedTranslatedShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltRotatedTranslatedShape_Destroy()` to free it when you're done using it.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_Construct(JoltShape *inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw);

/// Destroys a heap-allocated instance of `JoltRotatedTranslatedShape`. Does nothing if the pointer is null.
JOLT_API void JoltRotatedTranslatedShape_Destroy(const JoltRotatedTranslatedShape *_this);

/// Destroys a heap-allocated array of `JoltRotatedTranslatedShape`. Does nothing if the pointer is null.
JOLT_API void JoltRotatedTranslatedShape_DestroyArray(const JoltRotatedTranslatedShape *_this);

/// Generated from method `JoltRotatedTranslatedShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_AssignFromAnother(JoltRotatedTranslatedShape *_this, Jolt_PassBy _other_pass_by, JoltRotatedTranslatedShape *_other);

/// Generated from method `JoltRotatedTranslatedShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltRotatedTranslatedShape_Release(JoltRotatedTranslatedShape *_this);

/// Generated from method `JoltRotatedTranslatedShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltRotatedTranslatedShape_IsValid(const JoltRotatedTranslatedShape *_this);

/// Generated from method `JoltRotatedTranslatedShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltRotatedTranslatedShape_getHandle(const JoltRotatedTranslatedShape *_this);

/// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTaperedCapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltTaperedCapsuleShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_OffsetPtr(const JoltTaperedCapsuleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_OffsetMutablePtr(JoltTaperedCapsuleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltTaperedCapsuleShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltTaperedCapsuleShape_UpcastTo_JoltShape(const JoltTaperedCapsuleShape *object);

/// Upcasts an instance of `JoltTaperedCapsuleShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltTaperedCapsuleShape_MutableUpcastTo_JoltShape(JoltTaperedCapsuleShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTaperedCapsuleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_Construct(float halfHeight, float topRadius, float bottomRadius);

/// Destroys a heap-allocated instance of `JoltTaperedCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JoltTaperedCapsuleShape_Destroy(const JoltTaperedCapsuleShape *_this);

/// Destroys a heap-allocated array of `JoltTaperedCapsuleShape`. Does nothing if the pointer is null.
JOLT_API void JoltTaperedCapsuleShape_DestroyArray(const JoltTaperedCapsuleShape *_this);

/// Generated from method `JoltTaperedCapsuleShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltTaperedCapsuleShape *JoltTaperedCapsuleShape_AssignFromAnother(JoltTaperedCapsuleShape *_this, Jolt_PassBy _other_pass_by, JoltTaperedCapsuleShape *_other);

/// Generated from method `JoltTaperedCapsuleShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltTaperedCapsuleShape_Release(JoltTaperedCapsuleShape *_this);

/// Generated from method `JoltTaperedCapsuleShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltTaperedCapsuleShape_IsValid(const JoltTaperedCapsuleShape *_this);

/// Generated from method `JoltTaperedCapsuleShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltTaperedCapsuleShape_getHandle(const JoltTaperedCapsuleShape *_this);

/// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTaperedCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltTaperedCylinderShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltTaperedCylinderShape *JoltTaperedCylinderShape_OffsetPtr(const JoltTaperedCylinderShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_OffsetMutablePtr(JoltTaperedCylinderShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltTaperedCylinderShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltTaperedCylinderShape_UpcastTo_JoltShape(const JoltTaperedCylinderShape *object);

/// Upcasts an instance of `JoltTaperedCylinderShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltTaperedCylinderShape_MutableUpcastTo_JoltShape(JoltTaperedCylinderShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTaperedCylinderShape *JoltTaperedCylinderShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTaperedCylinderShape *JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltTaperedCylinderShape *JoltTaperedCylinderShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTaperedCylinderShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTaperedCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_Construct_4(float halfHeight, float topRadius, float bottomRadius, float convexRadius);

/// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTaperedCylinderShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_Construct_3(float halfHeight, float topRadius, float bottomRadius);

/// Destroys a heap-allocated instance of `JoltTaperedCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JoltTaperedCylinderShape_Destroy(const JoltTaperedCylinderShape *_this);

/// Destroys a heap-allocated array of `JoltTaperedCylinderShape`. Does nothing if the pointer is null.
JOLT_API void JoltTaperedCylinderShape_DestroyArray(const JoltTaperedCylinderShape *_this);

/// Generated from method `JoltTaperedCylinderShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltTaperedCylinderShape *JoltTaperedCylinderShape_AssignFromAnother(JoltTaperedCylinderShape *_this, Jolt_PassBy _other_pass_by, JoltTaperedCylinderShape *_other);

/// Generated from method `JoltTaperedCylinderShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltTaperedCylinderShape_Release(JoltTaperedCylinderShape *_this);

/// Generated from method `JoltTaperedCylinderShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltTaperedCylinderShape_IsValid(const JoltTaperedCylinderShape *_this);

/// Generated from method `JoltTaperedCylinderShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltTaperedCylinderShape_getHandle(const JoltTaperedCylinderShape *_this);

/// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTriangleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTriangleShape *JoltTriangleShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltTriangleShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltTriangleShape *JoltTriangleShape_OffsetPtr(const JoltTriangleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltTriangleShape *JoltTriangleShape_OffsetMutablePtr(JoltTriangleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltTriangleShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltTriangleShape_UpcastTo_JoltShape(const JoltTriangleShape *object);

/// Upcasts an instance of `JoltTriangleShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltTriangleShape_MutableUpcastTo_JoltShape(JoltTriangleShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTriangleShape *JoltTriangleShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTriangleShape *JoltTriangleShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltTriangleShape *JoltTriangleShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltTriangleShape *JoltTriangleShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltTriangleShape *JoltTriangleShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltTriangleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltTriangleShape *JoltTriangleShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTriangleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTriangleShape *JoltTriangleShape_Construct_9(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z);

/// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTriangleShape_Destroy()` to free it when you're done using it.
JOLT_API JoltTriangleShape *JoltTriangleShape_Construct_10(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z, float convexRadius);

/// Destroys a heap-allocated instance of `JoltTriangleShape`. Does nothing if the pointer is null.
JOLT_API void JoltTriangleShape_Destroy(const JoltTriangleShape *_this);

/// Destroys a heap-allocated array of `JoltTriangleShape`. Does nothing if the pointer is null.
JOLT_API void JoltTriangleShape_DestroyArray(const JoltTriangleShape *_this);

/// Generated from method `JoltTriangleShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltTriangleShape *JoltTriangleShape_AssignFromAnother(JoltTriangleShape *_this, Jolt_PassBy _other_pass_by, JoltTriangleShape *_other);

/// Generated from method `JoltTriangleShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltTriangleShape_Release(JoltTriangleShape *_this);

/// Generated from method `JoltTriangleShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltTriangleShape_IsValid(const JoltTriangleShape *_this);

/// Generated from method `JoltTriangleShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltTriangleShape_getHandle(const JoltTriangleShape *_this);

/// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JoltPlaneShape *JoltPlaneShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltPlaneShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltPlaneShape *JoltPlaneShape_OffsetPtr(const JoltPlaneShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltPlaneShape *JoltPlaneShape_OffsetMutablePtr(JoltPlaneShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltPlaneShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltPlaneShape_UpcastTo_JoltShape(const JoltPlaneShape *object);

/// Upcasts an instance of `JoltPlaneShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltPlaneShape_MutableUpcastTo_JoltShape(JoltPlaneShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltPlaneShape *JoltPlaneShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltPlaneShape *JoltPlaneShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltPlaneShape *JoltPlaneShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltPlaneShape *JoltPlaneShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltPlaneShape *JoltPlaneShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltPlaneShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltPlaneShape *JoltPlaneShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JoltPlaneShape *JoltPlaneShape_Construct_5(float nx, float ny, float nz, float d, float halfExtent);

/// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPlaneShape_Destroy()` to free it when you're done using it.
JOLT_API JoltPlaneShape *JoltPlaneShape_Construct_4(float nx, float ny, float nz, float d);

/// Destroys a heap-allocated instance of `JoltPlaneShape`. Does nothing if the pointer is null.
JOLT_API void JoltPlaneShape_Destroy(const JoltPlaneShape *_this);

/// Destroys a heap-allocated array of `JoltPlaneShape`. Does nothing if the pointer is null.
JOLT_API void JoltPlaneShape_DestroyArray(const JoltPlaneShape *_this);

/// Generated from method `JoltPlaneShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltPlaneShape *JoltPlaneShape_AssignFromAnother(JoltPlaneShape *_this, Jolt_PassBy _other_pass_by, JoltPlaneShape *_other);

/// Generated from method `JoltPlaneShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltPlaneShape_Release(JoltPlaneShape *_this);

/// Generated from method `JoltPlaneShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltPlaneShape_IsValid(const JoltPlaneShape *_this);

/// Generated from method `JoltPlaneShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltPlaneShape_getHandle(const JoltPlaneShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltEmptyShape_Destroy()` to free it when you're done using it.
JOLT_API JoltEmptyShape *JoltEmptyShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltEmptyShape_DestroyArray()`.
/// Use `JoltEmptyShape_OffsetMutablePtr()` and `JoltEmptyShape_OffsetPtr()` to access the array elements.
JOLT_API JoltEmptyShape *JoltEmptyShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltEmptyShape *JoltEmptyShape_OffsetPtr(const JoltEmptyShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltEmptyShape *JoltEmptyShape_OffsetMutablePtr(JoltEmptyShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltEmptyShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltEmptyShape_UpcastTo_JoltShape(const JoltEmptyShape *object);

/// Upcasts an instance of `JoltEmptyShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltEmptyShape_MutableUpcastTo_JoltShape(JoltEmptyShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltEmptyShape *JoltEmptyShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltEmptyShape *JoltEmptyShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltEmptyShape *JoltEmptyShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltEmptyShape *JoltEmptyShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltEmptyShape *JoltEmptyShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltEmptyShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltEmptyShape *JoltEmptyShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltEmptyShape_Destroy()` to free it when you're done using it.
JOLT_API JoltEmptyShape *JoltEmptyShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltEmptyShape *_other);

/// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltEmptyShape_Destroy()` to free it when you're done using it.
JOLT_API JoltEmptyShape *JoltEmptyShape_Construct(float comX, float comY, float comZ);

/// Destroys a heap-allocated instance of `JoltEmptyShape`. Does nothing if the pointer is null.
JOLT_API void JoltEmptyShape_Destroy(const JoltEmptyShape *_this);

/// Destroys a heap-allocated array of `JoltEmptyShape`. Does nothing if the pointer is null.
JOLT_API void JoltEmptyShape_DestroyArray(const JoltEmptyShape *_this);

/// Generated from method `JoltEmptyShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltEmptyShape *JoltEmptyShape_AssignFromAnother(JoltEmptyShape *_this, Jolt_PassBy _other_pass_by, JoltEmptyShape *_other);

/// Generated from method `JoltEmptyShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltEmptyShape_Release(JoltEmptyShape *_this);

/// Generated from method `JoltEmptyShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltEmptyShape_IsValid(const JoltEmptyShape *_this);

/// Generated from method `JoltEmptyShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltEmptyShape_getHandle(const JoltEmptyShape *_this);

/// Generated from constructor `JoltScaledShape::JoltScaledShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltScaledShape_Destroy()` to free it when you're done using it.
JOLT_API JoltScaledShape *JoltScaledShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltScaledShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltScaledShape *JoltScaledShape_OffsetPtr(const JoltScaledShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltScaledShape *JoltScaledShape_OffsetMutablePtr(JoltScaledShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltScaledShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltScaledShape_UpcastTo_JoltShape(const JoltScaledShape *object);

/// Upcasts an instance of `JoltScaledShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltScaledShape_MutableUpcastTo_JoltShape(JoltScaledShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltScaledShape *JoltScaledShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltScaledShape *JoltScaledShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltScaledShape *JoltScaledShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltScaledShape *JoltScaledShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltScaledShape *JoltScaledShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltScaledShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltScaledShape *JoltScaledShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltScaledShape::JoltScaledShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltScaledShape_Destroy()` to free it when you're done using it.
JOLT_API JoltScaledShape *JoltScaledShape_Construct(JoltShape *inner, float sx, float sy, float sz);

/// Destroys a heap-allocated instance of `JoltScaledShape`. Does nothing if the pointer is null.
JOLT_API void JoltScaledShape_Destroy(const JoltScaledShape *_this);

/// Destroys a heap-allocated array of `JoltScaledShape`. Does nothing if the pointer is null.
JOLT_API void JoltScaledShape_DestroyArray(const JoltScaledShape *_this);

/// Generated from method `JoltScaledShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltScaledShape *JoltScaledShape_AssignFromAnother(JoltScaledShape *_this, Jolt_PassBy _other_pass_by, JoltScaledShape *_other);

/// Generated from method `JoltScaledShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltScaledShape_Release(JoltScaledShape *_this);

/// Generated from method `JoltScaledShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltScaledShape_IsValid(const JoltScaledShape *_this);

/// Generated from method `JoltScaledShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltScaledShape_getHandle(const JoltScaledShape *_this);

/// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltOffsetCenterOfMassShape_Destroy()` to free it when you're done using it.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltOffsetCenterOfMassShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_OffsetPtr(const JoltOffsetCenterOfMassShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_OffsetMutablePtr(JoltOffsetCenterOfMassShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltOffsetCenterOfMassShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltOffsetCenterOfMassShape_UpcastTo_JoltShape(const JoltOffsetCenterOfMassShape *object);

/// Upcasts an instance of `JoltOffsetCenterOfMassShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltOffsetCenterOfMassShape_MutableUpcastTo_JoltShape(JoltOffsetCenterOfMassShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltOffsetCenterOfMassShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltOffsetCenterOfMassShape_Destroy()` to free it when you're done using it.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_Construct(JoltShape *inner, float offsetX, float offsetY, float offsetZ);

/// Destroys a heap-allocated instance of `JoltOffsetCenterOfMassShape`. Does nothing if the pointer is null.
JOLT_API void JoltOffsetCenterOfMassShape_Destroy(const JoltOffsetCenterOfMassShape *_this);

/// Destroys a heap-allocated array of `JoltOffsetCenterOfMassShape`. Does nothing if the pointer is null.
JOLT_API void JoltOffsetCenterOfMassShape_DestroyArray(const JoltOffsetCenterOfMassShape *_this);

/// Generated from method `JoltOffsetCenterOfMassShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltOffsetCenterOfMassShape *JoltOffsetCenterOfMassShape_AssignFromAnother(JoltOffsetCenterOfMassShape *_this, Jolt_PassBy _other_pass_by, JoltOffsetCenterOfMassShape *_other);

/// Generated from method `JoltOffsetCenterOfMassShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltOffsetCenterOfMassShape_Release(JoltOffsetCenterOfMassShape *_this);

/// Generated from method `JoltOffsetCenterOfMassShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltOffsetCenterOfMassShape_IsValid(const JoltOffsetCenterOfMassShape *_this);

/// Generated from method `JoltOffsetCenterOfMassShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltOffsetCenterOfMassShape_getHandle(const JoltOffsetCenterOfMassShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltStaticCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltStaticCompoundShape_DestroyArray()`.
/// Use `JoltStaticCompoundShape_OffsetMutablePtr()` and `JoltStaticCompoundShape_OffsetPtr()` to access the array elements.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltStaticCompoundShape *JoltStaticCompoundShape_OffsetPtr(const JoltStaticCompoundShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_OffsetMutablePtr(JoltStaticCompoundShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltStaticCompoundShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltStaticCompoundShape_UpcastTo_JoltShape(const JoltStaticCompoundShape *object);

/// Upcasts an instance of `JoltStaticCompoundShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltStaticCompoundShape_MutableUpcastTo_JoltShape(JoltStaticCompoundShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltStaticCompoundShape *JoltStaticCompoundShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltStaticCompoundShape *JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltStaticCompoundShape *JoltStaticCompoundShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltStaticCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltStaticCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltStaticCompoundShape *_other);

/// Destroys a heap-allocated instance of `JoltStaticCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JoltStaticCompoundShape_Destroy(const JoltStaticCompoundShape *_this);

/// Destroys a heap-allocated array of `JoltStaticCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JoltStaticCompoundShape_DestroyArray(const JoltStaticCompoundShape *_this);

/// Generated from method `JoltStaticCompoundShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltStaticCompoundShape *JoltStaticCompoundShape_AssignFromAnother(JoltStaticCompoundShape *_this, Jolt_PassBy _other_pass_by, JoltStaticCompoundShape *_other);

/// Generated from method `JoltStaticCompoundShape::AddSubShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltStaticCompoundShape_AddSubShape(JoltStaticCompoundShape *_this, JoltShape *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);

/// Generated from method `JoltStaticCompoundShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltStaticCompoundShape_Finalize(JoltStaticCompoundShape *_this);

/// Generated from method `JoltStaticCompoundShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltStaticCompoundShape_Release(JoltStaticCompoundShape *_this);

/// Generated from method `JoltStaticCompoundShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltStaticCompoundShape_IsValid(const JoltStaticCompoundShape *_this);

/// Generated from method `JoltStaticCompoundShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltStaticCompoundShape_getHandle(const JoltStaticCompoundShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMutableCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltMutableCompoundShape_DestroyArray()`.
/// Use `JoltMutableCompoundShape_OffsetMutablePtr()` and `JoltMutableCompoundShape_OffsetPtr()` to access the array elements.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltMutableCompoundShape *JoltMutableCompoundShape_OffsetPtr(const JoltMutableCompoundShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_OffsetMutablePtr(JoltMutableCompoundShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltMutableCompoundShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltMutableCompoundShape_UpcastTo_JoltShape(const JoltMutableCompoundShape *object);

/// Upcasts an instance of `JoltMutableCompoundShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltMutableCompoundShape_MutableUpcastTo_JoltShape(JoltMutableCompoundShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltMutableCompoundShape *JoltMutableCompoundShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltMutableCompoundShape *JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltMutableCompoundShape *JoltMutableCompoundShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMutableCompoundShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMutableCompoundShape_Destroy()` to free it when you're done using it.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltMutableCompoundShape *_other);

/// Destroys a heap-allocated instance of `JoltMutableCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JoltMutableCompoundShape_Destroy(const JoltMutableCompoundShape *_this);

/// Destroys a heap-allocated array of `JoltMutableCompoundShape`. Does nothing if the pointer is null.
JOLT_API void JoltMutableCompoundShape_DestroyArray(const JoltMutableCompoundShape *_this);

/// Generated from method `JoltMutableCompoundShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltMutableCompoundShape *JoltMutableCompoundShape_AssignFromAnother(JoltMutableCompoundShape *_this, Jolt_PassBy _other_pass_by, JoltMutableCompoundShape *_other);

/// Add a sub-shape during the build phase (before Finalize).
/// Generated from method `JoltMutableCompoundShape::AddSubShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMutableCompoundShape_AddSubShape(JoltMutableCompoundShape *_this, JoltShape *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);

/// Generated from method `JoltMutableCompoundShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMutableCompoundShape_Finalize(JoltMutableCompoundShape *_this);

/// Append a sub-shape at runtime (after Finalize). Returns the sub-shape index.
/// Generated from method `JoltMutableCompoundShape::AppendSubShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JoltMutableCompoundShape_AppendSubShape(JoltMutableCompoundShape *_this, JoltShape *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);

/// Generated from method `JoltMutableCompoundShape::RemoveSubShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMutableCompoundShape_RemoveSubShape(JoltMutableCompoundShape *_this, unsigned int index);

/// Generated from method `JoltMutableCompoundShape::ModifySubShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMutableCompoundShape_ModifySubShape(JoltMutableCompoundShape *_this, unsigned int index, double px, double py, double pz, float qx, float qy, float qz, float qw);

/// Generated from method `JoltMutableCompoundShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMutableCompoundShape_Release(JoltMutableCompoundShape *_this);

/// Generated from method `JoltMutableCompoundShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltMutableCompoundShape_IsValid(const JoltMutableCompoundShape *_this);

/// Generated from method `JoltMutableCompoundShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltMutableCompoundShape_getHandle(const JoltMutableCompoundShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMeshShape_Destroy()` to free it when you're done using it.
JOLT_API JoltMeshShape *JoltMeshShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltMeshShape_DestroyArray()`.
/// Use `JoltMeshShape_OffsetMutablePtr()` and `JoltMeshShape_OffsetPtr()` to access the array elements.
JOLT_API JoltMeshShape *JoltMeshShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltMeshShape *JoltMeshShape_OffsetPtr(const JoltMeshShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltMeshShape *JoltMeshShape_OffsetMutablePtr(JoltMeshShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltMeshShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltMeshShape_UpcastTo_JoltShape(const JoltMeshShape *object);

/// Upcasts an instance of `JoltMeshShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltMeshShape_MutableUpcastTo_JoltShape(JoltMeshShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltMeshShape *JoltMeshShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltMeshShape *JoltMeshShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltMeshShape *JoltMeshShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltMeshShape *JoltMeshShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltMeshShape *JoltMeshShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltMeshShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltMeshShape *JoltMeshShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltMeshShape::JoltMeshShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltMeshShape_Destroy()` to free it when you're done using it.
JOLT_API JoltMeshShape *JoltMeshShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltMeshShape *_other);

/// Destroys a heap-allocated instance of `JoltMeshShape`. Does nothing if the pointer is null.
JOLT_API void JoltMeshShape_Destroy(const JoltMeshShape *_this);

/// Destroys a heap-allocated array of `JoltMeshShape`. Does nothing if the pointer is null.
JOLT_API void JoltMeshShape_DestroyArray(const JoltMeshShape *_this);

/// Generated from method `JoltMeshShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltMeshShape *JoltMeshShape_AssignFromAnother(JoltMeshShape *_this, Jolt_PassBy _other_pass_by, JoltMeshShape *_other);

/// Generated from method `JoltMeshShape::AddVertex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMeshShape_AddVertex(JoltMeshShape *_this, float x, float y, float z);

/// Generated from method `JoltMeshShape::AddFace`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMeshShape_AddFace(JoltMeshShape *_this, unsigned int v0, unsigned int v1, unsigned int v2);

/// Generated from method `JoltMeshShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMeshShape_Finalize(JoltMeshShape *_this);

/// Generated from method `JoltMeshShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltMeshShape_Release(JoltMeshShape *_this);

/// Generated from method `JoltMeshShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltMeshShape_IsValid(const JoltMeshShape *_this);

/// Generated from method `JoltMeshShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltMeshShape_getHandle(const JoltMeshShape *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConvexHullShape_Destroy()` to free it when you're done using it.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltConvexHullShape_DestroyArray()`.
/// Use `JoltConvexHullShape_OffsetMutablePtr()` and `JoltConvexHullShape_OffsetPtr()` to access the array elements.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltConvexHullShape *JoltConvexHullShape_OffsetPtr(const JoltConvexHullShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_OffsetMutablePtr(JoltConvexHullShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltConvexHullShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltConvexHullShape_UpcastTo_JoltShape(const JoltConvexHullShape *object);

/// Upcasts an instance of `JoltConvexHullShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltConvexHullShape_MutableUpcastTo_JoltShape(JoltConvexHullShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltConvexHullShape *JoltConvexHullShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltConvexHullShape *JoltConvexHullShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltConvexHullShape *JoltConvexHullShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltConvexHullShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConvexHullShape_Destroy()` to free it when you're done using it.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltConvexHullShape *_other);

/// Destroys a heap-allocated instance of `JoltConvexHullShape`. Does nothing if the pointer is null.
JOLT_API void JoltConvexHullShape_Destroy(const JoltConvexHullShape *_this);

/// Destroys a heap-allocated array of `JoltConvexHullShape`. Does nothing if the pointer is null.
JOLT_API void JoltConvexHullShape_DestroyArray(const JoltConvexHullShape *_this);

/// Generated from method `JoltConvexHullShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltConvexHullShape *JoltConvexHullShape_AssignFromAnother(JoltConvexHullShape *_this, Jolt_PassBy _other_pass_by, JoltConvexHullShape *_other);

/// Generated from method `JoltConvexHullShape::AddPoint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltConvexHullShape_AddPoint(JoltConvexHullShape *_this, float x, float y, float z);

/// Generated from method `JoltConvexHullShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltConvexHullShape_Finalize_1(JoltConvexHullShape *_this, float convexRadius);

/// Generated from method `JoltConvexHullShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltConvexHullShape_Finalize_0(JoltConvexHullShape *_this);

/// Generated from method `JoltConvexHullShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltConvexHullShape_Release(JoltConvexHullShape *_this);

/// Generated from method `JoltConvexHullShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltConvexHullShape_IsValid(const JoltConvexHullShape *_this);

/// Generated from method `JoltConvexHullShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltConvexHullShape_getHandle(const JoltConvexHullShape *_this);

/// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHeightFieldShape_Destroy()` to free it when you're done using it.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltHeightFieldShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltHeightFieldShape *JoltHeightFieldShape_OffsetPtr(const JoltHeightFieldShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_OffsetMutablePtr(JoltHeightFieldShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `JoltHeightFieldShape` to its base class `JoltShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltShape *JoltHeightFieldShape_UpcastTo_JoltShape(const JoltHeightFieldShape *object);

/// Upcasts an instance of `JoltHeightFieldShape` to its base class `JoltShape`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltShape *JoltHeightFieldShape_MutableUpcastTo_JoltShape(JoltHeightFieldShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltHeightFieldShape *JoltHeightFieldShape_StaticDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JoltHeightFieldShape *JoltHeightFieldShape_DynamicDowncastFrom_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JoltHeightFieldShape *JoltHeightFieldShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object);

/// Downcasts an instance of `JoltShape` to a derived class `JoltHeightFieldShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object);

/// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHeightFieldShape_Destroy()` to free it when you're done using it.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_Construct(unsigned int sampleCount, float offsetX, float offsetY, float offsetZ, float scaleX, float scaleY, float scaleZ);

/// Destroys a heap-allocated instance of `JoltHeightFieldShape`. Does nothing if the pointer is null.
JOLT_API void JoltHeightFieldShape_Destroy(const JoltHeightFieldShape *_this);

/// Destroys a heap-allocated array of `JoltHeightFieldShape`. Does nothing if the pointer is null.
JOLT_API void JoltHeightFieldShape_DestroyArray(const JoltHeightFieldShape *_this);

/// Generated from method `JoltHeightFieldShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltHeightFieldShape *JoltHeightFieldShape_AssignFromAnother(JoltHeightFieldShape *_this, Jolt_PassBy _other_pass_by, JoltHeightFieldShape *_other);

/// Generated from method `JoltHeightFieldShape::SetSample`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltHeightFieldShape_SetSample(JoltHeightFieldShape *_this, unsigned int x, unsigned int y, float height);

/// Generated from method `JoltHeightFieldShape::Finalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltHeightFieldShape_Finalize(JoltHeightFieldShape *_this);

/// Generated from method `JoltHeightFieldShape::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltHeightFieldShape_Release(JoltHeightFieldShape *_this);

/// Generated from method `JoltHeightFieldShape::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JoltHeightFieldShape_IsValid(const JoltHeightFieldShape *_this);

/// Generated from method `JoltHeightFieldShape::getHandle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JoltHeightFieldShape_getHandle(const JoltHeightFieldShape *_this);

/// Returns a pointer to a member variable of class `JoltBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltBodyCreationSettings_Get_mHandle(const JoltBodyCreationSettings *_this);

/// Modifies a member variable of class `JoltBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mHandle`.
/// When this function is called, this object will drop object references it held previously in `mHandle`.
JOLT_API void JoltBodyCreationSettings_Set_mHandle(JoltBodyCreationSettings *_this, void *value);

/// Returns a mutable pointer to a member variable of class `JoltBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltBodyCreationSettings_GetMutable_mHandle(JoltBodyCreationSettings *_this);

/// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyCreationSettings *JoltBodyCreationSettings_ConstructFromAnother(const JoltBodyCreationSettings *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltBodyCreationSettings *JoltBodyCreationSettings_OffsetPtr(const JoltBodyCreationSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltBodyCreationSettings *JoltBodyCreationSettings_OffsetMutablePtr(JoltBodyCreationSettings *ptr, ptrdiff_t i);

/// Create settings for a body with the given shape.
/// layer should be one of JoltObjectLayer values (0=NonMoving, 1=Moving).
/// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyCreationSettings *JoltBodyCreationSettings_Construct_10(JoltShape *shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, unsigned int objectLayer);

/// Shorthand: identity rotation.
/// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyCreationSettings *JoltBodyCreationSettings_Construct_6(JoltShape *shape, double posX, double posY, double posZ, int motionType, unsigned int objectLayer);

/// Destroys a heap-allocated instance of `JoltBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JoltBodyCreationSettings_Destroy(const JoltBodyCreationSettings *_this);

/// Destroys a heap-allocated array of `JoltBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JoltBodyCreationSettings_DestroyArray(const JoltBodyCreationSettings *_this);

/// Generated from method `JoltBodyCreationSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltBodyCreationSettings *JoltBodyCreationSettings_AssignFromAnother(JoltBodyCreationSettings *_this, const JoltBodyCreationSettings *_other);

/// Generated from method `JoltBodyCreationSettings::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetPosition(JoltBodyCreationSettings *_this, double x, double y, double z);

/// Generated from method `JoltBodyCreationSettings::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetRotation(JoltBodyCreationSettings *_this, float qx, float qy, float qz, float qw);

/// Generated from method `JoltBodyCreationSettings::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetLinearVelocity(JoltBodyCreationSettings *_this, float vx, float vy, float vz);

/// Generated from method `JoltBodyCreationSettings::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetAngularVelocity(JoltBodyCreationSettings *_this, float vx, float vy, float vz);

/// Generated from method `JoltBodyCreationSettings::SetFriction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetFriction(JoltBodyCreationSettings *_this, float f);

/// Generated from method `JoltBodyCreationSettings::SetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetRestitution(JoltBodyCreationSettings *_this, float r);

/// Generated from method `JoltBodyCreationSettings::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetGravityFactor(JoltBodyCreationSettings *_this, float f);

/// Generated from method `JoltBodyCreationSettings::SetIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetIsSensor(JoltBodyCreationSettings *_this, bool isSensor);

/// Generated from method `JoltBodyCreationSettings::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltBodyCreationSettings_SetObjectLayer(JoltBodyCreationSettings *_this, unsigned int layer);

///< internal SBSSHandle*; do not use directly
/// Returns a pointer to a member variable of class `JoltSoftBodySharedSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltSoftBodySharedSettings_Get_mHandle(const JoltSoftBodySharedSettings *_this);

///< internal SBSSHandle*; do not use directly
/// Modifies a member variable of class `JoltSoftBodySharedSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mHandle`.
/// When this function is called, this object will drop object references it held previously in `mHandle`.
JOLT_API void JoltSoftBodySharedSettings_Set_mHandle(JoltSoftBodySharedSettings *_this, void *value);

///< internal SBSSHandle*; do not use directly
/// Returns a mutable pointer to a member variable of class `JoltSoftBodySharedSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltSoftBodySharedSettings_GetMutable_mHandle(JoltSoftBodySharedSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltSoftBodySharedSettings_DestroyArray()`.
/// Use `JoltSoftBodySharedSettings_OffsetMutablePtr()` and `JoltSoftBodySharedSettings_OffsetPtr()` to access the array elements.
JOLT_API JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_OffsetPtr(const JoltSoftBodySharedSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_OffsetMutablePtr(JoltSoftBodySharedSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JoltSoftBodySharedSettings::JoltSoftBodySharedSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_ConstructFromAnother(const JoltSoftBodySharedSettings *_other);

/// Destroys a heap-allocated instance of `JoltSoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JoltSoftBodySharedSettings_Destroy(const JoltSoftBodySharedSettings *_this);

/// Destroys a heap-allocated array of `JoltSoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JoltSoftBodySharedSettings_DestroyArray(const JoltSoftBodySharedSettings *_this);

/// Generated from method `JoltSoftBodySharedSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_AssignFromAnother(JoltSoftBodySharedSettings *_this, const JoltSoftBodySharedSettings *_other);

/// Add a particle at (x,y,z). invMass=0 pins it (kinematic vertex).
/// Generated from method `JoltSoftBodySharedSettings::AddVertex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_AddVertex(JoltSoftBodySharedSettings *_this, float x, float y, float z, float invMass);

/// Add a triangular face by vertex indices.
/// Generated from method `JoltSoftBodySharedSettings::AddFace`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_AddFace(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, unsigned int v2);

/// Add an explicit edge-length spring between two vertices.
/// compliance: 0 = perfectly rigid, larger = softer.
/// restLength: target length; pass <=0 to auto-compute from current vertex positions.
/// Generated from method `JoltSoftBodySharedSettings::AddEdgeConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_AddEdgeConstraint(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, float compliance, float restLength);

/// Convenience: add edge with auto-computed rest length.
/// Generated from method `JoltSoftBodySharedSettings::AddEdgeConstraintAuto`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_AddEdgeConstraintAuto(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, float compliance);

/// Compute rest lengths for all edges whose mRestLength == 1.0 (the default).
/// Generated from method `JoltSoftBodySharedSettings::CalculateEdgeLengths`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_CalculateEdgeLengths(JoltSoftBodySharedSettings *_this);

/// Must be called once after building. Reorders constraints for parallel solving.
/// Generated from method `JoltSoftBodySharedSettings::Optimize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodySharedSettings_Optimize(JoltSoftBodySharedSettings *_this);

/// Generated from method `JoltSoftBodySharedSettings::GetVertexCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JoltSoftBodySharedSettings_GetVertexCount(const JoltSoftBodySharedSettings *_this);

/// Generated from method `JoltSoftBodySharedSettings::GetFaceCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JoltSoftBodySharedSettings_GetFaceCount(const JoltSoftBodySharedSettings *_this);

/// Generated from method `JoltSoftBodySharedSettings::GetEdgeCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JoltSoftBodySharedSettings_GetEdgeCount(const JoltSoftBodySharedSettings *_this);

///< internal SBCSHandle*; do not use directly
/// Returns a pointer to a member variable of class `JoltSoftBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void *const *JoltSoftBodyCreationSettings_Get_mHandle(const JoltSoftBodyCreationSettings *_this);

///< internal SBCSHandle*; do not use directly
/// Modifies a member variable of class `JoltSoftBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mHandle`.
/// When this function is called, this object will drop object references it held previously in `mHandle`.
JOLT_API void JoltSoftBodyCreationSettings_Set_mHandle(JoltSoftBodyCreationSettings *_this, void *value);

///< internal SBCSHandle*; do not use directly
/// Returns a mutable pointer to a member variable of class `JoltSoftBodyCreationSettings` named `mHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API void **JoltSoftBodyCreationSettings_GetMutable_mHandle(JoltSoftBodyCreationSettings *_this);

/// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_ConstructFromAnother(const JoltSoftBodyCreationSettings *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_OffsetPtr(const JoltSoftBodyCreationSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_OffsetMutablePtr(JoltSoftBodyCreationSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_Construct_9(JoltSoftBodySharedSettings *settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, unsigned int objectLayer);

/// Convenience: identity rotation.
/// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltSoftBodyCreationSettings_Destroy()` to free it when you're done using it.
JOLT_API JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_Construct_5(JoltSoftBodySharedSettings *settings, double posX, double posY, double posZ, unsigned int objectLayer);

/// Destroys a heap-allocated instance of `JoltSoftBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JoltSoftBodyCreationSettings_Destroy(const JoltSoftBodyCreationSettings *_this);

/// Destroys a heap-allocated array of `JoltSoftBodyCreationSettings`. Does nothing if the pointer is null.
JOLT_API void JoltSoftBodyCreationSettings_DestroyArray(const JoltSoftBodyCreationSettings *_this);

/// Generated from method `JoltSoftBodyCreationSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_AssignFromAnother(JoltSoftBodyCreationSettings *_this, const JoltSoftBodyCreationSettings *_other);

/// Generated from method `JoltSoftBodyCreationSettings::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodyCreationSettings_SetPosition(JoltSoftBodyCreationSettings *_this, double x, double y, double z);

/// Generated from method `JoltSoftBodyCreationSettings::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodyCreationSettings_SetRotation(JoltSoftBodyCreationSettings *_this, float qx, float qy, float qz, float qw);

/// Generated from method `JoltSoftBodyCreationSettings::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodyCreationSettings_SetObjectLayer(JoltSoftBodyCreationSettings *_this, unsigned int layer);

/// Generated from method `JoltSoftBodyCreationSettings::SetMakeRotationIdentity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodyCreationSettings_SetMakeRotationIdentity(JoltSoftBodyCreationSettings *_this, bool v);

/// Generated from method `JoltSoftBodyCreationSettings::SetNumIterations`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltSoftBodyCreationSettings_SetNumIterations(JoltSoftBodyCreationSettings *_this, unsigned int n);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsSystem_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltPhysicsSystem_DestroyArray()`.
/// Use `JoltPhysicsSystem_OffsetMutablePtr()` and `JoltPhysicsSystem_OffsetPtr()` to access the array elements.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltPhysicsSystem *JoltPhysicsSystem_OffsetPtr(const JoltPhysicsSystem *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_OffsetMutablePtr(JoltPhysicsSystem *ptr, ptrdiff_t i);

/// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsSystem_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_ConstructFromAnother(const JoltPhysicsSystem *_other);

/// Construct with explicit capacities.
/// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltPhysicsSystem_Destroy()` to free it when you're done using it.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_Construct(unsigned int maxBodies, unsigned int maxBodyPairs, unsigned int maxContactConstraints);

/// Destroys a heap-allocated instance of `JoltPhysicsSystem`. Does nothing if the pointer is null.
JOLT_API void JoltPhysicsSystem_Destroy(const JoltPhysicsSystem *_this);

/// Destroys a heap-allocated array of `JoltPhysicsSystem`. Does nothing if the pointer is null.
JOLT_API void JoltPhysicsSystem_DestroyArray(const JoltPhysicsSystem *_this);

/// Generated from method `JoltPhysicsSystem::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltPhysicsSystem *JoltPhysicsSystem_AssignFromAnother(JoltPhysicsSystem *_this, const JoltPhysicsSystem *_other);

// ---- Simulation ----------------------------------------------------------
/// Generated from method `JoltPhysicsSystem::SetGravity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetGravity(JoltPhysicsSystem *_this, double x, double y, double z);

/// Generated from method `JoltPhysicsSystem::GetGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltPhysicsSystem_GetGravity(const JoltPhysicsSystem *_this);

/// Advance the simulation. deltaTime is typically 1/60.
/// collisionSteps: increase for fast-moving objects (normally 1).
/// Generated from method `JoltPhysicsSystem::Update`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_Update(JoltPhysicsSystem *_this, float deltaTime, int collisionSteps);

/// Optimise the broad phase. Call after loading a static level before
/// starting to simulate.
/// Generated from method `JoltPhysicsSystem::OptimizeBroadPhase`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_OptimizeBroadPhase(JoltPhysicsSystem *_this);

/// Create a body from settings and add it to the simulation.
/// Generated from method `JoltPhysicsSystem::CreateAndAddBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltPhysicsSystem_CreateAndAddBody(JoltPhysicsSystem *_this, JoltBodyCreationSettings *settings, int activation);

/// Remove a body from the simulation (body data preserved, can re-add).
/// Generated from method `JoltPhysicsSystem::RemoveBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_RemoveBody(JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Permanently destroy a body. ID is invalid after this call.
/// Generated from method `JoltPhysicsSystem::DestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_DestroyBody(JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Remove and destroy in one call.
/// Generated from method `JoltPhysicsSystem::RemoveAndDestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_RemoveAndDestroyBody(JoltPhysicsSystem *_this, const JoltBodyID *id);

// ---- Body queries --------------------------------------------------------
/// Generated from method `JoltPhysicsSystem::GetBodyPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltPhysicsSystem_GetBodyPosition(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::GetBodyRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltQuat_Destroy()` to free it when you're done using it.
JOLT_API JoltQuat *JoltPhysicsSystem_GetBodyRotation(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::GetBodyLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltPhysicsSystem_GetBodyLinearVelocity(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::GetBodyAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3f_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3f *JoltPhysicsSystem_GetBodyAngularVelocity(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::IsBodyActive`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltPhysicsSystem_IsBodyActive(const JoltPhysicsSystem *_this, const JoltBodyID *id);

// ---- Body control --------------------------------------------------------
/// Generated from method `JoltPhysicsSystem::SetBodyPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyPosition(JoltPhysicsSystem *_this, const JoltBodyID *id, double x, double y, double z, int activation);

/// Generated from method `JoltPhysicsSystem::SetBodyRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyRotation(JoltPhysicsSystem *_this, const JoltBodyID *id, float qx, float qy, float qz, float qw, int activation);

/// Generated from method `JoltPhysicsSystem::SetBodyPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyPositionAndRotation(JoltPhysicsSystem *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);

/// Generated from method `JoltPhysicsSystem::SetBodyLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyLinearVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float vx, float vy, float vz);

/// Generated from method `JoltPhysicsSystem::SetBodyAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyAngularVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float vx, float vy, float vz);

/// Generated from method `JoltPhysicsSystem::SetBodyLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetBodyLinearAndAngularVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);

/// Generated from method `JoltPhysicsSystem::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_AddForce(JoltPhysicsSystem *_this, const JoltBodyID *id, float fx, float fy, float fz);

/// Generated from method `JoltPhysicsSystem::AddForceAtPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_AddForceAtPosition(JoltPhysicsSystem *_this, const JoltBodyID *id, float fx, float fy, float fz, double px, double py, double pz);

/// Generated from method `JoltPhysicsSystem::AddTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_AddTorque(JoltPhysicsSystem *_this, const JoltBodyID *id, float tx, float ty, float tz);

/// Generated from method `JoltPhysicsSystem::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_AddImpulse(JoltPhysicsSystem *_this, const JoltBodyID *id, float ix, float iy, float iz);

/// Generated from method `JoltPhysicsSystem::AddAngularImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_AddAngularImpulse(JoltPhysicsSystem *_this, const JoltBodyID *id, float ix, float iy, float iz);

/// Generated from method `JoltPhysicsSystem::ActivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_ActivateBody(JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::DeactivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_DeactivateBody(JoltPhysicsSystem *_this, const JoltBodyID *id);

// ---- Body properties -----------------------------------------------------
/// Generated from method `JoltPhysicsSystem::SetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetFriction(JoltPhysicsSystem *_this, const JoltBodyID *id, float friction);

/// Generated from method `JoltPhysicsSystem::GetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltPhysicsSystem_GetFriction(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::SetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetRestitution(JoltPhysicsSystem *_this, const JoltBodyID *id, float restitution);

/// Generated from method `JoltPhysicsSystem::GetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltPhysicsSystem_GetRestitution(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Generated from method `JoltPhysicsSystem::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetGravityFactor(JoltPhysicsSystem *_this, const JoltBodyID *id, float factor);

/// Generated from method `JoltPhysicsSystem::GetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API float JoltPhysicsSystem_GetGravityFactor(const JoltPhysicsSystem *_this, const JoltBodyID *id);

/// Connect two bodies at fixed relative positions/orientations.
/// Generated from method `JoltPhysicsSystem::AddFixedConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `body1` can not be null. It is a single object.
/// Parameter `body2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltPhysicsSystem_AddFixedConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2);

/// Distance constraint: keep two bodies between [minDist, maxDist].
/// Generated from method `JoltPhysicsSystem::AddDistanceConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `body1` can not be null. It is a single object.
/// Parameter `body2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltPhysicsSystem_AddDistanceConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, float minDist, float maxDist);

/// Point constraint: two bodies share a common world-space pivot.
/// Generated from method `JoltPhysicsSystem::AddPointConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `body1` can not be null. It is a single object.
/// Parameter `body2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltPhysicsSystem_AddPointConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, double pivotX, double pivotY, double pivotZ);

/// Hinge constraint: bodies rotate about a shared axis.
/// Generated from method `JoltPhysicsSystem::AddHingeConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `body1` can not be null. It is a single object.
/// Parameter `body2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltConstraintID_Destroy()` to free it when you're done using it.
JOLT_API JoltConstraintID *JoltPhysicsSystem_AddHingeConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, double pivotX, double pivotY, double pivotZ, float axisX, float axisY, float axisZ);

/// Remove and destroy a constraint.
/// Generated from method `JoltPhysicsSystem::DestroyConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_DestroyConstraint(JoltPhysicsSystem *_this, const JoltConstraintID *id);

/// Enable or disable an existing constraint.
/// Generated from method `JoltPhysicsSystem::SetConstraintEnabled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltPhysicsSystem_SetConstraintEnabled(JoltPhysicsSystem *_this, const JoltConstraintID *id, bool enabled);

// ---- Soft body -----------------------------------------------------------
/// Generated from method `JoltPhysicsSystem::CreateAndAddSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltPhysicsSystem_CreateAndAddSoftBody(JoltPhysicsSystem *_this, JoltSoftBodyCreationSettings *settings, int activation);

/// Get a non-owning handle to a constraint created via AddFixedConstraint etc.
/// Generated from method `JoltPhysicsSystem::GetConstraintHandle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltTwoBodyConstraint_Destroy()` to free it when you're done using it.
JOLT_API JoltTwoBodyConstraint *JoltPhysicsSystem_GetConstraintHandle(JoltPhysicsSystem *_this, const JoltConstraintID *id);

/// Returns a non-owning handle to the body interface.
/// The JoltPhysicsSystem must outlive the returned JoltBodyInterface.
/// Generated from method `JoltPhysicsSystem::GetBodyInterface`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyInterface_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyInterface *JoltPhysicsSystem_GetBodyInterface(JoltPhysicsSystem *_this);

// ---- Statistics ----------------------------------------------------------
/// Generated from method `JoltPhysicsSystem::GetNumBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JoltPhysicsSystem_GetNumBodies(const JoltPhysicsSystem *_this);

/// Generated from method `JoltPhysicsSystem::GetNumActiveBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JoltPhysicsSystem_GetNumActiveBodies(const JoltPhysicsSystem *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltWorld_Destroy()` to free it when you're done using it.
JOLT_API JoltWorld *JoltWorld_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltWorld_DestroyArray()`.
/// Use `JoltWorld_OffsetMutablePtr()` and `JoltWorld_OffsetPtr()` to access the array elements.
JOLT_API JoltWorld *JoltWorld_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltWorld *JoltWorld_OffsetPtr(const JoltWorld *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltWorld *JoltWorld_OffsetMutablePtr(JoltWorld *ptr, ptrdiff_t i);

/// Generated from constructor `JoltWorld::JoltWorld`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltWorld_Destroy()` to free it when you're done using it.
JOLT_API JoltWorld *JoltWorld_ConstructFromAnother(const JoltWorld *_other);

/// Destroys a heap-allocated instance of `JoltWorld`. Does nothing if the pointer is null.
JOLT_API void JoltWorld_Destroy(const JoltWorld *_this);

/// Destroys a heap-allocated array of `JoltWorld`. Does nothing if the pointer is null.
JOLT_API void JoltWorld_DestroyArray(const JoltWorld *_this);

/// Generated from method `JoltWorld::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltWorld *JoltWorld_AssignFromAnother(JoltWorld *_this, const JoltWorld *_other);

/// Generated from method `JoltWorld::SetGravity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltWorld_SetGravity(JoltWorld *_this, double x, double y, double z);

/// Generated from method `JoltWorld::AddStaticBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltWorld_AddStaticBox(JoltWorld *_this, double halfX, double halfY, double halfZ, double posX, double posY, double posZ);

/// Generated from method `JoltWorld::AddDynamicSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltBodyID_Destroy()` to free it when you're done using it.
JOLT_API JoltBodyID *JoltWorld_AddDynamicSphere(JoltWorld *_this, double radius, double posX, double posY, double posZ);

/// Generated from method `JoltWorld::Update`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltWorld_Update(JoltWorld *_this, double deltaTime);

/// Generated from method `JoltWorld::OptimizeBroadPhase`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JoltWorld_OptimizeBroadPhase(JoltWorld *_this);

/// Generated from method `JoltWorld::GetBodyPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltVec3_Destroy()` to free it when you're done using it.
JOLT_API JoltVec3 *JoltWorld_GetBodyPosition(const JoltWorld *_this, const JoltBodyID *id);

/// Generated from method `JoltWorld::IsBodyActive`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API bool JoltWorld_IsBodyActive(const JoltWorld *_this, const JoltBodyID *id);

/// Generated from method `JoltWorld::RemoveBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltWorld_RemoveBody(JoltWorld *_this, const JoltBodyID *id);

/// Generated from method `JoltWorld::DestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `id` can not be null. It is a single object.
JOLT_API void JoltWorld_DestroyBody(JoltWorld *_this, const JoltBodyID *id);

#ifdef __cplusplus
} // extern "C"
#endif
