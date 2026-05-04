// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/GroupFilter.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/GroupFilter.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void JPH_GroupFilter_Destroy(const JPH_GroupFilter *_this)
{
    delete ((const JPH::GroupFilter *)_this);
}

void JPH_GroupFilter_DestroyArray(const JPH_GroupFilter *_this)
{
    delete[] ((const JPH::GroupFilter *)_this);
}

void *Jolt_new_JPH_GroupFilter_size_t(size_t inCount)
{
    return JPH::GroupFilter::operator new(
        inCount
    );
}

void Jolt_delete_JPH_GroupFilter_void_ptr(void *inPointer)
{
    JPH::GroupFilter::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_GroupFilter_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GroupFilter::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_GroupFilter_size_t(size_t inCount)
{
    return JPH::GroupFilter::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_GroupFilter_void_ptr(void *inPointer)
{
    JPH::GroupFilter::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GroupFilter::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_GroupFilter_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GroupFilter::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GroupFilter::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_GroupFilter_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GroupFilter::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GroupFilter::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_GroupFilter_CanCollide(const JPH_GroupFilter *_this, const JPH_CollisionGroup *inGroup1, const JPH_CollisionGroup *inGroup2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilter *)(_this)).CanCollide(
        ((inGroup1 ? void() : MRBINDC_THROW("Parameter `inGroup1` can not be null.", void)), *(const JPH::CollisionGroup *)(inGroup1)),
        ((inGroup2 ? void() : MRBINDC_THROW("Parameter `inGroup2` can not be null.", void)), *(const JPH::CollisionGroup *)(inGroup2))
    );
}

void JPH_GroupFilter_SetEmbedded(const JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilter *)(_this)).SetEmbedded();
}

unsigned int JPH_GroupFilter_GetRefCount(const JPH_GroupFilter *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilter *)(_this)).GetRefCount();
}

void JPH_GroupFilter_AddRef(const JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilter *)(_this)).AddRef();
}

void JPH_GroupFilter_Release(const JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilter *)(_this)).Release();
}

int JPH_GroupFilter_sInternalGetRefCountOffset(void)
{
    return JPH::GroupFilter::sInternalGetRefCountOffset();
}

const JPH_GroupFilter *JPH_GroupFilter_OffsetPtr(const JPH_GroupFilter *ptr, ptrdiff_t i)
{
    return (const JPH_GroupFilter *)(((const JPH::GroupFilter *)ptr) + i);
}

JPH_GroupFilter *JPH_GroupFilter_OffsetMutablePtr(JPH_GroupFilter *ptr, ptrdiff_t i)
{
    return (JPH_GroupFilter *)(((JPH::GroupFilter *)ptr) + i);
}

const JPH_SerializableObject *JPH_GroupFilter_UpcastTo_JPH_SerializableObject(const JPH_GroupFilter *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::GroupFilter *)object)
    ));
}

JPH_SerializableObject *JPH_GroupFilter_MutableUpcastTo_JPH_SerializableObject(JPH_GroupFilter *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::GroupFilter *)object)
    ));
}

const JPH_GroupFilter *JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_GroupFilter *)(static_cast<const JPH::GroupFilter *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_GroupFilter *JPH_GroupFilter_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_GroupFilter *)(static_cast<JPH::GroupFilter *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(const JPH_GroupFilter *object)
{
    return (const JPH_RefTarget_JPH_GroupFilter *)(static_cast<const JPH::RefTarget<JPH::GroupFilter> *>(
        ((const JPH::GroupFilter *)object)
    ));
}

JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilter_MutableUpcastTo_JPH_RefTarget_JPH_GroupFilter(JPH_GroupFilter *object)
{
    return (JPH_RefTarget_JPH_GroupFilter *)(static_cast<JPH::RefTarget<JPH::GroupFilter> *>(
        ((JPH::GroupFilter *)object)
    ));
}

const JPH_GroupFilter *JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(const JPH_RefTarget_JPH_GroupFilter *object)
{
    return (const JPH_GroupFilter *)(static_cast<const JPH::GroupFilter *>(
        ((const JPH::RefTarget<JPH::GroupFilter> *)object)
    ));
}

JPH_GroupFilter *JPH_GroupFilter_MutableStaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH_RefTarget_JPH_GroupFilter *object)
{
    return (JPH_GroupFilter *)(static_cast<JPH::GroupFilter *>(
        ((JPH::RefTarget<JPH::GroupFilter> *)object)
    ));
}

