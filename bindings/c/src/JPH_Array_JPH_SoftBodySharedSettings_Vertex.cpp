// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_Vertex.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::Vertex>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *)(new JPH::Array<JPH::SoftBodySharedSettings::Vertex>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *)new JPH::Array<JPH::SoftBodySharedSettings::Vertex>(JPH::Array<JPH::SoftBodySharedSettings::Vertex>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Vertex>), JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Vertex>), JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Vertex>), JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Vertex>), JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Vertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Vertex>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *)(((const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *)(((JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t new_size, const JPH_SoftBodySharedSettings_Vertex *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Vertex *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (const JPH_SoftBodySharedSettings_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).front());
}

JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (JPH_SoftBodySharedSettings_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (const JPH_SoftBodySharedSettings_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).back());
}

JPH_SoftBodySharedSettings_Vertex *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (JPH_SoftBodySharedSettings_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, const JPH_SoftBodySharedSettings_Vertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Vertex(*(JPH::SoftBodySharedSettings::Vertex *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t position, const JPH_SoftBodySharedSettings_Vertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Vertex(*(JPH::SoftBodySharedSettings::Vertex *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Vertex *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Vertex> *)(_this)).begin() + ptrdiff_t(position));
}

