// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyFilter JPH_BodyFilter; // Defined in `#include <jolt/Jolt/Physics/Body/BodyFilter.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_BroadPhaseLayerFilter JPH_BroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerFilter JPH_ObjectLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_RefTarget_JPH_VehicleCollisionTester JPH_RefTarget_JPH_VehicleCollisionTester; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.


/// Class that does collision detection between wheels and ground
/// Generated from class `JPH::VehicleCollisionTester`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleCollisionTesterCastCylinder`
///     `JPH::VehicleCollisionTesterCastSphere`
///     `JPH::VehicleCollisionTesterRay`
typedef struct JPH_VehicleCollisionTester JPH_VehicleCollisionTester;

/// Collision tester that tests collision using a raycast
/// Generated from class `JPH::VehicleCollisionTesterRay`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleCollisionTester`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
///     `JPH::NonCopyable`
typedef struct JPH_VehicleCollisionTesterRay JPH_VehicleCollisionTesterRay;

/// Collision tester that tests collision using a sphere cast
/// Generated from class `JPH::VehicleCollisionTesterCastSphere`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleCollisionTester`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
///     `JPH::NonCopyable`
typedef struct JPH_VehicleCollisionTesterCastSphere JPH_VehicleCollisionTesterCastSphere;

/// Collision tester that tests collision using a cylinder shape
/// Generated from class `JPH::VehicleCollisionTesterCastCylinder`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::VehicleCollisionTester`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
///     `JPH::NonCopyable`
typedef struct JPH_VehicleCollisionTesterCastCylinder JPH_VehicleCollisionTesterCastCylinder;

/// Destroys a heap-allocated instance of `JPH_VehicleCollisionTester`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTester_Destroy(const JPH_VehicleCollisionTester *_this);

/// Destroys a heap-allocated array of `JPH_VehicleCollisionTester`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTester_DestroyArray(const JPH_VehicleCollisionTester *_this);

/// Generated from method `JPH::VehicleCollisionTester::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTester_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTester::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTester_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTester::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTester::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTester_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTester::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTester::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleCollisionTester::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Object layer to use for collision detection, this is used when the filters are not overridden
/// Generated from method `JPH::VehicleCollisionTester::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_VehicleCollisionTester_GetObjectLayer(const JPH_VehicleCollisionTester *_this);

/// Generated from method `JPH::VehicleCollisionTester::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_SetObjectLayer(JPH_VehicleCollisionTester *_this, unsigned short inObjectLayer);

/// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTester::SetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTester *_this, const JPH_BroadPhaseLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTester::GetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTester *_this);

/// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTester::SetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_SetObjectLayerFilter(JPH_VehicleCollisionTester *_this, const JPH_ObjectLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTester::GetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ObjectLayerFilter *JPH_VehicleCollisionTester_GetObjectLayerFilter(const JPH_VehicleCollisionTester *_this);

/// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
/// Generated from method `JPH::VehicleCollisionTester::SetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_SetBodyFilter(JPH_VehicleCollisionTester *_this, const JPH_BodyFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTester::GetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BodyFilter *JPH_VehicleCollisionTester_GetBodyFilter(const JPH_VehicleCollisionTester *_this);

/// Do a collision test with the world
/// @param inPhysicsSystem The physics system that should be tested against
/// @param inVehicleConstraint The vehicle constraint
/// @param inWheelIndex Index of the wheel that we're testing collision for
/// @param inOrigin Origin for the test, corresponds to the world space position for the suspension attachment point
/// @param inDirection Direction for the test (unit vector, world space)
/// @param inVehicleBodyID This body should be filtered out during collision detection to avoid self collisions
/// @param outBody Body that the wheel collided with
/// @param outSubShapeID Sub shape ID that the wheel collided with
/// @param outContactPosition Contact point between wheel and floor, in world space
/// @param outContactNormal Contact normal between wheel and floor, pointing away from the floor
/// @param outSuspensionLength New length of the suspension [0, inSuspensionMaxLength]
/// @return True when collision found, false if not
/// Generated from method `JPH::VehicleCollisionTester::Collide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `outBody` can not be null. It is a single object.
/// Parameter `outSubShapeID` can not be null. It is a single object.
/// Parameter `outContactPosition` can not be null. It is a single object.
/// Parameter `outContactNormal` can not be null. It is a single object.
/// Parameter `outSuspensionLength` can not be null. It is a single object.
JOLT_API bool JPH_VehicleCollisionTester_Collide(const JPH_VehicleCollisionTester *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength);

