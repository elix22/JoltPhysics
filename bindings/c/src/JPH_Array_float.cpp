// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_float.h"

#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_float *Jolt_JPH_Array_float_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<float>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_float*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_float *Jolt_JPH_Array_float_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_float *)(new JPH::Array<float>[num_elems]);
}

Jolt_JPH_Array_float *Jolt_JPH_Array_float_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_float *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<float>);
    return (Jolt_JPH_Array_float *)new JPH::Array<float>(JPH::Array<float>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<float>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<float>), JPH::Array<float>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<float>), JPH::Array<float>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<float>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<float>) MRBINDC_CLASSARG_END(other, JPH::Array<float>))
    ));
}

void Jolt_JPH_Array_float_AssignFromAnother(Jolt_JPH_Array_float *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_float *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<float>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<float>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<float>), JPH::Array<float>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<float>), JPH::Array<float>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<float>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<float>) MRBINDC_CLASSARG_END(other, JPH::Array<float>))
    );
}

void Jolt_JPH_Array_float_Destroy(const Jolt_JPH_Array_float *_this)
{
    delete ((const JPH::Array<float> *)_this);
}

void Jolt_JPH_Array_float_DestroyArray(const Jolt_JPH_Array_float *_this)
{
    delete[] ((const JPH::Array<float> *)_this);
}

const Jolt_JPH_Array_float *Jolt_JPH_Array_float_OffsetPtr(const Jolt_JPH_Array_float *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_float *)(((const JPH::Array<float> *)ptr) + i);
}

Jolt_JPH_Array_float *Jolt_JPH_Array_float_OffsetMutablePtr(Jolt_JPH_Array_float *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_float *)(((JPH::Array<float> *)ptr) + i);
}

Jolt_JPH_Array_float *Jolt_JPH_Array_float_ConstructFromRange(const float *ptr, size_t size)
{
    return (Jolt_JPH_Array_float *)new JPH::Array<float>(JPH::Array<float>(ptr, ptr + size));
}

void Jolt_JPH_Array_float_AssignFromRange(Jolt_JPH_Array_float *_this, const float *ptr, size_t size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)) = JPH::Array<float>(ptr, ptr + size);
}

size_t Jolt_JPH_Array_float_size(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).size();
}

bool Jolt_JPH_Array_float_empty(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).empty();
}

void Jolt_JPH_Array_float_resize(Jolt_JPH_Array_float *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_float_resize_with_default_value(Jolt_JPH_Array_float *_this, size_t new_size, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).resize(
        new_size,
        value
    );
}

void Jolt_JPH_Array_float_clear(Jolt_JPH_Array_float *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).clear();
}

size_t Jolt_JPH_Array_float_capacity(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).capacity();
}

void Jolt_JPH_Array_float_reserve(Jolt_JPH_Array_float *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_float_shrink_to_fit(Jolt_JPH_Array_float *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).shrink_to_fit();
}

const float *Jolt_JPH_Array_float_at(const Jolt_JPH_Array_float *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).at(
        i
    ));
}

float *Jolt_JPH_Array_float_at_mut(Jolt_JPH_Array_float *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).at(
        i
    ));
}

const float *Jolt_JPH_Array_float_front(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).front();
}

float *Jolt_JPH_Array_float_front_mut(Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).front();
}

const float *Jolt_JPH_Array_float_back(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).back();
}

float *Jolt_JPH_Array_float_back_mut(Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).back();
}

const float *Jolt_JPH_Array_float_data(const Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<float> *)(_this)).data();
}

float *Jolt_JPH_Array_float_data_mut(Jolt_JPH_Array_float *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).data();
}

void Jolt_JPH_Array_float_push_back(Jolt_JPH_Array_float *_this, float new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).push_back(
        new_elem
    );
}

void Jolt_JPH_Array_float_pop_back(Jolt_JPH_Array_float *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).pop_back();
}

void Jolt_JPH_Array_float_insert(Jolt_JPH_Array_float *_this, size_t position, float new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).begin() + ptrdiff_t(position), new_elem);
}

void Jolt_JPH_Array_float_erase(Jolt_JPH_Array_float *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<float> *)(_this)).begin() + ptrdiff_t(position));
}

