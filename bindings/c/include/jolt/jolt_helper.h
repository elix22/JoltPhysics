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

/// Opaque handle to a physics body.
/// Generated from class `JoltBodyID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyID JoltBodyID;

/// Opaque handle to a constraint.
/// Generated from class `JoltConstraintID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltConstraintID JoltConstraintID;

/// Base class for all collision shapes.
/// Shapes are ref-counted; call Release() when you no longer need the handle.
/// Generated from class `JoltShape`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JoltBoxShape`
///     `JoltCapsuleShape`
///     `JoltCylinderShape`
///     `JoltRotatedTranslatedShape`
///     `JoltSphereShape`
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

/// Parameters used when adding a body to the physics system.
/// Generated from class `JoltBodyCreationSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltBodyCreationSettings JoltBodyCreationSettings;

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
