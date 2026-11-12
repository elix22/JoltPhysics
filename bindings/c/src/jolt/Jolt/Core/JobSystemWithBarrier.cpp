// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/JobSystemWithBarrier.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/JobSystem.h>
#include <Jolt/Core/JobSystemWithBarrier.h>
#include <Jolt/Core/NonCopyable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <functional>
#include <stdexcept>


void JPH_JobSystemWithBarrier_Destroy(const JPH_JobSystemWithBarrier *_this)
{
    delete ((const JPH::JobSystemWithBarrier *)_this);
}

void JPH_JobSystemWithBarrier_DestroyArray(const JPH_JobSystemWithBarrier *_this)
{
    delete[] ((const JPH::JobSystemWithBarrier *)_this);
}

void *Jolt_new_JPH_JobSystemWithBarrier_size_t(size_t inCount)
{
    return JPH::JobSystemWithBarrier::operator new(
        inCount
    );
}

void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr(void *inPointer)
{
    JPH::JobSystemWithBarrier::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemWithBarrier::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_JobSystemWithBarrier_size_t(size_t inCount)
{
    return JPH::JobSystemWithBarrier::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr(void *inPointer)
{
    JPH::JobSystemWithBarrier::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystemWithBarrier::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_JobSystemWithBarrier_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemWithBarrier::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemWithBarrier::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_JobSystemWithBarrier_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystemWithBarrier::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystemWithBarrier::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_JobSystemWithBarrier_Init(JPH_JobSystemWithBarrier *_this, unsigned int inMaxBarriers)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemWithBarrier *)(_this)).Init(
        inMaxBarriers
    );
}

JPH_JobSystem_Barrier *JPH_JobSystemWithBarrier_CreateBarrier(JPH_JobSystemWithBarrier *_this)
{
    return (JPH_JobSystem_Barrier *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemWithBarrier *)(_this)).CreateBarrier());
}

void JPH_JobSystemWithBarrier_DestroyBarrier(JPH_JobSystemWithBarrier *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemWithBarrier *)(_this)).DestroyBarrier(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

void JPH_JobSystemWithBarrier_WaitForJobs(JPH_JobSystemWithBarrier *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemWithBarrier *)(_this)).WaitForJobs(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

int JPH_JobSystemWithBarrier_GetMaxConcurrency(const JPH_JobSystemWithBarrier *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystemWithBarrier *)(_this)).GetMaxConcurrency();
}

JPH_JobSystem_JobHandle *JPH_JobSystemWithBarrier_CreateJob(JPH_JobSystemWithBarrier *_this, const char *inName, const JPH_Color *inColor, const Jolt_std_function_void *inJobFunction, const unsigned int *inNumDependencies)
{
    using namespace JPH;
    return (JPH_JobSystem_JobHandle *)new JPH::JobSystem::JobHandle(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystemWithBarrier *)(_this)).CreateJob(
        inName,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        ((inJobFunction ? void() : MRBINDC_THROW("Parameter `inJobFunction` can not be null.", void)), *(const std::function<void(void)> *)(inJobFunction)),
        (inNumDependencies ? *inNumDependencies : static_cast<unsigned int>(0))
    ));
}

const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_OffsetPtr(const JPH_JobSystemWithBarrier *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystemWithBarrier *)(((const JPH::JobSystemWithBarrier *)ptr) + i);
}

JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_OffsetMutablePtr(JPH_JobSystemWithBarrier *ptr, ptrdiff_t i)
{
    return (JPH_JobSystemWithBarrier *)(((JPH::JobSystemWithBarrier *)ptr) + i);
}

const JPH_NonCopyable *JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(const JPH_JobSystemWithBarrier *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::JobSystemWithBarrier *)object)
    ));
}

JPH_NonCopyable *JPH_JobSystemWithBarrier_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystemWithBarrier *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::JobSystemWithBarrier *)object)
    ));
}

const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_JobSystemWithBarrier *)(static_cast<const JPH::JobSystemWithBarrier *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_JobSystemWithBarrier *)(static_cast<JPH::JobSystemWithBarrier *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_JobSystem *JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(const JPH_JobSystemWithBarrier *object)
{
    return (const JPH_JobSystem *)(static_cast<const JPH::JobSystem *>(
        ((const JPH::JobSystemWithBarrier *)object)
    ));
}

JPH_JobSystem *JPH_JobSystemWithBarrier_MutableUpcastTo_JPH_JobSystem(JPH_JobSystemWithBarrier *object)
{
    return (JPH_JobSystem *)(static_cast<JPH::JobSystem *>(
        ((JPH::JobSystemWithBarrier *)object)
    ));
}

const JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(const JPH_JobSystem *object)
{
    return (const JPH_JobSystemWithBarrier *)(static_cast<const JPH::JobSystemWithBarrier *>(
        ((const JPH::JobSystem *)object)
    ));
}

JPH_JobSystemWithBarrier *JPH_JobSystemWithBarrier_MutableStaticDowncastFrom_JPH_JobSystem(JPH_JobSystem *object)
{
    return (JPH_JobSystemWithBarrier *)(static_cast<JPH::JobSystemWithBarrier *>(
        ((JPH::JobSystem *)object)
    ));
}

