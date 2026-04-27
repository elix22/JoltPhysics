// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_JobSystem JPH_JobSystem; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_JobSystemWithBarrier JPH_JobSystemWithBarrier; // Defined in `#include <jolt/Jolt/Core/JobSystemWithBarrier.h>`.
typedef struct JPH_JobSystem_Barrier JPH_JobSystem_Barrier; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct Jolt_std_function_void_from_int Jolt_std_function_void_from_int; // Defined in `#include <std_function_void_from_int.h>`.


/// Implementation of a JobSystem using a thread pool
///
/// Note that this is considered an example implementation. It is expected that when you integrate
/// the physics engine into your own project that you'll provide your own implementation of the
/// JobSystem built on top of whatever job system your project uses.
/// Generated from class `JPH::JobSystemThreadPool`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::JobSystemWithBarrier`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
///     `JPH::JobSystem`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_JobSystemThreadPool JPH_JobSystemThreadPool;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystemThreadPool_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_JobSystemThreadPool_DestroyArray()`.
/// Use `JPH_JobSystemThreadPool_OffsetMutablePtr()` and `JPH_JobSystemThreadPool_OffsetPtr()` to access the array elements.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_OffsetPtr(const JPH_JobSystemThreadPool *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_OffsetMutablePtr(JPH_JobSystemThreadPool *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(const JPH_JobSystemThreadPool *object);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemThreadPool *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::JobSystem`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystem *JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(const JPH_JobSystemThreadPool *object);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::JobSystem`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystem *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemThreadPool *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::JobSystemWithBarrier`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemWithBarrier *JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(const JPH_JobSystemThreadPool *object);

/// Upcasts an instance of `JPH::JobSystemThreadPool` to its base class `JPH::JobSystemWithBarrier`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemWithBarrier *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_JobSystemWithBarrier(JPH_JobSystemThreadPool *object);

/// Downcasts an instance of `JPH::JobSystemWithBarrier` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_JobSystemWithBarrier(const JPH_JobSystemWithBarrier *object);

/// Downcasts an instance of `JPH::JobSystemWithBarrier` to a derived class `JPH::JobSystemThreadPool`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_JobSystemWithBarrier(JPH_JobSystemWithBarrier *object);

/// Creates a thread pool.
/// @see JobSystemThreadPool::Init
/// Generated from constructor `JPH::JobSystemThreadPool::JobSystemThreadPool`.
/// Parameter `inNumThreads` has a default argument: `-1`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystemThreadPool_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_Construct(unsigned int inMaxJobs, unsigned int inMaxBarriers, const int *inNumThreads);

/// Destroys a heap-allocated instance of `JPH_JobSystemThreadPool`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemThreadPool_Destroy(const JPH_JobSystemThreadPool *_this);

/// Destroys a heap-allocated array of `JPH_JobSystemThreadPool`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemThreadPool_DestroyArray(const JPH_JobSystemThreadPool *_this);

/// Generated from method `JPH::JobSystemThreadPool::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemThreadPool_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystemThreadPool::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemThreadPool_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemThreadPool::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemThreadPool_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystemThreadPool::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::JobSystemThreadPool::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemThreadPool_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystemThreadPool::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystemThreadPool::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystemThreadPool::SetThreadInitFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inInitFunction` can not be null. It is a single object.
JOLT_API void JPH_JobSystemThreadPool_SetThreadInitFunction(JPH_JobSystemThreadPool *_this, const Jolt_std_function_void_from_int *inInitFunction);

/// Generated from method `JPH::JobSystemThreadPool::SetThreadExitFunction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inExitFunction` can not be null. It is a single object.
JOLT_API void JPH_JobSystemThreadPool_SetThreadExitFunction(JPH_JobSystemThreadPool *_this, const Jolt_std_function_void_from_int *inExitFunction);

/// Initialize the thread pool
/// @param inMaxJobs Max number of jobs that can be allocated at any time
/// @param inMaxBarriers Max number of barriers that can be allocated at any time
/// @param inNumThreads Number of threads to start (the number of concurrent jobs is 1 more because the main thread will also run jobs while waiting for a barrier to complete). Use -1 to auto detect the amount of CPU's.
/// Generated from method `JPH::JobSystemThreadPool::Init`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inNumThreads` has a default argument: `-1`, pass a null pointer to use it.
JOLT_API void JPH_JobSystemThreadPool_Init(JPH_JobSystemThreadPool *_this, unsigned int inMaxJobs, unsigned int inMaxBarriers, const int *inNumThreads);

// See JobSystem
/// Generated from method `JPH::JobSystemThreadPool::GetMaxConcurrency`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_JobSystemThreadPool_GetMaxConcurrency(const JPH_JobSystemThreadPool *_this);

/// Change the max concurrency after initialization
/// Generated from method `JPH::JobSystemThreadPool::SetNumThreads`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemThreadPool_SetNumThreads(JPH_JobSystemThreadPool *_this, int inNumThreads);

// See JobSystem
/// Generated from method `JPH::JobSystemThreadPool::CreateBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystemThreadPool_CreateBarrier(JPH_JobSystemThreadPool *_this);

/// Generated from method `JPH::JobSystemThreadPool::DestroyBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemThreadPool_DestroyBarrier(JPH_JobSystemThreadPool *_this, JPH_JobSystem_Barrier *inBarrier);

/// Generated from method `JPH::JobSystemThreadPool::WaitForJobs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemThreadPool_WaitForJobs(JPH_JobSystemThreadPool *_this, JPH_JobSystem_Barrier *inBarrier);

#ifdef __cplusplus
} // extern "C"
#endif