/// Do a cheap contact properties prediction based on the contact properties from the last collision test (provided as input parameters)
/// @param inPhysicsSystem The physics system that should be tested against
/// @param inVehicleConstraint The vehicle constraint
/// @param inWheelIndex Index of the wheel that we're testing collision for
/// @param inOrigin Origin for the test, corresponds to the world space position for the suspension attachment point
/// @param inDirection Direction for the test (unit vector, world space)
/// @param inVehicleBodyID The body ID for the vehicle itself
/// @param ioBody Body that the wheel previously collided with
/// @param ioSubShapeID Sub shape ID that the wheel collided with during the last check
/// @param ioContactPosition Contact point between wheel and floor during the last check, in world space
/// @param ioContactNormal Contact normal between wheel and floor during the last check, pointing away from the floor
/// @param ioSuspensionLength New length of the suspension [0, inSuspensionMaxLength]
/// Generated from method `JPH::VehicleCollisionTester::PredictContactProperties`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `ioBody` can not be null. It is a single object.
/// Parameter `ioSubShapeID` can not be null. It is a single object.
/// Parameter `ioContactPosition` can not be null. It is a single object.
/// Parameter `ioContactNormal` can not be null. It is a single object.
/// Parameter `ioSuspensionLength` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_PredictContactProperties(const JPH_VehicleCollisionTester *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleCollisionTester::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_SetEmbedded(const JPH_VehicleCollisionTester *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleCollisionTester::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleCollisionTester_GetRefCount(const JPH_VehicleCollisionTester *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleCollisionTester::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_AddRef(const JPH_VehicleCollisionTester *_this);

/// Generated from method `JPH::VehicleCollisionTester::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTester_Release(const JPH_VehicleCollisionTester *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleCollisionTester::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleCollisionTester_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_OffsetPtr(const JPH_VehicleCollisionTester *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_OffsetMutablePtr(JPH_VehicleCollisionTester *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleCollisionTester` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTester` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTester`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTester`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTester` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTester` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleCollisionTester_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTester`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTester`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Constructor
/// @param inObjectLayer Object layer to test collision with
/// @param inUp World space up vector, used to avoid colliding with vertical walls.
/// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
/// Generated from constructor `JPH::VehicleCollisionTesterRay::VehicleCollisionTesterRay`.
/// Parameter `inUp` is a single object.
/// Parameter `inUp` has a default argument: `Vec3::sAxisY()`, pass a null pointer to use it.
/// Parameter `inMaxSlopeAngle` has a default argument: `DegreesToRadians(80.0f)`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleCollisionTesterRay_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_Construct(unsigned short inObjectLayer, const JPH_Vec3 *inUp, const float *inMaxSlopeAngle);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_OffsetPtr(const JPH_VehicleCollisionTesterRay *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_OffsetMutablePtr(JPH_VehicleCollisionTesterRay *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterRay *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterRay *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterRay *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterRay *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::VehicleCollisionTester`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterRay *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterRay` to its base class `JPH::VehicleCollisionTester`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterRay *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterRay`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object);

/// Destroys a heap-allocated instance of `JPH_VehicleCollisionTesterRay`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterRay_Destroy(const JPH_VehicleCollisionTesterRay *_this);

/// Destroys a heap-allocated array of `JPH_VehicleCollisionTesterRay`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterRay_DestroyArray(const JPH_VehicleCollisionTesterRay *_this);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterRay_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleCollisionTester
/// Generated from method `JPH::VehicleCollisionTesterRay::Collide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `outBody` can not be null. It is a single object.
/// Parameter `outSubShapeID` can not be null. It is a single object.
/// Parameter `outContactPosition` can not be null. It is a single object.
/// Parameter `outContactNormal` can not be null. It is a single object.
/// Parameter `outSuspensionLength` can not be null. It is a single object.
JOLT_API bool JPH_VehicleCollisionTesterRay_Collide(const JPH_VehicleCollisionTesterRay *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength);

