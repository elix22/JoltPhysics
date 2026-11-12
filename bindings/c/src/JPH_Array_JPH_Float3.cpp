// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_Float3.h"

#include <Jolt/Math/Float3.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_Float3 *Jolt_JPH_Array_JPH_Float3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::Float3>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_Float3*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_Float3 *Jolt_JPH_Array_JPH_Float3_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_Float3 *)(new JPH::Array<JPH::Float3>[num_elems]);
}

Jolt_JPH_Array_JPH_Float3 *Jolt_JPH_Array_JPH_Float3_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Float3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Float3>);
    return (Jolt_JPH_Array_JPH_Float3 *)new JPH::Array<JPH::Float3>(JPH::Array<JPH::Float3>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Float3>), JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Float3>), JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Float3>))
    ));
}

void Jolt_JPH_Array_JPH_Float3_AssignFromAnother(Jolt_JPH_Array_JPH_Float3 *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Float3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Float3>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Float3>), JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Float3>), JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Float3>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Float3>))
    );
}

void Jolt_JPH_Array_JPH_Float3_Destroy(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    delete ((const JPH::Array<JPH::Float3> *)_this);
}

void Jolt_JPH_Array_JPH_Float3_DestroyArray(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    delete[] ((const JPH::Array<JPH::Float3> *)_this);
}

const Jolt_JPH_Array_JPH_Float3 *Jolt_JPH_Array_JPH_Float3_OffsetPtr(const Jolt_JPH_Array_JPH_Float3 *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_Float3 *)(((const JPH::Array<JPH::Float3> *)ptr) + i);
}

Jolt_JPH_Array_JPH_Float3 *Jolt_JPH_Array_JPH_Float3_OffsetMutablePtr(Jolt_JPH_Array_JPH_Float3 *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_Float3 *)(((JPH::Array<JPH::Float3> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_Float3_size(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_Float3_empty(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_Float3_resize(Jolt_JPH_Array_JPH_Float3 *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_Float3_clear(Jolt_JPH_Array_JPH_Float3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_Float3_capacity(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_Float3_reserve(Jolt_JPH_Array_JPH_Float3 *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_Float3_shrink_to_fit(Jolt_JPH_Array_JPH_Float3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).shrink_to_fit();
}

const JPH_Float3 *Jolt_JPH_Array_JPH_Float3_at(const Jolt_JPH_Array_JPH_Float3 *_this, size_t i)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).at(
        i
    ));
}

JPH_Float3 *Jolt_JPH_Array_JPH_Float3_at_mut(Jolt_JPH_Array_JPH_Float3 *_this, size_t i)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).at(
        i
    ));
}

const JPH_Float3 *Jolt_JPH_Array_JPH_Float3_front(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    return (const JPH_Float3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).front());
}

JPH_Float3 *Jolt_JPH_Array_JPH_Float3_front_mut(Jolt_JPH_Array_JPH_Float3 *_this)
{
    return (JPH_Float3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).front());
}

const JPH_Float3 *Jolt_JPH_Array_JPH_Float3_back(const Jolt_JPH_Array_JPH_Float3 *_this)
{
    return (const JPH_Float3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Float3> *)(_this)).back());
}

JPH_Float3 *Jolt_JPH_Array_JPH_Float3_back_mut(Jolt_JPH_Array_JPH_Float3 *_this)
{
    return (JPH_Float3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_Float3_push_back(Jolt_JPH_Array_JPH_Float3 *_this, const JPH_Float3 *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::Float3(*(JPH::Float3 *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_Float3_pop_back(Jolt_JPH_Array_JPH_Float3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Float3> *)(_this)).pop_back();
}

