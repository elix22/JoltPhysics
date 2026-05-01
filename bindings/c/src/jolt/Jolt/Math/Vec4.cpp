// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Vec4.h"

#include <Jolt/Math/Float4.h>
#include <Jolt/Math/UVec4.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <iostream>
#include <memory>
#include <new>
#include <stdexcept>


JPH_Vec4 *JPH_Vec4_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Vec4;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Vec4*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Vec4 *JPH_Vec4_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Vec4 *)(new JPH::Vec4[num_elems]{});
}

const JPH_Vec4 *JPH_Vec4_OffsetPtr(const JPH_Vec4 *ptr, ptrdiff_t i)
{
    return (const JPH_Vec4 *)(((const JPH::Vec4 *)ptr) + i);
}

JPH_Vec4 *JPH_Vec4_OffsetMutablePtr(JPH_Vec4 *ptr, ptrdiff_t i)
{
    return (JPH_Vec4 *)(((JPH::Vec4 *)ptr) + i);
}

JPH_Vec4 *JPH_Vec4_ConstructFromAnother(const JPH_Vec4 *inRHS)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inRHS))
    ));
}

JPH_Vec4 *JPH_Vec4_Construct_1_JPH_Vec3(const JPH_Vec3 *inRHS)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRHS))
    ));
}

JPH_Vec4 *JPH_Vec4_Construct_2(const JPH_Vec3 *inRHS, float inW)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRHS)),
        inW
    ));
}

JPH_Vec4 *JPH_Vec4_Construct_4(float inX, float inY, float inZ, float inW)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4(
        inX,
        inY,
        inZ,
        inW
    ));
}

void JPH_Vec4_Destroy(const JPH_Vec4 *_this)
{
    delete ((const JPH::Vec4 *)_this);
}

void JPH_Vec4_DestroyArray(const JPH_Vec4 *_this)
{
    delete[] ((const JPH::Vec4 *)_this);
}

JPH_Vec4 *JPH_Vec4_AssignFromAnother(JPH_Vec4 *_this, const JPH_Vec4 *inRHS)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Vec4_size_t(size_t inCount)
{
    return JPH::Vec4::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Vec4_void_ptr(void *inPointer)
{
    JPH::Vec4::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Vec4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Vec4::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Vec4_size_t(size_t inCount)
{
    return JPH::Vec4::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Vec4_void_ptr(void *inPointer)
{
    JPH::Vec4::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Vec4_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Vec4::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Vec4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Vec4::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Vec4::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Vec4_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Vec4::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Vec4::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec4 *JPH_Vec4_sZero(void)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sZero());
}

JPH_Vec4 *JPH_Vec4_sOne(void)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sOne());
}

JPH_Vec4 *JPH_Vec4_sNaN(void)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sNaN());
}

JPH_Vec4 *JPH_Vec4_sReplicate(float inV)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sReplicate(
        inV
    ));
}

JPH_Vec4 *JPH_Vec4_sLoadFloat4(const JPH_Float4 *inV)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sLoadFloat4(
        ((const JPH::Float4 *)inV)
    ));
}

JPH_Vec4 *JPH_Vec4_sLoadFloat4Aligned(const JPH_Float4 *inV)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sLoadFloat4Aligned(
        ((const JPH::Float4 *)inV)
    ));
}

