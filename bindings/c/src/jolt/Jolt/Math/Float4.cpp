// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Float4.h"

#include <Jolt/Math/Float4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_Float4_Get_x(const JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).x);
}

void JPH_Float4_Set_x(JPH_Float4 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).x = value;
}

float *JPH_Float4_GetMutable_x(JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).x);
}

const float *JPH_Float4_Get_y(const JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).y);
}

void JPH_Float4_Set_y(JPH_Float4 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).y = value;
}

float *JPH_Float4_GetMutable_y(JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).y);
}

const float *JPH_Float4_Get_z(const JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).z);
}

void JPH_Float4_Set_z(JPH_Float4 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).z = value;
}

float *JPH_Float4_GetMutable_z(JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).z);
}

const float *JPH_Float4_Get_w(const JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).w);
}

void JPH_Float4_Set_w(JPH_Float4 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).w = value;
}

float *JPH_Float4_GetMutable_w(JPH_Float4 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).w);
}

JPH_Float4 *JPH_Float4_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Float4;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Float4*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Float4 *JPH_Float4_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Float4 *)(new JPH::Float4[num_elems]);
}

const JPH_Float4 *JPH_Float4_OffsetPtr(const JPH_Float4 *ptr, ptrdiff_t i)
{
    return (const JPH_Float4 *)(((const JPH::Float4 *)ptr) + i);
}

JPH_Float4 *JPH_Float4_OffsetMutablePtr(JPH_Float4 *ptr, ptrdiff_t i)
{
    return (JPH_Float4 *)(((JPH::Float4 *)ptr) + i);
}

JPH_Float4 *JPH_Float4_ConstructFromAnother(const JPH_Float4 *inRHS)
{
    return (JPH_Float4 *)new JPH::Float4(JPH::Float4(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float4(*(JPH::Float4 *)inRHS))
    ));
}

JPH_Float4 *JPH_Float4_Construct(float inX, float inY, float inZ, float inW)
{
    return (JPH_Float4 *)new JPH::Float4(JPH::Float4(
        inX,
        inY,
        inZ,
        inW
    ));
}

void JPH_Float4_Destroy(const JPH_Float4 *_this)
{
    delete ((const JPH::Float4 *)_this);
}

void JPH_Float4_DestroyArray(const JPH_Float4 *_this)
{
    delete[] ((const JPH::Float4 *)_this);
}

JPH_Float4 *JPH_Float4_AssignFromAnother(JPH_Float4 *_this, const JPH_Float4 *inRHS)
{
    return (JPH_Float4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float4 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float4(*(JPH::Float4 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Float4_size_t(size_t inCount)
{
    return JPH::Float4::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Float4_void_ptr(void *inPointer)
{
    JPH::Float4::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Float4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float4::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Float4_size_t(size_t inCount)
{
    return JPH::Float4::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Float4_void_ptr(void *inPointer)
{
    JPH::Float4::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Float4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float4::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Float4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float4::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float4::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Float4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float4::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float4::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_Float4_index(const JPH_Float4 *_this, int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).operator[](
        inCoordinate
    );
}

bool Jolt_equal_JPH_Float4(const JPH_Float4 *_this, const JPH_Float4 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float4 *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_Float4(const JPH_Float4 *_this, const JPH_Float4 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float4 *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float4 *)(inRHS))
    );
}

