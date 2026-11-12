// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletalAnimation_AnimatedJoint.h"

#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *)(new JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>);
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *)new JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>), JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>), JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>), JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>), JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::AnimatedJoint>))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_Destroy(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    delete ((const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_DestroyArray(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *)(((const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *)(((JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_size(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_empty(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_resize(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t new_size, const JPH_SkeletalAnimation_AnimatedJoint *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletalAnimation::AnimatedJoint *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_clear(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_capacity(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_reserve(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).shrink_to_fit();
}

const JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_at(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t i)
{
    return (const JPH_SkeletalAnimation_AnimatedJoint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).at(
        i
    ));
}

JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_at_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t i)
{
    return (JPH_SkeletalAnimation_AnimatedJoint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).at(
        i
    ));
}

const JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_front(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return (const JPH_SkeletalAnimation_AnimatedJoint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).front());
}

JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_front_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return (JPH_SkeletalAnimation_AnimatedJoint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).front());
}

const JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_back(const Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return (const JPH_SkeletalAnimation_AnimatedJoint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).back());
}

JPH_SkeletalAnimation_AnimatedJoint *Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_back_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    return (JPH_SkeletalAnimation_AnimatedJoint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_push_back(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, Jolt_PassBy new_elem_pass_by, JPH_SkeletalAnimation_AnimatedJoint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::SkeletalAnimation::AnimatedJoint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_END(new_elem, JPH::SkeletalAnimation::AnimatedJoint))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_pop_back(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_insert(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_SkeletalAnimation_AnimatedJoint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::SkeletalAnimation::AnimatedJoint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_END(new_elem, JPH::SkeletalAnimation::AnimatedJoint)));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint_erase(Jolt_JPH_Array_JPH_SkeletalAnimation_AnimatedJoint *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::AnimatedJoint> *)(_this)).begin() + ptrdiff_t(position));
}

