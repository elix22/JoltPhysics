// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_CharacterVirtual_Contact.h"

#include <Jolt/Physics/Character/CharacterVirtual.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::CharacterVirtual::Contact>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_CharacterVirtual_Contact*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_CharacterVirtual_Contact *)(new JPH::Array<JPH::CharacterVirtual::Contact>[num_elems]);
}

Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_Contact *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CharacterVirtual::Contact>);
    return (Jolt_JPH_Array_JPH_CharacterVirtual_Contact *)new JPH::Array<JPH::CharacterVirtual::Contact>(JPH::Array<JPH::CharacterVirtual::Contact>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CharacterVirtual::Contact>), JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CharacterVirtual::Contact>), JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CharacterVirtual::Contact>))
    ));
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_AssignFromAnother(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_Contact *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CharacterVirtual::Contact>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CharacterVirtual::Contact>), JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CharacterVirtual::Contact>), JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CharacterVirtual::Contact>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CharacterVirtual::Contact>))
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_Destroy(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    delete ((const JPH::Array<JPH::CharacterVirtual::Contact> *)_this);
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DestroyArray(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    delete[] ((const JPH::Array<JPH::CharacterVirtual::Contact> *)_this);
}

const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetPtr(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *)(((const JPH::Array<JPH::CharacterVirtual::Contact> *)ptr) + i);
}

Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetMutablePtr(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_CharacterVirtual_Contact *)(((JPH::Array<JPH::CharacterVirtual::Contact> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_CharacterVirtual_Contact_size(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_CharacterVirtual_Contact_empty(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_resize(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_resize_with_default_value(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_size, const JPH_CharacterVirtual_Contact *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(value))
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_clear(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_CharacterVirtual_Contact_capacity(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_reserve(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_shrink_to_fit(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).shrink_to_fit();
}

const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_at(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t i)
{
    return (const JPH_CharacterVirtual_Contact *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).at(
        i
    ));
}

JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_at_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t i)
{
    return (JPH_CharacterVirtual_Contact *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).at(
        i
    ));
}

const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_front(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_CharacterVirtual_Contact *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).front());
}

JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_front_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_CharacterVirtual_Contact *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).front());
}

const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_back(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_CharacterVirtual_Contact *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).back());
}

JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_back_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_CharacterVirtual_Contact *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_push_back(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_Contact *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::CharacterVirtual::Contact(*(JPH::CharacterVirtual::Contact *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_pop_back(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_insert(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t position, const JPH_CharacterVirtual_Contact *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::CharacterVirtual::Contact(*(JPH::CharacterVirtual::Contact *)new_elem)));
}

void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_erase(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual::Contact> *)(_this)).begin() + ptrdiff_t(position));
}

