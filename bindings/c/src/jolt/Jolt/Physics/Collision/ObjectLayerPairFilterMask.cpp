// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ObjectLayerPairFilterMask.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/ObjectLayerPairFilterMask.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const unsigned int *JPH_ObjectLayerPairFilterMask_Get_cNumBits(void)
{
    return std::addressof(JPH::ObjectLayerPairFilterMask::cNumBits);
}

const unsigned int *JPH_ObjectLayerPairFilterMask_Get_cMask(void)
{
    return std::addressof(JPH::ObjectLayerPairFilterMask::cMask);
}

JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_DefaultConstruct(void)
{
    return (JPH_ObjectLayerPairFilterMask *)new JPH::ObjectLayerPairFilterMask(JPH::ObjectLayerPairFilterMask());
}

JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ObjectLayerPairFilterMask *)(new JPH::ObjectLayerPairFilterMask[num_elems]{});
}

const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_OffsetPtr(const JPH_ObjectLayerPairFilterMask *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectLayerPairFilterMask *)(((const JPH::ObjectLayerPairFilterMask *)ptr) + i);
}

JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_OffsetMutablePtr(JPH_ObjectLayerPairFilterMask *ptr, ptrdiff_t i)
{
    return (JPH_ObjectLayerPairFilterMask *)(((JPH::ObjectLayerPairFilterMask *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilterMask *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectLayerPairFilterMask *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectLayerPairFilterMask_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilterMask *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectLayerPairFilterMask *)object)
    ));
}

const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectLayerPairFilterMask *)(static_cast<const JPH::ObjectLayerPairFilterMask *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectLayerPairFilterMask *)(static_cast<JPH::ObjectLayerPairFilterMask *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilterMask *object)
{
    return (const JPH_ObjectLayerPairFilter *)(static_cast<const JPH::ObjectLayerPairFilter *>(
        ((const JPH::ObjectLayerPairFilterMask *)object)
    ));
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilterMask_MutableUpcastTo_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilterMask *object)
{
    return (JPH_ObjectLayerPairFilter *)(static_cast<JPH::ObjectLayerPairFilter *>(
        ((JPH::ObjectLayerPairFilterMask *)object)
    ));
}

const JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(const JPH_ObjectLayerPairFilter *object)
{
    return (const JPH_ObjectLayerPairFilterMask *)(static_cast<const JPH::ObjectLayerPairFilterMask *>(
        ((const JPH::ObjectLayerPairFilter *)object)
    ));
}

JPH_ObjectLayerPairFilterMask *JPH_ObjectLayerPairFilterMask_MutableStaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH_ObjectLayerPairFilter *object)
{
    return (JPH_ObjectLayerPairFilterMask *)(static_cast<JPH::ObjectLayerPairFilterMask *>(
        ((JPH::ObjectLayerPairFilter *)object)
    ));
}

void JPH_ObjectLayerPairFilterMask_Destroy(const JPH_ObjectLayerPairFilterMask *_this)
{
    delete ((const JPH::ObjectLayerPairFilterMask *)_this);
}

void JPH_ObjectLayerPairFilterMask_DestroyArray(const JPH_ObjectLayerPairFilterMask *_this)
{
    delete[] ((const JPH::ObjectLayerPairFilterMask *)_this);
}

void *Jolt_new_JPH_ObjectLayerPairFilterMask_size_t(size_t inCount)
{
    return JPH::ObjectLayerPairFilterMask::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer)
{
    JPH::ObjectLayerPairFilterMask::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectLayerPairFilterMask::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t(size_t inCount)
{
    return JPH::ObjectLayerPairFilterMask::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer)
{
    JPH::ObjectLayerPairFilterMask::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ObjectLayerPairFilterMask::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectLayerPairFilterMask::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectLayerPairFilterMask::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ObjectLayerPairFilterMask::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ObjectLayerPairFilterMask::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned short JPH_ObjectLayerPairFilterMask_sGetObjectLayer(unsigned int inGroup, const unsigned int *inMask)
{
    using namespace JPH;
    return JPH::ObjectLayerPairFilterMask::sGetObjectLayer(
        inGroup,
        (inMask ? *inMask : static_cast<unsigned int>(JPH::ObjectLayerPairFilterMask::cMask))
    );
}

unsigned int JPH_ObjectLayerPairFilterMask_sGetGroup(unsigned short inObjectLayer)
{
    return JPH::ObjectLayerPairFilterMask::sGetGroup(
        inObjectLayer
    );
}

unsigned int JPH_ObjectLayerPairFilterMask_sGetMask(unsigned short inObjectLayer)
{
    return JPH::ObjectLayerPairFilterMask::sGetMask(
        inObjectLayer
    );
}

bool JPH_ObjectLayerPairFilterMask_ShouldCollide(const JPH_ObjectLayerPairFilterMask *_this, unsigned short inObject1, unsigned short inObject2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectLayerPairFilterMask *)(_this)).ShouldCollide(
        inObject1,
        inObject2
    );
}

