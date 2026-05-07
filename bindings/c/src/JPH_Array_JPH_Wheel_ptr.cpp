// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_Wheel_ptr.h"

#include <Jolt/Physics/Vehicle/Wheel.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_Wheel_ptr *Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::Wheel *>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_Wheel_ptr*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_Wheel_ptr *Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_Wheel_ptr *)(new JPH::Array<JPH::Wheel *>[num_elems]);
}

Jolt_JPH_Array_JPH_Wheel_ptr *Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Wheel_ptr *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Wheel *>);
    return (Jolt_JPH_Array_JPH_Wheel_ptr *)new JPH::Array<JPH::Wheel *>(JPH::Array<JPH::Wheel *>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Wheel *>), JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Wheel *>), JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Wheel *>))
    ));
}

void Jolt_JPH_Array_JPH_Wheel_ptr_AssignFromAnother(Jolt_JPH_Array_JPH_Wheel_ptr *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Wheel_ptr *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Wheel *>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Wheel *>), JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Wheel *>), JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Wheel *>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Wheel *>))
    );
}

void Jolt_JPH_Array_JPH_Wheel_ptr_Destroy(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    delete ((const JPH::Array<JPH::Wheel *> *)_this);
}

void Jolt_JPH_Array_JPH_Wheel_ptr_DestroyArray(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    delete[] ((const JPH::Array<JPH::Wheel *> *)_this);
}

const Jolt_JPH_Array_JPH_Wheel_ptr *Jolt_JPH_Array_JPH_Wheel_ptr_OffsetPtr(const Jolt_JPH_Array_JPH_Wheel_ptr *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_Wheel_ptr *)(((const JPH::Array<JPH::Wheel *> *)ptr) + i);
}

Jolt_JPH_Array_JPH_Wheel_ptr *Jolt_JPH_Array_JPH_Wheel_ptr_OffsetMutablePtr(Jolt_JPH_Array_JPH_Wheel_ptr *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_Wheel_ptr *)(((JPH::Array<JPH::Wheel *> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_Wheel_ptr_size(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_Wheel_ptr_empty(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_Wheel_ptr_resize(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_Wheel_ptr_resize_with_default_value(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t new_size, JPH_Wheel *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).resize(
        new_size,
        ((JPH::Wheel *)value)
    );
}

void Jolt_JPH_Array_JPH_Wheel_ptr_clear(Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_Wheel_ptr_capacity(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_Wheel_ptr_reserve(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_Wheel_ptr_shrink_to_fit(Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).shrink_to_fit();
}

JPH_Wheel *const *Jolt_JPH_Array_JPH_Wheel_ptr_at(const Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t i)
{
    return (JPH_Wheel *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).at(
        i
    ));
}

JPH_Wheel **Jolt_JPH_Array_JPH_Wheel_ptr_at_mut(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t i)
{
    return (JPH_Wheel **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).at(
        i
    ));
}

JPH_Wheel *const *Jolt_JPH_Array_JPH_Wheel_ptr_front(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return (JPH_Wheel *const *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).front());
}

JPH_Wheel **Jolt_JPH_Array_JPH_Wheel_ptr_front_mut(Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return (JPH_Wheel **)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).front());
}

JPH_Wheel *const *Jolt_JPH_Array_JPH_Wheel_ptr_back(const Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return (JPH_Wheel *const *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Wheel *> *)(_this)).back());
}

JPH_Wheel **Jolt_JPH_Array_JPH_Wheel_ptr_back_mut(Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    return (JPH_Wheel **)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_Wheel_ptr_push_back(Jolt_JPH_Array_JPH_Wheel_ptr *_this, JPH_Wheel *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).push_back(
        ((JPH::Wheel *)new_elem)
    );
}

void Jolt_JPH_Array_JPH_Wheel_ptr_pop_back(Jolt_JPH_Array_JPH_Wheel_ptr *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_Wheel_ptr_insert(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t position, JPH_Wheel *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).begin() + ptrdiff_t(position), ((JPH::Wheel *)new_elem));
}

void Jolt_JPH_Array_JPH_Wheel_ptr_erase(Jolt_JPH_Array_JPH_Wheel_ptr *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Wheel *> *)(_this)).begin() + ptrdiff_t(position));
}

