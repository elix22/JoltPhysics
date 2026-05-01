// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/JobSystemSingleThreaded.h"

#include <Jolt/Core/JobSystem.h>
#include <Jolt/Core/JobSystemSingleThreaded.h>
#include <Jolt/Core/NonCopyable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <new>
#include <stdexcept>


JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_DefaultConstruct(void)
{
    using _mrbind_T = JPH::JobSystemSingleThreaded;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_JobSystemSingleThreaded*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_DefaultConstructArray(size_t num_elems)
{
    return (JPH_JobSystemSingleThreaded *)(new JPH::JobSystemSingleThreaded[num_elems]{});
}

const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_OffsetPtr(const JPH_JobSystemSingleThreaded *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystemSingleThreaded *)(((const JPH::JobSystemSingleThreaded *)ptr) + i);
}

JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_OffsetMutablePtr(JPH_JobSystemSingleThreaded *ptr, ptrdiff_t i)
{
    return (JPH_JobSystemSingleThreaded *)(((JPH::JobSystemSingleThreaded *)ptr) + i);
}

const JPH_NonCopyable *JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(const JPH_JobSystemSingleThreaded *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::JobSystemSingleThreaded *)object)
    ));
}

JPH_NonCopyable *JPH_JobSystemSingleThreaded_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemSingleThreaded *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::JobSystemSingleThreaded *)object)
    ));
}

const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_JobSystemSingleThreaded *)(static_cast<const JPH::JobSystemSingleThreaded *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_JobSystemSingleThreaded *)(static_cast<JPH::JobSystemSingleThreaded *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_JobSystem *JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(const JPH_JobSystemSingleThreaded *object)
{
    return (const JPH_JobSystem *)(static_cast<const JPH::JobSystem *>(
        ((const JPH::JobSystemSingleThreaded *)object)
    ));
}

JPH_JobSystem *JPH_JobSystemSingleThreaded_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemSingleThreaded *object)
{
    return (JPH_JobSystem *)(static_cast<JPH::JobSystem *>(
        ((JPH::JobSystemSingleThreaded *)object)
    ));
}

const JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object)
{
    return (const JPH_JobSystemSingleThreaded *)(static_cast<const JPH::JobSystemSingleThreaded *>(
        ((const JPH::JobSystem *)object)
    ));
}

JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object)
{
    return (JPH_JobSystemSingleThreaded *)(static_cast<JPH::JobSystemSingleThreaded *>(
        ((JPH::JobSystem *)object)
    ));
}

JPH_JobSystemSingleThreaded *JPH_JobSystemSingleThreaded_Construct(unsigned int inMaxJobs)
{
    return (JPH_JobSystemSingleThreaded *)new JPH::JobSystemSingleThreaded(JPH::JobSystemSingleThreaded(
        inMaxJobs
    ));
}

void JPH_JobSystemSingleThreaded_Destroy(const JPH_JobSystemSingleThreaded *_this)
{
    delete ((const JPH::JobSystemSingleThreaded *)_this);
}

void JPH_JobSystemSingleThreaded_DestroyArray(const JPH_JobSystemSingleThreaded *_this)
{
    delete[] ((const JPH::JobSystemSingleThreaded *)_this);
}

void *Jolt_new_JPH_JobSystemSingleThreaded_size_t(size_t inCount)
{
    return JPH::JobSystemSingleThreaded::operator new(
        inCount
    );
}

void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer)
{
    JPH::JobSystemSingleThreaded::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemSingleThreaded::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_JobSystemSingleThreaded_size_t(size_t inCount)
{
    return JPH::JobSystemSingleThreaded::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer)
{
    JPH::JobSystemSingleThreaded::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemSingleThreaded::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemSingleThreaded::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemSingleThreaded::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemSingleThreaded::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemSingleThreaded::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_JobSystemSingleThreaded_Init(JPH_JobSystemSingleThreaded *_this, unsigned int inMaxJobs)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemSingleThreaded *)(_this)).Init(
        inMaxJobs
    );
}

int JPH_JobSystemSingleThreaded_GetMaxConcurrency(const JPH_JobSystemSingleThreaded *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystemSingleThreaded *)(_this)).GetMaxConcurrency();
}

JPH_JobSystem_Barrier *JPH_JobSystemSingleThreaded_CreateBarrier(JPH_JobSystemSingleThreaded *_this)
{
    return (JPH_JobSystem_Barrier *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemSingleThreaded *)(_this)).CreateBarrier());
}

void JPH_JobSystemSingleThreaded_DestroyBarrier(JPH_JobSystemSingleThreaded *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemSingleThreaded *)(_this)).DestroyBarrier(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

void JPH_JobSystemSingleThreaded_WaitForJobs(JPH_JobSystemSingleThreaded *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemSingleThreaded *)(_this)).WaitForJobs(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

