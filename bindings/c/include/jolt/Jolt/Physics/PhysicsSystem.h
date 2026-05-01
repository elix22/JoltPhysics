// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/EPhysicsUpdateError.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Body JPH_Body; // Defined in `#include <jolt/Jolt/Physics/Body/Body.h>`.
typedef struct JPH_BodyActivationListener JPH_BodyActivationListener; // Defined in `#include <jolt/Jolt/Physics/Body/BodyActivationListener.h>`.
typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_BodyInterface JPH_BodyInterface; // Defined in `#include <jolt/Jolt/Physics/Body/BodyInterface.h>`.
typedef struct JPH_BroadPhaseLayerInterface JPH_BroadPhaseLayerInterface; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_BroadPhaseQuery JPH_BroadPhaseQuery; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseQuery.h>`.
typedef struct JPH_CollideShapeSettings JPH_CollideShapeSettings; // Defined in `#include <jolt/Jolt/Physics/Collision/CollideShape.h>`.
typedef struct JPH_Constraint JPH_Constraint; // Defined in `#include <jolt/Jolt/Physics/Constraints/Constraint.h>`.
typedef struct JPH_ContactListener JPH_ContactListener; // Defined in `#include <jolt/Jolt/Physics/Collision/ContactListener.h>`.
typedef struct JPH_DefaultBroadPhaseLayerFilter JPH_DefaultBroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_DefaultObjectLayerFilter JPH_DefaultObjectLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_JobSystem JPH_JobSystem; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NarrowPhaseQuery JPH_NarrowPhaseQuery; // Defined in `#include <jolt/Jolt/Physics/Collision/NarrowPhaseQuery.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_ObjectLayerPairFilter JPH_ObjectLayerPairFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/ObjectLayer.h>`.
typedef struct JPH_ObjectVsBroadPhaseLayerFilter JPH_ObjectVsBroadPhaseLayerFilter; // Defined in `#include <jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>`.
typedef struct JPH_PhysicsSettings JPH_PhysicsSettings; // Defined in `#include <jolt/Jolt/Physics/PhysicsSettings.h>`.
typedef struct JPH_PhysicsStepListener JPH_PhysicsStepListener; // Defined in `#include <jolt/Jolt/Physics/PhysicsStepListener.h>`.
typedef struct JPH_TempAllocator JPH_TempAllocator; // Defined in `#include <jolt/Jolt/Core/TempAllocator.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// The main class for the physics system. It contains all rigid bodies and simulates them.
///
/// The main simulation is performed by the Update() call on multiple threads (if the JobSystem is configured to use them). Please refer to the general architecture overview in the Docs folder for more information.
/// Generated from class `JPH::PhysicsSystem`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem;

/// The maximum value that can be passed to Init for inMaxBodies.
/// Returns a pointer to a member variable of class `JPH::PhysicsSystem` named `cMaxBodiesLimit`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_PhysicsSystem_Get_cMaxBodiesLimit(void);

/// The maximum value that can be passed to Init for inMaxBodyPairs.
/// Note you should really use a lower value, using this value will cost a lot of memory!
/// On a 32 bit platform, you'll run out of memory way before you reach this limit.
/// Returns a pointer to a member variable of class `JPH::PhysicsSystem` named `cMaxBodyPairsLimit`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_PhysicsSystem_Get_cMaxBodyPairsLimit(void);

