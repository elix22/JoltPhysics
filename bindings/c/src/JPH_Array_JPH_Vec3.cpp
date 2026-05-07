// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_Vec3.h"

#include <Jolt/Math/Vec3.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::Vec3>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_Vec3*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_Vec3 *)(new JPH::Array<JPH::Vec3>[num_elems]);
}

Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Vec3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Vec3>);
    return (Jolt_JPH_Array_JPH_Vec3 *)new JPH::Array<JPH::Vec3>(JPH::Array<JPH::Vec3>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Vec3>), JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Vec3>), JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Vec3>))
    ));
}

void Jolt_JPH_Array_JPH_Vec3_AssignFromAnother(Jolt_JPH_Array_JPH_Vec3 *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Vec3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Vec3>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Vec3>), JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Vec3>), JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Vec3>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Vec3>))
    );
}

void Jolt_JPH_Array_JPH_Vec3_Destroy(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    delete ((const JPH::Array<JPH::Vec3> *)_this);
}

void Jolt_JPH_Array_JPH_Vec3_DestroyArray(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    delete[] ((const JPH::Array<JPH::Vec3> *)_this);
}

const Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_OffsetPtr(const Jolt_JPH_Array_JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_Vec3 *)(((const JPH::Array<JPH::Vec3> *)ptr) + i);
}

Jolt_JPH_Array_JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_OffsetMutablePtr(Jolt_JPH_Array_JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_Vec3 *)(((JPH::Array<JPH::Vec3> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_Vec3_size(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_Vec3_empty(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_Vec3_resize(Jolt_JPH_Array_JPH_Vec3 *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_Vec3_clear(Jolt_JPH_Array_JPH_Vec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_Vec3_capacity(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_Vec3_reserve(Jolt_JPH_Array_JPH_Vec3 *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_Vec3_shrink_to_fit(Jolt_JPH_Array_JPH_Vec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).shrink_to_fit();
}

const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_at(const Jolt_JPH_Array_JPH_Vec3 *_this, size_t i)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).at(
        i
    ));
}

JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_at_mut(Jolt_JPH_Array_JPH_Vec3 *_this, size_t i)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).at(
        i
    ));
}

const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_front(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return (const JPH_Vec3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).front());
}

JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_front_mut(Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).front());
}

const JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_back(const Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return (const JPH_Vec3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Vec3> *)(_this)).back());
}

JPH_Vec3 *Jolt_JPH_Array_JPH_Vec3_back_mut(Jolt_JPH_Array_JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_Vec3_push_back(Jolt_JPH_Array_JPH_Vec3 *_this, const JPH_Vec3 *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_Vec3_pop_back(Jolt_JPH_Array_JPH_Vec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Vec3> *)(_this)).pop_back();
}

