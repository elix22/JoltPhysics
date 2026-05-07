// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_DebugLineRecord.h"

#include <__mrbind_c_details.h>
#include <jolt_init_wrapper.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<DebugLineRecord>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_DebugLineRecord*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_DebugLineRecord *)(new JPH::Array<DebugLineRecord>[num_elems]);
}

Jolt_JPH_Array_DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_DebugLineRecord *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<DebugLineRecord>);
    return (Jolt_JPH_Array_DebugLineRecord *)new JPH::Array<DebugLineRecord>(JPH::Array<DebugLineRecord>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<DebugLineRecord>), JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<DebugLineRecord>), JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_END(other, JPH::Array<DebugLineRecord>))
    ));
}

void Jolt_JPH_Array_DebugLineRecord_AssignFromAnother(Jolt_JPH_Array_DebugLineRecord *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_DebugLineRecord *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<DebugLineRecord>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<DebugLineRecord>), JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<DebugLineRecord>), JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<DebugLineRecord>) MRBINDC_CLASSARG_END(other, JPH::Array<DebugLineRecord>))
    );
}

void Jolt_JPH_Array_DebugLineRecord_Destroy(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    delete ((const JPH::Array<DebugLineRecord> *)_this);
}

void Jolt_JPH_Array_DebugLineRecord_DestroyArray(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    delete[] ((const JPH::Array<DebugLineRecord> *)_this);
}

const Jolt_JPH_Array_DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_OffsetPtr(const Jolt_JPH_Array_DebugLineRecord *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_DebugLineRecord *)(((const JPH::Array<DebugLineRecord> *)ptr) + i);
}

Jolt_JPH_Array_DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_OffsetMutablePtr(Jolt_JPH_Array_DebugLineRecord *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_DebugLineRecord *)(((JPH::Array<DebugLineRecord> *)ptr) + i);
}

size_t Jolt_JPH_Array_DebugLineRecord_size(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).size();
}

bool Jolt_JPH_Array_DebugLineRecord_empty(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).empty();
}

void Jolt_JPH_Array_DebugLineRecord_resize(Jolt_JPH_Array_DebugLineRecord *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_DebugLineRecord_resize_with_default_value(Jolt_JPH_Array_DebugLineRecord *_this, size_t new_size, const DebugLineRecord *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const DebugLineRecord *)(value))
    );
}

void Jolt_JPH_Array_DebugLineRecord_clear(Jolt_JPH_Array_DebugLineRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).clear();
}

size_t Jolt_JPH_Array_DebugLineRecord_capacity(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).capacity();
}

void Jolt_JPH_Array_DebugLineRecord_reserve(Jolt_JPH_Array_DebugLineRecord *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_DebugLineRecord_shrink_to_fit(Jolt_JPH_Array_DebugLineRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).shrink_to_fit();
}

const DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_at(const Jolt_JPH_Array_DebugLineRecord *_this, size_t i)
{
    return (const DebugLineRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).at(
        i
    ));
}

DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_at_mut(Jolt_JPH_Array_DebugLineRecord *_this, size_t i)
{
    return (DebugLineRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).at(
        i
    ));
}

const DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_front(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    return (const DebugLineRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).front());
}

DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_front_mut(Jolt_JPH_Array_DebugLineRecord *_this)
{
    return (DebugLineRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).front());
}

const DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_back(const Jolt_JPH_Array_DebugLineRecord *_this)
{
    return (const DebugLineRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<DebugLineRecord> *)(_this)).back());
}

DebugLineRecord *Jolt_JPH_Array_DebugLineRecord_back_mut(Jolt_JPH_Array_DebugLineRecord *_this)
{
    return (DebugLineRecord *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).back());
}

void Jolt_JPH_Array_DebugLineRecord_push_back(Jolt_JPH_Array_DebugLineRecord *_this, const DebugLineRecord *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), DebugLineRecord(*(DebugLineRecord *)new_elem))
    );
}

void Jolt_JPH_Array_DebugLineRecord_pop_back(Jolt_JPH_Array_DebugLineRecord *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).pop_back();
}

void Jolt_JPH_Array_DebugLineRecord_insert(Jolt_JPH_Array_DebugLineRecord *_this, size_t position, const DebugLineRecord *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), DebugLineRecord(*(DebugLineRecord *)new_elem)));
}

void Jolt_JPH_Array_DebugLineRecord_erase(Jolt_JPH_Array_DebugLineRecord *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<DebugLineRecord> *)(_this)).begin() + ptrdiff_t(position));
}

