// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletalAnimation_Keyframe.h"

#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletalAnimation::Keyframe>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *)(new JPH::Array<JPH::SkeletalAnimation::Keyframe>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>);
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *)new JPH::Array<JPH::SkeletalAnimation::Keyframe>(JPH::Array<JPH::SkeletalAnimation::Keyframe>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::Keyframe>), JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::Keyframe>), JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::Keyframe>), JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::Keyframe>), JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::Keyframe>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::Keyframe>))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_Destroy(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    delete ((const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_DestroyArray(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *)(((const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *)(((JPH::Array<JPH::SkeletalAnimation::Keyframe> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_size(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_empty(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_resize(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t new_size, const JPH_SkeletalAnimation_Keyframe *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletalAnimation::Keyframe *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_clear(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_capacity(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_reserve(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).shrink_to_fit();
}

const JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_at(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t i)
{
    return (const JPH_SkeletalAnimation_Keyframe *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).at(
        i
    ));
}

JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_at_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t i)
{
    return (JPH_SkeletalAnimation_Keyframe *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).at(
        i
    ));
}

const JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_front(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return (const JPH_SkeletalAnimation_Keyframe *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).front());
}

JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_front_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return (JPH_SkeletalAnimation_Keyframe *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).front());
}

const JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_back(const Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return (const JPH_SkeletalAnimation_Keyframe *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).back());
}

JPH_SkeletalAnimation_Keyframe *Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_back_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    return (JPH_SkeletalAnimation_Keyframe *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_push_back(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, const JPH_SkeletalAnimation_Keyframe *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletalAnimation::Keyframe(*(JPH::SkeletalAnimation::Keyframe *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_pop_back(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_insert(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t position, const JPH_SkeletalAnimation_Keyframe *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletalAnimation::Keyframe(*(JPH::SkeletalAnimation::Keyframe *)new_elem)));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe_erase(Jolt_JPH_Array_JPH_SkeletalAnimation_Keyframe *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::Keyframe> *)(_this)).begin() + ptrdiff_t(position));
}

