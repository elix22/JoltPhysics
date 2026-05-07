// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_VehicleDifferentialSettings.h"

#include <Jolt/Physics/Vehicle/VehicleDifferential.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::VehicleDifferentialSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_VehicleDifferentialSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_VehicleDifferentialSettings *)(new JPH::Array<JPH::VehicleDifferentialSettings>[num_elems]);
}

Jolt_JPH_Array_JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_VehicleDifferentialSettings *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::VehicleDifferentialSettings>);
    return (Jolt_JPH_Array_JPH_VehicleDifferentialSettings *)new JPH::Array<JPH::VehicleDifferentialSettings>(JPH::Array<JPH::VehicleDifferentialSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::VehicleDifferentialSettings>), JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::VehicleDifferentialSettings>), JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::VehicleDifferentialSettings>))
    ));
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_AssignFromAnother(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_VehicleDifferentialSettings *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::VehicleDifferentialSettings>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::VehicleDifferentialSettings>), JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::VehicleDifferentialSettings>), JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::VehicleDifferentialSettings>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::VehicleDifferentialSettings>))
    );
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_Destroy(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    delete ((const JPH::Array<JPH::VehicleDifferentialSettings> *)_this);
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DestroyArray(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    delete[] ((const JPH::Array<JPH::VehicleDifferentialSettings> *)_this);
}

const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_OffsetPtr(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *)(((const JPH::Array<JPH::VehicleDifferentialSettings> *)ptr) + i);
}

Jolt_JPH_Array_JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_OffsetMutablePtr(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_VehicleDifferentialSettings *)(((JPH::Array<JPH::VehicleDifferentialSettings> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_VehicleDifferentialSettings_size(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_VehicleDifferentialSettings_empty(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize_with_default_value(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t new_size, const JPH_VehicleDifferentialSettings *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(value))
    );
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_clear(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_VehicleDifferentialSettings_capacity(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_reserve(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_shrink_to_fit(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).shrink_to_fit();
}

const JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t i)
{
    return (const JPH_VehicleDifferentialSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).at(
        i
    ));
}

JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at_mut(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t i)
{
    return (JPH_VehicleDifferentialSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).at(
        i
    ));
}

const JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return (const JPH_VehicleDifferentialSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).front());
}

JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front_mut(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return (JPH_VehicleDifferentialSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).front());
}

const JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back(const Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return (const JPH_VehicleDifferentialSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).back());
}

JPH_VehicleDifferentialSettings *Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back_mut(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    return (JPH_VehicleDifferentialSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_push_back(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, const JPH_VehicleDifferentialSettings *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::VehicleDifferentialSettings(*(JPH::VehicleDifferentialSettings *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_pop_back(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_insert(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t position, const JPH_VehicleDifferentialSettings *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::VehicleDifferentialSettings(*(JPH::VehicleDifferentialSettings *)new_elem)));
}

void Jolt_JPH_Array_JPH_VehicleDifferentialSettings_erase(Jolt_JPH_Array_JPH_VehicleDifferentialSettings *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::VehicleDifferentialSettings> *)(_this)).begin() + ptrdiff_t(position));
}

