// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_std_pair_int_int.h"

#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>
#include <utility>


Jolt_JPH_Array_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<std::pair<int, int>>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_std_pair_int_int*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_std_pair_int_int *)(new JPH::Array<std::pair<int, int>>[num_elems]);
}

Jolt_JPH_Array_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_std_pair_int_int *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<std::pair<int, int>>);
    return (Jolt_JPH_Array_std_pair_int_int *)new JPH::Array<std::pair<int, int>>(JPH::Array<std::pair<int, int>>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<std::pair<int, int>>), JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<std::pair<int, int>>), JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_END(other, JPH::Array<std::pair<int, int>>))
    ));
}

void Jolt_JPH_Array_std_pair_int_int_AssignFromAnother(Jolt_JPH_Array_std_pair_int_int *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_std_pair_int_int *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<std::pair<int, int>>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<std::pair<int, int>>), JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<std::pair<int, int>>), JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<std::pair<int, int>>) MRBINDC_CLASSARG_END(other, JPH::Array<std::pair<int, int>>))
    );
}

void Jolt_JPH_Array_std_pair_int_int_Destroy(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    delete ((const JPH::Array<std::pair<int, int>> *)_this);
}

void Jolt_JPH_Array_std_pair_int_int_DestroyArray(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    delete[] ((const JPH::Array<std::pair<int, int>> *)_this);
}

const Jolt_JPH_Array_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_OffsetPtr(const Jolt_JPH_Array_std_pair_int_int *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_std_pair_int_int *)(((const JPH::Array<std::pair<int, int>> *)ptr) + i);
}

Jolt_JPH_Array_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_OffsetMutablePtr(Jolt_JPH_Array_std_pair_int_int *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_std_pair_int_int *)(((JPH::Array<std::pair<int, int>> *)ptr) + i);
}

size_t Jolt_JPH_Array_std_pair_int_int_size(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).size();
}

bool Jolt_JPH_Array_std_pair_int_int_empty(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).empty();
}

void Jolt_JPH_Array_std_pair_int_int_resize(Jolt_JPH_Array_std_pair_int_int *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_std_pair_int_int_resize_with_default_value(Jolt_JPH_Array_std_pair_int_int *_this, size_t new_size, const Jolt_std_pair_int_int *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const std::pair<int, int> *)(value))
    );
}

void Jolt_JPH_Array_std_pair_int_int_clear(Jolt_JPH_Array_std_pair_int_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).clear();
}

size_t Jolt_JPH_Array_std_pair_int_int_capacity(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).capacity();
}

void Jolt_JPH_Array_std_pair_int_int_reserve(Jolt_JPH_Array_std_pair_int_int *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_std_pair_int_int_shrink_to_fit(Jolt_JPH_Array_std_pair_int_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).shrink_to_fit();
}

const Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_at(const Jolt_JPH_Array_std_pair_int_int *_this, size_t i)
{
    return (const Jolt_std_pair_int_int *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).at(
        i
    ));
}

Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_at_mut(Jolt_JPH_Array_std_pair_int_int *_this, size_t i)
{
    return (Jolt_std_pair_int_int *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).at(
        i
    ));
}

const Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_front(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    return (const Jolt_std_pair_int_int *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).front());
}

Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_front_mut(Jolt_JPH_Array_std_pair_int_int *_this)
{
    return (Jolt_std_pair_int_int *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).front());
}

const Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_back(const Jolt_JPH_Array_std_pair_int_int *_this)
{
    return (const Jolt_std_pair_int_int *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<std::pair<int, int>> *)(_this)).back());
}

Jolt_std_pair_int_int *Jolt_JPH_Array_std_pair_int_int_back_mut(Jolt_JPH_Array_std_pair_int_int *_this)
{
    return (Jolt_std_pair_int_int *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).back());
}

void Jolt_JPH_Array_std_pair_int_int_push_back(Jolt_JPH_Array_std_pair_int_int *_this, const Jolt_std_pair_int_int *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), std::pair<int, int>(*(std::pair<int, int> *)new_elem))
    );
}

void Jolt_JPH_Array_std_pair_int_int_pop_back(Jolt_JPH_Array_std_pair_int_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).pop_back();
}

void Jolt_JPH_Array_std_pair_int_int_insert(Jolt_JPH_Array_std_pair_int_int *_this, size_t position, const Jolt_std_pair_int_int *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), std::pair<int, int>(*(std::pair<int, int> *)new_elem)));
}

void Jolt_JPH_Array_std_pair_int_int_erase(Jolt_JPH_Array_std_pair_int_int *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<std::pair<int, int>> *)(_this)).begin() + ptrdiff_t(position));
}

