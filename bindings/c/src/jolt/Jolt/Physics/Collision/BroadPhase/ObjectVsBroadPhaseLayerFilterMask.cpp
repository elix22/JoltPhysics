// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterMask.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceMask.h>
#include <Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterMask.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(const JPH_BroadPhaseLayerInterfaceMask *inBroadPhaseLayerInterface)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterMask *)new JPH::ObjectVsBroadPhaseLayerFilterMask(JPH::ObjectVsBroadPhaseLayerFilterMask(
        ((inBroadPhaseLayerInterface ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerInterface` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceMask *)(inBroadPhaseLayerInterface))
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilterMask *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterMask *)(((const JPH::ObjectVsBroadPhaseLayerFilterMask *)ptr) + i);
}

JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilterMask *ptr, ptrdiff_t i)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterMask *)(((JPH::ObjectVsBroadPhaseLayerFilterMask *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilterMask *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilterMask *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilterMask *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectVsBroadPhaseLayerFilterMask *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterMask *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilterMask *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterMask *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilterMask *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilterMask *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilterMask *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableUpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilterMask *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((JPH::ObjectVsBroadPhaseLayerFilterMask *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterMask *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilterMask *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilterMask *JPH_ObjectVsBroadPhaseLayerFilterMask_MutableStaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterMask *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilterMask *>(
        ((JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

void JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this)
{
    delete ((const JPH::ObjectVsBroadPhaseLayerFilterMask *)_this);
}

void JPH_ObjectVsBroadPhaseLayerFilterMask_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this)
{
    delete[] ((const JPH::ObjectVsBroadPhaseLayerFilterMask *)_this);
}

void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(size_t inCount)
{
    return JPH::ObjectVsBroadPhaseLayerFilterMask::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(size_t inCount)
{
    return JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectVsBroadPhaseLayerFilterMask::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilterMask *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectVsBroadPhaseLayerFilterMask *)(_this)).ShouldCollide(
        inLayer1,
        ((inLayer2 ? void() : MRBINDC_THROW("Parameter `inLayer2` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer2))
    );
}

