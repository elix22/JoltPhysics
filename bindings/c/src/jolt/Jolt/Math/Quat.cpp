// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Quat.h"

#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Float4.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <iostream>
#include <memory>
#include <stdexcept>


const JPH_Vec4 *JPH_Quat_Get_mValue(const JPH_Quat *_this)
{
    return (const JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).mValue);
}

JPH_Vec4 *JPH_Quat_GetMutable_mValue(JPH_Quat *_this)
{
    return (JPH_Vec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).mValue);
}

JPH_Quat *JPH_Quat_DefaultConstruct(void)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat());
}

JPH_Quat *JPH_Quat_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Quat *)(new JPH::Quat[num_elems]{});
}

const JPH_Quat *JPH_Quat_OffsetPtr(const JPH_Quat *ptr, ptrdiff_t i)
{
    return (const JPH_Quat *)(((const JPH::Quat *)ptr) + i);
}

JPH_Quat *JPH_Quat_OffsetMutablePtr(JPH_Quat *ptr, ptrdiff_t i)
{
    return (JPH_Quat *)(((JPH::Quat *)ptr) + i);
}

JPH_Quat *JPH_Quat_ConstructFromAnother(const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

JPH_Quat *JPH_Quat_Construct_4(float inX, float inY, float inZ, float inW)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat(
        inX,
        inY,
        inZ,
        inW
    ));
}

JPH_Quat *JPH_Quat_Construct_1_JPH_Float4(const JPH_Float4 *inV)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Float4 *)(inV))
    ));
}

JPH_Quat *JPH_Quat_Construct_1_JPH_Vec4(const JPH_Vec4 *inV)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    ));
}

void JPH_Quat_Destroy(const JPH_Quat *_this)
{
    delete ((const JPH::Quat *)_this);
}

void JPH_Quat_DestroyArray(const JPH_Quat *_this)
{
    delete[] ((const JPH::Quat *)_this);
}

JPH_Quat *JPH_Quat_AssignFromAnother(JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS)))
    ));
}

void *Jolt_new_JPH_Quat_size_t(size_t inCount)
{
    return JPH::Quat::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Quat_void_ptr(void *inPointer)
{
    JPH::Quat::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Quat_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Quat::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Quat_size_t(size_t inCount)
{
    return JPH::Quat::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Quat_void_ptr(void *inPointer)
{
    JPH::Quat::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Quat_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Quat::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Quat_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Quat::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Quat::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Quat_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Quat::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Quat::operator delete[](
        inPointer,
        inPlace
    );
}

bool Jolt_equal_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    );
}

bool Jolt_not_equal_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    );
}

bool JPH_Quat_IsClose(const JPH_Quat *_this, const JPH_Quat *inRHS, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).IsClose(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

bool JPH_Quat_IsNormalized(const JPH_Quat *_this, const float *inTolerance)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).IsNormalized(
        (inTolerance ? *inTolerance : static_cast<float>(9.99999974E-6F))
    );
}

bool JPH_Quat_IsNaN(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).IsNaN();
}

float JPH_Quat_GetX(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetX();
}

float JPH_Quat_GetY(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetY();
}

float JPH_Quat_GetZ(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetZ();
}

float JPH_Quat_GetW(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetW();
}

JPH_Vec3 *JPH_Quat_GetXYZ(const JPH_Quat *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetXYZ());
}

JPH_Vec4 *JPH_Quat_GetXYZW(const JPH_Quat *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetXYZW());
}

void JPH_Quat_SetX(JPH_Quat *_this, float inX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).SetX(
        inX
    );
}

void JPH_Quat_SetY(JPH_Quat *_this, float inY)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).SetY(
        inY
    );
}

void JPH_Quat_SetZ(JPH_Quat *_this, float inZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).SetZ(
        inZ
    );
}

void JPH_Quat_SetW(JPH_Quat *_this, float inW)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).SetW(
        inW
    );
}

void JPH_Quat_Set(JPH_Quat *_this, float inX, float inY, float inZ, float inW)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).Set(
        inX,
        inY,
        inZ,
        inW
    );
}

JPH_Quat *JPH_Quat_sZero(void)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sZero());
}

JPH_Quat *JPH_Quat_sIdentity(void)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sIdentity());
}

JPH_Quat *JPH_Quat_sRotation(const JPH_Vec3 *inAxis, float inAngle)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sRotation(
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        inAngle
    ));
}

void JPH_Quat_GetAxisAngle(const JPH_Quat *_this, JPH_Vec3 *outAxis, float *outAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetAxisAngle(
        ((outAxis ? void() : MRBINDC_THROW("Parameter `outAxis` can not be null.", void)), *(JPH::Vec3 *)(outAxis)),
        ((outAngle ? void() : MRBINDC_THROW("Parameter `outAngle` can not be null.", void)), *outAngle)
    );
}

JPH_Quat *JPH_Quat_sFromTo(const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sFromTo(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo))
    ));
}

JPH_Quat *JPH_Quat_sEulerAngles(const JPH_Vec3 *inAngles)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sEulerAngles(
        ((inAngles ? void() : MRBINDC_THROW("Parameter `inAngles` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngles))
    ));
}

JPH_Vec3 *JPH_Quat_GetEulerAngles(const JPH_Quat *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetEulerAngles());
}

float JPH_Quat_LengthSq(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).LengthSq();
}

float JPH_Quat_Length(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).Length();
}

JPH_Quat *JPH_Quat_Normalized(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).Normalized());
}

