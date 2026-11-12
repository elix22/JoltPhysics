// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletonMapper_Locked.h"

#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletonMapper::Locked>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Locked*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Locked *)(new JPH::Array<JPH::SkeletonMapper::Locked>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Locked *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Locked>);
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Locked *)new JPH::Array<JPH::SkeletonMapper::Locked>(JPH::Array<JPH::SkeletonMapper::Locked>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Locked>), JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Locked>), JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Locked>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Locked *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Locked>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Locked>), JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Locked>), JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Locked>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Locked>))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_Destroy(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    delete ((const JPH::Array<JPH::SkeletonMapper::Locked> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_DestroyArray(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletonMapper::Locked> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *)(((const JPH::Array<JPH::SkeletonMapper::Locked> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Locked *)(((JPH::Array<JPH::SkeletonMapper::Locked> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Locked_size(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletonMapper_Locked_empty(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_resize(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t new_size, const JPH_SkeletonMapper_Locked *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletonMapper::Locked *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_clear(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Locked_capacity(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_reserve(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).shrink_to_fit();
}

const JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_at(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t i)
{
    return (const JPH_SkeletonMapper_Locked *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).at(
        i
    ));
}

JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_at_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t i)
{
    return (JPH_SkeletonMapper_Locked *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).at(
        i
    ));
}

const JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_front(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return (const JPH_SkeletonMapper_Locked *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).front());
}

JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_front_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return (JPH_SkeletonMapper_Locked *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).front());
}

const JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_back(const Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return (const JPH_SkeletonMapper_Locked *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).back());
}

JPH_SkeletonMapper_Locked *Jolt_JPH_Array_JPH_SkeletonMapper_Locked_back_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    return (JPH_SkeletonMapper_Locked *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_push_back(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, const JPH_SkeletonMapper_Locked *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Locked(*(JPH::SkeletonMapper::Locked *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_pop_back(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_insert(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t position, const JPH_SkeletonMapper_Locked *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Locked(*(JPH::SkeletonMapper::Locked *)new_elem)));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Locked_erase(Jolt_JPH_Array_JPH_SkeletonMapper_Locked *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Locked> *)(_this)).begin() + ptrdiff_t(position));
}

