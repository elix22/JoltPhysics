// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Vec3.h"

#include <Jolt/Math/Float3.h>
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
#include <type_traits>


const float *JPH_Vec3_Get_mF32(const JPH_Vec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).mF32[0]);
}

float *JPH_Vec3_GetMutable_mF32(JPH_Vec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).mF32[0]);
}

size_t JPH_Vec3_GetSize_mF32(void)
{
    return std::extent_v<decltype(JPH::Vec3::mF32)>;
}

JPH_Vec3 *JPH_Vec3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Vec3;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Vec3*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Vec3 *JPH_Vec3_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Vec3 *)(new JPH::Vec3[num_elems]{});
}

const JPH_Vec3 *JPH_Vec3_OffsetPtr(const JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (const JPH_Vec3 *)(((const JPH::Vec3 *)ptr) + i);
}

JPH_Vec3 *JPH_Vec3_OffsetMutablePtr(JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (JPH_Vec3 *)(((JPH::Vec3 *)ptr) + i);
}

JPH_Vec3 *JPH_Vec3_ConstructFromAnother(const JPH_Vec3 *inRHS)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRHS))
    ));
}

JPH_Vec3 *JPH_Vec3_Construct_1_JPH_Vec4(const JPH_Vec4 *inRHS)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inRHS))
    ));
}

JPH_Vec3 *JPH_Vec3_Construct_1_JPH_Float3(const JPH_Float3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Float3 *)(inV))
    ));
}

JPH_Vec3 *JPH_Vec3_Construct_3(float inX, float inY, float inZ)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3(
        inX,
        inY,
        inZ
    ));
}

void JPH_Vec3_Destroy(const JPH_Vec3 *_this)
{
    delete ((const JPH::Vec3 *)_this);
}

void JPH_Vec3_DestroyArray(const JPH_Vec3 *_this)
{
    delete[] ((const JPH::Vec3 *)_this);
}

JPH_Vec3 *JPH_Vec3_AssignFromAnother(JPH_Vec3 *_this, const JPH_Vec3 *inRHS)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRHS)))
    ));
}

void *Jolt_new_JPH_Vec3_size_t(size_t inCount)
{
    return JPH::Vec3::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Vec3_void_ptr(void *inPointer)
{
    JPH::Vec3::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Vec3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Vec3::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Vec3_size_t(size_t inCount)
{
    return JPH::Vec3::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Vec3_void_ptr(void *inPointer)
{
    JPH::Vec3::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Vec3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Vec3::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Vec3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Vec3::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Vec3::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Vec3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Vec3::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Vec3::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_Vec3_sZero(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sZero());
}

JPH_Vec3 *JPH_Vec3_sOne(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sOne());
}

JPH_Vec3 *JPH_Vec3_sNaN(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sNaN());
}

JPH_Vec3 *JPH_Vec3_sAxisX(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sAxisX());
}

JPH_Vec3 *JPH_Vec3_sAxisY(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sAxisY());
}

JPH_Vec3 *JPH_Vec3_sAxisZ(void)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sAxisZ());
}

JPH_Vec3 *JPH_Vec3_sReplicate(float inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sReplicate(
        inV
    ));
}

JPH_Vec3 *JPH_Vec3_sLoadFloat3Unsafe(const JPH_Float3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sLoadFloat3Unsafe(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Float3 *)(inV))
    ));
}

