// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Float2.h"

#include <Jolt/Math/Float2.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <iostream>
#include <memory>
#include <stdexcept>


const float *JPH_Float2_Get_x(const JPH_Float2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float2 *)(_this)).x);
}

void JPH_Float2_Set_x(JPH_Float2 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float2 *)(_this)).x = value;
}

float *JPH_Float2_GetMutable_x(JPH_Float2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float2 *)(_this)).x);
}

const float *JPH_Float2_Get_y(const JPH_Float2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float2 *)(_this)).y);
}

void JPH_Float2_Set_y(JPH_Float2 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float2 *)(_this)).y = value;
}

float *JPH_Float2_GetMutable_y(JPH_Float2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float2 *)(_this)).y);
}

JPH_Float2 *JPH_Float2_DefaultConstruct(void)
{
    return (JPH_Float2 *)new JPH::Float2(JPH::Float2());
}

JPH_Float2 *JPH_Float2_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Float2 *)(new JPH::Float2[num_elems]{});
}

const JPH_Float2 *JPH_Float2_OffsetPtr(const JPH_Float2 *ptr, ptrdiff_t i)
{
    return (const JPH_Float2 *)(((const JPH::Float2 *)ptr) + i);
}

JPH_Float2 *JPH_Float2_OffsetMutablePtr(JPH_Float2 *ptr, ptrdiff_t i)
{
    return (JPH_Float2 *)(((JPH::Float2 *)ptr) + i);
}

JPH_Float2 *JPH_Float2_ConstructFromAnother(const JPH_Float2 *inRHS)
{
    return (JPH_Float2 *)new JPH::Float2(JPH::Float2(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float2(*(JPH::Float2 *)inRHS))
    ));
}

JPH_Float2 *JPH_Float2_Construct(float inX, float inY)
{
    return (JPH_Float2 *)new JPH::Float2(JPH::Float2(
        inX,
        inY
    ));
}

void JPH_Float2_Destroy(const JPH_Float2 *_this)
{
    delete ((const JPH::Float2 *)_this);
}

void JPH_Float2_DestroyArray(const JPH_Float2 *_this)
{
    delete[] ((const JPH::Float2 *)_this);
}

JPH_Float2 *JPH_Float2_AssignFromAnother(JPH_Float2 *_this, const JPH_Float2 *inRHS)
{
    return (JPH_Float2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Float2 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Float2(*(JPH::Float2 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Float2_size_t(size_t inCount)
{
    return JPH::Float2::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Float2_void_ptr(void *inPointer)
{
    JPH::Float2::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Float2_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float2::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Float2_size_t(size_t inCount)
{
    return JPH::Float2::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Float2_void_ptr(void *inPointer)
{
    JPH::Float2::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Float2_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Float2::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Float2_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float2::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Float2_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float2::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Float2_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Float2::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Float2_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Float2::operator delete[](
        inPointer,
        inPlace
    );
}

bool Jolt_equal_JPH_Float2(const JPH_Float2 *_this, const JPH_Float2 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float2 *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float2 *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_Float2(const JPH_Float2 *_this, const JPH_Float2 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Float2 *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Float2 *)(inRHS))
    );
}

Jolt_std_ostream *Jolt_print_JPH_Float2(Jolt_std_ostream *inStream, const JPH_Float2 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Float2 *)(inV))
    ));
}

