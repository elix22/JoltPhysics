// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.


/// Allocator for temporary allocations.
/// This allocator works as a stack: The blocks must always be freed in the reverse order as they are allocated.
/// Note that allocations and frees can take place from different threads, but the order is guaranteed though
/// job dependencies, so it is not needed to use any form of locking.
/// Generated from class `JPH::TempAllocator`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::TempAllocatorImpl`
///     `JPH::TempAllocatorImplWithMallocFallback`
///     `JPH::TempAllocatorMalloc`
typedef struct JPH_TempAllocator JPH_TempAllocator;

/// Default implementation of the temp allocator that allocates a large block through malloc upfront
/// Generated from class `JPH::TempAllocatorImpl`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TempAllocator`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_TempAllocatorImpl JPH_TempAllocatorImpl;

/// Implementation of the TempAllocator that just falls back to malloc/free
/// Note: This can be quite slow when running in the debugger as large memory blocks need to be initialized with 0xcd
/// Generated from class `JPH::TempAllocatorMalloc`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TempAllocator`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_TempAllocatorMalloc JPH_TempAllocatorMalloc;

/// Implementation of the TempAllocator that tries to allocate from a large preallocated block, but falls back to malloc when it is exhausted
/// Generated from class `JPH::TempAllocatorImplWithMallocFallback`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::TempAllocator`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
typedef struct JPH_TempAllocatorImplWithMallocFallback JPH_TempAllocatorImplWithMallocFallback;

/// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
/// Returns a pointer to a member variable of class `JPH::TempAllocator` named `needs_aligned_allocate`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_TempAllocator_Get_needs_aligned_allocate(void);

/// Destroys a heap-allocated instance of `JPH_TempAllocator`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocator_Destroy(const JPH_TempAllocator *_this);

/// Destroys a heap-allocated array of `JPH_TempAllocator`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocator_DestroyArray(const JPH_TempAllocator *_this);

/// Generated from method `JPH::TempAllocator::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocator_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocator::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocator_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocator::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocator_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocator::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocator_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocator::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocator_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocator::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocator_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocator::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocator_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocator::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TempAllocator::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocator_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocator::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Allocates inSize bytes of memory, returned memory address must be JPH_RVECTOR_ALIGNMENT byte aligned
/// Generated from method `JPH::TempAllocator::Allocate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_TempAllocator_Allocate(JPH_TempAllocator *_this, unsigned int inSize);

/// Frees inSize bytes of memory located at inAddress
/// Generated from method `JPH::TempAllocator::Free`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TempAllocator_Free(JPH_TempAllocator *_this, void *inAddress, unsigned int inSize);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TempAllocator *JPH_TempAllocator_OffsetPtr(const JPH_TempAllocator *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TempAllocator *JPH_TempAllocator_OffsetMutablePtr(JPH_TempAllocator *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TempAllocator` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TempAllocator_UpcastTo_JPH_NonCopyable(const JPH_TempAllocator *object);

/// Upcasts an instance of `JPH::TempAllocator` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TempAllocator_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocator *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocator`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocator *JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocator`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocator *JPH_TempAllocator_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
/// Returns a pointer to a member variable of class `JPH::TempAllocatorImpl` named `needs_aligned_allocate`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_TempAllocatorImpl_Get_needs_aligned_allocate(void);

/// Constructs the allocator with a maximum allocatable size of inSize
/// Generated from constructor `JPH::TempAllocatorImpl::TempAllocatorImpl`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TempAllocatorImpl_Destroy()` to free it when you're done using it.
JOLT_API JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_Construct(unsigned long inSize);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_OffsetPtr(const JPH_TempAllocatorImpl *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_OffsetMutablePtr(JPH_TempAllocatorImpl *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TempAllocatorImpl` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorImpl *object);

/// Upcasts an instance of `JPH::TempAllocatorImpl` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TempAllocatorImpl_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorImpl *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorImpl`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorImpl`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TempAllocatorImpl` to its base class `JPH::TempAllocator`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocator *JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorImpl *object);

/// Upcasts an instance of `JPH::TempAllocatorImpl` to its base class `JPH::TempAllocator`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocator *JPH_TempAllocatorImpl_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorImpl *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorImpl`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorImpl`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object);

/// Destroys a heap-allocated instance of `JPH_TempAllocatorImpl`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorImpl_Destroy(const JPH_TempAllocatorImpl *_this);

/// Destroys a heap-allocated array of `JPH_TempAllocatorImpl`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorImpl_DestroyArray(const JPH_TempAllocatorImpl *_this);

/// Generated from method `JPH::TempAllocatorImpl::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorImpl_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorImpl::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImpl_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorImpl::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImpl_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorImpl::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorImpl_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorImpl::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorImpl_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorImpl::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TempAllocatorImpl::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorImpl_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorImpl::Allocate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_TempAllocatorImpl_Allocate(JPH_TempAllocatorImpl *_this, unsigned int inSize);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorImpl::Free`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TempAllocatorImpl_Free(JPH_TempAllocatorImpl *_this, void *inAddress, unsigned int inSize);

/// Check if no allocations have been made
/// Generated from method `JPH::TempAllocatorImpl::IsEmpty`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TempAllocatorImpl_IsEmpty(const JPH_TempAllocatorImpl *_this);

/// Get the total size of the fixed buffer
/// Generated from method `JPH::TempAllocatorImpl::GetSize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t JPH_TempAllocatorImpl_GetSize(const JPH_TempAllocatorImpl *_this);

/// Get current usage in bytes of the buffer
/// Generated from method `JPH::TempAllocatorImpl::GetUsage`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t JPH_TempAllocatorImpl_GetUsage(const JPH_TempAllocatorImpl *_this);

/// Check if an allocation of inSize can be made in this fixed buffer allocator
/// Generated from method `JPH::TempAllocatorImpl::CanAllocate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TempAllocatorImpl_CanAllocate(const JPH_TempAllocatorImpl *_this, unsigned int inSize);

/// Check if memory block at inAddress is owned by this allocator
/// Generated from method `JPH::TempAllocatorImpl::OwnsMemory`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_TempAllocatorImpl_OwnsMemory(const JPH_TempAllocatorImpl *_this, const void *inAddress);

/// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
/// Returns a pointer to a member variable of class `JPH::TempAllocatorMalloc` named `needs_aligned_allocate`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_TempAllocatorMalloc_Get_needs_aligned_allocate(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TempAllocatorMalloc_Destroy()` to free it when you're done using it.
JOLT_API JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_TempAllocatorMalloc_DestroyArray()`.
/// Use `JPH_TempAllocatorMalloc_OffsetMutablePtr()` and `JPH_TempAllocatorMalloc_OffsetPtr()` to access the array elements.
JOLT_API JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_OffsetPtr(const JPH_TempAllocatorMalloc *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_OffsetMutablePtr(JPH_TempAllocatorMalloc *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TempAllocatorMalloc` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorMalloc *object);

