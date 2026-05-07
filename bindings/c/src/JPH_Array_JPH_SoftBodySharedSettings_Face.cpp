// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_Face.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::Face>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *)(new JPH::Array<JPH::SoftBodySharedSettings::Face>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Face>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *)new JPH::Array<JPH::SoftBodySharedSettings::Face>(JPH::Array<JPH::SoftBodySharedSettings::Face>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Face>), JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Face>), JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Face>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::Face>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::Face>), JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::Face>), JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::Face>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::Face>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::Face> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::Face> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *)(((const JPH::Array<JPH::SoftBodySharedSettings::Face> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *)(((JPH::Array<JPH::SoftBodySharedSettings::Face> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t new_size, const JPH_SoftBodySharedSettings_Face *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Face *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_Face *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_Face *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return (const JPH_SoftBodySharedSettings_Face *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).front());
}

JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return (JPH_SoftBodySharedSettings_Face *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return (const JPH_SoftBodySharedSettings_Face *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).back());
}

JPH_SoftBodySharedSettings_Face *Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    return (JPH_SoftBodySharedSettings_Face *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, const JPH_SoftBodySharedSettings_Face *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Face(*(JPH::SoftBodySharedSettings::Face *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t position, const JPH_SoftBodySharedSettings_Face *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::Face(*(JPH::SoftBodySharedSettings::Face *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::Face> *)(_this)).begin() + ptrdiff_t(position));
}

