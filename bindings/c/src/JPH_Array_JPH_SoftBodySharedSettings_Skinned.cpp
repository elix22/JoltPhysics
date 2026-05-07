// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_Skinned.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::Skinned>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *)(new JPH::Array<JPH::SoftBodySharedSettings::Skinned>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *)new JPH::Array<JPH::SoftBodySharedSettings::Skinned>(JPH::Array<JPH::SoftBodySharedSettings::Skinned>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Skinned>), JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Skinned>), JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Skinned>), JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Skinned>), JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Skinned>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Skinned>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *)(((const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *)(((JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t new_size, const JPH_SoftBodySharedSettings_Skinned *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_Skinned *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_Skinned *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (const JPH_SoftBodySharedSettings_Skinned *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).front());
}

JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (JPH_SoftBodySharedSettings_Skinned *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (const JPH_SoftBodySharedSettings_Skinned *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).back());
}

JPH_SoftBodySharedSettings_Skinned *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (JPH_SoftBodySharedSettings_Skinned *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, const JPH_SoftBodySharedSettings_Skinned *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Skinned(*(JPH::SoftBodySharedSettings::Skinned *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t position, const JPH_SoftBodySharedSettings_Skinned *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Skinned(*(JPH::SoftBodySharedSettings::Skinned *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Skinned *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Skinned> *)(_this)).begin() + ptrdiff_t(position));
}

