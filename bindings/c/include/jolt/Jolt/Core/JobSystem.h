// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// A job handle contains a reference to a job. The job will be deleted as soon as there are no JobHandles.
/// referring to the job and when it is not in the job queue / being processed.
/// Generated from class `JPH::JobSystem::JobHandle`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_JobSystem_JobHandle JPH_JobSystem_JobHandle;

/// A job barrier keeps track of a number of jobs and allows waiting until they are all completed.
/// Generated from class `JPH::JobSystem::Barrier`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_JobSystem_Barrier JPH_JobSystem_Barrier;

/// A class that allows units of work (Jobs) to be scheduled across multiple threads.
/// It allows dependencies between the jobs so that the jobs form a graph.
///
/// The pattern for using this class is:
///
///		// Create job system
///		JobSystem *job_system = new JobSystemThreadPool(...);
///
///		// Create some jobs
///		JobHandle second_job = job_system->CreateJob("SecondJob", Color::sRed, []() { ... }, 1); // Create a job with 1 dependency
///		JobHandle first_job = job_system->CreateJob("FirstJob", Color::sGreen, [second_job]() { ....; second_job.RemoveDependency(); }, 0); // Job can start immediately, will start second job when it's done
///		JobHandle third_job = job_system->CreateJob("ThirdJob", Color::sBlue, []() { ... }, 0); // This job can run immediately as well and can run in parallel to job 1 and 2
///
///		// Add the jobs to the barrier so that we can execute them while we're waiting
///		Barrier *barrier = job_system->CreateBarrier();
///		barrier->AddJob(first_job);
///		barrier->AddJob(second_job);
///		barrier->AddJob(third_job);
///		job_system->WaitForJobs(barrier);
///
///		// Clean up
///		job_system->DestroyBarrier(barrier);
///		delete job_system;
///
///	Jobs are guaranteed to be started in the order that their dependency counter becomes zero (in case they're scheduled on a background thread)
///	or in the order they're added to the barrier (when dependency count is zero and when executing on the thread that calls WaitForJobs).
///
/// If you want to implement your own job system, inherit from JobSystem and implement:
///
/// * JobSystem::GetMaxConcurrency - This should return the maximum number of jobs that can run in parallel.
/// * JobSystem::CreateJob - This should create a Job object and return it to the caller.
/// * JobSystem::FreeJob - This should free the memory associated with the job object. It is called by the Job destructor when it is Release()-ed for the last time.
/// * JobSystem::QueueJob/QueueJobs - These should store the job pointer in an internal queue to run immediately (dependencies are tracked internally, this function is called when the job can run).
/// The Job objects are reference counted and are guaranteed to stay alive during the QueueJob(s) call. If you store the job in your own data structure you need to call AddRef() to take a reference.
/// After the job has been executed you need to call Release() to release the reference. Make sure you no longer dereference the job pointer after calling Release().
///
/// JobSystem::Barrier is used to track the completion of a set of jobs. Jobs will be created by other jobs and added to the barrier while it is being waited on. This means that you cannot
/// create a dependency graph beforehand as the graph changes while jobs are running. Implement the following functions:
///
/// * Barrier::AddJob/AddJobs - Add a job to the barrier, any call to WaitForJobs will now also wait for this job to complete.
/// If you store the job in a data structure in the Barrier you need to call AddRef() on the job to keep it alive and Release() after you're done with it.
/// * Barrier::OnJobFinished - This function is called when a job has finished executing, you can use this to track completion and remove the job from the list of jobs to wait on.
///
/// The functions on JobSystem that need to be implemented to support barriers are:
///
/// * JobSystem::CreateBarrier - Create a new barrier.
/// * JobSystem::DestroyBarrier - Destroy a barrier.
/// * JobSystem::WaitForJobs - This is the main function that is used to wait for all jobs that have been added to a Barrier. WaitForJobs can execute jobs that have
/// been added to the barrier while waiting. It is not wise to execute other jobs that touch physics structures as this can cause race conditions and deadlocks. Please keep in mind that the barrier is
/// only intended to wait on the completion of the Jolt jobs added to it, if you scheduled any jobs in your engine's job system to execute the Jolt jobs as part of QueueJob/QueueJobs, you might still need
/// to wait for these in this function after the barrier is finished waiting.
///
/// An example implementation is JobSystemThreadPool. If you don't want to write the Barrier class you can also inherit from JobSystemWithBarrier.
/// Generated from class `JPH::JobSystem`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::JobSystemWithBarrier`
///   Indirect: (non-virtual)
///     `JPH::JobSystemThreadPool`
typedef struct JPH_JobSystem JPH_JobSystem;

/// Destroys a heap-allocated instance of `JPH_JobSystem`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystem_Destroy(const JPH_JobSystem *_this);

/// Destroys a heap-allocated array of `JPH_JobSystem`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystem_DestroyArray(const JPH_JobSystem *_this);

/// Generated from method `JPH::JobSystem::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystem_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystem::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystem_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystem::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystem_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystem::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystem::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystem_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystem::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get maximum number of concurrently executing jobs
/// Generated from method `JPH::JobSystem::GetMaxConcurrency`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_JobSystem_GetMaxConcurrency(const JPH_JobSystem *_this);

/// Create a new barrier, used to wait on jobs
/// Generated from method `JPH::JobSystem::CreateBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystem_CreateBarrier(JPH_JobSystem *_this);

