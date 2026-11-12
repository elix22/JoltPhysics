// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_BodyID.h"

#include <Jolt/Physics/Body/BodyID.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::BodyID>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_BodyID*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_BodyID *)(new JPH::Array<JPH::BodyID>[num_elems]);
}

Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_BodyID *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::BodyID>);
    return (Jolt_JPH_Array_JPH_BodyID *)new JPH::Array<JPH::BodyID>(JPH::Array<JPH::BodyID>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::BodyID>), JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::BodyID>), JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::BodyID>))
    ));
}

void Jolt_JPH_Array_JPH_BodyID_AssignFromAnother(Jolt_JPH_Array_JPH_BodyID *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_BodyID *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::BodyID>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::BodyID>), JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::BodyID>), JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::BodyID>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::BodyID>))
    );
}

void Jolt_JPH_Array_JPH_BodyID_Destroy(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    delete ((const JPH::Array<JPH::BodyID> *)_this);
}

void Jolt_JPH_Array_JPH_BodyID_DestroyArray(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    delete[] ((const JPH::Array<JPH::BodyID> *)_this);
}

const Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_OffsetPtr(const Jolt_JPH_Array_JPH_BodyID *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_BodyID *)(((const JPH::Array<JPH::BodyID> *)ptr) + i);
}

Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_OffsetMutablePtr(Jolt_JPH_Array_JPH_BodyID *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_BodyID *)(((JPH::Array<JPH::BodyID> *)ptr) + i);
}

Jolt_JPH_Array_JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_ConstructFromRange(const JPH_BodyID *ptr, size_t size)
{
    return (Jolt_JPH_Array_JPH_BodyID *)new JPH::Array<JPH::BodyID>(JPH::Array<JPH::BodyID>(((const JPH::BodyID *)ptr), ((const JPH::BodyID *)ptr) + size));
}

void Jolt_JPH_Array_JPH_BodyID_AssignFromRange(Jolt_JPH_Array_JPH_BodyID *_this, const JPH_BodyID *ptr, size_t size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)) = JPH::Array<JPH::BodyID>(((const JPH::BodyID *)ptr), ((const JPH::BodyID *)ptr) + size);
}

size_t Jolt_JPH_Array_JPH_BodyID_size(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_BodyID_empty(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_BodyID_resize(Jolt_JPH_Array_JPH_BodyID *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_BodyID_resize_with_default_value(Jolt_JPH_Array_JPH_BodyID *_this, size_t new_size, const JPH_BodyID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::BodyID *)(value))
    );
}

void Jolt_JPH_Array_JPH_BodyID_clear(Jolt_JPH_Array_JPH_BodyID *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_BodyID_capacity(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_BodyID_reserve(Jolt_JPH_Array_JPH_BodyID *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_BodyID_shrink_to_fit(Jolt_JPH_Array_JPH_BodyID *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).shrink_to_fit();
}

const JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_at(const Jolt_JPH_Array_JPH_BodyID *_this, size_t i)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).at(
        i
    ));
}

JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_at_mut(Jolt_JPH_Array_JPH_BodyID *_this, size_t i)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).at(
        i
    ));
}

const JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_front(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (const JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).front());
}

JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_front_mut(Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).front());
}

const JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_back(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (const JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).back());
}

JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_back_mut(Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).back());
}

const JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_data(const Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (const JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::BodyID> *)(_this)).data());
}

JPH_BodyID *Jolt_JPH_Array_JPH_BodyID_data_mut(Jolt_JPH_Array_JPH_BodyID *_this)
{
    return (JPH_BodyID *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).data());
}

void Jolt_JPH_Array_JPH_BodyID_push_back(Jolt_JPH_Array_JPH_BodyID *_this, JPH_BodyID new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).push_back(
        MRBINDC_BIT_CAST((JPH::BodyID), new_elem)
    );
}

void Jolt_JPH_Array_JPH_BodyID_pop_back(Jolt_JPH_Array_JPH_BodyID *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_BodyID_insert(Jolt_JPH_Array_JPH_BodyID *_this, size_t position, JPH_BodyID new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).begin() + ptrdiff_t(position), MRBINDC_BIT_CAST((JPH::BodyID), new_elem));
}

void Jolt_JPH_Array_JPH_BodyID_erase(Jolt_JPH_Array_JPH_BodyID *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::BodyID> *)(_this)).begin() + ptrdiff_t(position));
}

