// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_unsigned_char.h"

#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<unsigned char>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_unsigned_char*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_unsigned_char *)(new JPH::Array<unsigned char>[num_elems]);
}

Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_unsigned_char *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<unsigned char>);
    return (Jolt_JPH_Array_unsigned_char *)new JPH::Array<unsigned char>(JPH::Array<unsigned char>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<unsigned char>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<unsigned char>), JPH::Array<unsigned char>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<unsigned char>), JPH::Array<unsigned char>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<unsigned char>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<unsigned char>) MRBINDC_CLASSARG_END(other, JPH::Array<unsigned char>))
    ));
}

void Jolt_JPH_Array_unsigned_char_AssignFromAnother(Jolt_JPH_Array_unsigned_char *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_unsigned_char *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<unsigned char>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<unsigned char>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<unsigned char>), JPH::Array<unsigned char>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<unsigned char>), JPH::Array<unsigned char>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<unsigned char>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<unsigned char>) MRBINDC_CLASSARG_END(other, JPH::Array<unsigned char>))
    );
}

void Jolt_JPH_Array_unsigned_char_Destroy(const Jolt_JPH_Array_unsigned_char *_this)
{
    delete ((const JPH::Array<unsigned char> *)_this);
}

void Jolt_JPH_Array_unsigned_char_DestroyArray(const Jolt_JPH_Array_unsigned_char *_this)
{
    delete[] ((const JPH::Array<unsigned char> *)_this);
}

const Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_OffsetPtr(const Jolt_JPH_Array_unsigned_char *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_unsigned_char *)(((const JPH::Array<unsigned char> *)ptr) + i);
}

Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_OffsetMutablePtr(Jolt_JPH_Array_unsigned_char *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_unsigned_char *)(((JPH::Array<unsigned char> *)ptr) + i);
}

Jolt_JPH_Array_unsigned_char *Jolt_JPH_Array_unsigned_char_ConstructFromRange(const unsigned char *ptr, size_t size)
{
    return (Jolt_JPH_Array_unsigned_char *)new JPH::Array<unsigned char>(JPH::Array<unsigned char>(ptr, ptr + size));
}

void Jolt_JPH_Array_unsigned_char_AssignFromRange(Jolt_JPH_Array_unsigned_char *_this, const unsigned char *ptr, size_t size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)) = JPH::Array<unsigned char>(ptr, ptr + size);
}

size_t Jolt_JPH_Array_unsigned_char_size(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).size();
}

bool Jolt_JPH_Array_unsigned_char_empty(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).empty();
}

void Jolt_JPH_Array_unsigned_char_resize(Jolt_JPH_Array_unsigned_char *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_unsigned_char_resize_with_default_value(Jolt_JPH_Array_unsigned_char *_this, size_t new_size, unsigned char value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).resize(
        new_size,
        value
    );
}

void Jolt_JPH_Array_unsigned_char_clear(Jolt_JPH_Array_unsigned_char *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).clear();
}

size_t Jolt_JPH_Array_unsigned_char_capacity(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).capacity();
}

void Jolt_JPH_Array_unsigned_char_reserve(Jolt_JPH_Array_unsigned_char *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_unsigned_char_shrink_to_fit(Jolt_JPH_Array_unsigned_char *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).shrink_to_fit();
}

const unsigned char *Jolt_JPH_Array_unsigned_char_at(const Jolt_JPH_Array_unsigned_char *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).at(
        i
    ));
}

unsigned char *Jolt_JPH_Array_unsigned_char_at_mut(Jolt_JPH_Array_unsigned_char *_this, size_t i)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).at(
        i
    ));
}

const unsigned char *Jolt_JPH_Array_unsigned_char_front(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).front();
}

unsigned char *Jolt_JPH_Array_unsigned_char_front_mut(Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).front();
}

const unsigned char *Jolt_JPH_Array_unsigned_char_back(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).back();
}

unsigned char *Jolt_JPH_Array_unsigned_char_back_mut(Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).back();
}

const unsigned char *Jolt_JPH_Array_unsigned_char_data(const Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<unsigned char> *)(_this)).data();
}

unsigned char *Jolt_JPH_Array_unsigned_char_data_mut(Jolt_JPH_Array_unsigned_char *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).data();
}

void Jolt_JPH_Array_unsigned_char_push_back(Jolt_JPH_Array_unsigned_char *_this, unsigned char new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).push_back(
        new_elem
    );
}

void Jolt_JPH_Array_unsigned_char_pop_back(Jolt_JPH_Array_unsigned_char *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).pop_back();
}

void Jolt_JPH_Array_unsigned_char_insert(Jolt_JPH_Array_unsigned_char *_this, size_t position, unsigned char new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).begin() + ptrdiff_t(position), new_elem);
}

void Jolt_JPH_Array_unsigned_char_erase(Jolt_JPH_Array_unsigned_char *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<unsigned char> *)(_this)).begin() + ptrdiff_t(position));
}

