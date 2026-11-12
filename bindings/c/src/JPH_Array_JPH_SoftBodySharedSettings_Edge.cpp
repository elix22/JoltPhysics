// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_Edge.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::Edge>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *)(new JPH::Array<JPH::SoftBodySharedSettings::Edge>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *)new JPH::Array<JPH::SoftBodySharedSettings::Edge>(JPH::Array<JPH::SoftBodySharedSettings::Edge>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Edge>), JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Edge>), JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Edge>), JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Edge>), JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Edge>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Edge>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *)(((const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *)(((JPH::Array<JPH::SoftBodySharedSettings::Edge> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t new_size, const JPH_SoftBodySharedSettings_Edge *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Edge *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_Edge *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_Edge *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return (const JPH_SoftBodySharedSettings_Edge *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).front());
}

JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return (JPH_SoftBodySharedSettings_Edge *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return (const JPH_SoftBodySharedSettings_Edge *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).back());
}

JPH_SoftBodySharedSettings_Edge *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    return (JPH_SoftBodySharedSettings_Edge *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, const JPH_SoftBodySharedSettings_Edge *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Edge(*(JPH::SoftBodySharedSettings::Edge *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t position, const JPH_SoftBodySharedSettings_Edge *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Edge(*(JPH::SoftBodySharedSettings::Edge *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Edge *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Edge> *)(_this)).begin() + ptrdiff_t(position));
}

