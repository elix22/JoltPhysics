// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_SoftBodySharedSettings_DihedralBend.h"

#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *)(new JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>[num_elems]);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>);
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *)new JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>), JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>), JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>))
    ));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>), JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>), JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::SoftBodySharedSettings::DihedralBend>))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_Destroy(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    delete ((const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)_this);
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_DestroyArray(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    delete[] ((const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_OffsetPtr(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *)(((const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)ptr) + i);
}

Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_OffsetMutablePtr(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *)(((JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_size(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_empty(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_resize(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_resize_with_default_value(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t new_size, const JPH_SoftBodySharedSettings_DihedralBend *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::SoftBodySharedSettings::DihedralBend *)(value))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_clear(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_capacity(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_reserve(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_shrink_to_fit(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).shrink_to_fit();
}

const JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_at(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t i)
{
    return (const JPH_SoftBodySharedSettings_DihedralBend *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).at(
        i
    ));
}

JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_at_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t i)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).at(
        i
    ));
}

const JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_front(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return (const JPH_SoftBodySharedSettings_DihedralBend *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).front());
}

JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_front_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).front());
}

const JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_back(const Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return (const JPH_SoftBodySharedSettings_DihedralBend *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).back());
}

JPH_SoftBodySharedSettings_DihedralBend *Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_back_mut(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_push_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, const JPH_SoftBodySharedSettings_DihedralBend *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::DihedralBend(*(JPH::SoftBodySharedSettings::DihedralBend *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_pop_back(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_insert(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t position, const JPH_SoftBodySharedSettings_DihedralBend *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::SoftBodySharedSettings::DihedralBend(*(JPH::SoftBodySharedSettings::DihedralBend *)new_elem)));
}

void Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend_erase(Jolt_JPH_Array_JPH_SoftBodySharedSettings_DihedralBend *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::SoftBodySharedSettings::DihedralBend> *)(_this)).begin() + ptrdiff_t(position));
}

