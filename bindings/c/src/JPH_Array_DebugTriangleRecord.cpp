// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_DebugTriangleRecord.h"

#include <__mrbind_c_details.h>
#include <jolt_init_wrapper.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<DebugTriangleRecord>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_DebugTriangleRecord*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_DebugTriangleRecord *)(new JPH::Array<DebugTriangleRecord>[num_elems]);
}

Jolt_JPH_Array_DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_DebugTriangleRecord *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<DebugTriangleRecord>);
    return (Jolt_JPH_Array_DebugTriangleRecord *)new JPH::Array<DebugTriangleRecord>(JPH::Array<DebugTriangleRecord>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<DebugTriangleRecord>), JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<DebugTriangleRecord>), JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_END(other, JPH::Array<DebugTriangleRecord>))
    ));
}

void Jolt_JPH_Array_DebugTriangleRecord_AssignFromAnother(Jolt_JPH_Array_DebugTriangleRecord *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_DebugTriangleRecord *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<DebugTriangleRecord>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<DebugTriangleRecord>), JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<DebugTriangleRecord>), JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<DebugTriangleRecord>) MRBINDC_CLASSARG_END(other, JPH::Array<DebugTriangleRecord>))
    );
}

void Jolt_JPH_Array_DebugTriangleRecord_Destroy(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    delete ((const JPH::Array<DebugTriangleRecord> *)_this);
}

void Jolt_JPH_Array_DebugTriangleRecord_DestroyArray(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    delete[] ((const JPH::Array<DebugTriangleRecord> *)_this);
}

const Jolt_JPH_Array_DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_OffsetPtr(const Jolt_JPH_Array_DebugTriangleRecord *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_DebugTriangleRecord *)(((const JPH::Array<DebugTriangleRecord> *)ptr) + i);
}

Jolt_JPH_Array_DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_OffsetMutablePtr(Jolt_JPH_Array_DebugTriangleRecord *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_DebugTriangleRecord *)(((JPH::Array<DebugTriangleRecord> *)ptr) + i);
}

size_t Jolt_JPH_Array_DebugTriangleRecord_size(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).size();
}

bool Jolt_JPH_Array_DebugTriangleRecord_empty(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).empty();
}

void Jolt_JPH_Array_DebugTriangleRecord_resize(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_DebugTriangleRecord_resize_with_default_value(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t new_size, const DebugTriangleRecord *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const DebugTriangleRecord *)(value))
    );
}

void Jolt_JPH_Array_DebugTriangleRecord_clear(Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).clear();
}

size_t Jolt_JPH_Array_DebugTriangleRecord_capacity(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).capacity();
}

void Jolt_JPH_Array_DebugTriangleRecord_reserve(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_DebugTriangleRecord_shrink_to_fit(Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).shrink_to_fit();
}

const DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_at(const Jolt_JPH_Array_DebugTriangleRecord *_this, size_t i)
{
    return (const DebugTriangleRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).at(
        i
    ));
}

DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_at_mut(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t i)
{
    return (DebugTriangleRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).at(
        i
    ));
}

const DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_front(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return (const DebugTriangleRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).front());
}

DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_front_mut(Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return (DebugTriangleRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).front());
}

const DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_back(const Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return (const DebugTriangleRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugTriangleRecord> *)(_this)).back());
}

DebugTriangleRecord *Jolt_JPH_Array_DebugTriangleRecord_back_mut(Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    return (DebugTriangleRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).back());
}

void Jolt_JPH_Array_DebugTriangleRecord_push_back(Jolt_JPH_Array_DebugTriangleRecord *_this, const DebugTriangleRecord *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), DebugTriangleRecord(*(DebugTriangleRecord *)new_elem))
    );
}

void Jolt_JPH_Array_DebugTriangleRecord_pop_back(Jolt_JPH_Array_DebugTriangleRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).pop_back();
}

void Jolt_JPH_Array_DebugTriangleRecord_insert(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t position, const DebugTriangleRecord *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), DebugTriangleRecord(*(DebugTriangleRecord *)new_elem)));
}

void Jolt_JPH_Array_DebugTriangleRecord_erase(Jolt_JPH_Array_DebugTriangleRecord *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugTriangleRecord> *)(_this)).begin() + ptrdiff_t(position));
}

