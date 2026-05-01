// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Mat44.h"

#include <Jolt/Math/Float4.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <iostream>
#include <memory>
#include <new>
#include <stdexcept>


JPH_Mat44 *JPH_Mat44_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Mat44;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Mat44*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Mat44 *JPH_Mat44_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Mat44 *)(new JPH::Mat44[num_elems]{});
}

const JPH_Mat44 *JPH_Mat44_OffsetPtr(const JPH_Mat44 *ptr, ptrdiff_t i)
{
    return (const JPH_Mat44 *)(((const JPH::Mat44 *)ptr) + i);
}

JPH_Mat44 *JPH_Mat44_OffsetMutablePtr(JPH_Mat44 *ptr, ptrdiff_t i)
{
    return (JPH_Mat44 *)(((JPH::Mat44 *)ptr) + i);
}

JPH_Mat44 *JPH_Mat44_ConstructFromAnother(const JPH_Mat44 *inM2)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), JPH::Mat44(*(JPH::Mat44 *)inM2))
    ));
}

JPH_Mat44 *JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_Vec4 *inC4)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44(
        ((inC1 ? void() : MRBINDC_THROW("Parameter `inC1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC1)),
        ((inC2 ? void() : MRBINDC_THROW("Parameter `inC2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC2)),
        ((inC3 ? void() : MRBINDC_THROW("Parameter `inC3` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC3)),
        ((inC4 ? void() : MRBINDC_THROW("Parameter `inC4` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC4))
    ));
}

JPH_Mat44 *JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_Vec3 *inC4)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44(
        ((inC1 ? void() : MRBINDC_THROW("Parameter `inC1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC1)),
        ((inC2 ? void() : MRBINDC_THROW("Parameter `inC2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC2)),
        ((inC3 ? void() : MRBINDC_THROW("Parameter `inC3` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC3)),
        ((inC4 ? void() : MRBINDC_THROW("Parameter `inC4` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inC4))
    ));
}

void JPH_Mat44_Destroy(const JPH_Mat44 *_this)
{
    delete ((const JPH::Mat44 *)_this);
}

void JPH_Mat44_DestroyArray(const JPH_Mat44 *_this)
{
    delete[] ((const JPH::Mat44 *)_this);
}

JPH_Mat44 *JPH_Mat44_AssignFromAnother(JPH_Mat44 *_this, const JPH_Mat44 *inM2)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).operator=(
        mrbindc_details::unmove(((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), JPH::Mat44(*(JPH::Mat44 *)inM2)))
    ));
}

void *Jolt_new_JPH_Mat44_size_t(size_t inCount)
{
    return JPH::Mat44::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Mat44_void_ptr(void *inPointer)
{
    JPH::Mat44::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Mat44_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Mat44::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Mat44_size_t(size_t inCount)
{
    return JPH::Mat44::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Mat44_void_ptr(void *inPointer)
{
    JPH::Mat44::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Mat44_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Mat44::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Mat44_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Mat44::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Mat44::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Mat44_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Mat44::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Mat44::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Mat44 *JPH_Mat44_sZero(void)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sZero());
}

JPH_Mat44 *JPH_Mat44_sIdentity(void)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sIdentity());
}

JPH_Mat44 *JPH_Mat44_sNaN(void)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sNaN());
}

JPH_Mat44 *JPH_Mat44_sLoadFloat4x4(const JPH_Float4 *inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sLoadFloat4x4(
        ((const JPH::Float4 *)inV)
    ));
}

JPH_Mat44 *JPH_Mat44_sLoadFloat4x4Aligned(const JPH_Float4 *inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sLoadFloat4x4Aligned(
        ((const JPH::Float4 *)inV)
    ));
}

JPH_Mat44 *JPH_Mat44_sRotationX(float inX)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotationX(
        inX
    ));
}

JPH_Mat44 *JPH_Mat44_sRotationY(float inY)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotationY(
        inY
    ));
}

JPH_Mat44 *JPH_Mat44_sRotationZ(float inZ)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotationZ(
        inZ
    ));
}

JPH_Mat44 *JPH_Mat44_sRotation_2(const JPH_Vec3 *inAxis, float inAngle)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotation(
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        inAngle
    ));
}

JPH_Mat44 *JPH_Mat44_sRotation_1(const JPH_Quat *inQuat)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotation(
        ((inQuat ? void() : MRBINDC_THROW("Parameter `inQuat` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inQuat))
    ));
}

JPH_Mat44 *JPH_Mat44_sTranslation(const JPH_Vec3 *inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Mat44 *JPH_Mat44_sRotationTranslation(const JPH_Quat *inR, const JPH_Vec3 *inT)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sRotationTranslation(
        ((inR ? void() : MRBINDC_THROW("Parameter `inR` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inR)),
        ((inT ? void() : MRBINDC_THROW("Parameter `inT` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inT))
    ));
}

JPH_Mat44 *JPH_Mat44_sInverseRotationTranslation(const JPH_Quat *inR, const JPH_Vec3 *inT)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sInverseRotationTranslation(
        ((inR ? void() : MRBINDC_THROW("Parameter `inR` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inR)),
        ((inT ? void() : MRBINDC_THROW("Parameter `inT` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inT))
    ));
}

JPH_Mat44 *JPH_Mat44_sScale_float(float inScale)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sScale(
        inScale
    ));
}

JPH_Mat44 *JPH_Mat44_sScale_JPH_Vec3(const JPH_Vec3 *inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sScale(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Mat44 *JPH_Mat44_sOuterProduct(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sOuterProduct(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

JPH_Mat44 *JPH_Mat44_sCrossProduct(const JPH_Vec3 *inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sCrossProduct(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Mat44 *JPH_Mat44_sQuatLeftMultiply(const JPH_Quat *inQ)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sQuatLeftMultiply(
        ((inQ ? void() : MRBINDC_THROW("Parameter `inQ` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inQ))
    ));
}

JPH_Mat44 *JPH_Mat44_sQuatRightMultiply(const JPH_Quat *inQ)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sQuatRightMultiply(
        ((inQ ? void() : MRBINDC_THROW("Parameter `inQ` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inQ))
    ));
}

JPH_Mat44 *JPH_Mat44_sLookAt(const JPH_Vec3 *inPos, const JPH_Vec3 *inTarget, const JPH_Vec3 *inUp)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sLookAt(
        ((inPos ? void() : MRBINDC_THROW("Parameter `inPos` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPos)),
        ((inTarget ? void() : MRBINDC_THROW("Parameter `inTarget` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTarget)),
        ((inUp ? void() : MRBINDC_THROW("Parameter `inUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUp))
    ));
}

JPH_Mat44 *JPH_Mat44_sPerspective(float inFovY, float inAspect, float inNear, float inFar)
{
    return (JPH_Mat44 *)new JPH::Mat44(JPH::Mat44::sPerspective(
        inFovY,
        inAspect,
        inNear,
        inFar
    ));
}

float JPH_Mat44_call(const JPH_Mat44 *_this, unsigned int inRow, unsigned int inColumn)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator()(
        inRow,
        inColumn
    );
}

float *JPH_Mat44_call_mut(JPH_Mat44 *_this, unsigned int inRow, unsigned int inColumn)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).operator()(
        inRow,
        inColumn
    ));
}

bool Jolt_equal_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator==(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::Mat44 *)(inM2))
    );
}

bool Jolt_not_equal_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator!=(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::Mat44 *)(inM2))
    );
}

bool JPH_Mat44_IsClose(const JPH_Mat44 *_this, const JPH_Mat44 *inM2, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).IsClose(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::Mat44 *)(inM2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

JPH_Mat44 *Jolt_mul_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator*(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Vec3 *Jolt_mul_JPH_Mat44_JPH_Vec3(const JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator*(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Vec4 *Jolt_mul_JPH_Mat44_JPH_Vec4(const JPH_Mat44 *_this, const JPH_Vec4 *inV)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator*(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    ));
}

JPH_Vec3 *JPH_Mat44_Multiply3x3_JPH_Vec3(const JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Multiply3x3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Vec3 *JPH_Mat44_Multiply3x3Transposed(const JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Multiply3x3Transposed(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Mat44 *JPH_Mat44_Multiply3x3_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Multiply3x3(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Mat44 *JPH_Mat44_Multiply3x3LeftTransposed(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Multiply3x3LeftTransposed(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Mat44 *JPH_Mat44_Multiply3x3RightTransposed(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Multiply3x3RightTransposed(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Mat44 *Jolt_mul_JPH_Mat44_float(const JPH_Mat44 *_this, float inV)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator*(
        inV
    ));
}

JPH_Mat44 *JPH_Mat44_mul_assign(JPH_Mat44 *_this, float inV)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).operator*=(
        inV
    ));
}

JPH_Mat44 *Jolt_add_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator+(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Mat44 *Jolt_neg_JPH_Mat44(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator-());
}

JPH_Mat44 *Jolt_sub_JPH_Mat44(const JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).operator-(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Mat44 *JPH_Mat44_add_assign(JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).operator+=(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_Vec3 *JPH_Mat44_GetAxisX(const JPH_Mat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetAxisX());
}

void JPH_Mat44_SetAxisX(JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetAxisX(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_Mat44_GetAxisY(const JPH_Mat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetAxisY());
}

void JPH_Mat44_SetAxisY(JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetAxisY(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_Mat44_GetAxisZ(const JPH_Mat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetAxisZ());
}

void JPH_Mat44_SetAxisZ(JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetAxisZ(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_Mat44_GetTranslation(const JPH_Mat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetTranslation());
}

void JPH_Mat44_SetTranslation(JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_Mat44_GetDiagonal3(const JPH_Mat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetDiagonal3());
}

void JPH_Mat44_SetDiagonal3(JPH_Mat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetDiagonal3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec4 *JPH_Mat44_GetDiagonal4(const JPH_Mat44 *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetDiagonal4());
}

void JPH_Mat44_SetDiagonal4(JPH_Mat44 *_this, const JPH_Vec4 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetDiagonal4(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    );
}

JPH_Vec3 *JPH_Mat44_GetColumn3(const JPH_Mat44 *_this, unsigned int inCol)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetColumn3(
        inCol
    ));
}

void JPH_Mat44_SetColumn3(JPH_Mat44 *_this, unsigned int inCol, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetColumn3(
        inCol,
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec4 *JPH_Mat44_GetColumn4(const JPH_Mat44 *_this, unsigned int inCol)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetColumn4(
        inCol
    ));
}

void JPH_Mat44_SetColumn4(JPH_Mat44 *_this, unsigned int inCol, const JPH_Vec4 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetColumn4(
        inCol,
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    );
}

void JPH_Mat44_StoreFloat4x4(const JPH_Mat44 *_this, JPH_Float4 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).StoreFloat4x4(
        ((JPH::Float4 *)outV)
    );
}

JPH_Mat44 *JPH_Mat44_Transposed(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Transposed());
}

JPH_Mat44 *JPH_Mat44_Transposed3x3(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Transposed3x3());
}

JPH_Mat44 *JPH_Mat44_Inversed(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Inversed());
}

JPH_Mat44 *JPH_Mat44_InversedRotationTranslation(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).InversedRotationTranslation());
}

float JPH_Mat44_GetDeterminant3x3(const JPH_Mat44 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetDeterminant3x3();
}

JPH_Mat44 *JPH_Mat44_Adjointed3x3(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Adjointed3x3());
}

JPH_Mat44 *JPH_Mat44_Inversed3x3(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Inversed3x3());
}

bool JPH_Mat44_SetInversed3x3(JPH_Mat44 *_this, const JPH_Mat44 *inM)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetInversed3x3(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    );
}

JPH_Mat44 *JPH_Mat44_GetRotation(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetRotation());
}

JPH_Mat44 *JPH_Mat44_GetRotationSafe(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetRotationSafe());
}

void JPH_Mat44_SetRotation(JPH_Mat44 *_this, const JPH_Mat44 *inRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Mat44 *)(_this)).SetRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), *(const JPH::Mat44 *)(inRotation))
    );
}

JPH_Quat *JPH_Mat44_GetQuaternion(const JPH_Mat44 *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetQuaternion());
}

JPH_Mat44 *JPH_Mat44_GetDirectionPreservingMatrix(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).GetDirectionPreservingMatrix());
}

JPH_Mat44 *JPH_Mat44_PreTranslated(const JPH_Mat44 *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).PreTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Mat44 *JPH_Mat44_PostTranslated(const JPH_Mat44 *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Mat44 *JPH_Mat44_PreScaled(const JPH_Mat44 *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).PreScaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_Mat44 *JPH_Mat44_PostScaled(const JPH_Mat44 *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).PostScaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_Mat44 *JPH_Mat44_Decompose(const JPH_Mat44 *_this, JPH_Vec3 *outScale)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).Decompose(
        ((outScale ? void() : MRBINDC_THROW("Parameter `outScale` can not be null.", void)), *(JPH::Vec3 *)(outScale))
    ));
}

JPH_Mat44 *JPH_Mat44_ToMat44(const JPH_Mat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Mat44 *)(_this)).ToMat44());
}

JPH_Mat44 *Jolt_mul_float_JPH_Mat44(float inV, const JPH_Mat44 *inM)
{
    return (JPH_Mat44 *)new JPH::Mat44(operator*(
        inV,
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

Jolt_std_ostream *Jolt_print_JPH_Mat44(Jolt_std_ostream *inStream, const JPH_Mat44 *inM)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

