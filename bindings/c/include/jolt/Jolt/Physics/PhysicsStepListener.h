// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.


/// Context information for the step listener
/// Generated from class `JPH::PhysicsStepListenerContext`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_PhysicsStepListenerContext JPH_PhysicsStepListenerContext;

/// A listener class that receives a callback before every physics simulation step
/// Generated from class `JPH::PhysicsStepListener`.
typedef struct JPH_PhysicsStepListener JPH_PhysicsStepListener;

///< Delta time of the current step
/// Returns a pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_PhysicsStepListenerContext_Get_mDeltaTime(const JPH_PhysicsStepListenerContext *_this);

///< Delta time of the current step
/// Modifies a member variable of class `JPH::PhysicsStepListenerContext` named `mDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDeltaTime`.
JOLT_API void JPH_PhysicsStepListenerContext_Set_mDeltaTime(JPH_PhysicsStepListenerContext *_this, float value);

///< Delta time of the current step
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mDeltaTime`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime(JPH_PhysicsStepListenerContext *_this);

///< True if this is the first step
/// Returns a pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mIsFirstStep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsStepListenerContext_Get_mIsFirstStep(const JPH_PhysicsStepListenerContext *_this);

///< True if this is the first step
/// Modifies a member variable of class `JPH::PhysicsStepListenerContext` named `mIsFirstStep`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsFirstStep`.
JOLT_API void JPH_PhysicsStepListenerContext_Set_mIsFirstStep(JPH_PhysicsStepListenerContext *_this, bool value);

///< True if this is the first step
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mIsFirstStep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep(JPH_PhysicsStepListenerContext *_this);

///< True if this is the last step
/// Returns a pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mIsLastStep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_PhysicsStepListenerContext_Get_mIsLastStep(const JPH_PhysicsStepListenerContext *_this);

///< True if this is the last step
/// Modifies a member variable of class `JPH::PhysicsStepListenerContext` named `mIsLastStep`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mIsLastStep`.
JOLT_API void JPH_PhysicsStepListenerContext_Set_mIsLastStep(JPH_PhysicsStepListenerContext *_this, bool value);

///< True if this is the last step
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mIsLastStep`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep(JPH_PhysicsStepListenerContext *_this);

///< The physics system that is being stepped
/// Returns a pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_PhysicsSystem *const *JPH_PhysicsStepListenerContext_Get_mPhysicsSystem(const JPH_PhysicsStepListenerContext *_this);

///< The physics system that is being stepped
/// Modifies a member variable of class `JPH::PhysicsStepListenerContext` named `mPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mPhysicsSystem`.
/// When this function is called, this object will drop object references it held previously in `mPhysicsSystem`.
JOLT_API void JPH_PhysicsStepListenerContext_Set_mPhysicsSystem(JPH_PhysicsStepListenerContext *_this, JPH_PhysicsSystem *value);

///< The physics system that is being stepped
/// Returns a mutable pointer to a member variable of class `JPH::PhysicsStepListenerContext` named `mPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_PhysicsSystem **JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem(JPH_PhysicsStepListenerContext *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsStepListenerContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_PhysicsStepListenerContext_DestroyArray()`.
/// Use `JPH_PhysicsStepListenerContext_OffsetMutablePtr()` and `JPH_PhysicsStepListenerContext_OffsetPtr()` to access the array elements.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::PhysicsStepListenerContext` elementwise.
/// The reference to the parameter `mPhysicsSystem` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsStepListenerContext_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_ConstructFrom(float mDeltaTime, bool mIsFirstStep, bool mIsLastStep, JPH_PhysicsSystem *mPhysicsSystem);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_OffsetPtr(const JPH_PhysicsStepListenerContext *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_OffsetMutablePtr(JPH_PhysicsStepListenerContext *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::PhysicsStepListenerContext::PhysicsStepListenerContext`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_PhysicsStepListenerContext_Destroy()` to free it when you're done using it.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_ConstructFromAnother(const JPH_PhysicsStepListenerContext *_other);

/// Destroys a heap-allocated instance of `JPH_PhysicsStepListenerContext`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsStepListenerContext_Destroy(const JPH_PhysicsStepListenerContext *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsStepListenerContext`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsStepListenerContext_DestroyArray(const JPH_PhysicsStepListenerContext *_this);

/// Generated from method `JPH::PhysicsStepListenerContext::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_AssignFromAnother(JPH_PhysicsStepListenerContext *_this, const JPH_PhysicsStepListenerContext *_other);

/// Destroys a heap-allocated instance of `JPH_PhysicsStepListener`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsStepListener_Destroy(const JPH_PhysicsStepListener *_this);

/// Destroys a heap-allocated array of `JPH_PhysicsStepListener`. Does nothing if the pointer is null.
JOLT_API void JPH_PhysicsStepListener_DestroyArray(const JPH_PhysicsStepListener *_this);

/// Called before every simulation step (received inCollisionSteps times for every PhysicsSystem::Update(...) call)
/// This is called while all body and constraint mutexes are locked. You can read/write bodies and constraints but not add/remove them.
/// Multiple listeners can be executed in parallel and it is the responsibility of the listener to avoid race conditions.
/// The best way to do this is to have each step listener operate on a subset of the bodies and constraints
/// and making sure that these bodies and constraints are not touched by any other step listener.
/// Note that this function is not called if there aren't any active bodies or when the physics system is updated with 0 delta time.
/// Generated from method `JPH::PhysicsStepListener::OnStep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inContext` can not be null. It is a single object.
JOLT_API void JPH_PhysicsStepListener_OnStep(JPH_PhysicsStepListener *_this, const JPH_PhysicsStepListenerContext *inContext);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_PhysicsStepListener *JPH_PhysicsStepListener_OffsetPtr(const JPH_PhysicsStepListener *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_PhysicsStepListener *JPH_PhysicsStepListener_OffsetMutablePtr(JPH_PhysicsStepListener *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
