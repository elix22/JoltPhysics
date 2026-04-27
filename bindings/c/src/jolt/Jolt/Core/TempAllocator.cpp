// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/TempAllocator.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/TempAllocator.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const bool *JPH_TempAllocator_Get_needs_aligned_allocate(void)
{
    return std::addressof(JPH::TempAllocator::needs_aligned_allocate);
}

void JPH_TempAllocator_Destroy(const JPH_TempAllocator *_this)
{
    delete ((const JPH::TempAllocator *)_this);
}

void JPH_TempAllocator_DestroyArray(const JPH_TempAllocator *_this)
{
    delete[] ((const JPH::TempAllocator *)_this);
}

void *Jolt_new_JPH_TempAllocator_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocator::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TempAllocator_void_ptr(void *inPointer)
{
    JPH::TempAllocator::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocator_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocator::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TempAllocator_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocator::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TempAllocator_void_ptr(void *inPointer)
{
    JPH::TempAllocator::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocator_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocator::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TempAllocator_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocator::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocator::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TempAllocator_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocator::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocator::operator delete[](
        inPointer,
        inPlace
    );
}

void *JPH_TempAllocator_Allocate(JPH_TempAllocator *_this, unsigned int inSize)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocator *)(_this)).Allocate(
        inSize
    );
}

void JPH_TempAllocator_Free(JPH_TempAllocator *_this, void *inAddress, unsigned int inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocator *)(_this)).Free(
        inAddress,
        inSize
    );
}

const JPH_TempAllocator *JPH_TempAllocator_OffsetPtr(const JPH_TempAllocator *ptr, ptrdiff_t i)
{
    return (const JPH_TempAllocator *)(((const JPH::TempAllocator *)ptr) + i);
}

JPH_TempAllocator *JPH_TempAllocator_OffsetMutablePtr(JPH_TempAllocator *ptr, ptrdiff_t i)
{
    return (JPH_TempAllocator *)(((JPH::TempAllocator *)ptr) + i);
}

const JPH_NonCopyable *JPH_TempAllocator_UpcastTo_JPH_NonCopyable(const JPH_TempAllocator *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TempAllocator *)object)
    ));
}

JPH_NonCopyable *JPH_TempAllocator_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocator *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TempAllocator *)object)
    ));
}

const JPH_TempAllocator *JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TempAllocator *)(static_cast<const JPH::TempAllocator *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TempAllocator *JPH_TempAllocator_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TempAllocator *)(static_cast<JPH::TempAllocator *>(
        ((JPH::NonCopyable *)object)
    ));
}

const bool *JPH_TempAllocatorImpl_Get_needs_aligned_allocate(void)
{
    return std::addressof(JPH::TempAllocatorImpl::needs_aligned_allocate);
}

JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_Construct(unsigned long inSize)
{
    return (JPH_TempAllocatorImpl *)new JPH::TempAllocatorImpl(JPH::TempAllocatorImpl(
        inSize
    ));
}

const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_OffsetPtr(const JPH_TempAllocatorImpl *ptr, ptrdiff_t i)
{
    return (const JPH_TempAllocatorImpl *)(((const JPH::TempAllocatorImpl *)ptr) + i);
}

JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_OffsetMutablePtr(JPH_TempAllocatorImpl *ptr, ptrdiff_t i)
{
    return (JPH_TempAllocatorImpl *)(((JPH::TempAllocatorImpl *)ptr) + i);
}

const JPH_NonCopyable *JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorImpl *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TempAllocatorImpl *)object)
    ));
}

JPH_NonCopyable *JPH_TempAllocatorImpl_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorImpl *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TempAllocatorImpl *)object)
    ));
}

const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TempAllocatorImpl *)(static_cast<const JPH::TempAllocatorImpl *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TempAllocatorImpl *)(static_cast<JPH::TempAllocatorImpl *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_TempAllocator *JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorImpl *object)
{
    return (const JPH_TempAllocator *)(static_cast<const JPH::TempAllocator *>(
        ((const JPH::TempAllocatorImpl *)object)
    ));
}

JPH_TempAllocator *JPH_TempAllocatorImpl_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorImpl *object)
{
    return (JPH_TempAllocator *)(static_cast<JPH::TempAllocator *>(
        ((JPH::TempAllocatorImpl *)object)
    ));
}

const JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object)
{
    return (const JPH_TempAllocatorImpl *)(static_cast<const JPH::TempAllocatorImpl *>(
        ((const JPH::TempAllocator *)object)
    ));
}

JPH_TempAllocatorImpl *JPH_TempAllocatorImpl_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object)
{
    return (JPH_TempAllocatorImpl *)(static_cast<JPH::TempAllocatorImpl *>(
        ((JPH::TempAllocator *)object)
    ));
}

void JPH_TempAllocatorImpl_Destroy(const JPH_TempAllocatorImpl *_this)
{
    delete ((const JPH::TempAllocatorImpl *)_this);
}

void JPH_TempAllocatorImpl_DestroyArray(const JPH_TempAllocatorImpl *_this)
{
    delete[] ((const JPH::TempAllocatorImpl *)_this);
}

