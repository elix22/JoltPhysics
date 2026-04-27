// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/UVec4.h"

#include <Jolt/Math/UVec4.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <iostream>
#include <memory>
#include <stdexcept>


JPH_UVec4 *JPH_UVec4_DefaultConstruct(void)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4());
}

JPH_UVec4 *JPH_UVec4_DefaultConstructArray(size_t num_elems)
{
    return (JPH_UVec4 *)(new JPH::UVec4[num_elems]{});
}

const JPH_UVec4 *JPH_UVec4_OffsetPtr(const JPH_UVec4 *ptr, ptrdiff_t i)
{
    return (const JPH_UVec4 *)(((const JPH::UVec4 *)ptr) + i);
}

JPH_UVec4 *JPH_UVec4_OffsetMutablePtr(JPH_UVec4 *ptr, ptrdiff_t i)
{
    return (JPH_UVec4 *)(((JPH::UVec4 *)ptr) + i);
}

JPH_UVec4 *JPH_UVec4_ConstructFromAnother(const JPH_UVec4 *inRHS)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inRHS))
    ));
}

JPH_UVec4 *JPH_UVec4_Construct_4(unsigned int inX, unsigned int inY, unsigned int inZ, unsigned int inW)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4(
        inX,
        inY,
        inZ,
        inW
    ));
}

void JPH_UVec4_Destroy(const JPH_UVec4 *_this)
{
    delete ((const JPH::UVec4 *)_this);
}

void JPH_UVec4_DestroyArray(const JPH_UVec4 *_this)
{
    delete[] ((const JPH::UVec4 *)_this);
}

JPH_UVec4 *JPH_UVec4_AssignFromAnother(JPH_UVec4 *_this, const JPH_UVec4 *inRHS)
{
    return (JPH_UVec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inRHS)))
    ));
}

void *Jolt_new_JPH_UVec4_size_t(size_t inCount)
{
    return JPH::UVec4::operator new(
        inCount
    );
}

void Jolt_delete_JPH_UVec4_void_ptr(void *inPointer)
{
    JPH::UVec4::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_UVec4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::UVec4::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_UVec4_size_t(size_t inCount)
{
    return JPH::UVec4::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_UVec4_void_ptr(void *inPointer)
{
    JPH::UVec4::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_UVec4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::UVec4::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_UVec4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::UVec4::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::UVec4::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_UVec4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::UVec4::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::UVec4::operator delete[](
        inPointer,
        inPlace
    );
}

bool Jolt_equal_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    );
}

bool Jolt_not_equal_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    );
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_1_3_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 1, 3, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_2_3_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 2, 3, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_1_2_3_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<1, 2, 3, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_1_2_2_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<1, 2, 2, 2>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_2_2_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 2, 2, 2>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_2_3_0_1(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<2, 3, 0, 1>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_2_3_2_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<2, 3, 2, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_1_0_3_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<1, 0, 3, 2>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_1_1_3_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<1, 1, 3, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_2_1_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 2, 1, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_2_2_3(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 2, 2, 3>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_1_2_3_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<1, 2, 3, 2>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_2_3_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 2, 3, 2>());
}

JPH_UVec4 *JPH_UVec4_Swizzle_0_1_3_2(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Swizzle<0, 1, 3, 2>());
}

JPH_UVec4 *JPH_UVec4_sZero(void)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sZero());
}

JPH_UVec4 *JPH_UVec4_sReplicate(unsigned int inV)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sReplicate(
        inV
    ));
}

JPH_UVec4 *JPH_UVec4_sLoadInt(const unsigned int *inV)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sLoadInt(
        inV
    ));
}

JPH_UVec4 *JPH_UVec4_sLoadInt4(const unsigned int *inV)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sLoadInt4(
        inV
    ));
}

JPH_UVec4 *JPH_UVec4_sLoadInt4Aligned(const unsigned int *inV)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sLoadInt4Aligned(
        inV
    ));
}