/// Upcasts an instance of `JPH::TempAllocatorMalloc` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TempAllocatorMalloc_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorMalloc *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorMalloc`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorMalloc`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TempAllocatorMalloc` to its base class `JPH::TempAllocator`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocator *JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorMalloc *object);

/// Upcasts an instance of `JPH::TempAllocatorMalloc` to its base class `JPH::TempAllocator`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocator *JPH_TempAllocatorMalloc_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorMalloc *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorMalloc`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorMalloc`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object);

/// Destroys a heap-allocated instance of `JPH_TempAllocatorMalloc`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorMalloc_Destroy(const JPH_TempAllocatorMalloc *_this);

/// Destroys a heap-allocated array of `JPH_TempAllocatorMalloc`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorMalloc_DestroyArray(const JPH_TempAllocatorMalloc *_this);

/// Generated from method `JPH::TempAllocatorMalloc::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorMalloc_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorMalloc::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorMalloc_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorMalloc::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorMalloc_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TempAllocatorMalloc::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorMalloc_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorMalloc::Allocate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_TempAllocatorMalloc_Allocate(JPH_TempAllocatorMalloc *_this, unsigned int inSize);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorMalloc::Free`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TempAllocatorMalloc_Free(JPH_TempAllocatorMalloc *_this, void *inAddress, unsigned int inSize);

/// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
/// Returns a pointer to a member variable of class `JPH::TempAllocatorImplWithMallocFallback` named `needs_aligned_allocate`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const bool *JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate(void);

/// Constructs the allocator with an initial fixed block if inSize
/// Generated from constructor `JPH::TempAllocatorImplWithMallocFallback::TempAllocatorImplWithMallocFallback`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TempAllocatorImplWithMallocFallback_Destroy()` to free it when you're done using it.
JOLT_API JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_Construct(unsigned int inSize);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_OffsetPtr(const JPH_TempAllocatorImplWithMallocFallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_OffsetMutablePtr(JPH_TempAllocatorImplWithMallocFallback *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::TempAllocatorImplWithMallocFallback` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorImplWithMallocFallback *object);

/// Upcasts an instance of `JPH::TempAllocatorImplWithMallocFallback` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_TempAllocatorImplWithMallocFallback_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorImplWithMallocFallback *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorImplWithMallocFallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::TempAllocatorImplWithMallocFallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::TempAllocatorImplWithMallocFallback` to its base class `JPH::TempAllocator`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocator *JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorImplWithMallocFallback *object);

/// Upcasts an instance of `JPH::TempAllocatorImplWithMallocFallback` to its base class `JPH::TempAllocator`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocator *JPH_TempAllocatorImplWithMallocFallback_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorImplWithMallocFallback *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorImplWithMallocFallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object);

/// Downcasts an instance of `JPH::TempAllocator` to a derived class `JPH::TempAllocatorImplWithMallocFallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object);

/// Destroys a heap-allocated instance of `JPH_TempAllocatorImplWithMallocFallback`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorImplWithMallocFallback_Destroy(const JPH_TempAllocatorImplWithMallocFallback *_this);

/// Destroys a heap-allocated array of `JPH_TempAllocatorImplWithMallocFallback`. Does nothing if the pointer is null.
JOLT_API void JPH_TempAllocatorImplWithMallocFallback_DestroyArray(const JPH_TempAllocatorImplWithMallocFallback *_this);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t(unsigned long inCount);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new`.
JOLT_API void *Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
JOLT_API void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::Allocate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void *JPH_TempAllocatorImplWithMallocFallback_Allocate(JPH_TempAllocatorImplWithMallocFallback *_this, unsigned int inSize);

// See: TempAllocator
/// Generated from method `JPH::TempAllocatorImplWithMallocFallback::Free`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_TempAllocatorImplWithMallocFallback_Free(JPH_TempAllocatorImplWithMallocFallback *_this, void *inAddress, unsigned int inSize);

#ifdef __cplusplus
} // extern "C"
#endif
