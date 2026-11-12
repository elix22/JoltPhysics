// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_JobSystem JPH_JobSystem; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_JobSystem_Barrier JPH_JobSystem_Barrier; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_JobSystem_JobHandle JPH_JobSystem_JobHandle; // Defined in `#include <jolt/Jolt/Core/JobSystem.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct Jolt_std_function_void Jolt_std_function_void; // Defined in `#include <std_function_void.h>`.


/// Implementation of a JobSystem without threads, runs jobs as soon as they are added
/// Generated from class `JPH::JobSystemSingleThreaded`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::JobSystem`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_JobSystemSingleThreaded JPH_JobSystemSingleThreaded;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystemSingleThreaded_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_JobSystemSingleThreaded_DestroyArray()`.
/// Use `JPH_JobSystemSingleThreaded_OffsetMutablePtr()` and `JPH_JobSystemSingleThreaded_OffsetPtr()` to access the array elements.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_OffsetPtr(const JPH_JobSystemSingleThreaded *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_OffsetMutablePtr(JPH_JobSystemSingleThreaded *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::JobSystemSingleThreaded` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(const JPH_JobSystemSingleThreaded *object);

/// Upcasts an instance of `JPH::JobSystemSingleThreaded` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_JobSystemSingleThreaded_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemSingleThreaded *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemSingleThreaded`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::JobSystemSingleThreaded`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::JobSystemSingleThreaded` to its base class `JPH::JobSystem`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystem *JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(const JPH_JobSystemSingleThreaded *object);

/// Upcasts an instance of `JPH::JobSystemSingleThreaded` to its base class `JPH::JobSystem`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystem *JPH_JobSystemSingleThreaded_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemSingleThreaded *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemSingleThreaded`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object);

/// Downcasts an instance of `JPH::JobSystem` to a derived class `JPH::JobSystemSingleThreaded`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object);

/// Generated from constructor `JPH::JobSystemSingleThreaded::JobSystemSingleThreaded`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystemSingleThreaded_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_Construct(unsigned int inMaxJobs);

/// Destroys a heap-allocated instance of `JPH_JobSystemSingleThreaded`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemSingleThreaded_Destroy(const JPH_JobSystemSingleThreaded *_this);

/// Destroys a heap-allocated array of `JPH_JobSystemSingleThreaded`. Does nothing if the pointer is null.
JOLT_API void JPH_JobSystemSingleThreaded_DestroyArray(const JPH_JobSystemSingleThreaded *_this);

/// Generated from method `JPH::JobSystemSingleThreaded::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemSingleThreaded_size_t(size_t inCount);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::JobSystemSingleThreaded::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemSingleThreaded_size_t(size_t inCount);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::JobSystemSingleThreaded::operator new`.
JOLT_API void *Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
JOLT_API void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::JobSystemSingleThreaded::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Initialize the job system
/// @param inMaxJobs Max number of jobs that can be allocated at any time
/// Generated from method `JPH::JobSystemSingleThreaded::Init`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemSingleThreaded_Init(JPH_JobSystemSingleThreaded *_this, unsigned int inMaxJobs);

// See JobSystem
/// Generated from method `JPH::JobSystemSingleThreaded::GetMaxConcurrency`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_JobSystemSingleThreaded_GetMaxConcurrency(const JPH_JobSystemSingleThreaded *_this);

/// Generated from method `JPH::JobSystemSingleThreaded::CreateJob`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inJobFunction` can not be null. It is a single object.
/// Parameter `inNumDependencies` has a default argument: `0`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_JobSystem_JobHandle_Destroy()` to free it when you're done using it.
JOLT_API JPH_JobSystem_JobHandle *JPH_JobSystemSingleThreaded_CreateJob(JPH_JobSystemSingleThreaded *_this, const char *inName, const JPH_Color *inColor, const Jolt_std_function_void *inJobFunction, const unsigned int *inNumDependencies);

/// Generated from method `JPH::JobSystemSingleThreaded::CreateBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_JobSystem_Barrier *JPH_JobSystemSingleThreaded_CreateBarrier(JPH_JobSystemSingleThreaded *_this);

/// Generated from method `JPH::JobSystemSingleThreaded::DestroyBarrier`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemSingleThreaded_DestroyBarrier(JPH_JobSystemSingleThreaded *_this, JPH_JobSystem_Barrier *inBarrier);

/// Generated from method `JPH::JobSystemSingleThreaded::WaitForJobs`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_JobSystemSingleThreaded_WaitForJobs(JPH_JobSystemSingleThreaded *_this, JPH_JobSystem_Barrier *inBarrier);

#ifdef __cplusplus
} // extern "C"
#endif
