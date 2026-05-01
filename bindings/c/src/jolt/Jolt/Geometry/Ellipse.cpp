// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Geometry/Ellipse.h"

#include <Jolt/Geometry/Ellipse.h>
#include <Jolt/Math/Float2.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


JPH_Ellipse *JPH_Ellipse_ConstructFromAnother(const JPH_Ellipse *_other)
{
    return (JPH_Ellipse *)new JPH::Ellipse(JPH::Ellipse(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Ellipse(*(JPH::Ellipse *)_other))
    ));
}

const JPH_Ellipse *JPH_Ellipse_OffsetPtr(const JPH_Ellipse *ptr, ptrdiff_t i)
{
    return (const JPH_Ellipse *)(((const JPH::Ellipse *)ptr) + i);
}

JPH_Ellipse *JPH_Ellipse_OffsetMutablePtr(JPH_Ellipse *ptr, ptrdiff_t i)
{
    return (JPH_Ellipse *)(((JPH::Ellipse *)ptr) + i);
}

JPH_Ellipse *JPH_Ellipse_Construct(float inA, float inB)
{
    return (JPH_Ellipse *)new JPH::Ellipse(JPH::Ellipse(
        inA,
        inB
    ));
}

void JPH_Ellipse_Destroy(const JPH_Ellipse *_this)
{
    delete ((const JPH::Ellipse *)_this);
}

void JPH_Ellipse_DestroyArray(const JPH_Ellipse *_this)
{
    delete[] ((const JPH::Ellipse *)_this);
}

JPH_Ellipse *JPH_Ellipse_AssignFromAnother(JPH_Ellipse *_this, const JPH_Ellipse *_other)
{
    return (JPH_Ellipse *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ellipse *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Ellipse(*(JPH::Ellipse *)_other))
    ));
}

void *Jolt_new_JPH_Ellipse_size_t(size_t inCount)
{
    return JPH::Ellipse::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Ellipse_void_ptr(void *inPointer)
{
    JPH::Ellipse::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Ellipse_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Ellipse::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Ellipse_size_t(size_t inCount)
{
    return JPH::Ellipse::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Ellipse_void_ptr(void *inPointer)
{
    JPH::Ellipse::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Ellipse_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Ellipse::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Ellipse_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Ellipse::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Ellipse::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Ellipse_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Ellipse::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Ellipse::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_Ellipse_IsInside(const JPH_Ellipse *_this, const JPH_Float2 *inPoint)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ellipse *)(_this)).IsInside(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), *(const JPH::Float2 *)(inPoint))
    );
}

JPH_Float2 *JPH_Ellipse_GetClosestPoint(const JPH_Ellipse *_this, const JPH_Float2 *inPoint)
{
    return (JPH_Float2 *)new JPH::Float2(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ellipse *)(_this)).GetClosestPoint(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), *(const JPH::Float2 *)(inPoint))
    ));
}

JPH_Float2 *JPH_Ellipse_GetNormal(const JPH_Ellipse *_this, const JPH_Float2 *inPoint)
{
    return (JPH_Float2 *)new JPH::Float2(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ellipse *)(_this)).GetNormal(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), *(const JPH::Float2 *)(inPoint))
    ));
}

