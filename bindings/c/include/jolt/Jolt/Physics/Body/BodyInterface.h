// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Body/MotionQuality.h>
#include <jolt/Jolt/Physics/Body/MotionType.h>
#include <jolt/Jolt/Physics/EActivation.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyCreationSettings JPH_BodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/Body/BodyCreationSettings.h>`.
typedef struct JPH_BroadPhaseLayerFilter JPH_BroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_CollisionGroup JPH_CollisionGroup; // Defined in `#include <jolt/Jolt/Physics/Collision/CollisionGroup.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerFilter JPH_ObjectLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SoftBodyCreationSettings JPH_SoftBodyCreationSettings; // Defined in `#include <jolt/Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_TwoBodyConstraint JPH_TwoBodyConstraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_TwoBodyConstraintSettings JPH_TwoBodyConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that provides operations on bodies using a body ID. Note that if you need to do multiple operations on a single body, it is more efficient to lock the body once and combine the operations.
/// All quantities are in world space unless otherwise specified.
/// Generated from class `JPH::BodyInterface`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BodyInterface JPH_BodyInterface;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BodyInterface_Destroy()` to free it when you're done using it.
JOLT_API JPH_BodyInterface *JPH_BodyInterface_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BodyInterface_DestroyArray()`.
/// Use `JPH_BodyInterface_OffsetMutablePtr()` and `JPH_BodyInterface_OffsetPtr()` to access the array elements.
JOLT_API JPH_BodyInterface *JPH_BodyInterface_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BodyInterface *JPH_BodyInterface_OffsetPtr(const JPH_BodyInterface *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BodyInterface *JPH_BodyInterface_OffsetMutablePtr(JPH_BodyInterface *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::BodyInterface` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_BodyInterface_UpcastTo_JPH_NonCopyable(const JPH_BodyInterface *object);

/// Upcasts an instance of `JPH::BodyInterface` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_BodyInterface_MutableUpcastTo_JPH_NonCopyable(JPH_BodyInterface *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BodyInterface`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BodyInterface *JPH_BodyInterface_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::BodyInterface`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BodyInterface *JPH_BodyInterface_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_BodyInterface`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyInterface_Destroy(const JPH_BodyInterface *_this);

/// Destroys a heap-allocated array of `JPH_BodyInterface`. Does nothing if the pointer is null.
JOLT_API void JPH_BodyInterface_DestroyArray(const JPH_BodyInterface *_this);

/// Create a rigid body
/// @return Created body or null when out of bodies
/// Generated from method `JPH::BodyInterface::CreateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateBody(JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings);

/// Create a soft body
/// @return Created body or null when out of bodies
/// Generated from method `JPH::BodyInterface::CreateSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateSoftBody(JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings);

/// Create a rigid body with specified ID. This function can be used if a simulation is to run in sync between clients or if a simulation needs to be restored exactly.
/// The ID created on the server can be replicated to the client and used to create a deterministic simulation.
/// @return Created body or null when the body ID is invalid or a body of the same ID already exists.
/// Generated from method `JPH::BodyInterface::CreateBodyWithID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateBodyWithID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_BodyCreationSettings *inSettings);

/// Create a soft body with specified ID. See comments at CreateBodyWithID.
/// Generated from method `JPH::BodyInterface::CreateSoftBodyWithID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateSoftBodyWithID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_SoftBodyCreationSettings *inSettings);

/// Advanced use only. Creates a rigid body without specifying an ID. This body cannot be added to the physics system until it has been assigned a body ID.
/// This can be used to decouple allocation from registering the body. A call to CreateBodyWithoutID followed by AssignBodyID is equivalent to calling CreateBodyWithID.
/// @return Created body
/// Generated from method `JPH::BodyInterface::CreateBodyWithoutID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateBodyWithoutID(const JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings);

/// Advanced use only. Creates a body without specifying an ID. See comments at CreateBodyWithoutID.
/// Generated from method `JPH::BodyInterface::CreateSoftBodyWithoutID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_CreateSoftBodyWithoutID(const JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings);

