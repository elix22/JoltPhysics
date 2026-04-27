// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ObjectLayerPairFilterTable.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/ObjectLayerPairFilterTable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_Construct(unsigned int inNumObjectLayers)
{
    return (JPH_ObjectLayerPairFilterTable *)new JPH::ObjectLayerPairFilterTable(JPH::ObjectLayerPairFilterTable(
        inNumObjectLayers
    ));
}

const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_OffsetPtr(const JPH_ObjectLayerPairFilterTable *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectLayerPairFilterTable *)(((const JPH::ObjectLayerPairFilterTable *)ptr) + i);
}

JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_OffsetMutablePtr(JPH_ObjectLayerPairFilterTable *ptr, ptrdiff_t i)
{
    return (JPH_ObjectLayerPairFilterTable *)(((JPH::ObjectLayerPairFilterTable *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilterTable *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectLayerPairFilterTable *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectLayerPairFilterTable_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilterTable *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectLayerPairFilterTable *)object)
    ));
}

const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectLayerPairFilterTable *)(static_cast<const JPH::ObjectLayerPairFilterTable *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectLayerPairFilterTable *)(static_cast<JPH::ObjectLayerPairFilterTable *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilterTable *object)
{
    return (const JPH_ObjectLayerPairFilter *)(static_cast<const JPH::ObjectLayerPairFilter *>(
        ((const JPH::ObjectLayerPairFilterTable *)object)
    ));
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterTable_MutableUpcastTo_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilterTable *object)
{
    return (JPH_ObjectLayerPairFilter *)(static_cast<JPH::ObjectLayerPairFilter *>(
        ((JPH::ObjectLayerPairFilterTable *)object)
    ));
}

const JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilter *object)
{
    return (const JPH_ObjectLayerPairFilterTable *)(static_cast<const JPH::ObjectLayerPairFilterTable *>(
        ((const JPH::ObjectLayerPairFilter *)object)
    ));
}

JPH_ObjectLayerPairFilterTable *JPH_ObjectLayerPairFilterTable_MutableStaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilter *object)
{
    return (JPH_ObjectLayerPairFilterTable *)(static_cast<JPH::ObjectLayerPairFilterTable *>(
        ((JPH::ObjectLayerPairFilter *)object)
    ));
}

void JPH_ObjectLayerPairFilterTable_Destroy(const JPH_ObjectLayerPairFilterTable *_this)
{
    delete ((const JPH::ObjectLayerPairFilterTable *)_this);
}

void JPH_ObjectLayerPairFilterTable_DestroyArray(const JPH_ObjectLayerPairFilterTable *_this)
{
    delete[] ((const JPH::ObjectLayerPairFilterTable *)_this);
}

void *Jolt_new_JPH_ObjectLayerPairFilterTable_size_t(size_t inCount)
{
    return JPH::ObjectLayerPairFilterTable::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer)
{
    JPH::ObjectLayerPairFilterTable::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectLayerPairFilterTable::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t(size_t inCount)
{
    return JPH::ObjectLayerPairFilterTable::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer)
{
    JPH::ObjectLayerPairFilterTable::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectLayerPairFilterTable::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectLayerPairFilterTable::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectLayerPairFilterTable::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectLayerPairFilterTable::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectLayerPairFilterTable::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_ObjectLayerPairFilterTable_GetNumObjectLayers(const JPH_ObjectLayerPairFilterTable *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectLayerPairFilterTable *)(_this)).GetNumObjectLayers();
}

void JPH_ObjectLayerPairFilterTable_DisableCollision(JPH_ObjectLayerPairFilterTable *_this, unsigned short inLayer1, unsigned short inLayer2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ObjectLayerPairFilterTable *)(_this)).DisableCollision(
        inLayer1,
        inLayer2
    );
}

void JPH_ObjectLayerPairFilterTable_EnableCollision(JPH_ObjectLayerPairFilterTable *_this, unsigned short inLayer1, unsigned short inLayer2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ObjectLayerPairFilterTable *)(_this)).EnableCollision(
        inLayer1,
        inLayer2
    );
}

bool JPH_ObjectLayerPairFilterTable_ShouldCollide(const JPH_ObjectLayerPairFilterTable *_this, unsigned short inObject1, unsigned short inObject2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectLayerPairFilterTable *)(_this)).ShouldCollide(
        inObject1,
        inObject2
    );
}

