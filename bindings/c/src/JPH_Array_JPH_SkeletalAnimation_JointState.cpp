// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletalAnimation_JointState.h"

#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletalAnimation::JointState>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_JointState*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *)(new JPH::Array<JPH::SkeletalAnimation::JointState>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::JointState>);
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *)new JPH::Array<JPH::SkeletalAnimation::JointState>(JPH::Array<JPH::SkeletalAnimation::JointState>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::JointState>), JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::JointState>), JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::JointState>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletalAnimation::JointState>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletalAnimation::JointState>), JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletalAnimation::JointState>), JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletalAnimation::JointState>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletalAnimation::JointState>))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_Destroy(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    delete ((const JPH::Array<JPH::SkeletalAnimation::JointState> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_DestroyArray(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletalAnimation::JointState> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *)(((const JPH::Array<JPH::SkeletalAnimation::JointState> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *)(((JPH::Array<JPH::SkeletalAnimation::JointState> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_size(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_empty(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_resize(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t new_size, const JPH_SkeletalAnimation_JointState *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletalAnimation::JointState *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_clear(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_capacity(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_reserve(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).shrink_to_fit();
}

const JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_at(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t i)
{
    return (const JPH_SkeletalAnimation_JointState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).at(
        i
    ));
}

JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_at_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t i)
{
    return (JPH_SkeletalAnimation_JointState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).at(
        i
    ));
}

const JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_front(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return (const JPH_SkeletalAnimation_JointState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).front());
}

JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_front_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return (JPH_SkeletalAnimation_JointState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).front());
}

const JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_back(const Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return (const JPH_SkeletalAnimation_JointState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).back());
}

JPH_SkeletalAnimation_JointState *Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_back_mut(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    return (JPH_SkeletalAnimation_JointState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_push_back(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, const JPH_SkeletalAnimation_JointState *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletalAnimation::JointState(*(JPH::SkeletalAnimation::JointState *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_pop_back(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_insert(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t position, const JPH_SkeletalAnimation_JointState *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletalAnimation::JointState(*(JPH::SkeletalAnimation::JointState *)new_elem)));
}

void Jolt_JPH_Array_JPH_SkeletalAnimation_JointState_erase(Jolt_JPH_Array_JPH_SkeletalAnimation_JointState *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletalAnimation::JointState> *)(_this)).begin() + ptrdiff_t(position));
}