/// Advanced use only. Destroy a body previously created with CreateBodyWithoutID that hasn't gotten an ID yet through the AssignBodyID function,
/// or a body that has had its body ID unassigned through UnassignBodyIDs. Bodies that have an ID should be destroyed through DestroyBody.
/// Generated from method `JPH::BodyInterface::DestroyBodyWithoutID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_DestroyBodyWithoutID(const JPH_BodyInterface *_this, JPH_Body *inBody);

/// Advanced use only. Assigns the next available body ID to a body that was created using CreateBodyWithoutID. After this call, the body can be added to the physics system.
/// @return false if the body already has an ID or out of body ids.
/// Generated from method `JPH::BodyInterface::AssignBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_AssignBodyID_1(JPH_BodyInterface *_this, JPH_Body *ioBody);

/// Advanced use only. Assigns a body ID to a body that was created using CreateBodyWithoutID. After this call, the body can be added to the physics system.
/// @return false if the body already has an ID or if the ID is not valid.
/// Generated from method `JPH::BodyInterface::AssignBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_AssignBodyID_2(JPH_BodyInterface *_this, JPH_Body *ioBody, const JPH_BodyID *inBodyID);

/// Advanced use only. See UnassignBodyIDs. Unassigns the ID of a single body.
/// Generated from method `JPH::BodyInterface::UnassignBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API JPH_Body *JPH_BodyInterface_UnassignBodyID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Advanced use only. Removes a number of body IDs from their bodies and returns the body pointers. Before calling this, the body should have been removed from the physics system.
/// The body can be destroyed through DestroyBodyWithoutID. This can be used to decouple deallocation. A call to UnassignBodyIDs followed by calls to DestroyBodyWithoutID is equivalent to calling DestroyBodies.
/// @param inBodyIDs A list of body IDs
/// @param inNumber Number of bodies in the list
/// @param outBodies If not null on input, this will contain a list of body pointers corresponding to inBodyIDs that can be destroyed afterwards (caller assumes ownership over these).
/// Generated from method `JPH::BodyInterface::UnassignBodyIDs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_UnassignBodyIDs(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber, JPH_Body **outBodies);

/// Destroy a body.
/// Make sure that you remove the body from the physics system using BodyInterface::RemoveBody before calling this function.
/// Generated from method `JPH::BodyInterface::DestroyBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_DestroyBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Destroy multiple bodies
/// Make sure that you remove the bodies from the physics system using BodyInterface::RemoveBody before calling this function.
/// Generated from method `JPH::BodyInterface::DestroyBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_DestroyBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber);

/// Add body to the physics system.
/// Note that if you need to add multiple bodies, use the AddBodiesPrepare/AddBodiesFinalize function.
/// Adding many bodies, one at a time, results in a really inefficient broadphase until PhysicsSystem::OptimizeBroadPhase is called or when PhysicsSystem::Update rebuilds the tree!
/// After adding, to get a body by ID use the BodyLockRead or BodyLockWrite interface!
/// Generated from method `JPH::BodyInterface::AddBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_EActivation inActivationMode);

/// Remove body from the physics system. Note that you need to add a body to the physics system before you can remove it.
/// Generated from method `JPH::BodyInterface::RemoveBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_RemoveBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Check if a body has been added to the physics system.
/// Generated from method `JPH::BodyInterface::IsAdded`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_IsAdded(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Combines CreateBody and AddBody
/// @return Created body ID or an invalid ID when out of bodies
/// Generated from method `JPH::BodyInterface::CreateAndAddBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_BodyInterface_CreateAndAddBody(JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings, JPH_EActivation inActivationMode);

/// Combines CreateSoftBody and AddBody
/// @return Created body ID or an invalid ID when out of bodies
/// Generated from method `JPH::BodyInterface::CreateAndAddSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_BodyInterface_CreateAndAddSoftBody(JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings, JPH_EActivation inActivationMode);