/// Destroy a barrier when it is no longer used. The barrier should be empty at this point.
/// Generated from method `JPH::JobSystem::DestroyBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystem_DestroyBarrier(JPH_JobSystem *_this, JPH_JobSystem_Barrier *inBarrier);

/// Wait for a set of jobs to be finished, note that only 1 thread can be waiting on a barrier at a time
/// Generated from method `JPH::JobSystem::WaitForJobs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystem_WaitForJobs(JPH_JobSystem *_this, JPH_JobSystem_Barrier *inBarrier);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystem *JPH_JobSystem_OffsetPtr(const JPH_JobSystem *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystem *JPH_JobSystem_OffsetMutablePtr(JPH_JobSystem *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::JobSystem` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_JobSystem_UpcastTo_JPH_NonCopyable(const JPH_JobSystem *object);

/// Upcasts an instance of `JPH::JobSystem` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_JobSystem_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystem *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystem`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystem *JPH_JobSystem_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystem`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystem *JPH_JobSystem_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystem_JobHandle_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_JobSystem_JobHandle_DestroyArray()`.
/// Use `JPH_JobSystem_JobHandle_OffsetMutablePtr()` and `JPH_JobSystem_JobHandle_OffsetPtr()` to access the array elements.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_OffsetPtr(const JPH_JobSystem_JobHandle *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_OffsetMutablePtr(JPH_JobSystem_JobHandle *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
/// The reference to things referred to by the parameter `inHandle` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystem_JobHandle_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_ConstructFromAnother(Jolt_PassBy inHandle_pass_by, JPH_JobSystem_JobHandle *inHandle);

/// Destroys a heap-allocated instance of `JPH_JobSystem_JobHandle`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystem_JobHandle_Destroy(const JPH_JobSystem_JobHandle *_this);

/// Destroys a heap-allocated array of `JPH_JobSystem_JobHandle`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystem_JobHandle_DestroyArray(const JPH_JobSystem_JobHandle *_this);

/// Assignment
/// Generated from method `JPH::JobSystem::JobHandle::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inHandle` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_AssignFromAnother(JPH_JobSystem_JobHandle *_this, Jolt_PassBy inHandle_pass_by, JPH_JobSystem_JobHandle *inHandle);

/// Check if this handle contains a job
/// Generated from method `JPH::JobSystem::JobHandle::IsValid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_JobSystem_JobHandle_IsValid(const JPH_JobSystem_JobHandle *_this);

/// Check if this job has finished executing
/// Generated from method `JPH::JobSystem::JobHandle::IsDone`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_JobSystem_JobHandle_IsDone(const JPH_JobSystem_JobHandle *_this);

/// Add to the dependency counter.
/// Generated from method `JPH::JobSystem::JobHandle::AddDependency`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCount` has a default argument: `1`, pass a null pointer to use it.
JOLT_API void JPH_JobSystem_JobHandle_AddDependency(const JPH_JobSystem_JobHandle *_this, const int *inCount);

/// Remove from the dependency counter. Job will start whenever the dependency counter reaches zero
/// and if it does it is no longer valid to call the AddDependency/RemoveDependency functions.
/// Generated from method `JPH::JobSystem::JobHandle::RemoveDependency`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCount` has a default argument: `1`, pass a null pointer to use it.
JOLT_API void JPH_JobSystem_JobHandle_RemoveDependency(const JPH_JobSystem_JobHandle *_this, const int *inCount);

/// Remove a dependency from a batch of jobs at once, this can be more efficient than removing them one by one as it requires less locking
/// Generated from method `JPH::JobSystem::JobHandle::sRemoveDependencies`.
/// Parameter `inCount` has a default argument: `1`, pass a null pointer to use it.
JOLT_API void JPH_JobSystem_JobHandle_sRemoveDependencies(const JPH_JobSystem_JobHandle *inHandles, unsigned int inNumHandles, const int *inCount);

/// Generated from method `JPH::JobSystem::Barrier::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystem_Barrier_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystem::Barrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_Barrier_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystem::Barrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_Barrier_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystem::Barrier::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystem::Barrier::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystem_Barrier_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystem::Barrier::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystem::Barrier::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Add a job to this barrier
/// Note that jobs can keep being added to the barrier while waiting for the barrier
/// Generated from method `JPH::JobSystem::Barrier::AddJob`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inJob` can not be null. It is a single object.
JOLT_API void JPH_JobSystem_Barrier_AddJob(JPH_JobSystem_Barrier *_this, const JPH_JobSystem_JobHandle *inJob);

/// Add multiple jobs to this barrier
/// Note that jobs can keep being added to the barrier while waiting for the barrier
/// Generated from method `JPH::JobSystem::Barrier::AddJobs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystem_Barrier_AddJobs(JPH_JobSystem_Barrier *_this, const JPH_JobSystem_JobHandle *inHandles, unsigned int inNumHandles);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_OffsetPtr(const JPH_JobSystem_Barrier *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_OffsetMutablePtr(JPH_JobSystem_Barrier *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::JobSystem::Barrier` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(const JPH_JobSystem_Barrier *object);

/// Upcasts an instance of `JPH::JobSystem::Barrier` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_JobSystem_Barrier_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystem_Barrier *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystem::Barrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystem::Barrier`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

#ifdef __cplusplus
} // extern "C"
#endif