void *Jolt_new_JPH_TempAllocatorImpl_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorImpl::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TempAllocatorImpl_void_ptr(void *inPointer)
{
    JPH::TempAllocatorImpl::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorImpl_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorImpl::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TempAllocatorImpl_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorImpl::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr(void *inPointer)
{
    JPH::TempAllocatorImpl::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorImpl::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TempAllocatorImpl_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorImpl::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorImpl::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TempAllocatorImpl_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorImpl::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorImpl::operator delete[](
        inPointer,
        inPlace
    );
}

void *JPH_TempAllocatorImpl_Allocate(JPH_TempAllocatorImpl *_this, unsigned int inSize)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorImpl *)(_this)).Allocate(
        inSize
    );
}

void JPH_TempAllocatorImpl_Free(JPH_TempAllocatorImpl *_this, void *inAddress, unsigned int inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorImpl *)(_this)).Free(
        inAddress,
        inSize
    );
}

bool JPH_TempAllocatorImpl_IsEmpty(const JPH_TempAllocatorImpl *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TempAllocatorImpl *)(_this)).IsEmpty();
}

unsigned long JPH_TempAllocatorImpl_GetSize(const JPH_TempAllocatorImpl *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TempAllocatorImpl *)(_this)).GetSize();
}

unsigned long JPH_TempAllocatorImpl_GetUsage(const JPH_TempAllocatorImpl *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TempAllocatorImpl *)(_this)).GetUsage();
}

bool JPH_TempAllocatorImpl_CanAllocate(const JPH_TempAllocatorImpl *_this, unsigned int inSize)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TempAllocatorImpl *)(_this)).CanAllocate(
        inSize
    );
}

bool JPH_TempAllocatorImpl_OwnsMemory(const JPH_TempAllocatorImpl *_this, const void *inAddress)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TempAllocatorImpl *)(_this)).OwnsMemory(
        inAddress
    );
}

const bool *JPH_TempAllocatorMalloc_Get_needs_aligned_allocate(void)
{
    return std::addressof(JPH::TempAllocatorMalloc::needs_aligned_allocate);
}

JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_DefaultConstruct(void)
{
    return (JPH_TempAllocatorMalloc *)new JPH::TempAllocatorMalloc(JPH::TempAllocatorMalloc());
}

JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TempAllocatorMalloc *)(new JPH::TempAllocatorMalloc[num_elems]{});
}

const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_OffsetPtr(const JPH_TempAllocatorMalloc *ptr, ptrdiff_t i)
{
    return (const JPH_TempAllocatorMalloc *)(((const JPH::TempAllocatorMalloc *)ptr) + i);
}

JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_OffsetMutablePtr(JPH_TempAllocatorMalloc *ptr, ptrdiff_t i)
{
    return (JPH_TempAllocatorMalloc *)(((JPH::TempAllocatorMalloc *)ptr) + i);
}

const JPH_NonCopyable *JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorMalloc *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TempAllocatorMalloc *)object)
    ));
}

JPH_NonCopyable *JPH_TempAllocatorMalloc_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorMalloc *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TempAllocatorMalloc *)object)
    ));
}

const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TempAllocatorMalloc *)(static_cast<const JPH::TempAllocatorMalloc *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TempAllocatorMalloc *)(static_cast<JPH::TempAllocatorMalloc *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_TempAllocator *JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorMalloc *object)
{
    return (const JPH_TempAllocator *)(static_cast<const JPH::TempAllocator *>(
        ((const JPH::TempAllocatorMalloc *)object)
    ));
}

JPH_TempAllocator *JPH_TempAllocatorMalloc_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorMalloc *object)
{
    return (JPH_TempAllocator *)(static_cast<JPH::TempAllocator *>(
        ((JPH::TempAllocatorMalloc *)object)
    ));
}

const JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object)
{
    return (const JPH_TempAllocatorMalloc *)(static_cast<const JPH::TempAllocatorMalloc *>(
        ((const JPH::TempAllocator *)object)
    ));
}

JPH_TempAllocatorMalloc *JPH_TempAllocatorMalloc_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object)
{
    return (JPH_TempAllocatorMalloc *)(static_cast<JPH::TempAllocatorMalloc *>(
        ((JPH::TempAllocator *)object)
    ));
}

void JPH_TempAllocatorMalloc_Destroy(const JPH_TempAllocatorMalloc *_this)
{
    delete ((const JPH::TempAllocatorMalloc *)_this);
}

void JPH_TempAllocatorMalloc_DestroyArray(const JPH_TempAllocatorMalloc *_this)
{
    delete[] ((const JPH::TempAllocatorMalloc *)_this);
}

