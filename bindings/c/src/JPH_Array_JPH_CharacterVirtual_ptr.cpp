// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_CharacterVirtual_ptr.h"

#include <Jolt/Physics/Character/CharacterVirtual.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_CharacterVirtual_ptr *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::CharacterVirtual *>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_CharacterVirtual_ptr*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_CharacterVirtual_ptr *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_CharacterVirtual_ptr *)(new JPH::Array<JPH::CharacterVirtual *>[num_elems]);
}

Jolt_JPH_Array_JPH_CharacterVirtual_ptr *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_ptr *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CharacterVirtual *>);
    return (Jolt_JPH_Array_JPH_CharacterVirtual_ptr *)new JPH::Array<JPH::CharacterVirtual *>(JPH::Array<JPH::CharacterVirtual *>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CharacterVirtual *>), JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CharacterVirtual *>), JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CharacterVirtual *>))
    ));
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_AssignFromAnother(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_ptr *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CharacterVirtual *>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CharacterVirtual *>), JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CharacterVirtual *>), JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CharacterVirtual *>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CharacterVirtual *>))
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_Destroy(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    delete ((const JPH::Array<JPH::CharacterVirtual *> *)_this);
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_DestroyArray(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    delete[] ((const JPH::Array<JPH::CharacterVirtual *> *)_this);
}

const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_OffsetPtr(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *)(((const JPH::Array<JPH::CharacterVirtual *> *)ptr) + i);
}

Jolt_JPH_Array_JPH_CharacterVirtual_ptr *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_OffsetMutablePtr(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_CharacterVirtual_ptr *)(((JPH::Array<JPH::CharacterVirtual *> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_CharacterVirtual_ptr_size(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_CharacterVirtual_ptr_empty(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_resize(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_resize_with_default_value(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t new_size, JPH_CharacterVirtual *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).resize(
        new_size,
        ((JPH::CharacterVirtual *)value)
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_clear(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_CharacterVirtual_ptr_capacity(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_reserve(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_shrink_to_fit(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).shrink_to_fit();
}

JPH_CharacterVirtual *const *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_at(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t i)
{
    return (JPH_CharacterVirtual *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).at(
        i
    ));
}

JPH_CharacterVirtual **Jolt_JPH_Array_JPH_CharacterVirtual_ptr_at_mut(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t i)
{
    return (JPH_CharacterVirtual **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).at(
        i
    ));
}

JPH_CharacterVirtual *const *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_front(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return (JPH_CharacterVirtual *const *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).front());
}

JPH_CharacterVirtual **Jolt_JPH_Array_JPH_CharacterVirtual_ptr_front_mut(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return (JPH_CharacterVirtual **)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).front());
}

JPH_CharacterVirtual *const *Jolt_JPH_Array_JPH_CharacterVirtual_ptr_back(const Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return (JPH_CharacterVirtual *const *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CharacterVirtual *> *)(_this)).back());
}

JPH_CharacterVirtual **Jolt_JPH_Array_JPH_CharacterVirtual_ptr_back_mut(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    return (JPH_CharacterVirtual **)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_push_back(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, JPH_CharacterVirtual *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).push_back(
        ((JPH::CharacterVirtual *)new_elem)
    );
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_pop_back(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_insert(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t position, JPH_CharacterVirtual *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).begin() + ptrdiff_t(position), ((JPH::CharacterVirtual *)new_elem));
}

void Jolt_JPH_Array_JPH_CharacterVirtual_ptr_erase(Jolt_JPH_Array_JPH_CharacterVirtual_ptr *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CharacterVirtual *> *)(_this)).begin() + ptrdiff_t(position));
}