/// The maximum value that can be passed to Init for inMaxContactConstraints.
/// Note you should really use a lower value, using this value will cost a lot of memory!
/// On a 32 bit platform, you'll run out of memory way before you reach this limit.
/// Returns a pointer to a member variable of class `JPH::PhysicsSystem` named `cMaxContactConstraintsLimit`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsSystem_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsSystem *JPH_PhysicsSystem_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PhysicsSystem_DestroyArray()`.
/// Use `JPH_PhysicsSystem_OffsetMutablePtr()` and `JPH_PhysicsSystem_OffsetPtr()` to access the array elements.
JOLT_API JPH_PhysicsSystem *JPH_PhysicsSystem_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsSystem *JPH_PhysicsSystem_OffsetPtr(const JPH_PhysicsSystem *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsSystem *JPH_PhysicsSystem_OffsetMutablePtr(JPH_PhysicsSystem *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::PhysicsSystem` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(const JPH_PhysicsSystem *object);

/// Upcasts an instance of `JPH::PhysicsSystem` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_PhysicsSystem_MutableUpcastTo_JPH_NonCopyable(JPH_PhysicsSystem *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PhysicsSystem`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_PhysicsSystem *JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::PhysicsSystem`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_PhysicsSystem *JPH_PhysicsSystem_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_PhysicsSystem`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsSystem_Destroy(const JPH_PhysicsSystem *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsSystem`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsSystem_DestroyArray(const JPH_PhysicsSystem *_this);

/// Generated from method `JPH::PhysicsSystem::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsSystem_size_t(size_t inCount);

/// Generated from method `JPH::PhysicsSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSystem_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PhysicsSystem::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsSystem_size_t(size_t inCount);

/// Generated from method `JPH::PhysicsSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSystem_void_ptr(void *inPointer);

/// Generated from method `JPH::PhysicsSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::PhysicsSystem::operator new`.
JOLT_API void *Jolt_new_JPH_PhysicsSystem_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PhysicsSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::PhysicsSystem::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::PhysicsSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Initialize the system.
/// @param inMaxBodies Maximum number of bodies to support.
/// @param inNumBodyMutexes Number of body mutexes to use. Should be a power of 2 in the range [1, 64], use 0 to auto detect.
/// @param inMaxBodyPairs Maximum amount of body pairs to process (anything else will fall through the world), this number should generally be much higher than the max amount of contact points as there will be lots of bodies close that are not actually touching.
/// @param inMaxContactConstraints Maximum amount of contact constraints to process (anything else will fall through the world).
/// @param inBroadPhaseLayerInterface Information on the mapping of object layers to broad phase layers. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
/// @param inObjectVsBroadPhaseLayerFilter Filter callback function that is used to determine if an object layer collides with a broad phase layer. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
/// @param inObjectLayerPairFilter Filter callback function that is used to determine if two object layers collide. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
/// Generated from method `JPH::PhysicsSystem::Init`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBroadPhaseLayerInterface` can not be null. It is a single object.
/// Parameter `inObjectVsBroadPhaseLayerFilter` can not be null. It is a single object.
/// Parameter `inObjectLayerPairFilter` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_Init(JPH_PhysicsSystem *_this, unsigned int inMaxBodies, unsigned int inNumBodyMutexes, unsigned int inMaxBodyPairs, unsigned int inMaxContactConstraints, const JPH_BroadPhaseLayerInterface *inBroadPhaseLayerInterface, const JPH_ObjectVsBroadPhaseLayerFilter *inObjectVsBroadPhaseLayerFilter, const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter);

/// Listener that is notified whenever a body is activated/deactivated
/// Generated from method `JPH::PhysicsSystem::SetBodyActivationListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_SetBodyActivationListener(JPH_PhysicsSystem *_this, JPH_BodyActivationListener *inListener);

/// Generated from method `JPH::PhysicsSystem::GetBodyActivationListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyActivationListener *JPH_PhysicsSystem_GetBodyActivationListener(const JPH_PhysicsSystem *_this);

/// Listener that is notified whenever a contact point between two bodies is added/updated/removed.
/// You can't change contact listener during PhysicsSystem::Update but it can be changed at any other time.
/// Generated from method `JPH::PhysicsSystem::SetContactListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_SetContactListener(JPH_PhysicsSystem *_this, JPH_ContactListener *inListener);

/// Generated from method `JPH::PhysicsSystem::GetContactListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_ContactListener *JPH_PhysicsSystem_GetContactListener(const JPH_PhysicsSystem *_this);

/// Control the main constants of the physics simulation
/// Generated from method `JPH::PhysicsSystem::SetPhysicsSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inSettings` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_SetPhysicsSettings(JPH_PhysicsSystem *_this, const JPH_PhysicsSettings *inSettings);

/// Generated from method `JPH::PhysicsSystem::GetPhysicsSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_PhysicsSettings *JPH_PhysicsSystem_GetPhysicsSettings(const JPH_PhysicsSystem *_this);

/// Access to the body interface. This interface allows to to create / remove bodies and to change their properties.
/// Generated from method `JPH::PhysicsSystem::GetBodyInterface`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterface(const JPH_PhysicsSystem *_this);

/// Generated from method `JPH::PhysicsSystem::GetBodyInterface`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterface_mut(JPH_PhysicsSystem *_this);

/// Generated from method `JPH::PhysicsSystem::GetBodyInterfaceNoLock`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterfaceNoLock(const JPH_PhysicsSystem *_this);

/// Generated from method `JPH::PhysicsSystem::GetBodyInterfaceNoLock`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut(JPH_PhysicsSystem *_this);

/// Access to the broadphase interface that allows coarse collision queries
/// Generated from method `JPH::PhysicsSystem::GetBroadPhaseQuery`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BroadPhaseQuery *JPH_PhysicsSystem_GetBroadPhaseQuery(const JPH_PhysicsSystem *_this);

/// Interface that allows fine collision queries against first the broad phase and then the narrow phase.
/// Generated from method `JPH::PhysicsSystem::GetNarrowPhaseQuery`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_NarrowPhaseQuery *JPH_PhysicsSystem_GetNarrowPhaseQuery(const JPH_PhysicsSystem *_this);

/// Generated from method `JPH::PhysicsSystem::GetNarrowPhaseQueryNoLock`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_NarrowPhaseQuery *JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(const JPH_PhysicsSystem *_this);

/// Add constraint to the world
/// Generated from method `JPH::PhysicsSystem::AddConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_AddConstraint(JPH_PhysicsSystem *_this, JPH_Constraint *inConstraint);

/// Remove constraint from the world
/// Generated from method `JPH::PhysicsSystem::RemoveConstraint`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_RemoveConstraint(JPH_PhysicsSystem *_this, JPH_Constraint *inConstraint);

/// Batch add constraints.
/// Generated from method `JPH::PhysicsSystem::AddConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_AddConstraints(JPH_PhysicsSystem *_this, JPH_Constraint **inConstraints, int inNumber);

/// Batch remove constraints.
/// Generated from method `JPH::PhysicsSystem::RemoveConstraints`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_RemoveConstraints(JPH_PhysicsSystem *_this, JPH_Constraint **inConstraints, int inNumber);

/// Optimize the broadphase, needed only if you've added many bodies prior to calling Update() for the first time.
/// Don't call this every frame as PhysicsSystem::Update spreads out the same work over multiple frames.
/// If you add many bodies through BodyInterface::AddBodiesPrepare/AddBodiesFinalize and if the bodies in a batch are
/// in a roughly unoccupied space (e.g. a new level section) then a call to OptimizeBroadPhase is also not needed
/// as batch adding creates an efficient bounding volume hierarchy.
/// Don't call this function while bodies are being modified from another thread or use the locking BodyInterface to modify bodies.
/// Generated from method `JPH::PhysicsSystem::OptimizeBroadPhase`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_OptimizeBroadPhase(JPH_PhysicsSystem *_this);

/// Adds a new step listener
/// Generated from method `JPH::PhysicsSystem::AddStepListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_AddStepListener(JPH_PhysicsSystem *_this, JPH_PhysicsStepListener *inListener);

/// Removes a step listener
/// Generated from method `JPH::PhysicsSystem::RemoveStepListener`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_RemoveStepListener(JPH_PhysicsSystem *_this, JPH_PhysicsStepListener *inListener);

/// Simulate the system.
/// The world steps for a total of inDeltaTime seconds. This is divided in inCollisionSteps iterations.
/// Each iteration consists of collision detection followed by an integration step.
/// This function internally spawns jobs using inJobSystem and waits for them to complete, so no jobs will be running when this function returns.
/// The temp allocator is used, for example, to store the list of bodies that are in contact, how they form islands together
/// and data to solve the contacts between bodies. At the end of the Update call, all allocated memory will have been freed.
/// Generated from method `JPH::PhysicsSystem::Update`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_EPhysicsUpdateError JPH_PhysicsSystem_Update(JPH_PhysicsSystem *_this, float inDeltaTime, int inCollisionSteps, JPH_TempAllocator *inTempAllocator, JPH_JobSystem *inJobSystem);

/// Set gravity value
/// Generated from method `JPH::PhysicsSystem::SetGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inGravity` can not be null. It is a single object.
JOLT_API void JPH_PhysicsSystem_SetGravity(JPH_PhysicsSystem *_this, const JPH_Vec3 *inGravity);

/// Generated from method `JPH::PhysicsSystem::GetGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_PhysicsSystem_GetGravity(const JPH_PhysicsSystem *_this);

/// Broadphase layer filter that decides if two objects can collide, this was passed to the Init function.
/// Generated from method `JPH::PhysicsSystem::GetObjectVsBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_ObjectVsBroadPhaseLayerFilter *JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter(const JPH_PhysicsSystem *_this);

/// Object layer filter that decides if two objects can collide, this was passed to the Init function.
/// Generated from method `JPH::PhysicsSystem::GetObjectLayerPairFilter`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_ObjectLayerPairFilter *JPH_PhysicsSystem_GetObjectLayerPairFilter(const JPH_PhysicsSystem *_this);

/// Get an broadphase layer filter that uses the default pair filter and a specified object layer to determine if broadphase layers collide
/// Generated from method `JPH::PhysicsSystem::GetDefaultBroadPhaseLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DefaultBroadPhaseLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_DefaultBroadPhaseLayerFilter *JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter(const JPH_PhysicsSystem *_this, unsigned short inLayer);

/// Get an object layer filter that uses the default pair filter and a specified layer to determine if layers collide
/// Generated from method `JPH::PhysicsSystem::GetDefaultLayerFilter`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DefaultObjectLayerFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_DefaultObjectLayerFilter *JPH_PhysicsSystem_GetDefaultLayerFilter(const JPH_PhysicsSystem *_this, unsigned short inLayer);

/// Gets the current amount of bodies that are in the body manager
/// Generated from method `JPH::PhysicsSystem::GetNumBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PhysicsSystem_GetNumBodies(const JPH_PhysicsSystem *_this);

/// Get the maximum amount of bodies that this physics system supports
/// Generated from method `JPH::PhysicsSystem::GetMaxBodies`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_PhysicsSystem_GetMaxBodies(const JPH_PhysicsSystem *_this);

/// Check if 2 bodies were in contact during the last simulation step. Since contacts are only detected between active bodies, so at least one of the bodies must be active in order for this function to work.
/// It queries the state at the time of the last PhysicsSystem::Update and will return true if the bodies were in contact, even if one of the bodies was moved / removed afterwards.
/// This function can be called from any thread when the PhysicsSystem::Update is not running. During PhysicsSystem::Update this function is only valid during contact callbacks:
/// - During the ContactListener::OnContactAdded callback this function can be used to determine if a different contact pair between the bodies was active in the previous simulation step (function returns true) or if this is the first step that the bodies are touching (function returns false).
/// - During the ContactListener::OnContactRemoved callback this function can be used to determine if this is the last contact pair between the bodies (function returns false) or if there are other contacts still present (function returns true).
/// Generated from method `JPH::PhysicsSystem::WereBodiesInContact`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBody1ID` can not be null. It is a single object.
/// Parameter `inBody2ID` can not be null. It is a single object.
JOLT_API bool JPH_PhysicsSystem_WereBodiesInContact(const JPH_PhysicsSystem *_this, const JPH_BodyID *inBody1ID, const JPH_BodyID *inBody2ID);

/// Get the bounding box of all bodies in the physics system.
/// Deprecated: Use GetBroadPhaseQuery().GetBounds() instead.
/// Generated from method `JPH::PhysicsSystem::GetBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_PhysicsSystem_GetBounds(const JPH_PhysicsSystem *_this);

#ifdef __cplusplus
} // extern "C"
#endif
