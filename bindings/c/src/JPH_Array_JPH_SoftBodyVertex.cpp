// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodyVertex.h"

#include <Jolt/Physics/SoftBody/SoftBodyVertex.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodyVertex>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodyVertex*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodyVertex *)(new JPH::Array<JPH::SoftBodyVertex>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodyVertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodyVertex>);
    return (Jolt_JPH_Array_JPH_SoftBodyVertex *)new JPH::Array<JPH::SoftBodyVertex>(JPH::Array<JPH::SoftBodyVertex>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodyVertex>), JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodyVertex>), JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodyVertex>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodyVertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodyVertex>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodyVertex>), JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodyVertex>), JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodyVertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodyVertex>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_Destroy(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    delete ((const JPH::Array<JPH::SoftBodyVertex> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodyVertex> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodyVertex *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodyVertex *)(((const JPH::Array<JPH::SoftBodyVertex> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodyVertex *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodyVertex *)(((JPH::Array<JPH::SoftBodyVertex> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodyVertex_size(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodyVertex_empty(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_resize(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t new_size, const JPH_SoftBodyVertex *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodyVertex *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_clear(Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodyVertex_capacity(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_reserve(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_at(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t i)
{
    return (const JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).at(
        i
    ));
}

JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_at_mut(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t i)
{
    return (JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_front(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return (const JPH_SoftBodyVertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).front());
}

JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_front_mut(Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return (JPH_SoftBodyVertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).front());
}

const JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_back(const Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return (const JPH_SoftBodyVertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodyVertex> *)(_this)).back());
}

JPH_SoftBodyVertex *Jolt_JPH_Array_JPH_SoftBodyVertex_back_mut(Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    return (JPH_SoftBodyVertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_push_back(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, const JPH_SoftBodyVertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodyVertex(*(JPH::SoftBodyVertex *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_pop_back(Jolt_JPH_Array_JPH_SoftBodyVertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_insert(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t position, const JPH_SoftBodyVertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodyVertex(*(JPH::SoftBodyVertex *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodyVertex_erase(Jolt_JPH_Array_JPH_SoftBodyVertex *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodyVertex> *)(_this)).begin() + ptrdiff_t(position));
}

