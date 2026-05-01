// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Float3.h"

#include <Jolt/Math/Float3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_Float3_Get_x(const JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).x);
}

void JPH_Float3_Set_x(JPH_Float3 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).x = value;
}

float *JPH_Float3_GetMutable_x(JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).x);
}

const float *JPH_Float3_Get_y(const JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).y);
}

void JPH_Float3_Set_y(JPH_Float3 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).y = value;
}

float *JPH_Float3_GetMutable_y(JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).y);
}

const float *JPH_Float3_Get_z(const JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).z);
}

void JPH_Float3_Set_z(JPH_Float3 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).z = value;
}

float *JPH_Float3_GetMutable_z(JPH_Float3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).z);
}

JPH_Float3 *JPH_Float3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Float3;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Float3*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Float3 *JPH_Float3_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Float3 *)(new JPH::Float3[num_elems]{});
}

const JPH_Float3 *JPH_Float3_OffsetPtr(const JPH_Float3 *ptr, ptrdiff_t i)
{
    return (const JPH_Float3 *)(((const JPH::Float3 *)ptr) + i);
}

JPH_Float3 *JPH_Float3_OffsetMutablePtr(JPH_Float3 *ptr, ptrdiff_t i)
{
    return (JPH_Float3 *)(((JPH::Float3 *)ptr) + i);
}

JPH_Float3 *JPH_Float3_ConstructFromAnother(const JPH_Float3 *inRHS)
{
    return (JPH_Float3 *)new JPH::Float3(JPH::Float3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float3(*(JPH::Float3 *)inRHS))
    ));
}

JPH_Float3 *JPH_Float3_Construct(float inX, float inY, float inZ)
{
    return (JPH_Float3 *)new JPH::Float3(JPH::Float3(
        inX,
        inY,
        inZ
    ));
}

void JPH_Float3_Destroy(const JPH_Float3 *_this)
{
    delete ((const JPH::Float3 *)_this);
}

void JPH_Float3_DestroyArray(const JPH_Float3 *_this)
{
    delete[] ((const JPH::Float3 *)_this);
}

JPH_Float3 *JPH_Float3_AssignFromAnother(JPH_Float3 *_this, const JPH_Float3 *inRHS)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float3 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float3(*(JPH::Float3 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Float3_size_t(size_t inCount)
{
    return JPH::Float3::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Float3_void_ptr(void *inPointer)
{
    JPH::Float3::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Float3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float3::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Float3_size_t(size_t inCount)
{
    return JPH::Float3::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Float3_void_ptr(void *inPointer)
{
    JPH::Float3::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Float3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float3::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Float3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float3::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float3::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Float3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float3::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float3::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_Float3_index(const JPH_Float3 *_this, int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).operator[](
        inCoordinate
    );
}

bool Jolt_equal_JPH_Float3(const JPH_Float3 *_this, const JPH_Float3 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float3 *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_Float3(const JPH_Float3 *_this, const JPH_Float3 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float3 *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float3 *)(inRHS))
    );
}