/// Prepare adding inNumber bodies at ioBodies to the PhysicsSystem, returns a handle that should be used in AddBodiesFinalize/Abort.
/// This can be done on a background thread without influencing the PhysicsSystem.
/// ioBodies may be shuffled around by this function and should be kept that way until AddBodiesFinalize/Abort is called.
/// Generated from method `JPH::BodyInterface::AddBodiesPrepare`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_BodyInterface_AddBodiesPrepare(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber);

/// Finalize adding bodies to the PhysicsSystem, supply the return value of AddBodiesPrepare in inAddState.
/// Please ensure that the ioBodies array passed to AddBodiesPrepare is unmodified and passed again to this function.
/// Generated from method `JPH::BodyInterface::AddBodiesFinalize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddBodiesFinalize(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber, void *inAddState, JPH_EActivation inActivationMode);

/// Abort adding bodies to the PhysicsSystem, supply the return value of AddBodiesPrepare in inAddState.
/// This can be done on a background thread without influencing the PhysicsSystem.
/// Please ensure that the ioBodies array passed to AddBodiesPrepare is unmodified and passed again to this function.
/// Generated from method `JPH::BodyInterface::AddBodiesAbort`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddBodiesAbort(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber, void *inAddState);

/// Remove inNumber bodies in ioBodies from the PhysicsSystem. Note that bodies need to be added to the physics system before they can be removed.
/// ioBodies may be shuffled around by this function.
/// Generated from method `JPH::BodyInterface::RemoveBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_RemoveBodies(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber);

///@name Activate / deactivate a body. Note that you need to add a body to the physics system before you can activate it.
///@{
/// Generated from method `JPH::BodyInterface::ActivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_ActivateBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::ActivateBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_ActivateBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber);

/// Generated from method `JPH::BodyInterface::ActivateBodiesInAABox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerFilter` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_ActivateBodiesInAABox(JPH_BodyInterface *_this, const JPH_AABox *inBox, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter);

/// Generated from method `JPH::BodyInterface::DeactivateBody`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_DeactivateBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::DeactivateBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_DeactivateBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber);

/// Generated from method `JPH::BodyInterface::IsActive`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_IsActive(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::ResetSleepTimer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_ResetSleepTimer(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Create a two body constraint
/// Generated from method `JPH::BodyInterface::CreateConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID1` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
JOLT_API JPH_TwoBodyConstraint *JPH_BodyInterface_CreateConstraint(JPH_BodyInterface *_this, const JPH_TwoBodyConstraintSettings *inSettings, const JPH_BodyID *inBodyID1, const JPH_BodyID *inBodyID2);

/// Activate non-static bodies attached to a constraint.
/// Note that the bodies involved in the constraint should be added to the physics system before activating a constraint.
/// Generated from method `JPH::BodyInterface::ActivateConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_ActivateConstraint(JPH_BodyInterface *_this, const JPH_TwoBodyConstraint *inConstraint);

/// Set a new shape on the body
/// @param inBodyID Body ID of body that had its shape changed
/// @param inShape The new shape
/// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
/// @param inActivationMode Whether or not to activate the body
/// Generated from method `JPH::BodyInterface::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetShape(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Shape *inShape, bool inUpdateMassProperties, JPH_EActivation inActivationMode);

/// Notify all systems to indicate that a shape has changed (usable for MutableCompoundShapes)
/// @param inBodyID Body ID of body that had its shape changed
/// @param inPreviousCenterOfMass Center of mass of the shape before the alterations
/// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
/// @param inActivationMode Whether or not to activate the body
/// Generated from method `JPH::BodyInterface::NotifyShapeChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPreviousCenterOfMass` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_NotifyShapeChanged(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPreviousCenterOfMass, bool inUpdateMassProperties, JPH_EActivation inActivationMode);

///@name Object layer of a body
///@{
/// Generated from method `JPH::BodyInterface::SetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetObjectLayer(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, unsigned short inLayer);

/// Generated from method `JPH::BodyInterface::GetObjectLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API unsigned short JPH_BodyInterface_GetObjectLayer(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Position and rotation of a body
///@{
/// Generated from method `JPH::BodyInterface::SetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetPositionAndRotation(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EActivation inActivationMode);

