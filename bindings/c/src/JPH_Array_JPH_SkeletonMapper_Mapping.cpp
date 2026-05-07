// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletonMapper_Mapping.h"

#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletonMapper::Mapping>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Mapping*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *)(new JPH::Array<JPH::SkeletonMapper::Mapping>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Mapping>);
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *)new JPH::Array<JPH::SkeletonMapper::Mapping>(JPH::Array<JPH::SkeletonMapper::Mapping>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Mapping>), JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Mapping>), JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Mapping>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Mapping>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Mapping>), JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Mapping>), JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Mapping>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Mapping>))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_Destroy(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    delete ((const JPH::Array<JPH::SkeletonMapper::Mapping> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_DestroyArray(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletonMapper::Mapping> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *)(((const JPH::Array<JPH::SkeletonMapper::Mapping> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *)(((JPH::Array<JPH::SkeletonMapper::Mapping> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_size(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_empty(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_resize(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t new_size, const JPH_SkeletonMapper_Mapping *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletonMapper::Mapping *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_clear(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_capacity(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_reserve(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).shrink_to_fit();
}

const JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_at(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t i)
{
    return (const JPH_SkeletonMapper_Mapping *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).at(
        i
    ));
}

JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_at_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t i)
{
    return (JPH_SkeletonMapper_Mapping *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).at(
        i
    ));
}

const JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_front(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return (const JPH_SkeletonMapper_Mapping *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).front());
}

JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_front_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return (JPH_SkeletonMapper_Mapping *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).front());
}

const JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_back(const Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return (const JPH_SkeletonMapper_Mapping *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).back());
}

JPH_SkeletonMapper_Mapping *Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_back_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    return (JPH_SkeletonMapper_Mapping *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_push_back(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, const JPH_SkeletonMapper_Mapping *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Mapping(*(JPH::SkeletonMapper::Mapping *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_pop_back(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_insert(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t position, const JPH_SkeletonMapper_Mapping *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SkeletonMapper::Mapping(*(JPH::SkeletonMapper::Mapping *)new_elem)));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Mapping_erase(Jolt_JPH_Array_JPH_SkeletonMapper_Mapping *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Mapping> *)(_this)).begin() + ptrdiff_t(position));
}

