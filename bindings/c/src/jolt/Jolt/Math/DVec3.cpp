// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/DVec3.h"

#include <Jolt/Math/DVec3.h>
#include <Jolt/Math/Double3.h>
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


const double *JPH_DVec3_Get_cTrue(void)
{
    return std::addressof(JPH::DVec3::cTrue);
}

const double *JPH_DVec3_Get_cFalse(void)
{
    return std::addressof(JPH::DVec3::cFalse);
}

const double *JPH_DVec3_Get_mF64(const JPH_DVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).mF64[0]);
}

double *JPH_DVec3_GetMutable_mF64(JPH_DVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).mF64[0]);
}

size_t JPH_DVec3_GetSize_mF64(void)
{
    return std::extent_v<decltype(JPH::DVec3::mF64)>;
}

JPH_DVec3 *JPH_DVec3_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DVec3;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DVec3*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DVec3 *JPH_DVec3_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DVec3 *)(new JPH::DVec3[num_elems]{});
}

const JPH_DVec3 *JPH_DVec3_OffsetPtr(const JPH_DVec3 *ptr, ptrdiff_t i)
{
    return (const JPH_DVec3 *)(((const JPH::DVec3 *)ptr) + i);
}

JPH_DVec3 *JPH_DVec3_OffsetMutablePtr(JPH_DVec3 *ptr, ptrdiff_t i)
{
    return (JPH_DVec3 *)(((JPH::DVec3 *)ptr) + i);
}

JPH_DVec3 *JPH_DVec3_ConstructFromAnother(const JPH_DVec3 *inRHS)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::DVec3(*(JPH::DVec3 *)inRHS))
    ));
}

JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Vec3(const JPH_Vec3 *inRHS)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRHS))
    ));
}

JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Vec4(const JPH_Vec4 *inRHS)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inRHS))
    ));
}

JPH_DVec3 *JPH_DVec3_Construct_3(double inX, double inY, double inZ)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3(
        inX,
        inY,
        inZ
    ));
}

JPH_DVec3 *JPH_DVec3_Construct_1_JPH_Double3(const JPH_Double3 *inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Double3 *)(inV))
    ));
}

void JPH_DVec3_Destroy(const JPH_DVec3 *_this)
{
    delete ((const JPH::DVec3 *)_this);
}

void JPH_DVec3_DestroyArray(const JPH_DVec3 *_this)
{
    delete[] ((const JPH::DVec3 *)_this);
}

JPH_Vec3 *JPH_DVec3_ConvertTo_JPH_Vec3(const JPH_DVec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3((JPH::Vec3)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this))));
}

JPH_DVec3 *JPH_DVec3_AssignFromAnother(JPH_DVec3 *_this, const JPH_DVec3 *inRHS)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::DVec3(*(JPH::DVec3 *)inRHS)))
    ));
}

void *Jolt_new_JPH_DVec3_size_t(size_t inCount)
{
    return JPH::DVec3::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DVec3_void_ptr(void *inPointer)
{
    JPH::DVec3::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DVec3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DVec3::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DVec3_size_t(size_t inCount)
{
    return JPH::DVec3::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DVec3_void_ptr(void *inPointer)
{
    JPH::DVec3::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DVec3_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DVec3::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DVec3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DVec3::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DVec3::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DVec3_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DVec3::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DVec3::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_DVec3 *JPH_DVec3_sZero(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sZero());
}

JPH_DVec3 *JPH_DVec3_sOne(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sOne());
}

JPH_DVec3 *JPH_DVec3_sAxisX(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sAxisX());
}

JPH_DVec3 *JPH_DVec3_sAxisY(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sAxisY());
}

JPH_DVec3 *JPH_DVec3_sAxisZ(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sAxisZ());
}

JPH_DVec3 *JPH_DVec3_sReplicate(double inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sReplicate(
        inV
    ));
}