/// Generated from method `JPH::VehicleCollisionTesterRay::PredictContactProperties`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `ioBody` can not be null. It is a single object.
/// Parameter `ioSubShapeID` can not be null. It is a single object.
/// Parameter `ioContactPosition` can not be null. It is a single object.
/// Parameter `ioContactNormal` can not be null. It is a single object.
/// Parameter `ioSuspensionLength` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_PredictContactProperties(const JPH_VehicleCollisionTesterRay *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength);

/// Object layer to use for collision detection, this is used when the filters are not overridden
/// Generated from method `JPH::VehicleCollisionTesterRay::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_VehicleCollisionTesterRay_GetObjectLayer(const JPH_VehicleCollisionTesterRay *_this);

/// Generated from method `JPH::VehicleCollisionTesterRay::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_SetObjectLayer(JPH_VehicleCollisionTesterRay *_this, unsigned short inObjectLayer);

/// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterRay::SetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_BroadPhaseLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterRay::GetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterRay *_this);

/// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterRay::SetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_SetObjectLayerFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_ObjectLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterRay::GetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterRay_GetObjectLayerFilter(const JPH_VehicleCollisionTesterRay *_this);

/// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
/// Generated from method `JPH::VehicleCollisionTesterRay::SetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_SetBodyFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_BodyFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterRay::GetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BodyFilter *JPH_VehicleCollisionTesterRay_GetBodyFilter(const JPH_VehicleCollisionTesterRay *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleCollisionTesterRay::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_SetEmbedded(const JPH_VehicleCollisionTesterRay *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleCollisionTesterRay::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleCollisionTesterRay_GetRefCount(const JPH_VehicleCollisionTesterRay *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleCollisionTesterRay::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_AddRef(const JPH_VehicleCollisionTesterRay *_this);

/// Generated from method `JPH::VehicleCollisionTesterRay::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterRay_Release(const JPH_VehicleCollisionTesterRay *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleCollisionTesterRay::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset(void);

/// Constructor
/// @param inObjectLayer Object layer to test collision with
/// @param inUp World space up vector, used to avoid colliding with vertical walls.
/// @param inRadius Radius of sphere
/// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
/// Generated from constructor `JPH::VehicleCollisionTesterCastSphere::VehicleCollisionTesterCastSphere`.
/// Parameter `inUp` is a single object.
/// Parameter `inUp` has a default argument: `Vec3::sAxisY()`, pass a null pointer to use it.
/// Parameter `inMaxSlopeAngle` has a default argument: `DegreesToRadians(80.0f)`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleCollisionTesterCastSphere_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_Construct(unsigned short inObjectLayer, float inRadius, const JPH_Vec3 *inUp, const float *inMaxSlopeAngle);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_OffsetPtr(const JPH_VehicleCollisionTesterCastSphere *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_OffsetMutablePtr(JPH_VehicleCollisionTesterCastSphere *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastSphere *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastSphere *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterCastSphere *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterCastSphere *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::VehicleCollisionTester`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastSphere *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastSphere` to its base class `JPH::VehicleCollisionTester`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastSphere *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterCastSphere`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object);

