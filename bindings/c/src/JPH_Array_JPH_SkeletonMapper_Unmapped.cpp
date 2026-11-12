// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletonMapper_Unmapped.h"

#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletonMapper::Unmapped>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *)(new JPH::Array<JPH::SkeletonMapper::Unmapped>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Unmapped>);
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *)new JPH::Array<JPH::SkeletonMapper::Unmapped>(JPH::Array<JPH::SkeletonMapper::Unmapped>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Unmapped>), JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Unmapped>), JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Unmapped>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Unmapped>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Unmapped>), JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Unmapped>), JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Unmapped>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Unmapped>))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_Destroy(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    delete ((const JPH::Array<JPH::SkeletonMapper::Unmapped> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_DestroyArray(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletonMapper::Unmapped> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *)(((const JPH::Array<JPH::SkeletonMapper::Unmapped> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *)(((JPH::Array<JPH::SkeletonMapper::Unmapped> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_size(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_empty(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_resize(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t new_size, const JPH_SkeletonMapper_Unmapped *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletonMapper::Unmapped *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_clear(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_capacity(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_reserve(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).shrink_to_fit();
}

const JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_at(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t i)
{
    return (const JPH_SkeletonMapper_Unmapped *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).at(
        i
    ));
}

JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_at_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t i)
{
    return (JPH_SkeletonMapper_Unmapped *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).at(
        i
    ));
}

const JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_front(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return (const JPH_SkeletonMapper_Unmapped *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).front());
}

JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_front_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return (JPH_SkeletonMapper_Unmapped *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).front());
}

const JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_back(const Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return (const JPH_SkeletonMapper_Unmapped *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).back());
}

JPH_SkeletonMapper_Unmapped *Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_back_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    return (JPH_SkeletonMapper_Unmapped *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_push_back(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, const JPH_SkeletonMapper_Unmapped *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Unmapped(*(JPH::SkeletonMapper::Unmapped *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_pop_back(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_insert(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t position, const JPH_SkeletonMapper_Unmapped *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Unmapped(*(JPH::SkeletonMapper::Unmapped *)new_elem)));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped_erase(Jolt_JPH_Array_JPH_SkeletonMapper_Unmapped *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Unmapped> *)(_this)).begin() + ptrdiff_t(position));
}

