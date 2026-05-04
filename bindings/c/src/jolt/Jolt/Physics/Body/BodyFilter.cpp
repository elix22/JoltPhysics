// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/BodyFilter.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyFilter.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <new>
#include <stdexcept>


JPH_BodyFilter *JPH_BodyFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BodyFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BodyFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BodyFilter *JPH_BodyFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BodyFilter *)(new JPH::BodyFilter[num_elems]);
}

const JPH_BodyFilter *JPH_BodyFilter_OffsetPtr(const JPH_BodyFilter *ptr, ptrdiff_t i)
{
    return (const JPH_BodyFilter *)(((const JPH::BodyFilter *)ptr) + i);
}

JPH_BodyFilter *JPH_BodyFilter_OffsetMutablePtr(JPH_BodyFilter *ptr, ptrdiff_t i)
{
    return (JPH_BodyFilter *)(((JPH::BodyFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_BodyFilter_UpcastTo_JPH_NonCopyable(const JPH_BodyFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BodyFilter *)object)
    ));
}

JPH_NonCopyable *JPH_BodyFilter_MutableUpcastTo_JPH_NonCopyable(JPH_BodyFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BodyFilter *)object)
    ));
}

const JPH_BodyFilter *JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BodyFilter *)(static_cast<const JPH::BodyFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BodyFilter *JPH_BodyFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BodyFilter *)(static_cast<JPH::BodyFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_BodyFilter_Destroy(const JPH_BodyFilter *_this)
{
    delete ((const JPH::BodyFilter *)_this);
}

void JPH_BodyFilter_DestroyArray(const JPH_BodyFilter *_this)
{
    delete[] ((const JPH::BodyFilter *)_this);
}

bool JPH_BodyFilter_ShouldCollide(const JPH_BodyFilter *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyFilter *)(_this)).ShouldCollide(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

bool JPH_BodyFilter_ShouldCollideLocked(const JPH_BodyFilter *_this, const JPH_Body *inBody)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyFilter *)(_this)).ShouldCollideLocked(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody))
    );
}

JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_Construct(const JPH_BodyID *inBodyID)
{
    return (JPH_IgnoreSingleBodyFilter *)new JPH::IgnoreSingleBodyFilter(JPH::IgnoreSingleBodyFilter(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_OffsetPtr(const JPH_IgnoreSingleBodyFilter *ptr, ptrdiff_t i)
{
    return (const JPH_IgnoreSingleBodyFilter *)(((const JPH::IgnoreSingleBodyFilter *)ptr) + i);
}

JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_OffsetMutablePtr(JPH_IgnoreSingleBodyFilter *ptr, ptrdiff_t i)
{
    return (JPH_IgnoreSingleBodyFilter *)(((JPH::IgnoreSingleBodyFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(const JPH_IgnoreSingleBodyFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::IgnoreSingleBodyFilter *)object)
    ));
}

JPH_NonCopyable *JPH_IgnoreSingleBodyFilter_MutableUpcastTo_JPH_NonCopyable(JPH_IgnoreSingleBodyFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::IgnoreSingleBodyFilter *)object)
    ));
}

const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_IgnoreSingleBodyFilter *)(static_cast<const JPH::IgnoreSingleBodyFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_IgnoreSingleBodyFilter *)(static_cast<JPH::IgnoreSingleBodyFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BodyFilter *JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(const JPH_IgnoreSingleBodyFilter *object)
{
    return (const JPH_BodyFilter *)(static_cast<const JPH::BodyFilter *>(
        ((const JPH::IgnoreSingleBodyFilter *)object)
    ));
}

JPH_BodyFilter *JPH_IgnoreSingleBodyFilter_MutableUpcastTo_JPH_BodyFilter(JPH_IgnoreSingleBodyFilter *object)
{
    return (JPH_BodyFilter *)(static_cast<JPH::BodyFilter *>(
        ((JPH::IgnoreSingleBodyFilter *)object)
    ));
}

const JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(const JPH_BodyFilter *object)
{
    return (const JPH_IgnoreSingleBodyFilter *)(static_cast<const JPH::IgnoreSingleBodyFilter *>(
        ((const JPH::BodyFilter *)object)
    ));
}

JPH_IgnoreSingleBodyFilter *JPH_IgnoreSingleBodyFilter_MutableStaticDowncastFrom_JPH_BodyFilter(JPH_BodyFilter *object)
{
    return (JPH_IgnoreSingleBodyFilter *)(static_cast<JPH::IgnoreSingleBodyFilter *>(
        ((JPH::BodyFilter *)object)
    ));
}

void JPH_IgnoreSingleBodyFilter_Destroy(const JPH_IgnoreSingleBodyFilter *_this)
{
    delete ((const JPH::IgnoreSingleBodyFilter *)_this);
}

void JPH_IgnoreSingleBodyFilter_DestroyArray(const JPH_IgnoreSingleBodyFilter *_this)
{
    delete[] ((const JPH::IgnoreSingleBodyFilter *)_this);
}

bool JPH_IgnoreSingleBodyFilter_ShouldCollide(const JPH_IgnoreSingleBodyFilter *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::IgnoreSingleBodyFilter *)(_this)).ShouldCollide(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

bool JPH_IgnoreSingleBodyFilter_ShouldCollideLocked(const JPH_IgnoreSingleBodyFilter *_this, const JPH_Body *inBody)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::IgnoreSingleBodyFilter *)(_this)).ShouldCollideLocked(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody))
    );
}

JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::IgnoreMultipleBodiesFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_IgnoreMultipleBodiesFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_IgnoreMultipleBodiesFilter *)(new JPH::IgnoreMultipleBodiesFilter[num_elems]);
}

const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_OffsetPtr(const JPH_IgnoreMultipleBodiesFilter *ptr, ptrdiff_t i)
{
    return (const JPH_IgnoreMultipleBodiesFilter *)(((const JPH::IgnoreMultipleBodiesFilter *)ptr) + i);
}

JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_OffsetMutablePtr(JPH_IgnoreMultipleBodiesFilter *ptr, ptrdiff_t i)
{
    return (JPH_IgnoreMultipleBodiesFilter *)(((JPH::IgnoreMultipleBodiesFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(const JPH_IgnoreMultipleBodiesFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::IgnoreMultipleBodiesFilter *)object)
    ));
}

JPH_NonCopyable *JPH_IgnoreMultipleBodiesFilter_MutableUpcastTo_JPH_NonCopyable(JPH_IgnoreMultipleBodiesFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::IgnoreMultipleBodiesFilter *)object)
    ));
}

const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_IgnoreMultipleBodiesFilter *)(static_cast<const JPH::IgnoreMultipleBodiesFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_IgnoreMultipleBodiesFilter *)(static_cast<JPH::IgnoreMultipleBodiesFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BodyFilter *JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(const JPH_IgnoreMultipleBodiesFilter *object)
{
    return (const JPH_BodyFilter *)(static_cast<const JPH::BodyFilter *>(
        ((const JPH::IgnoreMultipleBodiesFilter *)object)
    ));
}

JPH_BodyFilter *JPH_IgnoreMultipleBodiesFilter_MutableUpcastTo_JPH_BodyFilter(JPH_IgnoreMultipleBodiesFilter *object)
{
    return (JPH_BodyFilter *)(static_cast<JPH::BodyFilter *>(
        ((JPH::IgnoreMultipleBodiesFilter *)object)
    ));
}

const JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(const JPH_BodyFilter *object)
{
    return (const JPH_IgnoreMultipleBodiesFilter *)(static_cast<const JPH::IgnoreMultipleBodiesFilter *>(
        ((const JPH::BodyFilter *)object)
    ));
}

JPH_IgnoreMultipleBodiesFilter *JPH_IgnoreMultipleBodiesFilter_MutableStaticDowncastFrom_JPH_BodyFilter(JPH_BodyFilter *object)
{
    return (JPH_IgnoreMultipleBodiesFilter *)(static_cast<JPH::IgnoreMultipleBodiesFilter *>(
        ((JPH::BodyFilter *)object)
    ));
}

void JPH_IgnoreMultipleBodiesFilter_Destroy(const JPH_IgnoreMultipleBodiesFilter *_this)
{
    delete ((const JPH::IgnoreMultipleBodiesFilter *)_this);
}

void JPH_IgnoreMultipleBodiesFilter_DestroyArray(const JPH_IgnoreMultipleBodiesFilter *_this)
{
    delete[] ((const JPH::IgnoreMultipleBodiesFilter *)_this);
}

void JPH_IgnoreMultipleBodiesFilter_Clear(JPH_IgnoreMultipleBodiesFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::IgnoreMultipleBodiesFilter *)(_this)).Clear();
}

void JPH_IgnoreMultipleBodiesFilter_Reserve(JPH_IgnoreMultipleBodiesFilter *_this, unsigned int inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::IgnoreMultipleBodiesFilter *)(_this)).Reserve(
        inSize
    );
}

void JPH_IgnoreMultipleBodiesFilter_IgnoreBody(JPH_IgnoreMultipleBodiesFilter *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::IgnoreMultipleBodiesFilter *)(_this)).IgnoreBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

bool JPH_IgnoreMultipleBodiesFilter_ShouldCollide(const JPH_IgnoreMultipleBodiesFilter *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::IgnoreMultipleBodiesFilter *)(_this)).ShouldCollide(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

bool JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked(const JPH_IgnoreMultipleBodiesFilter *_this, const JPH_Body *inBody)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::IgnoreMultipleBodiesFilter *)(_this)).ShouldCollideLocked(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody))
    );
}

