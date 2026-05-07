// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SkeletonMapper_Chain.h"

#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SkeletonMapper::Chain>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Chain*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Chain *)(new JPH::Array<JPH::SkeletonMapper::Chain>[num_elems]);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Chain *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Chain>);
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Chain *)new JPH::Array<JPH::SkeletonMapper::Chain>(JPH::Array<JPH::SkeletonMapper::Chain>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Chain>), JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Chain>), JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Chain>))
    ));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_AssignFromAnother(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SkeletonMapper_Chain *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SkeletonMapper::Chain>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SkeletonMapper::Chain>), JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SkeletonMapper::Chain>), JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SkeletonMapper::Chain>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SkeletonMapper::Chain>))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_Destroy(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    delete ((const JPH::Array<JPH::SkeletonMapper::Chain> *)_this);
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DestroyArray(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    delete[] ((const JPH::Array<JPH::SkeletonMapper::Chain> *)_this);
}

const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_OffsetPtr(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *)(((const JPH::Array<JPH::SkeletonMapper::Chain> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_OffsetMutablePtr(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SkeletonMapper_Chain *)(((JPH::Array<JPH::SkeletonMapper::Chain> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Chain_size(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SkeletonMapper_Chain_empty(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize_with_default_value(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t new_size, const JPH_SkeletonMapper_Chain *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SkeletonMapper::Chain *)(value))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_clear(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SkeletonMapper_Chain_capacity(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_reserve(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_shrink_to_fit(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).shrink_to_fit();
}

const JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t i)
{
    return (const JPH_SkeletonMapper_Chain *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).at(
        i
    ));
}

JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t i)
{
    return (JPH_SkeletonMapper_Chain *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).at(
        i
    ));
}

const JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return (const JPH_SkeletonMapper_Chain *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).front());
}

JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return (JPH_SkeletonMapper_Chain *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).front());
}

const JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back(const Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return (const JPH_SkeletonMapper_Chain *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).back());
}

JPH_SkeletonMapper_Chain *Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back_mut(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    return (JPH_SkeletonMapper_Chain *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_push_back(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, Jolt_PassBy new_elem_pass_by, JPH_SkeletonMapper_Chain *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::SkeletonMapper::Chain);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_COPY(new_elem, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_END(new_elem, JPH::SkeletonMapper::Chain))
    );
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_pop_back(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_insert(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_SkeletonMapper_Chain *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::SkeletonMapper::Chain);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_COPY(new_elem, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_END(new_elem, JPH::SkeletonMapper::Chain)));
}

void Jolt_JPH_Array_JPH_SkeletonMapper_Chain_erase(Jolt_JPH_Array_JPH_SkeletonMapper_Chain *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SkeletonMapper::Chain> *)(_this)).begin() + ptrdiff_t(position));
}

