// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_int.h"

#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_int *Jolt_JPH_Array_int_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<int>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_int*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_int *Jolt_JPH_Array_int_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_int *)(new JPH::Array<int>[num_elems]);
}

Jolt_JPH_Array_int *Jolt_JPH_Array_int_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_int *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<int>);
    return (Jolt_JPH_Array_int *)new JPH::Array<int>(JPH::Array<int>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<int>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<int>), JPH::Array<int>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<int>), JPH::Array<int>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<int>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<int>) MRBINDC_CLASSARG_END(other, JPH::Array<int>))
    ));
}

void Jolt_JPH_Array_int_AssignFromAnother(Jolt_JPH_Array_int *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_int *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<int>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<int>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<int>), JPH::Array<int>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<int>), JPH::Array<int>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<int>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<int>) MRBINDC_CLASSARG_END(other, JPH::Array<int>))
    );
}

void Jolt_JPH_Array_int_Destroy(const Jolt_JPH_Array_int *_this)
{
    delete ((const JPH::Array<int> *)_this);
}

void Jolt_JPH_Array_int_DestroyArray(const Jolt_JPH_Array_int *_this)
{
    delete[] ((const JPH::Array<int> *)_this);
}

const Jolt_JPH_Array_int *Jolt_JPH_Array_int_OffsetPtr(const Jolt_JPH_Array_int *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_int *)(((const JPH::Array<int> *)ptr) + i);
}

Jolt_JPH_Array_int *Jolt_JPH_Array_int_OffsetMutablePtr(Jolt_JPH_Array_int *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_int *)(((JPH::Array<int> *)ptr) + i);
}

Jolt_JPH_Array_int *Jolt_JPH_Array_int_ConstructFromRange(const int *ptr, size_t size)
{
    return (Jolt_JPH_Array_int *)new JPH::Array<int>(JPH::Array<int>(ptr, ptr + size));
}

void Jolt_JPH_Array_int_AssignFromRange(Jolt_JPH_Array_int *_this, const int *ptr, size_t size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)) = JPH::Array<int>(ptr, ptr + size);
}

size_t Jolt_JPH_Array_int_size(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).size();
}

bool Jolt_JPH_Array_int_empty(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).empty();
}

void Jolt_JPH_Array_int_resize(Jolt_JPH_Array_int *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_int_resize_with_default_value(Jolt_JPH_Array_int *_this, size_t new_size, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).resize(
        new_size,
        value
    );
}

void Jolt_JPH_Array_int_clear(Jolt_JPH_Array_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).clear();
}

size_t Jolt_JPH_Array_int_capacity(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).capacity();
}

void Jolt_JPH_Array_int_reserve(Jolt_JPH_Array_int *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_int_shrink_to_fit(Jolt_JPH_Array_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).shrink_to_fit();
}

const int *Jolt_JPH_Array_int_at(const Jolt_JPH_Array_int *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).at(
        i
    ));
}

int *Jolt_JPH_Array_int_at_mut(Jolt_JPH_Array_int *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).at(
        i
    ));
}

const int *Jolt_JPH_Array_int_front(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).front();
}

int *Jolt_JPH_Array_int_front_mut(Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).front();
}

const int *Jolt_JPH_Array_int_back(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).back();
}

int *Jolt_JPH_Array_int_back_mut(Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).back();
}

const int *Jolt_JPH_Array_int_data(const Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<int> *)(_this)).data();
}

int *Jolt_JPH_Array_int_data_mut(Jolt_JPH_Array_int *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).data();
}

void Jolt_JPH_Array_int_push_back(Jolt_JPH_Array_int *_this, int new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).push_back(
        new_elem
    );
}

void Jolt_JPH_Array_int_pop_back(Jolt_JPH_Array_int *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).pop_back();
}

void Jolt_JPH_Array_int_insert(Jolt_JPH_Array_int *_this, size_t position, int new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).begin() + ptrdiff_t(position), new_elem);
}

void Jolt_JPH_Array_int_erase(Jolt_JPH_Array_int *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<int> *)(_this)).begin() + ptrdiff_t(position));
}

