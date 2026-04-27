// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_JobSystem JPH_JobSystem; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_JobSystem_Barrier JPH_JobSystem_Barrier; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// Implementation of the Barrier class for a JobSystem
///
/// This class can be used to make it easier to create a new JobSystem implementation that integrates with your own job system.
/// It will implement all functionality relating to barriers, so the only functions that are left to be implemented are:
///
/// * JobSystem::GetMaxConcurrency
/// * JobSystem::CreateJob
/// * JobSystem::FreeJob
/// * JobSystem::QueueJob/QueueJobs
///
/// See instructions in JobSystem for more information on how to implement these.
/// Generated from class `JPH::JobSystemWithBarrier`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::JobSystem`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::JobSystemThreadPool`
typedef struct JPH_JobSystemWithBarrier JPH_JobSystemWithBarrier;

/// Destroys a heap-allocated instance of `JPH_JobSystemWithBarrier`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemWithBarrier_Destroy(const JPH_JobSystemWithBarrier *_this);

/// Destroys a heap-allocated array of `JPH_JobSystemWithBarrier`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemWithBarrier_DestroyArray(const JPH_JobSystemWithBarrier *_this);

/// Generated from method `JPH::JobSystemWithBarrier::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemWithBarrier_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystemWithBarrier::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystemWithBarrier::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystemWithBarrier::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Initialize the barriers
/// @param inMaxBarriers Max number of barriers that can be allocated at any time
/// Generated from method `JPH::JobSystemWithBarrier::Init`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemWithBarrier_Init(JPH_JobSystemWithBarrier *_this, unsigned int inMaxBarriers);

// See JobSystem
/// Generated from method `JPH::JobSystemWithBarrier::CreateBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystemWithBarrier_CreateBarrier(JPH_JobSystemWithBarrier *_this);

/// Generated from method `JPH::JobSystemWithBarrier::DestroyBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemWithBarrier_DestroyBarrier(JPH_JobSystemWithBarrier *_this, JPH_JobSystem_Barrier *inBarrier);

/// Generated from method `JPH::JobSystemWithBarrier::WaitForJobs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemWithBarrier_WaitForJobs(JPH_JobSystemWithBarrier *_this, JPH_JobSystem_Barrier *inBarrier);

/// Get maximum number of concurrently executing jobs
/// Generated from method `JPH::JobSystemWithBarrier::GetMaxConcurrency`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_JobSystemWithBarrier_GetMaxConcurrency(const JPH_JobSystemWithBarrier *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_OffsetPtr(const JPH_JobSystemWithBarrier *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_OffsetMutablePtr(JPH_JobSystemWithBarrier *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::JobSystemWithBarrier` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(const JPH_JobSystemWithBarrier *object);

/// Upcasts an instance of `JPH::JobSystemWithBarrier` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_JobSystemWithBarrier_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemWithBarrier *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemWithBarrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemWithBarrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::JobSystemWithBarrier` to its base class `JPH::JobSystem`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystem *JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(const JPH_JobSystemWithBarrier *object);

/// Upcasts an instance of `JPH::JobSystemWithBarrier` to its base class `JPH::JobSystem`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystem *JPH_JobSystemWithBarrier_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemWithBarrier *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemWithBarrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemWithBarrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object);

#ifdef __cplusplus
} // extern "C"
#endif