/// Generated from method `JPH::BodyInterface::SetPositionAndRotationWhenChanged`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetPositionAndRotationWhenChanged(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EActivation inActivationMode);

/// Generated from method `JPH::BodyInterface::GetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `outPosition` can not be null. It is a single object.
/// Parameter `outRotation` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_GetPositionAndRotation(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_Vec3 *outPosition, JPH_Quat *outRotation);

/// Generated from method `JPH::BodyInterface::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetPosition(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, JPH_EActivation inActivationMode);

/// Generated from method `JPH::BodyInterface::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BodyInterface_GetPosition(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::GetCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BodyInterface_GetCenterOfMassPosition(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetRotation(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Quat *inRotation, JPH_EActivation inActivationMode);

/// Generated from method `JPH::BodyInterface::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_BodyInterface_GetRotation(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_BodyInterface_GetWorldTransform(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::GetCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_BodyInterface_GetCenterOfMassTransform(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Set velocity of body such that it will be positioned at inTargetPosition/Rotation in inDeltaTime seconds (will activate body if needed)
/// Generated from method `JPH::BodyInterface::MoveKinematic`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inTargetPosition` can not be null. It is a single object.
/// Parameter `inTargetRotation` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_MoveKinematic(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inTargetPosition, const JPH_Quat *inTargetRotation, float inDeltaTime);

/// Linear or angular velocity (functions will activate body if needed).
/// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
/// Generated from method `JPH::BodyInterface::SetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetLinearAndAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity);

/// Generated from method `JPH::BodyInterface::GetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `outLinearVelocity` can not be null. It is a single object.
/// Parameter `outAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_GetLinearAndAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_Vec3 *outLinearVelocity, JPH_Vec3 *outAngularVelocity);

/// Generated from method `JPH::BodyInterface::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity);

/// Generated from method `JPH::BodyInterface::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BodyInterface_GetLinearVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::AddLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity);

/// Generated from method `JPH::BodyInterface::AddLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddLinearAndAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity);

/// Generated from method `JPH::BodyInterface::SetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inAngularVelocity);

/// Generated from method `JPH::BodyInterface::GetAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BodyInterface_GetAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::GetPointVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_BodyInterface_GetPointVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPoint);

/// Set the complete motion state of a body.
/// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
/// Generated from method `JPH::BodyInterface::SetPositionRotationAndVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetPositionRotationAndVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity);

///@name Add forces to the body. Note that you should add a body to the physics system before applying forces or torques.
///@{
/// Generated from method `JPH::BodyInterface::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inForce` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `JPH::EActivation::Activate`, pass a null pointer to use it.
JOLT_API void JPH_BodyInterface_AddForce_3(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_EActivation *inActivationMode);

/// Generated from method `JPH::BodyInterface::AddForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inForce` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `JPH::EActivation::Activate`, pass a null pointer to use it.
JOLT_API void JPH_BodyInterface_AddForce_4(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_Vec3 *inPoint, const JPH_EActivation *inActivationMode);

/// Generated from method `JPH::BodyInterface::AddTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inTorque` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `JPH::EActivation::Activate`, pass a null pointer to use it.
JOLT_API void JPH_BodyInterface_AddTorque(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inTorque, const JPH_EActivation *inActivationMode);

/// Generated from method `JPH::BodyInterface::AddForceAndTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inForce` can not be null. It is a single object.
/// Parameter `inTorque` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `JPH::EActivation::Activate`, pass a null pointer to use it.
JOLT_API void JPH_BodyInterface_AddForceAndTorque(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_Vec3 *inTorque, const JPH_EActivation *inActivationMode);

///@name Add an impulse to the body. Note that you should add a body to the physics system before applying impulses.
///@{
/// Generated from method `JPH::BodyInterface::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddImpulse_2(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inImpulse);

/// Generated from method `JPH::BodyInterface::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddImpulse_3(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inImpulse, const JPH_Vec3 *inPoint);

/// Generated from method `JPH::BodyInterface::AddAngularImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inAngularImpulse` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_AddAngularImpulse(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inAngularImpulse);

