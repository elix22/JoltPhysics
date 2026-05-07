// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_Mat44.h"

#include <Jolt/Math/Mat44.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::Mat44>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_Mat44*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_Mat44 *)(new JPH::Array<JPH::Mat44>[num_elems]);
}

Jolt_JPH_Array_JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Mat44 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Mat44>);
    return (Jolt_JPH_Array_JPH_Mat44 *)new JPH::Array<JPH::Mat44>(JPH::Array<JPH::Mat44>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Mat44>), JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Mat44>), JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Mat44>))
    ));
}

void Jolt_JPH_Array_JPH_Mat44_AssignFromAnother(Jolt_JPH_Array_JPH_Mat44 *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Mat44 *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Mat44>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Mat44>), JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Mat44>), JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Mat44>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Mat44>))
    );
}

void Jolt_JPH_Array_JPH_Mat44_Destroy(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    delete ((const JPH::Array<JPH::Mat44> *)_this);
}

void Jolt_JPH_Array_JPH_Mat44_DestroyArray(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    delete[] ((const JPH::Array<JPH::Mat44> *)_this);
}

const Jolt_JPH_Array_JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_OffsetPtr(const Jolt_JPH_Array_JPH_Mat44 *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_Mat44 *)(((const JPH::Array<JPH::Mat44> *)ptr) + i);
}

Jolt_JPH_Array_JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_OffsetMutablePtr(Jolt_JPH_Array_JPH_Mat44 *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_Mat44 *)(((JPH::Array<JPH::Mat44> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_Mat44_size(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_Mat44_empty(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_Mat44_resize(Jolt_JPH_Array_JPH_Mat44 *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_Mat44_clear(Jolt_JPH_Array_JPH_Mat44 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_Mat44_capacity(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_Mat44_reserve(Jolt_JPH_Array_JPH_Mat44 *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_Mat44_shrink_to_fit(Jolt_JPH_Array_JPH_Mat44 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).shrink_to_fit();
}

const JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_at(const Jolt_JPH_Array_JPH_Mat44 *_this, size_t i)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).at(
        i
    ));
}

JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_at_mut(Jolt_JPH_Array_JPH_Mat44 *_this, size_t i)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).at(
        i
    ));
}

const JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_front(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return (const JPH_Mat44 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).front());
}

JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_front_mut(Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).front());
}

const JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_back(const Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return (const JPH_Mat44 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Mat44> *)(_this)).back());
}

JPH_Mat44 *Jolt_JPH_Array_JPH_Mat44_back_mut(Jolt_JPH_Array_JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_Mat44_push_back(Jolt_JPH_Array_JPH_Mat44 *_this, const JPH_Mat44 *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::Mat44(*(JPH::Mat44 *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_Mat44_pop_back(Jolt_JPH_Array_JPH_Mat44 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Mat44> *)(_this)).pop_back();
}