/// Destroys a heap-allocated instance of `JPH_VehicleCollisionTesterCastSphere`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_Destroy(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Destroys a heap-allocated array of `JPH_VehicleCollisionTesterCastSphere`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_DestroyArray(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleCollisionTester
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::Collide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `outBody` can not be null. It is a single object.
/// Parameter `outSubShapeID` can not be null. It is a single object.
/// Parameter `outContactPosition` can not be null. It is a single object.
/// Parameter `outContactNormal` can not be null. It is a single object.
/// Parameter `outSuspensionLength` can not be null. It is a single object.
JOLT_API bool JPH_VehicleCollisionTesterCastSphere_Collide(const JPH_VehicleCollisionTesterCastSphere *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::PredictContactProperties`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `ioBody` can not be null. It is a single object.
/// Parameter `ioSubShapeID` can not be null. It is a single object.
/// Parameter `ioContactPosition` can not be null. It is a single object.
/// Parameter `ioContactNormal` can not be null. It is a single object.
/// Parameter `ioSuspensionLength` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_PredictContactProperties(const JPH_VehicleCollisionTesterCastSphere *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength);

/// Object layer to use for collision detection, this is used when the filters are not overridden
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_VehicleCollisionTesterCastSphere_GetObjectLayer(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_SetObjectLayer(JPH_VehicleCollisionTesterCastSphere *_this, unsigned short inObjectLayer);

/// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_BroadPhaseLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_ObjectLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_SetBodyFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_BodyFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BodyFilter *JPH_VehicleCollisionTesterCastSphere_GetBodyFilter(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_SetEmbedded(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleCollisionTesterCastSphere_GetRefCount(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_AddRef(const JPH_VehicleCollisionTesterCastSphere *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastSphere::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastSphere_Release(const JPH_VehicleCollisionTesterCastSphere *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleCollisionTesterCastSphere::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset(void);

/// Constructor
/// @param inObjectLayer Object layer to test collision with
/// @param inConvexRadiusFraction Fraction of half the wheel width (or wheel radius if it is smaller) that is used as the convex radius
/// Generated from constructor `JPH::VehicleCollisionTesterCastCylinder::VehicleCollisionTesterCastCylinder`.
/// Parameter `inConvexRadiusFraction` has a default argument: `0.100000001f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_VehicleCollisionTesterCastCylinder_Destroy()` to free it when you're done using it.
JOLT_API JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_Construct(unsigned short inObjectLayer, const float *inConvexRadiusFraction);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_OffsetPtr(const JPH_VehicleCollisionTesterCastCylinder *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_OffsetMutablePtr(JPH_VehicleCollisionTesterCastCylinder *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastCylinder *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastCylinder *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleCollisionTester>` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterCastCylinder *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterCastCylinder *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::VehicleCollisionTester`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastCylinder *object);

/// Upcasts an instance of `JPH::VehicleCollisionTesterCastCylinder` to its base class `JPH::VehicleCollisionTester`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastCylinder *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object);

/// Downcasts an instance of `JPH::VehicleCollisionTester` to a derived class `JPH::VehicleCollisionTesterCastCylinder`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object);

/// Destroys a heap-allocated instance of `JPH_VehicleCollisionTesterCastCylinder`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_Destroy(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Destroys a heap-allocated array of `JPH_VehicleCollisionTesterCastCylinder`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_DestroyArray(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t(size_t inCount);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: VehicleCollisionTester
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::Collide`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `outBody` can not be null. It is a single object.
/// Parameter `outSubShapeID` can not be null. It is a single object.
/// Parameter `outContactPosition` can not be null. It is a single object.
/// Parameter `outContactNormal` can not be null. It is a single object.
/// Parameter `outSuspensionLength` can not be null. It is a single object.
JOLT_API bool JPH_VehicleCollisionTesterCastCylinder_Collide(const JPH_VehicleCollisionTesterCastCylinder *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::PredictContactProperties`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPhysicsSystem` can not be null. It is a single object.
/// Parameter `inVehicleConstraint` can not be null. It is a single object.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Parameter `inVehicleBodyID` can not be null. It is a single object.
/// Parameter `ioBody` can not be null. It is a single object.
/// Parameter `ioSubShapeID` can not be null. It is a single object.
/// Parameter `ioContactPosition` can not be null. It is a single object.
/// Parameter `ioContactNormal` can not be null. It is a single object.
/// Parameter `ioSuspensionLength` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties(const JPH_VehicleCollisionTesterCastCylinder *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength);

/// Object layer to use for collision detection, this is used when the filters are not overridden
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer(JPH_VehicleCollisionTesterCastCylinder *_this, unsigned short inObjectLayer);

/// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_BroadPhaseLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_ObjectLayerFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetObjectLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_BodyFilter *inFilter);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetBodyFilter`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_BodyFilter *JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_SetEmbedded(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleCollisionTesterCastCylinder_GetRefCount(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_AddRef(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleCollisionTesterCastCylinder_Release(const JPH_VehicleCollisionTesterCastCylinder *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleCollisionTesterCastCylinder::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
