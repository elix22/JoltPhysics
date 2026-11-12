// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *)(new JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *)new JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>), JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>), JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>), JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>), JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *)(((const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *)(((JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t new_size, const JPH_SoftBodySharedSettings_RodBendTwist *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodBendTwist *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_RodBendTwist *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (const JPH_SoftBodySharedSettings_RodBendTwist *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).front());
}

JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (const JPH_SoftBodySharedSettings_RodBendTwist *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).back());
}

JPH_SoftBodySharedSettings_RodBendTwist *Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, const JPH_SoftBodySharedSettings_RodBendTwist *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::RodBendTwist(*(JPH::SoftBodySharedSettings::RodBendTwist *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t position, const JPH_SoftBodySharedSettings_RodBendTwist *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::RodBendTwist(*(JPH::SoftBodySharedSettings::RodBendTwist *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_RodBendTwist *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::RodBendTwist> *)(_this)).begin() + ptrdiff_t(position));
}

