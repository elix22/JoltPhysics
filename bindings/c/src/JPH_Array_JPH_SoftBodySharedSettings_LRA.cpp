// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_LRA.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::LRA>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *)(new JPH::Array<JPH::SoftBodySharedSettings::LRA>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *)new JPH::Array<JPH::SoftBodySharedSettings::LRA>(JPH::Array<JPH::SoftBodySharedSettings::LRA>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::LRA>), JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::LRA>), JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::LRA>), JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::LRA>), JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::LRA>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::LRA>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *)(((const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *)(((JPH::Array<JPH::SoftBodySharedSettings::LRA> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t new_size, const JPH_SoftBodySharedSettings_LRA *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::LRA *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_LRA *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_LRA *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return (const JPH_SoftBodySharedSettings_LRA *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).front());
}

JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return (JPH_SoftBodySharedSettings_LRA *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return (const JPH_SoftBodySharedSettings_LRA *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).back());
}

JPH_SoftBodySharedSettings_LRA *Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    return (JPH_SoftBodySharedSettings_LRA *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, const JPH_SoftBodySharedSettings_LRA *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::LRA(*(JPH::SoftBodySharedSettings::LRA *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t position, const JPH_SoftBodySharedSettings_LRA *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::LRA(*(JPH::SoftBodySharedSettings::LRA *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::LRA> *)(_this)).begin() + ptrdiff_t(position));
}

