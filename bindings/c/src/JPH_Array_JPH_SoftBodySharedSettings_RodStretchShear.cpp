// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *)(new JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *)new JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>), JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>), JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>), JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>), JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *)(((const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *)(((JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t new_size, const JPH_SoftBodySharedSettings_RodStretchShear *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_RodStretchShear *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (const JPH_SoftBodySharedSettings_RodStretchShear *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).front());
}

JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (const JPH_SoftBodySharedSettings_RodStretchShear *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).back());
}

JPH_SoftBodySharedSettings_RodStretchShear *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, const JPH_SoftBodySharedSettings_RodStretchShear *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::RodStretchShear(*(JPH::SoftBodySharedSettings::RodStretchShear *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t position, const JPH_SoftBodySharedSettings_RodStretchShear *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::RodStretchShear(*(JPH::SoftBodySharedSettings::RodStretchShear *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodStretchShear *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodStretchShear> *)(_this)).begin() + ptrdiff_t(position));
}

