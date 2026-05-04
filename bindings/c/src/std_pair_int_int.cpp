// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "std_pair_int_int.h"

#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>
#include <utility>


Jolt_std_pair_int_int *Jolt_std_pair_int_int_DefaultConstruct(void)
{
    using _mrbind_T = std::pair<int, int>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_std_pair_int_int*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_std_pair_int_int *Jolt_std_pair_int_int_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_std_pair_int_int *)(new std::pair<int, int>[num_elems]);
}

Jolt_std_pair_int_int *Jolt_std_pair_int_int_ConstructFromAnother(const Jolt_std_pair_int_int *other)
{
    return (Jolt_std_pair_int_int *)new std::pair<int, int>(std::pair<int, int>(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), std::pair<int, int>(*(std::pair<int, int> *)other))
    ));
}

void Jolt_std_pair_int_int_AssignFromAnother(Jolt_std_pair_int_int *_this, const Jolt_std_pair_int_int *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::pair<int, int> *)(_this)).operator=(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), std::pair<int, int>(*(std::pair<int, int> *)other))
    );
}

void Jolt_std_pair_int_int_Destroy(const Jolt_std_pair_int_int *_this)
{
    delete ((const std::pair<int, int> *)_this);
}

void Jolt_std_pair_int_int_DestroyArray(const Jolt_std_pair_int_int *_this)
{
    delete[] ((const std::pair<int, int> *)_this);
}

const Jolt_std_pair_int_int *Jolt_std_pair_int_int_OffsetPtr(const Jolt_std_pair_int_int *ptr, ptrdiff_t i)
{
    return (const Jolt_std_pair_int_int *)(((const std::pair<int, int> *)ptr) + i);
}

Jolt_std_pair_int_int *Jolt_std_pair_int_int_OffsetMutablePtr(Jolt_std_pair_int_int *ptr, ptrdiff_t i)
{
    return (Jolt_std_pair_int_int *)(((std::pair<int, int> *)ptr) + i);
}

Jolt_std_pair_int_int *Jolt_std_pair_int_int_Construct(int first, int second)
{
    return (Jolt_std_pair_int_int *)new std::pair<int, int>(std::pair<int, int>(
        first,
        second
    ));
}

const int *Jolt_std_pair_int_int_first(const Jolt_std_pair_int_int *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::pair<int, int> *)(_this)).first);
}

int *Jolt_std_pair_int_int_first_mut(Jolt_std_pair_int_int *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::pair<int, int> *)(_this)).first);
}

const int *Jolt_std_pair_int_int_second(const Jolt_std_pair_int_int *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::pair<int, int> *)(_this)).second);
}

int *Jolt_std_pair_int_int_second_mut(Jolt_std_pair_int_int *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::pair<int, int> *)(_this)).second);
}