JPH_DVec3 *JPH_DVec3_sNaN(void)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sNaN());
}

JPH_DVec3 *JPH_DVec3_sLoadDouble3Unsafe(const JPH_Double3 *inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sLoadDouble3Unsafe(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Double3 *)(inV))
    ));
}

void JPH_DVec3_StoreDouble3(const JPH_DVec3 *_this, JPH_Double3 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).StoreDouble3(
        ((JPH::Double3 *)outV)
    );
}

JPH_DVec3 *JPH_DVec3_PrepareRoundToZero(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).PrepareRoundToZero());
}

JPH_DVec3 *JPH_DVec3_PrepareRoundToInf(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).PrepareRoundToInf());
}

JPH_Vec3 *JPH_DVec3_ToVec3RoundDown(const JPH_DVec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).ToVec3RoundDown());
}

JPH_Vec3 *JPH_DVec3_ToVec3RoundUp(const JPH_DVec3 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).ToVec3RoundUp());
}

JPH_DVec3 *JPH_DVec3_sMin(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sMin(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sMax(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sMax(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sClamp(const JPH_DVec3 *inV, const JPH_DVec3 *inMin, const JPH_DVec3 *inMax)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sClamp(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV)),
        ((inMin ? void() : MRBINDC_THROW("Parameter `inMin` can not be null.", void)), *(const JPH::DVec3 *)(inMin)),
        ((inMax ? void() : MRBINDC_THROW("Parameter `inMax` can not be null.", void)), *(const JPH::DVec3 *)(inMax))
    ));
}

JPH_DVec3 *JPH_DVec3_sEquals(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sEquals(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sLess(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sLess(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sLessOrEqual(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sLessOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sGreater(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sGreater(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sGreaterOrEqual(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sGreaterOrEqual(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sFusedMultiplyAdd(const JPH_DVec3 *inMul1, const JPH_DVec3 *inMul2, const JPH_DVec3 *inAdd)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sFusedMultiplyAdd(
        ((inMul1 ? void() : MRBINDC_THROW("Parameter `inMul1` can not be null.", void)), *(const JPH::DVec3 *)(inMul1)),
        ((inMul2 ? void() : MRBINDC_THROW("Parameter `inMul2` can not be null.", void)), *(const JPH::DVec3 *)(inMul2)),
        ((inAdd ? void() : MRBINDC_THROW("Parameter `inAdd` can not be null.", void)), *(const JPH::DVec3 *)(inAdd))
    ));
}

JPH_DVec3 *JPH_DVec3_sSelect(const JPH_DVec3 *inNotSet, const JPH_DVec3 *inSet, const JPH_DVec3 *inControl)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sSelect(
        ((inNotSet ? void() : MRBINDC_THROW("Parameter `inNotSet` can not be null.", void)), *(const JPH::DVec3 *)(inNotSet)),
        ((inSet ? void() : MRBINDC_THROW("Parameter `inSet` can not be null.", void)), *(const JPH::DVec3 *)(inSet)),
        ((inControl ? void() : MRBINDC_THROW("Parameter `inControl` can not be null.", void)), *(const JPH::DVec3 *)(inControl))
    ));
}

JPH_DVec3 *JPH_DVec3_sOr(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sOr(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sXor(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sXor(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sAnd(const JPH_DVec3 *inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(JPH::DVec3::sAnd(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), *(const JPH::DVec3 *)(inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

int JPH_DVec3_GetTrues(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).GetTrues();
}

bool JPH_DVec3_TestAnyTrue(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).TestAnyTrue();
}

bool JPH_DVec3_TestAllTrue(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).TestAllTrue();
}

double JPH_DVec3_GetX(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).GetX();
}

double JPH_DVec3_GetY(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).GetY();
}

double JPH_DVec3_GetZ(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).GetZ();
}

void JPH_DVec3_SetX(JPH_DVec3 *_this, double inX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).SetX(
        inX
    );
}

void JPH_DVec3_SetY(JPH_DVec3 *_this, double inY)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).SetY(
        inY
    );
}

void JPH_DVec3_SetZ(JPH_DVec3 *_this, double inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).SetZ(
        inZ
    );
}

void JPH_DVec3_Set(JPH_DVec3 *_this, double inX, double inY, double inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).Set(
        inX,
        inY,
        inZ
    );
}

double JPH_DVec3_index(const JPH_DVec3 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator[](
        inCoordinate
    );
}

void JPH_DVec3_SetComponent(JPH_DVec3 *_this, unsigned int inCoordinate, double inValue)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).SetComponent(
        inCoordinate,
        inValue
    );
}

