// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Double3.h"

#include <Jolt/Math/Double3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const double *JPH_Double3_Get_x(const JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).x);
}

void JPH_Double3_Set_x(JPH_Double3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).x = value;
}

double *JPH_Double3_GetMutable_x(JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).x);
}

const double *JPH_Double3_Get_y(const JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).y);
}

void JPH_Double3_Set_y(JPH_Double3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).y = value;
}

double *JPH_Double3_GetMutable_y(JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).y);
}

const double *JPH_Double3_Get_z(const JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).z);
}

void JPH_Double3_Set_z(JPH_Double3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).z = value;
}

double *JPH_Double3_GetMutable_z(JPH_Double3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).z);
}

JPH_Double3 *JPH_Double3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Double3;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Double3*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Double3 *JPH_Double3_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Double3 *)(new JPH::Double3[num_elems]);
}

const JPH_Double3 *JPH_Double3_OffsetPtr(const JPH_Double3 *ptr, ptrdiff_t i)
{
    return (const JPH_Double3 *)(((const JPH::Double3 *)ptr) + i);
}

JPH_Double3 *JPH_Double3_OffsetMutablePtr(JPH_Double3 *ptr, ptrdiff_t i)
{
    return (JPH_Double3 *)(((JPH::Double3 *)ptr) + i);
}

JPH_Double3 *JPH_Double3_ConstructFromAnother(const JPH_Double3 *inRHS)
{
    return (JPH_Double3 *)new JPH::Double3(JPH::Double3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Double3(*(JPH::Double3 *)inRHS))
    ));
}

JPH_Double3 *JPH_Double3_Construct(double inX, double inY, double inZ)
{
    return (JPH_Double3 *)new JPH::Double3(JPH::Double3(
        inX,
        inY,
        inZ
    ));
}

void JPH_Double3_Destroy(const JPH_Double3 *_this)
{
    delete ((const JPH::Double3 *)_this);
}

void JPH_Double3_DestroyArray(const JPH_Double3 *_this)
{
    delete[] ((const JPH::Double3 *)_this);
}

JPH_Double3 *JPH_Double3_AssignFromAnother(JPH_Double3 *_this, const JPH_Double3 *inRHS)
{
    return (JPH_Double3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Double3 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Double3(*(JPH::Double3 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Double3_size_t(size_t inCount)
{
    return JPH::Double3::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Double3_void_ptr(void *inPointer)
{
    JPH::Double3::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Double3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Double3::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Double3_size_t(size_t inCount)
{
    return JPH::Double3::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Double3_void_ptr(void *inPointer)
{
    JPH::Double3::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Double3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Double3::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Double3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Double3::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Double3::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Double3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Double3::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Double3::operator delete[](
        inPointer,
        inPlace
    );
}

double JPH_Double3_index(const JPH_Double3 *_this, int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).operator[](
        inCoordinate
    );
}

bool Jolt_equal_JPH_Double3(const JPH_Double3 *_this, const JPH_Double3 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Double3 *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_Double3(const JPH_Double3 *_this, const JPH_Double3 *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Double3 *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Double3 *)(inRHS))
    );
}

