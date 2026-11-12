// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_VehicleAntiRollBar.h"

#include <Jolt/Physics/Vehicle/VehicleAntiRollBar.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::VehicleAntiRollBar>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar *)(new JPH::Array<JPH::VehicleAntiRollBar>[num_elems]);
}

Jolt_JPH_Array_JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_VehicleAntiRollBar *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::VehicleAntiRollBar>);
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar *)new JPH::Array<JPH::VehicleAntiRollBar>(JPH::Array<JPH::VehicleAntiRollBar>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::VehicleAntiRollBar>))
    ));
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_AssignFromAnother(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_VehicleAntiRollBar *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::VehicleAntiRollBar>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::VehicleAntiRollBar>))
    );
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_Destroy(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    delete ((const JPH::Array<JPH::VehicleAntiRollBar> *)_this);
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_DestroyArray(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    delete[] ((const JPH::Array<JPH::VehicleAntiRollBar> *)_this);
}

const Jolt_JPH_Array_JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_OffsetPtr(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_VehicleAntiRollBar *)(((const JPH::Array<JPH::VehicleAntiRollBar> *)ptr) + i);
}

Jolt_JPH_Array_JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_OffsetMutablePtr(Jolt_JPH_Array_JPH_VehicleAntiRollBar *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar *)(((JPH::Array<JPH::VehicleAntiRollBar> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_VehicleAntiRollBar_size(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_VehicleAntiRollBar_empty(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_resize(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_resize_with_default_value(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t new_size, const JPH_VehicleAntiRollBar *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::VehicleAntiRollBar *)(value))
    );
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_clear(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_VehicleAntiRollBar_capacity(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_reserve(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_shrink_to_fit(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).shrink_to_fit();
}

const JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_at(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t i)
{
    return (const JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).at(
        i
    ));
}

JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_at_mut(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t i)
{
    return (JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).at(
        i
    ));
}

const JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_front(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return (const JPH_VehicleAntiRollBar *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).front());
}

JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_front_mut(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return (JPH_VehicleAntiRollBar *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).front());
}

const JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_back(const Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return (const JPH_VehicleAntiRollBar *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).back());
}

JPH_VehicleAntiRollBar *Jolt_JPH_Array_JPH_VehicleAntiRollBar_back_mut(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    return (JPH_VehicleAntiRollBar *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_push_back(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, const JPH_VehicleAntiRollBar *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::VehicleAntiRollBar(*(JPH::VehicleAntiRollBar *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_pop_back(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_insert(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t position, const JPH_VehicleAntiRollBar *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::VehicleAntiRollBar(*(JPH::VehicleAntiRollBar *)new_elem)));
}

void Jolt_JPH_Array_JPH_VehicleAntiRollBar_erase(Jolt_JPH_Array_JPH_VehicleAntiRollBar *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleAntiRollBar> *)(_this)).begin() + ptrdiff_t(position));
}

