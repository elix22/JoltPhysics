// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_InvBind.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::InvBind>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *)(new JPH::Array<JPH::SoftBodySharedSettings::InvBind>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *)new JPH::Array<JPH::SoftBodySharedSettings::InvBind>(JPH::Array<JPH::SoftBodySharedSettings::InvBind>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::InvBind>), JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::InvBind>), JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::InvBind>), JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::InvBind>), JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::InvBind>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::InvBind>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *)(((const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *)(((JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t new_size, const JPH_SoftBodySharedSettings_InvBind *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::InvBind *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_InvBind *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_InvBind *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (const JPH_SoftBodySharedSettings_InvBind *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).front());
}

JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (JPH_SoftBodySharedSettings_InvBind *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (const JPH_SoftBodySharedSettings_InvBind *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).back());
}

JPH_SoftBodySharedSettings_InvBind *Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (JPH_SoftBodySharedSettings_InvBind *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, const JPH_SoftBodySharedSettings_InvBind *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::InvBind(*(JPH::SoftBodySharedSettings::InvBind *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t position, const JPH_SoftBodySharedSettings_InvBind *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::InvBind(*(JPH::SoftBodySharedSettings::InvBind *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::InvBind> *)(_this)).begin() + ptrdiff_t(position));
}

