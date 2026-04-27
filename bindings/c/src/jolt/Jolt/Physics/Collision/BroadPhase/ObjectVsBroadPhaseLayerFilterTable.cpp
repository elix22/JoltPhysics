// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterTable.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterTable.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(const JPH_BroadPhaseLayerInterface *inBroadPhaseLayerInterface, unsigned int inNumBroadPhaseLayers, const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter, unsigned int inNumObjectLayers)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterTable *)new JPH::ObjectVsBroadPhaseLayerFilterTable(JPH::ObjectVsBroadPhaseLayerFilterTable(
        ((inBroadPhaseLayerInterface ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerInterface` can not be null.", void)), *(const JPH::BroadPhaseLayerInterface *)(inBroadPhaseLayerInterface)),
        inNumBroadPhaseLayers,
        ((inObjectLayerPairFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerPairFilter` can not be null.", void)), *(const JPH::ObjectLayerPairFilter *)(inObjectLayerPairFilter)),
        inNumObjectLayers
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilterTable *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterTable *)(((const JPH::ObjectVsBroadPhaseLayerFilterTable *)ptr) + i);
}

JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilterTable *ptr, ptrdiff_t i)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterTable *)(((JPH::ObjectVsBroadPhaseLayerFilterTable *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilterTable *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilterTable *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilterTable *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectVsBroadPhaseLayerFilterTable *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterTable *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilterTable *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterTable *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilterTable *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilterTable *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilterTable *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableUpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilterTable *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((JPH::ObjectVsBroadPhaseLayerFilterTable *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(const JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilterTable *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilterTable *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilterTable *JPH_ObjectVsBroadPhaseLayerFilterTable_MutableStaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilterTable *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilterTable *>(
        ((JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

void JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this)
{
    delete ((const JPH::ObjectVsBroadPhaseLayerFilterTable *)_this);
}

void JPH_ObjectVsBroadPhaseLayerFilterTable_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this)
{
    delete[] ((const JPH::ObjectVsBroadPhaseLayerFilterTable *)_this);
}

void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(unsigned long inCount)
{
    return JPH::ObjectVsBroadPhaseLayerFilterTable::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(unsigned long inCount)
{
    return JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::ObjectVsBroadPhaseLayerFilterTable::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilterTable *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectVsBroadPhaseLayerFilterTable *)(_this)).ShouldCollide(
        inLayer1,
        ((inLayer2 ? void() : MRBINDC_THROW("Parameter `inLayer2` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer2))
    );
}