JPH_Vec3 *JPH_Vec3_sMin(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sMin(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sMax(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sMax(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sClamp(const JPH_Vec3 *inV, const JPH_Vec3 *inMin, const JPH_Vec3 *inMax)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sClamp(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV)),
        ((inMin ? void() : MRBINDC_THROW("Parameter `inMin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMin)),
        ((inMax ? void() : MRBINDC_THROW("Parameter `inMax` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMax))
    ));
}

JPH_UVec4 *JPH_Vec3_sEquals(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec3::sEquals(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec3_sLess(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec3::sLess(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec3_sLessOrEqual(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec3::sLessOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec3_sGreater(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec3::sGreater(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_UVec4 *JPH_Vec3_sGreaterOrEqual(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_UVec4 *)new JPH::UVec4(JPH::Vec3::sGreaterOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sFusedMultiplyAdd(const JPH_Vec3 *inMul1, const JPH_Vec3 *inMul2, const JPH_Vec3 *inAdd)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sFusedMultiplyAdd(
        ((inMul1 ? void() : MRBINDC_THROW("Parameter `inMul1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMul1)),
        ((inMul2 ? void() : MRBINDC_THROW("Parameter `inMul2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMul2)),
        ((inAdd ? void() : MRBINDC_THROW("Parameter `inAdd` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAdd))
    ));
}

JPH_Vec3 *JPH_Vec3_sSelect(const JPH_Vec3 *inNotSet, const JPH_Vec3 *inSet, const JPH_UVec4 *inControl)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sSelect(
        ((inNotSet ? void() : MRBINDC_THROW("Parameter `inNotSet` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNotSet)),
        ((inSet ? void() : MRBINDC_THROW("Parameter `inSet` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSet)),
        ((inControl ? void() : MRBINDC_THROW("Parameter `inControl` can not be null.", void)), JPH::UVec4(*(JPH::UVec4 *)inControl))
    ));
}

JPH_Vec3 *JPH_Vec3_sOr(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sOr(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sXor(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sXor(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sAnd(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sAnd(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sUnitSpherical(float inTheta, float inPhi)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sUnitSpherical(
        inTheta,
        inPhi
    ));
}

float JPH_Vec3_GetX(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetX();
}

float JPH_Vec3_GetY(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetY();
}

float JPH_Vec3_GetZ(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetZ();
}

void JPH_Vec3_SetX(JPH_Vec3 *_this, float inX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).SetX(
        inX
    );
}

void JPH_Vec3_SetY(JPH_Vec3 *_this, float inY)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).SetY(
        inY
    );
}

void JPH_Vec3_SetZ(JPH_Vec3 *_this, float inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).SetZ(
        inZ
    );
}

void JPH_Vec3_Set(JPH_Vec3 *_this, float inX, float inY, float inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).Set(
        inX,
        inY,
        inZ
    );
}

float JPH_Vec3_index(const JPH_Vec3 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator[](
        inCoordinate
    );
}

void JPH_Vec3_SetComponent(JPH_Vec3 *_this, unsigned int inCoordinate, float inValue)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).SetComponent(
        inCoordinate,
        inValue
    );
}

bool Jolt_equal_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    );
}

bool Jolt_not_equal_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    );
}

bool JPH_Vec3_IsClose(const JPH_Vec3 *_this, const JPH_Vec3 *inV2, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).IsClose(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

bool JPH_Vec3_IsNearZero(const JPH_Vec3 *_this, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).IsNearZero(
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

bool JPH_Vec3_IsNormalized(const JPH_Vec3 *_this, const float *inTolerance)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).IsNormalized(
        (inTolerance ? *inTolerance : static_cast<float>(9.99999997E-7F))
    );
}

bool JPH_Vec3_IsNaN(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).IsNaN();
}

JPH_Vec3 *Jolt_mul_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator*(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *Jolt_mul_JPH_Vec3_float(const JPH_Vec3 *_this, float inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator*(
        inV2
    ));
}

JPH_Vec3 *Jolt_div_JPH_Vec3_float(const JPH_Vec3 *_this, float inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator/(
        inV2
    ));
}

JPH_Vec3 *JPH_Vec3_mul_assign_float(JPH_Vec3 *_this, float inV2)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator*=(
        inV2
    ));
}

JPH_Vec3 *JPH_Vec3_mul_assign_JPH_Vec3(JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator*=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_div_assign(JPH_Vec3 *_this, float inV2)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator/=(
        inV2
    ));
}

JPH_Vec3 *Jolt_add_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_add_assign(JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *Jolt_neg_JPH_Vec3(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator-());
}

JPH_Vec3 *Jolt_sub_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_sub_assign(JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vec3 *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *Jolt_div_JPH_Vec3(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).operator/(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_Swizzle_1_2_2(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<1, 2, 2>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_2_2_2(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<2, 2, 2>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_2_0_1(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<2, 0, 1>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_0_2_1(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<0, 2, 1>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_1_2_0(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<1, 2, 0>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_0_1_0(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<0, 1, 0>());
}

JPH_Vec3 *JPH_Vec3_Swizzle_2_1_0(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Swizzle<2, 1, 0>());
}

JPH_Vec4 *JPH_Vec3_SplatX(const JPH_Vec3 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).SplatX());
}

JPH_Vec4 *JPH_Vec3_SplatY(const JPH_Vec3 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).SplatY());
}

JPH_Vec4 *JPH_Vec3_SplatZ(const JPH_Vec3 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).SplatZ());
}

int JPH_Vec3_GetLowestComponentIndex(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetLowestComponentIndex();
}

int JPH_Vec3_GetHighestComponentIndex(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetHighestComponentIndex();
}

JPH_Vec3 *JPH_Vec3_Abs(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Abs());
}

JPH_Vec3 *JPH_Vec3_Reciprocal(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Reciprocal());
}

JPH_Vec3 *JPH_Vec3_Cross(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Cross(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec3 *JPH_Vec3_DotV(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).DotV(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Vec4 *JPH_Vec3_DotV4(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).DotV4(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

float JPH_Vec3_Dot(const JPH_Vec3 *_this, const JPH_Vec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Dot(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    );
}

float JPH_Vec3_LengthSq(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).LengthSq();
}

float JPH_Vec3_Length(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Length();
}

JPH_Vec3 *JPH_Vec3_Normalized(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Normalized());
}

JPH_Vec3 *JPH_Vec3_NormalizedOr(const JPH_Vec3 *_this, const JPH_Vec3 *inZeroValue)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).NormalizedOr(
        ((inZeroValue ? void() : MRBINDC_THROW("Parameter `inZeroValue` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inZeroValue))
    ));
}

void JPH_Vec3_StoreFloat3(const JPH_Vec3 *_this, JPH_Float3 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).StoreFloat3(
        ((JPH::Float3 *)outV)
    );
}

JPH_UVec4 *JPH_Vec3_ToInt(const JPH_Vec3 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).ToInt());
}

JPH_UVec4 *JPH_Vec3_ReinterpretAsInt(const JPH_Vec3 *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).ReinterpretAsInt());
}

float JPH_Vec3_ReduceMin(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).ReduceMin();
}

float JPH_Vec3_ReduceMax(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).ReduceMax();
}

JPH_Vec3 *JPH_Vec3_Sqrt(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).Sqrt());
}

JPH_Vec3 *JPH_Vec3_GetNormalizedPerpendicular(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetNormalizedPerpendicular());
}

JPH_Vec3 *JPH_Vec3_GetSign(const JPH_Vec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).GetSign());
}

unsigned int JPH_Vec3_CompressUnitVector(const JPH_Vec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).CompressUnitVector();
}

JPH_Vec3 *JPH_Vec3_sDecompressUnitVector(unsigned int inValue)
{
    return (JPH_Vec3 *)new JPH::Vec3(JPH::Vec3::sDecompressUnitVector(
        inValue
    ));
}

void JPH_Vec3_CheckW(const JPH_Vec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vec3 *)(_this)).CheckW();
}

Jolt_std_ostream *Jolt_print_JPH_Vec3(Jolt_std_ostream *inStream, const JPH_Vec3 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

