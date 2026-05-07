// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_RagdollSettings_Part.h"

#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::RagdollSettings::Part>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_RagdollSettings_Part*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_Part *)(new JPH::Array<JPH::RagdollSettings::Part>[num_elems]);
}

Jolt_JPH_Array_JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_Part *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::RagdollSettings::Part>);
    return (Jolt_JPH_Array_JPH_RagdollSettings_Part *)new JPH::Array<JPH::RagdollSettings::Part>(JPH::Array<JPH::RagdollSettings::Part>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::RagdollSettings::Part>))
    ));
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_AssignFromAnother(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_Part *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::RagdollSettings::Part>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::RagdollSettings::Part>))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_Destroy(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    delete ((const JPH::Array<JPH::RagdollSettings::Part> *)_this);
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_DestroyArray(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    delete[] ((const JPH::Array<JPH::RagdollSettings::Part> *)_this);
}

const Jolt_JPH_Array_JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_OffsetPtr(const Jolt_JPH_Array_JPH_RagdollSettings_Part *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_RagdollSettings_Part *)(((const JPH::Array<JPH::RagdollSettings::Part> *)ptr) + i);
}

Jolt_JPH_Array_JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_OffsetMutablePtr(Jolt_JPH_Array_JPH_RagdollSettings_Part *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_Part *)(((JPH::Array<JPH::RagdollSettings::Part> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_RagdollSettings_Part_size(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_RagdollSettings_Part_empty(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_resize(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_resize_with_default_value(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t new_size, const JPH_RagdollSettings_Part *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(value))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_clear(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_RagdollSettings_Part_capacity(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_reserve(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_shrink_to_fit(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).shrink_to_fit();
}

const JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_at(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t i)
{
    return (const JPH_RagdollSettings_Part *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).at(
        i
    ));
}

JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_at_mut(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t i)
{
    return (JPH_RagdollSettings_Part *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).at(
        i
    ));
}

const JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_front(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return (const JPH_RagdollSettings_Part *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).front());
}

JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_front_mut(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return (JPH_RagdollSettings_Part *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).front());
}

const JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_back(const Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return (const JPH_RagdollSettings_Part *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::Part> *)(_this)).back());
}

JPH_RagdollSettings_Part *Jolt_JPH_Array_JPH_RagdollSettings_Part_back_mut(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    return (JPH_RagdollSettings_Part *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_push_back(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, Jolt_PassBy new_elem_pass_by, JPH_RagdollSettings_Part *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::RagdollSettings::Part);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_COPY(new_elem, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_END(new_elem, JPH::RagdollSettings::Part))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_pop_back(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_insert(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_RagdollSettings_Part *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::RagdollSettings::Part);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_COPY(new_elem, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_END(new_elem, JPH::RagdollSettings::Part)));
}

void Jolt_JPH_Array_JPH_RagdollSettings_Part_erase(Jolt_JPH_Array_JPH_RagdollSettings_Part *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::Part> *)(_this)).begin() + ptrdiff_t(position));
}

