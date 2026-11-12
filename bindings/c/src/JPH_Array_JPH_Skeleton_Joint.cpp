// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_Skeleton_Joint.h"

#include <Jolt/Skeleton/Skeleton.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::Skeleton::Joint>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_Skeleton_Joint*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_Skeleton_Joint *)(new JPH::Array<JPH::Skeleton::Joint>[num_elems]);
}

Jolt_JPH_Array_JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Skeleton_Joint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Skeleton::Joint>);
    return (Jolt_JPH_Array_JPH_Skeleton_Joint *)new JPH::Array<JPH::Skeleton::Joint>(JPH::Array<JPH::Skeleton::Joint>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Skeleton::Joint>), JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Skeleton::Joint>), JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Skeleton::Joint>))
    ));
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_AssignFromAnother(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_Skeleton_Joint *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::Skeleton::Joint>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::Skeleton::Joint>), JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::Skeleton::Joint>), JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::Skeleton::Joint>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::Skeleton::Joint>))
    );
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_Destroy(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    delete ((const JPH::Array<JPH::Skeleton::Joint> *)_this);
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_DestroyArray(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    delete[] ((const JPH::Array<JPH::Skeleton::Joint> *)_this);
}

const Jolt_JPH_Array_JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_OffsetPtr(const Jolt_JPH_Array_JPH_Skeleton_Joint *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_Skeleton_Joint *)(((const JPH::Array<JPH::Skeleton::Joint> *)ptr) + i);
}

Jolt_JPH_Array_JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_OffsetMutablePtr(Jolt_JPH_Array_JPH_Skeleton_Joint *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_Skeleton_Joint *)(((JPH::Array<JPH::Skeleton::Joint> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_Skeleton_Joint_size(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_Skeleton_Joint_empty(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_resize(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_resize_with_default_value(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t new_size, const JPH_Skeleton_Joint *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::Skeleton::Joint *)(value))
    );
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_clear(Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_Skeleton_Joint_capacity(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_reserve(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_shrink_to_fit(Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).shrink_to_fit();
}

const JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_at(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t i)
{
    return (const JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).at(
        i
    ));
}

JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_at_mut(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t i)
{
    return (JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).at(
        i
    ));
}

const JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_front(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return (const JPH_Skeleton_Joint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).front());
}

JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_front_mut(Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return (JPH_Skeleton_Joint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).front());
}

const JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_back(const Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return (const JPH_Skeleton_Joint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::Skeleton::Joint> *)(_this)).back());
}

JPH_Skeleton_Joint *Jolt_JPH_Array_JPH_Skeleton_Joint_back_mut(Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    return (JPH_Skeleton_Joint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_push_back(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, Jolt_PassBy new_elem_pass_by, JPH_Skeleton_Joint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::Skeleton::Joint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::Skeleton::Joint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::Skeleton::Joint) MRBINDC_CLASSARG_END(new_elem, JPH::Skeleton::Joint))
    );
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_pop_back(Jolt_JPH_Array_JPH_Skeleton_Joint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_insert(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_Skeleton_Joint *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::Skeleton::Joint);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::Skeleton::Joint) MRBINDC_CLASSARG_COPY(new_elem, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::Skeleton::Joint) MRBINDC_CLASSARG_END(new_elem, JPH::Skeleton::Joint)));
}

void Jolt_JPH_Array_JPH_Skeleton_Joint_erase(Jolt_JPH_Array_JPH_Skeleton_Joint *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::Skeleton::Joint> *)(_this)).begin() + ptrdiff_t(position));
}