JPH_UVec4 *JPH_UVec4_sMin(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sMin(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sMax(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sMax(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sEquals(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sEquals(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sSelect(const JPH_UVec4 *inNotSet, const JPH_UVec4 *inSet, const JPH_UVec4 *inControl)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sSelect(
        ((inNotSet ? void() : MRBINDC_THROW("Parameter `inNotSet` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inNotSet)),
        ((inSet ? void() : MRBINDC_THROW("Parameter `inSet` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inSet)),
        ((inControl ? void() : MRBINDC_THROW("Parameter `inControl` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inControl))
    ));
}

JPH_UVec4 *JPH_UVec4_sOr(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sOr(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sXor(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sXor(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sAnd(const JPH_UVec4 *inV1, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sAnd(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sNot(const JPH_UVec4 *inV1)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sNot(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV1))
    ));
}

JPH_UVec4 *JPH_UVec4_sSort4True(const JPH_UVec4 *inValue, const JPH_UVec4 *inIndex)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::UVec4::sSort4True(
        ((inValue ? void() : MRBINDC_THROW("Parameter `inValue` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inValue)),
        ((inIndex ? void() : MRBINDC_THROW("Parameter `inIndex` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inIndex))
    ));
}

unsigned int JPH_UVec4_GetX(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).GetX();
}

unsigned int JPH_UVec4_GetY(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).GetY();
}

unsigned int JPH_UVec4_GetZ(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).GetZ();
}

unsigned int JPH_UVec4_GetW(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).GetW();
}

void JPH_UVec4_SetX(JPH_UVec4 *_this, unsigned int inX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).SetX(
        inX
    );
}

void JPH_UVec4_SetY(JPH_UVec4 *_this, unsigned int inY)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).SetY(
        inY
    );
}

void JPH_UVec4_SetZ(JPH_UVec4 *_this, unsigned int inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).SetZ(
        inZ
    );
}

void JPH_UVec4_SetW(JPH_UVec4 *_this, unsigned int inW)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).SetW(
        inW
    );
}

unsigned int JPH_UVec4_index(const JPH_UVec4 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator[](
        inCoordinate
    );
}

unsigned int *JPH_UVec4_index_mut(JPH_UVec4 *_this, unsigned int inCoordinate)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).operator[](
        inCoordinate
    ));
}

JPH_UVec4 *Jolt_mul_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator*(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *Jolt_add_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_add_assign(JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *Jolt_sub_JPH_UVec4(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_sub_assign(JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::UVec4 *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_UVec4_SplatX(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).SplatX());
}

JPH_UVec4 *JPH_UVec4_SplatY(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).SplatY());
}

JPH_UVec4 *JPH_UVec4_SplatZ(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).SplatZ());
}

JPH_UVec4 *JPH_UVec4_SplatW(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).SplatW());
}

JPH_Vec4 *JPH_UVec4_ToFloat(const JPH_UVec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).ToFloat());
}

JPH_Vec4 *JPH_UVec4_ReinterpretAsFloat(const JPH_UVec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).ReinterpretAsFloat());
}

JPH_UVec4 *JPH_UVec4_DotV(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).DotV(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    ));
}

unsigned int JPH_UVec4_Dot(const JPH_UVec4 *_this, const JPH_UVec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Dot(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV2))
    );
}

void JPH_UVec4_StoreInt4(const JPH_UVec4 *_this, unsigned int *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).StoreInt4(
        outV
    );
}

void JPH_UVec4_StoreInt4Aligned(const JPH_UVec4 *_this, unsigned int *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).StoreInt4Aligned(
        outV
    );
}

bool JPH_UVec4_TestAnyTrue(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).TestAnyTrue();
}

bool JPH_UVec4_TestAnyXYZTrue(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).TestAnyXYZTrue();
}

bool JPH_UVec4_TestAllTrue(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).TestAllTrue();
}

bool JPH_UVec4_TestAllXYZTrue(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).TestAllXYZTrue();
}

int JPH_UVec4_CountTrues(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).CountTrues();
}

int JPH_UVec4_GetTrues(const JPH_UVec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).GetTrues();
}

JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_31(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).LogicalShiftLeft<31>());
}

JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_30(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).LogicalShiftLeft<30>());
}

JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_13(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).LogicalShiftLeft<13>());
}

JPH_UVec4 *JPH_UVec4_LogicalShiftLeft_16(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).LogicalShiftLeft<16>());
}

JPH_UVec4 *JPH_UVec4_ArithmeticShiftRight(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).ArithmeticShiftRight<31>());
}

JPH_UVec4 *JPH_UVec4_Expand4Uint16Lo(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Uint16Lo());
}

JPH_UVec4 *JPH_UVec4_Expand4Uint16Hi(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Uint16Hi());
}

JPH_UVec4 *JPH_UVec4_Expand4Byte0(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Byte0());
}

JPH_UVec4 *JPH_UVec4_Expand4Byte4(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Byte4());
}

JPH_UVec4 *JPH_UVec4_Expand4Byte8(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Byte8());
}

JPH_UVec4 *JPH_UVec4_Expand4Byte12(const JPH_UVec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).Expand4Byte12());
}

JPH_UVec4 *JPH_UVec4_ShiftComponents4Minus(const JPH_UVec4 *_this, int inCount)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::UVec4 *)(_this)).ShiftComponents4Minus(
        inCount
    ));
}

Jolt_std_ostream *Jolt_print_JPH_UVec4(Jolt_std_ostream *inStream, const JPH_UVec4 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inV))
    ));
}

