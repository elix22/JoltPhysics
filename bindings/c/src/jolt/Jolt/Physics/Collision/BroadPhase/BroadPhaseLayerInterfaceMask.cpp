// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceMask.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceMask.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_Construct(unsigned int inNumBroadPhaseLayers)
{
    return (JPH_BroadPhaseLayerInterfaceMask *)new JPH::BroadPhaseLayerInterfaceMask(JPH::BroadPhaseLayerInterfaceMask(
        inNumBroadPhaseLayers
    ));
}

const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_OffsetPtr(const JPH_BroadPhaseLayerInterfaceMask *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseLayerInterfaceMask *)(((const JPH::BroadPhaseLayerInterfaceMask *)ptr) + i);
}

JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_OffsetMutablePtr(JPH_BroadPhaseLayerInterfaceMask *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseLayerInterfaceMask *)(((JPH::BroadPhaseLayerInterfaceMask *)ptr) + i);
}

const JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterfaceMask *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BroadPhaseLayerInterfaceMask *)object)
    ));
}

JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceMask_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterfaceMask *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BroadPhaseLayerInterfaceMask *)object)
    ));
}

const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BroadPhaseLayerInterfaceMask *)(static_cast<const JPH::BroadPhaseLayerInterfaceMask *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BroadPhaseLayerInterfaceMask *)(static_cast<JPH::BroadPhaseLayerInterfaceMask *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterfaceMask *object)
{
    return (const JPH_BroadPhaseLayerInterface *)(static_cast<const JPH::BroadPhaseLayerInterface *>(
        ((const JPH::BroadPhaseLayerInterfaceMask *)object)
    ));
}

JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceMask_MutableUpcastTo_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterfaceMask *object)
{
    return (JPH_BroadPhaseLayerInterface *)(static_cast<JPH::BroadPhaseLayerInterface *>(
        ((JPH::BroadPhaseLayerInterfaceMask *)object)
    ));
}

const JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterface *object)
{
    return (const JPH_BroadPhaseLayerInterfaceMask *)(static_cast<const JPH::BroadPhaseLayerInterfaceMask *>(
        ((const JPH::BroadPhaseLayerInterface *)object)
    ));
}

JPH_BroadPhaseLayerInterfaceMask *JPH_BroadPhaseLayerInterfaceMask_MutableStaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterface *object)
{
    return (JPH_BroadPhaseLayerInterfaceMask *)(static_cast<JPH::BroadPhaseLayerInterfaceMask *>(
        ((JPH::BroadPhaseLayerInterface *)object)
    ));
}

void JPH_BroadPhaseLayerInterfaceMask_Destroy(const JPH_BroadPhaseLayerInterfaceMask *_this)
{
    delete ((const JPH::BroadPhaseLayerInterfaceMask *)_this);
}

void JPH_BroadPhaseLayerInterfaceMask_DestroyArray(const JPH_BroadPhaseLayerInterfaceMask *_this)
{
    delete[] ((const JPH::BroadPhaseLayerInterfaceMask *)_this);
}

void *Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t(size_t inCount)
{
    return JPH::BroadPhaseLayerInterfaceMask::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t(size_t inCount)
{
    return JPH::BroadPhaseLayerInterfaceMask::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseLayerInterfaceMask::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseLayerInterfaceMask::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseLayerInterfaceMask::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer(JPH_BroadPhaseLayerInterfaceMask *_this, const JPH_BroadPhaseLayer *inBroadPhaseLayer, unsigned int inGroupsToInclude, unsigned int inGroupsToExclude)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseLayerInterfaceMask *)(_this)).ConfigureLayer(
        ((inBroadPhaseLayer ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inBroadPhaseLayer)),
        inGroupsToInclude,
        inGroupsToExclude
    );
}

unsigned int JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterfaceMask *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceMask *)(_this)).GetNumBroadPhaseLayers();
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterfaceMask *_this, unsigned short inLayer)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceMask *)(_this)).GetBroadPhaseLayer(
        inLayer
    ));
}

bool JPH_BroadPhaseLayerInterfaceMask_ShouldCollide(const JPH_BroadPhaseLayerInterfaceMask *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceMask *)(_this)).ShouldCollide(
        inLayer1,
        ((inLayer2 ? void() : MRBINDC_THROW("Parameter `inLayer2` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer2))
    );
}

