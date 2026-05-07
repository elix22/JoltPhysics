// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_RagdollSettings_AdditionalConstraint.h"

#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::RagdollSettings::AdditionalConstraint>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)(new JPH::Array<JPH::RagdollSettings::AdditionalConstraint>[num_elems]);
}

Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>);
    return (Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)new JPH::Array<JPH::RagdollSettings::AdditionalConstraint>(JPH::Array<JPH::RagdollSettings::AdditionalConstraint>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>))
    ));
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_Destroy(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    delete ((const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)_this);
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_DestroyArray(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    delete[] ((const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)_this);
}

const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_OffsetPtr(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)(((const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)ptr) + i);
}

Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_OffsetMutablePtr(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)(((JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_size(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_empty(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_resize(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_resize_with_default_value(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t new_size, const JPH_RagdollSettings_AdditionalConstraint *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::RagdollSettings::AdditionalConstraint *)(value))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_clear(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_capacity(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_reserve(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_shrink_to_fit(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).shrink_to_fit();
}

const JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_at(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t i)
{
    return (const JPH_RagdollSettings_AdditionalConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).at(
        i
    ));
}

JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_at_mut(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t i)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).at(
        i
    ));
}

const JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_front(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return (const JPH_RagdollSettings_AdditionalConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).front());
}

JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_front_mut(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).front());
}

const JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_back(const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return (const JPH_RagdollSettings_AdditionalConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).back());
}

JPH_RagdollSettings_AdditionalConstraint *Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_back_mut(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_push_back(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, Jolt_PassBy new_elem_pass_by, JPH_RagdollSettings_AdditionalConstraint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::RagdollSettings::AdditionalConstraint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_END(new_elem, JPH::RagdollSettings::AdditionalConstraint))
    );
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_pop_back(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_insert(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_RagdollSettings_AdditionalConstraint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::RagdollSettings::AdditionalConstraint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_END(new_elem, JPH::RagdollSettings::AdditionalConstraint)));
}

void Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint_erase(Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::RagdollSettings::AdditionalConstraint> *)(_this)).begin() + ptrdiff_t(position));
}