bool Jolt_equal_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    );
}

bool Jolt_not_equal_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    );
}

bool JPH_DVec3_IsClose(const JPH_DVec3 *_this, const JPH_DVec3 *inV2, const double *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).IsClose(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<double>(9.9999999999999992E-25))
    );
}

bool JPH_DVec3_IsNearZero(const JPH_DVec3 *_this, const double *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).IsNearZero(
        (inMaxDistSq ? *inMaxDistSq : static_cast<double>(9.9999999999999992E-25))
    );
}

bool JPH_DVec3_IsNormalized(const JPH_DVec3 *_this, const double *inTolerance)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).IsNormalized(
        (inTolerance ? *inTolerance : static_cast<double>(9.9999999999999998E-13))
    );
}

bool JPH_DVec3_IsNaN(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).IsNaN();
}

JPH_DVec3 *Jolt_mul_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator*(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *Jolt_mul_JPH_DVec3_double(const JPH_DVec3 *_this, double inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator*(
        inV2
    ));
}

JPH_DVec3 *Jolt_div_JPH_DVec3_double(const JPH_DVec3 *_this, double inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator/(
        inV2
    ));
}

JPH_DVec3 *JPH_DVec3_mul_assign_double(JPH_DVec3 *_this, double inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator*=(
        inV2
    ));
}

JPH_DVec3 *JPH_DVec3_mul_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator*=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_div_assign(JPH_DVec3 *_this, double inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator/=(
        inV2
    ));
}

JPH_DVec3 *Jolt_add_JPH_DVec3_JPH_Vec3(const JPH_DVec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_DVec3 *Jolt_add_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_add_assign_JPH_Vec3(JPH_DVec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_add_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *Jolt_neg_JPH_DVec3(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator-());
}

JPH_DVec3 *Jolt_sub_JPH_DVec3_JPH_Vec3(const JPH_DVec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_DVec3 *Jolt_sub_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sub_assign_JPH_Vec3(JPH_DVec3 *_this, const JPH_Vec3 *inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_sub_assign_JPH_DVec3(JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DVec3 *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *Jolt_div_JPH_DVec3(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).operator/(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

JPH_DVec3 *JPH_DVec3_Abs(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Abs());
}

JPH_DVec3 *JPH_DVec3_Reciprocal(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Reciprocal());
}

JPH_DVec3 *JPH_DVec3_Cross(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Cross(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

double JPH_DVec3_Dot(const JPH_DVec3 *_this, const JPH_DVec3 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Dot(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    );
}

double JPH_DVec3_LengthSq(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).LengthSq();
}

double JPH_DVec3_Length(const JPH_DVec3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Length();
}

JPH_DVec3 *JPH_DVec3_Normalized(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Normalized());
}

JPH_DVec3 *JPH_DVec3_Sqrt(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).Sqrt());
}

JPH_DVec3 *JPH_DVec3_GetSign(const JPH_DVec3 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).GetSign());
}

void JPH_DVec3_CheckW(const JPH_DVec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DVec3 *)(_this)).CheckW();
}

Jolt_std_ostream *Jolt_print_JPH_DVec3(Jolt_std_ostream *inStream, const JPH_DVec3 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV))
    ));
}

