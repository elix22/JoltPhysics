// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings.h"

#include <Jolt/Physics/Collision/Shape/CompoundShape.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)(new JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>[num_elems]);
}

Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>);
    return (Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)new JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>))
    ));
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>))
    );
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_Destroy(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    delete ((const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)_this);
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_DestroyArray(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    delete[] ((const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)_this);
}

const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_OffsetPtr(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)(((const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)ptr) + i);
}

Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_OffsetMutablePtr(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)(((JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_size(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_empty(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_resize(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_resize_with_default_value(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t new_size, const JPH_CompoundShapeSettings_SubShapeSettings *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::CompoundShapeSettings::SubShapeSettings *)(value))
    );
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_clear(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_capacity(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_reserve(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_shrink_to_fit(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).shrink_to_fit();
}

const JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_at(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t i)
{
    return (const JPH_CompoundShapeSettings_SubShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).at(
        i
    ));
}

JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_at_mut(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t i)
{
    return (JPH_CompoundShapeSettings_SubShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).at(
        i
    ));
}

const JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_front(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return (const JPH_CompoundShapeSettings_SubShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).front());
}

JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_front_mut(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return (JPH_CompoundShapeSettings_SubShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).front());
}

const JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_back(const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return (const JPH_CompoundShapeSettings_SubShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).back());
}

JPH_CompoundShapeSettings_SubShapeSettings *Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_back_mut(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return (JPH_CompoundShapeSettings_SubShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_push_back(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, Jolt_PassBy new_elem_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::CompoundShapeSettings::SubShapeSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_COPY(new_elem, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_END(new_elem, JPH::CompoundShapeSettings::SubShapeSettings))
    );
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_pop_back(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_insert(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::CompoundShapeSettings::SubShapeSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_COPY(new_elem, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_END(new_elem, JPH::CompoundShapeSettings::SubShapeSettings)));
}

void Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings_erase(Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings> *)(_this)).begin() + ptrdiff_t(position));
}