/// Generated from method `JPH::BodyInterface::ApplyBuoyancyImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inSurfacePosition` can not be null. It is a single object.
/// Parameter `inSurfaceNormal` can not be null. It is a single object.
/// Parameter `inFluidVelocity` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_ApplyBuoyancyImpulse(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime);

///@name Body motion type
///@{
/// Generated from method `JPH::BodyInterface::SetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetMotionType(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_EMotionType inMotionType, JPH_EActivation inActivationMode);

/// Generated from method `JPH::BodyInterface::GetMotionType`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API JPH_EMotionType JPH_BodyInterface_GetMotionType(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Body motion quality
///@{
/// Generated from method `JPH::BodyInterface::SetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetMotionQuality(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_EMotionQuality inMotionQuality);

/// Generated from method `JPH::BodyInterface::GetMotionQuality`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API JPH_EMotionQuality JPH_BodyInterface_GetMotionQuality(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Get inverse inertia tensor in world space
/// Generated from method `JPH::BodyInterface::GetInverseInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_BodyInterface_GetInverseInertia(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Restitution
///@{
/// Generated from method `JPH::BodyInterface::SetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetRestitution(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inRestitution);

/// Generated from method `JPH::BodyInterface::GetRestitution`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API float JPH_BodyInterface_GetRestitution(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Friction
///@{
/// Generated from method `JPH::BodyInterface::SetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetFriction(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inFriction);

/// Generated from method `JPH::BodyInterface::GetFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API float JPH_BodyInterface_GetFriction(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Gravity factor
///@{
/// Generated from method `JPH::BodyInterface::SetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetGravityFactor(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inGravityFactor);

/// Generated from method `JPH::BodyInterface::GetGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API float JPH_BodyInterface_GetGravityFactor(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Max linear velocity
///@{
/// Generated from method `JPH::BodyInterface::SetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetMaxLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inLinearVelocity);

/// Generated from method `JPH::BodyInterface::GetMaxLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API float JPH_BodyInterface_GetMaxLinearVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Max angular velocity
///@{
/// Generated from method `JPH::BodyInterface::SetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetMaxAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inAngularVelocity);

/// Generated from method `JPH::BodyInterface::GetMaxAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API float JPH_BodyInterface_GetMaxAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Manifold reduction
///@{
/// Generated from method `JPH::BodyInterface::SetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetUseManifoldReduction(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, bool inUseReduction);

/// Generated from method `JPH::BodyInterface::GetUseManifoldReduction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_GetUseManifoldReduction(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Sensor
///@{
/// Generated from method `JPH::BodyInterface::SetIsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetIsSensor(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, bool inIsSensor);

/// Generated from method `JPH::BodyInterface::IsSensor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API bool JPH_BodyInterface_IsSensor(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

///@name Collision group
///@{
/// Generated from method `JPH::BodyInterface::SetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inCollisionGroup` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetCollisionGroup(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_CollisionGroup *inCollisionGroup);

/// Generated from method `JPH::BodyInterface::GetCollisionGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_CollisionGroup *JPH_BodyInterface_GetCollisionGroup(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Get transform and shape for this body, used to perform collision detection
/// Generated from method `JPH::BodyInterface::GetTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_BodyInterface_GetTransformedShape(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Get the user data for a body
/// Generated from method `JPH::BodyInterface::GetUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API uint64_t JPH_BodyInterface_GetUserData(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

/// Generated from method `JPH::BodyInterface::SetUserData`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_SetUserData(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, uint64_t inUserData);

/// Get the material for a particular sub shape
/// Generated from method `JPH::BodyInterface::GetMaterial`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
/// Parameter `inSubShapeID` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_BodyInterface_GetMaterial(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_SubShapeID *inSubShapeID);

/// Set the Body::EFlags::InvalidateContactCache flag for the specified body. This means that the collision cache is invalid for any body pair involving that body until the next physics step.
/// Generated from method `JPH::BodyInterface::InvalidateContactCache`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBodyID` can not be null. It is a single object.
JOLT_API void JPH_BodyInterface_InvalidateContactCache(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID);

#ifdef __cplusplus
} // extern "C"
#endif