JPH_Vec4 *JPH_Vec4_sMin(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sMin(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sMax(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sMax(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sClamp(const JPH_Vec4 *inV, const JPH_Vec4 *inMin, const JPH_Vec4 *inMax)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sClamp(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV)),
        ((inMin ? void() : MRBINDC_THROW("Parameter `inMin` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inMin)),
        ((inMax ? void() : MRBINDC_THROW("Parameter `inMax` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inMax))
    ));
}

JPH_UVec4 *JPH_Vec4_sEquals(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec4::sEquals(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec4_sLess(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec4::sLess(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec4_sLessOrEqual(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec4::sLessOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec4_sGreater(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec4::sGreater(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec4_sGreaterOrEqual(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec4::sGreaterOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sFusedMultiplyAdd(const JPH_Vec4 *inMul1, const JPH_Vec4 *inMul2, const JPH_Vec4 *inAdd)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sFusedMultiplyAdd(
        ((inMul1 ? void() : MRBINDC_THROW("Parameter `inMul1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inMul1)),
        ((inMul2 ? void() : MRBINDC_THROW("Parameter `inMul2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inMul2)),
        ((inAdd ? void() : MRBINDC_THROW("Parameter `inAdd` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inAdd))
    ));
}

JPH_Vec4 *JPH_Vec4_sSelect(const JPH_Vec4 *inNotSet, const JPH_Vec4 *inSet, const JPH_UVec4 *inControl)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sSelect(
        ((inNotSet ? void() : MRBINDC_THROW("Parameter `inNotSet` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inNotSet)),
        ((inSet ? void() : MRBINDC_THROW("Parameter `inSet` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inSet)),
        ((inControl ? void() : MRBINDC_THROW("Parameter `inControl` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inControl))
    ));
}

JPH_Vec4 *JPH_Vec4_sOr(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sOr(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sXor(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sXor(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sAnd(const JPH_Vec4 *inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sAnd(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

void JPH_Vec4_sSort4(JPH_Vec4 *ioValue, JPH_UVec4 *ioIndex)
{
    JPH::Vec4::sSort4(
        ((ioValue ? void() : MRBINDC_THROW("Parameter `ioValue` can not be null.", void)), *(JPH::Vec4 *)(ioValue)),
        ((ioIndex ? void() : MRBINDC_THROW("Parameter `ioIndex` can not be null.", void)), *(JPH::UVec4 *)(ioIndex))
    );
}

void JPH_Vec4_sSort4Reverse(JPH_Vec4 *ioValue, JPH_UVec4 *ioIndex)
{
    JPH::Vec4::sSort4Reverse(
        ((ioValue ? void() : MRBINDC_THROW("Parameter `ioValue` can not be null.", void)), *(JPH::Vec4 *)(ioValue)),
        ((ioIndex ? void() : MRBINDC_THROW("Parameter `ioIndex` can not be null.", void)), *(JPH::UVec4 *)(ioIndex))
    );
}

float JPH_Vec4_GetX(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetX();
}

float JPH_Vec4_GetY(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetY();
}

float JPH_Vec4_GetZ(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetZ();
}

float JPH_Vec4_GetW(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetW();
}

void JPH_Vec4_SetX(JPH_Vec4 *_this, float inX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).SetX(
        inX
    );
}

void JPH_Vec4_SetY(JPH_Vec4 *_this, float inY)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).SetY(
        inY
    );
}

void JPH_Vec4_SetZ(JPH_Vec4 *_this, float inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).SetZ(
        inZ
    );
}

void JPH_Vec4_SetW(JPH_Vec4 *_this, float inW)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).SetW(
        inW
    );
}

void JPH_Vec4_Set(JPH_Vec4 *_this, float inX, float inY, float inZ, float inW)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).Set(
        inX,
        inY,
        inZ,
        inW
    );
}

float JPH_Vec4_index(const JPH_Vec4 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator[](
        inCoordinate
    );
}

float *JPH_Vec4_index_mut(JPH_Vec4 *_this, unsigned int inCoordinate)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator[](
        inCoordinate
    ));
}

bool Jolt_equal_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    );
}

bool Jolt_not_equal_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    );
}

bool JPH_Vec4_IsClose(const JPH_Vec4 *_this, const JPH_Vec4 *inV2, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).IsClose(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

bool JPH_Vec4_IsNearZero(const JPH_Vec4 *_this, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).IsNearZero(
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

bool JPH_Vec4_IsNormalized(const JPH_Vec4 *_this, const float *inTolerance)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).IsNormalized(
        (inTolerance ? *inTolerance : static_cast<float>(9.99999997E-7F))
    );
}

bool JPH_Vec4_IsNaN(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).IsNaN();
}

JPH_Vec4 *Jolt_mul_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator*(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *Jolt_mul_JPH_Vec4_float(const JPH_Vec4 *_this, float inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator*(
        inV2
    ));
}

JPH_Vec4 *Jolt_div_JPH_Vec4_float(const JPH_Vec4 *_this, float inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator/(
        inV2
    ));
}

JPH_Vec4 *JPH_Vec4_mul_assign_float(JPH_Vec4 *_this, float inV2)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator*=(
        inV2
    ));
}

JPH_Vec4 *JPH_Vec4_mul_assign_JPH_Vec4(JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator*=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_div_assign(JPH_Vec4 *_this, float inV2)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator/=(
        inV2
    ));
}

JPH_Vec4 *Jolt_add_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_add_assign(JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *Jolt_neg_JPH_Vec4(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator-());
}

JPH_Vec4 *Jolt_sub_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_sub_assign(JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec4 *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *Jolt_div_JPH_Vec4(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).operator/(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec4_Swizzle_2_3_0_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<2, 3, 0, 1>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_0_3_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 0, 3, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_0_2_1_3(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<0, 2, 1, 3>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_2_3_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 2, 3, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_2_2_2_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<2, 2, 2, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_3_0_1_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<3, 0, 1, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_0_3_1_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<0, 3, 1, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_0_1_3_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<0, 1, 3, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_3_2_1_0(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<3, 2, 1, 0>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_2_0_1_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<2, 0, 1, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_2_0_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 2, 0, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_0_0_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 0, 0, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_3_2_3_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<3, 2, 3, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_2_3_1_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<2, 3, 1, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_2_2_1_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<2, 2, 1, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_3_0_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 3, 0, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_3_0_3_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<3, 0, 3, 2>());
}

JPH_Vec4 *JPH_Vec4_Swizzle_1_1_2_2(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Swizzle<1, 1, 2, 2>());
}

JPH_Vec4 *JPH_Vec4_SplatX(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatX());
}

JPH_Vec4 *JPH_Vec4_SplatY(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatY());
}

JPH_Vec4 *JPH_Vec4_SplatZ(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatZ());
}

JPH_Vec4 *JPH_Vec4_SplatW(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatW());
}

JPH_Vec3 *JPH_Vec4_SplatX3(const JPH_Vec4 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatX3());
}

JPH_Vec3 *JPH_Vec4_SplatY3(const JPH_Vec4 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatY3());
}

JPH_Vec3 *JPH_Vec4_SplatZ3(const JPH_Vec4 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatZ3());
}

JPH_Vec3 *JPH_Vec4_SplatW3(const JPH_Vec4 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SplatW3());
}

int JPH_Vec4_GetLowestComponentIndex(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetLowestComponentIndex();
}

int JPH_Vec4_GetHighestComponentIndex(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetHighestComponentIndex();
}

JPH_Vec4 *JPH_Vec4_Abs(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Abs());
}

JPH_Vec4 *JPH_Vec4_Reciprocal(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Reciprocal());
}

JPH_Vec4 *JPH_Vec4_DotV(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).DotV(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

float JPH_Vec4_Dot(const JPH_Vec4 *_this, const JPH_Vec4 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Dot(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    );
}

float JPH_Vec4_LengthSq(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).LengthSq();
}

float JPH_Vec4_Length(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Length();
}

JPH_Vec4 *JPH_Vec4_Normalized(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Normalized());
}

void JPH_Vec4_StoreFloat4(const JPH_Vec4 *_this, JPH_Float4 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).StoreFloat4(
        ((JPH::Float4 *)outV)
    );
}

JPH_UVec4 *JPH_Vec4_ToInt(const JPH_Vec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ToInt());
}

JPH_UVec4 *JPH_Vec4_ReinterpretAsInt(const JPH_Vec4 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ReinterpretAsInt());
}

int JPH_Vec4_GetSignBits(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetSignBits();
}

float JPH_Vec4_ReduceMin(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ReduceMin();
}

float JPH_Vec4_ReduceMax(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ReduceMax();
}

JPH_Vec4 *JPH_Vec4_Sqrt(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Sqrt());
}

JPH_Vec4 *JPH_Vec4_GetSign(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).GetSign());
}

JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<-1, -1, -1, 1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_1_sub_1_1_sub_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<1, -1, 1, -1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_1_1_sub_1_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<1, 1, -1, 1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_1_1_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<-1, 1, 1, 1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_1_sub_1_1_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<1, -1, 1, 1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_1_1_sub_1_sub_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<1, 1, -1, -1>());
}

JPH_Vec4 *JPH_Vec4_FlipSign_sub_1_1_1_sub_1(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).FlipSign<-1, 1, 1, -1>());
}

void JPH_Vec4_SinCos(const JPH_Vec4 *_this, JPH_Vec4 *outSin, JPH_Vec4 *outCos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).SinCos(
        ((outSin ? void() : MRBINDC_THROW("Parameter `outSin` can not be null.", void)), *(JPH::Vec4 *)(outSin)),
        ((outCos ? void() : MRBINDC_THROW("Parameter `outCos` can not be null.", void)), *(JPH::Vec4 *)(outCos))
    );
}

JPH_Vec4 *JPH_Vec4_Tan(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).Tan());
}

JPH_Vec4 *JPH_Vec4_ASin(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ASin());
}

JPH_Vec4 *JPH_Vec4_ACos(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ACos());
}

JPH_Vec4 *JPH_Vec4_ATan(const JPH_Vec4 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).ATan());
}

JPH_Vec4 *JPH_Vec4_sATan2(const JPH_Vec4 *inY, const JPH_Vec4 *inX)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sATan2(
        ((inY ? void() : MRBINDC_THROW("Parameter `inY` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inY)),
        ((inX ? void() : MRBINDC_THROW("Parameter `inX` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inX))
    ));
}

unsigned int JPH_Vec4_CompressUnitVector(const JPH_Vec4 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec4 *)(_this)).CompressUnitVector();
}

JPH_Vec4 *JPH_Vec4_sDecompressUnitVector(unsigned int inValue)
{
    return (JPH_Vec4 *)new JPH::Vec4(JPH::Vec4::sDecompressUnitVector(
        inValue
    ));
}

Jolt_std_ostream *Jolt_print_JPH_Vec4(Jolt_std_ostream *inStream, const JPH_Vec4 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    ));
}

