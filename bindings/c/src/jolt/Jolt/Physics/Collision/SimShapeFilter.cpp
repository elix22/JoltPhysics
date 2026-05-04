// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/SimShapeFilter.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/SimShapeFilter.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <new>
#include <stdexcept>


JPH_SimShapeFilter *JPH_SimShapeFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SimShapeFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SimShapeFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SimShapeFilter *JPH_SimShapeFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SimShapeFilter *)(new JPH::SimShapeFilter[num_elems]{});
}

const JPH_SimShapeFilter *JPH_SimShapeFilter_OffsetPtr(const JPH_SimShapeFilter *ptr, ptrdiff_t i)
{
    return (const JPH_SimShapeFilter *)(((const JPH::SimShapeFilter *)ptr) + i);
}

JPH_SimShapeFilter *JPH_SimShapeFilter_OffsetMutablePtr(JPH_SimShapeFilter *ptr, ptrdiff_t i)
{
    return (JPH_SimShapeFilter *)(((JPH::SimShapeFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_SimShapeFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SimShapeFilter *)object)
    ));
}

JPH_NonCopyable *JPH_SimShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SimShapeFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SimShapeFilter *)object)
    ));
}

const JPH_SimShapeFilter *JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SimShapeFilter *)(static_cast<const JPH::SimShapeFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SimShapeFilter *JPH_SimShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SimShapeFilter *)(static_cast<JPH::SimShapeFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_SimShapeFilter_Destroy(const JPH_SimShapeFilter *_this)
{
    delete ((const JPH::SimShapeFilter *)_this);
}

void JPH_SimShapeFilter_DestroyArray(const JPH_SimShapeFilter *_this)
{
    delete[] ((const JPH::SimShapeFilter *)_this);
}

bool JPH_SimShapeFilter_ShouldCollide(const JPH_SimShapeFilter *_this, const JPH_Body *inBody1, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Body *inBody2, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SimShapeFilter *)(_this)).ShouldCollide(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((const JPH::Shape *)inShape1),
        ((inSubShapeIDOfShape1 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((const JPH::Shape *)inShape2),
        ((inSubShapeIDOfShape2 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape2))
    );
}