void JPH_Quat_add_assign(JPH_Quat *_this, const JPH_Quat *inRHS)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).operator+=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    );
}

void JPH_Quat_sub_assign(JPH_Quat *_this, const JPH_Quat *inRHS)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).operator-=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    );
}

void JPH_Quat_mul_assign(JPH_Quat *_this, float inValue)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).operator*=(
        inValue
    );
}

void JPH_Quat_div_assign(JPH_Quat *_this, float inValue)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Quat *)(_this)).operator/=(
        inValue
    );
}

JPH_Quat *Jolt_neg_JPH_Quat(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator-());
}

JPH_Quat *Jolt_add_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator+(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

JPH_Quat *Jolt_sub_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator-(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

JPH_Quat *Jolt_mul_JPH_Quat(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator*(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

JPH_Quat *Jolt_mul_JPH_Quat_float(const JPH_Quat *_this, float inValue)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator*(
        inValue
    ));
}

JPH_Quat *Jolt_div_JPH_Quat_float(const JPH_Quat *_this, float inValue)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator/(
        inValue
    ));
}

JPH_Vec3 *Jolt_mul_JPH_Quat_JPH_Vec3(const JPH_Quat *_this, const JPH_Vec3 *inValue)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).operator*(
        ((inValue ? void() : MRBINDC_THROW("Parameter `inValue` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inValue))
    ));
}

JPH_Quat *JPH_Quat_sMultiplyImaginary(const JPH_Vec3 *inLHS, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sMultiplyImaginary(
        ((inLHS ? void() : MRBINDC_THROW("Parameter `inLHS` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLHS)),
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

JPH_Vec3 *JPH_Quat_InverseRotate(const JPH_Quat *_this, const JPH_Vec3 *inValue)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).InverseRotate(
        ((inValue ? void() : MRBINDC_THROW("Parameter `inValue` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inValue))
    ));
}

JPH_Vec3 *JPH_Quat_RotateAxisX(const JPH_Quat *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).RotateAxisX());
}

JPH_Vec3 *JPH_Quat_RotateAxisY(const JPH_Quat *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).RotateAxisY());
}

JPH_Vec3 *JPH_Quat_RotateAxisZ(const JPH_Quat *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).RotateAxisZ());
}

float JPH_Quat_Dot(const JPH_Quat *_this, const JPH_Quat *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).Dot(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    );
}

JPH_Quat *JPH_Quat_Conjugated(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).Conjugated());
}

JPH_Quat *JPH_Quat_Inversed(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).Inversed());
}

JPH_Quat *JPH_Quat_EnsureWPositive(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).EnsureWPositive());
}

JPH_Quat *JPH_Quat_GetPerpendicular(const JPH_Quat *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetPerpendicular());
}

float JPH_Quat_GetRotationAngle(const JPH_Quat *_this, const JPH_Vec3 *inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetRotationAngle(
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis))
    );
}

JPH_Quat *JPH_Quat_GetTwist(const JPH_Quat *_this, const JPH_Vec3 *inAxis)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetTwist(
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis))
    ));
}

void JPH_Quat_GetSwingTwist(const JPH_Quat *_this, JPH_Quat *outSwing, JPH_Quat *outTwist)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).GetSwingTwist(
        ((outSwing ? void() : MRBINDC_THROW("Parameter `outSwing` can not be null.", void)), *(JPH::Quat *)(outSwing)),
        ((outTwist ? void() : MRBINDC_THROW("Parameter `outTwist` can not be null.", void)), *(JPH::Quat *)(outTwist))
    );
}

JPH_Quat *JPH_Quat_LERP(const JPH_Quat *_this, const JPH_Quat *inDestination, float inFraction)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).LERP(
        ((inDestination ? void() : MRBINDC_THROW("Parameter `inDestination` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inDestination)),
        inFraction
    ));
}

JPH_Quat *JPH_Quat_SLERP(const JPH_Quat *_this, const JPH_Quat *inDestination, float inFraction)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).SLERP(
        ((inDestination ? void() : MRBINDC_THROW("Parameter `inDestination` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inDestination)),
        inFraction
    ));
}

JPH_Quat *JPH_Quat_sLoadFloat3Unsafe(const JPH_Float3 *inV)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sLoadFloat3Unsafe(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Float3 *)(inV))
    ));
}

void JPH_Quat_StoreFloat3(const JPH_Quat *_this, JPH_Float3 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).StoreFloat3(
        ((JPH::Float3 *)outV)
    );
}

void JPH_Quat_StoreFloat4(const JPH_Quat *_this, JPH_Float4 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).StoreFloat4(
        ((JPH::Float4 *)outV)
    );
}

unsigned int JPH_Quat_CompressUnitQuat(const JPH_Quat *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Quat *)(_this)).CompressUnitQuat();
}

JPH_Quat *JPH_Quat_sDecompressUnitQuat(unsigned int inValue)
{
    return (JPH_Quat *)new JPH::Quat(JPH::Quat::sDecompressUnitQuat(
        inValue
    ));
}

JPH_Quat *Jolt_mul_float_JPH_Quat(float inValue, const JPH_Quat *inRHS)
{
    return (JPH_Quat *)new JPH::Quat(operator*(
        inValue,
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRHS))
    ));
}

Jolt_std_ostream *Jolt_print_JPH_Quat(Jolt_std_ostream *inStream, const JPH_Quat *inQ)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inQ ? void() : MRBINDC_THROW("Parameter `inQ` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inQ))
    ));
}

