// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceTable.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceTable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_Construct(unsigned int inNumObjectLayers, unsigned int inNumBroadPhaseLayers)
{
    return (JPH_BroadPhaseLayerInterfaceTable *)new JPH::BroadPhaseLayerInterfaceTable(JPH::BroadPhaseLayerInterfaceTable(
        inNumObjectLayers,
        inNumBroadPhaseLayers
    ));
}

const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_OffsetPtr(const JPH_BroadPhaseLayerInterfaceTable *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseLayerInterfaceTable *)(((const JPH::BroadPhaseLayerInterfaceTable *)ptr) + i);
}

JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_OffsetMutablePtr(JPH_BroadPhaseLayerInterfaceTable *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseLayerInterfaceTable *)(((JPH::BroadPhaseLayerInterfaceTable *)ptr) + i);
}

const JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterfaceTable *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BroadPhaseLayerInterfaceTable *)object)
    ));
}

JPH_NonCopyable *JPH_BroadPhaseLayerInterfaceTable_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterfaceTable *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BroadPhaseLayerInterfaceTable *)object)
    ));
}

const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BroadPhaseLayerInterfaceTable *)(static_cast<const JPH::BroadPhaseLayerInterfaceTable *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BroadPhaseLayerInterfaceTable *)(static_cast<JPH::BroadPhaseLayerInterfaceTable *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterfaceTable *object)
{
    return (const JPH_BroadPhaseLayerInterface *)(static_cast<const JPH::BroadPhaseLayerInterface *>(
        ((const JPH::BroadPhaseLayerInterfaceTable *)object)
    ));
}

JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterfaceTable_MutableUpcastTo_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterfaceTable *object)
{
    return (JPH_BroadPhaseLayerInterface *)(static_cast<JPH::BroadPhaseLayerInterface *>(
        ((JPH::BroadPhaseLayerInterfaceTable *)object)
    ));
}

const JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(const JPH_BroadPhaseLayerInterface *object)
{
    return (const JPH_BroadPhaseLayerInterfaceTable *)(static_cast<const JPH::BroadPhaseLayerInterfaceTable *>(
        ((const JPH::BroadPhaseLayerInterface *)object)
    ));
}

JPH_BroadPhaseLayerInterfaceTable *JPH_BroadPhaseLayerInterfaceTable_MutableStaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH_BroadPhaseLayerInterface *object)
{
    return (JPH_BroadPhaseLayerInterfaceTable *)(static_cast<JPH::BroadPhaseLayerInterfaceTable *>(
        ((JPH::BroadPhaseLayerInterface *)object)
    ));
}

void JPH_BroadPhaseLayerInterfaceTable_Destroy(const JPH_BroadPhaseLayerInterfaceTable *_this)
{
    delete ((const JPH::BroadPhaseLayerInterfaceTable *)_this);
}

void JPH_BroadPhaseLayerInterfaceTable_DestroyArray(const JPH_BroadPhaseLayerInterfaceTable *_this)
{
    delete[] ((const JPH::BroadPhaseLayerInterfaceTable *)_this);
}

void *Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t(size_t inCount)
{
    return JPH::BroadPhaseLayerInterfaceTable::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t(size_t inCount)
{
    return JPH::BroadPhaseLayerInterfaceTable::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseLayerInterfaceTable::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseLayerInterfaceTable::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseLayerInterfaceTable::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer(JPH_BroadPhaseLayerInterfaceTable *_this, unsigned short inObjectLayer, const JPH_BroadPhaseLayer *inBroadPhaseLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseLayerInterfaceTable *)(_this)).MapObjectToBroadPhaseLayer(
        inObjectLayer,
        ((inBroadPhaseLayer ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inBroadPhaseLayer))
    );
}

unsigned int JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterfaceTable *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceTable *)(_this)).GetNumBroadPhaseLayers();
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterfaceTable *_this, unsigned short inLayer)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterfaceTable *)(_this)).GetBroadPhaseLayer(
        inLayer
    ));
}

