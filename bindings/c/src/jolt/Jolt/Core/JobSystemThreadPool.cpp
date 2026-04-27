// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/JobSystemThreadPool.h"

#include <Jolt/Core/JobSystem.h>
#include <Jolt/Core/JobSystemThreadPool.h>
#include <Jolt/Core/JobSystemWithBarrier.h>
#include <Jolt/Core/NonCopyable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <functional>
#include <stdexcept>


JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_DefaultConstruct(void)
{
    return (JPH_JobSystemThreadPool *)new JPH::JobSystemThreadPool(JPH::JobSystemThreadPool());
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_DefaultConstructArray(size_t num_elems)
{
    return (JPH_JobSystemThreadPool *)(new JPH::JobSystemThreadPool[num_elems]{});
}

const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_OffsetPtr(const JPH_JobSystemThreadPool *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystemThreadPool *)(((const JPH::JobSystemThreadPool *)ptr) + i);
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_OffsetMutablePtr(JPH_JobSystemThreadPool *ptr, ptrdiff_t i)
{
    return (JPH_JobSystemThreadPool *)(((JPH::JobSystemThreadPool *)ptr) + i);
}

const JPH_NonCopyable *JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(const JPH_JobSystemThreadPool *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::JobSystemThreadPool *)object)
    ));
}

JPH_NonCopyable *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemThreadPool *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::JobSystemThreadPool *)object)
    ));
}

const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_JobSystemThreadPool *)(static_cast<const JPH::JobSystemThreadPool *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_JobSystemThreadPool *)(static_cast<JPH::JobSystemThreadPool *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_JobSystem *JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(const JPH_JobSystemThreadPool *object)
{
    return (const JPH_JobSystem *)(static_cast<const JPH::JobSystem *>(
        ((const JPH::JobSystemThreadPool *)object)
    ));
}

JPH_JobSystem *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemThreadPool *object)
{
    return (JPH_JobSystem *)(static_cast<JPH::JobSystem *>(
        ((JPH::JobSystemThreadPool *)object)
    ));
}

const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object)
{
    return (const JPH_JobSystemThreadPool *)(static_cast<const JPH::JobSystemThreadPool *>(
        ((const JPH::JobSystem *)object)
    ));
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object)
{
    return (JPH_JobSystemThreadPool *)(static_cast<JPH::JobSystemThreadPool *>(
        ((JPH::JobSystem *)object)
    ));
}

const JPH_JobSystemWithBarrier *JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(const JPH_JobSystemThreadPool *object)
{
    return (const JPH_JobSystemWithBarrier *)(static_cast<const JPH::JobSystemWithBarrier *>(
        ((const JPH::JobSystemThreadPool *)object)
    ));
}

JPH_JobSystemWithBarrier *JPH_JobSystemThreadPool_MutableUpcastTo_JPH_JobSystemWithBarrier(JPH_JobSystemThreadPool *object)
{
    return (JPH_JobSystemWithBarrier *)(static_cast<JPH::JobSystemWithBarrier *>(
        ((JPH::JobSystemThreadPool *)object)
    ));
}

const JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_StaticDowncastFrom_JPH_JobSystemWithBarrier(const JPH_JobSystemWithBarrier *object)
{
    return (const JPH_JobSystemThreadPool *)(static_cast<const JPH::JobSystemThreadPool *>(
        ((const JPH::JobSystemWithBarrier *)object)
    ));
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_MutableStaticDowncastFrom_JPH_JobSystemWithBarrier(JPH_JobSystemWithBarrier *object)
{
    return (JPH_JobSystemThreadPool *)(static_cast<JPH::JobSystemThreadPool *>(
        ((JPH::JobSystemWithBarrier *)object)
    ));
}

JPH_JobSystemThreadPool *JPH_JobSystemThreadPool_Construct(unsigned int inMaxJobs, unsigned int inMaxBarriers, const int *inNumThreads)
{
    using namespace JPH;
    return (JPH_JobSystemThreadPool *)new JPH::JobSystemThreadPool(JPH::JobSystemThreadPool(
        inMaxJobs,
        inMaxBarriers,
        (inNumThreads ? *inNumThreads : static_cast<int>(-1))
    ));
}

void JPH_JobSystemThreadPool_Destroy(const JPH_JobSystemThreadPool *_this)
{
    delete ((const JPH::JobSystemThreadPool *)_this);
}

void JPH_JobSystemThreadPool_DestroyArray(const JPH_JobSystemThreadPool *_this)
{
    delete[] ((const JPH::JobSystemThreadPool *)_this);
}

void *Jolt_new_JPH_JobSystemThreadPool_size_t(size_t inCount)
{
    return JPH::JobSystemThreadPool::operator new(
        inCount
    );
}

void Jolt_delete_JPH_JobSystemThreadPool_void_ptr(void *inPointer)
{
    JPH::JobSystemThreadPool::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemThreadPool_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemThreadPool::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_JobSystemThreadPool_size_t(size_t inCount)
{
    return JPH::JobSystemThreadPool::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr(void *inPointer)
{
    JPH::JobSystemThreadPool::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemThreadPool::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_JobSystemThreadPool_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemThreadPool::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemThreadPool::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_JobSystemThreadPool_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemThreadPool::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemThreadPool::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_JobSystemThreadPool_SetThreadInitFunction(JPH_JobSystemThreadPool *_this, const Jolt_std_function_void_from_int *inInitFunction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).SetThreadInitFunction(
        ((inInitFunction ? void() : MRBINDC_THROW("Parameter `inInitFunction` can not be null.", void)), *(const std::function<void(int)> *)(inInitFunction))
    );
}

void JPH_JobSystemThreadPool_SetThreadExitFunction(JPH_JobSystemThreadPool *_this, const Jolt_std_function_void_from_int *inExitFunction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).SetThreadExitFunction(
        ((inExitFunction ? void() : MRBINDC_THROW("Parameter `inExitFunction` can not be null.", void)), *(const std::function<void(int)> *)(inExitFunction))
    );
}

void JPH_JobSystemThreadPool_Init(JPH_JobSystemThreadPool *_this, unsigned int inMaxJobs, unsigned int inMaxBarriers, const int *inNumThreads)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).Init(
        inMaxJobs,
        inMaxBarriers,
        (inNumThreads ? *inNumThreads : static_cast<int>(-1))
    );
}

int JPH_JobSystemThreadPool_GetMaxConcurrency(const JPH_JobSystemThreadPool *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystemThreadPool *)(_this)).GetMaxConcurrency();
}

void JPH_JobSystemThreadPool_SetNumThreads(JPH_JobSystemThreadPool *_this, int inNumThreads)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).SetNumThreads(
        inNumThreads
    );
}

JPH_JobSystem_Barrier *JPH_JobSystemThreadPool_CreateBarrier(JPH_JobSystemThreadPool *_this)
{
    return (JPH_JobSystem_Barrier *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).CreateBarrier());
}

void JPH_JobSystemThreadPool_DestroyBarrier(JPH_JobSystemThreadPool *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).DestroyBarrier(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

void JPH_JobSystemThreadPool_WaitForJobs(JPH_JobSystemThreadPool *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemThreadPool *)(_this)).WaitForJobs(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

