// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ShapeFilter.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/ShapeFilter.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_BodyID *JPH_ShapeFilter_Get_mBodyID2(const JPH_ShapeFilter *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeFilter *)(_this)).mBodyID2);
}

void JPH_ShapeFilter_Set_mBodyID2(JPH_ShapeFilter *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeFilter *)(_this)).mBodyID2 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_ShapeFilter_GetMutable_mBodyID2(JPH_ShapeFilter *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeFilter *)(_this)).mBodyID2);
}

JPH_ShapeFilter *JPH_ShapeFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ShapeFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ShapeFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ShapeFilter *JPH_ShapeFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ShapeFilter *)(new JPH::ShapeFilter[num_elems]);
}

const JPH_ShapeFilter *JPH_ShapeFilter_OffsetPtr(const JPH_ShapeFilter *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeFilter *)(((const JPH::ShapeFilter *)ptr) + i);
}

JPH_ShapeFilter *JPH_ShapeFilter_OffsetMutablePtr(JPH_ShapeFilter *ptr, ptrdiff_t i)
{
    return (JPH_ShapeFilter *)(((JPH::ShapeFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_ShapeFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ShapeFilter *)object)
    ));
}

JPH_NonCopyable *JPH_ShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ShapeFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ShapeFilter *)object)
    ));
}

const JPH_ShapeFilter *JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ShapeFilter *)(static_cast<const JPH::ShapeFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ShapeFilter *JPH_ShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ShapeFilter *)(static_cast<JPH::ShapeFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_ShapeFilter_Destroy(const JPH_ShapeFilter *_this)
{
    delete ((const JPH::ShapeFilter *)_this);
}

void JPH_ShapeFilter_DestroyArray(const JPH_ShapeFilter *_this)
{
    delete[] ((const JPH::ShapeFilter *)_this);
}

bool JPH_ShapeFilter_ShouldCollide_2(const JPH_ShapeFilter *_this, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeFilter *)(_this)).ShouldCollide(
        ((const JPH::Shape *)inShape2),
        ((inSubShapeIDOfShape2 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape2))
    );
}

bool JPH_ShapeFilter_ShouldCollide_4(const JPH_ShapeFilter *_this, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeFilter *)(_this)).ShouldCollide(
        ((const JPH::Shape *)inShape1),
        ((inSubShapeIDOfShape1 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape1)),
        ((const JPH::Shape *)inShape2),
        ((inSubShapeIDOfShape2 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape2))
    );
}

const JPH_BodyID *JPH_ReversedShapeFilter_Get_mBodyID2(const JPH_ReversedShapeFilter *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ReversedShapeFilter *)(_this)).mBodyID2);
}

void JPH_ReversedShapeFilter_Set_mBodyID2(JPH_ReversedShapeFilter *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ReversedShapeFilter *)(_this)).mBodyID2 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_ReversedShapeFilter_GetMutable_mBodyID2(JPH_ReversedShapeFilter *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ReversedShapeFilter *)(_this)).mBodyID2);
}

JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_Construct(const JPH_ShapeFilter *inFilter)
{
    return (JPH_ReversedShapeFilter *)new JPH::ReversedShapeFilter(JPH::ReversedShapeFilter(
        ((inFilter ? void() : MRBINDC_THROW("Parameter `inFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inFilter))
    ));
}

const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_OffsetPtr(const JPH_ReversedShapeFilter *ptr, ptrdiff_t i)
{
    return (const JPH_ReversedShapeFilter *)(((const JPH::ReversedShapeFilter *)ptr) + i);
}

JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_OffsetMutablePtr(JPH_ReversedShapeFilter *ptr, ptrdiff_t i)
{
    return (JPH_ReversedShapeFilter *)(((JPH::ReversedShapeFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(const JPH_ReversedShapeFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ReversedShapeFilter *)object)
    ));
}

JPH_NonCopyable *JPH_ReversedShapeFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ReversedShapeFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ReversedShapeFilter *)object)
    ));
}

const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ReversedShapeFilter *)(static_cast<const JPH::ReversedShapeFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ReversedShapeFilter *)(static_cast<JPH::ReversedShapeFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ShapeFilter *JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(const JPH_ReversedShapeFilter *object)
{
    return (const JPH_ShapeFilter *)(static_cast<const JPH::ShapeFilter *>(
        ((const JPH::ReversedShapeFilter *)object)
    ));
}

JPH_ShapeFilter *JPH_ReversedShapeFilter_MutableUpcastTo_JPH_ShapeFilter(JPH_ReversedShapeFilter *object)
{
    return (JPH_ShapeFilter *)(static_cast<JPH::ShapeFilter *>(
        ((JPH::ReversedShapeFilter *)object)
    ));
}

const JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(const JPH_ShapeFilter *object)
{
    return (const JPH_ReversedShapeFilter *)(static_cast<const JPH::ReversedShapeFilter *>(
        ((const JPH::ShapeFilter *)object)
    ));
}

JPH_ReversedShapeFilter *JPH_ReversedShapeFilter_MutableStaticDowncastFrom_JPH_ShapeFilter(JPH_ShapeFilter *object)
{
    return (JPH_ReversedShapeFilter *)(static_cast<JPH::ReversedShapeFilter *>(
        ((JPH::ShapeFilter *)object)
    ));
}

void JPH_ReversedShapeFilter_Destroy(const JPH_ReversedShapeFilter *_this)
{
    delete ((const JPH::ReversedShapeFilter *)_this);
}

void JPH_ReversedShapeFilter_DestroyArray(const JPH_ReversedShapeFilter *_this)
{
    delete[] ((const JPH::ReversedShapeFilter *)_this);
}

bool JPH_ReversedShapeFilter_ShouldCollide_2(const JPH_ReversedShapeFilter *_this, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ReversedShapeFilter *)(_this)).ShouldCollide(
        ((const JPH::Shape *)inShape2),
        ((inSubShapeIDOfShape2 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape2))
    );
}

bool JPH_ReversedShapeFilter_ShouldCollide_4(const JPH_ReversedShapeFilter *_this, const JPH_Shape *inShape1, const JPH_SubShapeID *inSubShapeIDOfShape1, const JPH_Shape *inShape2, const JPH_SubShapeID *inSubShapeIDOfShape2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ReversedShapeFilter *)(_this)).ShouldCollide(
        ((const JPH::Shape *)inShape1),
        ((inSubShapeIDOfShape1 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape1)),
        ((const JPH::Shape *)inShape2),
        ((inSubShapeIDOfShape2 ? void() : MRBINDC_THROW("Parameter `inSubShapeIDOfShape2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeIDOfShape2))
    );
}

