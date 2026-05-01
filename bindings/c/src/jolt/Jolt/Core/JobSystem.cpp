// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/JobSystem.h"

#include <Jolt/Core/JobSystem.h>
#include <Jolt/Core/NonCopyable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


void JPH_JobSystem_Destroy(const JPH_JobSystem *_this)
{
    delete ((const JPH::JobSystem *)_this);
}

void JPH_JobSystem_DestroyArray(const JPH_JobSystem *_this)
{
    delete[] ((const JPH::JobSystem *)_this);
}

void *Jolt_new_JPH_JobSystem_size_t(size_t inCount)
{
    return JPH::JobSystem::operator new(
        inCount
    );
}

void Jolt_delete_JPH_JobSystem_void_ptr(void *inPointer)
{
    JPH::JobSystem::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_JobSystem_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystem::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_JobSystem_size_t(size_t inCount)
{
    return JPH::JobSystem::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_JobSystem_void_ptr(void *inPointer)
{
    JPH::JobSystem::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystem_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystem::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_JobSystem_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystem::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystem::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_JobSystem_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystem::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystem::operator delete[](
        inPointer,
        inPlace
    );
}

int JPH_JobSystem_GetMaxConcurrency(const JPH_JobSystem *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystem *)(_this)).GetMaxConcurrency();
}

JPH_JobSystem_Barrier *JPH_JobSystem_CreateBarrier(JPH_JobSystem *_this)
{
    return (JPH_JobSystem_Barrier *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem *)(_this)).CreateBarrier());
}

void JPH_JobSystem_DestroyBarrier(JPH_JobSystem *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem *)(_this)).DestroyBarrier(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

void JPH_JobSystem_WaitForJobs(JPH_JobSystem *_this, JPH_JobSystem_Barrier *inBarrier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem *)(_this)).WaitForJobs(
        ((JPH::JobSystem::Barrier *)inBarrier)
    );
}

const JPH_JobSystem *JPH_JobSystem_OffsetPtr(const JPH_JobSystem *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystem *)(((const JPH::JobSystem *)ptr) + i);
}

JPH_JobSystem *JPH_JobSystem_OffsetMutablePtr(JPH_JobSystem *ptr, ptrdiff_t i)
{
    return (JPH_JobSystem *)(((JPH::JobSystem *)ptr) + i);
}

const JPH_NonCopyable *JPH_JobSystem_UpcastTo_JPH_NonCopyable(const JPH_JobSystem *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::JobSystem *)object)
    ));
}

JPH_NonCopyable *JPH_JobSystem_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystem *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::JobSystem *)object)
    ));
}

const JPH_JobSystem *JPH_JobSystem_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_JobSystem *)(static_cast<const JPH::JobSystem *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_JobSystem *JPH_JobSystem_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_JobSystem *)(static_cast<JPH::JobSystem *>(
        ((JPH::NonCopyable *)object)
    ));
}

JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_DefaultConstruct(void)
{
    using _mrbind_T = JPH::JobSystem::JobHandle;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_JobSystem_JobHandle*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_DefaultConstructArray(size_t num_elems)
{
    return (JPH_JobSystem_JobHandle *)(new JPH::JobSystem::JobHandle[num_elems]{});
}

const JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_OffsetPtr(const JPH_JobSystem_JobHandle *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystem_JobHandle *)(((const JPH::JobSystem::JobHandle *)ptr) + i);
}

JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_OffsetMutablePtr(JPH_JobSystem_JobHandle *ptr, ptrdiff_t i)
{
    return (JPH_JobSystem_JobHandle *)(((JPH::JobSystem::JobHandle *)ptr) + i);
}

JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_ConstructFromAnother(Jolt_PassBy inHandle_pass_by, JPH_JobSystem_JobHandle *inHandle)
{
    MRBINDC_CLASSARG_GUARD(inHandle, JPH::JobSystem::JobHandle);
    return (JPH_JobSystem_JobHandle *)new JPH::JobSystem::JobHandle(JPH::JobSystem::JobHandle(
        (MRBINDC_CLASSARG_DEF_CTOR(inHandle, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_COPY(inHandle, (JPH::JobSystem::JobHandle), JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_MOVE(inHandle, (JPH::JobSystem::JobHandle), JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_NO_DEF_ARG(inHandle, Jolt_PassBy_DefaultArgument, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_NO_DEF_ARG(inHandle, Jolt_PassBy_NoObject, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_END(inHandle, JPH::JobSystem::JobHandle))
    ));
}

void JPH_JobSystem_JobHandle_Destroy(const JPH_JobSystem_JobHandle *_this)
{
    delete ((const JPH::JobSystem::JobHandle *)_this);
}

void JPH_JobSystem_JobHandle_DestroyArray(const JPH_JobSystem_JobHandle *_this)
{
    delete[] ((const JPH::JobSystem::JobHandle *)_this);
}

JPH_JobSystem_JobHandle *JPH_JobSystem_JobHandle_AssignFromAnother(JPH_JobSystem_JobHandle *_this, Jolt_PassBy inHandle_pass_by, JPH_JobSystem_JobHandle *inHandle)
{
    MRBINDC_CLASSARG_GUARD(inHandle, JPH::JobSystem::JobHandle);
    return (JPH_JobSystem_JobHandle *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem::JobHandle *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(inHandle, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_COPY(inHandle, (JPH::JobSystem::JobHandle), JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_MOVE(inHandle, (JPH::JobSystem::JobHandle), JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_NO_DEF_ARG(inHandle, Jolt_PassBy_DefaultArgument, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_NO_DEF_ARG(inHandle, Jolt_PassBy_NoObject, JPH::JobSystem::JobHandle) MRBINDC_CLASSARG_END(inHandle, JPH::JobSystem::JobHandle))
    ));
}

bool JPH_JobSystem_JobHandle_IsValid(const JPH_JobSystem_JobHandle *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystem::JobHandle *)(_this)).IsValid();
}

bool JPH_JobSystem_JobHandle_IsDone(const JPH_JobSystem_JobHandle *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystem::JobHandle *)(_this)).IsDone();
}

void JPH_JobSystem_JobHandle_AddDependency(const JPH_JobSystem_JobHandle *_this, const int *inCount)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystem::JobHandle *)(_this)).AddDependency(
        (inCount ? *inCount : static_cast<int>(1))
    );
}

void JPH_JobSystem_JobHandle_RemoveDependency(const JPH_JobSystem_JobHandle *_this, const int *inCount)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::JobSystem::JobHandle *)(_this)).RemoveDependency(
        (inCount ? *inCount : static_cast<int>(1))
    );
}

void JPH_JobSystem_JobHandle_sRemoveDependencies(const JPH_JobSystem_JobHandle *inHandles, unsigned int inNumHandles, const int *inCount)
{
    using namespace JPH;
    JPH::JobSystem::JobHandle::sRemoveDependencies(
        ((const JPH::JobSystem::JobHandle *)inHandles),
        inNumHandles,
        (inCount ? *inCount : static_cast<int>(1))
    );
}

void *Jolt_new_JPH_JobSystem_Barrier_size_t(size_t inCount)
{
    return JPH::JobSystem::Barrier::operator new(
        inCount
    );
}

void Jolt_delete_JPH_JobSystem_Barrier_void_ptr(void *inPointer)
{
    JPH::JobSystem::Barrier::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_JobSystem_Barrier_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystem::Barrier::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_JobSystem_Barrier_size_t(size_t inCount)
{
    return JPH::JobSystem::Barrier::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr(void *inPointer)
{
    JPH::JobSystem::Barrier::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::JobSystem::Barrier::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_JobSystem_Barrier_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystem::Barrier::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystem::Barrier::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_JobSystem_Barrier_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::JobSystem::Barrier::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::JobSystem::Barrier::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_JobSystem_Barrier_AddJob(JPH_JobSystem_Barrier *_this, const JPH_JobSystem_JobHandle *inJob)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem::Barrier *)(_this)).AddJob(
        ((inJob ? void() : MRBINDC_THROW("Parameter `inJob` can not be null.", void)), *(const JPH::JobSystem::JobHandle *)(inJob))
    );
}

void JPH_JobSystem_Barrier_AddJobs(JPH_JobSystem_Barrier *_this, const JPH_JobSystem_JobHandle *inHandles, unsigned int inNumHandles)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::JobSystem::Barrier *)(_this)).AddJobs(
        ((const JPH::JobSystem::JobHandle *)inHandles),
        inNumHandles
    );
}

const JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_OffsetPtr(const JPH_JobSystem_Barrier *ptr, ptrdiff_t i)
{
    return (const JPH_JobSystem_Barrier *)(((const JPH::JobSystem::Barrier *)ptr) + i);
}

JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_OffsetMutablePtr(JPH_JobSystem_Barrier *ptr, ptrdiff_t i)
{
    return (JPH_JobSystem_Barrier *)(((JPH::JobSystem::Barrier *)ptr) + i);
}

const JPH_NonCopyable *JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(const JPH_JobSystem_Barrier *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::JobSystem::Barrier *)object)
    ));
}

JPH_NonCopyable *JPH_JobSystem_Barrier_MutableUpcastTo_JPH_NonCopyable(JPH_JobSystem_Barrier *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::JobSystem::Barrier *)object)
    ));
}

const JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_JobSystem_Barrier *)(static_cast<const JPH::JobSystem::Barrier *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_JobSystem_Barrier *JPH_JobSystem_Barrier_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_JobSystem_Barrier *)(static_cast<JPH::JobSystem::Barrier *>(
        ((JPH::NonCopyable *)object)
    ));
}