void *Jolt_new_JPH_TempAllocatorMalloc_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorMalloc::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr(void *inPointer)
{
    JPH::TempAllocatorMalloc::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorMalloc::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TempAllocatorMalloc_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorMalloc::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr(void *inPointer)
{
    JPH::TempAllocatorMalloc::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorMalloc::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TempAllocatorMalloc_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorMalloc::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorMalloc::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TempAllocatorMalloc_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorMalloc::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorMalloc::operator delete[](
        inPointer,
        inPlace
    );
}

void *JPH_TempAllocatorMalloc_Allocate(JPH_TempAllocatorMalloc *_this, unsigned int inSize)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorMalloc *)(_this)).Allocate(
        inSize
    );
}

void JPH_TempAllocatorMalloc_Free(JPH_TempAllocatorMalloc *_this, void *inAddress, unsigned int inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorMalloc *)(_this)).Free(
        inAddress,
        inSize
    );
}

const bool *JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate(void)
{
    return std::addressof(JPH::TempAllocatorImplWithMallocFallback::needs_aligned_allocate);
}

JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_Construct(unsigned int inSize)
{
    return (JPH_TempAllocatorImplWithMallocFallback *)new JPH::TempAllocatorImplWithMallocFallback(JPH::TempAllocatorImplWithMallocFallback(
        inSize
    ));
}

const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_OffsetPtr(const JPH_TempAllocatorImplWithMallocFallback *ptr, ptrdiff_t i)
{
    return (const JPH_TempAllocatorImplWithMallocFallback *)(((const JPH::TempAllocatorImplWithMallocFallback *)ptr) + i);
}

JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_OffsetMutablePtr(JPH_TempAllocatorImplWithMallocFallback *ptr, ptrdiff_t i)
{
    return (JPH_TempAllocatorImplWithMallocFallback *)(((JPH::TempAllocatorImplWithMallocFallback *)ptr) + i);
}

const JPH_NonCopyable *JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(const JPH_TempAllocatorImplWithMallocFallback *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TempAllocatorImplWithMallocFallback *)object)
    ));
}

JPH_NonCopyable *JPH_TempAllocatorImplWithMallocFallback_MutableUpcastTo_JPH_NonCopyable(JPH_TempAllocatorImplWithMallocFallback *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TempAllocatorImplWithMallocFallback *)object)
    ));
}

const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TempAllocatorImplWithMallocFallback *)(static_cast<const JPH::TempAllocatorImplWithMallocFallback *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TempAllocatorImplWithMallocFallback *)(static_cast<JPH::TempAllocatorImplWithMallocFallback *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_TempAllocator *JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(const JPH_TempAllocatorImplWithMallocFallback *object)
{
    return (const JPH_TempAllocator *)(static_cast<const JPH::TempAllocator *>(
        ((const JPH::TempAllocatorImplWithMallocFallback *)object)
    ));
}

JPH_TempAllocator *JPH_TempAllocatorImplWithMallocFallback_MutableUpcastTo_JPH_TempAllocator(JPH_TempAllocatorImplWithMallocFallback *object)
{
    return (JPH_TempAllocator *)(static_cast<JPH::TempAllocator *>(
        ((JPH::TempAllocatorImplWithMallocFallback *)object)
    ));
}

const JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(const JPH_TempAllocator *object)
{
    return (const JPH_TempAllocatorImplWithMallocFallback *)(static_cast<const JPH::TempAllocatorImplWithMallocFallback *>(
        ((const JPH::TempAllocator *)object)
    ));
}

JPH_TempAllocatorImplWithMallocFallback *JPH_TempAllocatorImplWithMallocFallback_MutableStaticDowncastFrom_JPH_TempAllocator(JPH_TempAllocator *object)
{
    return (JPH_TempAllocatorImplWithMallocFallback *)(static_cast<JPH::TempAllocatorImplWithMallocFallback *>(
        ((JPH::TempAllocator *)object)
    ));
}

void JPH_TempAllocatorImplWithMallocFallback_Destroy(const JPH_TempAllocatorImplWithMallocFallback *_this)
{
    delete ((const JPH::TempAllocatorImplWithMallocFallback *)_this);
}

void JPH_TempAllocatorImplWithMallocFallback_DestroyArray(const JPH_TempAllocatorImplWithMallocFallback *_this)
{
    delete[] ((const JPH::TempAllocatorImplWithMallocFallback *)_this);
}

void *Jolt_new_JPH_TempAllocatorImplWithMallocFallback_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorImplWithMallocFallback::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_unsigned_long(unsigned long inCount)
{
    return JPH::TempAllocatorImplWithMallocFallback::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TempAllocatorImplWithMallocFallback_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorImplWithMallocFallback::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::TempAllocatorImplWithMallocFallback::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TempAllocatorImplWithMallocFallback::operator delete[](
        inPointer,
        inPlace
    );
}

void *JPH_TempAllocatorImplWithMallocFallback_Allocate(JPH_TempAllocatorImplWithMallocFallback *_this, unsigned int inSize)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorImplWithMallocFallback *)(_this)).Allocate(
        inSize
    );
}

void JPH_TempAllocatorImplWithMallocFallback_Free(JPH_TempAllocatorImplWithMallocFallback *_this, void *inAddress, unsigned int inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TempAllocatorImplWithMallocFallback *)(_this)).Free(
        inAddress,
        inSize
    );
}

